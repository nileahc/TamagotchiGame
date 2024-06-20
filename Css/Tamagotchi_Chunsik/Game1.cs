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



    public partial class Game1 : Form
    {
        Room r1;
        DoSomething dosome;
        public Game1(Room room)
        {
            InitializeComponent();
            r1 = room;
            timer1.Interval = 50;
            timer2.Interval = 300;
            dosome = new DoSomething();
        }

        Random rand = new Random();

        int r;
        int count = 0;
        //string com = "";
        string user = "";
        
        public static int score = 0; // 가위바위보 승부 점수

        static int Round_Cnt = 0;

        private void btn_Start_Click(object sender, EventArgs e)
        {
            lb_Chance.Visible = true;
            btn_Rock.Enabled = true;
            btn_Siger.Enabled = true;
            btn_Paper.Enabled = true;
            btn_Go.Enabled = true;

            btn_Rock.Visible = true;
            btn_Siger.Visible = true;
            btn_Paper.Visible = true;
            btn_Go.Visible = true;

            btn_Start.Enabled = false;
            btn_Start.Visible = false;

            btn_Back.Enabled = false;
            btn_Back.Visible = false;

            btn_Rock.Enabled = false;
            btn_Siger.Enabled = false;
            btn_Paper.Enabled = false;

            //btn_Exit.Enabled = true;
            //btn_Exit.Visible = true; 
            //종료 버튼이 필요해지면 주석을 지운다.
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Livingroom.Click_Cnt--;
            r1.lb_Limit.Text = Livingroom.Click_Cnt.ToString("클릭 #0 / 8회");
            this.Close();
        }

        private void btn_Rock_Click(object sender, EventArgs e)
        {
            
            user = "주먹";
            timer2.Start();
            
        }

        private void btn_Siger_Click(object sender, EventArgs e)
        {
            
            user = "가위";
            timer2.Start();
            
        }

        private void btn_Paper_Click(object sender, EventArgs e)
        {
            
            user = "보";
            timer2.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            r = rand.Next(1, 4);

            if (r == 1) pb_Other.BackgroundImage = Properties.Resources.rock;
            else if (r == 2) pb_Other.BackgroundImage = Properties.Resources.scissors;
            else if (r == 3) pb_Other.BackgroundImage = Properties.Resources.paper;
        }

        private void btn_Go_Click(object sender, EventArgs e)
        {

            timer1.Start();
            Round_Cnt++;
            lb_Chance.Text = "기회 "+(3-Round_Cnt).ToString()+" / 3회";

            btn_Go.Enabled = false;
            btn_Go.Visible = false;
            btn_Rock.Enabled = true;
            btn_Siger.Enabled = true;
            btn_Paper.Enabled = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            count++;

            r = rand.Next(1, 4);

            if (r == 1) pb_Other.BackgroundImage = Properties.Resources.rock;
            else if (r == 2) pb_Other.BackgroundImage = Properties.Resources.scissors;
            else if (r == 3) pb_Other.BackgroundImage = Properties.Resources.paper;
            if (count == 10)
            {
                if (r == 1) pb_Other.BackgroundImage = Properties.Resources.rock;
                else if (r == 2) pb_Other.BackgroundImage = Properties.Resources.scissors;
                else if (r == 3) pb_Other.BackgroundImage = Properties.Resources.paper;

                int com = r;
               
                timer2.Stop();

                MessageBox.Show( Vss(r, user));


                lb_Score.Text = score*5 + "점";
                if(Round_Cnt == 3)
                {
                    if(r1.pgb_Feel.Value + score*20 >= 100)
                    {
                        r1.pgb_Feel.Value = 30;
                        if (Livingroom.Level_Cnt == 2)
                        {
                            Livingroom.Level_Cnt++;
                            r1.Level.Text = Livingroom.Level_Cnt.ToString();
                                MessageBox.Show("기분이 " + score * 5 + " 증가합니다!");
                                MessageBox.Show("우리왔어~");//우리왔어 폼 열기
                                                         //우리왔어 폼 안에서 해주기this.Close();
                            

                            
                        }
                        else if (Livingroom.Level_Cnt == 4)
                        {
                            Livingroom.Level_Cnt++;
                            r1.Level.Text = Livingroom.Level_Cnt.ToString();
                                MessageBox.Show("기분이 " + score * 5 + " 증가합니다!");
                                MessageBox.Show("우리왔어~");//우리왔어 폼 열기
                                                         //우리왔어 폼 안에서 해주기this.Close();
                            
                           
                        }
                        else
                        {
                            Livingroom.Level_Cnt++;
                            r1.Level.Text = Livingroom.Level_Cnt.ToString();
                        }
                    }

                    else
                    {
                        if (score >= 0)
                        {
                            MessageBox.Show("기분이 " + score * 5 + " 증가합니다!");
                            
                        }
                        else
                            MessageBox.Show("기분이 " + score * 5 + " 감소합니다!");
                        r1.pgb_Feel.Value += (score * 30);
                        if (r1.pgb_Feel.Value + score <= 0)
                        {
                            Ending_No ending = new Ending_No();
                            ending.Show();
                            r1.Close();
                            this.Close();
                        }

                    }

                    Round_Cnt = 0;
                    score = 0;
                    this.Close();
                }
                btn_Go.Enabled = true;
                count = 0;
                //com = "";
                user = "";

                


            }
        }
        public string Vss(int com, string user) // 1. 주먹 2. 가위. 3. 보
        {
            if (com == 1 && user == "주먹")
            {
                btn_Go.Visible = true;
                return "비겼습니다.";// 비김
            }
            else if (com == 1 && user == "가위")
            {
                score--;
                btn_Go.Visible = true;
                return "당신이 패배하였습니다.";// 컴퓨터가 이김
            }
            else if (com == 1 && user == "보")
            {
                score++;
                btn_Go.Visible = true;
                return "당신이 승리하였습니다.";// 유저가 이김
            }


            if (com == 2 && user == "주먹")
            {
                score++;
                btn_Go.Visible = true;
                return "당신이 승리하였습니다.";// 유저가 이김
            }
            else if (com == 2 && user == "가위")
            {
                btn_Go.Visible = true;
                return "비겼습니다.";// 비김            
            }
            else if (com == 2 && user == "보")
            {
                score--;
                btn_Go.Visible = true;
                return "당신이 패배하였습니다.";// 컴퓨터가 이김
            }


            if (com == 3 && user == "주먹")
            {
                score--;
                btn_Go.Visible = true;
                return "당신이 패배하였습니다.";// 컴퓨터가 이김
            }
            else if (com == 3 && user == "가위")
            {
                score++;
                btn_Go.Visible = true;
                return "당신이 승리하였습니다.";// 유져가 이김
            }
            else if (com == 3 && user == "보")
            {
                btn_Go.Visible = true; 
                return "비겼습니다.";
            }// 비김
            else return "예외상황 발생";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
