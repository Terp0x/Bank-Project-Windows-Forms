namespace My_Bank_Project
{
    partial class TransactionsForm
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
            this.btDeposit = new System.Windows.Forms.Button();
            this.btWithdraw = new System.Windows.Forms.Button();
            this.btTransfer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.lbHeader.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbHeader.Location = new System.Drawing.Point(409, 44);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(339, 39);
            this.lbHeader.TabIndex = 5;
            this.lbHeader.Text = "Transactions Screen";
            // 
            // btDeposit
            // 
            this.btDeposit.BackColor = System.Drawing.Color.AliceBlue;
            this.btDeposit.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btDeposit.FlatAppearance.BorderSize = 2;
            this.btDeposit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeposit.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeposit.ForeColor = System.Drawing.Color.ForestGreen;
            this.btDeposit.Location = new System.Drawing.Point(711, 254);
            this.btDeposit.Name = "btDeposit";
            this.btDeposit.Size = new System.Drawing.Size(320, 55);
            this.btDeposit.TabIndex = 6;
            this.btDeposit.Text = "Deposit";
            this.btDeposit.UseVisualStyleBackColor = false;
            this.btDeposit.Click += new System.EventHandler(this.btDeposit_Click);
            // 
            // btWithdraw
            // 
            this.btWithdraw.BackColor = System.Drawing.Color.AliceBlue;
            this.btWithdraw.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btWithdraw.FlatAppearance.BorderSize = 2;
            this.btWithdraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btWithdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btWithdraw.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWithdraw.ForeColor = System.Drawing.Color.ForestGreen;
            this.btWithdraw.Location = new System.Drawing.Point(711, 373);
            this.btWithdraw.Name = "btWithdraw";
            this.btWithdraw.Size = new System.Drawing.Size(320, 55);
            this.btWithdraw.TabIndex = 7;
            this.btWithdraw.Text = "Withdraw";
            this.btWithdraw.UseVisualStyleBackColor = false;
            this.btWithdraw.Click += new System.EventHandler(this.btWithdraw_Click);
            // 
            // btTransfer
            // 
            this.btTransfer.BackColor = System.Drawing.Color.AliceBlue;
            this.btTransfer.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btTransfer.FlatAppearance.BorderSize = 2;
            this.btTransfer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btTransfer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTransfer.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTransfer.ForeColor = System.Drawing.Color.ForestGreen;
            this.btTransfer.Location = new System.Drawing.Point(711, 492);
            this.btTransfer.Name = "btTransfer";
            this.btTransfer.Size = new System.Drawing.Size(320, 55);
            this.btTransfer.TabIndex = 8;
            this.btTransfer.Text = "Transfer";
            this.btTransfer.UseVisualStyleBackColor = false;
            this.btTransfer.Click += new System.EventHandler(this.btTransfer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(211, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ch$$se Transaction:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_Bank_Project.Properties.Resources.Moneycur;
            this.pictureBox1.Location = new System.Drawing.Point(12, 390);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbPerson
            // 
            this.pbPerson.Image = global::My_Bank_Project.Properties.Resources.Person1;
            this.pbPerson.Location = new System.Drawing.Point(29, 31);
            this.pbPerson.Name = "pbPerson";
            this.pbPerson.Size = new System.Drawing.Size(23, 36);
            this.pbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPerson.TabIndex = 11;
            this.pbPerson.TabStop = false;
            // 
            // lbLoginUserClient
            // 
            this.lbLoginUserClient.AutoSize = true;
            this.lbLoginUserClient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginUserClient.Location = new System.Drawing.Point(68, 41);
            this.lbLoginUserClient.Name = "lbLoginUserClient";
            this.lbLoginUserClient.Size = new System.Drawing.Size(0, 16);
            this.lbLoginUserClient.TabIndex = 10;
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1219, 739);
            this.Controls.Add(this.pbPerson);
            this.Controls.Add(this.lbLoginUserClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTransfer);
            this.Controls.Add(this.btWithdraw);
            this.Controls.Add(this.btDeposit);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TransactionsForm";
            this.Text = "TransactionsForm";
            this.Load += new System.EventHandler(this.TransactionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btDeposit;
        private System.Windows.Forms.Button btWithdraw;
        private System.Windows.Forms.Button btTransfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPerson;
        private System.Windows.Forms.Label lbLoginUserClient;
    }
}