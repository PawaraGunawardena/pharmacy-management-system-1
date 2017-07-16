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
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCon.con.Open();
                MySqlDataAdapter sAdapter = new MySqlDataAdapter("Select * from pharmacy.people where Username= '" + textBox1.Text + "' and Password = '" + textBox2.Text + "';", SqlCon.con);
                DataTable dt = new DataTable("CharacterInfo");
                sAdapter.Fill(dt);
                SqlCon.con.Close();

                if (dt.Rows.Count == 1 && dt.Rows[0][3].ToString() == "Owner")
                {

                    Program.logged_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                    owner_form of = new owner_form();
                    this.Hide();
                    of.Show();
                    if (Program.isNotification)
                    {
                        NotificationForm exProd = new NotificationForm();
                        exProd.Show();
                    }
                }
                else if (dt.Rows.Count == 1 && dt.Rows[0][3].ToString() == "Cashier")
                {
                    cashierForm cashier = new cashierForm();
                    this.Hide();
                    cashier.Show();
                    Program.logged_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                }
                else if (dt.Rows.Count == 1 && dt.Rows[0][3].ToString() == "StockManager")
                {
                    Program.logged_id = Convert.ToInt32(dt.Rows[0][0].ToString());
                    StockManagerForm of = new StockManagerForm();
                    this.Hide();
                    of.Show();
                    if (Program.isNotification)
                    {
                        NotificationForm exProd = new NotificationForm();
                        exProd.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password or Username!");
                    
                }
            }
            catch (Exception ex)
           {
          
                MessageBox.Show(ex.Message);
                
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
