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
        private SqlConnection conn = new SqlConnection(@"Data Source=CYBORG\SQLEXPRESS;Initial Catalog=C#;Integrated Security=True");

        public EwalletTopUP()
        {
            InitializeComponent();
        }
        private void TopUpForm_Load(object sender, EventArgs e)
        {
            lblCurrentBalance.Text = "";
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

        private void EwalletTopUP_Load(object sender, EventArgs e)
        {
            {
                string customerId = txtCustomerId.Text.Trim();
                decimal amount;

                if (string.IsNullOrWhiteSpace(customerId))
                {
                    MessageBox.Show("Please enter the Customer ID.");
                    return;
                }

                if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
                {
                    MessageBox.Show("Please enter a valid top-up amount.");
                    return;
                }

                try
                {
                    // Update Users.WalletBalance
                    string updateQuery = "UPDATE Users SET WalletBalance = WalletBalance + @amount WHERE UserId = @userId";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@amount", amount);
                    updateCmd.Parameters.AddWithValue("@userId", customerId);

                    // Insert into WalletTransactions
                    string insertQuery = "INSERT INTO WalletTransactions (UserId, Amount, Type, TransactionDate) VALUES (@userId, @amount, 'TopUp', GETDATE())";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@userId", customerId);
                    insertCmd.Parameters.AddWithValue("@amount", amount);

                    conn.Open();
                    updateCmd.ExecuteNonQuery();
                    insertCmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Top-up successful.");
                    txtAmount.Clear();
                    btnCheckBalance_Click(null, null); // Refresh balance
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing top-up: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }

            

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
         
            string customerId = txtCustomerId.Text.Trim();

            if (string.IsNullOrWhiteSpace(customerId))
            {
                MessageBox.Show("Please enter the Customer ID.");
                return;
            }

            try
            {
                string query = "SELECT WalletBalance FROM Users WHERE UserId = @userId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", customerId);

                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();

                if (result != null)
                {
                    lblCurrentBalance.Text = "Current Balance: RM " + Convert.ToDecimal(result).ToString("F2");
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                    lblCurrentBalance.Text = "Current Balance: N/A";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving balance: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
    
}
