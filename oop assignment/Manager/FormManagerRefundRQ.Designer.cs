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
            this.btnSubmitRR = new System.Windows.Forms.Button();
            this.btnreturnRR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefunds)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRefunds
            // 
            this.dgvRefunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefunds.Location = new System.Drawing.Point(297, 73);
            this.dgvRefunds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRefunds.Name = "dgvRefunds";
            this.dgvRefunds.RowTemplate.Height = 24;
            this.dgvRefunds.Size = new System.Drawing.Size(461, 212);
            this.dgvRefunds.TabIndex = 0;
            this.dgvRefunds.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rdoApprove
            // 
            this.rdoApprove.AutoSize = true;
            this.rdoApprove.BackColor = System.Drawing.Color.White;
            this.rdoApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoApprove.Location = new System.Drawing.Point(318, 303);
            this.rdoApprove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoApprove.Name = "rdoApprove";
            this.rdoApprove.Size = new System.Drawing.Size(80, 22);
            this.rdoApprove.TabIndex = 1;
            this.rdoApprove.TabStop = true;
            this.rdoApprove.Text = "Approve";
            this.rdoApprove.UseVisualStyleBackColor = false;
            // 
            // rdoReject
            // 
            this.rdoReject.AutoSize = true;
            this.rdoReject.BackColor = System.Drawing.Color.White;
            this.rdoReject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoReject.Location = new System.Drawing.Point(318, 336);
            this.rdoReject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoReject.Name = "rdoReject";
            this.rdoReject.Size = new System.Drawing.Size(68, 22);
            this.rdoReject.TabIndex = 2;
            this.rdoReject.TabStop = true;
            this.rdoReject.Text = "Reject";
            this.rdoReject.UseVisualStyleBackColor = false;
            // 
            // btnSubmitRR
            // 
            this.btnSubmitRR.Location = new System.Drawing.Point(457, 391);
            this.btnSubmitRR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmitRR.Name = "btnSubmitRR";
            this.btnSubmitRR.Size = new System.Drawing.Size(107, 34);
            this.btnSubmitRR.TabIndex = 3;
            this.btnSubmitRR.Text = "Submit";
            this.btnSubmitRR.UseVisualStyleBackColor = true;
            this.btnSubmitRR.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnreturnRR
            // 
            this.btnreturnRR.Location = new System.Drawing.Point(723, 417);
            this.btnreturnRR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreturnRR.Name = "btnreturnRR";
            this.btnreturnRR.Size = new System.Drawing.Size(75, 32);
            this.btnreturnRR.TabIndex = 4;
            this.btnreturnRR.Text = "return";
            this.btnreturnRR.UseVisualStyleBackColor = true;
            this.btnreturnRR.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormManagerRefundRQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImage = global::oop_assignment.Properties.Resources.Screenshot_2025_06_14_224414;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnreturnRR);
            this.Controls.Add(this.btnSubmitRR);
            this.Controls.Add(this.rdoReject);
            this.Controls.Add(this.rdoApprove);
            this.Controls.Add(this.dgvRefunds);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnSubmitRR;
        private System.Windows.Forms.Button btnreturnRR;
    }
}