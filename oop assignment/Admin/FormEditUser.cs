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
    public partial class FormEditUser : Form
    {
        // Empty constructor (rarely used)
        public FormEditUser()
        {
            InitializeComponent();
        }

        // Overloaded constructor – pre‑fills form when you pass user data in
        public FormEditUser(string userID, string username,
                            string email, string password,
                            string role, string wallet)
        {
            InitializeComponent();

            txtUserID.Text = userID;
            txtUsername.Text = username;
            txtEmail.Text = email;
            txtPassword.Text = password;
            cmbRole.SelectedItem = role;
            txtWallet.Text = wallet;
        }

        // Populate role combo box on load
        private void FormEditUser_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(new[]
            {
                "System Admin", "Manager", "Chef", "Customer"
            });
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // --- basic validation ---
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    cmbRole.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtWallet.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (!decimal.TryParse(txtWallet.Text, out decimal wallet))
                {
                    MessageBox.Show("Wallet must be a number.");
                    return;
                }

                // --- build User object ---
                var user = new User
                {
                    UserID = int.Parse(txtUserID.Text.Trim()),
                    FullName = txtUsername.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Role = cmbRole.SelectedItem.ToString(),
                    WalletBalance = wallet
                };

                // --- run the update via EditUser wrapper ---
                bool success = new EditUser(user).Execute();

                MessageBox.Show(success
                    ? "User updated successfully."
                    : "No rows updated. Check UserID.");

                if (success) Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }
    }
}
