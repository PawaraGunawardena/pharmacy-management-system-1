using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Star_Pharmacy
{
    public partial class create_order : Form
    {
        public DataTable dt = new DataTable();
        public create_order()
        {
            InitializeComponent();
        }

        private void create_order_Load(object sender, EventArgs e)
        {
            load_dgv1();
        }
        private void load_dgv1()
        {
            Program.con.Open();
            MySqlDataAdapter sAdapter = new MySqlDataAdapter("Select ProductID,BrandName,MedicalName,UnitPrice,ExpiryDate,InStock from pharmacy.inventory;", Program.con);
            sAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = numericUpDown1.Value.ToString();
        }

    }
}
