// File: FormSelectUserToEdit.cs
using System;
using System.ComponentModel;   // BindingList
using System.Windows.Forms;    // WinForms

namespace oop_assignment
{
    public partial class FormSelectUserToEdit : Form
    {
        public FormSelectUserToEdit() => InitializeComponent();

        // LOAD USERS button
        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            try
            {
                var users = new SelectUserToEdit().Execute();   // List<User>
                dgvUsers.DataSource = new BindingList<User>(users);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        // EDIT SELECTED button 
        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit.");
                return;
            }

            var row = dgvUsers.SelectedRows[0];

            // Grab data from the bound columns (property names)
            string id = row.Cells["UserID"].Value.ToString();
            string name = row.Cells["FullName"].Value.ToString();      // property = FullName
            string email = row.Cells["Email"].Value.ToString();
            string pwd = row.Cells["Password"].Value.ToString();
            string role = row.Cells["Role"].Value.ToString();
            string wallet = row.Cells["WalletBalance"].Value.ToString();

            // Open edit form with existing data
            new FormEditUser(id, name, email, pwd, role, wallet).ShowDialog();
        }

        //CANCEL button
        private void btnCancel_Click(object sender, EventArgs e) => Close();

        // Optional: auto‑load on form open
        private void FormSelectUserToEdit_Load(object sender, EventArgs e)
        {
            // btnLoadUsers.PerformClick(); // Uncomment to auto‑load
        }
    }
}
