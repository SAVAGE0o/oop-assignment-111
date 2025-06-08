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
            this.MlblTitle = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvFeedback = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // MlblTitle
            // 
            this.MlblTitle.AutoSize = true;
            this.MlblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MlblTitle.Location = new System.Drawing.Point(296, 66);
            this.MlblTitle.Name = "MlblTitle";
            this.MlblTitle.Size = new System.Drawing.Size(202, 30);
            this.MlblTitle.TabIndex = 0;
            this.MlblTitle.Text = "Customer Feedback";
            this.MlblTitle.UseCompatibleTextRendering = true;
            // 
            // txtResponse
            // 
            this.txtResponse.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtResponse.Location = new System.Drawing.Point(144, 274);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(525, 22);
            this.txtResponse.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit Response";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvFeedback
            // 
            this.dgvFeedback.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedback.Location = new System.Drawing.Point(144, 98);
            this.dgvFeedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFeedback.Name = "dgvFeedback";
            this.dgvFeedback.RowHeadersWidth = 51;
            this.dgvFeedback.RowTemplate.Height = 24;
            this.dgvFeedback.Size = new System.Drawing.Size(525, 171);
            this.dgvFeedback.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(675, 420);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "back to menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManagerFeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvFeedback);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.MlblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerFeedBack";
            this.Text = "ManagerFeedBack";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MlblTitle;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvFeedback;
        private System.Windows.Forms.Button button2;
    }
}