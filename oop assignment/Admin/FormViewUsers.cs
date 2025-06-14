using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Needed for SQL Server database connection
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Needed for form controls (buttons, datagrid, etc.)

namespace oop_assignment
{
    public partial class FormViewUsers : Form
    {
        // This constructor runs when the form is opened
        public FormViewUsers()
        {
            InitializeComponent(); // Set up the form controls
        }

        // This runs when the "Load" button is clicked
        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Connection string to the database (SedapMakanDB)
            string connStr = "Data Source=MSI;Initial Catalog=SedapMakanDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open(); // Open the database connection

                // Create a SQL adapter to run a SELECT * query on Users table
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);

                // Create a DataTable to hold the data from the query
                DataTable dt = new DataTable();

                // Fill the DataTable with results from the database
                da.Fill(dt);

                // Set the data source of the DataGridView to show the users
                dgvUsers.DataSource = dt;
            }
        }

        // This runs when the "Close" button is clicked
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Just close the form
        }

        // This runs when the form first loads
        private void FormViewUsers_Load(object sender, EventArgs e)
        {
            // Nothing happens here now, but you can auto-load users if you want
            // Example: btnLoad.PerformClick();
        }
    }
}
