namespace oop_assignment
{
    partial class ManagerFeedBack
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFeedBack = new System.Windows.Forms.DataGridView();
            this.rtbResponses = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedBack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Costumer Feedback";
            // 
            // dgvFeedBack
            // 
            this.dgvFeedBack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedBack.Location = new System.Drawing.Point(96, 44);
            this.dgvFeedBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFeedBack.Name = "dgvFeedBack";
            this.dgvFeedBack.RowHeadersWidth = 51;
            this.dgvFeedBack.RowTemplate.Height = 24;
            this.dgvFeedBack.Size = new System.Drawing.Size(420, 172);
            this.dgvFeedBack.TabIndex = 1;
            this.dgvFeedBack.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedBack_CellContentClick);
            // 
            // rtbResponses
            // 
            this.rtbResponses.Location = new System.Drawing.Point(96, 221);
            this.rtbResponses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbResponses.Name = "rtbResponses";
            this.rtbResponses.Size = new System.Drawing.Size(311, 79);
            this.rtbResponses.TabIndex = 2;
            this.rtbResponses.Text = "";
            this.rtbResponses.TextChanged += new System.EventHandler(this.txtResponses_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(424, 220);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 79);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ManagerFeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rtbResponses);
            this.Controls.Add(this.dgvFeedBack);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManagerFeedBack";
            this.Text = "ManagerFeedBack";
            this.Load += new System.EventHandler(this.ManagerFeedBack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFeedBack;
        private System.Windows.Forms.RichTextBox rtbResponses;
        private System.Windows.Forms.Button btnSubmit;
    }
}