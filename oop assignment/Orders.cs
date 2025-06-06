using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_assignment
{
    public partial class Orders : Form
    {

        OrderCancellationManager cancellationManager = new OrderCancellationManager();
        OrderManager orderManager = new OrderManager();
        int userId = CurrentSession.UserId;

        public Orders()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Orders_Load); 
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            LoadRunningOrders(); // method to load orders
            LoadRefundStatus(); // method to load refund status
        }


       

        private void returnButton_Click(object sender, EventArgs e)
        {
            new FormCustomerDashboard().Show();
            this.Hide();
        }

        private List<OrderInfo> currentOrders;

        private void LoadRunningOrders()
        {
            runOrderList.Items.Clear();
            currentOrders = orderManager.GetOrdersByUser(userId);

            foreach (var order in currentOrders)
            {
                if (order.Status == "In Progress")
                    runOrderList.Items.Add(order); // ToString() will be used
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (runOrderList.SelectedIndex >= 0)
            {
                OrderInfo selectedOrder = currentOrders[runOrderList.SelectedIndex];
                bool success = cancellationManager.CancelOrder(selectedOrder.OrderId, userId);

                if (success)
                {
                    MessageBox.Show("Order cancelled and refund requested.");

                    // Refresh the running orders list
                    LoadRunningOrders();

                    // Immediately show updated refund status
                    LoadRefundStatus();
                }
                else
                {
                    MessageBox.Show("Unable to cancel. Order may already be completed.");
                }
            }

        }


    }
}

