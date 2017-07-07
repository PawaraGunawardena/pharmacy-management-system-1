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
    public partial class Expiry_Products : Form
    {
        public Expiry_Products()
        {
            
            InitializeComponent();
        }

        private void Expiry_Products_Load(object sender, EventArgs e)
        {
            

            MySqlDataAdapter sAdapter = new MySqlDataAdapter("select * from pharmacy.inventory where ExpiryDate between '" +expiryNotification.today.ToString("yyyy-MM-dd") + "' and '" +expiryNotification.sevenDaysOnwards.ToString("yyyy-MM-dd") + "';", SqlCon.con);
            DataTable dt = new DataTable();
            sAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            MySqlDataAdapter sAdapter2 = new MySqlDataAdapter("SELECT * from inventory where `InStock`<`Reorderlevel`;", SqlCon.con);
            DataTable dt2 = new DataTable();
            sAdapter.Fill(dt2);
            dataGridView2.DataSource = dt2;
            dataGridView2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
