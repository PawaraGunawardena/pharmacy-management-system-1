using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Pharmacy
{
    public partial class supplier_transactions : Form
    {
        public supplier_transactions()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=pharmacy");
        MySqlCommand command;
        MySqlDataReader mdr;

        private void supplier_transactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet4.supplierdetails' table. You can move, or remove it, as needed.
            this.supplierdetailsTableAdapter1.Fill(this.pharmacyDataSet4.supplierdetails);
            // TODO: This line of code loads data into the 'pharmacyDataSet3.supplierdetails' table. You can move, or remove it, as needed.
            this.supplierdetailsTableAdapter.Fill(this.pharmacyDataSet3.supplierdetails);
            String query1 = "Select * from pharmacy.supplier_transactions";
            String query2 = "Select * from pharmacy.credit_details";
            SqlCon.updateDataGridView(query1, supplier_transactionsDetails);
            SqlCon.updateDataGridView(query2, creditDetails);
            groupBox1.Enabled = false;

        }

        private void transactionID_search1_ValueChanged(object sender, EventArgs e)
        {
            String query;
            if (transactionID_search1.Value == 0)
            {
                query = "Select * from pharmacy.supplier_transactions";
            }
            else
            {
                query = "Select * from pharmacy.supplier_transactions where TransactionID like '" + transactionID_search1.Value.ToString() + "%" + "';";
            }
            SqlCon.updateDataGridView(query, supplier_transactionsDetails);
        }

        private void itemID_search_ValueChanged(object sender, EventArgs e)
        {
            String query;
            if (itemID_search.Value == 0)
            {
                query = "Select * from pharmacy.supplier_transactions";
            }
            else
            {
                query = "Select * from pharmacy.supplier_transactions where ItemID like '" + itemID_search.Value.ToString() + "%" + "';";
            }
            SqlCon.updateDataGridView(query, supplier_transactionsDetails);
        }

        private void supDetails_search1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.supplier_transactions where SupplierName like'" + supDetails_search1.Text + "';";
            SqlCon.updateDataGridView(query, supplier_transactionsDetails);
        }

        private void supplierID_search2_ValueChanged(object sender, EventArgs e)
        {
            String query;
            if (supplierID_search2.Value == 0)
            {
                query = "Select * from pharmacy.credit_details";
            }
            else
            {
                query = "Select * from pharmacy.credit_details where SupplierID like '" + supplierID_search2.Value.ToString() + "%" + "';";
            }
            SqlCon.updateDataGridView(query, creditDetails);
        }

        private void supplierName_search2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.credit_details where SupplierName like'" + supplierName_search2.Text + "';";
            SqlCon.updateDataGridView(query, creditDetails);
        }

        private void resetAll()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            payDebit.Enabled = true;
            viewDebit.Enabled = true;
            supplier_transactionsDetails.Enabled = true;
            creditDetails.Enabled = true;
            supplier_transactionsDetails.ClearSelection();
            creditDetails.ClearSelection();
            supplier_transactionsDetails.Refresh();
            creditDetails.Refresh();
        }

        private void payDebit_Click(object sender, EventArgs e)
        {
            if (creditDetails.SelectedRows.Count == 1)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                viewDebit.Enabled = false;
                supName_select.Text = creditDetails.SelectedRows[0].Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a supplier from above credit details!");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            resetAll();
            payAmount.ResetText();
            supName_select.ResetText();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (payAmount.Value != 0 && supName_select.Text != "")
            {
                SqlCon.con.Open();
                MySqlCommand cmd1 = new MySqlCommand(@"insert into pharmacy.debit_balances (DebitID,SupplierName,PaidAmount,Date,Time) values ('" + null + "','" + supName_select.Text + "','" + payAmount.Value.ToString() + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToShortTimeString() + "');", SqlCon.con);
                cmd1.ExecuteNonQuery();

                MySqlCommand cmd2 = new MySqlCommand(@"insert into pharmacy.debit_balances (DebitID,SupplierName,PaidAmount,Date,Time) values ('" + null + "','" + supName_select.Text + "','" + payAmount.Value.ToString() + "','" + DateTime.Today.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToShortTimeString() + "');", SqlCon.con);
                cmd2.ExecuteNonQuery();

                SqlCon.con.Close();

            }
            else
            {
                MessageBox.Show("Invalid Enrty. Check the inputs!");
            }
            
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            transactionID_search1.ResetText();
            itemID_search.ResetText();
            supDetails_search1.ResetText();
        
        }

        private void ClrBtn2_Click(object sender, EventArgs e)
        {
            supplierID_search2.ResetText();
            supplierName_search2.ResetText();
        }
    }
}
