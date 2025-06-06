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
    public partial class Feedback : Form
    {
        OrderCancellationManager cancellationManager = new OrderCancellationManager();
        OrderManager orderManager = new OrderManager();
        int userId = CurrentSession.UserId;

        private FeedbackManager feedbackManager = new FeedbackManager();

        public Feedback()
        {
            InitializeComponent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            new FormCustomerDashboard().Show();
            this.Hide();
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            LoadRunningOrders(); // method to load orders
        }

        private List<OrderInfo> completedOrders;
        private void LoadRunningOrders()
        {
            doneOrderList.Items.Clear();
            completedOrders = orderManager.GetOrdersByUser(userId);

            foreach (var order in completedOrders)
            {
                if (order.Status == "Completed")
                    doneOrderList.Items.Add(order); // ToString() will be used
            }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {


        
            if (doneOrderList.SelectedIndex >= 0 && !string.IsNullOrWhiteSpace(feedbackTextBox.Text))
            {
                OrderInfo selectedOrder = completedOrders[doneOrderList.SelectedIndex];
                string feedback = feedbackTextBox.Text.Trim();
                int userId = CurrentSession.UserId;

                // Check if feedback already exists
                if (feedbackManager.HasFeedback(userId, selectedOrder.OrderId))
                {
                    MessageBox.Show("You have already submitted feedback for this order.");
                    return;
                }

                feedbackManager.SubmitFeedback(userId, selectedOrder.OrderId, feedback);

                MessageBox.Show("Feedback submitted successfully.");
                feedbackTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please select an order and enter your feedback.");
            }
        }

    }

}


