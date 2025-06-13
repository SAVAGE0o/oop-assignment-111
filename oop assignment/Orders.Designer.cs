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
            this.runOrderList.ItemHeight = 20;
            this.runOrderList.Location = new System.Drawing.Point(337, 65);
            this.runOrderList.Name = "runOrderList";
            this.runOrderList.Size = new System.Drawing.Size(239, 164);
            this.runOrderList.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(337, 421);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(108, 44);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Confirm";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(724, 421);
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
            this.refundList.Location = new System.Drawing.Point(602, 65);
            this.refundList.Name = "refundList";
            this.refundList.Size = new System.Drawing.Size(240, 164);
            this.refundList.TabIndex = 12;
            // 
            // cancelReasonText
            // 
            this.cancelReasonText.Location = new System.Drawing.Point(349, 284);
            this.cancelReasonText.Name = "cancelReasonText";
            this.cancelReasonText.Size = new System.Drawing.Size(325, 71);
            this.cancelReasonText.TabIndex = 13;
            this.cancelReasonText.Text = "";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oop_assignment.Properties.Resources.Screenshot_2025_06_13_103308;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 477);
            this.Controls.Add(this.cancelReasonText);
            this.Controls.Add(this.refundList);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.runOrderList);
            this.DoubleBuffered = true;
            this.Name = "Orders";
            this.Text = "Orders";
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