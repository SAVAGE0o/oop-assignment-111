
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
        private string managerId = "12345";
        private readonly string connectionString = "Data Source=Abofares;Initial Catalog=C#;Integrated Security=True";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Please enter both email and password.";
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT UserId, Username, Email, Role FROM Users WHERE Email = @Email AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        
                        CurrentSession.UserId = Convert.ToInt32(reader["UserId"]);
                        CurrentSession.Username = reader["Username"].ToString();
                        CurrentSession.Email = reader["Email"].ToString();
                        string role = reader["Role"].ToString();

                        MessageBox.Show("Login successful! Role: " + role);

                       
                        switch (role)
                        {
                            case "System Admin":
                                new FormAdminDashboard().Show();
                                break;

                            case "Manager":
                               
                                new FormManagerDashboard(managerId).Show();
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

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
