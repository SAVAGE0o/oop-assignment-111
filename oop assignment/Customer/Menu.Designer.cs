namespace oop_assignment
{
    partial class Menu
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
            this.customerMenuList = new System.Windows.Forms.ListBox();
            this.menuReturnButton = new System.Windows.Forms.Button();
            this.menuList = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerMenuList
            // 
            this.customerMenuList.FormattingEnabled = true;
            this.customerMenuList.ItemHeight = 20;
            this.customerMenuList.Location = new System.Drawing.Point(316, 209);
            this.customerMenuList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerMenuList.Name = "customerMenuList";
            this.customerMenuList.Size = new System.Drawing.Size(346, 144);
            this.customerMenuList.TabIndex = 0;
            this.customerMenuList.SelectedIndexChanged += new System.EventHandler(this.customerMenuList_SelectedIndexChanged);
            // 
            // menuReturnButton
            // 
            this.menuReturnButton.Location = new System.Drawing.Point(603, 378);
            this.menuReturnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuReturnButton.Name = "menuReturnButton";
            this.menuReturnButton.Size = new System.Drawing.Size(102, 42);
            this.menuReturnButton.TabIndex = 10;
            this.menuReturnButton.Text = "Return";
            this.menuReturnButton.UseVisualStyleBackColor = true;
            this.menuReturnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuList
            // 
            this.menuList.FormattingEnabled = true;
            this.menuList.ItemHeight = 20;
            this.menuList.Location = new System.Drawing.Point(316, 62);
            this.menuList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuList.Name = "menuList";
            this.menuList.Size = new System.Drawing.Size(346, 124);
            this.menuList.TabIndex = 13;
            this.menuList.SelectedIndexChanged += new System.EventHandler(this.menuList_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.pictureBox1.Image = global::oop_assignment.Properties.Resources.grocery_store;
            this.pictureBox1.Location = new System.Drawing.Point(652, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oop_assignment.Properties.Resources.Screenshot_2025_06_13_094645;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 431);
            this.Controls.Add(this.menuList);
            this.Controls.Add(this.menuReturnButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customerMenuList);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox customerMenuList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button menuReturnButton;
        private System.Windows.Forms.ListBox menuList;
    }
}