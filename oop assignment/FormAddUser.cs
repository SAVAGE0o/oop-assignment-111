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
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString() ?? "";
            string walletText = txtWallet.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(walletText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(walletText, out decimal wallet))
            {
                MessageBox.Show("Invalid wallet amount.");
                return;
            }

            string connStr = "Data Source=Abofares;Initial Catalog=SedapMakanDB;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, Email, Password, Role, WalletBalance) " +
                                   "VALUES (@Username, @Email, @Password, @Role, @Wallet)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@Wallet", wallet);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User added successfully.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(new string[] { "System Admin", "Manager", "Chef", "Customer" });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
