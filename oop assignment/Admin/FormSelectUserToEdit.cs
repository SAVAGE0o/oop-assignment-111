using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // For connecting to and using SQL Server
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // For Windows Forms (buttons, grid, etc.)

namespace oop_assignment
{
    public partial class FormSelectUserToEdit : Form
    {
        // Constructor: runs when this form is first opened
        public FormSelectUserToEdit()
        {
            InitializeComponent(); // Sets up the form UI controls
        }

        // This runs when the "Load Users" button is clicked
        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            // Connection string to the database
            string connStr = "Data Source=MSI;Initial Catalog=C#;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open(); // Open the connection to the database

                // Create a data adapter to get all rows from the Users table
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);

                // Create a table to hold the data
                DataTable dt = new DataTable();

                // Fill the table with data from the database
                da.Fill(dt);

                // Show the data in the DataGridView on the form
                dgvUsers.DataSource = dt;
            }
        }

        // This runs when the "Edit Selected" button is clicked
        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            // Check if a user row is selected in the DataGridView
            if (dgvUsers.SelectedRows.Count > 0)
            {
                // Get the selected row
                var row = dgvUsers.SelectedRows[0];

                // Read the values from that row
                string id = row.Cells["UserID"].Value.ToString();
                string name = row.Cells["Username"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                string password = row.Cells["Password"].Value.ToString();
                string role = row.Cells["Role"].Value.ToString();
                string wallet = row.Cells["WalletBalance"].Value.ToString();

                // Open the Edit User form and pass the selected user's data to it
                new FormEditUser(id, name, email, password, role, wallet).ShowDialog(); // ShowDialog blocks until form closes
            }
        }

        // This runs when the "Cancel" button is clicked
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form without doing anything
        }

        // This runs when the form loads (when it first opens)
        private void FormSelectUserToEdit_Load(object sender, EventArgs e)
        {
            // Nothing here for now – you can use this to auto-load users if you want
        }
    }
}
