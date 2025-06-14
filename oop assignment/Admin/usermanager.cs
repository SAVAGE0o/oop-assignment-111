using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace oop_assignment
{
    // Handles all DB operations for the Users table
    public static class UserManager
    {
        // ---------------- READ ALL ----------------
        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Users", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        FullName = reader["Username"].ToString(),   // <-- Username col
                        Email = reader["Email"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString(),
                        WalletBalance = Convert.ToDecimal(reader["WalletBalance"])
                    });
                }
            }
            return users;
        }

        // ---------------- READ ONE ----------------
        public static User GetUserById(int userId)
        {
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "SELECT * FROM Users WHERE UserID = @UserID", conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        FullName = reader["Username"].ToString(),   // <-- Username col
                        Email = reader["Email"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString(),
                        WalletBalance = Convert.ToDecimal(reader["WalletBalance"])
                    };
                }
            }
            return null;
        }

        // ---------------- CREATE ----------------
        public static bool AddUser(User user)
        {
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "INSERT INTO Users (Username, Email, Password, Role, WalletBalance) " +   // <-- Username
                    "VALUES (@Username, @Email, @Password, @Role, @WalletBalance)", conn);

                cmd.Parameters.AddWithValue("@Username", user.FullName);   // maps to property
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@WalletBalance", user.WalletBalance);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ---------------- UPDATE ----------------
        public static bool UpdateUser(User user)
        {
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "UPDATE Users SET Username = @Username, Email = @Email, " +   // <-- Username
                    "Password = @Password, Role = @Role, WalletBalance = @WalletBalance " +
                    "WHERE UserID = @UserID", conn);

                cmd.Parameters.AddWithValue("@UserID", user.UserID);
                cmd.Parameters.AddWithValue("@Username", user.FullName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@WalletBalance", user.WalletBalance);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // ---------------- DELETE ----------------
        public static bool DeleteUser(int userId)
        {
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM Users WHERE UserID = @UserID", conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
