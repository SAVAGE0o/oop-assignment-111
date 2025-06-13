using System;

namespace oop_assignment
{
    public class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public decimal WalletBalance { get; set; }

        // Default constructor
        public User() { }

        // Parameterized constructor
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
