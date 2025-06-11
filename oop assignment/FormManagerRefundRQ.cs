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
    public partial class FormManagerRefundRQ : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=CYBORG\SQLEXPRESS;Initial Catalog=C#;Integrated Security=True");

        public FormManagerRefundRQ()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvRefunds.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a refund request.");
                return;
            }

            // Ensure the manager selects either 'Approve' or 'Reject'
            if (!rdoApprove.Checked && !rdoReject.Checked)
            {
                MessageBox.Show("Please select Approve or Reject.");
                return;
            }

            // Retrieve necessary data from the selected row in DataGridView
            int refundId = Convert.ToInt32(dgvRefunds.SelectedRows[0].Cells["RefundId"].Value);
            int userId = Convert.ToInt32(dgvRefunds.SelectedRows[0].Cells["UserId"].Value);
            decimal amount = Convert.ToDecimal(dgvRefunds.SelectedRows[0].Cells["Amount"].Value);
            string status = rdoApprove.Checked ? "Approved" : "Rejected";

            try
            {
                // Update the status of the refund request
                string updateQuery = "UPDATE RefundRequests SET Status = @status WHERE RefundId = @id";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", refundId);

                conn.Open();
                cmd.ExecuteNonQuery();

                // If the refund is approved, process the wallet top-up
                if (status == "Approved")
                {
                    // Update wallet balance for the user
                    string updateWallet = "UPDATE Users SET WalletBalance = WalletBalance + @amount WHERE UserId = @uid";
                    SqlCommand walletCmd = new SqlCommand(updateWallet, conn);
                    walletCmd.Parameters.AddWithValue("@amount", amount);
                    walletCmd.Parameters.AddWithValue("@uid", userId);
                    walletCmd.ExecuteNonQuery();

                    // Log the top-up transaction in WalletTransactions table
                    string logTransaction = "INSERT INTO WalletTransactions (UserId, Amount, Type, TransactionDate) VALUES (@uid, @amount, 'Topup', GETDATE())";
                    SqlCommand transCmd = new SqlCommand(logTransaction, conn);
                    transCmd.Parameters.AddWithValue("@uid", userId);
                    transCmd.Parameters.AddWithValue("@amount", amount);
                    transCmd.ExecuteNonQuery();
                }

                conn.Close();
                MessageBox.Show($"Refund {status.ToLower()} successfully.");
                FormManagerRefundRQ_Load(); // Refresh the DataGridView to show the updated refund status
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing refund: " + ex.Message);
                if (conn.State == ConnectionState.Open)
                    conn.Close();

            }
        }
private void FormManagerRefundRQ_Load()
        {
            throw new NotImplementedException();
        }

        private void FormManagerRefundRQ_Load(object sender, EventArgs e)
        {
            try
            {
                // SQL query to load pending refund requests
                string query = @"
            SELECT 
                r.RefundId, 
                r.UserId,
                r.OrderId, 
                r.Amount, 
                r.Reason, 
                r.Status, 
                r.RequestDate
            FROM RefundRequests r
            INNER JOIN Users u ON r.UserId = u.UserId
            WHERE r.Status = 'Pending'";  // Only show pending refunds

                // Execute the query using SqlDataAdapter to fill the DataTable
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Bind the DataTable to the DataGridView
                dgvRefunds.DataSource = dt;

                // Optional: Column formatting (this is to make the grid look better)
                dgvRefunds.Columns["RefundId"].Width = 50;
                dgvRefunds.Columns["OrderId"].Width = 100;
                dgvRefunds.Columns["Amount"].Width = 100;
                dgvRefunds.Columns["Reason"].Width = 250;
                dgvRefunds.Columns["Status"].Width = 100;
                dgvRefunds.Columns["RequestDate"].Width = 120;
            }
            catch (Exception ex)
            {
                // Display error message if an exception occurs
                MessageBox.Show("Error loading refund requests: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
