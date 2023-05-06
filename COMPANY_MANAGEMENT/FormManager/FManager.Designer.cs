namespace COMPANY_MANAGEMENT
{
    partial class FManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FManager));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.grInfo = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtBirth = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.dGVBasic = new System.Windows.Forms.DataGridView();
            this.grOption = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btDistribution = new System.Windows.Forms.Button();
            this.btSalary = new System.Windows.Forms.Button();
            this.btMyInfo = new System.Windows.Forms.Button();
            this.btCheckIn_Out = new System.Windows.Forms.Button();
            this.btJob = new System.Windows.Forms.Button();
            this.btLetter = new System.Windows.Forms.Button();
            this.btContact = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.grInfo.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBasic)).BeginInit();
            this.grOption.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel1.Controls.Add(this.grInfo);
            this.flowLayoutPanel1.Controls.Add(this.dGVBasic);
            this.flowLayoutPanel1.Controls.Add(this.grOption);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1538, 688);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // grInfo
            // 
            this.grInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grInfo.BackgroundImage")));
            this.grInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grInfo.Controls.Add(this.flowLayoutPanel3);
            this.grInfo.Controls.Add(this.txtPass);
            this.grInfo.Controls.Add(this.label8);
            this.grInfo.Controls.Add(this.txtBasicSalary);
            this.grInfo.Controls.Add(this.txtAddress);
            this.grInfo.Controls.Add(this.label6);
            this.grInfo.Controls.Add(this.label5);
            this.grInfo.Controls.Add(this.txtIDCard);
            this.grInfo.Controls.Add(this.label4);
            this.grInfo.Controls.Add(this.txtEmail);
            this.grInfo.Controls.Add(this.label3);
            this.grInfo.Controls.Add(this.dtBirth);
            this.grInfo.Controls.Add(this.txtName);
            this.grInfo.Controls.Add(this.label2);
            this.grInfo.Controls.Add(this.label1);
            this.grInfo.Controls.Add(this.txtID);
            this.grInfo.Controls.Add(this.labID);
            this.grInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grInfo.Location = new System.Drawing.Point(3, 7);
            this.grInfo.Name = "grInfo";
            this.grInfo.Size = new System.Drawing.Size(451, 670);
            this.grInfo.TabIndex = 1;
            this.grInfo.TabStop = false;
            this.grInfo.Text = "INFORMATION";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btUpdate);
            this.flowLayoutPanel3.Controls.Add(this.btInsert);
            this.flowLayoutPanel3.Controls.Add(this.btDelete);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 617);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(451, 52);
            this.flowLayoutPanel3.TabIndex = 17;
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btUpdate.FlatAppearance.BorderSize = 0;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btUpdate.Image")));
            this.btUpdate.Location = new System.Drawing.Point(3, 3);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(139, 42);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btInsert.FlatAppearance.BorderSize = 0;
            this.btInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Image = ((System.Drawing.Image)(resources.GetObject("btInsert.Image")));
            this.btInsert.Location = new System.Drawing.Point(148, 3);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(140, 42);
            this.btInsert.TabIndex = 2;
            this.btInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btDelete.FlatAppearance.BorderSize = 0;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Image = ((System.Drawing.Image)(resources.GetObject("btDelete.Image")));
            this.btDelete.Location = new System.Drawing.Point(294, 3);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(146, 42);
            this.btDelete.TabIndex = 1;
            this.btDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(145, 537);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(261, 28);
            this.txtPass.TabIndex = 16;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 537);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Password";
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasicSalary.Location = new System.Drawing.Point(145, 453);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(261, 28);
            this.txtBasicSalary.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(145, 374);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(261, 28);
            this.txtAddress.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Basic salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCard.Location = new System.Drawing.Point(145, 241);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(261, 28);
            this.txtIDCard.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID card";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(148, 303);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(261, 28);
            this.txtEmail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // dtBirth
            // 
            this.dtBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirth.Location = new System.Drawing.Point(145, 177);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(261, 28);
            this.dtBirth.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(145, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(261, 28);
            this.txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date of birth";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(145, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(261, 28);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.BackColor = System.Drawing.Color.White;
            this.labID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labID.Location = new System.Drawing.Point(3, 51);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(27, 22);
            this.labID.TabIndex = 0;
            this.labID.Text = "ID";
            // 
            // dGVBasic
            // 
            this.dGVBasic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVBasic.BackgroundColor = System.Drawing.Color.White;
            this.dGVBasic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBasic.Location = new System.Drawing.Point(460, 9);
            this.dGVBasic.Name = "dGVBasic";
            this.dGVBasic.RowHeadersWidth = 51;
            this.dGVBasic.RowTemplate.Height = 24;
            this.dGVBasic.Size = new System.Drawing.Size(852, 667);
            this.dGVBasic.TabIndex = 0;
            this.dGVBasic.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVStaff_CellClick);
            // 
            // grOption
            // 
            this.grOption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grOption.Controls.Add(this.flowLayoutPanel2);
            this.grOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grOption.Location = new System.Drawing.Point(1318, 3);
            this.grOption.Name = "grOption";
            this.grOption.Size = new System.Drawing.Size(216, 679);
            this.grOption.TabIndex = 0;
            this.grOption.TabStop = false;
            this.grOption.Text = "OPTION";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btDistribution);
            this.flowLayoutPanel2.Controls.Add(this.btSalary);
            this.flowLayoutPanel2.Controls.Add(this.btMyInfo);
            this.flowLayoutPanel2.Controls.Add(this.btCheckIn_Out);
            this.flowLayoutPanel2.Controls.Add(this.btJob);
            this.flowLayoutPanel2.Controls.Add(this.btLetter);
            this.flowLayoutPanel2.Controls.Add(this.btContact);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 39);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(210, 634);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // btDistribution
            // 
            this.btDistribution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btDistribution.FlatAppearance.BorderSize = 0;
            this.btDistribution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDistribution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDistribution.Location = new System.Drawing.Point(3, 3);
            this.btDistribution.Name = "btDistribution";
            this.btDistribution.Size = new System.Drawing.Size(207, 86);
            this.btDistribution.TabIndex = 8;
            this.btDistribution.Text = "DISTRIBUTION";
            this.btDistribution.UseVisualStyleBackColor = false;
            this.btDistribution.Click += new System.EventHandler(this.btDistribution_Click);
            // 
            // btSalary
            // 
            this.btSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btSalary.FlatAppearance.BorderSize = 0;
            this.btSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalary.Location = new System.Drawing.Point(3, 95);
            this.btSalary.Name = "btSalary";
            this.btSalary.Size = new System.Drawing.Size(207, 93);
            this.btSalary.TabIndex = 7;
            this.btSalary.Text = "SALARY DETAILS";
            this.btSalary.UseVisualStyleBackColor = false;
            this.btSalary.Click += new System.EventHandler(this.btSalary_Click);
            // 
            // btMyInfo
            // 
            this.btMyInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btMyInfo.FlatAppearance.BorderSize = 0;
            this.btMyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMyInfo.Location = new System.Drawing.Point(3, 194);
            this.btMyInfo.Name = "btMyInfo";
            this.btMyInfo.Size = new System.Drawing.Size(207, 102);
            this.btMyInfo.TabIndex = 3;
            this.btMyInfo.Text = "MY INFORMATION";
            this.btMyInfo.UseVisualStyleBackColor = false;
            this.btMyInfo.Click += new System.EventHandler(this.btMyInfo_Click);
            // 
            // btCheckIn_Out
            // 
            this.btCheckIn_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btCheckIn_Out.FlatAppearance.BorderSize = 0;
            this.btCheckIn_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheckIn_Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckIn_Out.Location = new System.Drawing.Point(3, 302);
            this.btCheckIn_Out.Name = "btCheckIn_Out";
            this.btCheckIn_Out.Size = new System.Drawing.Size(207, 81);
            this.btCheckIn_Out.TabIndex = 5;
            this.btCheckIn_Out.Text = "CHECK IN/OUT";
            this.btCheckIn_Out.UseVisualStyleBackColor = false;
            this.btCheckIn_Out.Click += new System.EventHandler(this.btCheckIn_Out_Click);
            // 
            // btJob
            // 
            this.btJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btJob.FlatAppearance.BorderSize = 0;
            this.btJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJob.Location = new System.Drawing.Point(3, 389);
            this.btJob.Name = "btJob";
            this.btJob.Size = new System.Drawing.Size(207, 73);
            this.btJob.TabIndex = 9;
            this.btJob.Text = "JOB";
            this.btJob.UseVisualStyleBackColor = false;
            this.btJob.Click += new System.EventHandler(this.btJob_Click);
            // 
            // btLetter
            // 
            this.btLetter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btLetter.FlatAppearance.BorderSize = 0;
            this.btLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLetter.Location = new System.Drawing.Point(3, 468);
            this.btLetter.Name = "btLetter";
            this.btLetter.Size = new System.Drawing.Size(207, 80);
            this.btLetter.TabIndex = 10;
            this.btLetter.Text = "ABSENCE LETTER";
            this.btLetter.UseVisualStyleBackColor = false;
            this.btLetter.Click += new System.EventHandler(this.btLetter_Click);
            // 
            // btContact
            // 
            this.btContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btContact.FlatAppearance.BorderSize = 0;
            this.btContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContact.Location = new System.Drawing.Point(3, 554);
            this.btContact.Name = "btContact";
            this.btContact.Size = new System.Drawing.Size(207, 81);
            this.btContact.TabIndex = 11;
            this.btContact.Text = "CONTACT";
            this.btContact.UseVisualStyleBackColor = false;
            this.btContact.Click += new System.EventHandler(this.btContact_Click);
            // 
            // FManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1547, 699);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FManager";
            this.Text = "MANAGER";
            this.Load += new System.EventHandler(this.FManager_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.grInfo.ResumeLayout(false);
            this.grInfo.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBasic)).EndInit();
            this.grOption.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox grInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.DataGridView dGVBasic;
        private System.Windows.Forms.GroupBox grOption;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtBirth;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btCheckIn_Out;
        private System.Windows.Forms.Button btMyInfo;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSalary;
        private System.Windows.Forms.Button btDistribution;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btJob;
        private System.Windows.Forms.Button btLetter;
        private System.Windows.Forms.Button btContact;
    }
}