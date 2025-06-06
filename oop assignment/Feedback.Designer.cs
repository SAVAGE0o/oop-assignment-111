namespace oop_assignment
{
    partial class Feedback
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
            this.label3 = new System.Windows.Forms.Label();
            this.doneOrderList = new System.Windows.Forms.ListBox();
            this.feedbackTextBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Completed Orders (Click for Feedback)";
            // 
            // doneOrderList
            // 
            this.doneOrderList.FormattingEnabled = true;
            this.doneOrderList.ItemHeight = 20;
            this.doneOrderList.Location = new System.Drawing.Point(59, 97);
            this.doneOrderList.Name = "doneOrderList";
            this.doneOrderList.Size = new System.Drawing.Size(332, 184);
            this.doneOrderList.TabIndex = 6;
            // 
            // feedbackTextBox
            // 
            this.feedbackTextBox.Location = new System.Drawing.Point(433, 97);
            this.feedbackTextBox.Name = "feedbackTextBox";
            this.feedbackTextBox.Size = new System.Drawing.Size(326, 112);
            this.feedbackTextBox.TabIndex = 10;
            this.feedbackTextBox.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(651, 376);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(108, 44);
            this.returnButton.TabIndex = 12;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.feedbackTextBox);
            this.Controls.Add(this.doneOrderList);
            this.Controls.Add(this.label3);
            this.Name = "Feedback";
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox doneOrderList;
        private System.Windows.Forms.RichTextBox feedbackTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button returnButton;
    }
}