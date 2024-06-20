namespace Tamagotchi
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            btn_Quit = new System.Windows.Forms.Button();
            btn_start = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SpeechBubble = new System.Windows.Forms.PictureBox();
            Speech = new System.Windows.Forms.Label();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpeechBubble).BeginInit();
            SuspendLayout();
            // 
            // btn_Quit
            // 
            btn_Quit.BackColor = System.Drawing.Color.Transparent;
            btn_Quit.BackgroundImage = Properties.Resources.종료;
            btn_Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Quit.FlatAppearance.BorderSize = 0;
            btn_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Quit.ForeColor = System.Drawing.Color.Black;
            btn_Quit.Location = new System.Drawing.Point(321, 384);
            btn_Quit.Name = "btn_Quit";
            btn_Quit.Size = new System.Drawing.Size(181, 68);
            btn_Quit.TabIndex = 0;
            btn_Quit.UseVisualStyleBackColor = false;
            btn_Quit.Click += btn_Quit_Click;
            btn_Quit.MouseDown += btn_Quit_MouseDown;
            btn_Quit.MouseUp += btn_Quit_MouseUp;
            // 
            // btn_start
            // 
            btn_start.BackColor = System.Drawing.Color.Transparent;
            btn_start.BackgroundImage = Properties.Resources.시작;
            btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_start.FlatAppearance.BorderSize = 0;
            btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_start.Location = new System.Drawing.Point(321, 313);
            btn_start.Name = "btn_start";
            btn_start.Size = new System.Drawing.Size(181, 65);
            btn_start.TabIndex = 1;
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += btn_start_Click;
            btn_start.MouseDown += btn_start_MouseDown;
            btn_start.MouseUp += btn_start_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(86, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(656, 168);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SpeechBubble
            // 
            SpeechBubble.BackColor = System.Drawing.Color.Transparent;
            SpeechBubble.Image = Properties.Resources.pngegg;
            SpeechBubble.Location = new System.Drawing.Point(519, 253);
            SpeechBubble.Name = "SpeechBubble";
            SpeechBubble.Size = new System.Drawing.Size(118, 87);
            SpeechBubble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            SpeechBubble.TabIndex = 3;
            SpeechBubble.TabStop = false;
            // 
            // Speech
            // 
            Speech.AutoSize = true;
            Speech.BackColor = System.Drawing.Color.White;
            Speech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Speech.Font = new System.Drawing.Font("Galmuri9 Regular", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Speech.Location = new System.Drawing.Point(531, 271);
            Speech.Name = "Speech";
            Speech.Size = new System.Drawing.Size(89, 32);
            Speech.TabIndex = 4;
            Speech.Text = "너\r\n내 주인 해라";
            Speech.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Start
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(241, 185, 90);
            BackgroundImage = Properties.Resources.진짜최종;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 600);
            Controls.Add(Speech);
            Controls.Add(btn_start);
            Controls.Add(btn_Quit);
            Controls.Add(SpeechBubble);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Start";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Start";
            Load += Start_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpeechBubble).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox SpeechBubble;
        public System.Windows.Forms.Label Speech;
        private System.Windows.Forms.Timer timer2;
    }
}