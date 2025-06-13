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
    public partial class FormAdminDashboard: Form
    {
        public FormAdminDashboard()
        {
            InitializeComponent();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            new FormViewUsers().ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            new FormAddUser().ShowDialog();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            new FormSelectUserToEdit().ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            new FormDeleteUser().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLogin().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
