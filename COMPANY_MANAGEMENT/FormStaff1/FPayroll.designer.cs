namespace COMPANY_MANAGEMENT.FormStaff1
{
    partial class FPayroll
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.textBonus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataCVHT = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textMonth = new System.Windows.Forms.TextBox();
            this.lbLuongCB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.dtGVLate = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataCVHT)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVLate)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(686, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tiền thưởng:";
            // 
            // txtFine
            // 
            this.txtFine.Enabled = false;
            this.txtFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFine.Location = new System.Drawing.Point(831, 141);
            this.txtFine.Name = "txtFine";
            this.txtFine.ReadOnly = true;
            this.txtFine.Size = new System.Drawing.Size(100, 27);
            this.txtFine.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(686, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tiền phạt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(696, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tiền lương tổng:";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.BackColor = System.Drawing.SystemColors.Info;
            this.lbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.Location = new System.Drawing.Point(859, 374);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(33, 20);
            this.lbSalary.TabIndex = 19;
            this.lbSalary.Text = "****";
            // 
            // textBonus
            // 
            this.textBonus.Location = new System.Drawing.Point(831, 90);
            this.textBonus.Name = "textBonus";
            this.textBonus.ReadOnly = true;
            this.textBonus.Size = new System.Drawing.Size(100, 22);
            this.textBonus.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "COMPLETE JOB";
            // 
            // dataCVHT
            // 
            this.dataCVHT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCVHT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataCVHT.BackgroundColor = System.Drawing.Color.White;
            this.dataCVHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCVHT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataCVHT.Location = new System.Drawing.Point(3, 28);
            this.dataCVHT.Name = "dataCVHT";
            this.dataCVHT.RowHeadersWidth = 51;
            this.dataCVHT.RowTemplate.Height = 24;
            this.dataCVHT.Size = new System.Drawing.Size(628, 378);
            this.dataCVHT.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.dataCVHT);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(639, 411);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(696, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tháng:";
            // 
            // textMonth
            // 
            this.textMonth.Location = new System.Drawing.Point(841, 426);
            this.textMonth.Name = "textMonth";
            this.textMonth.ReadOnly = true;
            this.textMonth.Size = new System.Drawing.Size(100, 22);
            this.textMonth.TabIndex = 23;
            // 
            // lbLuongCB
            // 
            this.lbLuongCB.AutoSize = true;
            this.lbLuongCB.BackColor = System.Drawing.SystemColors.Info;
            this.lbLuongCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuongCB.Location = new System.Drawing.Point(837, 50);
            this.lbLuongCB.Name = "lbLuongCB";
            this.lbLuongCB.Size = new System.Drawing.Size(33, 20);
            this.lbLuongCB.TabIndex = 13;
            this.lbLuongCB.Text = "****";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(686, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Lương cơ bản: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "MONTH";
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(112, 20);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 24);
            this.cbMonth.TabIndex = 25;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // dtGVLate
            // 
            this.dtGVLate.BackgroundColor = System.Drawing.Color.White;
            this.dtGVLate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVLate.Location = new System.Drawing.Point(690, 199);
            this.dtGVLate.Name = "dtGVLate";
            this.dtGVLate.RowHeadersWidth = 51;
            this.dtGVLate.RowTemplate.Height = 24;
            this.dtGVLate.Size = new System.Drawing.Size(298, 150);
            this.dtGVLate.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(686, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ngày đi trễ:";
            // 
            // FPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 475);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtGVLate);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBonus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLuongCB);
            this.Name = "FPayroll";
            this.Text = "PAYROLL";
            this.Load += new System.EventHandler(this.FPayroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCVHT)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVLate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.TextBox textBonus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataCVHT;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMonth;
        private System.Windows.Forms.Label lbLuongCB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.DataGridView dtGVLate;
        private System.Windows.Forms.Label label7;
    }
}