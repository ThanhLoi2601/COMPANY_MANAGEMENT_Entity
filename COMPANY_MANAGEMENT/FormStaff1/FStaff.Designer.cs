namespace COMPANY_MANAGEMENT.FormStaff1
{
    partial class FStaff
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataStaff = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAnnounce = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.btChangePass = new System.Windows.Forms.Button();
            this.btInform = new System.Windows.Forms.Button();
            this.btPayroll = new System.Windows.Forms.Button();
            this.btLetter = new System.Windows.Forms.Button();
            this.btCheckInOut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btMin = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chJob = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btLoadHightLight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chJob)).BeginInit();
            this.SuspendLayout();
            // 
            // dataStaff
            // 
            this.dataStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataStaff.BackgroundColor = System.Drawing.Color.White;
            this.dataStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStaff.Location = new System.Drawing.Point(0, 76);
            this.dataStaff.Margin = new System.Windows.Forms.Padding(4);
            this.dataStaff.Name = "dataStaff";
            this.dataStaff.ReadOnly = true;
            this.dataStaff.RowHeadersWidth = 51;
            this.dataStaff.RowTemplate.Height = 24;
            this.dataStaff.Size = new System.Drawing.Size(958, 659);
            this.dataStaff.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.panel1.Controls.Add(this.btAnnounce);
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Controls.Add(this.btChangePass);
            this.panel1.Controls.Add(this.btInform);
            this.panel1.Controls.Add(this.btPayroll);
            this.panel1.Controls.Add(this.btLetter);
            this.panel1.Controls.Add(this.btCheckInOut);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 782);
            this.panel1.TabIndex = 30;
            // 
            // btAnnounce
            // 
            this.btAnnounce.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAnnounce.FlatAppearance.BorderSize = 0;
            this.btAnnounce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btAnnounce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnnounce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnounce.ForeColor = System.Drawing.Color.White;
            this.btAnnounce.Image = global::COMPANY_MANAGEMENT.Properties.Resources.commercial_26px;
            this.btAnnounce.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAnnounce.Location = new System.Drawing.Point(0, 675);
            this.btAnnounce.Margin = new System.Windows.Forms.Padding(4);
            this.btAnnounce.Name = "btAnnounce";
            this.btAnnounce.Size = new System.Drawing.Size(284, 84);
            this.btAnnounce.TabIndex = 38;
            this.btAnnounce.Text = "ANNOUNCEMENT";
            this.btAnnounce.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAnnounce.UseVisualStyleBackColor = true;
            this.btAnnounce.Click += new System.EventHandler(this.btAnnounce_Click);
            // 
            // btHome
            // 
            this.btHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Image = global::COMPANY_MANAGEMENT.Properties.Resources.home_26px;
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.Location = new System.Drawing.Point(0, 591);
            this.btHome.Margin = new System.Windows.Forms.Padding(4);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(284, 84);
            this.btHome.TabIndex = 37;
            this.btHome.Text = "HOME";
            this.btHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btChangePass
            // 
            this.btChangePass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btChangePass.FlatAppearance.BorderSize = 0;
            this.btChangePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangePass.ForeColor = System.Drawing.Color.White;
            this.btChangePass.Image = global::COMPANY_MANAGEMENT.Properties.Resources.password_26px;
            this.btChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChangePass.Location = new System.Drawing.Point(0, 515);
            this.btChangePass.Margin = new System.Windows.Forms.Padding(4);
            this.btChangePass.Name = "btChangePass";
            this.btChangePass.Size = new System.Drawing.Size(284, 76);
            this.btChangePass.TabIndex = 36;
            this.btChangePass.Text = "CHANGE PASSWORD";
            this.btChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btChangePass.UseVisualStyleBackColor = true;
            this.btChangePass.Click += new System.EventHandler(this.btChangePass_Click_1);
            // 
            // btInform
            // 
            this.btInform.Dock = System.Windows.Forms.DockStyle.Top;
            this.btInform.FlatAppearance.BorderSize = 0;
            this.btInform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btInform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInform.ForeColor = System.Drawing.Color.White;
            this.btInform.Image = global::COMPANY_MANAGEMENT.Properties.Resources.profile_26px;
            this.btInform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInform.Location = new System.Drawing.Point(0, 439);
            this.btInform.Margin = new System.Windows.Forms.Padding(4);
            this.btInform.Name = "btInform";
            this.btInform.Size = new System.Drawing.Size(284, 76);
            this.btInform.TabIndex = 35;
            this.btInform.Text = "INFORMATION";
            this.btInform.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInform.UseVisualStyleBackColor = true;
            this.btInform.Click += new System.EventHandler(this.btInform_Click_1);
            // 
            // btPayroll
            // 
            this.btPayroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPayroll.FlatAppearance.BorderSize = 0;
            this.btPayroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPayroll.ForeColor = System.Drawing.Color.White;
            this.btPayroll.Image = global::COMPANY_MANAGEMENT.Properties.Resources.money_transfer_26px;
            this.btPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPayroll.Location = new System.Drawing.Point(0, 363);
            this.btPayroll.Margin = new System.Windows.Forms.Padding(4);
            this.btPayroll.Name = "btPayroll";
            this.btPayroll.Size = new System.Drawing.Size(284, 76);
            this.btPayroll.TabIndex = 34;
            this.btPayroll.Text = "PAYROLL";
            this.btPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPayroll.UseVisualStyleBackColor = true;
            this.btPayroll.Click += new System.EventHandler(this.btPayroll_Click_1);
            // 
            // btLetter
            // 
            this.btLetter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btLetter.FlatAppearance.BorderSize = 0;
            this.btLetter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLetter.ForeColor = System.Drawing.Color.White;
            this.btLetter.Image = global::COMPANY_MANAGEMENT.Properties.Resources.leave_26px1;
            this.btLetter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLetter.Location = new System.Drawing.Point(0, 287);
            this.btLetter.Margin = new System.Windows.Forms.Padding(4);
            this.btLetter.Name = "btLetter";
            this.btLetter.Size = new System.Drawing.Size(284, 76);
            this.btLetter.TabIndex = 33;
            this.btLetter.Text = "ABSENCE LETTER";
            this.btLetter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLetter.UseVisualStyleBackColor = true;
            this.btLetter.Click += new System.EventHandler(this.btLetter_Click_1);
            // 
            // btCheckInOut
            // 
            this.btCheckInOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCheckInOut.FlatAppearance.BorderSize = 0;
            this.btCheckInOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btCheckInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckInOut.ForeColor = System.Drawing.Color.White;
            this.btCheckInOut.Image = global::COMPANY_MANAGEMENT.Properties.Resources.checkmark_26px;
            this.btCheckInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCheckInOut.Location = new System.Drawing.Point(0, 206);
            this.btCheckInOut.Margin = new System.Windows.Forms.Padding(4);
            this.btCheckInOut.Name = "btCheckInOut";
            this.btCheckInOut.Size = new System.Drawing.Size(284, 81);
            this.btCheckInOut.TabIndex = 21;
            this.btCheckInOut.Text = "CHECK IN/OUT";
            this.btCheckInOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCheckInOut.UseVisualStyleBackColor = true;
            this.btCheckInOut.Click += new System.EventHandler(this.btCheckInOut_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picAvatar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(284, 206);
            this.panel3.TabIndex = 32;
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(64, 31);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(148, 144);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            this.picAvatar.DoubleClick += new System.EventHandler(this.picAvatar_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btMin);
            this.panel2.Controls.Add(this.btClose);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(284, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 42);
            this.panel2.TabIndex = 31;
            // 
            // btMin
            // 
            this.btMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(21)))));
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Image = global::COMPANY_MANAGEMENT.Properties.Resources.minimize_window_30px;
            this.btMin.Location = new System.Drawing.Point(1051, 3);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(79, 32);
            this.btMin.TabIndex = 3;
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(21)))));
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::COMPANY_MANAGEMENT.Properties.Resources.close_window_30px;
            this.btClose.Location = new System.Drawing.Point(1148, 4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(79, 32);
            this.btClose.TabIndex = 1;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(350, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(524, 48);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "DANH SÁCH CÔNG VIỆC ĐƯỢC PHÂN CÔNG";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.chJob);
            this.panel5.Controls.Add(this.btLoadHightLight);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.dataStaff);
            this.panel5.Location = new System.Drawing.Point(284, 43);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1239, 749);
            this.panel5.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(965, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Red";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1032, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Overdue";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Orange;
            this.label17.Location = new System.Drawing.Point(965, 193);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 20);
            this.label17.TabIndex = 49;
            this.label17.Text = "Orange";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(1041, 244);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 20);
            this.label16.TabIndex = 48;
            this.label16.Text = "Not started yet";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(1032, 193);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(204, 20);
            this.label18.TabIndex = 50;
            this.label18.Text = "Warning is about to expire";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(1041, 300);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(103, 20);
            this.label20.TabIndex = 52;
            this.label20.Text = "Change data";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Yellow;
            this.label19.Location = new System.Drawing.Point(965, 300);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 20);
            this.label19.TabIndex = 51;
            this.label19.Text = "Yellow";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.SkyBlue;
            this.label15.Location = new System.Drawing.Point(965, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 20);
            this.label15.TabIndex = 47;
            this.label15.Text = "SkyBlue";
            // 
            // chJob
            // 
            chartArea1.Name = "ChartArea1";
            this.chJob.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chJob.Legends.Add(legend1);
            this.chJob.Location = new System.Drawing.Point(965, 376);
            this.chJob.Name = "chJob";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chJob.Series.Add(series1);
            this.chJob.Size = new System.Drawing.Size(262, 300);
            this.chJob.TabIndex = 54;
            this.chJob.Text = "chart1";
            // 
            // btLoadHightLight
            // 
            this.btLoadHightLight.FlatAppearance.BorderSize = 0;
            this.btLoadHightLight.Image = global::COMPANY_MANAGEMENT.Properties.Resources._4b24f6325b54850adc45;
            this.btLoadHightLight.Location = new System.Drawing.Point(983, 60);
            this.btLoadHightLight.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btLoadHightLight.Name = "btLoadHightLight";
            this.btLoadHightLight.Size = new System.Drawing.Size(147, 72);
            this.btLoadHightLight.TabIndex = 53;
            this.btLoadHightLight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLoadHightLight.UseVisualStyleBackColor = true;
            this.btLoadHightLight.Click += new System.EventHandler(this.btLoadHightLight_Click);
            // 
            // FStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1523, 782);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FStaff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.FStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStaff)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chJob)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btChangePass;
        private System.Windows.Forms.Button btInform;
        private System.Windows.Forms.Button btPayroll;
        private System.Windows.Forms.Button btLetter;
        private System.Windows.Forms.Button btCheckInOut;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btAnnounce;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataVisualization.Charting.Chart chJob;
        private System.Windows.Forms.Button btLoadHightLight;
    }
}