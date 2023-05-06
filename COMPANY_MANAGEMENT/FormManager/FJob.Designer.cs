namespace COMPANY_MANAGEMENT
{
    partial class FJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FJob));
            this.grInfo = new System.Windows.Forms.GroupBox();
            this.txtIDWork = new System.Windows.Forms.TextBox();
            this.lbIDWork = new System.Windows.Forms.Label();
            this.rTxtContent = new System.Windows.Forms.RichTextBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.labBonus = new System.Windows.Forms.Label();
            this.dtDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtDateStart = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.labDateEnd = new System.Windows.Forms.Label();
            this.labDateStart = new System.Windows.Forms.Label();
            this.LabContent = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabJobStaff = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dGVJobStaff = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btConf = new System.Windows.Forms.Button();
            this.dGVMyProject = new System.Windows.Forms.DataGridView();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grInfo.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabJobStaff.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVJobStaff)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMyProject)).BeginInit();
            this.SuspendLayout();
            // 
            // grInfo
            // 
            this.grInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grInfo.BackgroundImage")));
            this.grInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grInfo.Controls.Add(this.txtIDWork);
            this.grInfo.Controls.Add(this.lbIDWork);
            this.grInfo.Controls.Add(this.rTxtContent);
            this.grInfo.Controls.Add(this.txtBonus);
            this.grInfo.Controls.Add(this.labBonus);
            this.grInfo.Controls.Add(this.dtDateEnd);
            this.grInfo.Controls.Add(this.dtDateStart);
            this.grInfo.Controls.Add(this.flowLayoutPanel3);
            this.grInfo.Controls.Add(this.labDateEnd);
            this.grInfo.Controls.Add(this.labDateStart);
            this.grInfo.Controls.Add(this.LabContent);
            this.grInfo.Controls.Add(this.txtName);
            this.grInfo.Controls.Add(this.labName);
            this.grInfo.Controls.Add(this.txtID);
            this.grInfo.Controls.Add(this.labID);
            this.grInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grInfo.Location = new System.Drawing.Point(3, 3);
            this.grInfo.Name = "grInfo";
            this.grInfo.Size = new System.Drawing.Size(507, 502);
            this.grInfo.TabIndex = 2;
            this.grInfo.TabStop = false;
            this.grInfo.Text = "INFORMATION";
            // 
            // txtIDWork
            // 
            this.txtIDWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDWork.Location = new System.Drawing.Point(331, 36);
            this.txtIDWork.Name = "txtIDWork";
            this.txtIDWork.Size = new System.Drawing.Size(155, 24);
            this.txtIDWork.TabIndex = 25;
            // 
            // lbIDWork
            // 
            this.lbIDWork.AutoSize = true;
            this.lbIDWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDWork.Location = new System.Drawing.Point(262, 42);
            this.lbIDWork.Name = "lbIDWork";
            this.lbIDWork.Size = new System.Drawing.Size(63, 18);
            this.lbIDWork.TabIndex = 24;
            this.lbIDWork.Text = "ID Work";
            // 
            // rTxtContent
            // 
            this.rTxtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtContent.Location = new System.Drawing.Point(100, 143);
            this.rTxtContent.Name = "rTxtContent";
            this.rTxtContent.Size = new System.Drawing.Size(347, 145);
            this.rTxtContent.TabIndex = 23;
            this.rTxtContent.Text = "";
            // 
            // txtBonus
            // 
            this.txtBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonus.Location = new System.Drawing.Point(100, 419);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(267, 24);
            this.txtBonus.TabIndex = 22;
            this.txtBonus.TextChanged += new System.EventHandler(this.txtBonus_TextChanged);
            // 
            // labBonus
            // 
            this.labBonus.AutoSize = true;
            this.labBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBonus.Location = new System.Drawing.Point(6, 419);
            this.labBonus.Name = "labBonus";
            this.labBonus.Size = new System.Drawing.Size(51, 18);
            this.labBonus.TabIndex = 21;
            this.labBonus.Text = "Bonus";
            // 
            // dtDateEnd
            // 
            this.dtDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateEnd.Location = new System.Drawing.Point(100, 361);
            this.dtDateEnd.Name = "dtDateEnd";
            this.dtDateEnd.Size = new System.Drawing.Size(267, 24);
            this.dtDateEnd.TabIndex = 20;
            // 
            // dtDateStart
            // 
            this.dtDateStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateStart.Location = new System.Drawing.Point(100, 308);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(267, 24);
            this.dtDateStart.TabIndex = 19;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btUpdate);
            this.flowLayoutPanel3.Controls.Add(this.btInsert);
            this.flowLayoutPanel3.Controls.Add(this.btDelete);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 453);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(409, 45);
            this.flowLayoutPanel3.TabIndex = 17;
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(3, 3);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(128, 42);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "UPDATE";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(137, 3);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(127, 42);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "INSERT";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(270, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(128, 42);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "DELETE";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // labDateEnd
            // 
            this.labDateEnd.AutoSize = true;
            this.labDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDateEnd.Location = new System.Drawing.Point(6, 373);
            this.labDateEnd.Name = "labDateEnd";
            this.labDateEnd.Size = new System.Drawing.Size(65, 18);
            this.labDateEnd.TabIndex = 15;
            this.labDateEnd.Text = "DateEnd";
            // 
            // labDateStart
            // 
            this.labDateStart.AutoSize = true;
            this.labDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDateStart.Location = new System.Drawing.Point(6, 317);
            this.labDateStart.Name = "labDateStart";
            this.labDateStart.Size = new System.Drawing.Size(70, 18);
            this.labDateStart.TabIndex = 13;
            this.labDateStart.Text = "DateStart";
            // 
            // LabContent
            // 
            this.LabContent.AutoSize = true;
            this.LabContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabContent.Location = new System.Drawing.Point(3, 151);
            this.LabContent.Name = "LabContent";
            this.LabContent.Size = new System.Drawing.Size(60, 18);
            this.LabContent.TabIndex = 6;
            this.LabContent.Text = "Content";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(100, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(267, 24);
            this.txtName.TabIndex = 5;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(6, 87);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(48, 18);
            this.labName.TabIndex = 4;
            this.labName.Text = "Name";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(100, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(136, 24);
            this.txtID.TabIndex = 1;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labID.Location = new System.Drawing.Point(6, 39);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(22, 18);
            this.labID.TabIndex = 0;
            this.labID.Text = "ID";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.62811F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.37189F));
            this.tableLayoutPanel1.Controls.Add(this.grInfo, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 508F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1366, 508);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tabJobStaff
            // 
            this.tabJobStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabJobStaff.Controls.Add(this.tabPage1);
            this.tabJobStaff.Controls.Add(this.tabPage2);
            this.tabJobStaff.Location = new System.Drawing.Point(520, 4);
            this.tabJobStaff.Name = "tabJobStaff";
            this.tabJobStaff.SelectedIndex = 0;
            this.tabJobStaff.Size = new System.Drawing.Size(849, 512);
            this.tabJobStaff.TabIndex = 4;
            this.tabJobStaff.SelectedIndexChanged += new System.EventHandler(this.tabJobStaff_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dGVJobStaff);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(841, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "STAFF JOB ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dGVJobStaff
            // 
            this.dGVJobStaff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dGVJobStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVJobStaff.Location = new System.Drawing.Point(0, 0);
            this.dGVJobStaff.Name = "dGVJobStaff";
            this.dGVJobStaff.RowHeadersWidth = 51;
            this.dGVJobStaff.RowTemplate.Height = 24;
            this.dGVJobStaff.Size = new System.Drawing.Size(841, 476);
            this.dGVJobStaff.TabIndex = 4;
            this.dGVJobStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVJobStaff_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbStatus);
            this.tabPage2.Controls.Add(this.btConf);
            this.tabPage2.Controls.Add(this.dGVMyProject);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(841, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MY PROJECT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btConf
            // 
            this.btConf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConf.Location = new System.Drawing.Point(663, 431);
            this.btConf.Name = "btConf";
            this.btConf.Size = new System.Drawing.Size(172, 48);
            this.btConf.TabIndex = 5;
            this.btConf.Text = "CONFIRM ";
            this.btConf.UseVisualStyleBackColor = false;
            this.btConf.Click += new System.EventHandler(this.btConf_Click);
            // 
            // dGVMyProject
            // 
            this.dGVMyProject.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dGVMyProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMyProject.Location = new System.Drawing.Point(0, 0);
            this.dGVMyProject.Name = "dGVMyProject";
            this.dGVMyProject.RowHeadersWidth = 51;
            this.dGVMyProject.RowTemplate.Height = 24;
            this.dGVMyProject.Size = new System.Drawing.Size(841, 426);
            this.dGVMyProject.TabIndex = 5;
            this.dGVMyProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVMyProject_CellClick);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(130, 432);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(161, 26);
            this.cbStatus.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Status Task: ";
            // 
            // FJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1371, 517);
            this.Controls.Add(this.tabJobStaff);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FJob";
            this.Text = "JOB";
            this.Load += new System.EventHandler(this.FJob_Load);
            this.grInfo.ResumeLayout(false);
            this.grInfo.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabJobStaff.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVJobStaff)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMyProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label labDateEnd;
        private System.Windows.Forms.Label labDateStart;
        private System.Windows.Forms.Label LabContent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox rTxtContent;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label labBonus;
        private System.Windows.Forms.DateTimePicker dtDateEnd;
        private System.Windows.Forms.DateTimePicker dtDateStart;
        private System.Windows.Forms.TabControl tabJobStaff;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dGVJobStaff;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dGVMyProject;
        private System.Windows.Forms.Button btConf;
        private System.Windows.Forms.TextBox txtIDWork;
        private System.Windows.Forms.Label lbIDWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}