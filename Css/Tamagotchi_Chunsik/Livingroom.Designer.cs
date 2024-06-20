namespace Tamagotchi
{
    partial class Livingroom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new System.Windows.Forms.Panel();
            btn_Cleaning = new System.Windows.Forms.Button();
            btn_Exercise = new System.Windows.Forms.Button();
            btn_Smartphone = new System.Windows.Forms.Button();
            btn_Go_Right = new System.Windows.Forms.Button();
            btn_Go_Left = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            lb_Limit = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            lb_Name = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            pgb_Day = new System.Windows.Forms.ProgressBar();
            pgb_Full = new System.Windows.Forms.ProgressBar();
            Level = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pgb_Clean = new System.Windows.Forms.ProgressBar();
            FaceState = new System.Windows.Forms.PictureBox();
            pgb_Feel = new System.Windows.Forms.ProgressBar();
            pb_User = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btn_Go_Room = new System.Windows.Forms.Button();
            MoveText = new System.Windows.Forms.Label();
            MoveText2 = new System.Windows.Forms.Label();
            MoveText3 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FaceState).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_User).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(btn_Cleaning);
            panel1.Controls.Add(btn_Exercise);
            panel1.Controls.Add(btn_Smartphone);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 520);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 80);
            panel1.TabIndex = 0;
            // 
            // btn_Cleaning
            // 
            btn_Cleaning.BackColor = System.Drawing.Color.Transparent;
            btn_Cleaning.BackgroundImage = Properties.Resources.행동버튼;
            btn_Cleaning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Cleaning.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Cleaning.Dock = System.Windows.Forms.DockStyle.Left;
            btn_Cleaning.FlatAppearance.BorderSize = 0;
            btn_Cleaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Cleaning.Font = new System.Drawing.Font("Galmuri9 Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Cleaning.Location = new System.Drawing.Point(266, 0);
            btn_Cleaning.Name = "btn_Cleaning";
            btn_Cleaning.Size = new System.Drawing.Size(131, 80);
            btn_Cleaning.TabIndex = 0;
            btn_Cleaning.Text = "청소 하기";
            btn_Cleaning.UseVisualStyleBackColor = false;
            btn_Cleaning.Click += btn_Cleaning_Click;
            btn_Cleaning.MouseDown += btn_Cleaning_MouseDown;
            btn_Cleaning.MouseUp += btn_Cleaning_MouseUp;
            // 
            // btn_Exercise
            // 
            btn_Exercise.BackColor = System.Drawing.Color.Transparent;
            btn_Exercise.BackgroundImage = Properties.Resources.행동버튼;
            btn_Exercise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Exercise.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Exercise.Dock = System.Windows.Forms.DockStyle.Left;
            btn_Exercise.FlatAppearance.BorderSize = 0;
            btn_Exercise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Exercise.Font = new System.Drawing.Font("Galmuri9 Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Exercise.Location = new System.Drawing.Point(135, 0);
            btn_Exercise.Name = "btn_Exercise";
            btn_Exercise.Size = new System.Drawing.Size(131, 80);
            btn_Exercise.TabIndex = 0;
            btn_Exercise.Text = "운동 하기";
            btn_Exercise.UseVisualStyleBackColor = false;
            btn_Exercise.Click += btn_Exercise_Click;
            btn_Exercise.MouseDown += btn_Exercise_MouseDown;
            btn_Exercise.MouseUp += btn_Exercise_MouseUp;
            // 
            // btn_Smartphone
            // 
            btn_Smartphone.BackColor = System.Drawing.Color.Transparent;
            btn_Smartphone.BackgroundImage = Properties.Resources.행동버튼;
            btn_Smartphone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Smartphone.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Smartphone.Dock = System.Windows.Forms.DockStyle.Left;
            btn_Smartphone.FlatAppearance.BorderSize = 0;
            btn_Smartphone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Smartphone.Font = new System.Drawing.Font("Galmuri9 Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Smartphone.Location = new System.Drawing.Point(0, 0);
            btn_Smartphone.Name = "btn_Smartphone";
            btn_Smartphone.Size = new System.Drawing.Size(135, 80);
            btn_Smartphone.TabIndex = 0;
            btn_Smartphone.Text = "휴대폰 하기";
            btn_Smartphone.UseVisualStyleBackColor = false;
            btn_Smartphone.Click += btn_Smartphone_Click;
            btn_Smartphone.MouseDown += btn_Smartphone_MouseDown;
            btn_Smartphone.MouseUp += btn_Smartphone_MouseUp;
            // 
            // btn_Go_Right
            // 
            btn_Go_Right.BackColor = System.Drawing.Color.Transparent;
            btn_Go_Right.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Go_Right.FlatAppearance.BorderSize = 0;
            btn_Go_Right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Go_Right.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Go_Right.Location = new System.Drawing.Point(388, 1);
            btn_Go_Right.Name = "btn_Go_Right";
            btn_Go_Right.Size = new System.Drawing.Size(36, 39);
            btn_Go_Right.TabIndex = 1;
            btn_Go_Right.Text = "▲";
            btn_Go_Right.UseVisualStyleBackColor = false;
            btn_Go_Right.Click += btn_Go_Right_Click;
            btn_Go_Right.MouseHover += btn_Go_Right_MouseHover;
            // 
            // btn_Go_Left
            // 
            btn_Go_Left.BackColor = System.Drawing.Color.Transparent;
            btn_Go_Left.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Go_Left.FlatAppearance.BorderSize = 0;
            btn_Go_Left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Go_Left.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Go_Left.Location = new System.Drawing.Point(12, 285);
            btn_Go_Left.Name = "btn_Go_Left";
            btn_Go_Left.Size = new System.Drawing.Size(36, 39);
            btn_Go_Left.TabIndex = 1;
            btn_Go_Left.Text = "◀";
            btn_Go_Left.UseVisualStyleBackColor = false;
            btn_Go_Left.Click += btn_Go_Left_Click;
            btn_Go_Left.MouseHover += btn_Go_Left_MouseHover;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.상태창_배경;
            panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel2.Controls.Add(lb_Limit);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lb_Name);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pgb_Day);
            panel2.Controls.Add(pgb_Full);
            panel2.Controls.Add(Level);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pgb_Clean);
            panel2.Controls.Add(FaceState);
            panel2.Controls.Add(pgb_Feel);
            panel2.Location = new System.Drawing.Point(560, 0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(240, 170);
            panel2.TabIndex = 2;
            // 
            // lb_Limit
            // 
            lb_Limit.AutoSize = true;
            lb_Limit.BackColor = System.Drawing.Color.Silver;
            lb_Limit.Font = new System.Drawing.Font("Galmuri9 Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Limit.ForeColor = System.Drawing.Color.Black;
            lb_Limit.Location = new System.Drawing.Point(144, 132);
            lb_Limit.Name = "lb_Limit";
            lb_Limit.Size = new System.Drawing.Size(74, 13);
            lb_Limit.TabIndex = 3;
            lb_Limit.Text = "클릭  0 / 5회";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Galmuri9 Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(25, 59);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(37, 13);
            label7.TabIndex = 2;
            label7.Text = "상태 :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Galmuri9 Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.DodgerBlue;
            label6.Location = new System.Drawing.Point(62, 59);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(29, 13);
            label6.TabIndex = 2;
            label6.Text = "좋음";
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.BackColor = System.Drawing.Color.Transparent;
            lb_Name.Font = new System.Drawing.Font("Galmuri9 Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Name.ForeColor = System.Drawing.Color.Black;
            lb_Name.Location = new System.Drawing.Point(63, 44);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new System.Drawing.Size(40, 13);
            lb_Name.TabIndex = 2;
            lb_Name.Text = "박춘식";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Galmuri9 Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(25, 42);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 13);
            label2.TabIndex = 2;
            label2.Text = "이름 :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Galmuri9 Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(19, 131);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(41, 13);
            label9.TabIndex = 2;
            label9.Text = "D-Day";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Galmuri9 Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(20, 112);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 13);
            label5.TabIndex = 2;
            label5.Text = "배부름";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Galmuri9 Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(25, 95);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(29, 13);
            label4.TabIndex = 2;
            label4.Text = "건강";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Galmuri9 Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(25, 78);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 13);
            label3.TabIndex = 2;
            label3.Text = "기분";
            // 
            // pgb_Day
            // 
            pgb_Day.ForeColor = System.Drawing.Color.LimeGreen;
            pgb_Day.Location = new System.Drawing.Point(65, 133);
            pgb_Day.Maximum = 7;
            pgb_Day.Name = "pgb_Day";
            pgb_Day.Size = new System.Drawing.Size(75, 13);
            pgb_Day.Step = 1;
            pgb_Day.TabIndex = 0;
            pgb_Day.Value = 1;
            // 
            // pgb_Full
            // 
            pgb_Full.ForeColor = System.Drawing.Color.SteelBlue;
            pgb_Full.Location = new System.Drawing.Point(65, 114);
            pgb_Full.Maximum = 105;
            pgb_Full.Name = "pgb_Full";
            pgb_Full.Size = new System.Drawing.Size(75, 13);
            pgb_Full.TabIndex = 0;
            pgb_Full.Value = 30;
            // 
            // Level
            // 
            Level.AutoSize = true;
            Level.BackColor = System.Drawing.Color.Transparent;
            Level.Font = new System.Drawing.Font("Galmuri9 Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Level.ForeColor = System.Drawing.Color.Black;
            Level.Location = new System.Drawing.Point(194, 114);
            Level.Name = "Level";
            Level.Size = new System.Drawing.Size(11, 13);
            Level.TabIndex = 2;
            Level.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Galmuri9 Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(156, 114);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(37, 13);
            label1.TabIndex = 2;
            label1.Text = "Level";
            // 
            // pgb_Clean
            // 
            pgb_Clean.ForeColor = System.Drawing.Color.SteelBlue;
            pgb_Clean.Location = new System.Drawing.Point(65, 97);
            pgb_Clean.Maximum = 105;
            pgb_Clean.Name = "pgb_Clean";
            pgb_Clean.Size = new System.Drawing.Size(75, 13);
            pgb_Clean.TabIndex = 0;
            pgb_Clean.Value = 30;
            // 
            // FaceState
            // 
            FaceState.Image = Properties.Resources.기본얼굴;
            FaceState.Location = new System.Drawing.Point(149, 40);
            FaceState.Name = "FaceState";
            FaceState.Size = new System.Drawing.Size(69, 73);
            FaceState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            FaceState.TabIndex = 1;
            FaceState.TabStop = false;
            // 
            // pgb_Feel
            // 
            pgb_Feel.ForeColor = System.Drawing.Color.SteelBlue;
            pgb_Feel.Location = new System.Drawing.Point(65, 80);
            pgb_Feel.Maximum = 105;
            pgb_Feel.Name = "pgb_Feel";
            pgb_Feel.Size = new System.Drawing.Size(75, 13);
            pgb_Feel.TabIndex = 0;
            pgb_Feel.Value = 30;
            // 
            // pb_User
            // 
            pb_User.BackColor = System.Drawing.Color.Transparent;
            pb_User.Image = Properties.Resources.기본상태;
            pb_User.Location = new System.Drawing.Point(98, 254);
            pb_User.Name = "pb_User";
            pb_User.Size = new System.Drawing.Size(150, 128);
            pb_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pb_User.TabIndex = 3;
            pb_User.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btn_Go_Room
            // 
            btn_Go_Room.BackColor = System.Drawing.Color.Transparent;
            btn_Go_Room.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Go_Room.FlatAppearance.BorderSize = 0;
            btn_Go_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Go_Room.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Go_Room.Location = new System.Drawing.Point(752, 285);
            btn_Go_Room.Name = "btn_Go_Room";
            btn_Go_Room.Size = new System.Drawing.Size(36, 39);
            btn_Go_Room.TabIndex = 4;
            btn_Go_Room.Text = "▶";
            btn_Go_Room.UseVisualStyleBackColor = false;
            btn_Go_Room.Click += btn_Go_Room_Click;
            btn_Go_Room.MouseHover += btn_Go_Room_MouseHover;
            // 
            // MoveText
            // 
            MoveText.AutoSize = true;
            MoveText.BackColor = System.Drawing.Color.Transparent;
            MoveText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MoveText.Font = new System.Drawing.Font("Galmuri9 Regular", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            MoveText.Location = new System.Drawing.Point(42, 287);
            MoveText.Name = "MoveText";
            MoveText.Size = new System.Drawing.Size(71, 33);
            MoveText.TabIndex = 6;
            MoveText.Text = "욕실";
            MoveText.Visible = false;
            // 
            // MoveText2
            // 
            MoveText2.AutoSize = true;
            MoveText2.BackColor = System.Drawing.Color.Transparent;
            MoveText2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MoveText2.Font = new System.Drawing.Font("Galmuri9 Regular", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            MoveText2.Location = new System.Drawing.Point(716, 287);
            MoveText2.Name = "MoveText2";
            MoveText2.Size = new System.Drawing.Size(43, 33);
            MoveText2.TabIndex = 7;
            MoveText2.Text = "방";
            MoveText2.Visible = false;
            // 
            // MoveText3
            // 
            MoveText3.AutoSize = true;
            MoveText3.BackColor = System.Drawing.Color.Transparent;
            MoveText3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MoveText3.Font = new System.Drawing.Font("Galmuri9 Regular", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            MoveText3.Location = new System.Drawing.Point(368, 32);
            MoveText3.Name = "MoveText3";
            MoveText3.Size = new System.Drawing.Size(71, 33);
            MoveText3.TabIndex = 7;
            MoveText3.Text = "부엌";
            MoveText3.Visible = false;
            // 
            // Livingroom
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.거실배경;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 600);
            Controls.Add(MoveText3);
            Controls.Add(MoveText2);
            Controls.Add(MoveText);
            Controls.Add(btn_Go_Room);
            Controls.Add(pb_User);
            Controls.Add(panel2);
            Controls.Add(btn_Go_Left);
            Controls.Add(btn_Go_Right);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Livingroom";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Kitchen";
            Load += Livingroom_Load;
            MouseHover += Livingroom_MouseHover;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FaceState).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_User).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Smartphone;
        private System.Windows.Forms.Button btn_Exercise;
        private System.Windows.Forms.Button btn_Cleaning;
        private System.Windows.Forms.Button btn_Go_Right;
        private System.Windows.Forms.Button btn_Go_Left;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pb_User;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ProgressBar pgb_Full;
        public System.Windows.Forms.ProgressBar pgb_Clean;
        public System.Windows.Forms.ProgressBar pgb_Feel;
        public System.Windows.Forms.ProgressBar pgb_Day;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Go_Room;
        public System.Windows.Forms.PictureBox FaceState;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label Level;
        private System.Windows.Forms.Label lb_Limit;
        private System.Windows.Forms.Label MoveText;
        private System.Windows.Forms.Label MoveText2;
        private System.Windows.Forms.Label MoveText3;
    }
}
