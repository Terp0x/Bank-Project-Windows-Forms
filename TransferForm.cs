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
    public partial class TransferForm : Form
    {


        private string _SubItemTextUser1 = "";
        private string _SubItemTextUser2 = "";
        private int _AccountIDUser1;
        private int _AccountIDUser2;


        public TransferForm()
        {
            InitializeComponent();
        }



        private void _DataLoad()
        {
            tbUserName.Focus();

            listView3.Visible = false;
            listView4.Visible = false;

        }




        private void _UpdateAccountDataUser1()
        {
            ClsAccountsBusiness Account = ClsAccountsBusiness.Find(_SubItemTextUser1);



            if (Account != null)
            {

                _AccountIDUser1 = Account.AccountID;




                if (MessageBox.Show("Are You Sure You Want To Perform This Transaction?", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)

                {
                    if (Account.AccountBalance >= Convert.ToInt64(tbAmount.Text))
                    {

                        Account.AccountBalance = Account.AccountBalance - Convert.ToInt64(tbAmount.Text);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    }
                    if (Account.Save())
                    {
                       
                        _LoadDataIntoListView2();
                        MessageBox.Show("Transaction performed Successfully", "Performed", MessageBoxButtons.OK);
                    }

                }
                else
                {

                    MessageBox.Show("Transaction Canceled", "Canceled", MessageBoxButtons.OK);

                }





            }
            else
            {
                MessageBox.Show("Account Number Not found");
            }

        }


        private void _UpdateTransactionDataUser1()
        {
            ClsTransactionBusiness Transaction = ClsTransactionBusiness.Find(_AccountIDUser1);




            if (Transaction != null)
            {

                Transaction.Date = DateTime.Now;
                Transaction.TransactionTypesID = 3;

                Transaction.Amount = (Convert.ToInt64(tbAmount.Text) * -1);

                if (Transaction.Save())
                {
                    
                    _LoadDataIntoListView3User1();

                }
            }
            else
            {
                MessageBox.Show("Error");
            }



        }


        private void _UpdateAccountDataUser2()
        {
            ClsAccountsBusiness Account = ClsAccountsBusiness.Find(_SubItemTextUser2);



            if (Account != null)
            {

                _AccountIDUser2 = Account.AccountID;

                Account.AccountBalance = Account.AccountBalance + Convert.ToInt64(tbAmount.Text);



                if (Account.Save())
                    {
                       
                        _LoadDataIntoListView1(); ///diffff
                      
                    }




            }
            else
            {
                MessageBox.Show("Account Number Not found");
            }

        }


        private void _UpdateTransactionDataUser2()
        {
            ClsTransactionBusiness Transaction = ClsTransactionBusiness.Find(_AccountIDUser2);




            if (Transaction != null)
            {

                Transaction.Date = DateTime.Now;
                Transaction.TransactionTypesID = 3;

                Transaction.Amount = Convert.ToInt64(tbAmount.Text);

                if (Transaction.Save())
                {
                    
                    _LoadDataIntoListView4User2();

                }
            }
            else
            {
                MessageBox.Show("Error");
            }



        }



        private void _LoadDataIntoListView2()
        {
            DataTable dataTable = ClsTransactionBusiness.GetTransactionsCards(tbUserName.Text);


            listView2.Items.Clear();
            listView2.Columns.Clear();

            // Add columns based on the DataTable
            foreach (DataColumn column in dataTable.Columns)
            {
                listView2.Columns.Add(column.ColumnName);
            }

            // Add rows to the ListView
            foreach (DataRow row in dataTable.Rows)
            {
                // Create a ListViewItem for each row
                ListViewItem listViewItem = new ListViewItem(row[0].ToString()); // First column as the ListView item
                for (int i = 1; i < dataTable.Columns.Count; i++)
                {


                    listViewItem.SubItems.Add(row[i].ToString());



                }

                listView2.Items.Add(listViewItem);   // Add the ListViewItem to the ListView




            }

            if (dataTable.Rows.Count > 0)
            {
                lbUserNotFound.Visible = false;
            }
            else
            {
                lbUserNotFound.Visible = true;
                lbUserNotFound.Text = "UserName is not Found!";
            }



            foreach (ColumnHeader column in listView2.Columns)
            {
                column.Width = -2; // Auto adjust width
            }



        }


        private void _LoadDataIntoListView1()
        {
            DataTable dataTable = ClsTransactionBusiness.GetTransactionsCards(tbUserRecever.Text);


            listView1.Items.Clear();
            listView1.Columns.Clear();

            // Add columns based on the DataTable
            foreach (DataColumn column in dataTable.Columns)
            {
                listView1.Columns.Add(column.ColumnName);
            }

            // Add rows to the ListView
            foreach (DataRow row in dataTable.Rows)
            {
                // Create a ListViewItem for each row
                ListViewItem listViewItem = new ListViewItem(row[0].ToString()); // First column as the ListView item
                for (int i = 1; i < dataTable.Columns.Count; i++)
                {


                    listViewItem.SubItems.Add(row[i].ToString());



                }

                listView1.Items.Add(listViewItem);   // Add the ListViewItem to the ListView




            }

            if (dataTable.Rows.Count > 0)
            {
                lbLoginFailedUser2.Visible = false;
            }
            else
            {
                lbLoginFailedUser2.Visible = true;
                lbLoginFailedUser2.Text = "UserName is not Found!";
            }



            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = -2; // Auto adjust width
            }



        }



        public void _LoadDataIntoListView3User1()
        {




            DataTable dataTable = ClsCustomersBusiness.GetAllDetailsTransactions(tbUserName.Text);


            listView3.Items.Clear();
            listView3.Columns.Clear();

            // Add columns based on the DataTable
            foreach (DataColumn column in dataTable.Columns)
            {
                listView3.Columns.Add(column.ColumnName);
            }

            // Add rows to the ListView
            foreach (DataRow row in dataTable.Rows)
            {
                // Create a ListViewItem for each row
                ListViewItem listViewItem1 = new ListViewItem(row[0].ToString()); // First column as the ListView item



                for (int i = 1; i < dataTable.Columns.Count; i++)
                {


                    listViewItem1.SubItems.Add(row[i].ToString());


                }


                if (listViewItem1.SubItems.Count >= 2)
                {
                    
                    _SubItemTextUser1 = listViewItem1.SubItems[2].Text; // AccountNumber
                }





                listView3.Items.Add(listViewItem1);   // Add the ListViewItem to the ListView




            }

          
            foreach (ColumnHeader column in listView3.Columns)
            {
                column.Width = -2; // Auto adjust width
            }


        }


      
        public void _LoadDataIntoListView4User2()
        {




            DataTable dataTable = ClsCustomersBusiness.GetAllDetailsTransactions(tbUserRecever.Text);


            listView4.Items.Clear();
            listView4.Columns.Clear();

            // Add columns based on the DataTable
            foreach (DataColumn column in dataTable.Columns)
            {
                listView4.Columns.Add(column.ColumnName);
            }

            // Add rows to the ListView
            foreach (DataRow row in dataTable.Rows)
            {
                // Create a ListViewItem for each row
                ListViewItem listViewItem1 = new ListViewItem(row[0].ToString()); // First column as the ListView item



                for (int i = 1; i < dataTable.Columns.Count; i++)
                {


                    listViewItem1.SubItems.Add(row[i].ToString());


                }


                if (listViewItem1.SubItems.Count >= 2)
                {
                    
                    _SubItemTextUser2 = listViewItem1.SubItems[2].Text; // AccountNumber
                }





                listView4.Items.Add(listViewItem1);   // Add the ListViewItem to the ListView




            }


            foreach (ColumnHeader column in listView4.Columns)
            {
                column.Width = -2; // Auto adjust width
            }


        }



        private void btFind_Click(object sender, EventArgs e)
        {
            _LoadDataIntoListView2();
            _LoadDataIntoListView1();


            _LoadDataIntoListView3User1();
            _LoadDataIntoListView4User2();

        }

        private void btPerform_Click(object sender, EventArgs e)
        {
            _UpdateAccountDataUser1();
            _UpdateTransactionDataUser1();

            _UpdateAccountDataUser2();
            _UpdateTransactionDataUser2();

        }

        private void TransferForm_Load(object sender, EventArgs e)
        {
            lbLoginUserClient.Text = ClsGlobal.CurrentUser;
            _DataLoad();
        }
    }
}
