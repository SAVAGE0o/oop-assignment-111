using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace oop_assignment
{
    public static class SalesManager
    {
        public static DataTable GetAllSales(out decimal totalSales)
        {
            totalSales = 0;
            DataTable dt = new DataTable();

            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT SaleId, ChefId, Category, Amount, SaleDate FROM Sales";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    totalSales += Convert.ToDecimal(row["Amount"]);
                }
            }

            return dt;
        }
    }
}