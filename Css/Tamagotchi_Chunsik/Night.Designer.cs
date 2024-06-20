namespace Tamagotchi
{
    partial class Night
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new System.Windows.Forms.Label();
            dot1 = new System.Windows.Forms.Label();
            dot2 = new System.Windows.Forms.Label();
            dot3 = new System.Windows.Forms.Label();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = Properties.Resources.밤_춘식이;
            pictureBox1.Location = new System.Drawing.Point(317, 260);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(160, 160);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Galmuri9 Regular", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(317, 439);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(145, 38);
            label1.TabIndex = 1;
            label1.Text = "재밌었다";
            // 
            // dot1
            // 
            dot1.AutoSize = true;
            dot1.BackColor = System.Drawing.Color.Transparent;
            dot1.Font = new System.Drawing.Font("Galmuri9 Regular", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dot1.ForeColor = System.Drawing.Color.White;
            dot1.Location = new System.Drawing.Point(452, 439);
            dot1.Name = "dot1";
            dot1.Size = new System.Drawing.Size(30, 38);
            dot1.TabIndex = 1;
            dot1.Text = ".";
            dot1.Visible = false;
            // 
            // dot2
            // 
            dot2.AutoSize = true;
            dot2.BackColor = System.Drawing.Color.Transparent;
            dot2.Font = new System.Drawing.Font("Galmuri9 Regular", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dot2.ForeColor = System.Drawing.Color.White;
            dot2.Location = new System.Drawing.Point(473, 439);
            dot2.Name = "dot2";
            dot2.Size = new System.Drawing.Size(30, 38);
            dot2.TabIndex = 1;
            dot2.Text = ".";
            dot2.Visible = false;
            // 
            // dot3
            // 
            dot3.AutoSize = true;
            dot3.BackColor = System.Drawing.Color.Transparent;
            dot3.Font = new System.Drawing.Font("Galmuri9 Regular", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dot3.ForeColor = System.Drawing.Color.White;
            dot3.Location = new System.Drawing.Point(494, 439);
            dot3.Name = "dot3";
            dot3.Size = new System.Drawing.Size(30, 38);
            dot3.TabIndex = 1;
            dot3.Text = ".";
            dot3.Visible = false;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Night
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = Properties.Resources.밤;
            ClientSize = new System.Drawing.Size(800, 600);
            Controls.Add(label1);
            Controls.Add(dot3);
            Controls.Add(dot2);
            Controls.Add(dot1);
            Controls.Add(pictureBox1);
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Night";
            Text = "Night";
            Load += Night_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dot1;
        private System.Windows.Forms.Label dot2;
        private System.Windows.Forms.Label dot3;
        private System.Windows.Forms.Timer timer2;
    }
}