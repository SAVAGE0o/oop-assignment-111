using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;
using oop_assignment.Models;



namespace oop_assignment
{
    public partial class FormManagerDashboard : Form
    {
        private Button btnAddItem;
        private TextBox txtPrice;
        DataTable menuTable;



        public FormManagerDashboard()
        {
            InitializeComponent();



            menuTable = new DataTable();
            menuTable.Columns.Add("ItemName", typeof(string));
            menuTable.Columns.Add("Price", typeof(decimal));
            menuTable.Columns.Add("Available", typeof(bool));

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = menuTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string itemName = itemname.Text.Trim();
            if (string.IsNullOrWhiteSpace(itemName))
            {
                MessageBox.Show("Please enter an item name.");
                return;
            }

            if (decimal.TryParse(numericUpDownPrice.Text, out decimal price))
            {
                // Success - 'price' contains the valid decimal value
                // Use it for database operations or calculations
            }
            else
            {
                // Show error message if conversion fails
                MessageBox.Show("Please enter a valid numeric price",
                              "Invalid Input",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return; // Exit the method or function
            }

            bool available = chkAvailable.Checked;

            string connectionString = "Data Source=desktop-euek254;Initial Catalog=C#;Integrated Security=True";

            string query = "INSERT INTO Menu (item_name, price, availability) VALUES (@name, @price, @available)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", itemName);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@available", available);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadMenuItems();

            MessageBox.Show("Item added successfully.");

            MenuItem item = new MenuItem
            {
                ItemName = txtItemName.Text.Trim(),
                Price = decimal.Parse(numericUpDownPrice.Text),
                Available = chkAvailable.Checked
            };
        }





        private void btnToggleAvailability_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                bool currentStatus = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells["Available"].Value);

                string query = "UPDATE Menu SET Available = @available WHERE Id = @id";
                using (SqlConnection conn = new SqlConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@available", !currentStatus);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadMenuItems();

                }
            }
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChefDashboard mainMenu = new FormChefDashboard();
            mainMenu.Show();
        }

        private void chkAvailable_CheckedChanged(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            string price = numericUpDownPrice.Text; 
            bool available = chkAvailable.Checked;

            string connectionString = "Data Source=desktop-euek254;Initial Catalog=C#;Integrated Security=True";
            string query = "INSERT INTO Menu (item_name, price, availability) VALUES (@name, @price, @availability)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", itemName);
                cmd.Parameters.AddWithValue("@price", price);       // ← الآن الرقم صح
                cmd.Parameters.AddWithValue("@availability", available);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Item added successfully.");
            LoadMenuItems();
        }

        private void SearchMenu(string keyword)
        {
            string connectionString = "Data Source=desktop-euek254;Initial Catalog=C#;Integrated Security=True";
            string query = "SELECT * FROM Menu WHERE item_name LIKE @search";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@search", "%" + keyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            SearchMenu(txtItemName.Text);

        }

        int selectedItemId = -1;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                txtItemName.Text = row.Cells["Item Name"].Value.ToString();
                Price.Text = row.Cells["Price"].Value.ToString();
                chkAvailable.Checked = row.Cells["Available"].Value.ToString() == "Yes";  
            }
        }
        private void LoadMenuItems()
        {
            string connectionString = "Data Source=desktop-euek254;Initial Catalog=C#;Integrated Security=True";
            string query = "SELECT * FROM Menu";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dt.Columns.Add("AvailabilityText", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    string rawValue = row["availability"].ToString().Trim();

                    bool isAvailable = rawValue == "1";

                    row["AvailabilityText"] = isAvailable ? "Yes" : "No";
                }



                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Contains("availability"))
                    dataGridView1.Columns["availability"].Visible = false;
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Please select a row to remove.");
            }
        }

        private void ClearInputs()
        {
            txtItemName.Text = "";
            numericUpDownPrice.Text = "";
            chkAvailable.Checked = false;
        }

        private void FormManagerDashboard_Load(object sender, EventArgs e)
        {
            menuTable = new DataTable();
            menuTable.Columns.Add("ItemName", typeof(string));
            menuTable.Columns.Add("Price", typeof(decimal));
            menuTable.Columns.Add("Available", typeof(bool));

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = menuTable;      
        }

        private void InitializeControls()
        {
        }

        private void numPrice_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a row.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtItemName.Text) || string.IsNullOrWhiteSpace(numericUpDownPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(numericUpDownPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price.");
                return;
            }

            DataGridViewRow selectedRow = dataGridView1.CurrentRow;

            if (selectedRow.Cells["item_name"] == null || selectedRow.Cells["Price"] == null || selectedRow.Cells["availability"] == null)
            {
                MessageBox.Show("One or more columns are missing in the DataGridView.");
                return;
            }

            selectedRow.Cells["item_name"].Value = txtItemName.Text;
            selectedRow.Cells["Price"].Value = price;
            selectedRow.Cells["availability"].Value = chkAvailable.Checked;
        }
    }
}
