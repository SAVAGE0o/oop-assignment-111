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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string connectionString = "Data Source=Abofares;Initial Catalog=C#;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Updated query to also retrieve UserId
                    string query = "SELECT UserId, Role FROM Users WHERE Email = @Email AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Store UserId and Role in session
                        CurrentSession.UserId = Convert.ToInt32(reader["UserId"]);
                        
                        string role = reader["Role"].ToString();

                        MessageBox.Show("Login successful! Role: " + role + "\nUserId: " + CurrentSession.UserId);

                        // Open the correct dashboard
                        switch (role)
                        {
                            case "System Admin":
                                new FormAdminDashboard().Show();
                                break;
                            case "Manager":
                                new FormManagerDashboard().Show();
                                break;
                            case "Chef":
                                new FormChefDashboard().Show();
                                break;
                            case "Customer":
                                new FormCustomerDashboard().Show();
                                break;
                            default:
                                MessageBox.Show("Unknown role: " + role);
                                return;
                        }

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

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

