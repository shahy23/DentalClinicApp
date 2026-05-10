using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DentalClinicApp
{
    public partial class ReceptionistDashboard : Form
    {
        public ReceptionistDashboard()
        {
            InitializeComponent();
        }


        private void RefreshGrid()
        {
            string query = @"SELECT A.App_ID AS [ID], 
                            D.Name AS [Doctor Name], 
                            A.Date AS [Appointment Date], 
                            A.Type AS [Type],
                            A.Waiting_No AS [Waiting No],
                            A.Status AS [Status] 
                     FROM Appointment A 
                     JOIN Doctor D ON A.Doctor_ID = D.Doctor_ID";

            dataGridView1.DataSource = DBHelper.GetData(query);
        }

        private void LoadPayments()
        {
            string query = @"SELECT P.Payment_ID AS [Receipt ID], 
                            Pat.Name AS [Patient Name], 
                            A.Date AS [Appointment Date], 
                            P.Amount AS [Amount Paid], 
                            P.Method AS [Payment Method]
                     FROM Payment P
                     JOIN Appointment A ON P.App_ID = A.App_ID
                     JOIN Patient Pat ON A.Patient_ID = Pat.Patient_ID";

            DataTable dt = DBHelper.GetData(query);
            gridPayments.DataSource = dt;

            decimal total = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row["Amount Paid"] != DBNull.Value)
                    total += Convert.ToDecimal(row["Amount Paid"]);
            }

            label7.Text = "Total Revenue: " + total.ToString() + " EGP";
        }


        private void ReceptionistDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                string doctorQuery = "SELECT Doctor_ID, Name FROM Doctor";
                DataTable dtDoctors = DBHelper.GetData(doctorQuery);

                comboBoxDoctors.DataSource = dtDoctors;
                comboBoxDoctors.DisplayMember = "Name";
                comboBoxDoctors.ValueMember = "Doctor_ID";

                RefreshGrid();
                LoadPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                LoadPayments();
            }
            else if (tabControl1.SelectedTab == tabPage1)
            {
                RefreshGrid();
            }
        }

        
        // Insert into the table
        private void btnAddSlot_Click(object sender, EventArgs e)
        {
            try
            {
                // --- 1. VALIDATION ---
                if (string.IsNullOrWhiteSpace(comboType.Text))
                {
                    MessageBox.Show("Please select or enter an Appointment Type before adding a slot.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- 2. EXECUTION ---
                int docID = Convert.ToInt32(comboBoxDoctors.SelectedValue);
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string type = comboType.Text;
                int waiting = (int)numWaiting.Value;

                // Grab the currently logged-in Receptionist's ID
                int recID = CurrentUser.UserID;

                RegistrationManager reg = new RegistrationManager();
                int nextID = reg.GetNextID("Appointment", "App_ID");

                // Add Receptionist_ID to the columns, and {recID} to the values
                string sql = $"INSERT INTO Appointment (App_ID, Date, Type, Status, Waiting_No, Doctor_ID, Receptionist_ID) " +
                             $"VALUES ({nextID}, '{date}', '{type}', 'Available', {waiting}, {docID}, {recID})";

                DBHelper.SetData(sql);
                RefreshGrid();

                comboType.SelectedIndex = -1;
                comboType.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Delete From table
        private void btnDeleteSlot_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int appId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete this slot?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string sql = $"DELETE FROM Appointment WHERE App_ID = {appId}";
                    DBHelper.SetData(sql);
                    RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a slot from the table first.");
            }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Hide();
        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}