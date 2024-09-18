namespace My_Bank_Project
{
    partial class TransferForm
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
            this.lbHeader = new System.Windows.Forms.Label();
            this.btPerform = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnUserName = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbUserNotFound = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAccountNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTotalBalances = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbDate = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserRecever = new System.Windows.Forms.TextBox();
            this.lbUserNameReceve = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.lbLoginFailedUser2 = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.pbPerson = new System.Windows.Forms.PictureBox();
            this.lbLoginUserClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbHeader.Location = new System.Drawing.Point(449, 9);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(269, 39);
            this.lbHeader.TabIndex = 6;
            this.lbHeader.Text = "Transfer Screen";
            // 
            // btPerform
            // 
            this.btPerform.BackColor = System.Drawing.SystemColors.Control;
            this.btPerform.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btPerform.FlatAppearance.BorderSize = 2;
            this.btPerform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btPerform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPerform.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPerform.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btPerform.Location = new System.Drawing.Point(542, 548);
            this.btPerform.Name = "btPerform";
            this.btPerform.Size = new System.Drawing.Size(289, 55);
            this.btPerform.TabIndex = 5;
            this.btPerform.Text = "Perform";
            this.btPerform.UseVisualStyleBackColor = false;
            this.btPerform.Click += new System.EventHandler(this.btPerform_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_Bank_Project.Properties.Resources.transfers;
            this.pictureBox1.Location = new System.Drawing.Point(12, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lnUserName
            // 
            this.lnUserName.AutoSize = true;
            this.lnUserName.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnUserName.Location = new System.Drawing.Point(144, 93);
            this.lnUserName.Name = "lnUserName";
            this.lnUserName.Size = new System.Drawing.Size(164, 20);
            this.lnUserName.TabIndex = 8;
            this.lnUserName.Text = "Enter your UserName:";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(352, 85);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(142, 28);
            this.tbUserName.TabIndex = 9;
            // 
            // lbUserNotFound
            // 
            this.lbUserNotFound.AutoSize = true;
            this.lbUserNotFound.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserNotFound.ForeColor = System.Drawing.Color.Red;
            this.lbUserNotFound.Location = new System.Drawing.Point(145, 367);
            this.lbUserNotFound.Name = "lbUserNotFound";
            this.lbUserNotFound.Size = new System.Drawing.Size(0, 16);
            this.lbUserNotFound.TabIndex = 23;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmAccountNum,
            this.clmTotalBalances});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(148, 189);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(335, 175);
            this.listView2.TabIndex = 22;
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
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbDate.Location = new System.Drawing.Point(144, 151);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(123, 23);
            this.lbDate.TabIndex = 21;
            this.lbDate.Text = "Client Data:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(623, 189);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(335, 175);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AccountNumber";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TotalBalances";
            this.columnHeader3.Width = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(619, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Client Data:";
            // 
            // tbUserRecever
            // 
            this.tbUserRecever.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserRecever.Location = new System.Drawing.Point(890, 85);
            this.tbUserRecever.Name = "tbUserRecever";
            this.tbUserRecever.Size = new System.Drawing.Size(142, 28);
            this.tbUserRecever.TabIndex = 28;
            // 
            // lbUserNameReceve
            // 
            this.lbUserNameReceve.AutoSize = true;
            this.lbUserNameReceve.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserNameReceve.Location = new System.Drawing.Point(619, 89);
            this.lbUserNameReceve.Name = "lbUserNameReceve";
            this.lbUserNameReceve.Size = new System.Drawing.Size(226, 20);
            this.lbUserNameReceve.TabIndex = 27;
            this.lbUserNameReceve.Text = "Enter UserName to transfer to:";
            // 
            // tbAmount
            // 
            this.tbAmount.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(642, 413);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(142, 28);
            this.tbAmount.TabIndex = 30;
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.Location = new System.Drawing.Point(404, 417);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(191, 20);
            this.lbAmount.TabIndex = 29;
            this.lbAmount.Text = "Enter Amount to transfer:";
            // 
            // btFind
            // 
            this.btFind.BackColor = System.Drawing.SystemColors.Control;
            this.btFind.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btFind.FlatAppearance.BorderSize = 2;
            this.btFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFind.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btFind.Location = new System.Drawing.Point(1068, 71);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(108, 66);
            this.btFind.TabIndex = 31;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = false;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // lbLoginFailedUser2
            // 
            this.lbLoginFailedUser2.AutoSize = true;
            this.lbLoginFailedUser2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginFailedUser2.ForeColor = System.Drawing.Color.Red;
            this.lbLoginFailedUser2.Location = new System.Drawing.Point(609, 367);
            this.lbLoginFailedUser2.Name = "lbLoginFailedUser2";
            this.lbLoginFailedUser2.Size = new System.Drawing.Size(0, 16);
            this.lbLoginFailedUser2.TabIndex = 32;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(856, 413);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(320, 78);
            this.listView3.TabIndex = 33;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // listView4
            // 
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(856, 548);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(320, 78);
            this.listView4.TabIndex = 35;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // pbPerson
            // 
            this.pbPerson.Image = global::My_Bank_Project.Properties.Resources.Person1;
            this.pbPerson.Location = new System.Drawing.Point(24, 12);
            this.pbPerson.Name = "pbPerson";
            this.pbPerson.Size = new System.Drawing.Size(23, 36);
            this.pbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPerson.TabIndex = 37;
            this.pbPerson.TabStop = false;
            // 
            // lbLoginUserClient
            // 
            this.lbLoginUserClient.AutoSize = true;
            this.lbLoginUserClient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginUserClient.Location = new System.Drawing.Point(63, 22);
            this.lbLoginUserClient.Name = "lbLoginUserClient";
            this.lbLoginUserClient.Size = new System.Drawing.Size(0, 16);
            this.lbLoginUserClient.TabIndex = 36;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1219, 739);
            this.Controls.Add(this.pbPerson);
            this.Controls.Add(this.lbLoginUserClient);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.lbLoginFailedUser2);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.tbUserRecever);
            this.Controls.Add(this.lbUserNameReceve);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUserNotFound);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lnUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.btPerform);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btPerform;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lnUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbUserNotFound;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmAccountNum;
        private System.Windows.Forms.ColumnHeader clmTotalBalances;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserRecever;
        private System.Windows.Forms.Label lbUserNameReceve;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Label lbLoginFailedUser2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.PictureBox pbPerson;
        private System.Windows.Forms.Label lbLoginUserClient;
    }
}