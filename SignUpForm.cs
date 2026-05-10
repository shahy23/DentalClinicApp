using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions; // Required for validation

namespace DentalClinicApp
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        // --- REAL-TIME VALIDATION: Prevents typing numbers/symbols in the Name box ---
        private void LabelName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like Backspace), letters, and spaces only.
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // --- REAL-TIME VALIDATION: Prevents typing letters/symbols in the Phone box ---
        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control characters (like Backspace) and digits only.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationManager reg = new RegistrationManager();
            string role = RoleSign.Text;

            try
            {
                int generatedID = 0;

                // --- 1. GENERAL VALIDATION (Applies to everyone) ---

                // Validate Name: Must not be empty, only letters and spaces allowed
                if (string.IsNullOrWhiteSpace(LabelName.Text) || !Regex.IsMatch(LabelName.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Please enter a valid name using only letters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- 2. ROLE-SPECIFIC VALIDATION ---

                if (role == "Patient")
                {
                    // Validate Phone: Exactly 11 digits
                    if (!Regex.IsMatch(txtphone.Text, @"^\d{11}$"))
                    {
                        MessageBox.Show("Phone number must be exactly 11 digits.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validate Blood Type: Standard types (A+, O-, AB+, etc.)
                    if (!Regex.IsMatch(txtblood.Text, @"^(A|B|AB|O)[+-]$", RegexOptions.IgnoreCase))
                    {
                        MessageBox.Show("Please enter a valid blood type (e.g., A+, O-, AB+).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (role == "Doctor" || role == "Receptionist")
                {
                    // Validate Email format
                    if (string.IsNullOrWhiteSpace(txtEmail.Text) || !Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    {
                        MessageBox.Show("Please enter a valid email address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // --- 3. REGISTRATION EXECUTION ---

                if (role == "Patient")
                {
                    generatedID = reg.RegisterPatient(LabelName.Text, labelGender.Text, DOB.Value, txtcity.Text, txtcountry.Text, txtblood.Text, txtphone.Text);
                }
                else if (role == "Doctor")
                {
                    generatedID = reg.RegisterDoctor(LabelName.Text, labelGender.Text, txtSpeciality.Text, txtEmail.Text);
                }
                else if (role == "Receptionist")
                {
                    generatedID = reg.RegisterReceptionist(LabelName.Text, labelGender.Text, DOB.Value, txtEmail.Text);
                }

                // Success/Error Output
                if (generatedID > 0)
                {
                    MessageBox.Show($"Registration Successful!\n\nYour Login ID is: {generatedID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RoleSign_SelectedIndexChanged(object sender, EventArgs e)
        {
            string role = RoleSign.Text;

            LabelName.Visible = label3.Visible = true;
            labelGender.Visible = label4.Visible = true;

            bool isPatient = (role == "Patient");
            DOB.Visible = label5.Visible = isPatient;
            txtphone.Visible = label6.Visible = isPatient;
            txtblood.Visible = label2.Visible = isPatient;
            txtcity.Visible = label7.Visible = isPatient;
            txtcountry.Visible = label10.Visible = isPatient;

            bool isDoctor = (role == "Doctor");
            txtSpeciality.Visible = label8.Visible = isDoctor;

            bool isReceptionist = (role == "Receptionist");
            if (isReceptionist)
            {
                DOB.Visible = label5.Visible = true;
            }
            txtEmail.Visible = (isDoctor || isReceptionist);
            label11.Visible = (isDoctor || isReceptionist);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm Login = new LoginForm();
            Login.Show();
            this.Hide();
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtcountry_TextChanged(object sender, EventArgs e)
        {
            // Check if there is anything in the text box that is NOT a letter or space
            if (System.Text.RegularExpressions.Regex.IsMatch(LabelName.Text, @"[^a-zA-Z\s]"))
            {
                // Replace all the bad characters with nothing (effectively deleting them)
                LabelName.Text = System.Text.RegularExpressions.Regex.Replace(LabelName.Text, @"[^a-zA-Z\s]", "");

                // Move the typing cursor back to the end of the word so it doesn't jump to the beginning
                LabelName.SelectionStart = LabelName.Text.Length;
            }
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
        }

        private void LabelName_TextChanged(object sender, EventArgs e)
        {
            // Check if there is anything in the text box that is NOT a letter or space
            if (System.Text.RegularExpressions.Regex.IsMatch(LabelName.Text, @"[^a-zA-Z\s]"))
            {
                // Replace all the bad characters with nothing (effectively deleting them)
                LabelName.Text = System.Text.RegularExpressions.Regex.Replace(LabelName.Text, @"[^a-zA-Z\s]", "");

                // Move the typing cursor back to the end of the word so it doesn't jump to the beginning
                LabelName.SelectionStart = LabelName.Text.Length;
            }
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            // Check if there is anything that is NOT a digit
            if (System.Text.RegularExpressions.Regex.IsMatch(txtphone.Text, @"[^0-9]"))
            {
                // Replace all non-digits with nothing
                txtphone.Text = System.Text.RegularExpressions.Regex.Replace(txtphone.Text, @"[^0-9]", "");
                txtphone.SelectionStart = txtphone.Text.Length;
            }
        }
    }
}