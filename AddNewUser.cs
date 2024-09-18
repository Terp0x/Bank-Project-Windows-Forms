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
    public partial class AddNewUser : Form
    {


        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        int _UserID;
        ClsUsersBusiness _User;


        public AddNewUser(int UserID)
        {
            InitializeComponent();


            _UserID = UserID;

            if (_UserID == -1)

                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

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



        private void _LoadDate()
        {


            if (_Mode == enMode.AddNew)
            {
                label1.Text = "Add New Client";
                _User = new ClsUsersBusiness();

                return;
            }


            _User = ClsUsersBusiness.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("This form will be closed because No Clients with ID = " + _UserID);
                this.Close();

                return;
            }


            label1.Text = "Edit Contact ID = " + _UserID;
            txRole.Text = _User.RoleID.ToString();
            tbName.Text = _User.Name;
            tbEmail.Text = _User.Email;
            tbPhone.Text = _User.Phone;
            tbAddress.Text = _User.Address;
            comboBox1.SelectedItem = _User.Gender;
            dateTimePicker1.Value = _User.DateOfBirth;
            tbUserName.Text = _User.UserName;
            tbPassword.Text = _User.Password;




        }



        private void btSave_Click(object sender, EventArgs e)
        {

            _User.RoleID = Convert.ToInt32(txRole.Text);
            _User.Name = tbName.Text;
            _User.Email = tbEmail.Text;
            _User.Phone = tbPhone.Text;
            _User.Address = tbAddress.Text;
            _User.Gender = comboBox1.SelectedItem.ToString();
            _User.DateOfBirth = dateTimePicker1.Value;
            _User.UserName = tbUserName.Text;
            _User.Password = tbPassword.Text;


            if (_User.Save())
                MessageBox.Show("Data Saved Successfully.");
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.");



            _Mode = enMode.Update;
            label1.Text = "Edit User ID = " + _User.ID;
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {

            lbCurrentUser.Text = ClsGlobal.CurrentUser;

                        _LoadDate();
        }

        private void btColse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
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
            if (string.IsNullOrEmpty(tbUserName.Text))
            {

                e.Cancel = true;
                tbUserName.Focus();
                errorProvider1.SetError(tbUserName, "UserName is required and Unique");


            }
            else if (!_CheckUserName())
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
