using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace oop_assignment
{
    public static class UserManager
    {
        // Get all users from the database
        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    users.Add(new User
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        FullName = reader["FullName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString(),
                        WalletBalance = Convert.ToDecimal(reader["WalletBalance"])
                    });
                }
            }

            return users;
        }

        // Get a single user by ID
        public static User GetUserById(int userId)
        {
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserID = @UserID", conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new User
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        FullName = reader["FullName"].ToString(),
                        Email = reader["Email"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString(),
                        WalletBalance = Convert.ToDecimal(reader["WalletBalance"])
                    };
                }
            }

            return null;
        }

        // Add a new user
        public static bool AddUser(User user)
        {
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (FullName, Email, Password, Role, WalletBalance) VALUES (@FullName, @Email, @Password, @Role, @WalletBalance)", conn);

                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@WalletBalance", user.WalletBalance);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Update an existing user
        public static bool UpdateUser(User user)
        {
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Users SET FullName = @FullName, Email = @Email, Password = @Password, Role = @Role, WalletBalance = @WalletBalance WHERE UserID = @UserID", conn);

                cmd.Parameters.AddWithValue("@UserID", user.UserID);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@WalletBalance", user.WalletBalance);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Delete a user by ID
        public static bool DeleteUser(int userId)
        {
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID = @UserID", conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
