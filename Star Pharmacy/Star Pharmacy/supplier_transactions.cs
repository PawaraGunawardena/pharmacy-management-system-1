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
                query = "Select * from pharmacy.supplier_transactions where ID like '" + transactionID_search1.Value.ToString() + "%" + "';";
            }
            SqlCon.updateDataGridView(query, supplier_transactionsDetails);
        }
    }
}
