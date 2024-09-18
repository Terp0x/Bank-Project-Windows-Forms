namespace My_Bank_Project
{
    partial class MainMenuForm
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
            this.lbLoginUserClient = new System.Windows.Forms.Label();
            this.btClients = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btUsers = new System.Windows.Forms.Button();
            this.btTransactions = new System.Windows.Forms.Button();
            this.btCurrency = new System.Windows.Forms.Button();
            this.pbPerson = new System.Windows.Forms.PictureBox();
            this.pbMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLoginUserClient
            // 
            this.lbLoginUserClient.AutoSize = true;
            this.lbLoginUserClient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginUserClient.Location = new System.Drawing.Point(68, 36);
            this.lbLoginUserClient.Name = "lbLoginUserClient";
            this.lbLoginUserClient.Size = new System.Drawing.Size(0, 16);
            this.lbLoginUserClient.TabIndex = 1;
            // 
            // btClients
            // 
            this.btClients.BackColor = System.Drawing.SystemColors.Control;
            this.btClients.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btClients.FlatAppearance.BorderSize = 2;
            this.btClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClients.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClients.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btClients.Location = new System.Drawing.Point(676, 226);
            this.btClients.Name = "btClients";
            this.btClients.Size = new System.Drawing.Size(370, 66);
            this.btClients.TabIndex = 3;
            this.btClients.Text = "Manage Clients";
            this.btClients.UseVisualStyleBackColor = false;
            this.btClients.Click += new System.EventHandler(this.btClients_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbHeader.Location = new System.Drawing.Point(413, 38);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(310, 39);
            this.lbHeader.TabIndex = 4;
            this.lbHeader.Text = "Main Menu Screen";
            // 
            // btUsers
            // 
            this.btUsers.BackColor = System.Drawing.SystemColors.Control;
            this.btUsers.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btUsers.FlatAppearance.BorderSize = 2;
            this.btUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsers.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsers.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btUsers.Location = new System.Drawing.Point(676, 333);
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(370, 66);
            this.btUsers.TabIndex = 5;
            this.btUsers.Text = "Manage Users";
            this.btUsers.UseVisualStyleBackColor = false;
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // btTransactions
            // 
            this.btTransactions.BackColor = System.Drawing.SystemColors.Control;
            this.btTransactions.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btTransactions.FlatAppearance.BorderSize = 2;
            this.btTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTransactions.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTransactions.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btTransactions.Location = new System.Drawing.Point(676, 440);
            this.btTransactions.Name = "btTransactions";
            this.btTransactions.Size = new System.Drawing.Size(370, 66);
            this.btTransactions.TabIndex = 6;
            this.btTransactions.Text = "Transactions";
            this.btTransactions.UseVisualStyleBackColor = false;
            this.btTransactions.Click += new System.EventHandler(this.btTransactions_Click);
            // 
            // btCurrency
            // 
            this.btCurrency.BackColor = System.Drawing.SystemColors.Control;
            this.btCurrency.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btCurrency.FlatAppearance.BorderSize = 2;
            this.btCurrency.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCurrency.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCurrency.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btCurrency.Location = new System.Drawing.Point(676, 547);
            this.btCurrency.Name = "btCurrency";
            this.btCurrency.Size = new System.Drawing.Size(370, 66);
            this.btCurrency.TabIndex = 7;
            this.btCurrency.Text = "Currency Exchange";
            this.btCurrency.UseVisualStyleBackColor = false;
            // 
            // pbPerson
            // 
            this.pbPerson.Image = global::My_Bank_Project.Properties.Resources.Person1;
            this.pbPerson.Location = new System.Drawing.Point(29, 26);
            this.pbPerson.Name = "pbPerson";
            this.pbPerson.Size = new System.Drawing.Size(23, 36);
            this.pbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPerson.TabIndex = 2;
            this.pbPerson.TabStop = false;
            // 
            // pbMain
            // 
            this.pbMain.Image = global::My_Bank_Project.Properties.Resources.main;
            this.pbMain.Location = new System.Drawing.Point(29, 378);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(430, 349);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1219, 739);
            this.Controls.Add(this.btCurrency);
            this.Controls.Add(this.btTransactions);
            this.Controls.Add(this.btUsers);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.btClients);
            this.Controls.Add(this.pbPerson);
            this.Controls.Add(this.lbLoginUserClient);
            this.Controls.Add(this.pbMain);
            this.Name = "MainMenuForm";
            this.Text = "MainMenuForm";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Label lbLoginUserClient;
        private System.Windows.Forms.PictureBox pbPerson;
        private System.Windows.Forms.Button btClients;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btUsers;
        private System.Windows.Forms.Button btTransactions;
        private System.Windows.Forms.Button btCurrency;
    }
}