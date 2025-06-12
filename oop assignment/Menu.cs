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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Checkout checkoutForm = new Checkout(orderlist);
            checkoutForm.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            new FormCustomerDashboard().Show();
            this.Hide();
        }
        private void LoadAvailableMenuItems()
        {
            menuItems menu = new menuItems();
            List<menuItems> items = menu.GetAvailableItems();

            menuList.Items.Clear();
            foreach (var item in items)
            {
                menuList.Items.Add($"{item.Name} - RM {item.Price}");
            }
        }
        private void Menu_Load(object sender, EventArgs e)
        {
         
            LoadAvailableMenuItems();
   
    }
        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuList.SelectedItem != null)
            {
                string selected = menuList.SelectedItem.ToString();

               
                string[] parts = selected.Split(new string[] { " - RM " }, StringSplitOptions.None);

                if (parts.Length == 2)
                {
                    string itemName = parts[0];
                    int price = int.Parse(parts[1]);

                   
                    menuItems item = new menuItems
                    {
                        Name = itemName,
                        Price = price
                    };

                   
                    orderlist.Add(item);

                  
                    customerMenuList.Items.Add($"{item.Name} - RM {item.Price}");
                }
            }
        }

    }
}
