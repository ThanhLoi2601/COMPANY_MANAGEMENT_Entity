
namespace COMPANY_MANAGEMENT.FormStaff1
{
    partial class FAnnouncement
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.dtGVAnnou = new System.Windows.Forms.DataGridView();
            this.btLoadHightLight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVAnnou)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(68, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "ANNOUNCEMENT";
            // 
            // dtGVAnnou
            // 
            this.dtGVAnnou.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGVAnnou.BackgroundColor = System.Drawing.Color.White;
            this.dtGVAnnou.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVAnnou.GridColor = System.Drawing.Color.Black;
            this.dtGVAnnou.Location = new System.Drawing.Point(74, 96);
            this.dtGVAnnou.Margin = new System.Windows.Forms.Padding(4);
            this.dtGVAnnou.Name = "dtGVAnnou";
            this.dtGVAnnou.RowHeadersWidth = 51;
            this.dtGVAnnou.RowTemplate.Height = 24;
            this.dtGVAnnou.Size = new System.Drawing.Size(1086, 559);
            this.dtGVAnnou.TabIndex = 35;
            // 
            // btLoadHightLight
            // 
            this.btLoadHightLight.FlatAppearance.BorderSize = 0;
            this.btLoadHightLight.Image = global::COMPANY_MANAGEMENT.Properties.Resources._4b24f6325b54850adc45;
            this.btLoadHightLight.Location = new System.Drawing.Point(1013, 11);
            this.btLoadHightLight.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btLoadHightLight.Name = "btLoadHightLight";
            this.btLoadHightLight.Size = new System.Drawing.Size(147, 72);
            this.btLoadHightLight.TabIndex = 46;
            this.btLoadHightLight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLoadHightLight.UseVisualStyleBackColor = true;
            this.btLoadHightLight.Click += new System.EventHandler(this.btLoadHightLight_Click);
            // 
            // FAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 696);
            this.Controls.Add(this.btLoadHightLight);
            this.Controls.Add(this.dtGVAnnou);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FAnnouncement";
            this.Text = "Announcement";
            this.Load += new System.EventHandler(this.FAnnouncement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVAnnou)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtGVAnnou;
        private System.Windows.Forms.Button btLoadHightLight;
    }
}