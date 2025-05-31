namespace oop_assignment
{
    partial class FormCustomerDashboard
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
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerProfile = new System.Windows.Forms.Button();
            this.customerMenuButton = new System.Windows.Forms.Button();
            this.customerSupportButton = new System.Windows.Forms.Button();
            this.customerFeedbackButton = new System.Windows.Forms.Button();
            this.customerLogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(358, 24);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(78, 20);
            this.customerLabel.TabIndex = 0;
            this.customerLabel.Text = "Customer";
            // 
            // customerProfile
            // 
            this.customerProfile.Location = new System.Drawing.Point(35, 45);
            this.customerProfile.Name = "customerProfile";
            this.customerProfile.Size = new System.Drawing.Size(127, 61);
            this.customerProfile.TabIndex = 1;
            this.customerProfile.Text = "Profile";
            this.customerProfile.UseVisualStyleBackColor = true;
            // 
            // customerMenuButton
            // 
            this.customerMenuButton.Location = new System.Drawing.Point(35, 122);
            this.customerMenuButton.Name = "customerMenuButton";
            this.customerMenuButton.Size = new System.Drawing.Size(127, 61);
            this.customerMenuButton.TabIndex = 2;
            this.customerMenuButton.Text = "Menu";
            this.customerMenuButton.UseVisualStyleBackColor = true;
            this.customerMenuButton.Click += new System.EventHandler(this.customerMenuButton_Click);
            // 
            // customerSupportButton
            // 
            this.customerSupportButton.Location = new System.Drawing.Point(35, 210);
            this.customerSupportButton.Name = "customerSupportButton";
            this.customerSupportButton.Size = new System.Drawing.Size(127, 61);
            this.customerSupportButton.TabIndex = 4;
            this.customerSupportButton.Text = "Support";
            this.customerSupportButton.UseVisualStyleBackColor = true;
            // 
            // customerFeedbackButton
            // 
            this.customerFeedbackButton.Location = new System.Drawing.Point(35, 288);
            this.customerFeedbackButton.Name = "customerFeedbackButton";
            this.customerFeedbackButton.Size = new System.Drawing.Size(127, 61);
            this.customerFeedbackButton.TabIndex = 5;
            this.customerFeedbackButton.Text = "Feedback";
            this.customerFeedbackButton.UseVisualStyleBackColor = true;
            // 
            // customerLogoutButton
            // 
            this.customerLogoutButton.Location = new System.Drawing.Point(589, 288);
            this.customerLogoutButton.Name = "customerLogoutButton";
            this.customerLogoutButton.Size = new System.Drawing.Size(127, 61);
            this.customerLogoutButton.TabIndex = 6;
            this.customerLogoutButton.Text = "Logout";
            this.customerLogoutButton.UseVisualStyleBackColor = true;
            // 
            // FormCustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.customerLogoutButton);
            this.Controls.Add(this.customerFeedbackButton);
            this.Controls.Add(this.customerSupportButton);
            this.Controls.Add(this.customerMenuButton);
            this.Controls.Add(this.customerProfile);
            this.Controls.Add(this.customerLabel);
            this.Name = "FormCustomerDashboard";
            this.Text = "FormCustomerDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Button customerProfile;
        private System.Windows.Forms.Button customerMenuButton;
        private System.Windows.Forms.Button customerSupportButton;
        private System.Windows.Forms.Button customerFeedbackButton;
        private System.Windows.Forms.Button customerLogoutButton;
    }
}