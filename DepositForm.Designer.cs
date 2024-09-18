namespace My_Bank_Project
{
    partial class DepositForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btFind = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAccountNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTotalBalances = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbUserNotFound = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbEneter = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.pbPerson = new System.Windows.Forms.PictureBox();
            this.lbLoginUserClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_Bank_Project.Properties.Resources.Deposittt;
            this.pictureBox1.Location = new System.Drawing.Point(12, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 387);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbHeader.Location = new System.Drawing.Point(440, 26);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(257, 39);
            this.lbHeader.TabIndex = 6;
            this.lbHeader.Text = "Dep$sit Screen";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbDate.Location = new System.Drawing.Point(42, 86);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(123, 23);
            this.lbDate.TabIndex = 8;
            this.lbDate.Text = "Client Data:";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.Black;
            this.lbUserName.Location = new System.Drawing.Point(499, 124);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(223, 23);
            this.lbUserName.TabIndex = 15;
            this.lbUserName.Text = "Enter Your UserName:";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(756, 119);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(174, 28);
            this.tbUserName.TabIndex = 16;
            // 
            // btFind
            // 
            this.btFind.BackColor = System.Drawing.Color.AliceBlue;
            this.btFind.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btFind.FlatAppearance.BorderSize = 2;
            this.btFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFind.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.ForeColor = System.Drawing.Color.ForestGreen;
            this.btFind.Location = new System.Drawing.Point(982, 114);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(121, 40);
            this.btFind.TabIndex = 17;
            this.btFind.Text = "Find User";
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmAccountNum,
            this.clmTotalBalances});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(46, 124);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(335, 175);
            this.listView2.TabIndex = 19;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 108;
            // 
            // clmAccountNum
            // 
            this.clmAccountNum.Text = "AccountNumber";
            this.clmAccountNum.Width = 103;
            // 
            // clmTotalBalances
            // 
            this.clmTotalBalances.Text = "TotalBalances";
            this.clmTotalBalances.Width = 111;
            // 
            // lbUserNotFound
            // 
            this.lbUserNotFound.AutoSize = true;
            this.lbUserNotFound.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserNotFound.ForeColor = System.Drawing.Color.Red;
            this.lbUserNotFound.Location = new System.Drawing.Point(43, 302);
            this.lbUserNotFound.Name = "lbUserNotFound";
            this.lbUserNotFound.Size = new System.Drawing.Size(0, 16);
            this.lbUserNotFound.TabIndex = 20;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnUser,
            this.columnAccount,
            this.columnBalance,
            this.columnAmount});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(513, 181);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(369, 87);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // columnUser
            // 
            this.columnUser.Text = "UserName";
            // 
            // columnAccount
            // 
            this.columnAccount.Text = "AccountNumber";
            this.columnAccount.Width = 91;
            // 
            // columnBalance
            // 
            this.columnBalance.Text = "Ac.Balance";
            // 
            // columnAmount
            // 
            this.columnAmount.Text = "Amount";
            // 
            // lbEneter
            // 
            this.lbEneter.AutoSize = true;
            this.lbEneter.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEneter.ForeColor = System.Drawing.Color.Black;
            this.lbEneter.Location = new System.Drawing.Point(494, 354);
            this.lbEneter.Name = "lbEneter";
            this.lbEneter.Size = new System.Drawing.Size(228, 23);
            this.lbEneter.TabIndex = 23;
            this.lbEneter.Text = "Enter Deposit Amount:";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(756, 349);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(174, 28);
            this.tbAmount.TabIndex = 24;
            // 
            // btEnter
            // 
            this.btEnter.BackColor = System.Drawing.Color.AliceBlue;
            this.btEnter.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btEnter.FlatAppearance.BorderSize = 2;
            this.btEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnter.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnter.ForeColor = System.Drawing.Color.ForestGreen;
            this.btEnter.Location = new System.Drawing.Point(736, 488);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(225, 40);
            this.btEnter.TabIndex = 25;
            this.btEnter.Text = "Perform";
            this.btEnter.UseVisualStyleBackColor = false;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // pbPerson
            // 
            this.pbPerson.Image = global::My_Bank_Project.Properties.Resources.Person1;
            this.pbPerson.Location = new System.Drawing.Point(29, 12);
            this.pbPerson.Name = "pbPerson";
            this.pbPerson.Size = new System.Drawing.Size(23, 36);
            this.pbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPerson.TabIndex = 27;
            this.pbPerson.TabStop = false;
            // 
            // lbLoginUserClient
            // 
            this.lbLoginUserClient.AutoSize = true;
            this.lbLoginUserClient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginUserClient.Location = new System.Drawing.Point(68, 22);
            this.lbLoginUserClient.Name = "lbLoginUserClient";
            this.lbLoginUserClient.Size = new System.Drawing.Size(0, 16);
            this.lbLoginUserClient.TabIndex = 26;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 739);
            this.Controls.Add(this.pbPerson);
            this.Controls.Add(this.lbLoginUserClient);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lbEneter);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbUserNotFound);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DepositForm";
            this.Text = "DepositForm";
            this.Load += new System.EventHandler(this.DepositForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmAccountNum;
        private System.Windows.Forms.ColumnHeader clmTotalBalances;
        private System.Windows.Forms.Label lbUserNotFound;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnUser;
        private System.Windows.Forms.ColumnHeader columnAccount;
        private System.Windows.Forms.ColumnHeader columnBalance;
        private System.Windows.Forms.ColumnHeader columnAmount;
        private System.Windows.Forms.Label lbEneter;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.PictureBox pbPerson;
        private System.Windows.Forms.Label lbLoginUserClient;
    }
}