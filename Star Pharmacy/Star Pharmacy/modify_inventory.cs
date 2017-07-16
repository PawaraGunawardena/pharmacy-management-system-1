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
            buyingInvoiceNo_nud.ReadOnly = false;
            buyingInvoiceNo_nud.ReadOnly = false;
            unitprice_nud.ReadOnly = false;
            numericUpDown5.ReadOnly = false;
            brandName_txtbox.ReadOnly = false;
            medicalname_txtbox.ReadOnly = false;
            supplier_combobox.Enabled = true;
            dateTimePicker1.Enabled = true;
            branch_combobox.Enabled = true;
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
                                        ,UnitPrice,ExpiryDate,InStock,Reorderlevel,Branch) values ('" + numericUpDown2.Value.ToString() + "','" + brandName_txtbox.Text + "','" + medicalname_txtbox.Text + "','" + supplier_combobox.Text + "','" + unitprice_nud.Value.ToString() + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + noofitems_nud.Value.ToString() + "','" + numericUpDown5.Value.ToString() + "','" + branch_combobox.Text + "');", SqlCon.con);
                    cmd.ExecuteNonQuery();
                    SqlCon.con.Close();
                    String query = "Select * from pharmacy.inventory;";
                    SqlCon.updateDataGridView(query, dataGridView1);
                }
                else if(brandName_txtbox.Text==null && medicalname_txtbox.Text==null && supplier_combobox.SelectedIndex==null && noofitems_nud.Value == 0 && branch_combobox.SelectedIndex==null )
                {
                    MessageBox.Show("Check productID again!");
                }
                else
                {
                    MessageBox.Show("Check details again!");
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
                                        ,UnitPrice,ExpiryDate,InStock,Reorderlevel,Branch) values ('" + numericUpDown2.Value.ToString() + "','" + brandName_txtbox.Text + "','" + medicalname_txtbox.Text + "','" + supplier_combobox.Text + "','" + unitprice_nud.Value.ToString() + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + noofitems_nud.Value.ToString() + "','" + numericUpDown5.Value.ToString() + "','" + branch_combobox.Text + "');", SqlCon.con);
               

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
                MySqlCommand cmd = new MySqlCommand("update pharmacy.inventory set InStock='" + noofitems_nud.Value.ToString() + "' where ProductID ='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "';", SqlCon.con);
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
                buyingInvoiceNo_nud.ReadOnly = false;
                buyingPrice_nud.ReadOnly = false;
                unitprice_nud.ReadOnly = false;
                numericUpDown5.ReadOnly = false;
                brandName_txtbox.ReadOnly = false;
                medicalname_txtbox.ReadOnly = false;
                supplier_combobox.Enabled = true;
                dateTimePicker1.Enabled = true;
                branch_combobox.Enabled = true;
                groupBox1.Enabled = true;
                numericUpDown2.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                brandName_txtbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                medicalname_txtbox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                supplier_combobox.SelectedIndex = supplier_combobox.FindStringExact(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                unitprice_nud.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                dateTimePicker1.Value = System.Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                noofitems_nud.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                numericUpDown5.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
                branch_combobox.SelectedIndex = branch_combobox.FindStringExact(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
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
            unitprice_nud.ResetText();
            noofitems_nud.ResetText();
            buyingInvoiceNo_nud.ResetText();
            buyingPrice_nud.ResetText();
            numericUpDown5.ResetText();
            brandName_txtbox.ResetText();
            medicalname_txtbox.ResetText();
            supplier_combobox.ResetText();
            dateTimePicker1.ResetText();
            branch_combobox.ResetText();
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
                DialogResult result = MessageBox.Show("Are you sure you want to delete?","Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SqlCon.con.Open();
                    MySqlCommand cmd = new MySqlCommand("delete from pharmacy.inventory where ProductID='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "';", SqlCon.con);
                    cmd.ExecuteNonQuery();
                    SqlCon.updateDataGridView("select * from pharmacy.inventory;", dataGridView1);
                    SqlCon.con.Close();
                }
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
            numericUpDown5.Maximum = noofitems_nud.Value;
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
                buyingPrice_nud.ReadOnly = true;
                buyingInvoiceNo_nud.ReadOnly = true;
                unitprice_nud.ReadOnly = true;
                numericUpDown5.ReadOnly = true;
                brandName_txtbox.ReadOnly = true;
                medicalname_txtbox.ReadOnly = true;
                supplier_combobox.Enabled = false;
                dateTimePicker1.Enabled = false;
                branch_combobox.Enabled = false;
                numericUpDown2.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                brandName_txtbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                medicalname_txtbox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                supplier_combobox.SelectedIndex = supplier_combobox.FindStringExact(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                unitprice_nud.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                dateTimePicker1.Value = System.Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                noofitems_nud.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                numericUpDown5.Value = System.Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
                branch_combobox.SelectedIndex = branch_combobox.FindStringExact(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
                
            }
            else
            {
                MessageBox.Show("Select a product first!");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
