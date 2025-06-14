namespace oop_assignment
{
    partial class customerOrders
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
            this.runOrderList = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.returnButton = new System.Windows.Forms.Button();
            this.refundList = new System.Windows.Forms.ListBox();
            this.cancelReasonText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // runOrderList
            // 
            this.runOrderList.FormattingEnabled = true;
            this.runOrderList.ItemHeight = 20;
            this.runOrderList.Location = new System.Drawing.Point(299, 39);
            this.runOrderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runOrderList.Name = "runOrderList";
            this.runOrderList.Size = new System.Drawing.Size(239, 164);
            this.runOrderList.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(560, 130);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(108, 44);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Confirm";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(768, 423);
            this.returnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(108, 44);
            this.returnButton.TabIndex = 10;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // refundList
            // 
            this.refundList.FormattingEnabled = true;
            this.refundList.ItemHeight = 20;
            this.refundList.Location = new System.Drawing.Point(295, 258);
            this.refundList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refundList.Name = "refundList";
            this.refundList.Size = new System.Drawing.Size(586, 144);
            this.refundList.TabIndex = 12;
            // 
            // cancelReasonText
            // 
            this.cancelReasonText.Location = new System.Drawing.Point(560, 39);
            this.cancelReasonText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelReasonText.Name = "cancelReasonText";
            this.cancelReasonText.Size = new System.Drawing.Size(325, 72);
            this.cancelReasonText.TabIndex = 13;
            this.cancelReasonText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Running Orders";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(547, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Reason";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(291, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Refund Status";
            // 
            // customerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oop_assignment.Properties.Resources.Screenshot_2025_06_14_092150;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 478);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelReasonText);
            this.Controls.Add(this.refundList);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.runOrderList);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "customerOrders";
            this.Text = "CustomerOrders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox runOrderList;
        private System.Windows.Forms.Button cancelButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.ListBox refundList;
        private System.Windows.Forms.RichTextBox cancelReasonText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}