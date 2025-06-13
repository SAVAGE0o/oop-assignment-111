// ──────────────────────────────────────────────────────────────────────────────
//  FormManageMenu.Designer.cs
// ──────────────────────────────────────────────────────────────────────────────
namespace oop_assignment
{
    partial class FormManageMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvMenu = new System.Windows.Forms.DataGridView();
            btnAdd = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(dgvMenu)).BeginInit();
            SuspendLayout();
            // 
            // dgvMenu
            // 
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.AllowUserToDeleteRows = false;
            dgvMenu.ColumnHeadersHeightSizeMode =
                     System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Columns.Add("colId", "ID");
            dgvMenu.Columns.Add("colName", "Name");
            dgvMenu.Columns.Add("colPrice", "Price (RM)");
            dgvMenu.Location = new System.Drawing.Point(12, 12);
            dgvMenu.MultiSelect = false;
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dgvMenu.RowHeadersVisible = false;
            dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMenu.Size = new System.Drawing.Size(460, 250);
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(12, 275);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(90, 30);
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new System.EventHandler(btnAdd_Click);
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(108, 275);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(90, 30);
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += new System.EventHandler(btnEdit_Click);
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(204, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(90, 30);
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += new System.EventHandler(btnDelete_Click);
            // 
            // FormManageMenu
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 321);
            Controls.Add(dgvMenu);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Name = "FormManageMenu";
            Text = "Manage Menu";
            ((System.ComponentModel.ISupportInitialize)(dgvMenu)).EndInit();
            ResumeLayout(false);
        }
    }
}
