namespace COMPANY_MANAGEMENT
{
    partial class FSalary
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
            this.dtGVCmpTask = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThuong = new System.Windows.Forms.TextBox();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCmpTask = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongLuong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVCmpTask)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGVCmpTask
            // 
            this.dtGVCmpTask.BackgroundColor = System.Drawing.Color.White;
            this.dtGVCmpTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVCmpTask.Location = new System.Drawing.Point(32, 88);
            this.dtGVCmpTask.Margin = new System.Windows.Forms.Padding(4);
            this.dtGVCmpTask.Name = "dtGVCmpTask";
            this.dtGVCmpTask.RowHeadersWidth = 51;
            this.dtGVCmpTask.RowTemplate.Height = 24;
            this.dtGVCmpTask.Size = new System.Drawing.Size(355, 366);
            this.dtGVCmpTask.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "COMPLETE TASKS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tiền thưởng:";
            // 
            // txtThuong
            // 
            this.txtThuong.Location = new System.Drawing.Point(581, 216);
            this.txtThuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtThuong.Name = "txtThuong";
            this.txtThuong.ReadOnly = true;
            this.txtThuong.Size = new System.Drawing.Size(145, 27);
            this.txtThuong.TabIndex = 15;
            this.txtThuong.TextChanged += new System.EventHandler(this.txtThuong_TextChanged);
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Location = new System.Drawing.Point(581, 98);
            this.txtLuongCB.Margin = new System.Windows.Forms.Padding(4);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.ReadOnly = true;
            this.txtLuongCB.Size = new System.Drawing.Size(145, 27);
            this.txtLuongCB.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Lương cơ bản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(433, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tiền lương tổng:";
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "All month"});
            this.cbMonth.Location = new System.Drawing.Point(496, 36);
            this.cbMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(150, 28);
            this.cbMonth.TabIndex = 28;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(375, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "MONTH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Complete Tasks:";
            // 
            // txtCmpTask
            // 
            this.txtCmpTask.Location = new System.Drawing.Point(581, 162);
            this.txtCmpTask.Margin = new System.Windows.Forms.Padding(4);
            this.txtCmpTask.Name = "txtCmpTask";
            this.txtCmpTask.ReadOnly = true;
            this.txtCmpTask.Size = new System.Drawing.Size(145, 27);
            this.txtCmpTask.TabIndex = 31;
            this.txtCmpTask.TextChanged += new System.EventHandler(this.txtCmpTask_TextChanged);
            // 
            // label8
            // 
            this.label8.AccessibleDescription = "";
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(433, 269);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "Trên 10 tasks, thưởng 100000đ/task  ";
            // 
            // txtTongLuong
            // 
            this.txtTongLuong.Location = new System.Drawing.Point(582, 322);
            this.txtTongLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongLuong.Name = "txtTongLuong";
            this.txtTongLuong.ReadOnly = true;
            this.txtTongLuong.Size = new System.Drawing.Size(145, 27);
            this.txtTongLuong.TabIndex = 33;
            // 
            // FSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 475);
            this.Controls.Add(this.txtTongLuong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCmpTask);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLuongCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtThuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGVCmpTask);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FSalary";
            this.Text = "SALARY";
            this.Load += new System.EventHandler(this.FSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVCmpTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGVCmpTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThuong;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCmpTask;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongLuong;
    }
}