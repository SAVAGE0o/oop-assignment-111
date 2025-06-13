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
    public partial class Managersupport : Form
    {
        public Managersupport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EwalletTopUP().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormManagerRefundRQ().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Managersupport_Load(object sender, EventArgs e)
        {

        }
    }
}