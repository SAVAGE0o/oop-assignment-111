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
            this.dgvFeedBack = new System.Windows.Forms.DataGridView();
            this.rtbResponses = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFeedBack
            // 
            this.dgvFeedBack.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFeedBack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedBack.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvFeedBack.Location = new System.Drawing.Point(343, 53);
            this.dgvFeedBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFeedBack.Name = "dgvFeedBack";
            this.dgvFeedBack.RowHeadersWidth = 51;
            this.dgvFeedBack.RowTemplate.Height = 24;
            this.dgvFeedBack.Size = new System.Drawing.Size(534, 212);
            this.dgvFeedBack.TabIndex = 1;
            this.dgvFeedBack.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedBack_CellContentClick);
            // 
            // rtbResponses
            // 
            this.rtbResponses.Location = new System.Drawing.Point(343, 269);
            this.rtbResponses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbResponses.Name = "rtbResponses";
            this.rtbResponses.Size = new System.Drawing.Size(368, 96);
            this.rtbResponses.TabIndex = 2;
            this.rtbResponses.Text = "";
            this.rtbResponses.TextChanged += new System.EventHandler(this.txtResponses_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(717, 268);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(132, 97);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(808, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "return";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerFeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImage = global::oop_assignment.Properties.Resources.Screenshot_2025_06_12_230441;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rtbResponses);
            this.Controls.Add(this.dgvFeedBack);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerFeedBack";
            this.Text = "ManagerFeedBack";
            this.Load += new System.EventHandler(this.ManagerFeedBack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFeedBack;
        private System.Windows.Forms.RichTextBox rtbResponses;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button1;
    }
}