namespace Tamagotchi
{
    partial class Loding
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loding));
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            dot3 = new System.Windows.Forms.Label();
            dot1 = new System.Windows.Forms.Label();
            dot2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dot3);
            panel1.Controls.Add(dot1);
            panel1.Controls.Add(dot2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(276, 479);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Galmuri9 Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(84, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 25);
            label1.TabIndex = 1;
            label1.Text = "Loading";
            // 
            // dot3
            // 
            dot3.AutoSize = true;
            dot3.BackColor = System.Drawing.Color.Transparent;
            dot3.Font = new System.Drawing.Font("Galmuri9 Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dot3.Location = new System.Drawing.Point(207, 91);
            dot3.Name = "dot3";
            dot3.Size = new System.Drawing.Size(21, 25);
            dot3.TabIndex = 1;
            dot3.Text = ".";
            dot3.Visible = false;
            // 
            // dot1
            // 
            dot1.AutoSize = true;
            dot1.BackColor = System.Drawing.Color.Transparent;
            dot1.Font = new System.Drawing.Font("Galmuri9 Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dot1.Location = new System.Drawing.Point(175, 91);
            dot1.Name = "dot1";
            dot1.Size = new System.Drawing.Size(21, 25);
            dot1.TabIndex = 1;
            dot1.Text = ".";
            dot1.Visible = false;
            // 
            // dot2
            // 
            dot2.AutoSize = true;
            dot2.BackColor = System.Drawing.Color.Transparent;
            dot2.Font = new System.Drawing.Font("Galmuri9 Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dot2.Location = new System.Drawing.Point(190, 91);
            dot2.Name = "dot2";
            dot2.Size = new System.Drawing.Size(21, 25);
            dot2.TabIndex = 1;
            dot2.Text = ".";
            dot2.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(83, 181);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(110, 110);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Loding
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(276, 479);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Loding";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Loding";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Label dot3;
        public System.Windows.Forms.Label dot1;
        public System.Windows.Forms.Label dot2;
    }
}