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

        public Checkout(List<menuItems> orders)
        {
            InitializeComponent();
            receivedOrders = orders;

            float totalPrice = 0;

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
        
        }
    }
}
