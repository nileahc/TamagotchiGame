using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Tamagotchi
{
    public partial class Room : Form
    {
        DoSomething dosome;

        public static Room room;


        public Room()
        {
            room = this;
            InitializeComponent();
            dosome = new DoSomething();
        }

        int count = 0;
        public static int Btn_Num = 0;


        private void btn_Do_Study_Click(object sender, EventArgs e)
        {
            pb_User.Image = Properties.Resources.공부하기;
            Btn_Num = 1;

            timer1.Interval = 1000;
            timer1.Start();

            //feel down, full down
        }

        private void btn_Do_Sleep_Click(object sender, EventArgs e)
        {
            pb_User.Image = Properties.Resources.낮잠;
            Btn_Num = 2;

            timer1.Interval = 1000;
            timer1.Start();
            //feel up

        }

        private void btn_Go_Left_Click(object sender, EventArgs e)
        {
            //거실로 이동하는 버튼이다.


        }

        private void btn_Go_Right_Click(object sender, EventArgs e)// 거실로 이동하는 버튼
        {
            Save.Save_pgb();
            Livingroom livingroom = new Livingroom();//거실 생성자 만들기

            livingroom.Show();

            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 1)
            {
                count = 0;
                timer1.Stop();
                switch (Btn_Num)      //버튼 1, 2, 3으로 나누었다.
                {
                    case 1://1. 공부하기
                        {
                            dosome.Feel_Up();
                            dosome.Feel_Up();
                            dosome.Full_Down();
                            dosome.Clean_Down();

                            //매개변수에 넣어서 object로 박싱한다.
                            //메소드 안에서 int형으로 언박싱해서
                            //색깔 변화에 대한 동작을 한다.
                            break;
                        }
                    case 2://2. 낮잠자기
                        {
                            dosome.Feel_Up();
                            dosome.Feel_Up();
                            dosome.Full_Down();
                            dosome.Clean_Down();
                            break;
                        }

                    default:
                        break;
                }
                dosome.Change_Color(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);
                dosome.Face_Change(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);

                Btn_Num = 0; //다시 초기화한다.
                if (pgb_Feel.Value - dosome.GetRandom() <= 0 || pgb_Full.Value - dosome.GetRandom() <= 0 || pgb_Clean.Value - dosome.GetRandom() <= 0)
                {
                    Ending_No ending = new Ending_No();
                    ending.Show();
                    this.Close();
                }
                pb_User.Image = Properties.Resources.기본상태;
                label6.Text = DoSomething.State;
                Level.Text = Livingroom.Level_Cnt.ToString();
                Livingroom.Click_Cnt++;
                lb_Limit.Text = Livingroom.Click_Cnt.ToString("클릭 #0 / 8회");

                if (Livingroom.Click_Cnt == 8)
                {
                    Save.Save_pgb();
                    dosome.Night_Time();
                    this.Close();
                }


            }
            count++;

        }

        private void Room_Load(object sender, EventArgs e)
        {
            Save.Page = 4;

            Save.Load_pgb();
            Btn_Num = 1;
            dosome.Change_Color(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);
            dosome.Face_Change(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);
            label6.Text = DoSomething.State;
            Level.Text = Livingroom.Level_Cnt.ToString();
            pgb_Day.Value = Livingroom.Day_Cnt;
            lb_Limit.Text = Livingroom.Click_Cnt.ToString("클릭 #0 /8회");
            lb_Name.Text = Naming.user_nickname;



        }

        private void btn_Do_Game_Click(object sender, EventArgs e)
        {
            Cargame cargame = new Cargame(this);
            cargame.StartPosition = FormStartPosition.Manual;
            cargame.Location = new Point(560, 216);
            cargame.ShowDialog();
            Btn_Num = 3;
            timer1.Interval = 1;
            timer1.Start();
            
        }

        private void btn_Do_Game2_Click(object sender, EventArgs e)
        {
            Game1 RSPgame = new Game1(this);
            RSPgame.StartPosition = FormStartPosition.Manual;
            RSPgame.Location = new Point(560, 216);
            RSPgame.ShowDialog();
            Btn_Num = 4;
            timer1.Interval = 1;
            timer1.Start();
            
        }

        private void btn_Go_Right_MouseHover(object sender, EventArgs e)
        {
            MoveText.Visible = true;
        }

        private void Room_MouseHover(object sender, EventArgs e)
        {
            MoveText.Visible = false;

        }

        private void btn_Do_Game2_MouseHover(object sender, EventArgs e)
        {
            //필요 없는 이벤트
        }

        private void btn_Do_Study_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Do_Study.BackgroundImage = Properties.Resources.행동버튼_;
        }

        private void btn_Do_Sleep_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Do_Sleep.BackgroundImage = Properties.Resources.행동버튼_;
        }

        private void btn_Do_Game_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Do_Game.BackgroundImage = Properties.Resources.행동버튼_;
        }

        private void btn_Do_Game2_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Do_Game2.BackgroundImage = Properties.Resources.행동버튼_;
        }

        private void btn_Do_Study_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Do_Study.BackgroundImage = Properties.Resources.행동버튼;
        }

        private void btn_Do_Sleep_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Do_Sleep.BackgroundImage = Properties.Resources.행동버튼;
        }

        private void btn_Do_Game_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Do_Game.BackgroundImage = Properties.Resources.행동버튼;
        }

        private void btn_Do_Game2_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Do_Game2.BackgroundImage = Properties.Resources.행동버튼;
        }
    }
}
