namespace oop_assignment
{
    partial class FormViewEWalletTopUp
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvWallets;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewEWalletTopUp));
            this.dgvWallets = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWallets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWallets
            // 
            this.dgvWallets.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.dgvWallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWallets.GridColor = System.Drawing.Color.DarkOrange;
            this.dgvWallets.Location = new System.Drawing.Point(259, 126);
            this.dgvWallets.Name = "dgvWallets";
            this.dgvWallets.RowHeadersWidth = 51;
            this.dgvWallets.Size = new System.Drawing.Size(390, 223);
            this.dgvWallets.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClose.Location = new System.Drawing.Point(468, 86);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Return";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormViewEWalletTopUp
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 361);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvWallets);
            this.Name = "FormViewEWalletTopUp";
            this.Text = "E-Wallet Transactions Report";
            this.Load += new System.EventHandler(this.FormViewEwalletTopUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWallets)).EndInit();
            this.ResumeLayout(false);

        }
    }
}