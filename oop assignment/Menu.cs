using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace oop_assignment
{
    

    public partial class Menu : Form
    {
        string connectionString = "Data Source=AboFares;Initial Catalog=SedapMakanDB;Integrated Security=True";

       
        
        public List<menuItems> orderlist = new List<menuItems>();
        public Menu()
        {
            InitializeComponent();
        }

        private bool IsItemAvailable(string itemName)
        {
            bool available = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT availability FROM Menu WHERE item_name = @itemName";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@itemName", itemName);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    conn.Close();

                    if (result == "No")
                    {
                        MessageBox.Show($"'{itemName}' was not found in the Menu table.");
                    }
                    else if (result.ToString().ToLower() == "yes")
                    {
                        available = true;
                    }
                }
            }
            catch 
            {
               
            }

            return available;
        }

        private void HandleItemClick(string itemName)
        {
            if (IsItemAvailable(itemName))
            {
                customerMenuList.Items.Add(itemName);
            }
            else
            {
                MessageBox.Show(itemName + " is currently not available.");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customerMenuBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            menuItems Noodles = new menuItems();
            Noodles.Name = "Noodles";
            Noodles.Price = 10;
            customerMenuList.Items.Add(Noodles.Name);
            orderlist.Add(Noodles);
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            menuItems healthyFood = new menuItems();
            healthyFood.Name = "Salad";
            healthyFood.Price = 8;
            customerMenuList.Items.Add(healthyFood.Name);
            orderlist.Add(healthyFood);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            HandleItemClick("Pizza");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HandleItemClick("Donut");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            menuItems Burger = new menuItems();
            Burger.Name = "Burger";
            Burger.Price = 20;
            customerMenuList.Items.Add(Burger.Name);
            orderlist.Add(Burger);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            menuItems Rice = new menuItems();
            Rice.Name = "Chicken Rice";
            Rice.Price = 15;
            customerMenuList.Items.Add(Rice.Name);
            orderlist.Add(Rice);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Checkout checkoutForm = new Checkout(orderlist);
            checkoutForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }
    }
}
