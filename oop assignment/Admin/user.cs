using System;

namespace oop_assignment
{
    // This class represents a user in the system (e.g., Admin, Manager, Customer, etc.)
    public class User
    {
        // Unique ID for the user (usually from the database)
        public int UserID { get; set; }

        // The full name of the user (used as username in this project)
        public string FullName { get; set; }

        // The user's email address
        public string Email { get; set; }

        // The user's password (stored as plain text here, but should be hashed in real applications)
        public string Password { get; set; }

        // The role of the user (e.g., System Admin, Manager, Chef, Customer)
        public string Role { get; set; }

        // The amount of money in the user's e-wallet
        public decimal WalletBalance { get; set; }

        // Default constructor: creates an empty user object
        public User() { }

        // Constructor with parameters: useful when we want to quickly create a user with values
        public User(int userID, string fullName, string email, string password, string role, decimal walletBalance)
        {
            UserID = userID;
            FullName = fullName;
            Email = email;
            Password = password;
            Role = role;
            WalletBalance = walletBalance;
        }
    }
}
