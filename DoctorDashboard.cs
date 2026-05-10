using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DentalClinicApp
{
    public partial class DoctorDashboard : Form
    {
        int selectedAppID = 0;
        int selectedPatientID = 0;
        DataTable dtPrescription = new DataTable();

        public DoctorDashboard()
        {
            InitializeComponent();
        }

        private void DoctorDashboard_Load(object sender, EventArgs e)
        {
            lblDoctorName.Text ="Dr." + CurrentUser.UserName;
            lblSpeciality.Text = "Speciality: " + CurrentUser.Speciality;

            labelPatient.Text = "No Patient Selected";

            SetupPrescriptionTable();
            RefreshAppointments();

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // LOCK the inputs when the dashboard first loads
            SetSessionControlsEnabled(false);
        }

        // --- HELPER METHOD TO LOCK/UNLOCK THE UI ---
        private void SetSessionControlsEnabled(bool isEnabled)
        {
            rtbDiagnosis.Enabled = isEnabled;
            if (rtbTreatment != null) rtbTreatment.Enabled = isEnabled;
            txtMedicineName.Enabled = isEnabled;
            txtDosage.Enabled = isEnabled;

            btnAddPrescription.Enabled = isEnabled;
            btnSaveRecord.Enabled = isEnabled;
        }

        private void RefreshAppointments()
        {
            string query = $@"SELECT A.App_ID, P.Patient_ID, ISNULL(P.Name, '---') AS [Patient Name], A.Date, A.Type, A.Status 
                              FROM Appointment A 
                              LEFT JOIN Patient P ON A.Patient_ID = P.Patient_ID
                              WHERE A.Doctor_ID = {CurrentUser.UserID}
                              ORDER BY A.Date ASC";

            DataTable dt = DBHelper.GetData(query);
            dgvAppointments.DataSource = dt;

            if (dgvAppointments.Columns.Contains("Patient_ID"))
                dgvAppointments.Columns["Patient_ID"].Visible = false;
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                // SAFETY CHECK: Prevent viewing an 'Available' slot with no patient
                if (dgvAppointments.SelectedRows[0].Cells["Patient_ID"].Value == DBNull.Value)
                {
                    MessageBox.Show("This slot doesn't have a patient assigned yet! You cannot start a session.", "No Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                selectedAppID = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["App_ID"].Value);
                selectedPatientID = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["Patient_ID"].Value);
                string pName = dgvAppointments.SelectedRows[0].Cells["Patient Name"].Value.ToString();

                labelPatient.Text = "Patient: " + pName;
                label6.Text = "ID: " + selectedPatientID.ToString();

                LoadPatientHistory(selectedPatientID);

                // UNLOCK the inputs because a valid patient was selected
                SetSessionControlsEnabled(true);

                tabControlDoctor.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Please select a patient from the list first!");
            }
        }

        private void LoadPatientHistory(int pID)
        {
            string query = $@"SELECT RecordDate AS [Date], Diagnosis 
                              FROM MedicalRecord 
                              WHERE Patient_ID = {pID} 
                              ORDER BY RecordDate DESC";

            dataGridView2.DataSource = DBHelper.GetData(query);

            if (dataGridView2.Columns.Count > 0)
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSaveFullSession_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedAppID == 0)
                {
                    MessageBox.Show("No active session to save. Please select a patient first.");
                    return;
                }

                // --- 1. SAVE THE MEDICAL RECORD ---
                int newRecordID = new Random().Next(1000, 9999);

                // Combine Diagnosis and Treatment since the DB only has a Diagnosis column
                string fullDiagnosis = $"Diagnosis: {rtbDiagnosis.Text} | Treatment: {rtbTreatment.Text}";

                string insertRecordQuery = $@"INSERT INTO MedicalRecord (Record_ID, Patient_ID, Diagnosis, RecordDate) 
                                              VALUES ({newRecordID}, {selectedPatientID}, '{fullDiagnosis}', GETDATE())";
                DBHelper.SetData(insertRecordQuery);

                // Link the Medical Record to the specific Appointment in the bridging table
                string insertAppRecord = $"INSERT INTO App_MedicalRecord (App_ID, Record_ID, Patient_ID) VALUES ({selectedAppID}, {newRecordID}, {selectedPatientID})";
                DBHelper.SetData(insertAppRecord);

                // --- 2. SAVE THE PRESCRIPTION (IF ANY MEDICINES WERE ADDED) ---
                if (dtPrescription.Rows.Count > 0)
                {
                    int newPrescriptionID = new Random().Next(1000, 9999);

                    // Create the main Prescription header
                    string insertPrescription = $@"INSERT INTO Prescription (Prescription_ID, Date, Record_ID, Doctor_ID, Patient_ID) 
                                                   VALUES ({newPrescriptionID}, GETDATE(), {newRecordID}, {CurrentUser.UserID}, {selectedPatientID})";
                    DBHelper.SetData(insertPrescription);

                    // Loop through the DataGrid to save each medicine
                    foreach (DataRow row in dtPrescription.Rows)
                    {
                        string medName = row["MedicineName"].ToString();
                        string dosage = row["Dosage"].ToString();
                        int medID = 0;

                        // Check if this medicine already exists in the Medicine table
                        DataTable dtMed = DBHelper.GetData($"SELECT Medicine_ID FROM Medicine WHERE Name = '{medName}'");

                        if (dtMed != null && dtMed.Rows.Count > 0)
                        {
                            // Medicine exists, grab its ID
                            medID = Convert.ToInt32(dtMed.Rows[0]["Medicine_ID"]);
                        }
                        else
                        {
                            // New medicine! Insert it into the Medicine table first
                            medID = new Random().Next(10000, 99999);
                            string insertMed = $"INSERT INTO Medicine (Medicine_ID, Name, Diagnosis) VALUES ({medID}, '{medName}', 'General')";
                            DBHelper.SetData(insertMed);
                        }

                        // Link the Prescription and the Medicine together in the bridging table
                        string insertPM = $@"INSERT INTO Prescription_Medicine (Prescription_ID, Medicine_ID, Quantity, Instruction) 
                                             VALUES ({newPrescriptionID}, {medID}, 1, '{dosage}')";
                        DBHelper.SetData(insertPM);
                    }
                }

                // --- 3. COMPLETE THE APPOINTMENT ---
                string updateQuery = $"UPDATE Appointment SET Status = 'Completed' WHERE App_ID = {selectedAppID}";
                DBHelper.SetData(updateQuery);

                MessageBox.Show("Success! Patient Record and Prescriptions have been saved.", "Session Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset the form for the next patient
                ClearSession();
                RefreshAppointments();
                tabControlDoctor.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving session: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupPrescriptionTable()
        {
            if (dtPrescription.Columns.Count == 0)
            {
                dtPrescription.Columns.Add("MedicineName");
                dtPrescription.Columns.Add("Dosage");
                dgvPrescription.DataSource = dtPrescription;
            }
        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMedicineName.Text) && !string.IsNullOrEmpty(txtDosage.Text))
            {
                dtPrescription.Rows.Add(txtMedicineName.Text, txtDosage.Text);
                txtMedicineName.Clear();
                txtDosage.Clear();
            }
            else
                MessageBox.Show("Please enter Medicine Name and Dosage.");
        }

        private void ClearSession()
        {
            rtbDiagnosis.Clear();
            if (rtbTreatment != null) rtbTreatment.Clear();
            dtPrescription.Rows.Clear();
            labelPatient.Text = "No Patient Selected";
            label6.Text = "ID: --";
            selectedAppID = 0;

            // LOCK the inputs again now that the session is cleared
            SetSessionControlsEnabled(false);
        }

        private void btnRefresh_Click(object sender, EventArgs e) => RefreshAppointments();

        private void btnlogout_Click(object sender, EventArgs e)
        {
            CurrentUser.UserID = 0;
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Hide();
        }

        private void btnSearchHistory_Click(object sender, EventArgs e)
        {
            try
            {
                string query;

                // If the search box is empty, let's just show ALL patient history
                if (string.IsNullOrWhiteSpace(txtSearchHistory.Text))
                {
                    query = $@"SELECT P.Name, M.Diagnosis, M.RecordDate AS [Date] 
                       FROM MedicalRecord M 
                       JOIN Patient P ON M.Patient_ID = P.Patient_ID 
                       ORDER BY M.RecordDate DESC";
                }
                else
                {
                    // If they typed something, search safely by casting the INT to a VARCHAR
                    query = $@"SELECT P.Name, M.Diagnosis, M.RecordDate AS [Date] 
                       FROM MedicalRecord M 
                       JOIN Patient P ON M.Patient_ID = P.Patient_ID 
                       WHERE P.Name LIKE '%{txtSearchHistory.Text}%' 
                          OR CAST(P.Patient_ID AS VARCHAR) LIKE '%{txtSearchHistory.Text}%'
                       ORDER BY M.RecordDate DESC";
                }

                DataTable dt = DBHelper.GetData(query);
                dataGridView2.DataSource = dt;

                // Give the doctor a helpful pop-up if the patient has no history yet!
                if (dt != null && dt.Rows.Count == 0)
                {
                    MessageBox.Show("No medical history found! This patient might be new, or the ID/Name doesn't exist.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // If SQL throws an error, we actually want to see it!
                MessageBox.Show("Search Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblDoctorName_Click(object sender, EventArgs e)
        {

        }
    }
}