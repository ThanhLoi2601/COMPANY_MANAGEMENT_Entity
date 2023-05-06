namespace COMPANY_MANAGEMENT
{
    partial class FAbsenceLetter
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
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.rbRea1 = new System.Windows.Forms.RadioButton();
            this.rbRea2 = new System.Windows.Forms.RadioButton();
            this.rbRea3 = new System.Windows.Forms.RadioButton();
            this.rbRea4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.textName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textReason = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textNghi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textNgayNghi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(165, 333);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 22);
            this.dateStart.TabIndex = 0;
            // 
            // rbRea1
            // 
            this.rbRea1.AutoSize = true;
            this.rbRea1.Location = new System.Drawing.Point(93, 151);
            this.rbRea1.Name = "rbRea1";
            this.rbRea1.Size = new System.Drawing.Size(109, 20);
            this.rbRea1.TabIndex = 1;
            this.rbRea1.TabStop = true;
            this.rbRea1.Text = "Health issues";
            this.rbRea1.UseVisualStyleBackColor = true;
            // 
            // rbRea2
            // 
            this.rbRea2.AutoSize = true;
            this.rbRea2.Location = new System.Drawing.Point(93, 199);
            this.rbRea2.Name = "rbRea2";
            this.rbRea2.Size = new System.Drawing.Size(135, 20);
            this.rbRea2.TabIndex = 2;
            this.rbRea2.TabStop = true;
            this.rbRea2.Text = "Personal problem";
            this.rbRea2.UseVisualStyleBackColor = true;
            // 
            // rbRea3
            // 
            this.rbRea3.AutoSize = true;
            this.rbRea3.Location = new System.Drawing.Point(93, 246);
            this.rbRea3.Name = "rbRea3";
            this.rbRea3.Size = new System.Drawing.Size(270, 20);
            this.rbRea3.TabIndex = 3;
            this.rbRea3.TabStop = true;
            this.rbRea3.Text = "Care for a sick immediate family member";
            this.rbRea3.UseVisualStyleBackColor = true;
            // 
            // rbRea4
            // 
            this.rbRea4.AutoSize = true;
            this.rbRea4.Location = new System.Drawing.Point(93, 288);
            this.rbRea4.Name = "rbRea4";
            this.rbRea4.Size = new System.Drawing.Size(56, 20);
            this.rbRea4.TabIndex = 4;
            this.rbRea4.TabStop = true;
            this.rbRea4.Text = "Etc...";
            this.rbRea4.UseVisualStyleBackColor = true;
            this.rbRea4.CheckedChanged += new System.EventHandler(this.rbRea4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reasons";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "End date";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(165, 390);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 22);
            this.dateEnd.TabIndex = 12;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(165, 21);
            this.textName.Name = "textName";
            this.textName.ReadOnly = true;
            this.textName.Size = new System.Drawing.Size(200, 22);
            this.textName.TabIndex = 13;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(165, 66);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(200, 22);
            this.textID.TabIndex = 14;
            // 
            // textReason
            // 
            this.textReason.Location = new System.Drawing.Point(165, 285);
            this.textReason.Name = "textReason";
            this.textReason.Size = new System.Drawing.Size(200, 22);
            this.textReason.TabIndex = 15;
            this.textReason.Visible = false;
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Location = new System.Drawing.Point(404, 550);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(135, 43);
            this.btConfirm.TabIndex = 22;
            this.btConfirm.Text = "CONFIRM";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Số lần xin nghỉ trong tháng ";
            // 
            // textNghi
            // 
            this.textNghi.Location = new System.Drawing.Point(265, 439);
            this.textNghi.Name = "textNghi";
            this.textNghi.ReadOnly = true;
            this.textNghi.Size = new System.Drawing.Size(100, 22);
            this.textNghi.TabIndex = 24;
            this.textNghi.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Số ngày đã nghỉ";
            // 
            // textNgayNghi
            // 
            this.textNgayNghi.Location = new System.Drawing.Point(265, 488);
            this.textNgayNghi.Name = "textNgayNghi";
            this.textNgayNghi.ReadOnly = true;
            this.textNgayNghi.Size = new System.Drawing.Size(100, 22);
            this.textNgayNghi.TabIndex = 26;
            this.textNgayNghi.Text = "0";
            // 
            // FAbsenceLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 605);
            this.Controls.Add(this.textNgayNghi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textNghi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.textReason);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbRea4);
            this.Controls.Add(this.rbRea3);
            this.Controls.Add(this.rbRea2);
            this.Controls.Add(this.rbRea1);
            this.Controls.Add(this.dateStart);
            this.Name = "FAbsenceLetter";
            this.Text = "FAbsenceLetter";
            this.Load += new System.EventHandler(this.FAbsenceLetter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.RadioButton rbRea1;
        private System.Windows.Forms.RadioButton rbRea2;
        private System.Windows.Forms.RadioButton rbRea3;
        private System.Windows.Forms.RadioButton rbRea4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textReason;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNghi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNgayNghi;
    }
}