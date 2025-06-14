using System;
using System.Data;
using System.Data.SqlClient; // To connect and work with SQL Server
using System.Windows.Forms; // For UI controls like buttons, grid, etc.

namespace oop_assignment
{
    public partial class FormDeleteUser : Form
    {
        public FormDeleteUser()
        {
            InitializeComponent(); // Initializes all form controls
        }

        // This runs when the Delete button is clicked (usually button2)
        private void button2_Click(object sender, EventArgs e)
        {
            // Check if the user selected a row in the DataGridView
            if (dgvUsers.SelectedRows.Count > 0)
            {
                // Get the UserID from the selected row (convert to int)
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);

                // Ask the user to confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Call the method from UserManager to delete the user
                    bool success = UserManager.DeleteUser(userId);

                    if (success)
                    {
                        MessageBox.Show("User deleted successfully.");

                        // Reload the user list by clicking the Load button again
                        btnLoad.PerformClick();
                    }
                    else
                    {
                        // If deletion failed, show message
                        MessageBox.Show("No user deleted. Check UserID.");
                    }
                }
            }
            else
            {
                // If no row is selected in the grid
                MessageBox.Show("Please select a user to delete.");
            }
        }

        // This runs when the Load button is clicked
        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Connection string to connect to the database
            string connStr = "Data Source=MSI;Initial Catalog=C#;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open(); // Open the database connection

                // SQL Adapter to fetch all users from Users table
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);

                // DataTable to hold the data
                DataTable dt = new DataTable();

                // Fill the DataTable with the result from the query
                da.Fill(dt);

                // Show the result in the DataGridView
                dgvUsers.DataSource = dt;
            }
        }

        // This runs when the Cancel button is clicked
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Just close the form
        }

        // This runs when the form loads (when it first opens)
        private void FormDeleteUser_Load(object sender, EventArgs e)
        {
            // Optional: auto load users when form loads
            // btnLoad.PerformClick(); // Uncomment if you want it to load automatically
        }
    }
}
