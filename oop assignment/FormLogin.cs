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
    public partial class FormLogin: Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            string connectionString = "Data Source=MSI;Initial Catalog=SedapMakanDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT Role FROM Users WHERE Email = @Email AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();

                        // ✅ Show simple message box
                        MessageBox.Show("Login successful! Role: " + role);

                        // ✅ Open the correct form
                        if (role == "System Admin")
                        {
                            new FormAdminDashboard().Show();
                            this.Hide();
                        }
                        else if (role == "Manager")
                        {
                            new FormManagerDashboard().Show();
                            this.Hide();
                        }
                        else if (role == "Chef")
                        {
                            new FormChefDashboard().Show();
                            this.Hide();
                        }
                        else if (role == "Customer")
                        {
                            new FormCustomerDashboard().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Unknown role: " + role);
                        }
                    }
                    else
                    {
                        lblMessage.Text = "Invalid email or password.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

