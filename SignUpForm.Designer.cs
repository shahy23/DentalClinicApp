namespace DentalClinicApp
{
    partial class SignUpForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RoleSign = new ComboBox();
            panel1 = new Panel();
            label9 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            label1 = new Label();
            btnRegister = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            LabelName = new TextBox();
            label6 = new Label();
            txtphone = new TextBox();
            label4 = new Label();
            labelGender = new ComboBox();
            label2 = new Label();
            txtblood = new TextBox();
            label8 = new Label();
            txtSpeciality = new TextBox();
            label5 = new Label();
            DOB = new DateTimePicker();
            label7 = new Label();
            txtcity = new TextBox();
            label11 = new Label();
            txtEmail = new TextBox();
            label10 = new Label();
            txtcountry = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // RoleSign
            // 
            RoleSign.Anchor = AnchorStyles.None;
            RoleSign.BackColor = Color.Snow;
            RoleSign.DropDownStyle = ComboBoxStyle.DropDownList;
            RoleSign.FlatStyle = FlatStyle.Flat;
            RoleSign.ForeColor = Color.Black;
            RoleSign.FormattingEnabled = true;
            RoleSign.Items.AddRange(new object[] { "Patient", "Doctor", "Receptionist" });
            RoleSign.Location = new Point(323, 92);
            RoleSign.Name = "RoleSign";
            RoleSign.Size = new Size(151, 28);
            RoleSign.TabIndex = 0;
            RoleSign.SelectedIndexChanged += RoleSign_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 51);
            panel1.TabIndex = 1;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(283, 9);
            label9.Name = "label9";
            label9.Size = new Size(232, 31);
            label9.TabIndex = 0;
            label9.Text = "Create Your Account";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(112, 352);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 400);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 51);
            panel3.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(11, 9);
            button1.Name = "button1";
            button1.Size = new Size(126, 29);
            button1.TabIndex = 25;
            button1.Text = "Back to Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(701, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(99, 349);
            panel4.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(323, 69);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 14;
            label1.Text = "Select Your Role";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.BackColor = Color.Pink;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegister.Location = new Point(357, 365);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 24;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(LabelName);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(txtphone);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(labelGender);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txtblood);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(txtSpeciality);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(DOB);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(txtcity);
            flowLayoutPanel1.Controls.Add(label11);
            flowLayoutPanel1.Controls.Add(txtEmail);
            flowLayoutPanel1.Controls.Add(label10);
            flowLayoutPanel1.Controls.Add(txtcountry);
            flowLayoutPanel1.Location = new Point(133, 147);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(533, 211);
            flowLayoutPanel1.TabIndex = 27;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label3
            // 
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 16;
            label3.Text = "Name";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelName
            // 
            LabelName.Location = new Point(129, 3);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(121, 27);
            LabelName.TabIndex = 5;
            LabelName.TextChanged += LabelName_TextChanged;
            // 
            // label6
            // 
            label6.Location = new Point(256, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 19;
            label6.Text = "Phone Number";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(382, 3);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(121, 27);
            txtphone.TabIndex = 8;
            txtphone.TextChanged += txtphone_TextChanged;
            // 
            // label4
            // 
            label4.Location = new Point(3, 33);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 17;
            label4.Text = "Gender";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // labelGender
            // 
            labelGender.BackColor = Color.Snow;
            labelGender.DropDownStyle = ComboBoxStyle.DropDownList;
            labelGender.FlatStyle = FlatStyle.Flat;
            labelGender.ForeColor = Color.Black;
            labelGender.FormattingEnabled = true;
            labelGender.Items.AddRange(new object[] { "Male", "Female" });
            labelGender.Location = new Point(129, 36);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(121, 28);
            labelGender.TabIndex = 6;
            // 
            // label2
            // 
            label2.Location = new Point(256, 33);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(120, 20);
            label2.TabIndex = 15;
            label2.Text = "Blood Type";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtblood
            // 
            txtblood.Location = new Point(382, 36);
            txtblood.Name = "txtblood";
            txtblood.Size = new Size(121, 27);
            txtblood.TabIndex = 9;
            // 
            // label8
            // 
            label8.Location = new Point(3, 67);
            label8.Name = "label8";
            label8.Size = new Size(120, 20);
            label8.TabIndex = 21;
            label8.Text = "Speciality";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSpeciality
            // 
            txtSpeciality.Location = new Point(129, 70);
            txtSpeciality.Name = "txtSpeciality";
            txtSpeciality.Size = new Size(121, 27);
            txtSpeciality.TabIndex = 12;
            // 
            // label5
            // 
            label5.Location = new Point(256, 67);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 18;
            label5.Text = "Date Of Birth";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DOB
            // 
            DOB.Location = new Point(382, 70);
            DOB.Name = "DOB";
            DOB.Size = new Size(121, 27);
            DOB.TabIndex = 7;
            // 
            // label7
            // 
            label7.Location = new Point(3, 100);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(120, 20);
            label7.TabIndex = 20;
            label7.Text = "City";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtcity
            // 
            txtcity.Location = new Point(129, 103);
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(121, 27);
            txtcity.TabIndex = 10;
            // 
            // label11
            // 
            label11.Location = new Point(256, 100);
            label11.Name = "label11";
            label11.Size = new Size(120, 20);
            label11.TabIndex = 26;
            label11.Text = "Email";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(382, 103);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(121, 27);
            txtEmail.TabIndex = 25;
            // 
            // label10
            // 
            label10.Location = new Point(3, 133);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 23;
            label10.Text = "Country";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtcountry
            // 
            txtcountry.Location = new Point(129, 136);
            txtcountry.Name = "txtcountry";
            txtcountry.Size = new Size(121, 27);
            txtcountry.TabIndex = 11;
            txtcountry.TextChanged += txtcountry_TextChanged;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 451);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnRegister);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(RoleSign);
            Name = "SignUpForm";
            Text = "PA";
            FormClosed += SignUpForm_FormClosed;
            Load += SignUpForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox RoleSign;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Button btnRegister;
        private Label label9;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private TextBox LabelName;
        private Label label6;
        private TextBox txtphone;
        private Label label10;
        private ComboBox labelGender;
        private DateTimePicker DOB;
        private TextBox txtblood;
        private TextBox txtcity;
        private TextBox txtcountry;
        private TextBox txtSpeciality;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private TextBox txtEmail;
        private Label label11;
    }
}
