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
    public partial class Checkout : Form
    {
        private List<menuItems> receivedOrders;
        float totalPrice = 0;

        public Checkout(List<menuItems> orders)
        {
            InitializeComponent();
            receivedOrders = orders;

            // Display the received orders in the ListBox
            foreach (menuItems item in receivedOrders)
            {
                customerCheckoutList.Items.Add(item.Name);
                totalPrice += item.Price;
                customerTotalPayment.Text = totalPrice.ToString() + " RM";
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        public void customerCheckoutList_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void customerTotalPayment_TextChanged(object sender, EventArgs e)
        {

        }

        public void Checkout_Load(object sender, EventArgs e)
        {

            if (CurrentSession.UserId > 0)
            {
                try
                {
                    UserWallet wallet = new UserWallet(CurrentSession.UserId);
                    customerBalance.Text = wallet.Balance.ToString("C"); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading wallet balance: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No user session found. Please login first.");
            }


        }

        private void customerPaymentButton_Click(object sender, EventArgs e)
        {

            try
            {
                // Use UserId directly instead of Username
                UserWallet wallet = new UserWallet(CurrentSession.UserId);
                decimal total = 0;

                foreach (menuItems item in receivedOrders)
                {
                    total += item.Price;
                }
                if (total == 0)
                {
                    MessageBox.Show("No items to checkout.");
                    return;
                }
                if (wallet.Deduct(total))
                {
                    OrderManager orderManager = new OrderManager();
                    foreach (menuItems item in receivedOrders)
                    {
                        int itemId = DBHelper.GetItemIdFromDatabase(item.Name);
                        orderManager.PlaceOrder(wallet.UserId, itemId, 1);
                    }
                    MessageBox.Show("All orders placed and payment successful.");
                    new FormCustomerDashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Insufficient wallet balance.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void customerBalance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}