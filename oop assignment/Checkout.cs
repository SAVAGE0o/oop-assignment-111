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

        private string[] receivedOrders; // Step 3: Hold the received array

        // Step 4: Create constructor that accepts the array
        public Checkout(string[] orders)
        {
            InitializeComponent();
            receivedOrders = orders;

            
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

        private void Checkout_Load(object sender, EventArgs e)
        {
            // Step 5: Display the items in the ListBox
            foreach (string item in receivedOrders)
            {
                customerCheckoutList.Items.Add(item);
            }
        }
    }
}
