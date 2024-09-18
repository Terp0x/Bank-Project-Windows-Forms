namespace My_Bank_Project
{
    partial class AddNewUser
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
            this.btColse = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbaddress = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txRole = new System.Windows.Forms.TextBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.pbPerson = new System.Windows.Forms.PictureBox();
            this.lbCurrentUser = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btColse
            // 
            this.btColse.BackColor = System.Drawing.Color.Aquamarine;
            this.btColse.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btColse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btColse.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btColse.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btColse.Location = new System.Drawing.Point(876, 607);
            this.btColse.Name = "btColse";
            this.btColse.Size = new System.Drawing.Size(177, 50);
            this.btColse.TabIndex = 41;
            this.btColse.Text = "Cancel";
            this.btColse.UseVisualStyleBackColor = false;
            this.btColse.Click += new System.EventHandler(this.btColse_Click);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.Aquamarine;
            this.btSave.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btSave.Location = new System.Drawing.Point(583, 607);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(177, 50);
            this.btSave.TabIndex = 40;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(975, 411);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 12, 30, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 24);
            this.dateTimePicker1.TabIndex = 39;
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBox1.Location = new System.Drawing.Point(578, 299);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 29);
            this.comboBox1.TabIndex = 38;
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(583, 402);
            this.tbUserName.MaxLength = 20;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(208, 28);
            this.tbUserName.TabIndex = 37;
            this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserName_Validating);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(583, 499);
            this.tbPassword.MaxLength = 20;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(208, 28);
            this.tbPassword.TabIndex = 36;
            this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbPassword_Validating);
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(938, 196);
            this.tbAddress.MaxLength = 200;
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(256, 153);
            this.tbAddress.TabIndex = 35;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(922, 100);
            this.tbEmail.MaxLength = 100;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(195, 28);
            this.tbEmail.TabIndex = 34;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(578, 187);
            this.tbPhone.MaxLength = 20;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(163, 28);
            this.tbPhone.TabIndex = 33;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(578, 91);
            this.tbName.MaxLength = 100;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(224, 28);
            this.tbName.TabIndex = 32;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(448, 503);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(93, 19);
            this.lbPassword.TabIndex = 31;
            this.lbPassword.Text = "Password:";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(448, 402);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(99, 19);
            this.lbUserName.TabIndex = 30;
            this.lbUserName.Text = "UserName:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(824, 411);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(112, 19);
            this.lbDate.TabIndex = 29;
            this.lbDate.Text = "DateOfBirth:";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(448, 299);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(74, 19);
            this.lbGender.TabIndex = 28;
            this.lbGender.Text = "Gender:";
            // 
            // lbaddress
            // 
            this.lbaddress.AutoSize = true;
            this.lbaddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaddress.Location = new System.Drawing.Point(843, 196);
            this.lbaddress.Name = "lbaddress";
            this.lbaddress.Size = new System.Drawing.Size(80, 19);
            this.lbaddress.TabIndex = 27;
            this.lbaddress.Text = "Address:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(448, 187);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(66, 19);
            this.lbPhone.TabIndex = 26;
            this.lbPhone.Text = "Phone:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(843, 100);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(60, 19);
            this.lbEmail.TabIndex = 25;
            this.lbEmail.Text = "Email:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(448, 91);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(62, 19);
            this.lbName.TabIndex = 24;
            this.lbName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(277, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 22;
            this.label1.Text = "Add New User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_Bank_Project.Properties.Resources.Add_C;
            this.pictureBox1.Location = new System.Drawing.Point(25, 373);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // txRole
            // 
            this.txRole.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRole.Location = new System.Drawing.Point(164, 178);
            this.txRole.MaxLength = 100;
            this.txRole.Name = "txRole";
            this.txRole.Size = new System.Drawing.Size(224, 28);
            this.txRole.TabIndex = 43;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.Location = new System.Drawing.Point(34, 178);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(71, 19);
            this.lbRole.TabIndex = 42;
            this.lbRole.Text = "RoleID:";
            // 
            // pbPerson
            // 
            this.pbPerson.Image = global::My_Bank_Project.Properties.Resources.Person1;
            this.pbPerson.Location = new System.Drawing.Point(12, 29);
            this.pbPerson.Name = "pbPerson";
            this.pbPerson.Size = new System.Drawing.Size(23, 36);
            this.pbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPerson.TabIndex = 46;
            this.pbPerson.TabStop = false;
            // 
            // lbCurrentUser
            // 
            this.lbCurrentUser.AutoSize = true;
            this.lbCurrentUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentUser.Location = new System.Drawing.Point(50, 49);
            this.lbCurrentUser.Name = "lbCurrentUser";
            this.lbCurrentUser.Size = new System.Drawing.Size(0, 16);
            this.lbCurrentUser.TabIndex = 45;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 100;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 739);
            this.Controls.Add(this.pbPerson);
            this.Controls.Add(this.lbCurrentUser);
            this.Controls.Add(this.txRole);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.btColse);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbaddress);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddNewUser";
            this.Text = "AddNewUser";
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btColse;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbaddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txRole;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.PictureBox pbPerson;
        private System.Windows.Forms.Label lbCurrentUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}