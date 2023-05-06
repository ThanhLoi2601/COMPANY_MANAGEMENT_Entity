using System.Windows.Forms;

namespace COMPANY_MANAGEMENT.FormLeader
{
    partial class FLeader
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbInformationLd = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDManager = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btUpdateLd = new System.Windows.Forms.Button();
            this.btInsertLd = new System.Windows.Forms.Button();
            this.btDeleteLd = new System.Windows.Forms.Button();
            this.txtPasswordLd = new System.Windows.Forms.TextBox();
            this.txtBasicSalaryLd = new System.Windows.Forms.TextBox();
            this.txtAddressLd = new System.Windows.Forms.TextBox();
            this.txtEmailLd = new System.Windows.Forms.TextBox();
            this.txtIDCardLd = new System.Windows.Forms.TextBox();
            this.txtNameLd = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dtpkDateOfBirthLd = new System.Windows.Forms.DateTimePicker();
            this.lbPasswordLd = new System.Windows.Forms.Label();
            this.lbBasicSalaryLd = new System.Windows.Forms.Label();
            this.lbAddressLd = new System.Windows.Forms.Label();
            this.lbEmailLd = new System.Windows.Forms.Label();
            this.lbIDCardLd = new System.Windows.Forms.Label();
            this.lbDateOfBirthLd = new System.Windows.Forms.Label();
            this.lbNameLd = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.grbOptionLd = new System.Windows.Forms.GroupBox();
            this.btAbsenceLetterLd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btDistributionLd = new System.Windows.Forms.Button();
            this.btContact = new System.Windows.Forms.Button();
            this.btMyInfor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListManager = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListStaff = new System.Windows.Forms.DataGridView();
            this.grbInformationLd.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.grbOptionLd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListManager)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformationLd
            // 
            this.grbInformationLd.Controls.Add(this.label1);
            this.grbInformationLd.Controls.Add(this.txtIDManager);
            this.grbInformationLd.Controls.Add(this.flowLayoutPanel1);
            this.grbInformationLd.Controls.Add(this.txtPasswordLd);
            this.grbInformationLd.Controls.Add(this.txtBasicSalaryLd);
            this.grbInformationLd.Controls.Add(this.txtAddressLd);
            this.grbInformationLd.Controls.Add(this.txtEmailLd);
            this.grbInformationLd.Controls.Add(this.txtIDCardLd);
            this.grbInformationLd.Controls.Add(this.txtNameLd);
            this.grbInformationLd.Controls.Add(this.txtID);
            this.grbInformationLd.Controls.Add(this.dtpkDateOfBirthLd);
            this.grbInformationLd.Controls.Add(this.lbPasswordLd);
            this.grbInformationLd.Controls.Add(this.lbBasicSalaryLd);
            this.grbInformationLd.Controls.Add(this.lbAddressLd);
            this.grbInformationLd.Controls.Add(this.lbEmailLd);
            this.grbInformationLd.Controls.Add(this.lbIDCardLd);
            this.grbInformationLd.Controls.Add(this.lbDateOfBirthLd);
            this.grbInformationLd.Controls.Add(this.lbNameLd);
            this.grbInformationLd.Controls.Add(this.lbID);
            this.grbInformationLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grbInformationLd.Location = new System.Drawing.Point(1, 1);
            this.grbInformationLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInformationLd.Name = "grbInformationLd";
            this.grbInformationLd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInformationLd.Size = new System.Drawing.Size(407, 482);
            this.grbInformationLd.TabIndex = 0;
            this.grbInformationLd.TabStop = false;
            this.grbInformationLd.Text = "INFORMATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(3, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID Manager";
            // 
            // txtIDManager
            // 
            this.txtIDManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtIDManager.Location = new System.Drawing.Point(102, 346);
            this.txtIDManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDManager.Name = "txtIDManager";
            this.txtIDManager.Size = new System.Drawing.Size(294, 27);
            this.txtIDManager.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btUpdateLd);
            this.flowLayoutPanel1.Controls.Add(this.btInsertLd);
            this.flowLayoutPanel1.Controls.Add(this.btDeleteLd);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 424);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(395, 46);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // btUpdateLd
            // 
            this.btUpdateLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btUpdateLd.Location = new System.Drawing.Point(3, 2);
            this.btUpdateLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btUpdateLd.Name = "btUpdateLd";
            this.btUpdateLd.Size = new System.Drawing.Size(125, 38);
            this.btUpdateLd.TabIndex = 0;
            this.btUpdateLd.Text = "Update";
            this.btUpdateLd.UseVisualStyleBackColor = true;
            this.btUpdateLd.Click += new System.EventHandler(this.btUpdateLd_Click);
            // 
            // btInsertLd
            // 
            this.btInsertLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btInsertLd.Location = new System.Drawing.Point(134, 2);
            this.btInsertLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btInsertLd.Name = "btInsertLd";
            this.btInsertLd.Size = new System.Drawing.Size(125, 38);
            this.btInsertLd.TabIndex = 1;
            this.btInsertLd.Text = "Insert";
            this.btInsertLd.UseVisualStyleBackColor = true;
            this.btInsertLd.Click += new System.EventHandler(this.btInsertLd_Click);
            // 
            // btDeleteLd
            // 
            this.btDeleteLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btDeleteLd.Location = new System.Drawing.Point(265, 2);
            this.btDeleteLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDeleteLd.Name = "btDeleteLd";
            this.btDeleteLd.Size = new System.Drawing.Size(125, 38);
            this.btDeleteLd.TabIndex = 2;
            this.btDeleteLd.Text = "Delete";
            this.btDeleteLd.UseVisualStyleBackColor = true;
            this.btDeleteLd.Click += new System.EventHandler(this.btDeleteLd_Click);
            // 
            // txtPasswordLd
            // 
            this.txtPasswordLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtPasswordLd.Location = new System.Drawing.Point(102, 390);
            this.txtPasswordLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordLd.Name = "txtPasswordLd";
            this.txtPasswordLd.Size = new System.Drawing.Size(294, 27);
            this.txtPasswordLd.TabIndex = 17;
            this.txtPasswordLd.UseSystemPasswordChar = true;
            // 
            // txtBasicSalaryLd
            // 
            this.txtBasicSalaryLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtBasicSalaryLd.Location = new System.Drawing.Point(102, 297);
            this.txtBasicSalaryLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBasicSalaryLd.Name = "txtBasicSalaryLd";
            this.txtBasicSalaryLd.Size = new System.Drawing.Size(294, 27);
            this.txtBasicSalaryLd.TabIndex = 15;
            // 
            // txtAddressLd
            // 
            this.txtAddressLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtAddressLd.Location = new System.Drawing.Point(102, 252);
            this.txtAddressLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddressLd.Name = "txtAddressLd";
            this.txtAddressLd.Size = new System.Drawing.Size(294, 27);
            this.txtAddressLd.TabIndex = 14;
            // 
            // txtEmailLd
            // 
            this.txtEmailLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtEmailLd.Location = new System.Drawing.Point(102, 206);
            this.txtEmailLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailLd.Name = "txtEmailLd";
            this.txtEmailLd.Size = new System.Drawing.Size(294, 27);
            this.txtEmailLd.TabIndex = 13;
            // 
            // txtIDCardLd
            // 
            this.txtIDCardLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtIDCardLd.Location = new System.Drawing.Point(102, 159);
            this.txtIDCardLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDCardLd.Name = "txtIDCardLd";
            this.txtIDCardLd.Size = new System.Drawing.Size(294, 27);
            this.txtIDCardLd.TabIndex = 12;
            // 
            // txtNameLd
            // 
            this.txtNameLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtNameLd.Location = new System.Drawing.Point(102, 68);
            this.txtNameLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameLd.Name = "txtNameLd";
            this.txtNameLd.Size = new System.Drawing.Size(294, 27);
            this.txtNameLd.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtID.Location = new System.Drawing.Point(102, 28);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(294, 27);
            this.txtID.TabIndex = 10;
            // 
            // dtpkDateOfBirthLd
            // 
            this.dtpkDateOfBirthLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtpkDateOfBirthLd.Location = new System.Drawing.Point(102, 116);
            this.dtpkDateOfBirthLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpkDateOfBirthLd.Name = "dtpkDateOfBirthLd";
            this.dtpkDateOfBirthLd.Size = new System.Drawing.Size(294, 27);
            this.dtpkDateOfBirthLd.TabIndex = 9;
            this.dtpkDateOfBirthLd.Value = new System.DateTime(2023, 3, 22, 8, 52, 31, 0);
            // 
            // lbPasswordLd
            // 
            this.lbPasswordLd.AutoSize = true;
            this.lbPasswordLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbPasswordLd.Location = new System.Drawing.Point(9, 396);
            this.lbPasswordLd.Name = "lbPasswordLd";
            this.lbPasswordLd.Size = new System.Drawing.Size(75, 18);
            this.lbPasswordLd.TabIndex = 8;
            this.lbPasswordLd.Text = "Password";
            // 
            // lbBasicSalaryLd
            // 
            this.lbBasicSalaryLd.AutoSize = true;
            this.lbBasicSalaryLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbBasicSalaryLd.Location = new System.Drawing.Point(3, 300);
            this.lbBasicSalaryLd.Name = "lbBasicSalaryLd";
            this.lbBasicSalaryLd.Size = new System.Drawing.Size(88, 18);
            this.lbBasicSalaryLd.TabIndex = 6;
            this.lbBasicSalaryLd.Text = "Basic salary";
            // 
            // lbAddressLd
            // 
            this.lbAddressLd.AutoSize = true;
            this.lbAddressLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbAddressLd.Location = new System.Drawing.Point(3, 258);
            this.lbAddressLd.Name = "lbAddressLd";
            this.lbAddressLd.Size = new System.Drawing.Size(62, 18);
            this.lbAddressLd.TabIndex = 5;
            this.lbAddressLd.Text = "Address";
            // 
            // lbEmailLd
            // 
            this.lbEmailLd.AutoSize = true;
            this.lbEmailLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbEmailLd.Location = new System.Drawing.Point(6, 212);
            this.lbEmailLd.Name = "lbEmailLd";
            this.lbEmailLd.Size = new System.Drawing.Size(45, 18);
            this.lbEmailLd.TabIndex = 4;
            this.lbEmailLd.Text = "Email";
            // 
            // lbIDCardLd
            // 
            this.lbIDCardLd.AutoSize = true;
            this.lbIDCardLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbIDCardLd.Location = new System.Drawing.Point(6, 166);
            this.lbIDCardLd.Name = "lbIDCardLd";
            this.lbIDCardLd.Size = new System.Drawing.Size(58, 18);
            this.lbIDCardLd.TabIndex = 3;
            this.lbIDCardLd.Text = "ID Card";
            // 
            // lbDateOfBirthLd
            // 
            this.lbDateOfBirthLd.AutoSize = true;
            this.lbDateOfBirthLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbDateOfBirthLd.Location = new System.Drawing.Point(0, 120);
            this.lbDateOfBirthLd.Name = "lbDateOfBirthLd";
            this.lbDateOfBirthLd.Size = new System.Drawing.Size(88, 18);
            this.lbDateOfBirthLd.TabIndex = 2;
            this.lbDateOfBirthLd.Text = "Date of birth";
            // 
            // lbNameLd
            // 
            this.lbNameLd.AutoSize = true;
            this.lbNameLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbNameLd.Location = new System.Drawing.Point(6, 74);
            this.lbNameLd.Name = "lbNameLd";
            this.lbNameLd.Size = new System.Drawing.Size(48, 18);
            this.lbNameLd.TabIndex = 1;
            this.lbNameLd.Text = "Name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbID.Location = new System.Drawing.Point(9, 34);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(22, 18);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "ID";
            // 
            // grbOptionLd
            // 
            this.grbOptionLd.Controls.Add(this.btAbsenceLetterLd);
            this.grbOptionLd.Controls.Add(this.button1);
            this.grbOptionLd.Controls.Add(this.btDistributionLd);
            this.grbOptionLd.Controls.Add(this.btContact);
            this.grbOptionLd.Controls.Add(this.btMyInfor);
            this.grbOptionLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grbOptionLd.Location = new System.Drawing.Point(1231, 1);
            this.grbOptionLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbOptionLd.Name = "grbOptionLd";
            this.grbOptionLd.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbOptionLd.Size = new System.Drawing.Size(156, 482);
            this.grbOptionLd.TabIndex = 2;
            this.grbOptionLd.TabStop = false;
            this.grbOptionLd.Text = "Option";
            // 
            // btAbsenceLetterLd
            // 
            this.btAbsenceLetterLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btAbsenceLetterLd.Location = new System.Drawing.Point(8, 129);
            this.btAbsenceLetterLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAbsenceLetterLd.Name = "btAbsenceLetterLd";
            this.btAbsenceLetterLd.Size = new System.Drawing.Size(142, 57);
            this.btAbsenceLetterLd.TabIndex = 11;
            this.btAbsenceLetterLd.Text = "Absence Letter";
            this.btAbsenceLetterLd.UseVisualStyleBackColor = true;
            this.btAbsenceLetterLd.Click += new System.EventHandler(this.btAbsenceLetterLd_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(8, 374);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "Project";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btDistributionLd
            // 
            this.btDistributionLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btDistributionLd.Location = new System.Drawing.Point(8, 289);
            this.btDistributionLd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDistributionLd.Name = "btDistributionLd";
            this.btDistributionLd.Size = new System.Drawing.Size(142, 61);
            this.btDistributionLd.TabIndex = 9;
            this.btDistributionLd.Text = "Distribution";
            this.btDistributionLd.UseVisualStyleBackColor = true;
            this.btDistributionLd.Click += new System.EventHandler(this.btDistributionLd_Click);
            // 
            // btContact
            // 
            this.btContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btContact.Location = new System.Drawing.Point(8, 212);
            this.btContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btContact.Name = "btContact";
            this.btContact.Size = new System.Drawing.Size(142, 54);
            this.btContact.TabIndex = 6;
            this.btContact.Text = "Contact";
            this.btContact.UseVisualStyleBackColor = true;
            this.btContact.Click += new System.EventHandler(this.btContract_Click);
            // 
            // btMyInfor
            // 
            this.btMyInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btMyInfor.Location = new System.Drawing.Point(8, 48);
            this.btMyInfor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMyInfor.Name = "btMyInfor";
            this.btMyInfor.Size = new System.Drawing.Size(142, 59);
            this.btMyInfor.TabIndex = 5;
            this.btMyInfor.Text = "My Information";
            this.btMyInfor.UseVisualStyleBackColor = true;
            this.btMyInfor.Click += new System.EventHandler(this.btMyInfor_Click);
            this.btMyInfor.MouseEnter += new System.EventHandler(this.btMyInfor_MouseEnter);
            this.btMyInfor.MouseLeave += new System.EventHandler(this.btMyInfor_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListManager);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox1.Location = new System.Drawing.Point(414, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(811, 238);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Manager";
            // 
            // dgvListManager
            // 
            this.dgvListManager.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListManager.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListManager.Location = new System.Drawing.Point(6, 21);
            this.dgvListManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListManager.Name = "dgvListManager";
            this.dgvListManager.RowHeadersWidth = 51;
            this.dgvListManager.RowTemplate.Height = 29;
            this.dgvListManager.Size = new System.Drawing.Size(798, 213);
            this.dgvListManager.TabIndex = 0;
            this.dgvListManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListManager_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListStaff);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox2.Location = new System.Drawing.Point(414, 253);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(811, 230);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Staff";
            // 
            // dgvListStaff
            // 
            this.dgvListStaff.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListStaff.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListStaff.Location = new System.Drawing.Point(6, 19);
            this.dgvListStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListStaff.Name = "dgvListStaff";
            this.dgvListStaff.RowHeadersWidth = 51;
            this.dgvListStaff.RowTemplate.Height = 29;
            this.dgvListStaff.Size = new System.Drawing.Size(798, 206);
            this.dgvListStaff.TabIndex = 1;
            this.dgvListStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListStaff_CellClick);
            // 
            // FLeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbOptionLd);
            this.Controls.Add(this.grbInformationLd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FLeader";
            this.Text = "FLeader";
            this.Load += new System.EventHandler(this.FLeader_Load);
            this.grbInformationLd.ResumeLayout(false);
            this.grbInformationLd.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.grbOptionLd.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListManager)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grbInformationLd;
        private TextBox txtPasswordLd;
        private TextBox txtBasicSalaryLd;
        private TextBox txtAddressLd;
        private TextBox txtEmailLd;
        private TextBox txtIDCardLd;
        private TextBox txtNameLd;
        private TextBox txtID;
        private DateTimePicker dtpkDateOfBirthLd;
        private Label lbPasswordLd;
        private Label lbBasicSalaryLd;
        private Label lbAddressLd;
        private Label lbEmailLd;
        private Label lbIDCardLd;
        private Label lbDateOfBirthLd;
        private Label lbNameLd;
        private Label lbID;
        private GroupBox grbOptionLd;
        private Button btDistributionLd;
        private Button btContact;
        private Button btMyInfor;
        private Button btDeleteLd;
        private Button btInsertLd;
        private Button btUpdateLd;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private GroupBox groupBox1;
        private DataGridView dgvListManager;
        private GroupBox groupBox2;
        private DataGridView dgvListStaff;
        private Button btAbsenceLetterLd;
        private Label label1;
        private TextBox txtIDManager;
    }
}