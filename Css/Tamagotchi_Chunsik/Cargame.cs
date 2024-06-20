using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagotchi
{
    public partial class Cargame : Form
    {
        Room r1;
        public Cargame(Room room)
        {
            InitializeComponent();
            r1 = room;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        int carSpeed = 0;
        int count = 0;
        int second = 0;
        public static int score = 0;

        void gameover()
        {
            //Room room = new Room();
            lb_Gameover.Visible = false;
            if (pb_Car3.Bounds.IntersectsWith(pb_Car1.Bounds))
            {
                timer1.Enabled = false;
                lb_Gameover.Visible = true;

                timer1.Interval = 1000;
                timer1.Start();

                timer2.Stop();



                timer1.Stop();
                score = second;
                if (score >= 10)
                    score = 10;
                if (r1.pgb_Feel.Value + score >= 100)
                {
                    r1.pgb_Feel.Value = 30;
                    if (Livingroom.Level_Cnt == 2)
                    {
                        Livingroom.Level_Cnt++;
                        r1.Level.Text = Livingroom.Level_Cnt.ToString();
                        MessageBox.Show("기분이 " + score + " 증가합니다!");

                        MessageBox.Show("우리왔어~");//우리왔어 폼 열기
                        //우리왔어 폼 안에서 해주기this.Close();
                    }
                     else if (Livingroom.Level_Cnt == 4)
                    {
                        Livingroom.Level_Cnt++;
                        r1.Level.Text = Livingroom.Level_Cnt.ToString();
                        MessageBox.Show("기분이 " + score + " 증가합니다!");

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
                    r1.pgb_Feel.Value += score;
                MessageBox.Show("기분이 " + score + " 증가합니다!");


                //레벨 축하폼을 띄운다
                //레벨 2일 때 r1.pgb_Feel.Value + score >= 100 일때
                //만약 레벨이 3이라면 친구가 놀러온다.

                this.Close();

            }
            if (pb_Car3.Bounds.IntersectsWith(pb_Car2.Bounds))
            {
                timer1.Enabled = false;
                lb_Gameover.Visible = true;

                timer1.Interval = 1000;
                timer1.Start();

                timer2.Stop();



                timer1.Stop();
                score = second;
                if (score >= 10)
                    score = 10;
                if (r1.pgb_Feel.Value + score >= 100)
                {
                    r1.pgb_Feel.Value = 30;
                    if (Livingroom.Level_Cnt == 2)
                    {
                        Livingroom.Level_Cnt++;
                        r1.Level.Text = Livingroom.Level_Cnt.ToString();
                        MessageBox.Show("기분이 " + score + " 증가합니다!");

                        MessageBox.Show("우리왔어~");//우리왔어 폼 열기
                        //우리왔어 폼 안에서 해주기this.Close();
                    }
                    else if (Livingroom.Level_Cnt == 4)
                    {
                        Livingroom.Level_Cnt++;
                        r1.Level.Text = Livingroom.Level_Cnt.ToString();
                        MessageBox.Show("기분이 " + score + " 증가합니다!");

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
                    r1.pgb_Feel.Value += score;
                MessageBox.Show("기분이 " + score + " 증가합니다!");
                //레벨 축하폼을 띄운다
                //레벨 2일 때 r1.pgb_Feel.Value + score >= 100 일때
                //만약 레벨이 3이라면 친구가 놀러온다.

                this.Close();

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            moveline(carSpeed);
            Car1(carSpeed);//무지
            gameover();
        }

        Random rand = new Random();
        int x;

        void moveline(int speed)
        {
            timer2.Interval = 1000;
            timer2.Start();

            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }

            else
            {
                pictureBox1.Top += speed;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }

        }

        void Car1(int speed)
        {
            if (pb_Car1.Top >= 500)
            {
                x = rand.Next(0, 800);
                pb_Car1.Location = new Point(x, 0);

            }
            else
            {
                pb_Car1.Top += speed;
            }

            if (pb_Car2.Top >= 500)
            {
                x = rand.Next(200, 600);
                pb_Car2.Location = new Point(x, 0);
            }
            else
            {
                pb_Car2.Top += speed;
            }
        }

        private void Cargame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (pb_Car3.Left > 30)
                    pb_Car3.Left += -40;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (pb_Car3.Right < 800 - pb_Car3.Width / 2)
                    pb_Car3.Left += 40;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (carSpeed < 15)
                {
                    carSpeed++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (carSpeed > 0)
                {
                    carSpeed--;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            second++;
            lb_timer.Text = second + "초";
        }

        private void Cargame_Load(object sender, EventArgs e)
        {

        }
    }
}
