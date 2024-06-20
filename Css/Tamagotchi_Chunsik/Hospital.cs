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
    public partial class Hospital : Form
    {
        DoSomething dosome;
        public static Hospital hospital;
        public Hospital()
        {
            hospital = this;
            InitializeComponent();
            dosome = new DoSomething();
        }


        int count = 0;

        public static int Btn_Num = 0;///////////////



        public int Quack_Event()
        {
            Random rand = new Random();
            return rand.Next(0, 7);
        }
        public void Quack()
        {
            pb_Doctor.Image = Properties.Resources.실수;
            pb_Doctor.Location = new Point(186, 197);
        }
        public void Doctor()
        {
            pb_Doctor.Image = Properties.Resources.닥터춘식;
            pb_Doctor.Location = new Point(171, 208);
        }
        public void Good()
        {
            pb_User.Image = Properties.Resources.오히려;
            pb_User.Location = new Point(341, 208);
        }
        public void Go_Livingroom()
        {
            Save.Save_pgb();
            Livingroom.Click_Cnt = 0;
            Livingroom livingroom = new Livingroom();//거실 생성자 만들기

            livingroom.Show();

            this.Close();
        }


        private void btn_Do_Drug_Click(object sender, EventArgs e) //약처방
        {
            if (Quack_Event() == 0)
            {
                Quack();//Feel_Up();Feel_Up();Clean_Up();Full_Down();
                pb_User.Image = Properties.Resources.헤롱;
                pb_User.Location = new Point(327, 208);
                lb_Result.Text = "약 처방 실패!";
                timer1.Interval = 1000;
                timer1.Start();

            }
            else
            {
                Doctor(); Good(); lb_Result.Text = "약 처방 성공!";

                Btn_Num = 1;

                timer1.Interval = 1000;
                timer1.Start();
            } //Feel_Down();Clean_Up();Full_up();
        }

        private void btn_Do_Phy_Click(object sender, EventArgs e)//물리치료
        {
            if (Quack_Event() == 1)
            {
                Quack(); pb_User.Image = Properties.Resources.로이더;
                pb_User.Location = new Point(332, 208);
                lb_Result.Text = "물리 치료 실패!";
                timer1.Interval = 1000;
                timer1.Start();
            }//Feel_Down();Clean_Up();Clean_Up();Full_Down();

            else
            {
                Doctor(); Good(); lb_Result.Text = "물리 치료 성공!";
                Btn_Num = 2;

                timer1.Interval = 1000;
                timer1.Start();
            }//Feel_up();Feel_up();Clean_Up();Clean_Up();Full_Down();
        }

        private void btn_Do_Short_Click(object sender, EventArgs e) //주사
        {
            if (Quack_Event() == 3)
            {
                Quack(); pb_User.Image = Properties.Resources.무서움;
                pb_User.Location = new Point(327, 220);
                lb_Result.Text = "주사 실패!";
                timer1.Interval = 1000;
                timer1.Start();
            }//Feel_Down();Clean_Down()Full_Up();
            else
            {
                Doctor(); Good(); lb_Result.Text = "주사 성공!";
                Btn_Num = 3;

                timer1.Interval = 1000;
                timer1.Start();
            }//Feel_Down();Clean_Down()Full_Up()Full_Up();;
        }

        private void Hospital_Load(object sender, EventArgs e)
        {
            Save.Page = 5;
            Save.Load_pgb();//값 불러오기
            Btn_Num = 1;
            dosome.Change_Color(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);
            dosome.Face_Change(pgb_Feel.Value, pgb_Full.Value, pgb_Clean.Value);
            label6.Text = DoSomething.State;
            Level.Text = Livingroom.Level_Cnt.ToString();

            Btn_Num = 0;
            Livingroom.Click_Cnt = 0;
            pgb_Day.Value = Livingroom.Day_Cnt;
            lb_Limit.Text = Livingroom.Click_Cnt.ToString("퇴원 #0 / 3회");
            lb_Name.Text = Naming.user_nickname;





        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 1)
            {
                count = 0;
                timer1.Stop();
                switch (Btn_Num)      //버튼 1, 2, 3으로 나누었다.
                {
                    case 1://1. 약먹기
                        {
                            dosome.Full_Up();
                            dosome.Full_Up();
                            dosome.Feel_Down();
                            dosome.Clean_Up();
                            dosome.Clean_Up();



                            //색깔 변화에 대한 동작을 한다.
                            break;
                        }
                    case 2://2. 물리치료
                        {
                            dosome.Feel_Up();
                            dosome.Feel_Up();
                            dosome.Full_Down();
                            dosome.Clean_Down();


                            break;
                        }
                    case 3://3. 주사
                        {
                            dosome.Clean_Up();
                            dosome.Clean_Up();
                            dosome.Feel_Down();

                            break;
                        }
                    default:
                        pgb_Feel.Value -= 5;
                        pgb_Full.Value -= 5;
                        pgb_Clean.Value -= 5;

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
                pb_User.Image = Properties.Resources.병원에온춘식;
                pb_Doctor.Image = Properties.Resources.닥터춘식;
                label6.Text = DoSomething.State;
                Level.Text = Livingroom.Level_Cnt.ToString();
                Livingroom.Click_Cnt++;
                lb_Limit.Text = Livingroom.Click_Cnt.ToString("퇴원 #0 / 3회");

                if (Livingroom.Click_Cnt == 3)
                {
                    MessageBox.Show("치료 성공!\n다음엔 조심하거라~", "퇴원", MessageBoxButtons.OK);
                    Go_Livingroom();
                }
            }
            count++;
        }

        private void btn_Go_Livingroom_Click(object sender, EventArgs e)
        {
            //자동으로 나가기 때문에 필요 없어졌다.
        }

        private void btn_Go_Livingroom_MouseHover(object sender, EventArgs e)
        {
            MoveText.Visible = true;
        }

        private void Hospital_MouseHover(object sender, EventArgs e)
        {
            MoveText.Visible = false;
        }

        private void btn_Do_Drug_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Do_Drug.BackgroundImage = Properties.Resources.행동버튼_;
        }

        private void btn_Do_Phy_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Do_Phy.BackgroundImage = Properties.Resources.행동버튼_;
        }

        private void btn_Do_Short_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Do_Short.BackgroundImage = Properties.Resources.행동버튼_;
        }

        private void btn_Do_Drug_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Do_Drug.BackgroundImage = Properties.Resources.행동버튼;
        }

        private void btn_Do_Phy_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Do_Phy.BackgroundImage = Properties.Resources.행동버튼;
        }

        private void btn_Do_Short_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Do_Short.BackgroundImage = Properties.Resources.행동버튼;
        }
    }
}
