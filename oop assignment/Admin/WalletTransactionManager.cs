using System;
using System.Data;
using System.Data.SqlClient;

namespace oop_assignment
{
    public static class WalletTransactionManager
    {
        public static DataTable GetAllTransactions()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT 
                        wt.TransactionId, 
                        u.Username AS CustomerName,
                        wt.Amount, 
                        wt.Type, 
                        wt.TransactionDate 
                    FROM WalletTransactions wt
                    INNER JOIN Users u ON wt.UserId = u.UserId
                    ORDER BY wt.TransactionDate DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
            }

            return dt;
        }
    }
}