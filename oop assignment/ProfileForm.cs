using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace oop_assignment
{
    public partial class ProfileForm: Form
    {
        private readonly string connectionString = "Data Source=MSI;Initial Catalog=C#;Integrated Security=True";
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newEmail = emailText.Text.Trim();
            string newPassword = passwordText.Text.Trim();

            if (string.IsNullOrEmpty(newEmail) && string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please enter a new email or password.");
                return;
            }

            // ✅ Email validation: must be a valid email format and end with @gmail.com
            if (!string.IsNullOrEmpty(newEmail))
            {
                if (!IsValidEmail(newEmail) || !newEmail.EndsWith("@gmail.com"))
                {
                    MessageBox.Show("Please enter a valid Gmail address.");
                    return;
                }
            }

            // ✅ Password validation: must be at least 6 characters
            if (!string.IsNullOrEmpty(newPassword) && newPassword.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Build update query dynamically based on which fields are entered
                    string updateQuery = "UPDATE Users SET ";
                    if (!string.IsNullOrEmpty(newEmail)) updateQuery += "Email = @Email";
                    if (!string.IsNullOrEmpty(newPassword))
                    {
                        if (!string.IsNullOrEmpty(newEmail)) updateQuery += ", ";
                        updateQuery += "Password = @Password";
                    }
                    updateQuery += " WHERE UserId = @UserId";

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    if (!string.IsNullOrEmpty(newEmail)) cmd.Parameters.AddWithValue("@Email", newEmail);
                    if (!string.IsNullOrEmpty(newPassword)) cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@UserId", CurrentSession.UserId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        if (!string.IsNullOrEmpty(newEmail))
                        {
                            CurrentSession.Email = newEmail; // Update session
                        }

                        MessageBox.Show("Profile updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            emailText.Text = CurrentSession.Email;
        }
        //  Validate the email format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void returnButton_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }
    }
}
