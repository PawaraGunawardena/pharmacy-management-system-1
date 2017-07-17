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
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            
            InitializeComponent();
        }
        private static NotificationForm inst_notify;

        public static NotificationForm getNotificationForm(SplitContainer s, Form f)
        {
            if (inst_notify == null || inst_notify.IsDisposed)
            {
                inst_notify = new NotificationForm();
                inst_notify.MdiParent = f;
                s.Panel2.Controls.Add(inst_notify);
                return inst_notify;
            }
            else
            {
                return inst_notify;
            }
        }

        private void Expiry_Products_Load(object sender, EventArgs e)
        {
            

            MySqlDataAdapter sAdapter = new MySqlDataAdapter("select * from pharmacy.inventory where ExpiryDate <= '" +Notification.sevenDaysOnwards.ToString("yyyy-MM-dd") + "';", SqlCon.con);
            DataTable dt = new DataTable();
            sAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            MySqlDataAdapter sAdapter2 = new MySqlDataAdapter("SELECT * from inventory where `InStock`<`Reorderlevel`;", SqlCon.con);
            DataTable dt2 = new DataTable();
            sAdapter2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            dataGridView2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
