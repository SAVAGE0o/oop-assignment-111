using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment
{
    public class RefundRequest
    {
        public int RefundId { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public DateTime RequestDate { get; set; }
    }

    // RefundService class for handling database operations related to refunds
    public class RefundService
    {
        private readonly string connStr;

        public RefundService(string connectionString)
        {
            connStr = connectionString;
        }

        // Load all pending refund requests
        public DataTable LoadPending()
        {
            using (var conn = new SqlConnection(connStr))
            {
                string query = @"SELECT r.RefundId, r.UserId, r.OrderId, r.Amount, r.Reason, r.Status, r.RequestDate
                                 FROM RefundRequests r INNER JOIN Users u ON r.UserId = u.UserId
                                 WHERE r.Status = 'Pending'";
                using (var da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // Update the status of a refund and process the refund if approved
        public void UpdateStatusAndProcess(int refundId, int userId, decimal amount, string status)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Update the status of the refund request
                using (var cmd = new SqlCommand("UPDATE RefundRequests SET Status = @status WHERE RefundId = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", refundId);
                    cmd.ExecuteNonQuery();
                }

                // If the status is approved, process the refund
                if (status == "Approved")
                {
                    using (var walletCmd = new SqlCommand("UPDATE Users SET WalletBalance = WalletBalance + @amount WHERE UserId = @uid", conn))
                    {
                        walletCmd.Parameters.AddWithValue("@amount", amount);
                        walletCmd.Parameters.AddWithValue("@uid", userId);
                        walletCmd.ExecuteNonQuery();
                    }

                    // Log the transaction
                    using (var logCmd = new SqlCommand("INSERT INTO WalletTransactions (UserId, Amount, Type, TransactionDate) VALUES (@uid, @amount, 'Topup', GETDATE())", conn))
                    {
                        logCmd.Parameters.AddWithValue("@uid", userId);
                        logCmd.Parameters.AddWithValue("@amount", amount);
                        logCmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}

