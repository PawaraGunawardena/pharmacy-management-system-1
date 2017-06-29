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
            Program.con.Open();
            MySqlDataAdapter sAdapter = new MySqlDataAdapter("Select * from pharmacy.people where Username= '"+textBox1.Text+"' and Password = '"+textBox2.Text+"';", Program.con);
            DataTable dt = new DataTable("CharacterInfo");
            sAdapter.Fill(dt);
            Program.con.Close();

            if (dt.Rows.Count == 1 && dt.Rows[0][2].ToString() == "Owner")
            {
                owner_form of = new owner_form();
                this.Hide();
                of.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Password or Username!");
            }
        }
    }
}
