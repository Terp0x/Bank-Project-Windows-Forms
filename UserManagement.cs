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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }



        private void _RefreshUsersList()
        {

            dgvUsers.DataSource = ClsUsersBusiness.GetAllUsers();
        }




        private void btAddNew_Click(object sender, EventArgs e)
        {


            AddNewUser frm = new AddNewUser(-1);
            frm.ShowDialog();

            _RefreshUsersList();


        }







        private void UserManagement_Load(object sender, EventArgs e)
        {
            lbLoginUserClient.Text = ClsGlobal.CurrentUser;
            _RefreshUsersList();
        }

        private void dgvUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dgvUsers.CurrentRow.Cells[0].Value.ToString());
        }

        private void toolEdit_Click(object sender, EventArgs e)
        {
            AddNewUser frm = new AddNewUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshUsersList();
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete Client [" + dgvUsers.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delete and refresh
                if (ClsUsersBusiness.Delete((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully.");
                    _RefreshUsersList();
                }

                else
                    MessageBox.Show("User is not deleted.");

            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            AddNewUser frm = new AddNewUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshUsersList();
        }

        private void btUserRoles_Click(object sender, EventArgs e)
        {
            UserTransactions frm = new UserTransactions();
            frm.ShowDialog();


        }
    }
}
