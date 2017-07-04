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
    public partial class inventory_details_mulleriyawa : Form
    {
        public inventory_details_mulleriyawa()
        {
           
            InitializeComponent();
            this.Text = "Inventory-" + branch;
        }
        private static inventory_details_mulleriyawa inst;
        private String branch = "Mulleriyawa";

        public static inventory_details_mulleriyawa getInventoryDetails(SplitContainer s,Form f)
        {
            
            if (inst == null || inst.IsDisposed)
            {
                inst = new inventory_details_mulleriyawa();
                inst.MdiParent = f;
                s.Panel2.Controls.Add(inst);
                return inst;
            }
            else
            {
                return inst;
            }
        }

        private void inventory_details_Load(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.inventory where Branch = '"+branch+"';";
            SqlCon.updateDataGridView(query, dataGridView1);
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter sAdapter2 = new MySqlDataAdapter("Select * from pharmacy.inventory where ProductID like '" + numericUpDown1.Value.ToString() + "%" + "' and Branch = '"+branch+"';", SqlCon.con);
            DataTable dt2 = new DataTable();
            sAdapter2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter sAdapter3 = new MySqlDataAdapter("Select * from pharmacy.inventory where BrandName like '" + "%" + textBox1.Text + "%" + "' and Branch = '" + branch + "';", SqlCon.con);
            DataTable dt3 = new DataTable();
            sAdapter3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter sAdapter4 = new MySqlDataAdapter("Select * from pharmacy.inventory where MedicalName like '" + "%" + textBox2.Text + "%" + "' and Branch = '" + branch + "';", SqlCon.con);
            DataTable dt4 = new DataTable();
            sAdapter4.Fill(dt4);
            dataGridView1.DataSource = dt4;
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
