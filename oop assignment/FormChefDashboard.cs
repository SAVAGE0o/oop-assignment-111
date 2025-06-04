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
    public partial class FormChefDashboard: Form
    {
        public FormChefDashboard()
        {
            InitializeComponent();
        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            panelManageMenu.Visible = true;
            panelOrders.Visible = false;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            panelManageMenu.Visible = false;
            panelOrders.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chef Profile: John Doe\nExperience: 5 years\nSpecialty: Italian Cuisine");

        }
    }
}
