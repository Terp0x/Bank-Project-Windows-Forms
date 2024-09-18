using Bank_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace My_Bank_Project
{
    public partial class AddNewForm : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _ClientID;
        ClsCustomersBusiness _Client;


        public AddNewForm(int clientID)
        {
            InitializeComponent();



            _ClientID = clientID;

            if (_ClientID == -1)

                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;


        }


        private void _LoadDate()
        {


            if (_Mode == enMode.AddNew)
            {
                label1.Text = "Add New Client";
                _Client = new ClsCustomersBusiness();

                return;
            }


            _Client = ClsCustomersBusiness.Find(_ClientID);

            if (_Client == null)
            {
                MessageBox.Show("This form will be closed because No Clients with ID = " + _ClientID);
                this.Close();

                return;
            }


            label1.Text = "Edit Contact ID = " + _ClientID;
            tbName.Text = _Client.Name;
            tbEmail.Text = _Client.Email;
            tbPhone.Text = _Client.Phone;
            tbAddress.Text = _Client.Address;
            comboBox1.SelectedItem = _Client.Gender;
            dateTimePicker1.Value = _Client.DateOfBirth;

           
            tbUserName.Text = _Client.UserName;
            


            tbPassword.Text = _Client.Password;


        }

        private void AddNewForm_Load(object sender, EventArgs e)
        {
            lbLoginCurrent.Text = ClsGlobal.CurrentUser;
            _LoadDate();
        }


        private bool _CheckUserName()
        {
            //if username is repeated in customer's username or user's username
            if (ClsCustomersBusiness.IsExistsUserName(tbUserName.Text) || ClsUsersBusiness.IsExistsUserName(tbUserName.Text))
            {
                MessageBox.Show("UserName is Exists ,Change it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else
            {

                return true;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            _Client.Name = tbName.Text;
            _Client.Email = tbEmail.Text;
            _Client.Phone = tbPhone.Text;
            _Client.Address = tbAddress.Text;
            _Client.Gender = comboBox1.SelectedItem.ToString();
            _Client.DateOfBirth = dateTimePicker1.Value;

           
           _Client.UserName = tbUserName.Text;
            

            _Client.Password = tbPassword.Text;


            if (_Client.Save())
                 MessageBox.Show("Data Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");
            


            _Mode = enMode.Update;
            label1.Text = "Edit Contact ID = " + _Client.ID;
        }

        private void btColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbName.Text))
            {
                e.Cancel = true;
                tbName.Focus();
                errorProvider1.SetError(tbName, "Name is required");


            }
            else
            {
                e.Cancel = false;
                tbEmail.Focus();
                errorProvider1.SetError(tbName, ""); 
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text))
            {
                e.Cancel = true;
                tbEmail.Focus();
                errorProvider1.SetError(tbEmail, "Email is required");


            }
            else
            {
                e.Cancel = false;
                tbPhone.Focus();
                errorProvider1.SetError(tbEmail, "");
            }
        }

       

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUserName.Text) )
            {
                
                    e.Cancel = true;
                    tbUserName.Focus();
                    errorProvider1.SetError(tbUserName, "UserName is required and Unique");
                

            }else if (!_CheckUserName())
            {
                e.Cancel = true; // it means it is not Unique
                tbUserName.Focus();
                errorProvider1.SetError(tbUserName, "UserName must be Unique");
            }
            else
            {
                e.Cancel = false;
                dateTimePicker1.Focus();
                errorProvider1.SetError(tbUserName, "");
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                e.Cancel = true;
                dateTimePicker1.Focus();
                errorProvider1.SetError(dateTimePicker1, "Date is required");


            }
            else
            {
                e.Cancel = false;
                tbPassword.Focus();
                errorProvider1.SetError(dateTimePicker1, "");
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                e.Cancel = true;
                tbPassword.Focus();
                errorProvider1.SetError(tbPassword, "Password is required");


            }
            else
            {
                e.Cancel = false;
                btSave.Focus();
                errorProvider1.SetError(tbPassword, "");
            }
        }
    }
}
