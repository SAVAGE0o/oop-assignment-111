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
        public FormManagerDashboard(string managerId)
        {
            InitializeComponent();
            this.managerId = managerId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form4(managerId).ShowDialog();
        }

    }
}
