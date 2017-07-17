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
    public partial class emp_management : Form
    {

        bool addBtn_Clicked = false;
        bool changeBtn_Clicked = false;
        bool fireBtn_Clicked = false;
        bool recruitBtn_Clicked = false;

        public emp_management()
        {
            InitializeComponent();
            //fillCombos();
        }

        /*public void fillCombos()
        {
            roleSelect_cmboBox.Items.Add("Owner");
            roleSelect_cmboBox.Items.Add("Cashier");
            roleSelect_cmboBox.Items.Add("StockManager");
            role_CmbBox.Items.Add("Owner");
            role_CmbBox.Items.Add("Cashier");
            role_CmbBox.Items.Add("StockManager");
        }*/

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=pharmacy");
        MySqlCommand command;
        MySqlDataReader mdr;

        private static emp_management instance;

        public static emp_management getEmpManagement(SplitContainer scon, Form form)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new emp_management();
                instance.MdiParent = form;
                scon.Panel2.Controls.Add(instance);
                return instance;
            }
            else
            {
                return instance;
            }
        }

        private void emp_management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet2.people' table. You can move, or remove it, as needed.
            //this.peopleTableAdapter.Fill(this.pharmacyDataSet2.people);
            String query = "Select * from pharmacy.people";
            SqlCon.updateDataGridView(query, emp_details);
            groupBox1.Enabled = false;
            bdayPicker.MaxDate = DateTime.Today;

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

        private void empfirstName_txtBox_TextChanged(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.people where FirstName like'" + "%" + empfirstName_txtBox.Text + "%" + "';";
            SqlCon.updateDataGridView(query, emp_details);
        }

        private void emplastName_txtBox_TextChanged(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.people where LastName like'" + "%" + emplastName_txtBox.Text + "%" + "';";
            SqlCon.updateDataGridView(query, emp_details);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void role_CmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.people where Type like'" + role_CmbBox.Text + "';";
            SqlCon.updateDataGridView(query, emp_details);
        }

        private void add_emp_Click(object sender, EventArgs e)
        {
            addBtn_Clicked = true;
            changeBtn_Clicked = false;
            fireBtn_Clicked = false;
            recruitBtn_Clicked = false;
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            add_emp.Enabled = true;
            change_emp.Enabled = false;
            fire_emp.Enabled = false;
            recruit_emp.Enabled = false;
            emp_ID.ReadOnly = false;
            fName_txtBox.ReadOnly = false;
            lName_txtBox.ReadOnly = false;
            address_txtBox.ReadOnly = false;
            bdayPicker.Enabled = true;
            salary_updown.Enabled = true;
            roleSelect_cmboBox.Enabled = true;
            username_txtBox.ReadOnly = false;
            pwd_txtBox.ReadOnly = false;
            saveBtn.Enabled = true;
            cancelBtn.Enabled = true;

            if (emp_ID.Value==0)
            {
                availability_indicator.Text = "ID not available";
                availability_indicator.ForeColor = System.Drawing.Color.Red;
            }

        }

        private void emp_ID_ValueChanged(object sender, EventArgs e)
        {
            if (addBtn_Clicked)
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("Select * from pharmacy.people where ID = '"+ emp_ID.Value.ToString() + "'", SqlCon.con);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                if (dta.Rows.Count > 0)
                {
                    availability_indicator.Text = "ID not available";
                    availability_indicator.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    availability_indicator.Text = "ID available";
                    availability_indicator.ForeColor = System.Drawing.Color.Green;
                }
            }

            else if (changeBtn_Clicked)
            {
                if (emp_ID.Value == System.Convert.ToDecimal(emp_details.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    availability_indicator.Text = "No Change!";
                    availability_indicator.ForeColor = System.Drawing.Color.Indigo;
                }
                else
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter("Select * from pharmacy.people where ID = '" + emp_ID.Value.ToString() + "'", SqlCon.con);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if (dta.Rows.Count > 0)
                    {
                        availability_indicator.Text = "ID not available";
                        availability_indicator.ForeColor = System.Drawing.Color.Red;
                    }
                    else
                    {
                        availability_indicator.Text = "ID available";
                        availability_indicator.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
        }

        private void change_emp_Click(object sender, EventArgs e)
        {
            addBtn_Clicked = false;
            changeBtn_Clicked = true;
            fireBtn_Clicked = false;

            if (emp_details.SelectedRows.Count == 1)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                add_emp.Enabled = false;
                change_emp.Enabled = true;
                fire_emp.Enabled = false;
                recruit_emp.Enabled = false;
                emp_ID.ReadOnly = false;
                fName_txtBox.ReadOnly = false;
                lName_txtBox.ReadOnly = false;
                address_txtBox.ReadOnly = false;
                bdayPicker.Enabled = true;
                branchSelect.Enabled = true;
                salary_updown.Enabled = true;
                roleSelect_cmboBox.Enabled = true;
                username_txtBox.ReadOnly = false;
                pwd_txtBox.ReadOnly = false;
                saveBtn.Enabled = true;
                cancelBtn.Enabled = true;

                emp_ID.Value = System.Convert.ToDecimal(emp_details.SelectedRows[0].Cells[0].Value.ToString());
                fName_txtBox.Text = emp_details.SelectedRows[0].Cells[1].Value.ToString();
                lName_txtBox.Text = emp_details.SelectedRows[0].Cells[2].Value.ToString();
                address_txtBox.Text = emp_details.SelectedRows[0].Cells[4].Value.ToString();
                bdayPicker.Value = System.Convert.ToDateTime(emp_details.SelectedRows[0].Cells[5].Value.ToString());
                branchSelect.SelectedIndex = branchSelect.FindStringExact(emp_details.SelectedRows[0].Cells[9].Value.ToString());
                salary_updown.Value = System.Convert.ToDecimal(emp_details.SelectedRows[0].Cells[6].Value.ToString());
                roleSelect_cmboBox.SelectedIndex = roleSelect_cmboBox.FindStringExact(emp_details.SelectedRows[0].Cells[3].Value.ToString());
                username_txtBox.Text = emp_details.SelectedRows[0].Cells[7].Value.ToString();
                pwd_txtBox.Text = emp_details.SelectedRows[0].Cells[8].Value.ToString();

            }

            else
            {
                MessageBox.Show("Select a product first!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void resetStates()
        {
            add_emp.Enabled = true;
            change_emp.Enabled = true;
            fire_emp.Enabled = true;
            recruit_emp.Enabled = true;
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void fire_emp_Click(object sender, EventArgs e)
        {
            addBtn_Clicked = false;
            changeBtn_Clicked = false;
            fireBtn_Clicked = true;
            recruitBtn_Clicked = false;

            if (emp_details.SelectedRows.Count == 1)
            {
                if (emp_details.SelectedRows[0].Cells[10].Value.ToString() == "True")
                {
                    SqlCon.con.Open();
                    MySqlCommand cmd = new MySqlCommand("update pharmacy.people set Working = 0 where ID ='" + emp_details.SelectedRows[0].Cells[0].Value.ToString() + "';", SqlCon.con);
                    cmd.ExecuteNonQuery();
                    SqlCon.con.Close();
                    SqlCon.updateDataGridView("select * from pharmacy.people;", emp_details);
                    cancelBtn_Click(sender, e);
                    MessageBox.Show("Successfully fired!");
                }
                else
                {
                    MessageBox.Show("Employee already fired!");
                }
                
            }
            else
            {
                MessageBox.Show("Please select an Employee!");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            resetStates();
            availability_indicator.Text = "";
            emp_ID.ResetText();
            fName_txtBox.ResetText();
            lName_txtBox.ResetText();
            address_txtBox.ResetText();
            bdayPicker.ResetText();
            branchSelect.ResetText();
            salary_updown.ResetText();
            roleSelect_cmboBox.ResetText();
            username_txtBox.ResetText();
            pwd_txtBox.ResetText();
            emp_details.ClearSelection();
            emp_details.Refresh();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (addBtn_Clicked)
            {
                if (availability_indicator.Text == "ID available")
                {
                    if (bdayPicker.Value.ToString("yyyy-MM-dd") != "0000-00-00" && fName_txtBox.Text != "" && lName_txtBox.Text != "" && roleSelect_cmboBox.Text != "" && address_txtBox.Text != "" && username_txtBox.Text != "" && branchSelect.Text != "")
                    {
                        SqlCon.con.Open();
                        MySqlCommand cmd = new MySqlCommand(@"insert into pharmacy.people (ID,FirstName,LastName,Type,Address,DateOfBirth,Salary,
                                                        Username,Password,Branch,Working) values ('" + emp_ID.Value.ToString() + "','" + fName_txtBox.Text + "','" + lName_txtBox.Text + "','" + roleSelect_cmboBox.Text + "','" + address_txtBox.Text + "','" + bdayPicker.Value.ToString("yyyy-MM-dd") + "','" + salary_updown.Value.ToString() + "','" + username_txtBox.Text + "','" + pwd_txtBox.Text + "','" + branchSelect.Text + "','" + 1 + "');", SqlCon.con);
                        cmd.ExecuteNonQuery();
                        SqlCon.con.Close();
                        String query = "Select * from pharmacy.people;";
                        SqlCon.updateDataGridView(query, emp_details);
                        MessageBox.Show("Employee Successfully added!");
                        cancelBtn_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Entry. Please fill the details!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid ID!");
                }
                //cancelBtn_Click(sender, e);
            }
            else if (changeBtn_Clicked)
            {
                if (bdayPicker.Value.ToString("yyyy-MM-dd") != "0000-00-00" && fName_txtBox.Text != "" && lName_txtBox.Text != "" && roleSelect_cmboBox.Text != "" && address_txtBox.Text != "" && username_txtBox.Text != "" && branchSelect.Text != "")
                {
                    SqlCon.con.Open();
                    MySqlCommand locktable = new MySqlCommand("lock tables pharmacy.people write;", SqlCon.con);
                    locktable.ExecuteNonQuery();

                    MySqlCommand cmd = new MySqlCommand("delete from pharmacy.people where ID='" + emp_details.SelectedRows[0].Cells[0].Value.ToString() + "';", SqlCon.con);
                    cmd.ExecuteNonQuery();

                    MySqlCommand cmd1 = new MySqlCommand(@"insert into pharmacy.people (ID,FirstName,LastName,Type,Address,DateOfBirth,Salary,
                                                        Username,Password,Branch,Working) values ('" + emp_ID.Value.ToString() + "','" + fName_txtBox.Text + "','" + lName_txtBox.Text + "','" + roleSelect_cmboBox.Text + "','" + address_txtBox.Text + "','" + bdayPicker.Value.ToString("yyyy-MM-dd") + "','" + salary_updown.Value.ToString() + "','" + username_txtBox.Text + "','" + pwd_txtBox.Text + "','" + branchSelect.Text + "','" + 1 + "');", SqlCon.con);
                    cmd1.ExecuteNonQuery();


                    MySqlCommand unlock = new MySqlCommand("unlock tables;", SqlCon.con);
                    unlock.ExecuteNonQuery();
                    SqlCon.con.Close();
                    String query = "Select * from pharmacy.people;";
                    SqlCon.updateDataGridView(query, emp_details);
                    cancelBtn_Click(sender, e);
                    MessageBox.Show("Employee Details changed successfully!");
                }

                else
                {
                    MessageBox.Show("Invalid Entry. Please fill the details!");
                }
                
            }
            else
            {
                MessageBox.Show("Error! Recheck the entry!");
            }
        }

        private void recruit_emp_Click(object sender, EventArgs e)
        {
            addBtn_Clicked = false;
            changeBtn_Clicked = false;
            fireBtn_Clicked = false;
            recruitBtn_Clicked = true;

            if (emp_details.SelectedRows.Count == 1)
            {
                if (emp_details.SelectedRows[0].Cells[10].Value.ToString() == "False")
                {
                    SqlCon.con.Open();
                    MySqlCommand cmd = new MySqlCommand("update pharmacy.people set Working = 1 where ID ='" + emp_details.SelectedRows[0].Cells[0].Value.ToString() + "';", SqlCon.con);
                    cmd.ExecuteNonQuery();
                    SqlCon.con.Close();
                    SqlCon.updateDataGridView("select * from pharmacy.people;", emp_details);
                    cancelBtn_Click(sender, e);
                    MessageBox.Show("Successfully recruited!");
                }
                else
                {
                    MessageBox.Show("Employee is already working. No need to recruit!");
                }

            }
            else
            {
                MessageBox.Show("Please select an Employee!");
            }
        }

        private void empfirstName_txtBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void empfirstName_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void emplastName_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void fName_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void lName_txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
