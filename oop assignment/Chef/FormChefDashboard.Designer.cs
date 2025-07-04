﻿namespace oop_assignment
{
    partial class FormChefDashboard
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnManageMenu = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.Brown;
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnOrders);
            this.panelSidebar.Controls.Add(this.btnManageMenu);
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Location = new System.Drawing.Point(383, 1);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 450);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnLogout.Location = new System.Drawing.Point(0, 396);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 54);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.White;
            this.btnOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrders.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.btnOrders.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnOrders.Location = new System.Drawing.Point(0, 112);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(200, 54);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnManageMenu
            // 
            this.btnManageMenu.BackColor = System.Drawing.Color.White;
            this.btnManageMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageMenu.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.btnManageMenu.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnManageMenu.Location = new System.Drawing.Point(0, 50);
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Size = new System.Drawing.Size(200, 62);
            this.btnManageMenu.TabIndex = 1;
            this.btnManageMenu.Text = "Manage Menu\t";
            this.btnManageMenu.UseVisualStyleBackColor = false;
            this.btnManageMenu.Click += new System.EventHandler(this.btnManageMenu_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.White;
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.btnProfile.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnProfile.Location = new System.Drawing.Point(0, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(200, 50);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // FormChefDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImage = global::oop_assignment.Properties.Resources.Screenshot_2025_06_14_235012;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSidebar);
            this.DoubleBuffered = true;
            this.Name = "FormChefDashboard";
            this.Text = "FormChefDashboard";
            this.Load += new System.EventHandler(this.FormChefDashboard_Load_1);
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnManageMenu;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button panelManageMenu;
        private System.Windows.Forms.Button panelOrders;
        private System.Windows.Forms.TextBox numPrice;
    }
}