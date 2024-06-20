using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace Tamagotchi
{
    public partial class Start : Form
    {

        Save save;
        WindowsMediaPlayer wmp;

        public Start()
        {
            InitializeComponent();
            save = new Save();

            timer1.Interval = 1000;
        }
        static int cnt = 0;

        private void btn_start_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Opacity = 0;
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt++;
            if (cnt == 1)
            {
                timer1.Stop();
                SpeechBubble.Visible = false;
                Speech.Visible = false;
                cnt = 0;
                timer2.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            cnt++;
            if (cnt == 2)
            {
                timer2.Stop();
                SpeechBubble.Visible = true;
                Speech.Visible = true;
                cnt = 0;
                timer1.Start();
            }
        }

        private void btn_start_MouseDown(object sender, MouseEventArgs e)
        {
            btn_start.BackgroundImage = Properties.Resources.시작_;
        }

        private void btn_start_MouseUp(object sender, MouseEventArgs e)
        {
            btn_start.BackgroundImage = Properties.Resources.시작;
        }

        private void btn_Quit_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Quit.BackgroundImage = Properties.Resources.종료_;
        }

        private void btn_Quit_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Quit.BackgroundImage = Properties.Resources.종료;

        }

        private void Start_Load(object sender, EventArgs e)
        {
            Save.Page = 0;

            wmp = new WindowsMediaPlayer();
            wmp.settings.setMode("loop", true);
            wmp.URL = @"C:\Users\cjfgh\OneDrive\바탕 화면\Tamagotchi (1)\bgm.mp3";
            wmp.controls.play();

            timer1.Start();

        }

        
    }
}
