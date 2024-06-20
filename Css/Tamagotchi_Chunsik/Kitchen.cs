using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagotchi
{
    public partial class Kitchen : Form
    {
        DoSomething dosome;
        //Save save;

        public static Kitchen kitchen;
        public Kitchen()
        {
            kitchen = this;
            InitializeComponent();
            dosome = new DoSomething();
            //save = new Save();
        }

        int count = 0;
        public static int Btn_Num = 0;



        private void btn_Do_Eat_Sweetpotato_Click(object sender, EventArgs e)
        {
            pb_User.Image = Properties.Resources.고구마_먹고_배부른_춘식이;
            Btn_Num = 1;

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void btn_Do_Eat_tangerines_Click(object sender, EventArgs e)
        {
            pb_User.Image = Properties.Resources.귤먹기;
            Btn_Num = 2;

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void btn_Do_Eat_Popcorn_Click(object sender, EventArgs e)
        {
            pb_User.Image = Properties.Resources.팝콘먹기;
            Btn_Num = 3;

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void btn_Go_Left_Click(object sender, EventArgs e)//부엌에서 거실로 이동하는 버튼
        {
            Save.Save_pgb();

            Livingroom livingroom = new Livingroom();//거실 생성자 만들기
            livingroom.Show();
            this.Close();
        }

        private void btn_Go_Right_Click(object sender, EventArgs e)
        {
            Save.Save_pgb();

            Bathroom bathroom = new Bathroom();
            bathroom.Show();
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
                    case 1://1. 고구마
                        {
                            dosome.Feel_Up();
                            dosome.Feel_Up();
                            dosome.Full_Up();
                            dosome.Full_Up();
                            dosome.Clean_Down();


                            //매개변수에 넣어서 object로 박싱한다.
                            //메소드 안에서 int형으로 언박싱해서
                            //색깔 변화에 대한 동작을 한다.
                            break;
                        }
                    case 2://2. 귤
                        {
                            dosome.Feel_Down();
                            dosome.Full_Up();
                            dosome.Full_Up();
                            dosome.Clean_Up();
                            dosome.Clean_Up();

                            break;
                        }
                    case 3://3. 팝콘
                        {
                            dosome.Feel_Up();
                            dosome.Feel_Up();
                            dosome.Full_Up();
                            dosome.Full_Up();
                            dosome.Clean_Down();

                            break;
                        }
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

        private void Kitchen_Load(object sender, EventArgs e)
        {
            Save.Page = 2;

            Save.Load_pgb();//값 불러오기
            Btn_Num = 1;
            dosome.Change_Color(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);
            dosome.Face_Change(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);
            label6.Text = DoSomething.State;
            Level.Text = Livingroom.Level_Cnt.ToString();
            pgb_Day.Value = Livingroom.Day_Cnt;
            lb_Limit.Text = Livingroom.Click_Cnt.ToString("클릭 #0 / 8회");
            lb_Name.Text = Naming.user_nickname;




        }

        private void btn_Do_Eat_Sweetpotato_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Do_Eat_Sweetpotato.BackgroundImage = Properties.Resources.행동버튼_;

        }

        private void btn_Do_Eat_tangerines_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Do_Eat_tangerines.BackgroundImage = Properties.Resources.행동버튼_;
        }

        private void btn_Do_Eat_Popcorn_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Do_Eat_Popcorn.BackgroundImage = Properties.Resources.행동버튼_;
        }

        private void btn_Do_Eat_Sweetpotato_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Do_Eat_Sweetpotato.BackgroundImage = Properties.Resources.행동버튼;
        }

        private void btn_Do_Eat_tangerines_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Do_Eat_tangerines.BackgroundImage = Properties.Resources.행동버튼;
        }

        private void btn_Do_Eat_Popcorn_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Do_Eat_Popcorn.BackgroundImage = Properties.Resources.행동버튼;
        }
    }
}
