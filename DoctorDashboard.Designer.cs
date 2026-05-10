namespace DentalClinicApp
{
    partial class DoctorDashboard
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
            lblSpeciality = new Label();
            lblDoctorName = new Label();
            tabControlDoctor = new TabControl();
            tabPage1 = new TabPage();
            btnview = new Button();
            btnRefresh = new Button();
            dgvAppointments = new DataGridView();
            tabPage2 = new TabPage();
            labelPatient = new Label();
            label6 = new Label();
            btnSaveRecord = new Button();
            dgvPrescription = new DataGridView();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            btnAddPrescription = new Button();
            txtDosage = new TextBox();
            txtMedicineName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            rtbTreatment = new RichTextBox();
            rtbDiagnosis = new RichTextBox();
            tabPage3 = new TabPage();
            btnSearchHistory = new Button();
            txtSearchHistory = new TextBox();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            panel1.SuspendLayout();
            tabControlDoctor.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescription).BeginInit();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(lblSpeciality);
            panel1.Controls.Add(lblDoctorName);
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
            btnlogout.Location = new Point(669, 11);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(94, 29);
            btnlogout.TabIndex = 2;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // lblSpeciality
            // 
            lblSpeciality.AutoSize = true;
            lblSpeciality.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpeciality.ForeColor = Color.White;
            lblSpeciality.Location = new Point(214, 21);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Size = new Size(75, 20);
            lblSpeciality.TabIndex = 1;
            lblSpeciality.Text = "Speciality";
            // 
            // lblDoctorName
            // 
            lblDoctorName.AutoSize = true;
            lblDoctorName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoctorName.ForeColor = Color.White;
            lblDoctorName.Location = new Point(11, 0);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new Size(193, 38);
            lblDoctorName.TabIndex = 0;
            lblDoctorName.Text = "Doctor Name";
            lblDoctorName.Click += lblDoctorName_Click;
            // 
            // tabControlDoctor
            // 
            tabControlDoctor.Controls.Add(tabPage1);
            tabControlDoctor.Controls.Add(tabPage2);
            tabControlDoctor.Controls.Add(tabPage3);
            tabControlDoctor.Dock = DockStyle.Fill;
            tabControlDoctor.Location = new Point(0, 51);
            tabControlDoctor.Name = "tabControlDoctor";
            tabControlDoctor.SelectedIndex = 0;
            tabControlDoctor.Size = new Size(800, 400);
            tabControlDoctor.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnview);
            tabPage1.Controls.Add(btnRefresh);
            tabPage1.Controls.Add(dgvAppointments);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 367);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Appoinment";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnview
            // 
            btnview.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnview.BackColor = Color.Pink;
            btnview.Cursor = Cursors.Hand;
            btnview.FlatStyle = FlatStyle.Flat;
            btnview.Location = new Point(3, 335);
            btnview.Name = "btnview";
            btnview.Size = new Size(94, 29);
            btnview.TabIndex = 2;
            btnview.Text = "View";
            btnview.UseVisualStyleBackColor = false;
            btnview.Click += btnview_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRefresh.BackColor = Color.Pink;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(115, 335);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvAppointments
            // 
            dgvAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.BackgroundColor = Color.White;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(0, 5);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(784, 324);
            dgvAppointments.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(labelPatient);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(btnSaveRecord);
            tabPage2.Controls.Add(dgvPrescription);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(rtbTreatment);
            tabPage2.Controls.Add(rtbDiagnosis);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 367);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Diagnosis & Treatment";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelPatient
            // 
            labelPatient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPatient.AutoSize = true;
            labelPatient.Location = new Point(575, 3);
            labelPatient.Name = "labelPatient";
            labelPatient.Size = new Size(106, 20);
            labelPatient.TabIndex = 8;
            labelPatient.Text = "Current Patient";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(309, 187);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 7;
            label6.Text = "Prescription";
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveRecord.BackColor = Color.Pink;
            btnSaveRecord.Cursor = Cursors.Hand;
            btnSaveRecord.FlatStyle = FlatStyle.Flat;
            btnSaveRecord.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveRecord.Location = new Point(618, 309);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new Size(149, 35);
            btnSaveRecord.TabIndex = 6;
            btnSaveRecord.Text = "Save";
            btnSaveRecord.UseVisualStyleBackColor = false;
            btnSaveRecord.Click += btnSaveFullSession_Click;
            // 
            // dgvPrescription
            // 
            dgvPrescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPrescription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrescription.BackgroundColor = Color.White;
            dgvPrescription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrescription.Location = new Point(309, 208);
            dgvPrescription.Name = "dgvPrescription";
            dgvPrescription.RowHeadersWidth = 51;
            dgvPrescription.Size = new Size(261, 135);
            dgvPrescription.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnAddPrescription);
            groupBox1.Controls.Add(txtDosage);
            groupBox1.Controls.Add(txtMedicineName);
            groupBox1.Location = new Point(15, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 135);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prescription Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 59);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 4;
            label5.Text = "Dosage:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 29);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 3;
            label4.Text = "Medicine Name:";
            // 
            // btnAddPrescription
            // 
            btnAddPrescription.BackColor = Color.Pink;
            btnAddPrescription.FlatStyle = FlatStyle.Flat;
            btnAddPrescription.Location = new Point(42, 100);
            btnAddPrescription.Name = "btnAddPrescription";
            btnAddPrescription.Size = new Size(179, 29);
            btnAddPrescription.TabIndex = 2;
            btnAddPrescription.Text = "Add to Prescription";
            btnAddPrescription.UseVisualStyleBackColor = false;
            btnAddPrescription.Click += btnAddPrescription_Click;
            // 
            // txtDosage
            // 
            txtDosage.Location = new Point(129, 55);
            txtDosage.Name = "txtDosage";
            txtDosage.Size = new Size(139, 27);
            txtDosage.TabIndex = 1;
            // 
            // txtMedicineName
            // 
            txtMedicineName.Location = new Point(129, 21);
            txtMedicineName.Name = "txtMedicineName";
            txtMedicineName.Size = new Size(139, 27);
            txtMedicineName.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(309, 3);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "Treatment";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(15, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "Diagnosis";
            // 
            // rtbTreatment
            // 
            rtbTreatment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbTreatment.Location = new Point(309, 23);
            rtbTreatment.Name = "rtbTreatment";
            rtbTreatment.Size = new Size(260, 160);
            rtbTreatment.TabIndex = 1;
            rtbTreatment.Text = "";
            // 
            // rtbDiagnosis
            // 
            rtbDiagnosis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            rtbDiagnosis.Location = new Point(15, 23);
            rtbDiagnosis.Name = "rtbDiagnosis";
            rtbDiagnosis.Size = new Size(274, 163);
            rtbDiagnosis.TabIndex = 0;
            rtbDiagnosis.Text = "";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnSearchHistory);
            tabPage3.Controls.Add(txtSearchHistory);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 367);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Patient History";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSearchHistory
            // 
            btnSearchHistory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchHistory.BackColor = Color.Pink;
            btnSearchHistory.Cursor = Cursors.Hand;
            btnSearchHistory.FlatStyle = FlatStyle.Flat;
            btnSearchHistory.Location = new Point(673, 5);
            btnSearchHistory.Name = "btnSearchHistory";
            btnSearchHistory.Size = new Size(78, 29);
            btnSearchHistory.TabIndex = 3;
            btnSearchHistory.Text = "Search";
            btnSearchHistory.UseVisualStyleBackColor = false;
            btnSearchHistory.Click += btnSearchHistory_Click;
            // 
            // txtSearchHistory
            // 
            txtSearchHistory.Location = new Point(222, 9);
            txtSearchHistory.Name = "txtSearchHistory";
            txtSearchHistory.Size = new Size(125, 27);
            txtSearchHistory.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 20);
            label1.TabIndex = 1;
            label1.Text = "Search by Patient Name or ID:";
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(10, 40);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(741, 307);
            dataGridView2.TabIndex = 0;
            // 
            // DoctorDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(800, 451);
            Controls.Add(tabControlDoctor);
            Controls.Add(panel1);
            Name = "DoctorDashboard";
            Text = "DoctorDashboard";
            Load += DoctorDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControlDoctor.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrescription).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDoctorName;
        private Label lblSpeciality;
        private Button btnlogout;
        private TabControl tabControlDoctor;
        private TabPage tabPage1;
        private Button btnRefresh;
        private DataGridView dgvAppointments;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnview;
        private DataGridView dataGridView2;
        private Button btnSearchHistory;
        private TextBox txtSearchHistory;
        private Label label1;
        private RichTextBox rtbDiagnosis;
        private Label label2;
        private RichTextBox rtbTreatment;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtDosage;
        private TextBox txtMedicineName;
        private Button btnSaveRecord;
        private DataGridView dgvPrescription;
        private Label label5;
        private Label label4;
        private Button btnAddPrescription;
        private Label label6;
        private Label labelPatient;
    }
}