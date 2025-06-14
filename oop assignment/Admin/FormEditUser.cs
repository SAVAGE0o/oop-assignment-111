using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Needed to work with SQL Server
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Needed to build the form

namespace oop_assignment
{
    public partial class FormEditUser : Form
    {
        // Default constructor – runs when the form is created with no data
        public FormEditUser()
        {
            InitializeComponent(); // Set up the form controls
        }

        // Overloaded constructor – this one is used when opening the form with user data
        public FormEditUser(string userID, string username, string email, string password, string role, string wallet)
        {
            InitializeComponent(); // Set up the form controls

            // Fill in the form fields with existing user data
            txtUserID.Text = userID;
            txtUsername.Text = username;
            txtEmail.Text = email;
            txtPassword.Text = password;
            cmbRole.SelectedItem = role; // Set the selected role in the combo box
            txtWallet.Text = wallet;
        }

        // Runs when the form loads
        private void FormEditUser_Load(object sender, EventArgs e)
        {
            // Add the user roles to the combo box so the user can choose
            cmbRole.Items.AddRange(new string[] { "System Admin", "Manager", "Chef", "Customer" });
        }

        // Runs when the Cancel button is clicked
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form without saving changes
        }

        // Runs when the Update button is clicked
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new User object and fill it with the updated values from the form
                User user = new User
                {
                    UserID = int.Parse(txtUserID.Text.Trim()), // Convert UserID from text to int
                    FullName = txtUsername.Text.Trim(),         // Set FullName (same as username here)
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Role = cmbRole.SelectedItem?.ToString(),   // Get selected role
                    WalletBalance = decimal.Parse(txtWallet.Text.Trim()) // Convert wallet to decimal
                };

                // Call UpdateUser method from UserManager to update this user in the database
                bool success = UserManager.UpdateUser(user);

                if (success)
                {
                    // Show success message and close the form
                    MessageBox.Show("User updated successfully.");
                    this.Close();
                }
                else
                {
                    // If no row was affected (maybe wrong ID), show this
                    MessageBox.Show("No rows updated. Check UserID.");
                }
            }
            catch (Exception ex)
            {
                // If there's any error (like invalid input), show it
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }
    }
}
