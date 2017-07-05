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
    public partial class supplier_details : Form
    {
        public supplier_details()
        {
            InitializeComponent();
        }

        private static supplier_details inst;

        public static supplier_details getSupplierDetails(SplitContainer s, Form f)
        {
            if (inst == null || inst.IsDisposed)
            {
                inst = new supplier_details();
                inst.MdiParent = f;
                s.Panel2.Controls.Add(inst);
                return inst;
            }
            else
            {
                return inst;
            }
        }



        private void supplier_details_Load(object sender, EventArgs e)
        {
            
        }

        private void btnViewSupliers_Click(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.supplierdetails;";
            SqlCon.updateDataGridView(query, supplierDetailsDgv);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}