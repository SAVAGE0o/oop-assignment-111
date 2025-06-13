using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using static oop_assignment.OrderManager;

namespace oop_assignment
{
    public partial class customerOrders : Form
    {
        OrderCancellationManager cancellationManager = new OrderCancellationManager();
        OrderManager orderManager = new OrderManager();
        int userId = CurrentSession.UserId;



        public customerOrders()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Orders_Load);
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            LoadRunningOrders();
            LoadRefundStatus();
        }

        private void LoadRunningOrders()
        {
            runOrderList.Items.Clear();
            var orders = orderManager.GetOrdersByUser(userId);

            foreach (var order in orders)
            {
                if (order.Status.Trim().Equals("In Progress", StringComparison.OrdinalIgnoreCase))
                {
                    runOrderList.Items.Add(order);
                }
            }
        }

        private void LoadRefundStatus()
        {
            refundList.Items.Clear();
            var statuses = cancellationManager.GetRefundStatus(userId);
            foreach (var status in statuses)
            {
                refundList.Items.Add(status);
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            new FormCustomerDashboard().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (runOrderList.SelectedItem is OrderInfo selectedOrder)
            {
                string reason = cancelReasonText.Text.Trim();

                if (string.IsNullOrWhiteSpace(reason))
                {
                    MessageBox.Show("Please enter a reason for cancellation.");
                    return;
                }

                bool success = cancellationManager.CancelOrder(selectedOrder.OrderId, userId, reason);

                if (success)
                {
                    MessageBox.Show("Order cancelled and refund requested.");
                    LoadRunningOrders();
                    LoadRefundStatus();
                    cancelReasonText.Clear();
                }
                else
                {
                    MessageBox.Show("Unable to cancel. Order may already be completed.");
                }
            }
            else
            {
                MessageBox.Show("Please select an order to cancel.");
            }
        }
    }
}