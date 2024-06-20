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
    public partial class Bathroom : Form
    {
        DoSomething dosome;
        //Save save;
        //-----------------------------------------
        public static Bathroom bathroom;
        public Bathroom()
        {
            bathroom = this;
            InitializeComponent();
            dosome = new DoSomething();
            //save = new Save();
        }

        int count = 0;
        public static int Btn_Num = 0;


        private void btn_Do_Ddong_Click(object sender, EventArgs e)
        {
            pb_User.Image = Properties.Resources.똥싸기;
            Btn_Num = 1;

            timer1.Interval = 1000;
            timer1.Start();
            //pb_User.Location = new System.Drawing.Point(570, 386);
            // Feel_up();Full_Down();Clean_down();

        }

        private void btn_Do_Wash_Hand_Click(object sender, EventArgs e)
        {
            if (Livingroom.Click_Cnt != 4) //4번 버튼 클릭 시 비눙이 등장 안함
                Soap_Event();
            pb_User.Image = Properties.Resources.손씻기;
            Btn_Num = 2;

            timer1.Interval = 1000;
            timer1.Start();
            // pb_User.Location = new System.Drawing.Point(36, 234);
            // Feel_Down();Full_Down();Clean_Up();

        }

        private void btn_Do_Wash_Body_Click(object sender, EventArgs e)
        {
            if (Livingroom.Click_Cnt != 4)
                Soap_Event();
            pb_User.Image = Properties.Resources.목욕하기;
            Btn_Num = 3;

            timer1.Interval = 1000;
            timer1.Start();
            // pb_User.Location = new System.Drawing.Point(460, 299);
            // Feel_Up();Full_Down();Clean_Up();

        }
        private void btn_Go_Left_Click(object sender, EventArgs e)
        {

        }

        private void btn_Go_Right_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 1)
            {
                count = 0;
                timer1.Stop();
                switch (Btn_Num)      //버튼 1, 2, 3으로 나누었다.
                {
                    case 1://1. 똥싸기
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
                    case 2://2. 손닦기
                        {
                            dosome.Feel_Down();
                            dosome.Full_Down();
                            dosome.Clean_Up();
                            dosome.Clean_Up();

                            break;
                        }
                    case 3://3. 목욕하기
                        {
                            dosome.Feel_Up();
                            dosome.Full_Down();
                            dosome.Clean_Up();
                            dosome.Clean_Up();

                            break;
                        }
                }
                dosome.Change_Color(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);
                dosome.Face_Change(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);
                //매개변수에 넣어서 object로 박싱한다.
                //메소드 안에서 int형으로 언박싱해서

                //색깔 변화에 대한 동작을 한다.
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

        private void btn_Go_Livingroom_Click(object sender, EventArgs e)
        {
            Save.Save_pgb();
            Livingroom livingroom = new Livingroom();//거실 생성자 만들기

            livingroom.Show();

            this.Close();

        }

        private void Bathroom_Load(object sender, EventArgs e)
        {

            Save.Page = 3;

            Save.Load_pgb();
            Btn_Num = 1;
            dosome.Change_Color(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);
            dosome.Face_Change(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);
            label6.Text = DoSomething.State;
            Level.Text = Livingroom.Level_Cnt.ToString();
            pgb_Day.Value = Livingroom.Day_Cnt;
            lb_Limit.Text = Livingroom.Click_Cnt.ToString("클릭 #0 / 8회");
            lb_Name.Text = Naming.user_nickname;




        }
        int Soap_count = 0;
        public int teleport_X()
        {
            Random R_X = new Random();
            return R_X.Next(0, 760);
        }
        public int teleport_Y()
        {
            Random R_Y = new Random();
            return R_Y.Next(0, 560);
        }
        public void Soap_Event()
        {
            timer2.Start();
            timer2.Interval = 1000;
            lb_Notice.Visible = true;
            lb_Soap_Time.Visible = true;
            pb_Soap.Location = new System.Drawing.Point(teleport_X(), teleport_Y());
            pb_Soap.Visible = true;
        }
        public void After_Soap_Event()  //비누 이벤트 초기화
        {
            timer2.Stop();
            pb_Soap.Visible = false;
            lb_Notice.Visible = false;
            lb_Soap_Time.Visible = false;
            Soap_count = 0;
            lb_Soap_Time.Text = "3";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pb_Soap.Location = new Point(teleport_X(), teleport_Y());
            Soap_count++;
            lb_Soap_Time.Text = (3 - Soap_count).ToString();
            if (Soap_count == 3)
            {
                After_Soap_Event();

                Save.Save_pgb();
                MessageBox.Show("춘식이가 비눙이를 밟아 넘어졌습니다."); //대신 Fell_Down(); Form_hospital
                Hospital hospital = new Hospital();//거실 생성자 만들기
                hospital.Show();
                this.Close();
            }

        }

        private void pb_Soap_Click(object sender, EventArgs e)
        {
            After_Soap_Event();

        }

        private void btn_Go_Livingroom_MouseHover(object sender, EventArgs e)
        {
            MoveText.Visible = true;
        }

        private void Bathroom_MouseHover(object sender, EventArgs e)
        {
            MoveText.Visible = false;

        }

        private void btn_Do_Ddong_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Do_Ddong.BackgroundImage = Properties.Resources.행동버튼_;
        }

        private void btn_Do_Wash_Hand_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Do_Wash_Hand.BackgroundImage = Properties.Resources.행동버튼_;
        }

        private void btn_Do_Wash_Body_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Do_Wash_Body.BackgroundImage = Properties.Resources.행동버튼_;
        }

        private void btn_Do_Ddong_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Do_Ddong.BackgroundImage = Properties.Resources.행동버튼;
        }

        private void btn_Do_Wash_Hand_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Do_Wash_Hand.BackgroundImage = Properties.Resources.행동버튼;
        }

        private void btn_Do_Wash_Body_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Do_Wash_Body.BackgroundImage = Properties.Resources.행동버튼;
        }
    }
}
