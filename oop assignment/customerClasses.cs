using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace oop_assignment
{
   

    public class menuItems
    {
        public string Name { get; set; }
        public int Price { get; set; }

        private SqlConnection conn = new SqlConnection("Data Source=Abofares;Initial Catalog=C#;Integrated Security=True");

        // (availability = 'Yes')
        public List<menuItems> GetAvailableItems()
        {
            List<menuItems> availableItems = new List<menuItems>();
            string query = "SELECT item_name, price FROM Menu WHERE availability = 'Yes'";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                availableItems.Add(new menuItems
                {
                    Name = reader["item_name"].ToString(),
                    Price = Convert.ToInt32(reader["price"])
                });
            }

            conn.Close();
            return availableItems;
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
            return $"#{OrderId} - {ItemName} x{Quantity} - {Status}";
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




        public class OrderCancellationManager
        {
            private readonly string connectionString = "Data Source=Abofares;Initial Catalog=C#;Integrated Security=True";

            // Cancel an order and insert refund request
            public bool CancelOrder(int orderId, int userId, string reason)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Step 1: Check if the order exists and is cancellable
                    string checkQuery = "SELECT status, item_id FROM Orders WHERE order_id = @orderId AND UserId = @userId";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@orderId", orderId);
                    checkCmd.Parameters.AddWithValue("@userId", userId);

                    SqlDataReader reader = checkCmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("Order not found or not owned by user.");
                        conn.Close();
                        return false; // Order not found or not owned by user
                    }

                    string status = reader["status"].ToString();
                    int itemId = Convert.ToInt32(reader["item_id"]);
                    reader.Close();

                    if (status != "In Progress")
                    {
                        MessageBox.Show(status + orderId + userId);
                        conn.Close();
                        return false; // Only 'In Progress' orders can be cancelled
                    }

                    // Step 2: Get item price from Menu
                    string priceQuery = "SELECT price FROM Menu WHERE item_id = @itemId";
                    SqlCommand priceCmd = new SqlCommand(priceQuery, conn);
                    priceCmd.Parameters.AddWithValue("@itemId", itemId);

                    object result = priceCmd.ExecuteScalar();


                    decimal amount = Convert.ToDecimal(result);

                    // Step 3: Cancel the order
                    string updateOrderQuery = "UPDATE Orders SET status = 'Cancelled' WHERE order_id = @orderId";
                    SqlCommand updateCmd = new SqlCommand(updateOrderQuery, conn);
                    updateCmd.Parameters.AddWithValue("@orderId", orderId);
                    updateCmd.ExecuteNonQuery();

                    // Step 4: Insert refund request
                    string insertRefundQuery = @"
                INSERT INTO RefundRequests (UserId, order_id, Amount, Reason, Status)
                VALUES (@userId, @orderId, @amount, @reason, 'Pending')";

                    SqlCommand insertCmd = new SqlCommand(insertRefundQuery, conn);
                    insertCmd.Parameters.AddWithValue("@userId", userId);
                    insertCmd.Parameters.AddWithValue("@orderId", orderId);
                    insertCmd.Parameters.AddWithValue("@amount", amount);
                    insertCmd.Parameters.AddWithValue("@reason", reason);
                    insertCmd.ExecuteNonQuery();

                    conn.Close();
                    return true;
                }
            }

            // View refund statuses
            public List<string> GetRefundStatus(int userId)
            {
                List<string> refunds = new List<string>();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT r.order_id, r.Status, r.Amount, r.Reason, o.item_id
                FROM RefundRequests r
                JOIN Orders o ON r.order_id = o.order_id
                WHERE r.UserId = @userId";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int orderId = Convert.ToInt32(reader["order_id"]);
                        string refundStatus = reader["Status"].ToString();
                        decimal amount = Convert.ToDecimal(reader["Amount"]);
                        string reason = reader["Reason"].ToString();
                        int itemId = Convert.ToInt32(reader["item_id"]);
                        string itemName = DBHelper.GetItemNameFromDatabase(itemId);

                        refunds.Add($"Order #{orderId} - {itemName} - Amount: RM {amount} - Reason: {reason} - Status: {refundStatus}");
                    }

                    conn.Close();
                }

                return refunds;
            }
        }

        public class FeedbackManager
        {
            private readonly string connectionString = "Data Source=Abofares;Initial Catalog=C#;Integrated Security=True";

            public void SubmitFeedback(int userId, int orderId, string text)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Feedback 
        (UserId, order_id, FeedbackText, respond, status, FeedbackDate) 
        VALUES (@userId, @orderId, @text, NULL, @status, @date)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    cmd.Parameters.AddWithValue("@text", text);
                    cmd.Parameters.AddWithValue("@status", "New");
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }


            }
            public bool HasFeedback(int userId, int orderId)
            {
                using (SqlConnection conn = new SqlConnection("Data Source = Abofares; Initial Catalog = C#;Integrated Security=True"))
                {
                    string query = "SELECT COUNT(*) FROM Feedback WHERE UserId = @userId AND order_id = @orderId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@orderId", orderId);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

    }
}