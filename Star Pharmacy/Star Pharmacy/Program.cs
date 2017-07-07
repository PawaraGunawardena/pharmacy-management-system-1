using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Star_Pharmacy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static bool isExpire = false;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            expiryNotification.expnoti();
            if (!expiryNotification.noMySQlHost)
            {

                Application.Run(new login());
            }
            
        }
    }
}
