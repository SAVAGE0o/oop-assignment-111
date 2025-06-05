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
    public partial class Form4 : Form
    {

        private string managerId;
        private SqlConnection conn = new SqlConnection(@"Data Source=CYBORG\SQLEXPRESS;Initial Catalog=C#;Integrated Security=True");
       
        

        public Form4()
        {
            InitializeComponent();

        }
        public Form4(string id)
        {
            InitializeComponent();
            managerId = id;
        }

        public Form4(SqlConnection conn)
        {
            this.conn = conn;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            LoadFeedback();

        }

        private void LoadFeedback()
        {
            {
                try
                {
                    string query = @"
                    SELECT 
                        FeedbackId AS [ID],
                        CustomerName AS [Customer Name],
                        FeedbackText AS [Feedback],
                        responseText AS [ Manager Response],
                        FeedbackDate AS [Date]
                    FROM Feedback";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvFeedback.DataSource = dt;

                    // Optional formatting
                    dgvFeedback.Columns["ID"].Width = 50;
                    dgvFeedback.Columns["Customer Name"].Width = 150;
                    dgvFeedback.Columns["Feedback"].Width = 300;
                    dgvFeedback.Columns["Date"].Width = 120;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading feedback: " + ex.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvFeedback.SelectedRows.Count == 0)
    {
        MessageBox.Show("Please select a feedback entry to respond to.");
        return;
    }

    if (string.IsNullOrWhiteSpace(txtResponse.Text))
    {
        MessageBox.Show("Please enter a response.");
        return;
    }

    try
    {
        int feedbackId = Convert.ToInt32(dgvFeedback.SelectedRows[0].Cells["ID"].Value);
        string response = txtResponse.Text.Trim();

        string query = "UPDATE Feedback SET ResponseText = @response WHERE FeedbackId = @id";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@response", response);
        cmd.Parameters.AddWithValue("@id", feedbackId);

        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

        MessageBox.Show("Response submitted successfully.");
        txtResponse.Clear();
        LoadFeedback(); // Refresh the grid
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


        private void button2_Click(object sender, EventArgs e)
        {
          Close();

        }
    }
}
