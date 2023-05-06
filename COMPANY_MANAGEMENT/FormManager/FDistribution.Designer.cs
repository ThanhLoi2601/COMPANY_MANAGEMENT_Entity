namespace COMPANY_MANAGEMENT
{
    partial class FDistribution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDistribution));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbTask = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDStaff = new System.Windows.Forms.TextBox();
            this.txtIDJob = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.dGVJob = new System.Windows.Forms.DataGridView();
            this.dGVStaff = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNameTaskJobList = new System.Windows.Forms.TextBox();
            this.cbTaskJobList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbProcess = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btRemove = new System.Windows.Forms.Button();
            this.lbNameStaff = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbNameJob = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbIDStaff = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbIDJob = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dGVDistribution = new System.Windows.Forms.DataGridView();
            this.txtNameTaskDis = new System.Windows.Forms.TextBox();
            this.cbTaskDis = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVJob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStaff)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTask
            // 
            this.cbTask.AutoSize = true;
            this.cbTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTask.Location = new System.Drawing.Point(19, 15);
            this.cbTask.Name = "cbTask";
            this.cbTask.Size = new System.Drawing.Size(108, 25);
            this.cbTask.TabIndex = 2;
            this.cbTask.Text = "JOB LIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "STAFF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(579, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Staff :";
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Location = new System.Drawing.Point(711, 14);
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.Size = new System.Drawing.Size(183, 22);
            this.txtIDStaff.TabIndex = 6;
            // 
            // txtIDJob
            // 
            this.txtIDJob.Location = new System.Drawing.Point(135, 16);
            this.txtIDJob.Name = "txtIDJob";
            this.txtIDJob.Size = new System.Drawing.Size(182, 22);
            this.txtIDJob.TabIndex = 8;
            this.txtIDJob.TextChanged += new System.EventHandler(this.txtIDJob_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Job :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "assigned to";
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Location = new System.Drawing.Point(1033, 27);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(153, 58);
            this.btConfirm.TabIndex = 10;
            this.btConfirm.Text = "CONFIRM";
            this.btConfirm.UseVisualStyleBackColor = false;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // dGVJob
            // 
            this.dGVJob.BackgroundColor = System.Drawing.Color.White;
            this.dGVJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVJob.Location = new System.Drawing.Point(19, 53);
            this.dGVJob.Name = "dGVJob";
            this.dGVJob.RowHeadersWidth = 51;
            this.dGVJob.RowTemplate.Height = 24;
            this.dGVJob.Size = new System.Drawing.Size(538, 304);
            this.dGVJob.TabIndex = 3;
            this.dGVJob.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVJob_CellClick);
            // 
            // dGVStaff
            // 
            this.dGVStaff.BackgroundColor = System.Drawing.Color.White;
            this.dGVStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVStaff.Location = new System.Drawing.Point(583, 53);
            this.dGVStaff.Name = "dGVStaff";
            this.dGVStaff.RowHeadersWidth = 51;
            this.dGVStaff.RowTemplate.Height = 24;
            this.dGVStaff.Size = new System.Drawing.Size(603, 304);
            this.dGVStaff.TabIndex = 0;
            this.dGVStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVStaff_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txtNameTaskJobList);
            this.groupBox1.Controls.Add(this.cbTaskJobList);
            this.groupBox1.Controls.Add(this.dGVJob);
            this.groupBox1.Controls.Add(this.cbTask);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dGVStaff);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1196, 363);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // txtNameTaskJobList
            // 
            this.txtNameTaskJobList.Location = new System.Drawing.Point(384, 25);
            this.txtNameTaskJobList.Name = "txtNameTaskJobList";
            this.txtNameTaskJobList.ReadOnly = true;
            this.txtNameTaskJobList.Size = new System.Drawing.Size(153, 22);
            this.txtNameTaskJobList.TabIndex = 11;
            // 
            // cbTaskJobList
            // 
            this.cbTaskJobList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaskJobList.FormattingEnabled = true;
            this.cbTaskJobList.Location = new System.Drawing.Point(217, 23);
            this.cbTaskJobList.Name = "cbTaskJobList";
            this.cbTaskJobList.Size = new System.Drawing.Size(144, 24);
            this.cbTaskJobList.TabIndex = 5;
            this.cbTaskJobList.SelectedIndexChanged += new System.EventHandler(this.combTask_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btConfirm);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtIDStaff);
            this.groupBox2.Controls.Add(this.txtIDJob);
            this.groupBox2.Location = new System.Drawing.Point(12, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1196, 91);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.txtNameTaskDis);
            this.groupBox3.Controls.Add(this.cbTaskDis);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lbProcess);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btRemove);
            this.groupBox3.Controls.Add(this.lbNameStaff);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lbNameJob);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lbIDStaff);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lbIDJob);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dGVDistribution);
            this.groupBox3.Location = new System.Drawing.Point(12, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1196, 240);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(876, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "%";
            // 
            // lbProcess
            // 
            this.lbProcess.AutoSize = true;
            this.lbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcess.Location = new System.Drawing.Point(818, 169);
            this.lbProcess.Name = "lbProcess";
            this.lbProcess.Size = new System.Drawing.Size(52, 25);
            this.lbProcess.TabIndex = 21;
            this.lbProcess.Text = "*****";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(639, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Work completed :";
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Location = new System.Drawing.Point(960, 154);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(153, 58);
            this.btRemove.TabIndex = 19;
            this.btRemove.Text = "REMOVE";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // lbNameStaff
            // 
            this.lbNameStaff.AutoSize = true;
            this.lbNameStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameStaff.Location = new System.Drawing.Point(1050, 104);
            this.lbNameStaff.Name = "lbNameStaff";
            this.lbNameStaff.Size = new System.Drawing.Size(39, 20);
            this.lbNameStaff.TabIndex = 16;
            this.lbNameStaff.Text = "*****";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(902, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Name Staff:";
            // 
            // lbNameJob
            // 
            this.lbNameJob.AutoSize = true;
            this.lbNameJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameJob.Location = new System.Drawing.Point(751, 104);
            this.lbNameJob.Name = "lbNameJob";
            this.lbNameJob.Size = new System.Drawing.Size(39, 20);
            this.lbNameJob.TabIndex = 14;
            this.lbNameJob.Text = "*****";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(630, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Name Job :";
            // 
            // lbIDStaff
            // 
            this.lbIDStaff.AutoSize = true;
            this.lbIDStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDStaff.Location = new System.Drawing.Point(1049, 41);
            this.lbIDStaff.Name = "lbIDStaff";
            this.lbIDStaff.Size = new System.Drawing.Size(39, 20);
            this.lbIDStaff.TabIndex = 12;
            this.lbIDStaff.Text = "*****";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(931, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "ID Staff:";
            // 
            // lbIDJob
            // 
            this.lbIDJob.AutoSize = true;
            this.lbIDJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDJob.Location = new System.Drawing.Point(751, 41);
            this.lbIDJob.Name = "lbIDJob";
            this.lbIDJob.Size = new System.Drawing.Size(39, 20);
            this.lbIDJob.TabIndex = 10;
            this.lbIDJob.Text = "*****";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(659, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID Job :";
            // 
            // dGVDistribution
            // 
            this.dGVDistribution.BackgroundColor = System.Drawing.Color.White;
            this.dGVDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVDistribution.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGVDistribution.Location = new System.Drawing.Point(6, 12);
            this.dGVDistribution.Name = "dGVDistribution";
            this.dGVDistribution.RowHeadersWidth = 51;
            this.dGVDistribution.RowTemplate.Height = 24;
            this.dGVDistribution.Size = new System.Drawing.Size(591, 220);
            this.dGVDistribution.TabIndex = 0;
            this.dGVDistribution.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDistribution_CellClick);
            // 
            // txtNameTaskDis
            // 
            this.txtNameTaskDis.Location = new System.Drawing.Point(753, 14);
            this.txtNameTaskDis.Name = "txtNameTaskDis";
            this.txtNameTaskDis.ReadOnly = true;
            this.txtNameTaskDis.Size = new System.Drawing.Size(153, 22);
            this.txtNameTaskDis.TabIndex = 24;
            // 
            // cbTaskDis
            // 
            this.cbTaskDis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaskDis.FormattingEnabled = true;
            this.cbTaskDis.Location = new System.Drawing.Point(609, 14);
            this.cbTaskDis.Name = "cbTaskDis";
            this.cbTaskDis.Size = new System.Drawing.Size(126, 24);
            this.cbTaskDis.TabIndex = 23;
            this.cbTaskDis.SelectedIndexChanged += new System.EventHandler(this.cbTaskDis_SelectedIndexChanged);
            // 
            // FDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 716);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FDistribution";
            this.Text = "DISTRIBUTION";
            this.Load += new System.EventHandler(this.FDistribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVJob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVStaff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDistribution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cbTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDStaff;
        private System.Windows.Forms.TextBox txtIDJob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.DataGridView dGVJob;
        private System.Windows.Forms.DataGridView dGVStaff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dGVDistribution;
        private System.Windows.Forms.Label lbNameStaff;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbNameJob;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbIDStaff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbIDJob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbProcess;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTaskJobList;
        private System.Windows.Forms.TextBox txtNameTaskJobList;
        private System.Windows.Forms.TextBox txtNameTaskDis;
        private System.Windows.Forms.ComboBox cbTaskDis;
    }
}