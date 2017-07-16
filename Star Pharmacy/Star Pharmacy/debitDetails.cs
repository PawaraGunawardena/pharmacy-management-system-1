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
    public partial class debitDetails : Form
    {
        public debitDetails()
        {
            InitializeComponent();
        }

        private void debitDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet1.supplierdetails' table. You can move, or remove it, as needed.
            this.supplierdetailsTableAdapter.Fill(this.pharmacyDataSet1.supplierdetails);
            String query = "Select * from pharmacy.debit_balances";
            SqlCon.updateDataGridView(query, debitDetails_dgv);
        }

        private void debitID_search_ValueChanged(object sender, EventArgs e)
        {
            String query;
            if (debitID_search.Value == 0)
            {
                query = "Select * from pharmacy.debit_balances";
            }
            else
            {
                query = "Select * from pharmacy.debit_balances where DebitID like '" + debitID_search.Value.ToString() + "%" + "';";
            }
            SqlCon.updateDataGridView(query, debitDetails_dgv);
        }

        private void Amount_search_ValueChanged(object sender, EventArgs e)
        {
            String query;
            if (Amount_search.Value == 0)
            {
                query = "Select * from pharmacy.debit_balances";
            }
            else
            {
                query = "Select * from pharmacy.debit_balances where DebitID like '" + Amount_search.Value.ToString() + "%" + "';";
            }
            SqlCon.updateDataGridView(query, debitDetails_dgv);
        }

        private void supDetails_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.debit_balances where SupplierName like'" + supDetails_search.Text + "';";
            SqlCon.updateDataGridView(query, debitDetails_dgv);
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            debitID_search.ResetText();
            Amount_search.ResetText();
            supDetails_search.ResetText();
        }
    }
}
