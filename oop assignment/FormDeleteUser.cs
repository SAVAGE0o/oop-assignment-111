using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace oop_assignment
{
    public partial class FormDeleteUser : Form
    {
        public FormDeleteUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool success = UserManager.DeleteUser(userId);

                    if (success)
                    {
                        MessageBox.Show("User deleted successfully.");
                        btnLoad.PerformClick(); // Reload users
                    }
                    else
                    {
                        MessageBox.Show("No user deleted. Check UserID.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=Abofares;Initial Catalog=C#;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDeleteUser_Load(object sender, EventArgs e)
        {
            // Optional: auto load users
            // btnLoad.PerformClick();
        }
    }
}
