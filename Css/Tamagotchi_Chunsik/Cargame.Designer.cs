namespace Tamagotchi
{
    partial class Cargame
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
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            pictureBox6 = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pb_Car1 = new System.Windows.Forms.PictureBox();
            pb_Car2 = new System.Windows.Forms.PictureBox();
            pb_Car3 = new System.Windows.Forms.PictureBox();
            lb_Gameover = new System.Windows.Forms.Label();
            lb_timer = new System.Windows.Forms.Label();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Car1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Car2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Car3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.Location = new System.Drawing.Point(400, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(14, 121);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.White;
            pictureBox2.Location = new System.Drawing.Point(400, 153);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(14, 121);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.White;
            pictureBox3.Location = new System.Drawing.Point(400, 296);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(14, 121);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = System.Drawing.Color.White;
            pictureBox4.Location = new System.Drawing.Point(400, 435);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(14, 121);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = System.Drawing.Color.White;
            pictureBox5.Location = new System.Drawing.Point(-1, -2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(14, 604);
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = System.Drawing.Color.White;
            pictureBox6.Location = new System.Drawing.Point(786, -5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(14, 607);
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // pb_Car1
            // 
            pb_Car1.BackColor = System.Drawing.Color.Transparent;
            pb_Car1.Image = Properties.Resources.게임1;
            pb_Car1.Location = new System.Drawing.Point(115, 153);
            pb_Car1.Name = "pb_Car1";
            pb_Car1.Size = new System.Drawing.Size(110, 108);
            pb_Car1.TabIndex = 1;
            pb_Car1.TabStop = false;
            // 
            // pb_Car2
            // 
            pb_Car2.BackColor = System.Drawing.Color.Transparent;
            pb_Car2.Image = Properties.Resources.게임2;
            pb_Car2.Location = new System.Drawing.Point(558, 96);
            pb_Car2.Name = "pb_Car2";
            pb_Car2.Size = new System.Drawing.Size(103, 108);
            pb_Car2.TabIndex = 1;
            pb_Car2.TabStop = false;
            // 
            // pb_Car3
            // 
            pb_Car3.BackColor = System.Drawing.Color.Transparent;
            pb_Car3.Image = Properties.Resources.게임3;
            pb_Car3.Location = new System.Drawing.Point(367, 321);
            pb_Car3.Name = "pb_Car3";
            pb_Car3.Size = new System.Drawing.Size(104, 108);
            pb_Car3.TabIndex = 1;
            pb_Car3.TabStop = false;
            // 
            // lb_Gameover
            // 
            lb_Gameover.AutoSize = true;
            lb_Gameover.Font = new System.Drawing.Font("Galmuri9 Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Gameover.Location = new System.Drawing.Point(255, 207);
            lb_Gameover.Name = "lb_Gameover";
            lb_Gameover.Size = new System.Drawing.Size(378, 76);
            lb_Gameover.TabIndex = 2;
            lb_Gameover.Text = "Game Over";
            // 
            // lb_timer
            // 
            lb_timer.AutoSize = true;
            lb_timer.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_timer.Location = new System.Drawing.Point(700, 27);
            lb_timer.Name = "lb_timer";
            lb_timer.Size = new System.Drawing.Size(0, 21);
            lb_timer.TabIndex = 3;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Cargame
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gray;
            ClientSize = new System.Drawing.Size(800, 600);
            Controls.Add(lb_timer);
            Controls.Add(lb_Gameover);
            Controls.Add(pb_Car2);
            Controls.Add(pb_Car3);
            Controls.Add(pb_Car1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Cargame";
            Text = "Cargame";
            TopMost = true;
            Load += Cargame_Load;
            KeyDown += Cargame_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Car1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Car2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Car3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pb_Car1;
        private System.Windows.Forms.PictureBox pb_Car2;
        private System.Windows.Forms.PictureBox pb_Car3;
        private System.Windows.Forms.Label lb_Gameover;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.Timer timer2;
    }
}