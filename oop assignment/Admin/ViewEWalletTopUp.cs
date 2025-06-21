using System;
using System.Windows.Forms;

namespace oop_assignment
{
    public partial class FormViewEWalletTopUp : Form
    {
        public FormViewEWalletTopUp()
        {
            InitializeComponent();
        }

        private void FormViewEwalletTopUp_Load(object sender, EventArgs e)
        {
            dgvWallets.DataSource = WalletTransactionManager.GetAllTransactions();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}