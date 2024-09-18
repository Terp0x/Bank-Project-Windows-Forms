namespace My_Bank_Project
{
    partial class UserTransactions
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvUserPerm = new System.Windows.Forms.DataGridView();
            this.pbPerson = new System.Windows.Forms.PictureBox();
            this.lbLoginUserClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserPerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbHeader.Location = new System.Drawing.Point(461, 24);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(203, 25);
            this.lbHeader.TabIndex = 12;
            this.lbHeader.Text = "Users Permissions";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_Bank_Project.Properties.Resources.trans_bro;
            this.pictureBox1.Location = new System.Drawing.Point(2, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dgvUserPerm
            // 
            this.dgvUserPerm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserPerm.Location = new System.Drawing.Point(332, 307);
            this.dgvUserPerm.Name = "dgvUserPerm";
            this.dgvUserPerm.Size = new System.Drawing.Size(884, 408);
            this.dgvUserPerm.TabIndex = 10;
            this.dgvUserPerm.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserPerm_CellContentDoubleClick);
            // 
            // pbPerson
            // 
            this.pbPerson.Image = global::My_Bank_Project.Properties.Resources.Person1;
            this.pbPerson.Location = new System.Drawing.Point(31, 24);
            this.pbPerson.Name = "pbPerson";
            this.pbPerson.Size = new System.Drawing.Size(23, 36);
            this.pbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPerson.TabIndex = 14;
            this.pbPerson.TabStop = false;
            // 
            // lbLoginUserClient
            // 
            this.lbLoginUserClient.AutoSize = true;
            this.lbLoginUserClient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginUserClient.Location = new System.Drawing.Point(70, 34);
            this.lbLoginUserClient.Name = "lbLoginUserClient";
            this.lbLoginUserClient.Size = new System.Drawing.Size(0, 16);
            this.lbLoginUserClient.TabIndex = 13;
            // 
            // UserTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 739);
            this.Controls.Add(this.pbPerson);
            this.Controls.Add(this.lbLoginUserClient);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvUserPerm);
            this.Name = "UserTransactions";
            this.Text = "UserTransactions";
            this.Load += new System.EventHandler(this.UserTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserPerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvUserPerm;
        private System.Windows.Forms.PictureBox pbPerson;
        private System.Windows.Forms.Label lbLoginUserClient;
    }
}