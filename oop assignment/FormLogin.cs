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

            string connectionString = "Data Source=(local);Initial Catalog=SedapMakanDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Step 1: Check in Users table
                    string queryUsers = "SELECT Role FROM Users WHERE Email = @Email AND Password = @Password";
                    SqlCommand cmdUsers = new SqlCommand(queryUsers, conn);
                    cmdUsers.Parameters.AddWithValue("@Email", email);
                    cmdUsers.Parameters.AddWithValue("@Password", password);

                    object resultUsers = cmdUsers.ExecuteScalar();

                    if (resultUsers != null)
                    {
                        string role = resultUsers.ToString();
                        MessageBox.Show("Login successful! Role: " + role);

                        // Redirect based on role
                        if (role == "System Admin")
                            new FormAdminDashboard().Show();
                        else if (role == "Manager")
                            new FormManagerDashboard().Show();
                        else if (role == "Chef")
                            new FormChefDashboard().Show();
                        else if (role == "Customer")
                            new FormCustomerDashboard().Show();
                        else
                            MessageBox.Show("Unknown role: " + role);

                        this.Hide();
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


        private void LoginExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

