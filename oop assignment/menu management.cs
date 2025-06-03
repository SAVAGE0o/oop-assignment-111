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
    public partial class Menu_Management: Form
    {
        public Menu_Management()
        {
            InitializeComponent();
            this.panelManageMenu = new System.Windows.Forms.Panel();
            this.Controls.Add(this.panelManageMenu);


        }

        private void Menu_Management_Load(object sender, EventArgs e)
        {

        }
    }
}
