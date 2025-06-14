using System;

namespace oop_assignment
{
    partial class EwalletTopUP
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.btnTopUp = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.lbCI = new System.Windows.Forms.Label();
            this.lbAm = new System.Windows.Forms.Label();
            this.lbCb = new System.Windows.Forms.Label();
            this.btnreturn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(429, 155);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(167, 22);
            this.txtCustomerId.TabIndex = 0;
            this.txtCustomerId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(429, 208);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(167, 22);
            this.txtAmount.TabIndex = 1;
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Location = new System.Drawing.Point(277, 41);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(0, 16);
            this.lblCurrentBalance.TabIndex = 2;
            this.lblCurrentBalance.Click += new System.EventHandler(this.lblCurrentBalance_Click);
            // 
            // btnTopUp
            // 
            this.btnTopUp.Location = new System.Drawing.Point(443, 285);
            this.btnTopUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTopUp.Name = "btnTopUp";
            this.btnTopUp.Size = new System.Drawing.Size(112, 59);
            this.btnTopUp.TabIndex = 3;
            this.btnTopUp.Text = "Top Up";
            this.btnTopUp.UseVisualStyleBackColor = true;
            this.btnTopUp.Click += new System.EventHandler(this.btnTopUp_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.Location = new System.Drawing.Point(300, 285);
            this.btnCheckBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(117, 59);
            this.btnCheckBalance.TabIndex = 4;
            this.btnCheckBalance.Text = "Check balance";
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // lbCI
            // 
            this.lbCI.AutoSize = true;
            this.lbCI.BackColor = System.Drawing.Color.White;
            this.lbCI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCI.Location = new System.Drawing.Point(293, 151);
            this.lbCI.Name = "lbCI";
            this.lbCI.Size = new System.Drawing.Size(124, 25);
            this.lbCI.TabIndex = 5;
            this.lbCI.Text = "CustomerID";
            // 
            // lbAm
            // 
            this.lbAm.AutoSize = true;
            this.lbAm.BackColor = System.Drawing.Color.White;
            this.lbAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAm.Location = new System.Drawing.Point(295, 205);
            this.lbAm.Name = "lbAm";
            this.lbAm.Size = new System.Drawing.Size(85, 25);
            this.lbAm.TabIndex = 6;
            this.lbAm.Text = "Amount";
            this.lbAm.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbCb
            // 
            this.lbCb.AutoSize = true;
            this.lbCb.BackColor = System.Drawing.Color.White;
            this.lbCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCb.Location = new System.Drawing.Point(293, 93);
            this.lbCb.Name = "lbCb";
            this.lbCb.Size = new System.Drawing.Size(179, 25);
            this.lbCb.TabIndex = 7;
            this.lbCb.Text = "Current Balance :\r\n";
            // 
            // btnreturn4
            // 
            this.btnreturn4.Location = new System.Drawing.Point(635, 396);
            this.btnreturn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreturn4.Name = "btnreturn4";
            this.btnreturn4.Size = new System.Drawing.Size(109, 43);
            this.btnreturn4.TabIndex = 8;
            this.btnreturn4.Text = "return";
            this.btnreturn4.UseVisualStyleBackColor = true;
            this.btnreturn4.Click += new System.EventHandler(this.btnreturn4_Click);
            // 
            // EwalletTopUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImage = global::oop_assignment.Properties.Resources.Screenshot_2025_06_12_222624;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.btnreturn4);
            this.Controls.Add(this.lbCb);
            this.Controls.Add(this.lbAm);
            this.Controls.Add(this.lbCI);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnTopUp);
            this.Controls.Add(this.lblCurrentBalance);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtCustomerId);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EwalletTopUP";
            this.Text = "EwalletTopUP";
            this.Load += new System.EventHandler(this.EwalletTopUP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Button btnTopUp;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Label lbCI;
        private System.Windows.Forms.Label lbAm;
        private System.Windows.Forms.Label lbCb;
        private System.Windows.Forms.Button btnreturn4;



    }
}