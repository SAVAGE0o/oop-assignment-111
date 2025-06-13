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
            this.customerProfile = new System.Windows.Forms.Button();
            this.customerMenuButton = new System.Windows.Forms.Button();
            this.customerSupportButton = new System.Windows.Forms.Button();
            this.customerFeedbackButton = new System.Windows.Forms.Button();
            this.customerLogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerProfile
            // 
            this.customerProfile.BackColor = System.Drawing.Color.Orange;
            this.customerProfile.Location = new System.Drawing.Point(305, 74);
            this.customerProfile.Name = "customerProfile";
            this.customerProfile.Size = new System.Drawing.Size(139, 38);
            this.customerProfile.TabIndex = 1;
            this.customerProfile.Text = "Profile";
            this.customerProfile.UseVisualStyleBackColor = false;
            // 
            // customerMenuButton
            // 
            this.customerMenuButton.BackColor = System.Drawing.Color.Orange;
            this.customerMenuButton.Location = new System.Drawing.Point(305, 140);
            this.customerMenuButton.Name = "customerMenuButton";
            this.customerMenuButton.Size = new System.Drawing.Size(139, 36);
            this.customerMenuButton.TabIndex = 2;
            this.customerMenuButton.Text = "Menu";
            this.customerMenuButton.UseVisualStyleBackColor = false;
            this.customerMenuButton.Click += new System.EventHandler(this.customerMenuButton_Click);
            // 
            // customerSupportButton
            // 
            this.customerSupportButton.BackColor = System.Drawing.Color.Orange;
            this.customerSupportButton.Location = new System.Drawing.Point(305, 200);
            this.customerSupportButton.Name = "customerSupportButton";
            this.customerSupportButton.Size = new System.Drawing.Size(139, 40);
            this.customerSupportButton.TabIndex = 4;
            this.customerSupportButton.Text = "Running Orders";
            this.customerSupportButton.UseVisualStyleBackColor = false;
            this.customerSupportButton.Click += new System.EventHandler(this.customerSupportButton_Click);
            // 
            // customerFeedbackButton
            // 
            this.customerFeedbackButton.BackColor = System.Drawing.Color.Orange;
            this.customerFeedbackButton.Location = new System.Drawing.Point(305, 264);
            this.customerFeedbackButton.Name = "customerFeedbackButton";
            this.customerFeedbackButton.Size = new System.Drawing.Size(139, 36);
            this.customerFeedbackButton.TabIndex = 5;
            this.customerFeedbackButton.Text = "Feedback";
            this.customerFeedbackButton.UseVisualStyleBackColor = false;
            this.customerFeedbackButton.Click += new System.EventHandler(this.customerFeedbackButton_Click);
            // 
            // customerLogoutButton
            // 
            this.customerLogoutButton.BackColor = System.Drawing.Color.Orange;
            this.customerLogoutButton.Location = new System.Drawing.Point(486, 328);
            this.customerLogoutButton.Name = "customerLogoutButton";
            this.customerLogoutButton.Size = new System.Drawing.Size(139, 33);
            this.customerLogoutButton.TabIndex = 6;
            this.customerLogoutButton.Text = "Logout";
            this.customerLogoutButton.UseVisualStyleBackColor = false;
            this.customerLogoutButton.Click += new System.EventHandler(this.customerLogoutButton_Click);
            // 
            // FormCustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oop_assignment.Properties.Resources.Screenshot_2025_06_13_0935341;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(637, 394);
            this.Controls.Add(this.customerLogoutButton);
            this.Controls.Add(this.customerFeedbackButton);
            this.Controls.Add(this.customerSupportButton);
            this.Controls.Add(this.customerMenuButton);
            this.Controls.Add(this.customerProfile);
            this.DoubleBuffered = true;
            this.Name = "FormCustomerDashboard";
            this.Text = "FormCustomerDashboard";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button customerProfile;
        private System.Windows.Forms.Button customerMenuButton;
        private System.Windows.Forms.Button customerSupportButton;
        private System.Windows.Forms.Button customerFeedbackButton;
        private System.Windows.Forms.Button customerLogoutButton;
    }
}