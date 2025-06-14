namespace oop_assignment
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.buttonGoback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Font = new System.Drawing.Font("Cooper Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.Location = new System.Drawing.Point(77, 230);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(157, 39);
            this.btnViewOrders.TabIndex = 0;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.btnUpdateStatus.Location = new System.Drawing.Point(77, 290);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(157, 42);
            this.btnUpdateStatus.TabIndex = 1;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(397, 177);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowHeadersWidth = 62;
            this.dataGridViewOrders.RowTemplate.Height = 28;
            this.dataGridViewOrders.Size = new System.Drawing.Size(563, 312);
            this.dataGridViewOrders.TabIndex = 2;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "All",
            "In Progress",
            "Completed",
            "Cancelled"});
            this.cmbStatus.Location = new System.Drawing.Point(248, 191);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(143, 27);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // buttonGoback
            // 
            this.buttonGoback.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.buttonGoback.Location = new System.Drawing.Point(3, 476);
            this.buttonGoback.Name = "buttonGoback";
            this.buttonGoback.Size = new System.Drawing.Size(127, 29);
            this.buttonGoback.TabIndex = 4;
            this.buttonGoback.Text = "Go back";
            this.buttonGoback.UseVisualStyleBackColor = true;
            this.buttonGoback.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.label1.Location = new System.Drawing.Point(77, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select status :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonGoback);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.dataGridViewOrders);
            this.panel1.Controls.Add(this.btnUpdateStatus);
            this.panel1.Controls.Add(this.btnViewOrders);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 536);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 534);
            this.Controls.Add(this.panel1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button buttonGoback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}