using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace oop_assignment
{
    public partial class FormManagerRefundRQ : Form
    {
        private readonly RefundService service; // Instance of the RefundService class to interact with the database
        private SqlConnection conn = new SqlConnection(@"Data Source=CYBORG\SQLEXPRESS;Initial Catalog=C#;Integrated Security=True"); // Connection string for the database

        // Constructor to initialize the form and set up the RefundService
        public FormManagerRefundRQ()
        {
            InitializeComponent(); // Initialize the form's components (UI elements)
            service = new RefundService(conn.ConnectionString); // Create the RefundService instance using the connection string
        }

        // This method is triggered when the form is loaded
        private void FormManagerRefundRQ_Load(object sender, EventArgs e)
        {
            try
            {
                // Load pending refund requests from the database and bind to the DataGridView
                dgvRefunds.DataSource = service.LoadPending();

                // Adjust the column widths for better readability
                if (dgvRefunds.Columns.Count > 0)
                {
                    dgvRefunds.Columns["RefundId"].Width = 50;
                    dgvRefunds.Columns["OrderId"].Width = 100;
                    dgvRefunds.Columns["Amount"].Width = 100;
                    dgvRefunds.Columns["Reason"].Width = 250;
                    dgvRefunds.Columns["Status"].Width = 100;
                    dgvRefunds.Columns["RequestDate"].Width = 120;
                }

                // Deselect the radio buttons for Approve and Reject initially
                rdoApprove.Checked = false;
                rdoReject.Checked = false;
            }
            catch (Exception ex)
            {
                // If an error occurs while loading data, display the error message
                MessageBox.Show("Error loading data:\n" + ex.Message);
            }
        }

        // Empty event handler for the DataGridView cell content click (not being used in this code)
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // This method is triggered when the "Submit" button is clicked
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if a refund request is selected in the DataGridView
            if (dgvRefunds.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a refund request.");
                return;
            }

            // Ensure that either Approve or Reject is selected
            if (!rdoApprove.Checked && !rdoReject.Checked)
            {
                MessageBox.Show("Please select Approve or Reject.");
                return;
            }

            // Retrieve the data from the selected row in the DataGridView
            var row = dgvRefunds.SelectedRows[0];
            int refundId = (int)row.Cells["RefundId"].Value;
            int userId = (int)row.Cells["UserId"].Value;
            decimal amount = (decimal)row.Cells["Amount"].Value;
            string status = rdoApprove.Checked ? "Approved" : "Rejected"; // Set the status based on the selected radio button

            try
            {
                // Call the RefundService to update the refund status and process it
                service.UpdateStatusAndProcess(refundId, userId, amount, status);
                MessageBox.Show($"Refund {status.ToLower()} successfully."); // Show success message
                FormManagerRefundRQ_Load(sender, e); // Reload the data to reflect the updated refund status
            }
            catch (Exception ex)
            {
                // If an error occurs during the refund process, display the error message
                MessageBox.Show("Error processing refund:\n" + ex.Message);
            }
        }

        // This method is triggered when the "Exit" button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the from
        }
    }
}
