using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_assignment
{
    public partial class FormEditUser : Form
    {
        public FormEditUser()
        {
            InitializeComponent();
        }

        public FormEditUser(string userID, string username, string email, string password, string role, string wallet)
        {
            InitializeComponent();

            txtUserID.Text = userID;
            txtUsername.Text = username;
            txtEmail.Text = email;
            txtPassword.Text = password;
            cmbRole.SelectedItem = role;
            txtWallet.Text = wallet;
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(new string[] { "System Admin", "Manager", "Chef", "Customer" });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User
                {
                    UserID = int.Parse(txtUserID.Text.Trim()),
                    FullName = txtUsername.Text.Trim(), // FullName used for Username
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Role = cmbRole.SelectedItem?.ToString(),
                    WalletBalance = decimal.Parse(txtWallet.Text.Trim())
                };

                bool success = UserManager.UpdateUser(user);

                if (success)
                {
                    MessageBox.Show("User updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No rows updated. Check UserID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message);
            }
        }
    }
}
