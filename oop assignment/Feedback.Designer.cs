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
            this.doneOrderList = new System.Windows.Forms.ListBox();
            this.feedbackTextBox = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doneOrderList
            // 
            this.doneOrderList.FormattingEnabled = true;
            this.doneOrderList.ItemHeight = 20;
            this.doneOrderList.Location = new System.Drawing.Point(310, 287);
            this.doneOrderList.Name = "doneOrderList";
            this.doneOrderList.Size = new System.Drawing.Size(231, 144);
            this.doneOrderList.TabIndex = 6;
            this.doneOrderList.SelectedIndexChanged += new System.EventHandler(this.doneOrderList_SelectedIndexChanged);
            // 
            // feedbackTextBox
            // 
            this.feedbackTextBox.Location = new System.Drawing.Point(547, 287);
            this.feedbackTextBox.Name = "feedbackTextBox";
            this.feedbackTextBox.Size = new System.Drawing.Size(241, 83);
            this.feedbackTextBox.TabIndex = 10;
            this.feedbackTextBox.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 35);
            this.button2.TabIndex = 11;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(700, 396);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(78, 35);
            this.returnButton.TabIndex = 12;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.feedbackTextBox);
            this.Controls.Add(this.doneOrderList);
            this.DoubleBuffered = true;
            this.Name = "Feedback";
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox doneOrderList;
        private System.Windows.Forms.RichTextBox feedbackTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button returnButton;
    }
}