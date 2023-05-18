namespace COMPANY_MANAGEMENT.FormStaff1
{
    partial class FCheck
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkOUT = new System.Windows.Forms.CheckBox();
            this.checkIN = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbDsCV = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textTienDo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeCheck = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btReport = new System.Windows.Forms.Button();
            this.btConfirm = new System.Windows.Forms.Button();
            this.chProc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chProc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkOUT);
            this.groupBox1.Controls.Add(this.checkIN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 228);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(209, 125);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPTION";
            // 
            // checkOUT
            // 
            this.checkOUT.AutoSize = true;
            this.checkOUT.Location = new System.Drawing.Point(19, 88);
            this.checkOUT.Margin = new System.Windows.Forms.Padding(4);
            this.checkOUT.Name = "checkOUT";
            this.checkOUT.Size = new System.Drawing.Size(113, 24);
            this.checkOUT.TabIndex = 9;
            this.checkOUT.Text = "CheckOut";
            this.checkOUT.UseVisualStyleBackColor = true;
            this.checkOUT.CheckedChanged += new System.EventHandler(this.checkOUT_CheckedChanged);
            // 
            // checkIN
            // 
            this.checkIN.AutoSize = true;
            this.checkIN.Location = new System.Drawing.Point(19, 32);
            this.checkIN.Margin = new System.Windows.Forms.Padding(4);
            this.checkIN.Name = "checkIN";
            this.checkIN.Size = new System.Drawing.Size(98, 24);
            this.checkIN.TabIndex = 8;
            this.checkIN.Text = "CheckIn";
            this.checkIN.UseVisualStyleBackColor = true;
            this.checkIN.CheckedChanged += new System.EventHandler(this.checkIN_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "TIME";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbDsCV
            // 
            this.cbDsCV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDsCV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDsCV.FormattingEnabled = true;
            this.cbDsCV.Location = new System.Drawing.Point(342, 500);
            this.cbDsCV.Margin = new System.Windows.Forms.Padding(4);
            this.cbDsCV.Name = "cbDsCV";
            this.cbDsCV.Size = new System.Drawing.Size(232, 28);
            this.cbDsCV.TabIndex = 25;
            this.cbDsCV.SelectedIndexChanged += new System.EventHandler(this.cbDsCV_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 500);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "All job";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 579);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Process job (%)";
            // 
            // textTienDo
            // 
            this.textTienDo.Location = new System.Drawing.Point(342, 579);
            this.textTienDo.Margin = new System.Windows.Forms.Padding(4);
            this.textTienDo.Name = "textTienDo";
            this.textTienDo.Size = new System.Drawing.Size(232, 27);
            this.textTienDo.TabIndex = 29;
            this.textTienDo.TextChanged += new System.EventHandler(this.textTienDo_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(68, 429);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "TO-DO LIST AND SCHEDULE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Check date";
            // 
            // dateTimeCheck
            // 
            this.dateTimeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeCheck.Location = new System.Drawing.Point(262, 75);
            this.dateTimeCheck.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeCheck.Name = "dateTimeCheck";
            this.dateTimeCheck.Size = new System.Drawing.Size(346, 27);
            this.dateTimeCheck.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(68, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "TO-DO LIST AND SCHEDULE";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(342, 652);
            this.textID.Margin = new System.Windows.Forms.Padding(4);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(232, 27);
            this.textID.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 652);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "ID job";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::COMPANY_MANAGEMENT.Properties.Resources.c0674586a8e076be2ff1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(73, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 61);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // btReport
            // 
            this.btReport.FlatAppearance.BorderSize = 0;
            this.btReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReport.Image = global::COMPANY_MANAGEMENT.Properties.Resources.Task_60px;
            this.btReport.Location = new System.Drawing.Point(639, 570);
            this.btReport.Margin = new System.Windows.Forms.Padding(4);
            this.btReport.Name = "btReport";
            this.btReport.Size = new System.Drawing.Size(182, 73);
            this.btReport.TabIndex = 30;
            this.btReport.Text = "REPORT";
            this.btReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btReport.UseVisualStyleBackColor = true;
            this.btReport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // btConfirm
            // 
            this.btConfirm.FlatAppearance.BorderSize = 0;
            this.btConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Image = global::COMPANY_MANAGEMENT.Properties.Resources.checkmark_60px;
            this.btConfirm.Location = new System.Drawing.Point(382, 274);
            this.btConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(171, 79);
            this.btConfirm.TabIndex = 24;
            this.btConfirm.Text = "CONFIRM";
            this.btConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // chProc
            // 
            chartArea1.Name = "ChartArea1";
            this.chProc.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chProc.Legends.Add(legend1);
            this.chProc.Location = new System.Drawing.Point(672, 251);
            this.chProc.Name = "chProc";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chProc.Series.Add(series1);
            this.chProc.Size = new System.Drawing.Size(300, 300);
            this.chProc.TabIndex = 38;
            this.chProc.Text = "chProc";
            // 
            // FCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 695);
            this.Controls.Add(this.chProc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btReport);
            this.Controls.Add(this.textTienDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDsCV);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeCheck);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FCheck";
            this.Text = "Check";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FCheck_FormClosing);
            this.Load += new System.EventHandler(this.FCheck_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chProc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.CheckBox checkOUT;
        private System.Windows.Forms.CheckBox checkIN;
        private System.Windows.Forms.ComboBox cbDsCV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTienDo;
        private System.Windows.Forms.Button btReport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chProc;
    }
}