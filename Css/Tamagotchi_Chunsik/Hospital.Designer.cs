namespace Tamagotchi
{
    partial class Hospital
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
            lb_Result = new System.Windows.Forms.Label();
            pb_Doctor = new System.Windows.Forms.PictureBox();
            pb_User = new System.Windows.Forms.PictureBox();
            btn_Go_Livingroom = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1 = new System.Windows.Forms.Panel();
            btn_Do_Short = new System.Windows.Forms.Button();
            btn_Do_Phy = new System.Windows.Forms.Button();
            btn_Do_Drug = new System.Windows.Forms.Button();
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
            MoveText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pb_Doctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_User).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FaceState).BeginInit();
            SuspendLayout();
            // 
            // lb_Result
            // 
            lb_Result.AutoSize = true;
            lb_Result.BackColor = System.Drawing.Color.Transparent;
            lb_Result.Font = new System.Drawing.Font("Galmuri9 Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Result.ForeColor = System.Drawing.Color.DarkOrange;
            lb_Result.Location = new System.Drawing.Point(330, 133);
            lb_Result.Name = "lb_Result";
            lb_Result.Size = new System.Drawing.Size(111, 20);
            lb_Result.TabIndex = 0;
            lb_Result.Text = "닥터춘식병원";
            // 
            // pb_Doctor
            // 
            pb_Doctor.BackColor = System.Drawing.Color.Transparent;
            pb_Doctor.Image = Properties.Resources.닥터춘식;
            pb_Doctor.Location = new System.Drawing.Point(171, 208);
            pb_Doctor.Name = "pb_Doctor";
            pb_Doctor.Size = new System.Drawing.Size(150, 128);
            pb_Doctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pb_Doctor.TabIndex = 1;
            pb_Doctor.TabStop = false;
            // 
            // pb_User
            // 
            pb_User.BackColor = System.Drawing.Color.Transparent;
            pb_User.Image = Properties.Resources.병원에온춘식;
            pb_User.Location = new System.Drawing.Point(327, 200);
            pb_User.Name = "pb_User";
            pb_User.Size = new System.Drawing.Size(150, 128);
            pb_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pb_User.TabIndex = 2;
            pb_User.TabStop = false;
            // 
            // btn_Go_Livingroom
            // 
            btn_Go_Livingroom.BackColor = System.Drawing.Color.Transparent;
            btn_Go_Livingroom.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Go_Livingroom.Enabled = false;
            btn_Go_Livingroom.FlatAppearance.BorderSize = 0;
            btn_Go_Livingroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Go_Livingroom.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Go_Livingroom.Location = new System.Drawing.Point(761, 289);
            btn_Go_Livingroom.Name = "btn_Go_Livingroom";
            btn_Go_Livingroom.Size = new System.Drawing.Size(36, 39);
            btn_Go_Livingroom.TabIndex = 4;
            btn_Go_Livingroom.Text = "▶";
            btn_Go_Livingroom.UseVisualStyleBackColor = false;
            btn_Go_Livingroom.Visible = false;
            btn_Go_Livingroom.Click += btn_Go_Livingroom_Click;
            btn_Go_Livingroom.MouseHover += btn_Go_Livingroom_MouseHover;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(btn_Do_Short);
            panel1.Controls.Add(btn_Do_Phy);
            panel1.Controls.Add(btn_Do_Drug);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 520);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 80);
            panel1.TabIndex = 5;
            // 
            // btn_Do_Short
            // 
            btn_Do_Short.BackColor = System.Drawing.Color.Transparent;
            btn_Do_Short.BackgroundImage = Properties.Resources.행동버튼;
            btn_Do_Short.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Do_Short.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Do_Short.Dock = System.Windows.Forms.DockStyle.Left;
            btn_Do_Short.FlatAppearance.BorderSize = 0;
            btn_Do_Short.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Do_Short.Font = new System.Drawing.Font("Galmuri9 Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Do_Short.ForeColor = System.Drawing.Color.Black;
            btn_Do_Short.Location = new System.Drawing.Point(264, 0);
            btn_Do_Short.Name = "btn_Do_Short";
            btn_Do_Short.Size = new System.Drawing.Size(131, 80);
            btn_Do_Short.TabIndex = 0;
            btn_Do_Short.Text = "주사맞기";
            btn_Do_Short.UseVisualStyleBackColor = false;
            btn_Do_Short.Click += btn_Do_Short_Click;
            btn_Do_Short.MouseDown += btn_Do_Short_MouseDown;
            btn_Do_Short.MouseUp += btn_Do_Short_MouseUp;
            // 
            // btn_Do_Phy
            // 
            btn_Do_Phy.BackColor = System.Drawing.Color.Transparent;
            btn_Do_Phy.BackgroundImage = Properties.Resources.행동버튼;
            btn_Do_Phy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Do_Phy.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Do_Phy.Dock = System.Windows.Forms.DockStyle.Left;
            btn_Do_Phy.FlatAppearance.BorderSize = 0;
            btn_Do_Phy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Do_Phy.Font = new System.Drawing.Font("Galmuri9 Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Do_Phy.ForeColor = System.Drawing.Color.Black;
            btn_Do_Phy.Location = new System.Drawing.Point(133, 0);
            btn_Do_Phy.Name = "btn_Do_Phy";
            btn_Do_Phy.Size = new System.Drawing.Size(131, 80);
            btn_Do_Phy.TabIndex = 0;
            btn_Do_Phy.Text = "물리 치료";
            btn_Do_Phy.UseVisualStyleBackColor = false;
            btn_Do_Phy.Click += btn_Do_Phy_Click;
            btn_Do_Phy.MouseDown += btn_Do_Phy_MouseDown;
            btn_Do_Phy.MouseUp += btn_Do_Phy_MouseUp;
            // 
            // btn_Do_Drug
            // 
            btn_Do_Drug.BackColor = System.Drawing.Color.Transparent;
            btn_Do_Drug.BackgroundImage = Properties.Resources.행동버튼;
            btn_Do_Drug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_Do_Drug.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Do_Drug.Dock = System.Windows.Forms.DockStyle.Left;
            btn_Do_Drug.FlatAppearance.BorderSize = 0;
            btn_Do_Drug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Do_Drug.Font = new System.Drawing.Font("Galmuri9 Regular", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Do_Drug.ForeColor = System.Drawing.Color.Black;
            btn_Do_Drug.Location = new System.Drawing.Point(0, 0);
            btn_Do_Drug.Name = "btn_Do_Drug";
            btn_Do_Drug.Size = new System.Drawing.Size(133, 80);
            btn_Do_Drug.TabIndex = 0;
            btn_Do_Drug.Text = "약처방 받기";
            btn_Do_Drug.UseVisualStyleBackColor = false;
            btn_Do_Drug.Click += btn_Do_Drug_Click;
            btn_Do_Drug.MouseDown += btn_Do_Drug_MouseDown;
            btn_Do_Drug.MouseUp += btn_Do_Drug_MouseUp;
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
            panel2.TabIndex = 6;
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
            // MoveText
            // 
            MoveText.AutoSize = true;
            MoveText.BackColor = System.Drawing.Color.Transparent;
            MoveText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            MoveText.Font = new System.Drawing.Font("Galmuri9 Regular", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            MoveText.Location = new System.Drawing.Point(697, 291);
            MoveText.Name = "MoveText";
            MoveText.Size = new System.Drawing.Size(71, 33);
            MoveText.TabIndex = 6;
            MoveText.Text = "거실";
            // 
            // Hospital
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.병원;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 600);
            Controls.Add(btn_Go_Livingroom);
            Controls.Add(MoveText);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pb_User);
            Controls.Add(pb_Doctor);
            Controls.Add(lb_Result);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Hospital";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Hospital";
            Load += Hospital_Load;
            MouseHover += Hospital_MouseHover;
            ((System.ComponentModel.ISupportInitialize)pb_Doctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_User).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FaceState).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.PictureBox pb_Doctor;
        private System.Windows.Forms.PictureBox pb_User;
        private System.Windows.Forms.Button btn_Go_Livingroom;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Do_Short;
        private System.Windows.Forms.Button btn_Do_Phy;
        private System.Windows.Forms.Button btn_Do_Drug;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_Limit;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ProgressBar pgb_Day;
        public System.Windows.Forms.ProgressBar pgb_Full;
        public System.Windows.Forms.Label Level;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ProgressBar pgb_Clean;
        public System.Windows.Forms.PictureBox FaceState;
        public System.Windows.Forms.ProgressBar pgb_Feel;
        private System.Windows.Forms.Label MoveText;
    }
}