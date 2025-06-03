namespace oop_assignment
{
    partial class Menu_Management
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
            this.panelManageMenu = new System.Windows.Forms.Panel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.panelManageMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelManageMenu
            // 
            this.panelManageMenu.Controls.Add(this.listBoxMenu);
            this.panelManageMenu.Controls.Add(this.btnEditItem);
            this.panelManageMenu.Controls.Add(this.btnRemoveItem);
            this.panelManageMenu.Controls.Add(this.btnAddItem);
            this.panelManageMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManageMenu.Location = new System.Drawing.Point(0, 0);
            this.panelManageMenu.Name = "panelManageMenu";
            this.panelManageMenu.Size = new System.Drawing.Size(800, 450);
            this.panelManageMenu.TabIndex = 0;
            this.panelManageMenu.Visible = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(34, 111);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(147, 33);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add Item\t";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(34, 159);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(147, 31);
            this.btnRemoveItem.TabIndex = 1;
            this.btnRemoveItem.Text = "Remove Item\t";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(34, 208);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(147, 28);
            this.btnEditItem.TabIndex = 2;
            this.btnEditItem.Text = "Edit Item\t";
            this.btnEditItem.UseVisualStyleBackColor = true;
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 20;
            this.listBoxMenu.Location = new System.Drawing.Point(241, 208);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(409, 204);
            this.listBoxMenu.TabIndex = 3;
            // 
            // Menu_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelManageMenu);
            this.Name = "Menu_Management";
            this.Text = "Menu_Management";
            this.Load += new System.EventHandler(this.Menu_Management_Load);
            this.panelManageMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelManageMenu;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListBox listBoxMenu;
    }
}