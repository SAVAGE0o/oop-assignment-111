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
       
       
        
        public List<menuItems> orderlist = new List<menuItems>();
        public Menu()
        {
            InitializeComponent();
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

            if (Noodles.IsAvailable("Noodles"))
            {
                Noodles.Name = "Noodles";
                Noodles.Price = Noodles.GetPrice("Noodles");

                customerMenuList.Items.Add(Noodles.Name);
                orderlist.Add(Noodles);
            }
            else
            {
                MessageBox.Show("Sorry, Noodles is not available at the moment.");
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            menuItems healthyfood = new menuItems();

            if (healthyfood.IsAvailable("Salad"))
            {
                healthyfood.Name = "Salad";
                healthyfood.Price = healthyfood.GetPrice("Salad");

                customerMenuList.Items.Add(healthyfood.Name);
                orderlist.Add(healthyfood);
            }
            else
            {
                MessageBox.Show("Sorry, Salad is not available at the moment.");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            menuItems Pizza = new menuItems();

            if (Pizza.IsAvailable("Pizza"))
            {
                Pizza.Name = "Pizza";
                Pizza.Price = Pizza.GetPrice("Pizza");

                customerMenuList.Items.Add(Pizza.Name);
                orderlist.Add(Pizza);
            }
            else
            {
                MessageBox.Show("Sorry, Pizza is not available at the moment.");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            menuItems Donut = new menuItems();

            if (Donut.IsAvailable("Donut"))
            {
                Donut.Name = "Donut";
                Donut.Price = Donut.GetPrice("Donut");

                customerMenuList.Items.Add(Donut.Name);
                orderlist.Add(Donut);
            }
            else
            {
                MessageBox.Show("Sorry, Donut is not available at the moment.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            menuItems Burger = new menuItems();

            if (Burger.IsAvailable("Burger"))
            {
                Burger.Name = "Burger";
                Burger.Price = Burger.GetPrice("Burger");

                customerMenuList.Items.Add(Burger.Name);
                orderlist.Add(Burger);
            }
            else
            {
                MessageBox.Show("Sorry, Burger is not available at the moment.");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            menuItems Rice = new menuItems();

            if (Rice.IsAvailable("Chicken Rice"))
            {
                Rice.Name = "Chicken Rice";
                Rice.Price = Rice.GetPrice("Chicken Rice");

                customerMenuList.Items.Add(Rice.Name);
                orderlist.Add(Rice);
            }
            else
            {
                MessageBox.Show("Sorry, Chicken Rice is not available at the moment.");
            }
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

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
