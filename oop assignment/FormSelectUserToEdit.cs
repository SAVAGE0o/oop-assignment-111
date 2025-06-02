using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_assignment
{
    public partial class FormSelectUserToEdit : Form
    {
        public FormSelectUserToEdit()
        {
            InitializeComponent();
        }

        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=MSI;Initial Catalog=C#;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Users", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;
            }
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var row = dgvUsers.SelectedRows[0];
                string id = row.Cells["UserID"].Value.ToString();
                string name = row.Cells["Username"].Value.ToString();
                string email = row.Cells["Email"].Value.ToString();
                string password = row.Cells["Password"].Value.ToString();
                string role = row.Cells["Role"].Value.ToString();
                string wallet = row.Cells["WalletBalance"].Value.ToString();

                new FormEditUser(id, name, email, password, role, wallet).ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}