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
        private readonly RefundService service;
        private SqlConnection conn = new SqlConnection(@"Data Source=CYBORG\SQLEXPRESS;Initial Catalog=C#;Integrated Security=True");

        public class RefundRequest
    {
        public int RefundId { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public DateTime RequestDate { get; set; }
    }

    // ---------- SERVICE ----------
    public class RefundService
    {
        private readonly string connStr;

        public RefundService(string connectionString)
        {
            connStr = connectionString;
        }

        public DataTable LoadPending()
        {
            using (var conn = new SqlConnection(connStr))
            {
                string query = @"SELECT r.RefundId, r.UserId, r.OrderId, r.Amount, r.Reason, r.Status, r.RequestDate
                                 FROM RefundRequests r INNER JOIN Users u ON r.UserId = u.UserId
                                 WHERE r.Status = 'Pending'";
                using (var da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public void UpdateStatusAndProcess(int refundId, int userId, decimal amount, string status)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                using (var cmd = new SqlCommand("UPDATE RefundRequests SET Status = @status WHERE RefundId = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", refundId);
                    cmd.ExecuteNonQuery();
                }

                if (status == "Approved")
                {
                    using (var walletCmd = new SqlCommand("UPDATE Users SET WalletBalance = WalletBalance + @amount WHERE UserId = @uid", conn))
                    {
                        walletCmd.Parameters.AddWithValue("@amount", amount);
                        walletCmd.Parameters.AddWithValue("@uid", userId);
                        walletCmd.ExecuteNonQuery();
                    }

                    using (var logCmd = new SqlCommand("INSERT INTO WalletTransactions (UserId, Amount, Type, TransactionDate) VALUES (@uid, @amount, 'Topup', GETDATE())", conn))
                    {
                        logCmd.Parameters.AddWithValue("@uid", userId);
                        logCmd.Parameters.AddWithValue("@amount", amount);
                        logCmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }



   // ---------- FORM ----------

  
        public FormManagerRefundRQ()
        {
            InitializeComponent();
            service = new RefundService(conn.ConnectionString);
        }


        private void FormManagerRefundRQ_Load(object sender, EventArgs e)
        {
            try
            {
                dgvRefunds.DataSource = service.LoadPending();

                if (dgvRefunds.Columns.Count > 0)
                {
                    dgvRefunds.Columns["RefundId"].Width = 50;
                    dgvRefunds.Columns["OrderId"].Width = 100;
                    dgvRefunds.Columns["Amount"].Width = 100;
                    dgvRefunds.Columns["Reason"].Width = 250;
                    dgvRefunds.Columns["Status"].Width = 100;
                    dgvRefunds.Columns["RequestDate"].Width = 120;
                }

                rdoApprove.Checked = false;
                rdoReject.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data:\n" + ex.Message);
            }
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

            if (!rdoApprove.Checked && !rdoReject.Checked)
            {
                MessageBox.Show("Please select Approve or Reject.");
                return;
            }

            var row = dgvRefunds.SelectedRows[0];
            int refundId = (int)row.Cells["RefundId"].Value;
            int userId = (int)row.Cells["UserId"].Value;
            decimal amount = (decimal)row.Cells["Amount"].Value;
            string status = rdoApprove.Checked ? "Approved" : "Rejected";

            try
            {
                service.UpdateStatusAndProcess(refundId, userId, amount, status);
                MessageBox.Show($"Refund {status.ToLower()} successfully.");
                FormManagerRefundRQ_Load(sender, e); // reload
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing refund:\n" + ex.Message);
            }
        }
        
      
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
