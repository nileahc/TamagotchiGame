using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagotchi
{
    public partial class Livingroom : Form
    {
        DoSomething dosome;
        //Save save;
        //----------------------------------------------
        public static Livingroom livingroom;


        public Livingroom()
        {
            livingroom = this;
            InitializeComponent();
            dosome = new DoSomething();
            //save = new Save();
        }

        int count = 0;
        public static int Btn_Num = 0;
        public static int Level_Cnt = 1;
        public static int Click_Cnt = 0;
        public static int Day_Cnt = 1;

        

        private void btn_Go_Left_Click(object sender, EventArgs e)//화장실로 이동하는 버튼(왼쪽버튼)
        {

            Save.Save_pgb(); //pbg값 저장하기
                             //화장실로 이동하기
            Bathroom bathroom = new Bathroom();//화장실 생성자 만들기


            bathroom.Show();//생성자를 통해 화장실 열기
            this.Close();

        }

        private void btn_Go_Right_Click(object sender, EventArgs e)//부엌으로 이동하는 버튼
        {
            Save.Save_pgb();
            //부엌으로 이동하기
            Kitchen kitchen = new Kitchen();//부엌 생성자 만들기

            kitchen.Show();//생성자를 통해 부엌 열기
            this.Close();

        }

        private void btn_Go_Room_Click(object sender, EventArgs e)//방으로 이동하는 버튼

        {
            Save.Save_pgb();
            Room room = new Room();//부엌 생성자 만들기

            room.Show();//생성자를 통해 부엌 열기
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
                    case 1://1. 스마트폰
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
                    case 2://2. 운동하기
                        {
                            dosome.Feel_Up();
                            dosome.Feel_Up();
                            dosome.Full_Down();
                            dosome.Clean_Down();

                            break;
                        }
                    case 3://3. 청소하기
                        {
                            dosome.Feel_Down();
                            dosome.Full_Down();
                            dosome.Clean_Up();
                            dosome.Clean_Up();

                            break;
                        }
                }
                dosome.Change_Color(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);
                dosome.Face_Change(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);
                //dosome.Level_Up(pgb_Feel.Value, pgb_Full.Value);
                Btn_Num = 0; //다시 초기화한다.
                if (pgb_Feel.Value - dosome.GetRandom() <= 0 || pgb_Full.Value - dosome.GetRandom() <= 0 || pgb_Clean.Value - dosome.GetRandom() <= 0)
                {
                    Ending_No ending = new Ending_No();
                    ending.Show();
                    this.Close();
                }
                pb_User.Image = Properties.Resources.기본상태;
                label6.Text = DoSomething.State;
                Level.Text = Level_Cnt.ToString();
                Click_Cnt++;
                lb_Limit.Text = Click_Cnt.ToString("클릭 #0 / 8회");
                if (Click_Cnt == 8)
                {
                    Save.Save_pgb();
                    dosome.Night_Time();
                    this.Close();
                }


            }
            count++;
        }

        private void btn_Smartphone_Click(object sender, EventArgs e) //스마트폰 보기 버튼 클릭
        {
            pb_User.Image = Properties.Resources.스마트폰보기;
            Btn_Num = 1;

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void btn_Exercise_Click(object sender, EventArgs e)
        {
            pb_User.Image = Properties.Resources.운동하기;
            Btn_Num = 2;

            timer1.Interval = 1000;
            timer1.Start();
        }

        private void btn_Cleaning_Click(object sender, EventArgs e)
        {
            pb_User.Image = Properties.Resources.청소하기;
            Btn_Num = 3;


            timer1.Interval = 1000;
            timer1.Start();
        }

        private void Livingroom_Load(object sender, EventArgs e)
        {
            Save.Page = 1;

            Save.Load_pgb();//저장된 값을 불러온다. 처음 : 초기값 30
            Btn_Num = 1;
            dosome.Change_Color(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);
            dosome.Face_Change(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);
            label6.Text = DoSomething.State;
            Level.Text = Level_Cnt.ToString();
            pgb_Day.Value = Day_Cnt;
            lb_Limit.Text = Click_Cnt.ToString("클릭 #0 / 8회");
            lb_Name.Text = Naming.user_nickname;

            //춘식이 이름 텍스트에 문자열 추가하기


            //페이지가 로드될 때 이전에 변했던 게이지 색을 유지한다.-> 다시 색깔을 판별한다.
        }

        private void btn_Go_Left_MouseHover(object sender, EventArgs e)
        {
            MoveText.Visible = true;
        }

        private void btn_Go_Right_MouseHover(object sender, EventArgs e)
        {
            MoveText3.Visible = true;
        }

        private void btn_Go_Room_MouseHover(object sender, EventArgs e)
        {
            MoveText2.Visible = true;
        }

        private void Livingroom_MouseHover(object sender, EventArgs e)
        {
            if (MoveText.Visible == true)
                MoveText.Visible = false;
            else if (MoveText2.Visible == true)
                MoveText2.Visible = false;
            else if (MoveText3.Visible == true)
                MoveText3.Visible = false;
        }

        private void btn_Smartphone_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Smartphone.BackgroundImage = Properties.Resources.행동버튼_;
        }

        private void btn_Exercise_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Exercise.BackgroundImage = Properties.Resources.행동버튼_;
        }

        private void btn_Cleaning_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Cleaning.BackgroundImage = Properties.Resources.행동버튼_;
        }

        private void btn_Smartphone_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Smartphone.BackgroundImage = Properties.Resources.행동버튼;

        }

        private void btn_Exercise_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Exercise.BackgroundImage = Properties.Resources.행동버튼;

        }

        private void btn_Cleaning_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Cleaning.BackgroundImage = Properties.Resources.행동버튼;

        }
    }
}

