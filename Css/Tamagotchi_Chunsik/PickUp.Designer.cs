namespace Tamagotchi
{
    partial class PickUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickUp));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            lb_Question = new System.Windows.Forms.Label();
            btn_No = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            btn_Yes = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(12, 466);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(128, 122);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lb_Question);
            panel1.Controls.Add(btn_No);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_Yes);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new System.Drawing.Point(55, 73);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(676, 246);
            panel1.TabIndex = 2;
            // 
            // lb_Question
            // 
            lb_Question.AutoSize = true;
            lb_Question.BackColor = System.Drawing.SystemColors.Window;
            lb_Question.Font = new System.Drawing.Font("Galmuri9 Regular", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Question.Location = new System.Drawing.Point(78, 100);
            lb_Question.Name = "lb_Question";
            lb_Question.Size = new System.Drawing.Size(554, 38);
            lb_Question.TabIndex = 2;
            lb_Question.Text = "춘식이가 애처로운 눈빛을 보냅니다";
            // 
            // btn_No
            // 
            btn_No.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_No.Enabled = false;
            btn_No.FlatAppearance.BorderSize = 0;
            btn_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_No.Font = new System.Drawing.Font("Galmuri9 Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_No.Location = new System.Drawing.Point(357, 193);
            btn_No.Name = "btn_No";
            btn_No.Size = new System.Drawing.Size(78, 46);
            btn_No.TabIndex = 3;
            btn_No.Text = "No";
            btn_No.UseVisualStyleBackColor = true;
            btn_No.Visible = false;
            btn_No.Click += btn_No_Click;
            // 
            // button1
            // 
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Galmuri9 Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(556, 193);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(78, 46);
            button1.TabIndex = 3;
            button1.Text = "다음";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_Yes
            // 
            btn_Yes.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Yes.Enabled = false;
            btn_Yes.FlatAppearance.BorderSize = 0;
            btn_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Yes.Font = new System.Drawing.Font("Galmuri9 Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Yes.Location = new System.Drawing.Point(245, 193);
            btn_Yes.Name = "btn_Yes";
            btn_Yes.Size = new System.Drawing.Size(78, 46);
            btn_Yes.TabIndex = 3;
            btn_Yes.Text = "Yes";
            btn_Yes.UseVisualStyleBackColor = true;
            btn_Yes.Visible = false;
            btn_Yes.Click += btn_Yes_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(676, 246);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(270, 325);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(237, 190);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // PickUp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(253, 216, 136);
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 600);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "PickUp";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PickUp";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_Question;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.Button btn_Yes;
    }
}