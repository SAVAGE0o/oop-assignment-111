namespace oop_assignment
{
    partial class Managersupport
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
            this.mbuttonE = new System.Windows.Forms.Button();
            this.mbtnRR = new System.Windows.Forms.Button();
            this.mreturn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // mbuttonE
            // 
            this.mbuttonE.Location = new System.Drawing.Point(262, 114);
            this.mbuttonE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mbuttonE.Name = "mbuttonE";
            this.mbuttonE.Size = new System.Drawing.Size(149, 129);
            this.mbuttonE.TabIndex = 1;
            this.mbuttonE.Text = "E wallet ";
            this.mbuttonE.UseVisualStyleBackColor = true;
            this.mbuttonE.Click += new System.EventHandler(this.button1_Click);
            // 
            // mbtnRR
            // 
            this.mbtnRR.Location = new System.Drawing.Point(447, 114);
            this.mbtnRR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mbtnRR.Name = "mbtnRR";
            this.mbtnRR.Size = new System.Drawing.Size(156, 129);
            this.mbtnRR.TabIndex = 2;
            this.mbtnRR.Text = "Refund Request";
            this.mbtnRR.UseVisualStyleBackColor = true;
            this.mbtnRR.Click += new System.EventHandler(this.button2_Click);
            // 
            // mreturn3
            // 
            this.mreturn3.Location = new System.Drawing.Point(553, 350);
            this.mreturn3.Name = "mreturn3";
            this.mreturn3.Size = new System.Drawing.Size(86, 45);
            this.mreturn3.TabIndex = 4;
            this.mreturn3.Text = "return";
            this.mreturn3.UseVisualStyleBackColor = true;
            this.mreturn3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Managersupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImage = global::oop_assignment.Properties.Resources.Screenshot_2025_06_12_232603;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 391);
            this.Controls.Add(this.mreturn3);
            this.Controls.Add(this.mbtnRR);
            this.Controls.Add(this.mbuttonE);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Managersupport";
            this.Text = "Managersupport";
            this.Load += new System.EventHandler(this.Managersupport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mbuttonE;
        private System.Windows.Forms.Button mbtnRR;
        private System.Windows.Forms.Button mreturn3;
    }
}