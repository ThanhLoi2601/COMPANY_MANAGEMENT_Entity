using System.Windows.Forms;
namespace COMPANY_MANAGEMENT.FormLeader
{
    partial class DistributionLD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProject = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvListManager = new System.Windows.Forms.DataGridView();
            this.grbListDistribution = new System.Windows.Forms.GroupBox();
            this.btInsertLd = new System.Windows.Forms.Button();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.btDeleteLd = new System.Windows.Forms.Button();
            this.txtIDManager = new System.Windows.Forms.TextBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.txtIDTask = new System.Windows.Forms.TextBox();
            this.lblNameManager = new System.Windows.Forms.Label();
            this.lblIDManager = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblIDTask = new System.Windows.Forms.Label();
            this.dgvDistribution = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListManager)).BeginInit();
            this.grbListDistribution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProject);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Project";
            // 
            // dgvProject
            // 
            this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProject.Location = new System.Drawing.Point(6, 26);
            this.dgvProject.Name = "dgvProject";
            this.dgvProject.RowHeadersWidth = 51;
            this.dgvProject.RowTemplate.Height = 29;
            this.dgvProject.Size = new System.Drawing.Size(449, 340);
            this.dgvProject.TabIndex = 0;
            this.dgvProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProject_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTask);
            this.groupBox2.Location = new System.Drawing.Point(474, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 372);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Task";
            // 
            // dgvTask
            // 
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Location = new System.Drawing.Point(6, 26);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.RowHeadersWidth = 51;
            this.dgvTask.RowTemplate.Height = 29;
            this.dgvTask.Size = new System.Drawing.Size(449, 340);
            this.dgvTask.TabIndex = 1;
            this.dgvTask.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvListManager);
            this.groupBox3.Location = new System.Drawing.Point(941, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 372);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List Manager";
            // 
            // dgvListManager
            // 
            this.dgvListManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListManager.Location = new System.Drawing.Point(6, 26);
            this.dgvListManager.Name = "dgvListManager";
            this.dgvListManager.RowHeadersWidth = 51;
            this.dgvListManager.RowTemplate.Height = 29;
            this.dgvListManager.Size = new System.Drawing.Size(449, 340);
            this.dgvListManager.TabIndex = 2;
            this.dgvListManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListManager_CellClick);
            // 
            // grbListDistribution
            // 
            this.grbListDistribution.Controls.Add(this.btInsertLd);
            this.grbListDistribution.Controls.Add(this.txtManagerName);
            this.grbListDistribution.Controls.Add(this.btDeleteLd);
            this.grbListDistribution.Controls.Add(this.txtIDManager);
            this.grbListDistribution.Controls.Add(this.txtTaskName);
            this.grbListDistribution.Controls.Add(this.txtIDTask);
            this.grbListDistribution.Controls.Add(this.lblNameManager);
            this.grbListDistribution.Controls.Add(this.lblIDManager);
            this.grbListDistribution.Controls.Add(this.lblTaskName);
            this.grbListDistribution.Controls.Add(this.lblIDTask);
            this.grbListDistribution.Controls.Add(this.dgvDistribution);
            this.grbListDistribution.Location = new System.Drawing.Point(13, 390);
            this.grbListDistribution.Name = "grbListDistribution";
            this.grbListDistribution.Size = new System.Drawing.Size(1389, 321);
            this.grbListDistribution.TabIndex = 2;
            this.grbListDistribution.TabStop = false;
            this.grbListDistribution.Text = "List Distribution";
            // 
            // btInsertLd
            // 
            this.btInsertLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btInsertLd.Location = new System.Drawing.Point(892, 227);
            this.btInsertLd.Name = "btInsertLd";
            this.btInsertLd.Size = new System.Drawing.Size(125, 48);
            this.btInsertLd.TabIndex = 1;
            this.btInsertLd.Text = "Insert";
            this.btInsertLd.UseVisualStyleBackColor = true;
            this.btInsertLd.Click += new System.EventHandler(this.btInsertLd_Click);
            // 
            // txtManagerName
            // 
            this.txtManagerName.Location = new System.Drawing.Point(1174, 121);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(190, 27);
            this.txtManagerName.TabIndex = 23;
            // 
            // btDeleteLd
            // 
            this.btDeleteLd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDeleteLd.Location = new System.Drawing.Point(1144, 227);
            this.btDeleteLd.Name = "btDeleteLd";
            this.btDeleteLd.Size = new System.Drawing.Size(125, 48);
            this.btDeleteLd.TabIndex = 2;
            this.btDeleteLd.Text = "Delete";
            this.btDeleteLd.UseVisualStyleBackColor = true;
            this.btDeleteLd.Click += new System.EventHandler(this.btDeleteLd_Click);
            // 
            // txtIDManager
            // 
            this.txtIDManager.Location = new System.Drawing.Point(1174, 48);
            this.txtIDManager.Name = "txtIDManager";
            this.txtIDManager.Size = new System.Drawing.Size(190, 27);
            this.txtIDManager.TabIndex = 22;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(802, 121);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(215, 27);
            this.txtTaskName.TabIndex = 21;
            // 
            // txtIDTask
            // 
            this.txtIDTask.Location = new System.Drawing.Point(802, 47);
            this.txtIDTask.Name = "txtIDTask";
            this.txtIDTask.Size = new System.Drawing.Size(215, 27);
            this.txtIDTask.TabIndex = 20;
            // 
            // lblNameManager
            // 
            this.lblNameManager.AutoSize = true;
            this.lblNameManager.Location = new System.Drawing.Point(1056, 124);
            this.lblNameManager.Name = "lblNameManager";
            this.lblNameManager.Size = new System.Drawing.Size(112, 20);
            this.lblNameManager.TabIndex = 5;
            this.lblNameManager.Text = "Name Manager";
            // 
            // lblIDManager
            // 
            this.lblIDManager.AutoSize = true;
            this.lblIDManager.Location = new System.Drawing.Point(1056, 54);
            this.lblIDManager.Name = "lblIDManager";
            this.lblIDManager.Size = new System.Drawing.Size(87, 20);
            this.lblIDManager.TabIndex = 4;
            this.lblIDManager.Text = "ID Manager";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(707, 124);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(80, 20);
            this.lblTaskName.TabIndex = 3;
            this.lblTaskName.Text = "Name Task";
            // 
            // lblIDTask
            // 
            this.lblIDTask.AutoSize = true;
            this.lblIDTask.Location = new System.Drawing.Point(707, 51);
            this.lblIDTask.Name = "lblIDTask";
            this.lblIDTask.Size = new System.Drawing.Size(55, 20);
            this.lblIDTask.TabIndex = 2;
            this.lblIDTask.Text = "ID Task";
            // 
            // dgvDistribution
            // 
            this.dgvDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistribution.Location = new System.Drawing.Point(6, 21);
            this.dgvDistribution.Name = "dgvDistribution";
            this.dgvDistribution.RowHeadersWidth = 51;
            this.dgvDistribution.RowTemplate.Height = 29;
            this.dgvDistribution.Size = new System.Drawing.Size(675, 294);
            this.dgvDistribution.TabIndex = 1;
            this.dgvDistribution.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDistribution_CellClick);
            // 
            // DistributionLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 711);
            this.Controls.Add(this.grbListDistribution);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DistributionLD";
            this.Text = "DistributionLD";
            this.Load += new System.EventHandler(this.DistributionLD_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProject)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListManager)).EndInit();
            this.grbListDistribution.ResumeLayout(false);
            this.grbListDistribution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistribution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvProject;
        private GroupBox groupBox2;
        private DataGridView dgvTask;
        private GroupBox groupBox3;
        private DataGridView dgvListManager;
        private GroupBox grbListDistribution;
        private DataGridView dgvDistribution;
        private Label lblNameManager;
        private Label lblIDManager;
        private Label lblTaskName;
        private Label lblIDTask;
        private TextBox txtManagerName;
        private TextBox txtIDManager;
        private TextBox txtTaskName;
        private TextBox txtIDTask;
        private Button btInsertLd;
        private Button btDeleteLd;
    }
}