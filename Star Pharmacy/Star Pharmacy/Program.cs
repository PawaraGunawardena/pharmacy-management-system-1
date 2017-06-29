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
        public static MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=pharmacy");
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
    }
}
