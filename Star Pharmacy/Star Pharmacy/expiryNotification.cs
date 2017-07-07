﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Star_Pharmacy
{
    class expiryNotification
    {
        public static DateTime today;
        public static DateTime sevenDaysOnwards;
        public static bool noMySQlHost = false;
        public static void expnoti()
        {
            try
            {
                today = DateTime.Today;
                sevenDaysOnwards = today.AddDays(7);

                MySqlDataAdapter sAdapter = new MySqlDataAdapter("select * from pharmacy.inventory where ExpiryDate between '" + today.ToString("yyyy-MM-dd") + "' and '" + sevenDaysOnwards.ToString("yyyy-MM-dd") + "';", SqlCon.con);
                DataTable dt = new DataTable();
                sAdapter.Fill(dt);
                
                if (dt.Rows.Count > 0)
                {
                    Program.isExpire = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+" Program is Exiting! Ask devlopers for help!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                noMySQlHost = true;
            }


        }
    }
}
