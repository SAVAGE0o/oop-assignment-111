namespace oop_assignment
{
    partial class FormManagerRefundRQ
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
            this.dgvRefunds = new System.Windows.Forms.DataGridView();
            this.rdoApprove = new System.Windows.Forms.RadioButton();
            this.rdoReject = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefunds)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRefunds
            // 
            this.dgvRefunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefunds.Location = new System.Drawing.Point(209, 45);
            this.dgvRefunds.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRefunds.Name = "dgvRefunds";
            this.dgvRefunds.RowTemplate.Height = 24;
            this.dgvRefunds.Size = new System.Drawing.Size(276, 162);
            this.dgvRefunds.TabIndex = 0;
            this.dgvRefunds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rdoApprove
            // 
            this.rdoApprove.AutoSize = true;
            this.rdoApprove.Location = new System.Drawing.Point(218, 211);
            this.rdoApprove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoApprove.Name = "rdoApprove";
            this.rdoApprove.Size = new System.Drawing.Size(65, 17);
            this.rdoApprove.TabIndex = 1;
            this.rdoApprove.TabStop = true;
            this.rdoApprove.Text = "Approve";
            this.rdoApprove.UseVisualStyleBackColor = true;
            // 
            // rdoReject
            // 
            this.rdoReject.AutoSize = true;
            this.rdoReject.Location = new System.Drawing.Point(218, 246);
            this.rdoReject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoReject.Name = "rdoReject";
            this.rdoReject.Size = new System.Drawing.Size(56, 17);
            this.rdoReject.TabIndex = 2;
            this.rdoReject.TabStop = true;
            this.rdoReject.Text = "Reject";
            this.rdoReject.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(312, 264);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 28);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(542, 339);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormManagerRefundRQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdoReject);
            this.Controls.Add(this.rdoApprove);
            this.Controls.Add(this.dgvRefunds);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormManagerRefundRQ";
            this.Text = "Refund Request";
            this.Load += new System.EventHandler(this.FormManagerRefundRQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefunds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRefunds;
        private System.Windows.Forms.RadioButton rdoApprove;
        private System.Windows.Forms.RadioButton rdoReject;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button1;
    }
}