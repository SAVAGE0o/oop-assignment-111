// ──────────────────────────────────────────────────────────────────────────────
//  FormManageMenu.cs   (code‑behind)
// ──────────────────────────────────────────────────────────────────────────────
using System;
using System.Windows.Forms;

namespace oop_assignment
{
    public partial class FormManageMenu : Form
    {
        public FormManageMenu()
        {
            InitializeComponent();
            LoadMenu();          // demo data only – replace with DB call
        }

        private void LoadMenu()
        {
            dgvMenu.Rows.Clear();
            dgvMenu.Rows.Add("M001", "Nasi Lemak", 5.00m);
            dgvMenu.Rows.Add("M002", "Mee Goreng", 6.50m);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // TODO: open Add‑Item dialog, then refresh
            MessageBox.Show("Add new menu item");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow == null) return;
            MessageBox.Show($"Edit menu item: {dgvMenu.CurrentRow.Cells[1].Value}");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow == null) return;
            var name = dgvMenu.CurrentRow.Cells[1].Value;
            if (MessageBox.Show($"Delete '{name}'?", "Confirm",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvMenu.Rows.Remove(dgvMenu.CurrentRow);
            }
        }
    }
}
