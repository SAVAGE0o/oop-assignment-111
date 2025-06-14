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
    public partial class FormManagerDashboard : Form
    {
        private string managerId; // Variable to store the manager's ID

        // Constructor that initializes the form and sets the manager's ID
        public FormManagerDashboard(string managerId)
        {
            InitializeComponent(); // Initialize the form's components (UI elements)
            this.managerId = managerId; // Store the manager's ID passed to the constructor
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ManagerFeedBack(managerId).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ProfileForm().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Managersupport().ShowDialog();
        }

        private void FormManagerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}