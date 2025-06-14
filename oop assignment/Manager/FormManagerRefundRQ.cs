using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace oop_assignment
{
    public partial class FormManagerRefundRQ : Form
    {
        private readonly RefundService service;
        private SqlConnection conn = new SqlConnection(@"Data Source=Abofares;Initial Catalog=C#;Integrated Security=True");

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
                    dgvRefunds.Columns["order_id"].Width = 100;
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