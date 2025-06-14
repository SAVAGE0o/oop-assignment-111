using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using oop_assignment.Models;


namespace oop_assignment
{
    public partial class FormChefDashboard : Form
    {
        public FormChefDashboard()
        {
            InitializeComponent();
        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            new ManageMenu().Show();
            this.Hide();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders ordersForm = new Orders();
            ordersForm.Show();


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new ProfileForm().Show();
            this.Hide();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormChefDashboard_Load(object sender, EventArgs e)
        {

        }

        private void FormChefDashboard_Load_1(object sender, EventArgs e)
        {

        }
    }
}