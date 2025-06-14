// File: FormDeleteUser.cs
using System;
using System.ComponentModel;   // For BindingList
using System.Windows.Forms;    // UI controls

namespace oop_assignment
{
    public partial class FormDeleteUser : Form
    {
        public FormDeleteUser() => InitializeComponent();

        // ---------------- DELETE button ----------------
        private void button2_Click(object sender, EventArgs e)
        {
            // Must select a row first
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            int userId = Convert.ToInt32(
                dgvUsers.SelectedRows[0].Cells["UserID"].Value);

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm", MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes) return;

            // Use the DeleteUser service class
            bool success = new DeleteUser(userId).Execute();

            MessageBox.Show(success
                ? "User deleted successfully."
                : "No user deleted. Check UserID.");

            if (success) btnLoad.PerformClick(); // refresh grid
        }

        // ---------------- LOAD button ----------------
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                var users = UserManager.GetAllUsers(); // List<User>
                dgvUsers.DataSource = new BindingList<User>(users);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        // ---------------- CANCEL button ----------------
        private void btnCancel_Click(object sender, EventArgs e) => Close();

        // Optional: auto‑load on startup
        private void FormDeleteUser_Load(object sender, EventArgs e)
        {
            // btnLoad.PerformClick(); // Uncomment if you want auto‑load
        }
    }
}
