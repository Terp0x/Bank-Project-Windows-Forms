namespace My_Bank_Project
{
    partial class ClientManagement
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
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.btClientTrans = new System.Windows.Forms.Button();
            this.lbLoginUserClient = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPerson = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvClients.GridColor = System.Drawing.SystemColors.Control;
            this.dgvClients.Location = new System.Drawing.Point(284, 317);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Size = new System.Drawing.Size(934, 419);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentClick);
            this.dgvClients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellContentDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsEdit,
            this.toolsDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // toolsEdit
            // 
            this.toolsEdit.Name = "toolsEdit";
            this.toolsEdit.Size = new System.Drawing.Size(107, 22);
            this.toolsEdit.Text = "Edit";
            this.toolsEdit.Click += new System.EventHandler(this.toolsEdit_Click);
            // 
            // toolsDelete
            // 
            this.toolsDelete.Name = "toolsDelete";
            this.toolsDelete.Size = new System.Drawing.Size(107, 22);
            this.toolsDelete.Text = "Delete";
            this.toolsDelete.Click += new System.EventHandler(this.toolsDelete_Click);
            // 
            // btAddNew
            // 
            this.btAddNew.BackColor = System.Drawing.Color.LightGreen;
            this.btAddNew.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddNew.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddNew.ForeColor = System.Drawing.Color.Black;
            this.btAddNew.Location = new System.Drawing.Point(987, 220);
            this.btAddNew.Name = "btAddNew";
            this.btAddNew.Size = new System.Drawing.Size(186, 52);
            this.btAddNew.TabIndex = 2;
            this.btAddNew.Text = "Add Client";
            this.btAddNew.UseVisualStyleBackColor = false;
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.LightGreen;
            this.btUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.Color.Black;
            this.btUpdate.Location = new System.Drawing.Point(694, 220);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(186, 52);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "Update Client";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbHeader.Location = new System.Drawing.Point(458, 39);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(226, 25);
            this.lbHeader.TabIndex = 5;
            this.lbHeader.Text = "Clients Management";
            // 
            // btClientTrans
            // 
            this.btClientTrans.BackColor = System.Drawing.Color.LightGreen;
            this.btClientTrans.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btClientTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClientTrans.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClientTrans.ForeColor = System.Drawing.Color.Black;
            this.btClientTrans.Location = new System.Drawing.Point(328, 220);
            this.btClientTrans.Name = "btClientTrans";
            this.btClientTrans.Size = new System.Drawing.Size(244, 52);
            this.btClientTrans.TabIndex = 6;
            this.btClientTrans.Text = "Client Transactions";
            this.btClientTrans.UseVisualStyleBackColor = false;
            this.btClientTrans.Click += new System.EventHandler(this.btClientTrans_Click);
            // 
            // lbLoginUserClient
            // 
            this.lbLoginUserClient.AutoSize = true;
            this.lbLoginUserClient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginUserClient.Location = new System.Drawing.Point(61, 39);
            this.lbLoginUserClient.Name = "lbLoginUserClient";
            this.lbLoginUserClient.Size = new System.Drawing.Size(0, 16);
            this.lbLoginUserClient.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_Bank_Project.Properties.Resources._20240910_162617;
            this.pictureBox1.Location = new System.Drawing.Point(12, 395);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pbPerson
            // 
            this.pbPerson.Image = global::My_Bank_Project.Properties.Resources.Person1;
            this.pbPerson.Location = new System.Drawing.Point(12, 35);
            this.pbPerson.Name = "pbPerson";
            this.pbPerson.Size = new System.Drawing.Size(23, 29);
            this.pbPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPerson.TabIndex = 8;
            this.pbPerson.TabStop = false;
            // 
            // ClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 739);
            this.Controls.Add(this.pbPerson);
            this.Controls.Add(this.lbLoginUserClient);
            this.Controls.Add(this.btClientTrans);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvClients);
            this.Name = "ClientManagement";
            this.Text = "ClientManagement";
            this.Load += new System.EventHandler(this.ClientManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Button btClientTrans;
        private System.Windows.Forms.Label lbLoginUserClient;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsEdit;
        private System.Windows.Forms.ToolStripMenuItem toolsDelete;
        private System.Windows.Forms.PictureBox pbPerson;
    }
}