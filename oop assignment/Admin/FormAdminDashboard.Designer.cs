namespace oop_assignment
{
    partial class FormAdminDashboard
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
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnViewEWalletTopUp = new System.Windows.Forms.Button();
            this.btnViewSalesReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.BackColor = System.Drawing.Color.DarkOrange;
            this.btnViewUsers.Location = new System.Drawing.Point(340, 92);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(102, 23);
            this.btnViewUsers.TabIndex = 0;
            this.btnViewUsers.Text = "View Users";
            this.btnViewUsers.UseVisualStyleBackColor = false;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddUser.Location = new System.Drawing.Point(340, 164);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(102, 23);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditUser.Location = new System.Drawing.Point(340, 238);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(102, 23);
            this.btnEditUser.TabIndex = 2;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = false;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDeleteUser.Location = new System.Drawing.Point(340, 303);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.Location = new System.Drawing.Point(652, 403);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(102, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(632, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewEWalletTopUp
            // 
            this.btnViewEWalletTopUp.BackColor = System.Drawing.Color.DarkOrange;
            this.btnViewEWalletTopUp.Location = new System.Drawing.Point(340, 38);
            this.btnViewEWalletTopUp.Name = "btnViewEWalletTopUp";
            this.btnViewEWalletTopUp.Size = new System.Drawing.Size(120, 23);
            this.btnViewEWalletTopUp.TabIndex = 8;
            this.btnViewEWalletTopUp.Text = "View E-wallet";
            this.btnViewEWalletTopUp.UseVisualStyleBackColor = false;
            this.btnViewEWalletTopUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnViewSalesReport
            // 
            this.btnViewSalesReport.BackColor = System.Drawing.Color.DarkOrange;
            this.btnViewSalesReport.Location = new System.Drawing.Point(340, 359);
            this.btnViewSalesReport.Name = "btnViewSalesReport";
            this.btnViewSalesReport.Size = new System.Drawing.Size(102, 23);
            this.btnViewSalesReport.TabIndex = 9;
            this.btnViewSalesReport.Text = "Sales Report";
            this.btnViewSalesReport.UseVisualStyleBackColor = false;
            this.btnViewSalesReport.Click += new System.EventHandler(this.btnViewSalesReport_Click);
            // 
            // FormAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BackgroundImage = global::oop_assignment.Properties.Resources.Screenshot_2025_06_15_000848;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewSalesReport);
            this.Controls.Add(this.btnViewEWalletTopUp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnViewUsers);
            this.DoubleBuffered = true;
            this.Name = "FormAdminDashboard";
            this.Text = "FormAdminDashboard";
            this.Load += new System.EventHandler(this.FormAdminDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnViewEWalletTopUp;
        private System.Windows.Forms.Button btnViewSalesReport;
    }
}