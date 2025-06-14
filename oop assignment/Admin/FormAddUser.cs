using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // For connecting and working with SQL database
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // For using forms and controls

namespace oop_assignment
{
    public partial class FormAddUser : Form
    {
        // Constructor: when the form is created, this runs first
        public FormAddUser()
        {
            InitializeComponent(); // This loads all the controls (like textboxes, buttons, etc.)
        }

        // This runs when I click the "Save" button
        private void btnSave_Click(object sender, EventArgs e)
        {
            // I get all the data entered by the user into variables
            string username = txtUsername.Text.Trim(); // Remove extra spaces from username
            string email = txtEmail.Text.Trim();       // Remove extra spaces from email
            string password = txtPassword.Text.Trim(); // Remove extra spaces from password
            string role = cmbRole.SelectedItem?.ToString() ?? ""; // Get selected role from the dropdown
            string walletText = txtWallet.Text.Trim(); // Get wallet balance as text

            // If any field is empty, show error and stop
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(walletText))
            {
                MessageBox.Show("Please fill in all fields."); // Show a message box
                return; // Stop the function here
            }

            // Try to convert wallet text to decimal (number with decimals)
            if (!decimal.TryParse(walletText, out decimal wallet))
            {
                MessageBox.Show("Invalid wallet amount."); // If conversion fails, show error
                return;
            }

            // Connection string to my local database
            string connStr = "Data Source=Abofares;Initial Catalog=SedapMakanDB;Integrated Security=True";

            // Using statement makes sure the connection closes properly after use
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open(); // Open the connection to the database

                    // SQL command to insert the new user data into the Users table
                    string query = "INSERT INTO Users (Username, Email, Password, Role, WalletBalance) " +
                                   "VALUES (@Username, @Email, @Password, @Role, @Wallet)";

                    // Create the command and add the values to it
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@Wallet", wallet);

                    // Run the command (insert into database)
                    cmd.ExecuteNonQuery();

                    // Show success message
                    MessageBox.Show("User added successfully.");

                    // Close the form after adding the user
                    this.Close();
                }
                catch (Exception ex)
                {
                    // If something goes wrong with the database, show the error message
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        // This runs when the form first loads
        private void FormAddUser_Load(object sender, EventArgs e)
        {
            // Add the list of user roles to the role combo box
            cmbRole.Items.AddRange(new string[] { "System Admin", "Manager", "Chef", "Customer" });
        }

        // This runs when I click the Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Just close the form without saving anything
        }
    }
}
