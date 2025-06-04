using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace oop_assignment
{
    static class Program
    {
        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
    public class menuItems
    {

        private SqlConnection conn = new SqlConnection("Data Source=Abofares;Initial Catalog=C#;Integrated Security=True");

        public DataTable GetAvailableMenuItems()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Menu WHERE availability = 'Yes'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(dt);
            return dt;
        }
    }
}
  