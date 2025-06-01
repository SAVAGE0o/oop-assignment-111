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
    

    public partial class Menu : Form
    {
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
            Noodles.Name = "Noodles";
            Noodles.Price = 10;
            customerMenuList.Items.Add(Noodles.Name);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            menuItems healthyFood = new menuItems();
            healthyFood.Name = "Salad";
            healthyFood.Price = 8;
            customerMenuList.Items.Add(healthyFood.Name);
            
                
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            menuItems Pizza = new menuItems();
            Pizza.Name = "Pizza";
            Pizza.Price = 25;
            customerMenuList.Items.Add(Pizza.Name);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menuItems Donut = new menuItems();
            Donut.Name = "Donut";
            Donut.Price = 5;
            customerMenuList.Items.Add(Donut.Name);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            menuItems Burger = new menuItems();
            Burger.Name = "Burger";
            Burger.Price = 20;
            customerMenuList.Items.Add(Burger.Name);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            menuItems Rice = new menuItems();
            Rice.Name = "Chicken Rice";
            Rice.Price = 15;
            customerMenuList.Items.Add(Rice.Name);
        }
    }
}
