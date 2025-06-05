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
    public partial class FormCustomerDashboard: Form
    {
        public FormCustomerDashboard()
        {
            InitializeComponent();
        }

        private void customerMenuButton_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
                
        }

        private void customerLogoutButton_Click(object sender, EventArgs e)
        {
            Form FormLogin = new FormLogin();
            FormLogin.Show();
        }

        private void customerSupportButton_Click(object sender, EventArgs e)
        {
            new Orders().Show();
            this.Hide();
        }
    }
}
