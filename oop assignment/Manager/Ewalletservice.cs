using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment
{

    public class EwalletService
    {
        private readonly string connStr;
        // ✅ SERVICE CLASS (handles DB logic)

        public EwalletService(string connectionString)
        {
            connStr = connectionString;
        }

        public decimal? GetBalance(string userId)
        {
            using (var conn = new SqlConnection(connStr))
            {
                string query = "SELECT WalletBalance FROM Users WHERE UserId = @uid";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    conn.Close();

                    if (result != null && decimal.TryParse(result.ToString(), out decimal balance))
                        return balance;
                    else
                        return null;
                }
            }
        }

        public void TopUp(string userId, decimal amount)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                string updateQuery = "UPDATE Users SET WalletBalance = WalletBalance + @amount WHERE UserId = @uid";
                using (var updateCmd = new SqlCommand(updateQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@amount", amount);
                    updateCmd.Parameters.AddWithValue("@uid", userId);
                    updateCmd.ExecuteNonQuery();
                }

                string insertQuery = "INSERT INTO WalletTransactions (UserId, Amount, Type, TransactionDate) VALUES (@uid, @amount, 'TopUp', GETDATE())";
                using (var insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@uid", userId);
                    insertCmd.Parameters.AddWithValue("@amount", amount);
                    insertCmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
    }
}
