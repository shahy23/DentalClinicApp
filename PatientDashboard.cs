using System;
using System.Data;
using System.Windows.Forms;

namespace DentalClinicApp
{
    public partial class PatientDashboard : Form
    {
        public PatientDashboard()
        {
            InitializeComponent();
        }

        private void PatientDashboard_Load(object sender, EventArgs e)
        {

        }

        private void RefreshAllData()
        {
            LoadAvailableAppointments();
            LoadMedicalHistory();
            LoadPrescriptions();
            LoadMyPaymentHistory();
            LoadMyAppointmentIDs();
        }

        private void LoadMyProfileData()
        {
            string query = $@"SELECT P.*, PH.Phone_Number 
                             FROM Patient P 
                             LEFT JOIN Patient_Phone PH ON P.Patient_ID = PH.Patient_ID 
                             WHERE P.Patient_ID = {CurrentUser.UserID}";

            DataTable dt = DBHelper.GetData(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                txtPatientName.Text = dt.Rows[0]["Name"]?.ToString() ?? "";
                txtCity.Text = dt.Rows[0]["City"]?.ToString() ?? "";
                txtBloodType.Text = dt.Rows[0]["Blood_Type"]?.ToString() ?? "";
                txtPhone.Text = dt.Rows[0]["Phone_Number"]?.ToString() ?? "";
                comboGender.Text = dt.Rows[0]["Gender"]?.ToString() ?? "";
                dtpBdatePateint.Value = dt.Rows[0]["Bdate"] != DBNull.Value ? Convert.ToDateTime(dt.Rows[0]["Bdate"]) : DateTime.Now;

                lblWelcome.Text = "Welcome, " + txtPatientName.Text;
            }
        }

        private void LoadAvailableAppointments()
        {
            string query = @"SELECT A.App_ID, A.Date, A.Type, D.Name AS [Doctor] 
                             FROM Appointment A 
                             JOIN Doctor D ON A.Doctor_ID = D.Doctor_ID 
                             WHERE A.Patient_ID IS NULL";
            dgvAvailableApps.DataSource = DBHelper.GetData(query);
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {

        }

        private void LoadMedicalHistory()
        {
            string query = $"SELECT RecordDate, Diagnosis FROM MedicalRecord WHERE Patient_ID = {CurrentUser.UserID} ORDER BY RecordDate DESC";
            dgvMedicalHistory.DataSource = DBHelper.GetData(query);
        }

        private void LoadPrescriptions()
        {
            string query = $@"SELECT P.Date, M.Name, PM.Instruction 
                             FROM Prescription P 
                             JOIN Prescription_Medicine PM ON P.Prescription_ID = PM.Prescription_ID 
                             JOIN Medicine M ON PM.Medicine_ID = M.Medicine_ID 
                             WHERE P.Patient_ID = {CurrentUser.UserID}";
            dgvPrescriptions.DataSource = DBHelper.GetData(query);
        }

        private void LoadMyAppointmentIDs()
        {
            string query = $"SELECT App_ID FROM Appointment WHERE Patient_ID = {CurrentUser.UserID}";
            DataTable dt = DBHelper.GetData(query);
            comboBoxAppIDs.DataSource = dt;
            comboBoxAppIDs.DisplayMember = "App_ID";
            comboBoxAppIDs.ValueMember = "App_ID";
        }

        private void btnProcessPayment_Click(object sender, EventArgs e)
        {

        }

        private void LoadMyPaymentHistory()
        {
            string query = $@"SELECT P.Payment_ID, P.Amount, P.Method, P.PaymentDate 
                             FROM Payment P 
                             JOIN Appointment A ON P.App_ID = A.App_ID 
                             WHERE A.Patient_ID = {CurrentUser.UserID}";
            dgvPaymentHistory.DataSource = DBHelper.GetData(query);
        }

        private void SetFieldsEnabled(bool status)
        {
            txtPatientName.Enabled = status;
            txtCity.Enabled = status;
            txtBloodType.Enabled = status;
            txtPhone.Enabled = status;
            comboGender.Enabled = status;
            dtpBdatePateint.Enabled = status;
        }

        private void btnMyInfo_Click(object sender, EventArgs e) => LoadMyProfileData();
        //private void btnEdit_Click
        private void btnlogout_Click(object sender, EventArgs e) { this.Close(); new LoginForm().Show(); }

        private void PatientDashboard_Load_1(object sender, EventArgs e)
        {

            lblWelcome.Text = "Welcome, " + CurrentUser.UserName;
            SetFieldsEnabled(false);
            RefreshAllData();
            LoadMyProfileData();
        }

        private void btnProcessPayment_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAppIDs.SelectedValue == null) return;
                int appID = Convert.ToInt32(comboBoxAppIDs.SelectedValue);
                decimal amount;
                decimal.TryParse(txtAmount.Text, out amount);
                int payID = new Random().Next(10000, 99999);
                string query = $@"INSERT INTO Payment (Payment_ID, Status, Method, PaymentDate, Amount, App_ID) 
                                 VALUES ({payID}, 'Paid', '{comboBoxMethod.Text}', GETDATE(), {amount}, {appID})";
                DBHelper.SetData(query);
                MessageBox.Show("Payment Successful!");
                txtAmount.Clear();
                RefreshAllData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            SetFieldsEnabled(true);
        }

        private void btnMyInfo_Click_1(object sender, EventArgs e)
        {
            LoadMyProfileData();
        }



        private void btnBookNow_Click_1(object sender, EventArgs e)
        {
            if (dgvAvailableApps.SelectedRows.Count > 0)
            {
                int appID = Convert.ToInt32(dgvAvailableApps.SelectedRows[0].Cells["App_ID"].Value);
                string query = $"UPDATE Appointment SET Patient_ID = {CurrentUser.UserID}, Status = 'Confirmed' WHERE App_ID = {appID}";
                DBHelper.SetData(query);
                MessageBox.Show("Appointment Booked!");
                RefreshAllData();

            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, @"^\d{11}$"))
                {
                    MessageBox.Show("Phone number must be exactly 11 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string bdateStr = dtpBdatePateint.Value.ToString("yyyy-MM-dd");

                string executeProc = $@"EXEC UpdatePatientProfile 
                                @PatientID = {CurrentUser.UserID}, 
                                @Name = '{txtPatientName.Text}', 
                                @City = '{txtCity.Text}', 
                                @BloodType = '{txtBloodType.Text}', 
                                @Gender = '{comboGender.Text}', 
                                @Bdate = '{bdateStr}', 
                                @Phone = '{txtPhone.Text}'";

                DBHelper.SetData(executeProc);

                MessageBox.Show("Success! Profile and Phone Number updated using a Stored Procedure.");

                SetFieldsEnabled(false);
                LoadMyProfileData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}