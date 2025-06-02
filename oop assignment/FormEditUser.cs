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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=MSI;Initial Catalog=C#;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "UPDATE Users SET Username = @Username, Email = @Email, Password = @Password, Role = @Role, WalletBalance = @Wallet WHERE UserID = @UserID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", txtUserID.Text.Trim());
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@Wallet", decimal.Parse(txtWallet.Text.Trim()));

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No rows updated. Check UserID.");

   
                }
            }
        }
     
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
