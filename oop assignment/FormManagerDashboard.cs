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
    public partial class FormManagerDashboard: Form
    {
        public FormManagerDashboard()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chef Profile: John Doe\nExperience: 5 years\nSpecialty: Italian Cuisine");

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.SelectedItem != null)
            {
                string selected = listBoxMenu.SelectedItem.ToString();
                listBoxMenu.Items.Remove(selected);
                MessageBox.Show("Item removed: " + selected);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.SelectedIndex >= 0)
            {
                string updatedItem = "Updated Item";
                listBoxMenu.Items[listBoxMenu.SelectedIndex] = updatedItem;
                MessageBox.Show("Item updated.");
            }
            else
            {
                MessageBox.Show("Please select an item to edit.");
            }
        }
    }
}
