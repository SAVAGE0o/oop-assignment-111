using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace oop_assignment
{
    // This static class handles all the database operations for the User table.
    public static class UserManager
    {
        // Method to get a list of all users from the database
        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>(); // List to store users

            using (SqlConnection conn = DataBaseHelper.GetConnection()) // Get DB connection
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users", conn); // SQL to get all users
                SqlDataReader reader = cmd.ExecuteReader(); // Execute query and get results

                while (reader.Read()) // Loop through each row in result
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

            return users; // Return the full list of users
        }

        // Method to get a single user from the database by their ID
        public static User GetUserById(int userId)
        {
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE UserID = @UserID", conn);
                cmd.Parameters.AddWithValue("@UserID", userId); // Add the ID as a parameter

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // If a user is found
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

            return null; // Return null if no user is found
        }

        // Method to add a new user to the database
        public static bool AddUser(User user)
        {
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();

                // SQL INSERT statement to add user
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Users (FullName, Email, Password, Role, WalletBalance) " +
                    "VALUES (@FullName, @Email, @Password, @Role, @WalletBalance)", conn);

                // Add the values from the user object to the command
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@WalletBalance", user.WalletBalance);

                return cmd.ExecuteNonQuery() > 0; // Return true if insert successful
            }
        }

        // Method to update a user's information in the database
        public static bool UpdateUser(User user)
        {
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();

                // SQL UPDATE statement to update user data
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Users SET FullName = @FullName, Email = @Email, Password = @Password, Role = @Role, WalletBalance = @WalletBalance " +
                    "WHERE UserID = @UserID", conn);

                // Add updated values to the command
                cmd.Parameters.AddWithValue("@UserID", user.UserID);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@WalletBalance", user.WalletBalance);

                return cmd.ExecuteNonQuery() > 0; // Return true if update successful
            }
        }

        // Method to delete a user from the database by ID
        public static bool DeleteUser(int userId)
        {
            using (SqlConnection conn = DataBaseHelper.GetConnection())
            {
                conn.Open();

                // SQL DELETE statement to remove user by ID
                SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID = @UserID", conn);
                cmd.Parameters.AddWithValue("@UserID", userId); // Add user ID to command

                return cmd.ExecuteNonQuery() > 0; // Return true if delete successful
            }
        }
    }
}
