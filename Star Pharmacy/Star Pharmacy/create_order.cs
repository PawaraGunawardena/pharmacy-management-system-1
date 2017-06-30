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
    public partial class create_order : Form
    {
        public create_order()
        {
            InitializeComponent();
        }

        private void create_order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.pharmacyDataSet.inventory);

        }
    }
}
