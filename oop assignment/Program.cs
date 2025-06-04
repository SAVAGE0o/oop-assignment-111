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
        public string Name { get; set; }
        public int Price { get; set; }

        private SqlConnection conn = new SqlConnection("Data Source=Abofares;Initial Catalog=C#;Integrated Security=True");

        public bool IsAvailable(string itemName)
        {
            string query = "SELECT COUNT(*) FROM Menu WHERE item_name = @name AND availability = 'Yes'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", itemName);

            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();

            return count > 0;
        }

        public int GetPrice(string itemName)
        {
            string query = "SELECT price FROM Menu WHERE item_name = @name";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", itemName);

            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();

            return result != null ? Convert.ToInt32(result) : 0;
        }
    }

}

  