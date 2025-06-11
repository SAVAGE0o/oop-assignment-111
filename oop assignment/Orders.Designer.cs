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
            this.label1 = new System.Windows.Forms.Label();
            this.runOrderList = new System.Windows.Forms.ListBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.returnButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.refundList = new System.Windows.Forms.ListBox();
            this.cancelReasonText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Running Orders (Click for Cancelling & Refund)";
            // 
            // runOrderList
            // 
            this.runOrderList.FormattingEnabled = true;
            this.runOrderList.ItemHeight = 20;
            this.runOrderList.Location = new System.Drawing.Point(62, 122);
            this.runOrderList.Name = "runOrderList";
            this.runOrderList.Size = new System.Drawing.Size(325, 184);
            this.runOrderList.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(62, 421);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(108, 44);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Confirm";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(679, 421);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(108, 44);
            this.returnButton.TabIndex = 10;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Refund Status";
            // 
            // refundList
            // 
            this.refundList.FormattingEnabled = true;
            this.refundList.ItemHeight = 20;
            this.refundList.Location = new System.Drawing.Point(462, 122);
            this.refundList.Name = "refundList";
            this.refundList.Size = new System.Drawing.Size(423, 184);
            this.refundList.TabIndex = 12;
            // 
            // cancelReasonText
            // 
            this.cancelReasonText.Location = new System.Drawing.Point(62, 344);
            this.cancelReasonText.Name = "cancelReasonText";
            this.cancelReasonText.Size = new System.Drawing.Size(325, 71);
            this.cancelReasonText.TabIndex = 13;
            this.cancelReasonText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Reason";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cancelReasonText);
            this.Controls.Add(this.refundList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.runOrderList);
            this.Controls.Add(this.label1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox runOrderList;
        private System.Windows.Forms.Button cancelButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox refundList;
        private System.Windows.Forms.RichTextBox cancelReasonText;
        private System.Windows.Forms.Label label3;
    }
}