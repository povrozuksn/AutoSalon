using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Autosalon
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm.CONN = new MySqlConnection(MainForm.CONNECTION_STRING);
            MainForm.CONN.Open();
            
            Application.Run(new MainForm());

            MainForm.CONN.Close();
        }
    }
}
