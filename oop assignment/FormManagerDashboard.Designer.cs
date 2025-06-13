namespace oop_assignment
{
    partial class FormManagerDashboard
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
            this.components = new System.ComponentModel.Container();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._C_DataSet = new oop_assignment._C_DataSet();
            this.Goback = new System.Windows.Forms.Button();
            this.itemname = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(12, 45);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(156, 26);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.chkAvailable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkAvailable.Location = new System.Drawing.Point(408, 45);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(133, 23);
            this.chkAvailable.TabIndex = 2;
            this.chkAvailable.Text = "Availability";
            this.chkAvailable.UseVisualStyleBackColor = true;
            this.chkAvailable.CheckedChanged += new System.EventHandler(this.chkAvailable_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.btnAdd.Location = new System.Drawing.Point(18, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.btnEdit.Location = new System.Drawing.Point(219, 85);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 35);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.btnDelete.Location = new System.Drawing.Point(408, 85);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.Location = new System.Drawing.Point(142, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(605, 271);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cDataSetBindingSource
            // 
            this.cDataSetBindingSource.DataSource = this._C_DataSet;
            this.cDataSetBindingSource.Position = 0;
            // 
            // _C_DataSet
            // 
            this._C_DataSet.DataSetName = "_C_DataSet";
            this._C_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Goback
            // 
            this.Goback.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.Goback.Location = new System.Drawing.Point(12, 366);
            this.Goback.Name = "Goback";
            this.Goback.Size = new System.Drawing.Size(114, 44);
            this.Goback.TabIndex = 8;
            this.Goback.Text = "Go back";
            this.Goback.UseVisualStyleBackColor = true;
            this.Goback.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemname
            // 
            this.itemname.AutoSize = true;
            this.itemname.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.itemname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.itemname.Location = new System.Drawing.Point(20, 16);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(95, 19);
            this.itemname.TabIndex = 9;
            this.itemname.Text = "Item Name";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.Price.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Price.Location = new System.Drawing.Point(212, 16);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(51, 19);
            this.Price.TabIndex = 11;
            this.Price.Text = "Price";
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(204, 45);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(156, 26);
            this.numericUpDownPrice.TabIndex = 10;
            this.numericUpDownPrice.TextChanged += new System.EventHandler(this.numPrice_TextChanged);
            // 
            // FormManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.Goback);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkAvailable);
            this.Controls.Add(this.txtItemName);
            this.Name = "FormManagerDashboard";
            this.Text = "FormManagerDashboard";
            this.Load += new System.EventHandler(this.FormManagerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._C_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Goback;
        private System.Windows.Forms.BindingSource cDataSetBindingSource;
        private _C_DataSet _C_DataSet;
        private System.Windows.Forms.Label itemname;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox numericUpDownPrice;
    }
}