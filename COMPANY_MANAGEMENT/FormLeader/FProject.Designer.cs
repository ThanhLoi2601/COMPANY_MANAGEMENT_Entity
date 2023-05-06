using System.Windows.Forms;
namespace COMPANY_MANAGEMENT.FormLeader
{
    partial class FProject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btUpdateProject = new System.Windows.Forms.Button();
            this.btInsertProject = new System.Windows.Forms.Button();
            this.btDeleteProject = new System.Windows.Forms.Button();
            this.btTask = new System.Windows.Forms.Button();
            this.grbProject = new System.Windows.Forms.GroupBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.dtDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtDateStart = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.grbListProject = new System.Windows.Forms.GroupBox();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.grbListTask = new System.Windows.Forms.GroupBox();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            this.grbProject.SuspendLayout();
            this.grbListProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.grbListTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btUpdateProject);
            this.flowLayoutPanel1.Controls.Add(this.btInsertProject);
            this.flowLayoutPanel1.Controls.Add(this.btDeleteProject);
            this.flowLayoutPanel1.Controls.Add(this.btTask);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 494);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(533, 57);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // btUpdateProject
            // 
            this.btUpdateProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btUpdateProject.Location = new System.Drawing.Point(3, 3);
            this.btUpdateProject.Name = "btUpdateProject";
            this.btUpdateProject.Size = new System.Drawing.Size(125, 48);
            this.btUpdateProject.TabIndex = 0;
            this.btUpdateProject.Text = "Update";
            this.btUpdateProject.UseVisualStyleBackColor = true;
            this.btUpdateProject.Click += new System.EventHandler(this.btUpdateProject_Click);
            // 
            // btInsertProject
            // 
            this.btInsertProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btInsertProject.Location = new System.Drawing.Point(134, 3);
            this.btInsertProject.Name = "btInsertProject";
            this.btInsertProject.Size = new System.Drawing.Size(125, 48);
            this.btInsertProject.TabIndex = 1;
            this.btInsertProject.Text = "Insert";
            this.btInsertProject.UseVisualStyleBackColor = true;
            this.btInsertProject.Click += new System.EventHandler(this.btInsertProject_Click);
            // 
            // btDeleteProject
            // 
            this.btDeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDeleteProject.Location = new System.Drawing.Point(265, 3);
            this.btDeleteProject.Name = "btDeleteProject";
            this.btDeleteProject.Size = new System.Drawing.Size(125, 48);
            this.btDeleteProject.TabIndex = 2;
            this.btDeleteProject.Text = "Delete";
            this.btDeleteProject.UseVisualStyleBackColor = true;
            this.btDeleteProject.Click += new System.EventHandler(this.btDeleteProject_Click);
            // 
            // btTask
            // 
            this.btTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTask.Location = new System.Drawing.Point(396, 3);
            this.btTask.Name = "btTask";
            this.btTask.Size = new System.Drawing.Size(125, 48);
            this.btTask.TabIndex = 3;
            this.btTask.Text = "Add Task";
            this.btTask.UseVisualStyleBackColor = true;
            this.btTask.Click += new System.EventHandler(this.btTask_Click);
            // 
            // grbProject
            // 
            this.grbProject.Controls.Add(this.cbbStatus);
            this.grbProject.Controls.Add(this.dtDateEnd);
            this.grbProject.Controls.Add(this.dtDateStart);
            this.grbProject.Controls.Add(this.txtName);
            this.grbProject.Controls.Add(this.txtID);
            this.grbProject.Controls.Add(this.rtxtContent);
            this.grbProject.Controls.Add(this.lblStatus);
            this.grbProject.Controls.Add(this.flowLayoutPanel1);
            this.grbProject.Controls.Add(this.lblContent);
            this.grbProject.Controls.Add(this.lblDateEnd);
            this.grbProject.Controls.Add(this.lblDateStart);
            this.grbProject.Controls.Add(this.lblName);
            this.grbProject.Controls.Add(this.lblID);
            this.grbProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.grbProject.Location = new System.Drawing.Point(12, 12);
            this.grbProject.Name = "grbProject";
            this.grbProject.Size = new System.Drawing.Size(542, 557);
            this.grbProject.TabIndex = 27;
            this.grbProject.TabStop = false;
            this.grbProject.Text = "INFORMATION";
            // 
            // cbbStatus
            // 
            this.cbbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(96, 449);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(412, 28);
            this.cbbStatus.TabIndex = 35;
            // 
            // dtDateEnd
            // 
            this.dtDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtDateEnd.Location = new System.Drawing.Point(96, 186);
            this.dtDateEnd.Name = "dtDateEnd";
            this.dtDateEnd.Size = new System.Drawing.Size(412, 27);
            this.dtDateEnd.TabIndex = 34;
            // 
            // dtDateStart
            // 
            this.dtDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtDateStart.Location = new System.Drawing.Point(96, 136);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(412, 27);
            this.dtDateStart.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(96, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(412, 27);
            this.txtName.TabIndex = 29;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(96, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(412, 27);
            this.txtID.TabIndex = 28;
            // 
            // rtxtContent
            // 
            this.rtxtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtContent.Location = new System.Drawing.Point(96, 245);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(412, 180);
            this.rtxtContent.TabIndex = 27;
            this.rtxtContent.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(6, 456);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 18);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Status";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContent.Location = new System.Drawing.Point(6, 245);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(60, 18);
            this.lblContent.TabIndex = 25;
            this.lblContent.Text = "Content";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateEnd.Location = new System.Drawing.Point(6, 192);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(67, 18);
            this.lblDateEnd.TabIndex = 24;
            this.lblDateEnd.Text = "Date end";
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateStart.Location = new System.Drawing.Point(6, 142);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(72, 18);
            this.lblDateStart.TabIndex = 23;
            this.lblDateStart.Text = "Date start";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(6, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(6, 49);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 18);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "ID";
            // 
            // grbListProject
            // 
            this.grbListProject.Controls.Add(this.dgvProject);
            this.grbListProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.grbListProject.Location = new System.Drawing.Point(575, 12);
            this.grbListProject.Name = "grbListProject";
            this.grbListProject.Size = new System.Drawing.Size(812, 280);
            this.grbListProject.TabIndex = 28;
            this.grbListProject.TabStop = false;
            this.grbListProject.Text = "List Project";
            // 
            // dgvProject
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProject.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProject.Location = new System.Drawing.Point(6, 26);
            this.dgvProject.Name = "dgvProject";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProject.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProject.RowHeadersWidth = 51;
            this.dgvProject.RowTemplate.Height = 29;
            this.dgvProject.Size = new System.Drawing.Size(799, 245);
            this.dgvProject.TabIndex = 0;
            this.dgvProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProject_CellClick_1);
            // 
            // grbListTask
            // 
            this.grbListTask.Controls.Add(this.dgvTask);
            this.grbListTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.grbListTask.Location = new System.Drawing.Point(567, 289);
            this.grbListTask.Name = "grbListTask";
            this.grbListTask.Size = new System.Drawing.Size(820, 274);
            this.grbListTask.TabIndex = 29;
            this.grbListTask.TabStop = false;
            this.grbListTask.Text = "List Task";
            // 
            // dgvTask
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTask.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTask.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTask.Location = new System.Drawing.Point(21, 26);
            this.dgvTask.Name = "dgvTask";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTask.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTask.RowHeadersWidth = 51;
            this.dgvTask.RowTemplate.Height = 29;
            this.dgvTask.Size = new System.Drawing.Size(799, 242);
            this.dgvTask.TabIndex = 1;
            this.dgvTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellClick);
            // 
            // FProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 579);
            this.Controls.Add(this.grbListTask);
            this.Controls.Add(this.grbListProject);
            this.Controls.Add(this.grbProject);
            this.Name = "FProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FProject";
            this.Load += new System.EventHandler(this.FProject_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.grbProject.ResumeLayout(false);
            this.grbProject.PerformLayout();
            this.grbListProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.grbListTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btUpdateProject;
        private Button btInsertProject;
        private Button btDeleteProject;
        private GroupBox grbProject;
        private Button btTask;
        private Label lblContent;
        private Label lblDateEnd;
        private Label lblDateStart;
        private Label lblName;
        private Label lblID;
        private Label lblStatus;
        private TextBox txtName;
        private TextBox txtID;
        private RichTextBox rtxtContent;
        private DateTimePicker dtDateEnd;
        private DateTimePicker dtDateStart;
        private ComboBox cbbStatus;
        private GroupBox grbListProject;
        private DataGridView dgvProject;
        private GroupBox grbListTask;
        private DataGridView dgvTask;
    }
}