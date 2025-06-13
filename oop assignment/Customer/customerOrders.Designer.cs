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
            this.SuspendLayout();
            // 
            // runOrderList
            // 
            this.runOrderList.FormattingEnabled = true;
            this.runOrderList.ItemHeight = 16;
            this.runOrderList.Location = new System.Drawing.Point(300, 52);
            this.runOrderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runOrderList.Name = "runOrderList";
            this.runOrderList.Size = new System.Drawing.Size(213, 132);
            this.runOrderList.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(300, 337);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 35);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Confirm";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(644, 337);
            this.returnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(96, 35);
            this.returnButton.TabIndex = 10;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // refundList
            // 
            this.refundList.FormattingEnabled = true;
            this.refundList.ItemHeight = 16;
            this.refundList.Location = new System.Drawing.Point(535, 52);
            this.refundList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refundList.Name = "refundList";
            this.refundList.Size = new System.Drawing.Size(214, 132);
            this.refundList.TabIndex = 12;
            // 
            // cancelReasonText
            // 
            this.cancelReasonText.Location = new System.Drawing.Point(310, 227);
            this.cancelReasonText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelReasonText.Name = "cancelReasonText";
            this.cancelReasonText.Size = new System.Drawing.Size(289, 58);
            this.cancelReasonText.TabIndex = 13;
            this.cancelReasonText.Text = "";
            // 
            // customerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 382);
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

        }

        #endregion
        private System.Windows.Forms.ListBox runOrderList;
        private System.Windows.Forms.Button cancelButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.ListBox refundList;
        private System.Windows.Forms.RichTextBox cancelReasonText;
    }
}