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
        private string managerId;
          
        public FormManagerDashboard(string managerId)
        {
            InitializeComponent();
            this.managerId = managerId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ManagerFeedBack(managerId).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Managersupport().ShowDialog();
        }
    }
}
