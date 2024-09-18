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
using static My_Bank_Project.ClsGlobal;


namespace My_Bank_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        public bool LoginCustomer()
        {

               

            ClsCustomersBusiness Customer =  ClsCustomersBusiness.Find(tbUserName.Text, tbpassword.Text);
            

           
            if (Customer != null)
            {

                ClsGlobal.CurrentUser = Customer.UserName;
                return true;

            }
            
                 return false;
             
                    


        }

        public bool LoginUser()
        {

          
            ClsUsersBusiness User = ClsUsersBusiness.Find(tbUserName.Text, tbpassword.Text);

            if (User != null)
            {

                ClsGlobal.CurrentUser = User.UserName;
                return true;

            }
          
               return false;
          

        }



        private void bnLogin_Click(object sender, EventArgs e)
        {
            lbLoginFailed.Visible = false;


            if (LoginCustomer() || LoginUser())
            {
                MainMenuForm frm = new MainMenuForm();
                frm.ShowDialog();
            }

            else
            {
               
                tbpassword.Clear();

                lbLoginFailed.Visible = true;
                lbLoginFailed.Text = "Incorrect UserName or Password";

                

            }


        }

        
    }
}
