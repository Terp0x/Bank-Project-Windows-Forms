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
    public partial class UserTransactions : Form
    {
        public UserTransactions()
        {
            InitializeComponent();
        }



        private void _RefreshUsersPermissionsList()
        {
            dgvUserPerm.DataSource = ClsUsersBusiness.GetAllUsersPermissions();
        }







        private void UserTransactions_Load(object sender, EventArgs e)
        {
            lbLoginUserClient.Text = ClsGlobal.CurrentUser;
            _RefreshUsersPermissionsList();
        }

        private void dgvUserPerm_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dgvUserPerm.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
