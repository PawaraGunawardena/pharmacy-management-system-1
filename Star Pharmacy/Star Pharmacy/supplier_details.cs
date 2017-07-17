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
    public partial class supplier_details : Form
    {
        
        public supplier_details()
        {
            InitializeComponent();
        }

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=pharmacy");
        MySqlCommand command;
        MySqlDataReader mdr;
        
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
            //con.Open();
            refreshDatagrid(sender,e);
            btnViewSupplierDetails.Enabled = false;
            btnViewCredit.Enabled = false;
        }

        private void refreshDatagrid(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.supplierdetails;";
            SqlCon.updateDataGridView(query, supplierDetailsDgv);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                viewCredit vc = new viewCredit();
                string connString = "Server=localhost;Database=pharmacy;Uid=root;Pwd=;";
                command = new MySqlCommand("SELECT * FROM pharmacy.credit_details WHERE SupplierID=" + supplierDetailsDgv.SelectedRows[0].Cells[0].Value, con);
                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    vc.lbl_supID.Text = mdr.GetString("SupplierID");
                    vc.lbl_SupName.Text = mdr.GetString("SupplierName");
                    vc.lblSup_Credit.Text = mdr.GetString("CreditAmount");
                  

                }

                vc.Show();

                con.Close();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select a supplier!");
            }
        }

        public DataGridView sendDatagrid
        {
            get{
                return supplierDetailsDgv;
            }
        }

        public supplier_details formReference
        {
            get
            {
                return this;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                supplier_info_form supplierInfo = new supplier_info_form();
                string connString = "Server=localhost;Database=pharmacy;Uid=root;Pwd=;";
                command = new MySqlCommand("SELECT * FROM pharmacy.supplierdetails WHERE SupplierID=" + supplierDetailsDgv.SelectedRows[0].Cells[0].Value, con);
                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    supplierInfo.companyName.Text = mdr.GetString("CompanyName");
                    supplierInfo.contactNumber.Text = mdr.GetString("ContactPersonTelephone");
                    supplierInfo.contactPersonTelephone.Text = mdr.GetString("ContactPersonTelephone");
                    supplierInfo.companyTelephone.Text = mdr.GetString("CompanyTelephone");

                }

                supplierInfo.Show();

                con.Close();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select a supplier!");
            }

        }

        private void btnAddSuppliers_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String query = "Select * from pharmacy.supplierdetails;";
            SqlCon.updateDataGridView(query, supplierDetailsDgv);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string connString = "Server=localhost;Database=pharmacy;Uid=root;Pwd=;";
            command = new MySqlCommand("DELETE FROM pharmacy.supplierdetails WHERE SupplierID=" + supplierDetailsDgv.SelectedRows[0].Cells[0].Value, con);
            try
            {
                mdr = command.ExecuteReader();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            con.Close();

            con.Open();

            String query = "Select * from pharmacy.supplierdetails;";
            SqlCon.updateDataGridView(query, supplierDetailsDgv);

            con.Close();
        }

        private void supplierDetailsDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            btnViewSupplierDetails.Enabled = true;
            btnViewCredit.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MySqlDataAdapter sda1 = new MySqlDataAdapter("select * from supplierdetails where SupplierID ='" + supID_nud.Value.ToString() + "';",SqlCon.con);
            MySqlDataAdapter sda2 = new MySqlDataAdapter("Select * from supplierdetails where CompanyName= '" + textBox1.Text + "';",SqlCon.con);
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            sda1.Fill(dt1);
            sda2.Fill(dt2);
            bool notcorrect = false;
            if (dt1.Rows.Count > 0 || dt2.Rows.Count > 0 || textBox1.Text =="" || textBox2.Text =="" || textBox3.Text == "" || textBox4.Text=="")
            {
                notcorrect = true;
            }


            if (notcorrect)
            {
                MessageBox.Show("Check Details Again!!");
            }
            else
            {
                SqlCon.con.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `supplierdetails`(`SupplierID`, `CompanyName`, `ContactPerson`, `ContactPersonTelephone`, `CompanyTelephone`) VALUES ('"+supID_nud.Value.ToString()+"','"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"');",SqlCon.con);
                MySqlCommand cmd1 = new MySqlCommand("INSERT INTO `credit_details`(`SupplierID`, `SupplierName`, `CreditAmount`) VALUES ('"+supID_nud.Value.ToString()+"','"+textBox1.Text+"','"+0+"');",SqlCon.con);
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                SqlCon.con.Close();
                MessageBox.Show("Supplier Details Inserted!");
                refreshDatagrid(sender,e);
                button3_Click(sender, e);

            }
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