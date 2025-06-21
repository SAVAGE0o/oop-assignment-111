using System;
using System.Windows.Forms;

namespace oop_assignment
{
    public partial class FormViewSalesReport : Form
    {
        public FormViewSalesReport()
        {
            InitializeComponent();
        }

        private void FormViewSalesReport_Load(object sender, EventArgs e)
        {
            decimal total;
            dgvSales.DataSource = SalesManager.GetAllSales(out total);
            lblTotal.Text = "Total Sales: RM " + total.ToString("F2");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}