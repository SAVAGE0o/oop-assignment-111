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
            this.profileButton = new System.Windows.Forms.Button();
            this.customerMenuButton = new System.Windows.Forms.Button();
            this.customerOrdersButton = new System.Windows.Forms.Button();
            this.customerFeedbackButton = new System.Windows.Forms.Button();
            this.customerLogoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.Orange;
            this.profileButton.Location = new System.Drawing.Point(305, 74);
            this.profileButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(140, 38);
            this.profileButton.TabIndex = 1;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = false;
            // 
            // customerMenuButton
            // 
            this.customerMenuButton.BackColor = System.Drawing.Color.Orange;
            this.customerMenuButton.Location = new System.Drawing.Point(305, 140);
            this.customerMenuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerMenuButton.Name = "customerMenuButton";
            this.customerMenuButton.Size = new System.Drawing.Size(140, 36);
            this.customerMenuButton.TabIndex = 2;
            this.customerMenuButton.Text = "Menu";
            this.customerMenuButton.UseVisualStyleBackColor = false;
            this.customerMenuButton.Click += new System.EventHandler(this.customerMenuButton_Click);
            // 
            // customerOrdersButton
            // 
            this.customerOrdersButton.BackColor = System.Drawing.Color.Orange;
            this.customerOrdersButton.Location = new System.Drawing.Point(305, 200);
            this.customerOrdersButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerOrdersButton.Name = "customerOrdersButton";
            this.customerOrdersButton.Size = new System.Drawing.Size(140, 40);
            this.customerOrdersButton.TabIndex = 4;
            this.customerOrdersButton.Text = "Running Orders";
            this.customerOrdersButton.UseVisualStyleBackColor = false;
            this.customerOrdersButton.Click += new System.EventHandler(this.customerSupportButton_Click);
            // 
            // customerFeedbackButton
            // 
            this.customerFeedbackButton.BackColor = System.Drawing.Color.Orange;
            this.customerFeedbackButton.Location = new System.Drawing.Point(305, 264);
            this.customerFeedbackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerFeedbackButton.Name = "customerFeedbackButton";
            this.customerFeedbackButton.Size = new System.Drawing.Size(140, 36);
            this.customerFeedbackButton.TabIndex = 5;
            this.customerFeedbackButton.Text = "Feedback";
            this.customerFeedbackButton.UseVisualStyleBackColor = false;
            this.customerFeedbackButton.Click += new System.EventHandler(this.customerFeedbackButton_Click);
            // 
            // customerLogoutButton
            // 
            this.customerLogoutButton.BackColor = System.Drawing.Color.Orange;
            this.customerLogoutButton.Location = new System.Drawing.Point(486, 328);
            this.customerLogoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerLogoutButton.Name = "customerLogoutButton";
            this.customerLogoutButton.Size = new System.Drawing.Size(140, 32);
            this.customerLogoutButton.TabIndex = 6;
            this.customerLogoutButton.Text = "Logout";
            this.customerLogoutButton.UseVisualStyleBackColor = false;
            this.customerLogoutButton.Click += new System.EventHandler(this.customerLogoutButton_Click);
            // 
            // FormCustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oop_assignment.Properties.Resources.Screenshot_2025_06_13_093534;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(637, 394);
            this.Controls.Add(this.customerLogoutButton);
            this.Controls.Add(this.customerFeedbackButton);
            this.Controls.Add(this.customerOrdersButton);
            this.Controls.Add(this.customerMenuButton);
            this.Controls.Add(this.profileButton);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCustomerDashboard";
            this.Text = "FormCustomerDashboard";
            this.Load += new System.EventHandler(this.FormCustomerDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button customerMenuButton;
        private System.Windows.Forms.Button customerOrdersButton;
        private System.Windows.Forms.Button customerFeedbackButton;
        private System.Windows.Forms.Button customerLogoutButton;
    }
}