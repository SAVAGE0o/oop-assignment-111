using System;
using System.Data.SqlClient;

namespace oop_assignment
{
    public static class DataBaseHelper
    {
        // Update this connection string if needed
        private static readonly string connStr = "Data Source=Abofares;Initial Catalog=C#;Integrated Security=True";

        // This method returns a new SqlConnection object
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connStr);
        }
    }
}
