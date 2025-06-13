using System;
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
    public partial class EwalletTopUP : Form
    {
        private EwalletService service;
        private string connStr = @"Data Source=Abofares;Initial Catalog=C#;Integrated Security=True"; // Fixed initialization

        public EwalletTopUP()
        {
            InitializeComponent();
            service = new EwalletService(connStr); // Using the initialized connStr
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrentBalance_Click(object sender, EventArgs e)
        {

        }





        private void btnCheckBalance_Click(object sender, EventArgs e)
        {

            string userId = txtCustomerId.Text.Trim();

            if (string.IsNullOrWhiteSpace(userId))
            {
                MessageBox.Show("Please enter the User ID.");
                return;
            }

            try
            {
                decimal? balance = service.GetBalance(userId);
                lblCurrentBalance.Text = balance.HasValue
                    ? "Current Balance: RM " + balance.Value.ToString("F2")
                    : "User not found.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving balance: " + ex.Message);
            }

        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            string userId = txtCustomerId.Text.Trim();
            decimal amount;

            if (string.IsNullOrWhiteSpace(userId))
            {
                MessageBox.Show("Please enter the User ID.");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid top-up amount.");
                return;
            }

            try
            {
                service.TopUp(userId, amount);
                MessageBox.Show("Top-up successful.");
                txtAmount.Clear();
                btnCheckBalance_Click(null, null); // Refresh balance
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing top-up: " + ex.Message);
            }
        }

        private void EwalletTopUP_Load(object sender, EventArgs e)
        {
            lblCurrentBalance.Text = "";
        }
    }
}
// ✅ SERVICE CLASS (handles DB logic)
public class EwalletService
{
    private readonly string connStr;

    public EwalletService(string connectionString)
    {
        connStr = connectionString;
    }

    public decimal? GetBalance(string userId)
    {
        using (var conn = new SqlConnection(connStr))
        {
            string query = "SELECT WalletBalance FROM Users WHERE UserId = @uid";
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@uid", userId);
                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();

                if (result != null && decimal.TryParse(result.ToString(), out decimal balance))
                    return balance;
                else
                    return null;
            }
        }
    }

    public void TopUp(string userId, decimal amount)
    {
        using (var conn = new SqlConnection(connStr))
        {
            conn.Open();

            string updateQuery = "UPDATE Users SET WalletBalance = WalletBalance + @amount WHERE UserId = @uid";
            using (var updateCmd = new SqlCommand(updateQuery, conn))
            {
                updateCmd.Parameters.AddWithValue("@amount", amount);
                updateCmd.Parameters.AddWithValue("@uid", userId);
                updateCmd.ExecuteNonQuery();
            }

            string insertQuery = "INSERT INTO WalletTransactions (UserId, Amount, Type, TransactionDate) VALUES (@uid, @amount, 'TopUp', GETDATE())";
            using (var insertCmd = new SqlCommand(insertQuery, conn))
            {
                insertCmd.Parameters.AddWithValue("@uid", userId);
                insertCmd.Parameters.AddWithValue("@amount", amount);
                insertCmd.ExecuteNonQuery();
            }

            conn.Close();
        }
    }
}