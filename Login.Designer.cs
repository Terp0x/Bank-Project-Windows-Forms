namespace My_Bank_Project
{
    partial class Login
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.bnLogin = new System.Windows.Forms.Button();
            this.lbLoginFailed = new System.Windows.Forms.Label();
            this.pbLoginHeader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.lbLogin.Location = new System.Drawing.Point(550, 184);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(105, 39);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Login";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(481, 308);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(249, 32);
            this.tbUserName.TabIndex = 2;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbUserName.Location = new System.Drawing.Point(321, 315);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(99, 19);
            this.lbUserName.TabIndex = 3;
            this.lbUserName.Text = "UserName:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lbPassword.Location = new System.Drawing.Point(321, 385);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(93, 19);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password:";
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.Location = new System.Drawing.Point(481, 378);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(249, 32);
            this.tbpassword.TabIndex = 5;
            // 
            // bnLogin
            // 
            this.bnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnLogin.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.bnLogin.Location = new System.Drawing.Point(481, 459);
            this.bnLogin.Name = "bnLogin";
            this.bnLogin.Size = new System.Drawing.Size(249, 51);
            this.bnLogin.TabIndex = 6;
            this.bnLogin.Text = "Login";
            this.bnLogin.UseVisualStyleBackColor = false;
            this.bnLogin.Click += new System.EventHandler(this.bnLogin_Click);
            // 
            // lbLoginFailed
            // 
            this.lbLoginFailed.AutoSize = true;
            this.lbLoginFailed.BackColor = System.Drawing.SystemColors.Control;
            this.lbLoginFailed.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginFailed.ForeColor = System.Drawing.Color.Red;
            this.lbLoginFailed.Location = new System.Drawing.Point(356, 536);
            this.lbLoginFailed.Name = "lbLoginFailed";
            this.lbLoginFailed.Size = new System.Drawing.Size(0, 18);
            this.lbLoginFailed.TabIndex = 7;
            // 
            // pbLoginHeader
            // 
            this.pbLoginHeader.Image = global::My_Bank_Project.Properties.Resources.Yes__I_am_;
            this.pbLoginHeader.Location = new System.Drawing.Point(503, 48);
            this.pbLoginHeader.Name = "pbLoginHeader";
            this.pbLoginHeader.Size = new System.Drawing.Size(199, 110);
            this.pbLoginHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoginHeader.TabIndex = 0;
            this.pbLoginHeader.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1219, 739);
            this.Controls.Add(this.lbLoginFailed);
            this.Controls.Add(this.bnLogin);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.pbLoginHeader);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLoginHeader;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Button bnLogin;
        private System.Windows.Forms.Label lbLoginFailed;
    }
}

