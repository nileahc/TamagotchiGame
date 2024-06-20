namespace Tamagotchi
{
    partial class Game1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1));
            btn_Siger = new System.Windows.Forms.Button();
            btn_Paper = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btn_Start = new System.Windows.Forms.Button();
            btn_Back = new System.Windows.Forms.Button();
            btn_Rock = new System.Windows.Forms.Button();
            btn_Go = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            pb_Other = new System.Windows.Forms.PictureBox();
            btn_Exit = new System.Windows.Forms.Button();
            lb_Score = new System.Windows.Forms.Label();
            lb_Chance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pb_Other).BeginInit();
            SuspendLayout();
            // 
            // btn_Siger
            // 
            btn_Siger.BackColor = System.Drawing.Color.Transparent;
            btn_Siger.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_Siger.BackgroundImage");
            btn_Siger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Siger.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Siger.Enabled = false;
            btn_Siger.FlatAppearance.BorderSize = 0;
            btn_Siger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Siger.Location = new System.Drawing.Point(372, 403);
            btn_Siger.Name = "btn_Siger";
            btn_Siger.Size = new System.Drawing.Size(120, 106);
            btn_Siger.TabIndex = 0;
            btn_Siger.UseVisualStyleBackColor = false;
            btn_Siger.Visible = false;
            btn_Siger.Click += btn_Siger_Click;
            // 
            // btn_Paper
            // 
            btn_Paper.BackColor = System.Drawing.Color.Transparent;
            btn_Paper.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_Paper.BackgroundImage");
            btn_Paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Paper.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Paper.Enabled = false;
            btn_Paper.FlatAppearance.BorderSize = 0;
            btn_Paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Paper.Location = new System.Drawing.Point(676, 403);
            btn_Paper.Name = "btn_Paper";
            btn_Paper.Size = new System.Drawing.Size(120, 106);
            btn_Paper.TabIndex = 0;
            btn_Paper.UseVisualStyleBackColor = false;
            btn_Paper.Visible = false;
            btn_Paper.Click += btn_Paper_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Galmuri9 Regular", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(338, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(227, 43);
            label1.TabIndex = 1;
            label1.Text = "Game Start";
            // 
            // btn_Start
            // 
            btn_Start.BackColor = System.Drawing.Color.Transparent;
            btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Start.FlatAppearance.BorderSize = 0;
            btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Start.Font = new System.Drawing.Font("Galmuri9 Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Start.Location = new System.Drawing.Point(272, 249);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new System.Drawing.Size(142, 80);
            btn_Start.TabIndex = 2;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = false;
            btn_Start.Click += btn_Start_Click;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = System.Drawing.Color.Transparent;
            btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Back.Font = new System.Drawing.Font("Galmuri9 Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Back.Location = new System.Drawing.Point(451, 249);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new System.Drawing.Size(142, 80);
            btn_Back.TabIndex = 2;
            btn_Back.Text = "Back";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // btn_Rock
            // 
            btn_Rock.BackColor = System.Drawing.Color.Transparent;
            btn_Rock.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_Rock.BackgroundImage");
            btn_Rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Rock.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Rock.Enabled = false;
            btn_Rock.FlatAppearance.BorderSize = 0;
            btn_Rock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Rock.Location = new System.Drawing.Point(80, 403);
            btn_Rock.Name = "btn_Rock";
            btn_Rock.Size = new System.Drawing.Size(120, 106);
            btn_Rock.TabIndex = 0;
            btn_Rock.UseVisualStyleBackColor = false;
            btn_Rock.Visible = false;
            btn_Rock.Click += btn_Rock_Click;
            // 
            // btn_Go
            // 
            btn_Go.BackColor = System.Drawing.Color.Transparent;
            btn_Go.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Go.Enabled = false;
            btn_Go.FlatAppearance.BorderSize = 0;
            btn_Go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Go.Font = new System.Drawing.Font("Galmuri9 Regular", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Go.ForeColor = System.Drawing.SystemColors.HighlightText;
            btn_Go.Location = new System.Drawing.Point(672, 130);
            btn_Go.Name = "btn_Go";
            btn_Go.Size = new System.Drawing.Size(93, 53);
            btn_Go.TabIndex = 2;
            btn_Go.Text = "시작";
            btn_Go.UseVisualStyleBackColor = false;
            btn_Go.Visible = false;
            btn_Go.Click += btn_Go_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // pb_Other
            // 
            pb_Other.BackColor = System.Drawing.Color.Transparent;
            pb_Other.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pb_Other.Location = new System.Drawing.Point(372, 130);
            pb_Other.Name = "pb_Other";
            pb_Other.Size = new System.Drawing.Size(120, 106);
            pb_Other.TabIndex = 3;
            pb_Other.TabStop = false;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = System.Drawing.Color.Transparent;
            btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Exit.Enabled = false;
            btn_Exit.FlatAppearance.BorderSize = 0;
            btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Exit.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Exit.ForeColor = System.Drawing.SystemColors.WindowText;
            btn_Exit.Location = new System.Drawing.Point(802, 3);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new System.Drawing.Size(79, 45);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "종료";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Visible = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // lb_Score
            // 
            lb_Score.AutoSize = true;
            lb_Score.BackColor = System.Drawing.Color.Transparent;
            lb_Score.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Score.ForeColor = System.Drawing.Color.Red;
            lb_Score.Location = new System.Drawing.Point(189, 150);
            lb_Score.Name = "lb_Score";
            lb_Score.Size = new System.Drawing.Size(22, 32);
            lb_Score.TabIndex = 4;
            lb_Score.Text = " ";
            // 
            // lb_Chance
            // 
            lb_Chance.AutoSize = true;
            lb_Chance.BackColor = System.Drawing.Color.Transparent;
            lb_Chance.Font = new System.Drawing.Font("Galmuri9 Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Chance.Location = new System.Drawing.Point(745, 10);
            lb_Chance.Name = "lb_Chance";
            lb_Chance.Size = new System.Drawing.Size(142, 25);
            lb_Chance.TabIndex = 5;
            lb_Chance.Text = "기회 3 / 3회";
            lb_Chance.Visible = false;
            // 
            // Game1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(884, 554);
            Controls.Add(lb_Chance);
            Controls.Add(lb_Score);
            Controls.Add(pb_Other);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Go);
            Controls.Add(btn_Back);
            Controls.Add(btn_Start);
            Controls.Add(label1);
            Controls.Add(btn_Paper);
            Controls.Add(btn_Rock);
            Controls.Add(btn_Siger);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Game1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Game1";
            ((System.ComponentModel.ISupportInitialize)pb_Other).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btn_Siger;
        private System.Windows.Forms.Button btn_Paper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Rock;
        private System.Windows.Forms.Button btn_Go;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pb_Other;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lb_Score;
        private System.Windows.Forms.Label lb_Chance;
    }
}