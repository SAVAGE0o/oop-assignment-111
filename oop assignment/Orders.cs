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
using System.Configuration;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Eventing.Reader;

namespace oop_assignment
{
    public partial class Orders: Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            string selectedStatus = cmbStatus.SelectedItem.ToString();

            if (selectedStatus == "All")
            {

                string connectionStringall = "Data Source=desktop-euek254;Initial Catalog=C#;Integrated Security=True";
                string queryall = "SELECT order_id, UserId ,status FROM Orders";

                using (SqlConnection conn = new SqlConnection(connectionStringall))
                {
                    SqlCommand cmd = new SqlCommand(queryall, conn);
                    

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewOrders.DataSource = table;
                }
                
            }

            else {
                string connectionString = "Data Source=desktop-euek254;Initial Catalog=C#;Integrated Security=True";
                string query = "SELECT order_id, UserId ,status FROM Orders WHERE status = @status";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", selectedStatus);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewOrders.DataSource = table;
                }
            }

               
        }


        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["order_id"].Value);
                string newStatus = cmbStatus.SelectedItem.ToString();

                string connectionString = "Data Source=desktop-euek254;Initial Catalog=C#;Integrated Security=True";
                string query = "UPDATE Orders SET status = @status WHERE order_id = @id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@id", orderId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Order status updated successfully.");
                btnViewOrders_Click(null, null); // إعادة تحميل البيانات حسب الحالة
            }
            else
            {
                MessageBox.Show("Please select an order to update.");
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChefDashboard mainMenu = new FormChefDashboard();
            mainMenu.Show();
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT * FROM Orders";
            using (SqlConnection conn = new SqlConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewOrders.DataSource = dt;
            }
    }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrders();

        }
        private void LoadOrders()
       {
        //    string connectionString = "Data Source=desktop-euek254;Initial Catalog=C#;Integrated Security=True";
        //    string selectedStatus = cmbStatus.SelectedItem?.ToString() ?? "All";

        //    string query = "SELECT * FROM Orders";
        //    if (selectedStatus != "All")
        //    {
        //        query += " WHERE status = @status";
        //    }

        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(connectionString))
        //        {
        //            SqlDataAdapter da = new SqlDataAdapter(query, conn);
        //            if (selectedStatus != "All")
        //            {
        //                da.SelectCommand.Parameters.AddWithValue("@status", selectedStatus);
        //            }

        //            DataTable dt = new DataTable();
        //            da.Fill(dt);
        //            dataGridViewOrders.DataSource = dt;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;

            LoadOrders(); 
        }
    }
}
