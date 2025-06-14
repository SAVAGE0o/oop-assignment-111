// File: FormViewUsers.cs
using System;
using System.ComponentModel;   // For BindingList
using System.Windows.Forms;    // WinForms controls

namespace oop_assignment
{
    public partial class FormViewUsers : Form
    {
        public FormViewUsers() => InitializeComponent();

        //LOAD button
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                // Get list through the ViewUsers helper
                var users = new ViewUsers().Execute();   // List<User>
                dgvUsers.DataSource = new BindingList<User>(users);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        // CLOSE button
        private void btnClose_Click(object sender, EventArgs e) => Close();

        // Optional: auto‑load on form open
        private void FormViewUsers_Load(object sender, EventArgs e)
        {
            // btnLoad.PerformClick(); // Uncomment to auto‑load
        }
    }
}
