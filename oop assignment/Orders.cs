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
    public partial class Orders: Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("OrderID", "Order ID");
            dataGridView1.Columns.Add("Item", "Item");
            dataGridView1.Columns.Add("Status", "Status");

            dataGridView1.Rows.Add("101", "Burger", "Pending");
            dataGridView1.Rows.Add("102", "Pizza", "Cooking");
            dataGridView1.Rows.Add("103", "Pasta", "Ready");
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.CurrentRow.Cells["Status"].Value = "Completed";
                MessageBox.Show("Order status updated.");
            }
            else
            {
                MessageBox.Show("Please select an order.");
            }
        }
    }
}
