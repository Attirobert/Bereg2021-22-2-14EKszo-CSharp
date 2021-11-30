using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySqlTeszt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        static public MySqlConnection conn = null;
        static public MySqlCommand sql = null;

        [STAThread]
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "Autok";
            sb.CharacterSet = "utf8";
            try
            {
                conn = new MySqlConnection(sb.ToString());
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

