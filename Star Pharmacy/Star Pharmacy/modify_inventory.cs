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
    public partial class modify_inventory : Form
    {
        public modify_inventory()
        {
            InitializeComponent();
        }
        private static modify_inventory inst3;

        public static modify_inventory getModifyInventory(SplitContainer s, Form f)
        {
            if (inst3 == null || inst3.IsDisposed)
            {
                inst3 = new modify_inventory();
                inst3.MdiParent = f;
                s.Panel2.Controls.Add(inst3);
                return inst3;
            }
            else
            {
                return inst3;
            }
        }

        private void modify_inventory_Load(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.inventory;";
            SqlCon.updateDataGridView(query, dataGridView1);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            String query;
            if (numericUpDown1.Value == 0)
            {
                query = "Select * from pharmacy.inventory;";
            }
            else
            {
                query = "Select * from pharmacy.inventory where ProductID like '" + numericUpDown1.Value.ToString() + "%" + "';";

            }
            SqlCon.updateDataGridView(query, dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.inventory where BrandName like '" + "%" + textBox1.Text + "%" + "';";
            SqlCon.updateDataGridView(query, dataGridView1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.inventory where MedicalName like '" + "%" + textBox2.Text + "%" + "';";
            SqlCon.updateDataGridView(query, dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
