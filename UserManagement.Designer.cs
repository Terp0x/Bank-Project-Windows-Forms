namespace My_Bank_Project
{
    partial class UserManagement
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
            this.lbHeader = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btAddNew = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btUserRoles = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPerson = new System.Windows.Forms.PictureBox();
            this.lbLoginUserClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbHeader.Location = new System.Drawing.Point(452, 21);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(214, 25);
            this.lbHeader.TabIndex = 12;
            this.lbHeader.Text = "Users Management";
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.LightGreen;
            this.btUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.Color.Black;
            this.btUpdate.Location = new System.Drawing.Point(688, 202);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(186, 52);
            this.btUpdate.TabIndex = 11;
            this.btUpdate.Text = "Update User";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btAddNew
            // 
            this.btAddNew.BackColor = System.Drawing.Color.LightGreen;
            this.btAddNew.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddNew.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddNew.ForeColor = System.Drawing.Color.Black;
            this.btAddNew.Location = new System.Drawing.Point(981, 202);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(186, 52);
            this.btAddNew.TabIndex = 10;
            this.btAddNew.Text = "Add User";
            this.btAddNew.UseVisualStyleBackColor = false;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUsers.GridColor = System.Drawing.SystemColors.Control;
            this.dgvUsers.Location = new System.Drawing.Point(278, 299);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(934, 419);
            this.dgvUsers.TabIndex = 8;
            this.dgvUsers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolEdit,
            this.toolDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // toolEdit
            // 
            this.toolEdit.Name = "toolEdit";
            this.toolEdit.Size = new System.Drawing.Size(107, 22);
            this.toolEdit.Text = "Edit";
            this.toolEdit.Click += new System.EventHandler(this.toolEdit_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(107, 22);
            this.toolDelete.Text = "Delete";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // btUserRoles
            // 
            this.btUserRoles.BackColor = System.Drawing.Color.LightGreen;
            this.btUserRoles.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btUserRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUserRoles.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUserRoles.ForeColor = System.Drawing.Color.Black;
            this.btUserRoles.Location = new System.Drawing.Point(400, 202);
            this.btUserRoles.Name = "btUserRoles";
            this.btUserRoles.Size = new System.Drawing.Size(186, 52);
            this.btUserRoles.TabIndex = 16;
            this.btUserRoles.Text = "User Roles";
            this.btUserRoles.UseVisualStyleBackColor = false;
            this.btUserRoles.Click += new System.EventHandler(this.btUserRoles_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_Bank_Project.Properties.Resources._20240910_162617;
            this.pictureBox1.Location = new System.Drawing.Point(6, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pbPerson
            // 
            this.pbPerson.Image = global::My_Bank_Project.Properties.Resources.Person1;
            this.pbPerson.Location = new System.Drawing.Point(29, 33);
            this.pbPerson.Name = "pbPerson";
            this.pbPerson.Size = new System.Drawing.Size(23, 36);
            this.pbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPerson.TabIndex = 18;
            this.pbPerson.TabStop = false;
            // 
            // lbLoginUserClient
            // 
            this.lbLoginUserClient.AutoSize = true;
            this.lbLoginUserClient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginUserClient.Location = new System.Drawing.Point(68, 43);
            this.lbLoginUserClient.Name = "lbLoginUserClient";
            this.lbLoginUserClient.Size = new System.Drawing.Size(0, 16);
            this.lbLoginUserClient.TabIndex = 17;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 739);
            this.Controls.Add(this.pbPerson);
            this.Controls.Add(this.lbLoginUserClient);
            this.Controls.Add(this.btUserRoles);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvUsers);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolEdit;
        private System.Windows.Forms.ToolStripMenuItem toolDelete;
        private System.Windows.Forms.Button btUserRoles;
        private System.Windows.Forms.PictureBox pbPerson;
        private System.Windows.Forms.Label lbLoginUserClient;
    }
}