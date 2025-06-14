using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace oop_assignment
{
    public partial class EwalletTopUP : Form
    {
        private EwalletService service; // EwalletService instance to handle ewallet operations
        private string connStr = @"Data Source=CYBORG\SQLEXPRESS;Initial Catalog=C#;Integrated Security=True"; // Connection string to the database

        // Constructor that initializes the form and sets up the EwalletService
        public EwalletTopUP()
        {
            InitializeComponent();
            service = new EwalletService(connStr); // Using the initialized connStr to create the service object
        }

        // Empty method for textBox1 text change event, not being used in the current code
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Empty method for label2 click event, not being used in the current code
        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Empty method for lblCurrentBalance click event, not being used in the current code
        private void lblCurrentBalance_Click(object sender, EventArgs e)
        {

        }

        // This method is triggered when the "Check Balance" button is clicked
        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            string userId = txtCustomerId.Text.Trim(); // Get the UserId entered by the user

            // Check if the UserId is empty and display an error message
            if (string.IsNullOrWhiteSpace(userId))
            {
                MessageBox.Show("Please enter the User ID.");
                return;
            }

            try
            {
                // Call the GetBalance method from the EwalletService class to fetch the balance
                decimal? balance = service.GetBalance(userId);

                // Display the balance if found, else display "User not found"
                lblCurrentBalance.Text = balance.HasValue
                    ? "Current Balance: RM " + balance.Value.ToString("F2")
                    : "User not found.";
            }
            catch (Exception ex)
            {
                // Catch any errors and display the error message
                MessageBox.Show("Error retrieving balance: " + ex.Message);
            }
        }

        // This method is triggered when the "Top Up" button is clicked
        private void btnTopUp_Click(object sender, EventArgs e)
        {
            string userId = txtCustomerId.Text.Trim(); // Get the UserId entered by the user
            decimal amount; // Variable to store the top-up amount

            // Check if the UserId is empty and display an error message
            if (string.IsNullOrWhiteSpace(userId))
            {
                MessageBox.Show("Please enter the User ID.");
                return;
            }

            // Validate if the entered top-up amount is a valid number and greater than 0
            if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid top-up amount.");
                return;
            }

            try
            {
                // Call the TopUp method from the EwalletService class to process the top-up
                service.TopUp(userId, amount);

                // Display success message
                MessageBox.Show("Top-up successful.");

                // Clear the amount text box and refresh the balance by triggering the check balance method
                txtAmount.Clear();
                btnCheckBalance_Click(null, null); // Refresh balance
            }
            catch (Exception ex)
            {
                // Catch any errors during the top-up process and display the error message
                MessageBox.Show("Error processing top-up: " + ex.Message);
            }
        }

        // This method is triggered when the form is loaded
        private void EwalletTopUP_Load(object sender, EventArgs e)
        {
            lblCurrentBalance.Text = ""; // Clear the current balance label when the form loads
        }

        private void btnreturn4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
