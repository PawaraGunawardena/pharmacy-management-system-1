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
    public partial class Inventory_details_welivita : Form
    {
        private String branch = "Welivita";
        private static Inventory_details_welivita inst2;
        public Inventory_details_welivita()
        {
            InitializeComponent();
            this.Text = "Inventory-" + branch;
        }

        private void Inventory_details_welivita_Load(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.inventory where Branch = '" + branch + "';";
            SqlCon.updateDataGridView(query, dataGridView1);
        }
        public static Inventory_details_welivita getInventoryDetails(SplitContainer s, Form f)
        {

            if (inst2 == null || inst2.IsDisposed)
            {
                inst2 = new Inventory_details_welivita();
                inst2.MdiParent = f;
                s.Panel2.Controls.Add(inst2);
                return inst2;
            }
            else
            {
                return inst2;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.inventory where ProductID like '" + numericUpDown1.Value.ToString() + "%" + "' and Branch = '" + branch + "';";
            SqlCon.updateDataGridView(query, dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.inventory where BrandName like '" + "%" + textBox1.Text + "%" + "' and Branch = '" + branch + "';";
            SqlCon.updateDataGridView(query, dataGridView1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.inventory where MedicalName like '" + "%" + textBox2.Text + "%" + "' and Branch = '" + branch + "';";
            SqlCon.updateDataGridView(query, dataGridView1);
        }
        private void numericUpDown1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
        }
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            numericUpDown1.ResetText();
            textBox2.Text = null;
        }
        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            numericUpDown1.ResetText();
            textBox1.Text = null;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
