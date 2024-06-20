namespace Tamagotchi
{
    partial class Naming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Naming));
            label1 = new System.Windows.Forms.Label();
            tb_Name = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Galmuri9 Regular", 21.7499962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(186, 169);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(431, 35);
            label1.TabIndex = 0;
            label1.Text = "춘식이의 이름을 작성해주세요";
            // 
            // tb_Name
            // 
            tb_Name.Font = new System.Drawing.Font("Galmuri9 Regular", 21.7499962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tb_Name.Location = new System.Drawing.Point(186, 242);
            tb_Name.Name = "tb_Name";
            tb_Name.Size = new System.Drawing.Size(414, 45);
            tb_Name.TabIndex = 1;
            tb_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Galmuri9 Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(186, 321);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(414, 57);
            button1.TabIndex = 2;
            button1.Text = "확인";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(321, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(130, 121);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Naming
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(253, 216, 136);
            ClientSize = new System.Drawing.Size(784, 561);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(tb_Name);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Naming";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Naming";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}