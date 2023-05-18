using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPANY_MANAGEMENT.FormStaff1
{
    partial class FChangePassWord
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textMaDN = new System.Windows.Forms.TextBox();
            this.textOldPass = new System.Windows.Forms.TextBox();
            this.textNewPass = new System.Windows.Forms.TextBox();
            this.textNewPassConfirm = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Old password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "New password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm new password";
            // 
            // textMaDN
            // 
            this.textMaDN.Location = new System.Drawing.Point(223, 27);
            this.textMaDN.Margin = new System.Windows.Forms.Padding(4);
            this.textMaDN.Name = "textMaDN";
            this.textMaDN.ReadOnly = true;
            this.textMaDN.Size = new System.Drawing.Size(278, 27);
            this.textMaDN.TabIndex = 4;
            // 
            // textOldPass
            // 
            this.textOldPass.Location = new System.Drawing.Point(223, 86);
            this.textOldPass.Margin = new System.Windows.Forms.Padding(4);
            this.textOldPass.Name = "textOldPass";
            this.textOldPass.Size = new System.Drawing.Size(278, 27);
            this.textOldPass.TabIndex = 5;
            // 
            // textNewPass
            // 
            this.textNewPass.Location = new System.Drawing.Point(223, 155);
            this.textNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.textNewPass.Name = "textNewPass";
            this.textNewPass.Size = new System.Drawing.Size(278, 27);
            this.textNewPass.TabIndex = 6;
            // 
            // textNewPassConfirm
            // 
            this.textNewPassConfirm.Location = new System.Drawing.Point(223, 214);
            this.textNewPassConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.textNewPassConfirm.Name = "textNewPassConfirm";
            this.textNewPassConfirm.Size = new System.Drawing.Size(278, 27);
            this.textNewPassConfirm.TabIndex = 7;
            // 
            // btConfirm
            // 
            this.btConfirm.FlatAppearance.BorderSize = 0;
            this.btConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirm.Image = global::COMPANY_MANAGEMENT.Properties.Resources.checkmark_60px;
            this.btConfirm.Location = new System.Drawing.Point(402, 249);
            this.btConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(169, 69);
            this.btConfirm.TabIndex = 23;
            this.btConfirm.Text = "CONFIRM";
            this.btConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // FChangePassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 321);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.textNewPassConfirm);
            this.Controls.Add(this.textNewPass);
            this.Controls.Add(this.textOldPass);
            this.Controls.Add(this.textMaDN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FChangePassWord";
            this.Text = "Change password";
            this.Load += new System.EventHandler(this.FChangePassWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMaDN;
        private System.Windows.Forms.TextBox textOldPass;
        private System.Windows.Forms.TextBox textNewPass;
        private System.Windows.Forms.TextBox textNewPassConfirm;
        private System.Windows.Forms.Button btConfirm;
    }
}