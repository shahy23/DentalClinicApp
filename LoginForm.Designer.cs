namespace DentalClinicApp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            panel5 = new Panel();
            lblError = new Label();
            label3 = new Label();
            label2 = new Label();
            textID = new Label();
            RoleSign = new ComboBox();
            txtID = new TextBox();
            btnLogin = new Button();
            btnSignUp = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.Snow;
            panel5.Controls.Add(lblError);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(textID);
            panel5.Controls.Add(RoleSign);
            panel5.Controls.Add(txtID);
            panel5.Controls.Add(btnLogin);
            panel5.Controls.Add(btnSignUp);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(100, 50);
            panel5.Name = "panel5";
            panel5.Size = new Size(600, 350);
            panel5.TabIndex = 4;
            panel5.Paint += panel5_Paint;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(209, 241);
            lblError.Name = "lblError";
            lblError.Size = new Size(208, 17);
            lblError.TabIndex = 8;
            lblError.Text = "Invalid ID or Role, please try again";
            lblError.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(227, 15);
            label3.Name = "label3";
            label3.Size = new Size(132, 31);
            label3.TabIndex = 7;
            label3.Text = "Login Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 98);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 6;
            label2.Text = "Select Your Role";
            // 
            // textID
            // 
            textID.AutoSize = true;
            textID.Location = new Point(209, 188);
            textID.Name = "textID";
            textID.Size = new Size(95, 20);
            textID.TabIndex = 5;
            textID.Text = "Enter Your ID";
            // 
            // RoleSign
            // 
            RoleSign.BackColor = Color.Snow;
            RoleSign.DropDownStyle = ComboBoxStyle.DropDownList;
            RoleSign.FlatStyle = FlatStyle.Flat;
            RoleSign.FormattingEnabled = true;
            RoleSign.Items.AddRange(new object[] { "Patient", "Doctor", "Receptionist" });
            RoleSign.Location = new Point(210, 121);
            RoleSign.Name = "RoleSign";
            RoleSign.Size = new Size(185, 28);
            RoleSign.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(209, 211);
            txtID.Name = "txtID";
            txtID.Size = new Size(208, 27);
            txtID.TabIndex = 3;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Pink;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(211, 280);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(184, 29);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Pink;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(210, 315);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(185, 29);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "New User? Create Account";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.HotPink;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 50);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(687, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(421, 38);
            label1.TabIndex = 1;
            label1.Text = "Your Healthy Smile Starts Here";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Snow;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(700, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(100, 400);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Snow;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(100, 400);
            panel4.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Snow;
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(100, 400);
            panel6.Name = "panel6";
            panel6.Size = new Size(600, 50);
            panel6.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private ComboBox RoleSign;
        private TextBox txtID;
        private Button btnLogin;
        private Button btnSignUp;
        private Label textID;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label lblError;
        private PictureBox pictureBox1;
    }
}