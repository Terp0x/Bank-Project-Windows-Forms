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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace My_Bank_Project
{
    public partial class DepositForm : Form
    {


        private string _SubItemText = "";
        private int _AccountID ;

        public DepositForm()
        {
            InitializeComponent();
        }



       

        private void _DataLoad()
        {
            tbUserName.Focus();

            listView1.Visible = false;


        }


               

        private void _UpdateAccountData()
        {
            ClsAccountsBusiness Account = ClsAccountsBusiness.Find(_SubItemText);

           

            if (Account != null)
            {
               
                _AccountID = Account.AccountID;




                if (MessageBox.Show("Are You Sure You Want To Perform This Transaction?", "Confirm!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)

                {


                    Account.AccountBalance += Convert.ToInt64(tbAmount.Text);

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


        private void _UpdateTransactionData()
        {
            ClsTransactionBusiness Transaction = ClsTransactionBusiness.Find(_AccountID);


          

            if (Transaction != null)
            {
               
                Transaction.Date = DateTime.Now;
                Transaction.TransactionTypesID = 1;
                Transaction.Amount = Convert.ToInt64(tbAmount.Text);

                if (Transaction.Save())
                {
                    
                    _LoadDataIntoListView1();
                 
                }
            }else
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
            
            if(dataTable.Rows.Count > 0)
            {
                lbUserNotFound.Visible = false;
            }else
            {
                lbUserNotFound.Visible = true;
                lbUserNotFound.Text = "UserName is not Found!";
            }



            foreach (ColumnHeader column in listView2.Columns)
            {
                column.Width = -2; // Auto adjust width
            }



        }


        public void _LoadDataIntoListView1()
        {




            DataTable dataTable = ClsCustomersBusiness.GetAllDetailsTransactions(tbUserName.Text);


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
                ListViewItem listViewItem1 = new ListViewItem(row[0].ToString()); // First column as the ListView item



                for (int i = 1; i < dataTable.Columns.Count; i++)
                {


                    listViewItem1.SubItems.Add(row[i].ToString());


                }


                if (listViewItem1.SubItems.Count >= 2)
                {
                    lbLoginUserClient.Visible = true;
                    lbLoginUserClient.Text = listViewItem1.SubItems[1].Text;
                    _SubItemText = listViewItem1.SubItems[2].Text; 
                }





                listView1.Items.Add(listViewItem1);   // Add the ListViewItem to the ListView

   


            }
      
            if(dataTable.Rows.Count > 0)
            {

            }


            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = -2; // Auto adjust width
            }


        }


        private void btFind_Click(object sender, EventArgs e)
        {
            _LoadDataIntoListView2();

            _LoadDataIntoListView1();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {


            _UpdateAccountData();
            _UpdateTransactionData();
           
               
           

           
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {
            lbLoginUserClient.Text = ClsGlobal.CurrentUser;
            _DataLoad();

        }
    }
}
