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

    // ✅ CurrentSession.cs
    public static class CurrentSession
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Email { get; set; }
    }


    // ✅ DBHelper.cs
    public static class DBHelper
    {
        private static readonly string connectionString = "Data Source=Abofares;Initial Catalog=C#;Integrated Security=True";

        public static int GetItemIdFromDatabase(string itemName)
        {
            int itemId = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT item_id FROM Menu WHERE item_name = @name";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", itemName);
                conn.Open();
                itemId = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            return itemId;
        }

        public static int GetUserIdFromUsername(string username)
        {
            int userId = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserId FROM Users WHERE Username = @username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                userId = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            return userId;
        }
        public static string GetItemNameFromDatabase(int itemId)
        {
            string itemName = "";
            string query = "SELECT item_name FROM Menu WHERE Item_id = @itemId";

            using (SqlConnection conn = new SqlConnection("Data Source=Abofares;Initial Catalog=C#;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@itemId", itemId);
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    itemName = result.ToString();
                }
            }

            return itemName;
        }

    }


    // ✅ UserWallet.cs


    public class UserWallet
    {
        private readonly string connectionString = "Data Source=Abofares;Initial Catalog=C#;Integrated Security=True";

        public int UserId { get; private set; }
        public decimal Balance { get; private set; }

        public UserWallet(int userId)
        {
            UserId = userId;
            LoadUser();
        }

        private void LoadUser()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT WalletBalance FROM Users WHERE UserId = @UserId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", UserId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Balance = Convert.ToDecimal(reader["WalletBalance"]);
                }
            }
        }

        public bool Deduct(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                UpdateBalance();
                return true;
            }
            return false;
        }

        public void AddFunds(decimal amount)
        {
            Balance += amount;
            UpdateBalance();
        }

        public void Refund(decimal amount)
        {
            Balance += amount;
            UpdateBalance();
        }

        private void UpdateBalance()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET WalletBalance = @Balance WHERE UserId = @UserId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Balance", Balance);
                cmd.Parameters.AddWithValue("@UserId", UserId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }

    public class OrderInfo
    {
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"{ItemName} x{Quantity} - {Status}";
        }
    }

    public class OrderManager
    {
        private readonly string connectionString = "Data Source=Abofares;Initial Catalog=C#;Integrated Security=True";

        public void PlaceOrder(int userId, int itemId, int quantity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Orders (UserId, item_id, quantity, status) VALUES (@userId, @itemId, @quantity, @status)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@itemId", itemId);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@status", "In Progress");
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public List<OrderInfo> GetOrdersByUser(int userId)
        {
            List<OrderInfo> orders = new List<OrderInfo>();
            string query = "SELECT order_id, item_id, quantity, status FROM Orders WHERE UserId = @userId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int orderId = Convert.ToInt32(reader["order_id"]);
                    int itemId = Convert.ToInt32(reader["item_id"]);
                    int quantity = Convert.ToInt32(reader["quantity"]);
                    string status = reader["status"].ToString();
                    string itemName = DBHelper.GetItemNameFromDatabase(itemId);

                    orders.Add(new OrderInfo
                    {
                        OrderId = orderId,
                        ItemName = itemName,
                        Quantity = quantity,
                        Status = status
                    });
                }
            }

            return orders;
        }


    }
    public class OrderCancellationManager
    {
        private readonly string connectionString = "Data Source=Abofares;Initial Catalog=C#;Integrated Security=True";

        // Cancel an order and insert into CancelledOrders
        public bool CancelOrder(int orderId, int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string checkQuery = "SELECT status FROM Orders WHERE order_id = @orderId AND UserId = @userId";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@orderId", orderId);
                checkCmd.Parameters.AddWithValue("@userId", userId);

                conn.Open();
                SqlDataReader reader = checkCmd.ExecuteReader();

                if (reader.Read())
                {
                    string status = reader["status"].ToString();
                    reader.Close();

                    if (status == "In Progress")
                    {
                        // Update order status to Cancelled
                        string updateQuery = "UPDATE Orders SET status = 'Cancelled' WHERE order_id = @orderId";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@orderId", orderId);
                        updateCmd.ExecuteNonQuery();

                        // Insert into CancelledOrders with refund_status = 'Pending'
                        string insertQuery = "INSERT INTO CancelledOrders (order_id, UserId, refund_status) VALUES (@orderId, @userId, 'Pending')";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@orderId", orderId);
                        insertCmd.Parameters.AddWithValue("@userId", userId);
                        insertCmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }

            return false;
        }

        // View refund status from CancelledOrders
        public List<string> GetRefundStatus(int userId)
        {
            List<string> refunds = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT c.order_id, c.refund_status, o.item_id 
                FROM CancelledOrders c 
                JOIN Orders o ON c.order_id = o.order_id
                WHERE c.UserId = @userId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int orderId = Convert.ToInt32(reader["order_id"]);
                    string refundStatus = reader["refund_status"].ToString();
                    int itemId = Convert.ToInt32(reader["item_id"]);
                    string itemName = DBHelper.GetItemNameFromDatabase(itemId);

                    refunds.Add($"Order #{orderId} - {itemName} - Refund Status: {refundStatus}");
                }
            }

            return refunds;
        }
    }


}