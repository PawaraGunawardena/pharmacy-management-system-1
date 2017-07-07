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
    public partial class modify_inventory : Form
    {
        bool add_clicked= false;
        bool edit_clicked= false;
        bool update_clicked = false;
        bool remove_clicked = false;
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
            // TODO: This line of code loads data into the 'pharmacyDataSet1.supplierdetails' table. You can move, or remove it, as needed.
            this.supplierdetailsTableAdapter.Fill(this.pharmacyDataSet1.supplierdetails);
            String query = "Select * from pharmacy.inventory;";
            SqlCon.updateDataGridView(query, dataGridView1);
            groupBox1.Enabled = false;
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
            add_clicked =true;
            remove_clicked = false;
            edit_clicked = false;
            update_clicked = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            numericUpDown2.ReadOnly = false;
            numericUpDown3.ReadOnly = false;
            numericUpDown5.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            comboBox2.Enabled = true;
            dateTimePicker1.Enabled = true;
            comboBox1.Enabled = true;
            if (numericUpDown2.Value == 0)
            {
                label13.Text = "unavailable";
                label13.ForeColor = System.Drawing.Color.Red;
            }


        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (add_clicked)
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("Select * from pharmacy.inventory where ProductID = '" + numericUpDown2.Value.ToString() + "'", SqlCon.con);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    label13.Text = "Unavailable";
                    label13.ForeColor = System.Drawing.Color.Red;
                }else{
                    label13.Text = "available";
                    label13.ForeColor = System.Drawing.Color.Green;
                }
            }else if(edit_clicked)
            {
                if (numericUpDown2.Value == System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    label13.Text = "Current Value";
                }
                else
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter("Select * from pharmacy.inventory where ProductID = '" + numericUpDown2.Value.ToString() + "'", SqlCon.con);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count > 0)
                    {
                        label13.Text = "Unavailable";
                        label13.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        label13.Text = "available";
                        label13.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (add_clicked)
            {
                if (label13.Text == "available")
                {
                    
                    SqlCon.con.Open();
                    MySqlCommand cmd = new MySqlCommand(@"insert into pharmacy.inventory (ProductID,BrandName,MedicalName,Supplier
                                        ,UnitPrice,ExpiryDate,InStock,Reorderlevel,Branch) values ('" + numericUpDown2.Value.ToString() + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + numericUpDown3.Value.ToString() + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + numericUpDown4.Value.ToString() + "','" + numericUpDown5.Value.ToString() + "','" + comboBox1.Text + "');", SqlCon.con);
                    cmd.ExecuteNonQuery();
                    SqlCon.con.Close();
                    String query = "Select * from pharmacy.inventory;";
                    SqlCon.updateDataGridView(query, dataGridView1);
                }
                else
                {
                    MessageBox.Show("Check Product ID again!");
                }
                button6_Click(sender,e);
            }
            else if (edit_clicked)
            {
                SqlCon.con.Open();
                MySqlCommand locktable = new MySqlCommand("lock tables pharmacy.inventory write;",SqlCon.con);
                locktable.ExecuteNonQuery();
                MySqlCommand cmd = new MySqlCommand("delete from pharmacy.inventory where ProductID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "';", SqlCon.con);
                cmd.ExecuteNonQuery();
                MySqlCommand cmd1 = new MySqlCommand(@"insert into pharmacy.inventory (ProductID,BrandName,MedicalName,Supplier
                                        ,UnitPrice,ExpiryDate,InStock,Reorderlevel,Branch) values ('" + numericUpDown2.Value.ToString() + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + numericUpDown3.Value.ToString() + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + numericUpDown4.Value.ToString() + "','" + numericUpDown5.Value.ToString() + "','" + comboBox1.Text + "');", SqlCon.con);
               

                cmd1.ExecuteNonQuery();
                MySqlCommand unlock = new MySqlCommand("unlock tables;", SqlCon.con);
                unlock.ExecuteNonQuery();
                SqlCon.con.Close();
                String query = "Select * from pharmacy.inventory;";
                SqlCon.updateDataGridView(query, dataGridView1);
                button6_Click(sender, e);

            }
            else if (update_clicked)
            {
                SqlCon.con.Open();
                MySqlCommand cmd = new MySqlCommand("update pharmacy.inventory set InStock='" + numericUpDown4.Value.ToString() + "' where ProductID ='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "';", SqlCon.con);
                cmd.ExecuteNonQuery();
                SqlCon.con.Close();
                SqlCon.updateDataGridView("select * from pharmacy.inventory;", dataGridView1);
                button6_Click(sender, e);
            }
            
            
            
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_clicked = false;
            remove_clicked = false;
            edit_clicked = true;
            update_clicked = false;
            
            if (dataGridView1.SelectedRows.Count == 1)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                numericUpDown2.ReadOnly = false;
                numericUpDown3.ReadOnly = false;
                numericUpDown5.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                comboBox2.Enabled = true;
                dateTimePicker1.Enabled = true;
                comboBox1.Enabled = true;
                groupBox1.Enabled = true;
                numericUpDown2.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox2.SelectedIndex = comboBox2.FindStringExact(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                numericUpDown3.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                dateTimePicker1.Value = System.Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                numericUpDown4.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                numericUpDown5.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
                comboBox1.SelectedIndex = comboBox1.FindStringExact(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
                groupBox2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Select a product first!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void resetState()
        {
            groupBox2.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label13.Text = "";
            numericUpDown2.ResetText();
            numericUpDown3.ResetText();
            numericUpDown4.ResetText();
            numericUpDown5.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            comboBox2.ResetText();
            dateTimePicker1.ResetText();
            comboBox1.ResetText();
            resetState();
            dataGridView1.ClearSelection();
            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resetState();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_clicked = false;
            remove_clicked = true;
            edit_clicked = false;
            update_clicked = false;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                SqlCon.con.Open();
                MySqlCommand cmd = new MySqlCommand("delete from pharmacy.inventory where ProductID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "';", SqlCon.con);
                cmd.ExecuteNonQuery();
                SqlCon.updateDataGridView("select * from pharmacy.inventory;", dataGridView1);
                SqlCon.con.Close();
            }
            else
            {
                MessageBox.Show("Select a product first!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_MouseClick(object sender, MouseEventArgs e)
        {
            numericUpDown5.Maximum = numericUpDown4.Value;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value <= DateTime.Today)
            {
                MessageBox.Show("Invalid Date");
                dateTimePicker1.ResetText();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                add_clicked = false;
                remove_clicked = false;
                edit_clicked = false;
                update_clicked = true;
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                numericUpDown2.ReadOnly = true;
                numericUpDown3.ReadOnly = true;
                numericUpDown5.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                comboBox2.Enabled = false;
                dateTimePicker1.Enabled = false;
                comboBox1.Enabled = false;
                numericUpDown2.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox2.SelectedIndex = comboBox2.FindStringExact(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                numericUpDown3.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                dateTimePicker1.Value = System.Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                numericUpDown4.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                numericUpDown5.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
                comboBox1.SelectedIndex = comboBox1.FindStringExact(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
                
            }
            else
            {
                MessageBox.Show("Select a product first!");
            }
        }

    }
}
