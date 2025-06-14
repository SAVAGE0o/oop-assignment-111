using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_assignment
{
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();   // Loads textboxes, buttons, etc.
        }

        // Save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1) Gather data from form fields
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString() ?? "";
            string walletText = txtWallet.Text.Trim();

            // 2) Basic validation
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(role) ||
                string.IsNullOrWhiteSpace(walletText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(walletText, out decimal wallet))
            {
                MessageBox.Show("Invalid wallet amount.");
                return;
            }

            // 3) Build User object
            var user = new User
            {
                FullName = username,
                Email = email,
                Password = password,
                Role = role,
                WalletBalance = wallet
            };

            // 4) Use the AddUser service (no SQL here!)
            bool success = new AddUser(user).Execute();

            // 5) Feedback
            MessageBox.Show(success
                ? "User added successfully."
                : "Failed to add user.");

            if (success) Close();
        }

        // Form load
        private void FormAddUser_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(new[]
            {
                "System Admin", "Manager", "Chef", "Customer"
            });
        }

        // Cancel button
        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
