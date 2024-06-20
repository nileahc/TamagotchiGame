namespace Tamagotchi
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new System.Windows.Forms.Label();
            tb_ID = new System.Windows.Forms.TextBox();
            tb_Password = new System.Windows.Forms.TextBox();
            btn_Login = new System.Windows.Forms.Button();
            btn_Join_membership = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            btn_Exit = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.Info;
            label1.Font = new System.Drawing.Font("Galmuri9 Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.WindowText;
            label1.Location = new System.Drawing.Point(105, 112);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "로그인";
            // 
            // tb_ID
            // 
            tb_ID.Font = new System.Drawing.Font("Galmuri9 Regular", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_ID.Location = new System.Drawing.Point(49, 161);
            tb_ID.Name = "tb_ID";
            tb_ID.Size = new System.Drawing.Size(132, 22);
            tb_ID.TabIndex = 0;
            tb_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Password
            // 
            tb_Password.Font = new System.Drawing.Font("Galmuri9 Regular", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tb_Password.Location = new System.Drawing.Point(49, 190);
            tb_Password.Name = "tb_Password";
            tb_Password.PasswordChar = '*';
            tb_Password.Size = new System.Drawing.Size(132, 22);
            tb_Password.TabIndex = 1;
            tb_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Login
            // 
            btn_Login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Login.Font = new System.Drawing.Font("Galmuri9 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Login.ForeColor = System.Drawing.SystemColors.HighlightText;
            btn_Login.Location = new System.Drawing.Point(187, 161);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new System.Drawing.Size(62, 52);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "확인";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Join_membership
            // 
            btn_Join_membership.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btn_Join_membership.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Join_membership.FlatAppearance.BorderSize = 0;
            btn_Join_membership.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Join_membership.Font = new System.Drawing.Font("Galmuri9 Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_Join_membership.ForeColor = System.Drawing.SystemColors.WindowText;
            btn_Join_membership.Location = new System.Drawing.Point(49, 248);
            btn_Join_membership.Name = "btn_Join_membership";
            btn_Join_membership.Size = new System.Drawing.Size(190, 23);
            btn_Join_membership.TabIndex = 2;
            btn_Join_membership.Text = "회원가입";
            btn_Join_membership.UseVisualStyleBackColor = false;
            btn_Join_membership.Click += btn_Join_membership_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            panel1.Location = new System.Drawing.Point(32, 229);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(230, 4);
            panel1.TabIndex = 3;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = System.Drawing.Color.FromArgb(148, 109, 147);
            btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            btn_Exit.FlatAppearance.BorderSize = 0;
            btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Exit.Font = new System.Drawing.Font("Galmuri9 Regular", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Exit.ForeColor = System.Drawing.SystemColors.HighlightText;
            btn_Exit.Location = new System.Drawing.Point(49, 351);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new System.Drawing.Size(190, 62);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Galmuri9 Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(181, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(61, 13);
            label2.TabIndex = 4;
            label2.Text = "관리자 ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Galmuri9 Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(245, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 13);
            label3.TabIndex = 4;
            label3.Text = "1234";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Galmuri9 Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(245, 24);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(33, 13);
            label4.TabIndex = 4;
            label4.Text = "1234";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Galmuri9 Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(179, 24);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 13);
            label5.TabIndex = 4;
            label5.Text = "Password :";
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(292, 518);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Join_membership);
            Controls.Add(btn_Login);
            Controls.Add(tb_Password);
            Controls.Add(tb_ID);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Join_membership;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}