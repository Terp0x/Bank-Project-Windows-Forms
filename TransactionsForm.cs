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
    public partial class TransactionsForm : Form
    {
        public TransactionsForm()
        {
            InitializeComponent();
        }

        private void btDeposit_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm();
            depositForm.ShowDialog();
        }

        private void btWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm withdrawForm = new WithdrawForm();
            withdrawForm.ShowDialog();

        }

        private void btTransfer_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            transferForm.ShowDialog();


        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            lbLoginUserClient.Text = ClsGlobal.CurrentUser;
        }
    }
}
