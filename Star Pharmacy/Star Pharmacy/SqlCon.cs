using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Star_Pharmacy
{
    class SqlCon
    {
        public static MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=pharmacy");

        public static void updateDataGridView(String query, DataGridView dgv)
        {
            MySqlDataAdapter sAdapter = new MySqlDataAdapter(query, SqlCon.con);
            DataTable dt2 = new DataTable();
            sAdapter.Fill(dt2);
            dgv.DataSource = dt2;
            dgv.Refresh();
        }

    }
}
