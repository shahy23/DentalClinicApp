namespace DentalClinicApp
{
    partial class ReceptionistDashboard
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnlogout = new Button();
            numWaiting = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            comboType = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnDeleteSlot = new Button();
            dataGridView1 = new DataGridView();
            btnAddSlot = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBoxDoctors = new ComboBox();
            tabPage2 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            gridPayments = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numWaiting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPayments).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 38);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(4, 7);
            label3.Name = "label3";
            label3.Size = new Size(223, 25);
            label3.TabIndex = 0;
            label3.Text = "Receptionist Dashboard";
            label3.Click += label3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tabControl1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 38);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 300);
            panel2.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(700, 300);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(numWaiting);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(comboType);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnDeleteSlot);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(btnAddSlot);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(comboBoxDoctors);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(692, 272);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage Slot";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.Firebrick;
            btnlogout.Cursor = Cursors.Hand;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogout.ForeColor = Color.White;
            btnlogout.Location = new Point(614, 10);
            btnlogout.Margin = new Padding(3, 2, 3, 2);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(82, 22);
            btnlogout.TabIndex = 12;
            btnlogout.Text = "Log Out";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // numWaiting
            // 
            numWaiting.Location = new Point(555, 22);
            numWaiting.Margin = new Padding(3, 2, 3, 2);
            numWaiting.Name = "numWaiting";
            numWaiting.Size = new Size(131, 23);
            numWaiting.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(555, 5);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 10;
            label5.Text = "Waiting_No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(393, 4);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 9;
            label4.Text = "Appoinment Type";
            // 
            // comboType
            // 
            comboType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboType.FormattingEnabled = true;
            comboType.Items.AddRange(new object[] { "Checkup", "Surgery", "Follow-up" });
            comboType.Location = new Point(390, 22);
            comboType.Margin = new Padding(3, 2, 3, 2);
            comboType.Name = "comboType";
            comboType.Size = new Size(133, 23);
            comboType.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 5);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 6;
            label2.Text = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 5);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 5;
            label1.Text = "Doctor Name";
            // 
            // btnDeleteSlot
            // 
            btnDeleteSlot.BackColor = Color.Pink;
            btnDeleteSlot.Cursor = Cursors.Hand;
            btnDeleteSlot.FlatStyle = FlatStyle.Flat;
            btnDeleteSlot.Location = new Point(199, 243);
            btnDeleteSlot.Margin = new Padding(3, 2, 3, 2);
            btnDeleteSlot.Name = "btnDeleteSlot";
            btnDeleteSlot.Size = new Size(153, 22);
            btnDeleteSlot.TabIndex = 4;
            btnDeleteSlot.Text = "Delete Slot";
            btnDeleteSlot.UseVisualStyleBackColor = false;
            btnDeleteSlot.Click += btnDeleteSlot_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Snow;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(10, 48);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(676, 190);
            dataGridView1.TabIndex = 0;
            // 
            // btnAddSlot
            // 
            btnAddSlot.BackColor = Color.Pink;
            btnAddSlot.Cursor = Cursors.Hand;
            btnAddSlot.FlatStyle = FlatStyle.Flat;
            btnAddSlot.Location = new Point(10, 243);
            btnAddSlot.Margin = new Padding(3, 2, 3, 2);
            btnAddSlot.Name = "btnAddSlot";
            btnAddSlot.Size = new Size(153, 22);
            btnAddSlot.TabIndex = 3;
            btnAddSlot.Text = "Add Available Slot";
            btnAddSlot.UseVisualStyleBackColor = false;
            btnAddSlot.Click += btnAddSlot_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(199, 23);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // comboBoxDoctors
            // 
            comboBoxDoctors.FormattingEnabled = true;
            comboBoxDoctors.Items.AddRange(new object[] { "Dr.Omar", "Dr.Mai", "Dr.Noha" });
            comboBoxDoctors.Location = new Point(10, 22);
            comboBoxDoctors.Margin = new Padding(3, 2, 3, 2);
            comboBoxDoctors.Name = "comboBoxDoctors";
            comboBoxDoctors.Size = new Size(154, 23);
            comboBoxDoctors.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(gridPayments);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(692, 272);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "View Payments";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 246);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 0);
            label6.Name = "label6";
            label6.Size = new Size(230, 25);
            label6.TabIndex = 1;
            label6.Text = "Clinic Revenue & Payments";
            // 
            // gridPayments
            // 
            gridPayments.BackgroundColor = Color.White;
            gridPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Snow;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridPayments.DefaultCellStyle = dataGridViewCellStyle2;
            gridPayments.GridColor = Color.LightGray;
            gridPayments.Location = new Point(7, 28);
            gridPayments.Margin = new Padding(3, 2, 3, 2);
            gridPayments.Name = "gridPayments";
            gridPayments.RowHeadersWidth = 51;
            gridPayments.Size = new Size(679, 216);
            gridPayments.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ReceptionistDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReceptionistDashboard";
            Text = "ReceptionistDashboard";
            Load += ReceptionistDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numWaiting).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private TabPage tabPage2;
        private Button btnDeleteSlot;
        private Button btnAddSlot;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxDoctors;
        private Label label1;
        private Label label3;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private Label label5;
        private Label label4;
        private ComboBox comboType;
        private NumericUpDown numWaiting;
        private DataGridView gridPayments;
        private Label label6;
        private Label label7;
        private Button btnlogout;
    }
}