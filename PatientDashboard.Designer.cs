namespace DentalClinicApp
{
    partial class PatientDashboard
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
            panel1 = new Panel();
            btnlogout = new Button();
            lblWelcome = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnBookNow = new Button();
            dgvAvailableApps = new DataGridView();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvPrescriptions = new DataGridView();
            dgvMyPrescriptions = new Label();
            dgvMedicalHistory = new DataGridView();
            label2 = new Label();
            tabPage3 = new TabPage();
            label5 = new Label();
            dgvPaymentHistory = new DataGridView();
            groupBox1 = new GroupBox();
            btnProcessPayment = new Button();
            label4 = new Label();
            comboBoxMethod = new ComboBox();
            txtAmount = new TextBox();
            label3 = new Label();
            comboMyAppointments = new Label();
            comboBoxAppIDs = new ComboBox();
            tabPage4 = new TabPage();
            dtpBdatePateint = new DateTimePicker();
            btnMyInfo = new Button();
            btnEdit = new Button();
            label7 = new Label();
            comboGender = new ComboBox();
            btnUpdate = new Button();
            txtPhone = new TextBox();
            label11 = new Label();
            labellll = new Label();
            txtBloodType = new TextBox();
            txtCity = new TextBox();
            txtPatientName = new TextBox();
            label8 = new Label();
            label = new Label();
            label6 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableApps).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedicalHistory).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentHistory).BeginInit();
            groupBox1.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(lblWelcome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 51);
            panel1.TabIndex = 0;
            // 
            // btnlogout
            // 
            btnlogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnlogout.BackColor = Color.Firebrick;
            btnlogout.Cursor = Cursors.Hand;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.White;
            btnlogout.Location = new Point(672, 12);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(94, 29);
            btnlogout.TabIndex = 3;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(22, 13);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(123, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "PatientName";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Cursor = Cursors.Hand;
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 51);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 400);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnBookNow);
            tabPage1.Controls.Add(dgvAvailableApps);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 367);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Booking";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBookNow
            // 
            btnBookNow.Anchor = AnchorStyles.Bottom;
            btnBookNow.BackColor = Color.Pink;
            btnBookNow.ForeColor = Color.Black;
            btnBookNow.Location = new Point(295, 289);
            btnBookNow.Name = "btnBookNow";
            btnBookNow.Size = new Size(207, 29);
            btnBookNow.TabIndex = 2;
            btnBookNow.Text = "Book now";
            btnBookNow.UseVisualStyleBackColor = false;
            btnBookNow.Click += btnBookNow_Click_1;
            // 
            // dgvAvailableApps
            // 
            dgvAvailableApps.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAvailableApps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailableApps.BackgroundColor = Color.White;
            dgvAvailableApps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableApps.Location = new Point(6, 27);
            dgvAvailableApps.Name = "dgvAvailableApps";
            dgvAvailableApps.RowHeadersWidth = 51;
            dgvAvailableApps.Size = new Size(757, 259);
            dgvAvailableApps.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(228, 20);
            label1.TabIndex = 0;
            label1.Text = "Available Appointments in Clinic:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvPrescriptions);
            tabPage2.Controls.Add(dgvMyPrescriptions);
            tabPage2.Controls.Add(dgvMedicalHistory);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 367);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Medical Records & History";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPrescriptions
            // 
            dgvPrescriptions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvPrescriptions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescriptions.BackgroundColor = Color.White;
            dgvPrescriptions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrescriptions.Location = new Point(421, 27);
            dgvPrescriptions.Name = "dgvPrescriptions";
            dgvPrescriptions.RowHeadersWidth = 51;
            dgvPrescriptions.Size = new Size(365, 320);
            dgvPrescriptions.TabIndex = 3;
            // 
            // dgvMyPrescriptions
            // 
            dgvMyPrescriptions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvMyPrescriptions.AutoSize = true;
            dgvMyPrescriptions.Location = new Point(421, 3);
            dgvMyPrescriptions.Name = "dgvMyPrescriptions";
            dgvMyPrescriptions.Size = new Size(198, 20);
            dgvMyPrescriptions.TabIndex = 2;
            dgvMyPrescriptions.Text = "My Prescriptions (Medicines)";
            // 
            // dgvMedicalHistory
            // 
            dgvMedicalHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvMedicalHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicalHistory.BackgroundColor = Color.White;
            dgvMedicalHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicalHistory.Location = new Point(6, 27);
            dgvMedicalHistory.Name = "dgvMedicalHistory";
            dgvMedicalHistory.RowHeadersWidth = 51;
            dgvMedicalHistory.Size = new Size(365, 320);
            dgvMedicalHistory.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 3);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 0;
            label2.Text = "My Diagnosis History";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(dgvPaymentHistory);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 367);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Payments";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(505, 11);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 3;
            label5.Text = "Payment History";
            label5.Click += label5_Click;
            // 
            // dgvPaymentHistory
            // 
            dgvPaymentHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvPaymentHistory.BackgroundColor = Color.White;
            dgvPaymentHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaymentHistory.Location = new Point(351, 33);
            dgvPaymentHistory.Name = "dgvPaymentHistory";
            dgvPaymentHistory.RowHeadersWidth = 51;
            dgvPaymentHistory.Size = new Size(406, 318);
            dgvPaymentHistory.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnProcessPayment);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxMethod);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboMyAppointments);
            groupBox1.Controls.Add(comboBoxAppIDs);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(75, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 291);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pay for Appointment";
            // 
            // btnProcessPayment
            // 
            btnProcessPayment.BackColor = Color.Pink;
            btnProcessPayment.FlatStyle = FlatStyle.Flat;
            btnProcessPayment.Location = new Point(33, 256);
            btnProcessPayment.Name = "btnProcessPayment";
            btnProcessPayment.Size = new Size(155, 29);
            btnProcessPayment.TabIndex = 5;
            btnProcessPayment.Text = "Process Payment";
            btnProcessPayment.UseVisualStyleBackColor = false;
            btnProcessPayment.Click += btnProcessPayment_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 159);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 4;
            label4.Text = "Payment Method:";
            // 
            // comboBoxMethod
            // 
            comboBoxMethod.FormattingEnabled = true;
            comboBoxMethod.Items.AddRange(new object[] { "Visa", "Cash" });
            comboBoxMethod.Location = new Point(10, 181);
            comboBoxMethod.Name = "comboBoxMethod";
            comboBoxMethod.Size = new Size(151, 28);
            comboBoxMethod.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(11, 129);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(151, 27);
            txtAmount.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 107);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 2;
            label3.Text = "Amount to Pay:";
            // 
            // comboMyAppointments
            // 
            comboMyAppointments.AutoSize = true;
            comboMyAppointments.Location = new Point(10, 52);
            comboMyAppointments.Name = "comboMyAppointments";
            comboMyAppointments.Size = new Size(152, 20);
            comboMyAppointments.TabIndex = 1;
            comboMyAppointments.Text = "Select Appointment:";
            // 
            // comboBoxAppIDs
            // 
            comboBoxAppIDs.FormattingEnabled = true;
            comboBoxAppIDs.Location = new Point(10, 75);
            comboBoxAppIDs.Name = "comboBoxAppIDs";
            comboBoxAppIDs.Size = new Size(151, 28);
            comboBoxAppIDs.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dtpBdatePateint);
            tabPage4.Controls.Add(btnMyInfo);
            tabPage4.Controls.Add(btnEdit);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(comboGender);
            tabPage4.Controls.Add(btnUpdate);
            tabPage4.Controls.Add(txtPhone);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(labellll);
            tabPage4.Controls.Add(txtBloodType);
            tabPage4.Controls.Add(txtCity);
            tabPage4.Controls.Add(txtPatientName);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(label9);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(792, 367);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "MyAcount";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dtpBdatePateint
            // 
            dtpBdatePateint.Anchor = AnchorStyles.None;
            dtpBdatePateint.Location = new Point(488, 83);
            dtpBdatePateint.Name = "dtpBdatePateint";
            dtpBdatePateint.Size = new Size(250, 27);
            dtpBdatePateint.TabIndex = 27;
            // 
            // btnMyInfo
            // 
            btnMyInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMyInfo.BackColor = Color.Pink;
            btnMyInfo.FlatStyle = FlatStyle.Flat;
            btnMyInfo.Location = new Point(658, 17);
            btnMyInfo.Name = "btnMyInfo";
            btnMyInfo.Size = new Size(74, 29);
            btnMyInfo.TabIndex = 26;
            btnMyInfo.Text = "My Info";
            btnMyInfo.UseVisualStyleBackColor = false;
            btnMyInfo.Click += btnMyInfo_Click_1;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom;
            btnEdit.BackColor = Color.Pink;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(456, 283);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(45, 29);
            btnEdit.TabIndex = 25;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click_1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(482, 125);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 23;
            label7.Text = "Gender";
            // 
            // comboGender
            // 
            comboGender.Anchor = AnchorStyles.None;
            comboGender.FormattingEnabled = true;
            comboGender.Items.AddRange(new object[] { "Male", "Female" });
            comboGender.Location = new Point(482, 149);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(165, 28);
            comboGender.TabIndex = 22;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom;
            btnUpdate.BackColor = Color.Pink;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(285, 283);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(151, 29);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update My Info";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.Location = new Point(229, 219);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(151, 27);
            txtPhone.TabIndex = 20;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(229, 196);
            label11.Name = "label11";
            label11.Size = new Size(104, 20);
            label11.TabIndex = 19;
            label11.Text = "PhoneNumber";
            // 
            // labellll
            // 
            labellll.Anchor = AnchorStyles.None;
            labellll.AutoSize = true;
            labellll.Location = new Point(481, 61);
            labellll.Name = "labellll";
            labellll.Size = new Size(94, 20);
            labellll.TabIndex = 18;
            labellll.Text = "Birth of Date";
            // 
            // txtBloodType
            // 
            txtBloodType.Anchor = AnchorStyles.None;
            txtBloodType.Location = new Point(482, 219);
            txtBloodType.Name = "txtBloodType";
            txtBloodType.Size = new Size(165, 27);
            txtBloodType.TabIndex = 16;
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.None;
            txtCity.Location = new Point(229, 149);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 15;
            // 
            // txtPatientName
            // 
            txtPatientName.Anchor = AnchorStyles.None;
            txtPatientName.Location = new Point(229, 85);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(125, 27);
            txtPatientName.TabIndex = 14;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(496, 196);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 13;
            label8.Text = "BloodType";
            // 
            // label
            // 
            label.Anchor = AnchorStyles.None;
            label.AutoSize = true;
            label.Location = new Point(229, 125);
            label.Name = "label";
            label.Size = new Size(34, 20);
            label.TabIndex = 12;
            label.Text = "City";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(229, 61);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 11;
            label6.Text = "Name";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(285, 12);
            label9.Name = "label9";
            label9.Size = new Size(197, 31);
            label9.TabIndex = 10;
            label9.Text = "Account Settings";
            // 
            // PatientDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 451);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PatientDashboard";
            Text = "PatientDashboard";
            Load += PatientDashboard_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableApps).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescriptions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedicalHistory).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPaymentHistory).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblWelcome;
        private Button btnlogout;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnBookNow;
        private DataGridView dgvAvailableApps;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dgvPrescriptions;
        private Label dgvMyPrescriptions;
        private DataGridView dgvMedicalHistory;
        private Label label2;
        private GroupBox groupBox1;
        private Label comboMyAppointments;
        private ComboBox comboBoxAppIDs;
        private Button btnProcessPayment;
        private Label label4;
        private ComboBox comboBoxMethod;
        private TextBox txtAmount;
        private Label label3;
        private DataGridView dgvPaymentHistory;
        private Label label5;
        private TabPage tabPage4;
        private TextBox txtPhone;
        private Label label11;
        private Label labellll;
        private ComboBox dtpBdate;
        private TextBox txtBloodType;
        private TextBox txtCity;
        private TextBox txtPatientName;
        private Label label8;
        private Label label;
        private Label label6;
        private Label label9;
        private Button btnUpdate;
        private Button btnEdit;
        private Label label7;
        private ComboBox comboGender;
        private Button btnMyInfo;
        private DateTimePicker dtpBdatePateint;
    }
}