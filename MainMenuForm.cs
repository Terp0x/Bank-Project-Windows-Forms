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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private int resultPermission = 0;

      


        private void btClients_Click(object sender, EventArgs e)
        {

           


            if ( resultPermission == -1 || resultPermission == 1 || resultPermission == 2)
            {
                ClientManagement frm = new ClientManagement();
                frm.ShowDialog();
            }else
            {
                MessageBox.Show("You Don't Have Permissions To Do That!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                     



        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            resultPermission = ClsGlobal.SetPermissions();
            lbLoginUserClient.Text = ClsGlobal.CurrentUser; 

        }

        private void btUsers_Click(object sender, EventArgs e)
        {


           


            if (resultPermission == -1 )
            {

                UserManagement frm = new UserManagement();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You Don't Have Permissions To Do That!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btTransactions_Click(object sender, EventArgs e)
        {

           


            if (resultPermission == -1 || resultPermission == 1 || resultPermission == 3)
            {

                TransactionsForm frm = new TransactionsForm();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("You Don't Have Permissions To Do That!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       
        }


    }
}
