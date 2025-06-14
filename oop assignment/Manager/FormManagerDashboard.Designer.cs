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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.Mbutton2 = new System.Windows.Forms.Button();
            this.Mlogout = new System.Windows.Forms.Button();
            this.Mbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.button3.Location = new System.Drawing.Point(715, 326);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "coustomer support";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Mbutton2
            // 
            this.Mbutton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mbutton2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F);
            this.Mbutton2.Location = new System.Drawing.Point(715, 213);
            this.Mbutton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mbutton2.Name = "Mbutton2";
            this.Mbutton2.Size = new System.Drawing.Size(147, 52);
            this.Mbutton2.TabIndex = 1;
            this.Mbutton2.Text = "FeedBack";
            this.Mbutton2.UseVisualStyleBackColor = false;
            this.Mbutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Mlogout
            // 
            this.Mlogout.BackColor = System.Drawing.Color.White;
            this.Mlogout.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mlogout.Location = new System.Drawing.Point(691, 517);
            this.Mlogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mlogout.Name = "Mlogout";
            this.Mlogout.Size = new System.Drawing.Size(118, 40);
            this.Mlogout.TabIndex = 3;
            this.Mlogout.Text = "logout";
            this.Mlogout.UseVisualStyleBackColor = false;
            this.Mlogout.Click += new System.EventHandler(this.button4_Click);
            // 
            // Mbutton1
            // 
            this.Mbutton1.BackColor = System.Drawing.Color.White;
            this.Mbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mbutton1.Location = new System.Drawing.Point(715, 103);
            this.Mbutton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Mbutton1.Name = "Mbutton1";
            this.Mbutton1.Size = new System.Drawing.Size(147, 52);
            this.Mbutton1.TabIndex = 0;
            this.Mbutton1.Text = "profile";
            this.Mbutton1.UseVisualStyleBackColor = false;
            this.Mbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.BackgroundImage = global::oop_assignment.Properties.Resources.Screenshot_2025_06_13_193428;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1208, 685);
            this.Controls.Add(this.Mlogout);
            this.Controls.Add(this.Mbutton1);
            this.Controls.Add(this.Mbutton2);
            this.Controls.Add(this.button3);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormManagerDashboard";
            this.Text = "Manager Dashboard";
            this.Load += new System.EventHandler(this.FormManagerDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Mbutton2;
        private System.Windows.Forms.Button Mlogout;
        private System.Windows.Forms.Button Mbutton1;
    }
}