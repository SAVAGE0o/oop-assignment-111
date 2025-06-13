using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class FormCustomerDashboard : Form
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

            this.Hide();
        }

        private void customerSupportButton_Click(object sender, EventArgs e)
        {
            new customerOrders().Show();
            this.Hide();
        }

        private void customerFeedbackButton_Click(object sender, EventArgs e)
        {
            new Feedback().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormCustomerDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}