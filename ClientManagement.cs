using Bank_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Bank_Project
{
    public partial class ClientManagement : Form
    {
        public ClientManagement()
        {
            InitializeComponent();
        }


        private void _RefreshClientsList()
        {

            dgvClients.DataSource = ClsCustomersBusiness.GetAllCustomers();
        }



        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientManagement_Load(object sender, EventArgs e)
        {

            lbLoginUserClient.Text = ClsGlobal.CurrentUser; 
            _RefreshClientsList();
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            AddNewForm frm = new AddNewForm(-1);
            frm.ShowDialog();

            _RefreshClientsList();
        }

        private void dgvClients_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dgvClients.CurrentRow.Cells[0].Value.ToString());
        }

        private void toolsEdit_Click(object sender, EventArgs e)
        {
            AddNewForm frm = new AddNewForm((int)dgvClients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshClientsList();
        }

        private void toolsDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Client [" + dgvClients.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delete and refresh
                if (ClsCustomersBusiness.Delete((int)dgvClients.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Contact Deleted Successfully.");
                    _RefreshClientsList();

                }else
                {
                    MessageBox.Show("Contact is not deleted.");
                }
               

            }
            else
            {
                MessageBox.Show("deletion is canceled.");
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            AddNewForm frm = new AddNewForm((int)dgvClients.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshClientsList();
        }

        private void btClientTrans_Click(object sender, EventArgs e)
        {

            ClientTransaction frm = new ClientTransaction();
            frm.ShowDialog();


        }
    }
}
