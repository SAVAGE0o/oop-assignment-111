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

    public partial class ManagerFeedBack : Form
    {
        private const string V = @"
                    SELECT 
                        f.FeedbackId AS [ID],
                        u.Username AS [Customer Name],
                        o.order_id AS [OrderID],
                        f.FeedbackText AS [Feedback],
                        f.respond AS [Manager Response],
                        f.status AS [Status],
                        f.FeedbackDate AS [Date]
                    FROM Feedback f
                    INNER JOIN Users u ON f.UserId = u.UserId
                    INNER JOIN Orders o ON f.order_id = o.order_id";
        private SqlConnection conn = new SqlConnection(@"Data Source=CYBORG\SQLEXPRESS;Initial Catalog=C#;Integrated Security=True");


        // Store the manager's ID passed during form initialization
        private string managerId;

        public ManagerFeedBack(string managerId)
        {
            InitializeComponent();
            this.managerId = managerId;
        }

        public ManagerFeedBack()
        {
        }

        // Form load event handler
        private void ManagerFeedBack_Load(object sender, EventArgs e)
        {
            // Load feedback data
            LoadFeedback();
        }

        // Method to load feedback from database into DataGridView
        private void LoadFeedback()
        {
            try
            {
                string query = V;

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvFeedBack.DataSource = dt;  // Bind the data to DataGridView

                // Optional column formatting for DataGridView
                dgvFeedBack.Columns["ID"].Width = 50;
                dgvFeedBack.Columns["Customer Name"].Width = 150;
                dgvFeedBack.Columns["OrderID"].Width = 100;
                dgvFeedBack.Columns["Feedback"].Width = 300;
                dgvFeedBack.Columns["Manager Response"].Width = 200;
                dgvFeedBack.Columns["Status"].Width = 100;
                dgvFeedBack.Columns["Date"].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback: " + ex.Message);
            }
        }

        // Method to handle the response button click event


        // Optional: Event handler for DataGridView cell click (if needed)
        private void dgvFeedBack_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFeedBack.SelectedRows.Count > 0)
            {
                string feedbackText = dgvFeedBack.SelectedRows[0].Cells["Feedback"].Value.ToString();
                rtbResponses.Text = feedbackText;   // Handle any actions when clicking on a DataGridView cell (e.g., highlight the row or show more details)
            }
        }
        private void txtResponses_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvFeedBack.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a feedback entry to respond to.");
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbResponses.Text))
            {
                MessageBox.Show("Please enter a response.");
                return;
            }

            try
            {
                // Get the Feedback ID from the selected row
                int feedbackId = Convert.ToInt32(dgvFeedBack.SelectedRows[0].Cells["ID"].Value);
                string response = rtbResponses.Text.Trim();

                // SQL query to update the response for the selected feedback
                string query = "UPDATE Feedback SET respond = @response, status = 'Replied' WHERE FeedbackId = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@response", response);
                cmd.Parameters.AddWithValue("@id", feedbackId);

                conn.Open();
                cmd.ExecuteNonQuery();  // Execute the update query
                conn.Close();

                MessageBox.Show("Response submitted successfully.");

                // Clear the response RichTextBox and refresh the DataGridView
                rtbResponses.Clear();  // Clear the RichTextBox
                LoadFeedback();  // Refresh the DataGridView to show the updated response
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting response: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}