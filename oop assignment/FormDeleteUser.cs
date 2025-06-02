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
                var userID = dgvUsers.SelectedRows[0].Cells["UserID"].Value.ToString();

                {
         

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        string connStr = "Data Source=MSI;Initial Catalog=SedapMakanDB;Integrated Security=True";
                        using (SqlConnection conn = new SqlConnection(connStr))
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserID = @UserID", conn);
                            cmd.Parameters.AddWithValue("@UserID", userID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User deleted successfully.");
                                btnLoad.PerformClick(); // reload users
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
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=MSI;Initial Catalog=SedapMakanDB;Integrated Security=True";
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
    }
}
