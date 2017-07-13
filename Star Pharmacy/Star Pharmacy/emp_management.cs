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
    public partial class emp_management : Form
    {
        public emp_management()
        {
            InitializeComponent();
        }

        private void emp_management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet2.people' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.pharmacyDataSet2.people);
            String query = "Select * from pharmacy.people";
            SqlCon.updateDataGridView(query, emp_details);
            groupBox1.Enabled = false;

        }

        private void emp_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void address_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fName_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void empID_search_ValueChanged(object sender, EventArgs e)
        {
            String query;
            if (empID_search.Value==0)
            {
                query = "Select * from pharmacy.people";
            }
            else
            {
                query = "Select * from pharmacy.people where ID like '"+empID_search.Value.ToString()+"%"+"';";
            }
            SqlCon.updateDataGridView(query, emp_details);
        }
    }
}
