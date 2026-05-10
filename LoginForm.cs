using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DentalClinicApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;
                LoginLogic login = new LoginLogic();
                string selectedRole = RoleSign.Text;
                string userID = txtID.Text;

                if (login.Authenticate(selectedRole, userID))
                {
                    if (selectedRole == "Receptionist")
                    {
                        // We need to fetch the Receptionist to make sure they exist and save their ID
                        DataTable dt = DBHelper.GetData($"SELECT * FROM Receptionist WHERE Receptionist_ID = {userID}");

                        if (dt != null && dt.Rows.Count > 0)
                        {
                            // Save the logged-in user's data globally so the dashboard can use it!
                            CurrentUser.UserID = Convert.ToInt32(dt.Rows[0]["Receptionist_ID"]);
                            CurrentUser.UserName = dt.Rows[0]["Name"].ToString();
                            CurrentUser.UserRole = "Receptionist";

                            new ReceptionistDashboard().Show();
                            this.Hide();
                        }
                        else
                        {
                            lblError.Visible = true;
                        }
                    }
                    if (selectedRole == "Doctor")
                    {
                        DataTable dt = DBHelper.GetData($"SELECT * FROM Doctor WHERE Doctor_ID = {userID}");
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            CurrentUser.UserID = Convert.ToInt32(dt.Rows[0]["Doctor_ID"]);
                            CurrentUser.UserName = dt.Rows[0]["Name"].ToString();
                            CurrentUser.Speciality = dt.Rows[0]["Speciality"].ToString();
                            CurrentUser.UserRole = "Doctor";

                            new DoctorDashboard().Show();
                            this.Hide();
                        }
                    }
                    else if (selectedRole == "Patient")
                    {
                        DataTable dt = DBHelper.GetData($"SELECT * FROM Patient WHERE Patient_ID = {userID}");
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            CurrentUser.UserID = Convert.ToInt32(dt.Rows[0]["Patient_ID"]);
                            CurrentUser.UserName = dt.Rows[0]["Name"].ToString();
                            CurrentUser.UserRole = "Patient";

                            new PatientDashboard().Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    lblError.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm();
            signup.Show();
            this.Hide();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}