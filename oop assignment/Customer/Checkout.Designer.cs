﻿namespace oop_assignment
{
    partial class Checkout
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
            this.customerCheckoutList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerPaymentButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.customerBalance = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.customerTotalPayment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // customerCheckoutList
            // 
            this.customerCheckoutList.BackColor = System.Drawing.SystemColors.HighlightText;
            this.customerCheckoutList.FormattingEnabled = true;
            this.customerCheckoutList.ItemHeight = 20;
            this.customerCheckoutList.Location = new System.Drawing.Point(274, 120);
            this.customerCheckoutList.Name = "customerCheckoutList";
            this.customerCheckoutList.Size = new System.Drawing.Size(357, 164);
            this.customerCheckoutList.TabIndex = 0;
            this.customerCheckoutList.SelectedIndexChanged += new System.EventHandler(this.customerCheckoutList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.label1.Location = new System.Drawing.Point(270, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Order";
            // 
            // customerPaymentButton
            // 
            this.customerPaymentButton.BackColor = System.Drawing.SystemColors.Control;
            this.customerPaymentButton.ForeColor = System.Drawing.Color.DarkRed;
            this.customerPaymentButton.Location = new System.Drawing.Point(274, 391);
            this.customerPaymentButton.Name = "customerPaymentButton";
            this.customerPaymentButton.Size = new System.Drawing.Size(104, 45);
            this.customerPaymentButton.TabIndex = 2;
            this.customerPaymentButton.Text = "Confirm";
            this.customerPaymentButton.UseVisualStyleBackColor = false;
            this.customerPaymentButton.Click += new System.EventHandler(this.customerPaymentButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.label2.Location = new System.Drawing.Point(542, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-wallet balance:";
            // 
            // customerBalance
            // 
            this.customerBalance.Location = new System.Drawing.Point(677, 32);
            this.customerBalance.Name = "customerBalance";
            this.customerBalance.ReadOnly = true;
            this.customerBalance.Size = new System.Drawing.Size(100, 26);
            this.customerBalance.TabIndex = 5;
            this.customerBalance.TextChanged += new System.EventHandler(this.customerBalance_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(663, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.label3.Location = new System.Drawing.Point(282, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total: ";
            // 
            // customerTotalPayment
            // 
            this.customerTotalPayment.Location = new System.Drawing.Point(340, 326);
            this.customerTotalPayment.Name = "customerTotalPayment";
            this.customerTotalPayment.ReadOnly = true;
            this.customerTotalPayment.Size = new System.Drawing.Size(100, 26);
            this.customerTotalPayment.TabIndex = 8;
            this.customerTotalPayment.TextChanged += new System.EventHandler(this.customerTotalPayment_TextChanged);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oop_assignment.Properties.Resources.Screenshot_2025_06_13_100200;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 468);
            this.Controls.Add(this.customerTotalPayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.customerBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerPaymentButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerCheckoutList);
            this.DoubleBuffered = true;
            this.Name = "Checkout";
            this.Text = "h";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox customerCheckoutList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customerPaymentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerBalance;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerTotalPayment;
    }
}