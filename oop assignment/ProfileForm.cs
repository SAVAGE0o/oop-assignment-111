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
using System.Configuration;  

namespace oop_assignment
{
    public partial class ProfileForm: Form
    {
       private int userId; 

        public ProfileForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            string connectionString = ConfigurationManager.ConnectionStrings["C#"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection string not found.");
                return;
            }

            string query = "UPDATE UserProfile SET Name = @Name, Email = @email, Password = @password WHERE UserId = @userId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Profile updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonGoback1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChefDashboard mainMenu = new FormChefDashboard();
            mainMenu.Show();
        }
    }
}

