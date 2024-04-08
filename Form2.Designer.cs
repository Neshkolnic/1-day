namespace _1_day
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданиеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.заданиеToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заданиеToolStripMenuItem,
            this.заданиеToolStripMenuItem1,
            this.заданиеToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заданиеToolStripMenuItem
            // 
            this.заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            this.заданиеToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.заданиеToolStripMenuItem.Text = "1 задание";
            this.заданиеToolStripMenuItem.Click += new System.EventHandler(this.заданиеToolStripMenuItem_Click);
            // 
            // заданиеToolStripMenuItem1
            // 
            this.заданиеToolStripMenuItem1.Name = "заданиеToolStripMenuItem1";
            this.заданиеToolStripMenuItem1.Size = new System.Drawing.Size(92, 24);
            this.заданиеToolStripMenuItem1.Text = "2 задание";
            this.заданиеToolStripMenuItem1.Click += new System.EventHandler(this.заданиеToolStripMenuItem1_Click);
            // 
            // заданиеToolStripMenuItem2
            // 
            this.заданиеToolStripMenuItem2.Name = "заданиеToolStripMenuItem2";
            this.заданиеToolStripMenuItem2.Size = new System.Drawing.Size(92, 24);
            this.заданиеToolStripMenuItem2.Text = "3 задание";
            this.заданиеToolStripMenuItem2.Click += new System.EventHandler(this.заданиеToolStripMenuItem2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заданиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заданиеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem заданиеToolStripMenuItem2;
    }
}