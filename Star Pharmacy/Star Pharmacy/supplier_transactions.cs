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

        private void supplier_transactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet3.supplierdetails' table. You can move, or remove it, as needed.
            this.supplierdetailsTableAdapter.Fill(this.pharmacyDataSet3.supplierdetails);

        }
    }
}
