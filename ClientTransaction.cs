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
    public partial class ClientTransaction : Form
    {
        public ClientTransaction()
        {
            InitializeComponent();
        }


        private void _RefreshClientsTransactionsList()
        {
            dgvClientTrans.DataSource = ClsCustomersBusiness.GetAllCustomersTransactions();
        }



        private void dgvClientTrans_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dgvClientTrans.CurrentRow.Cells[0].Value.ToString());
        }

        private void ClientTransaction_Load(object sender, EventArgs e)
        {
            lbLoginUserClient.Text = ClsGlobal.CurrentUser;
            _RefreshClientsTransactionsList();
        }
    }
}
