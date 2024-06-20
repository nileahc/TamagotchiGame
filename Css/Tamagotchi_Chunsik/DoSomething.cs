using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagotchi
{

    internal class DoSomething
    {
        public int GetRandom()
        {
            Random rand = new Random();
            return rand.Next(1, 5);
        }
        public void Feel_Up()
        {
            switch (Save.Page)
            {
                case 1:
                    if (Livingroom.Btn_Num != 0)
                        if (Livingroom.livingroom.pgb_Feel.Value + GetRandom() >= 100)
                        {
                            Livingroom.Level_Cnt++;
                            Livingroom.livingroom.pgb_Feel.Value = 30;
                        }
                        else
                            Livingroom.livingroom.pgb_Feel.Value += GetRandom();
                    break;
                case 2:
                    if (Kitchen.Btn_Num != 0)
                        if (Kitchen.kitchen.pgb_Feel.Value + GetRandom() >= 100)
                        {
                            Livingroom.Level_Cnt++;
                            Kitchen.kitchen.pgb_Feel.Value = 30;
                        }
                        else
                            Kitchen.kitchen.pgb_Feel.Value += GetRandom();
                    break;
                case 3:
                    if (Bathroom.Btn_Num != 0)
                        if (Bathroom.bathroom.pgb_Feel.Value + GetRandom() >= 100)
                        {
                            Livingroom.Level_Cnt++;
                            Bathroom.bathroom.pgb_Feel.Value = 30;
                        }
                        else
                            Bathroom.bathroom.pgb_Feel.Value += GetRandom();
                    break;
                case 4:
                    if (Room.Btn_Num != 0)
                        if (Room.room.pgb_Feel.Value + GetRandom() >= 100)
                        {
                            Livingroom.Level_Cnt++;
                            Room.room.pgb_Feel.Value = 30;
                        }
                        else
                            Room.room.pgb_Feel.Value += GetRandom();
                    break;
                case 5:
                    if (Hospital.Btn_Num != 0)
                        if (Hospital.hospital.pgb_Feel.Value + GetRandom() >= 100)
                        {
                            Livingroom.Level_Cnt++;
                            Hospital.hospital.pgb_Feel.Value = 30;
                        }
                        else
                            Hospital.hospital.pgb_Feel.Value += GetRandom();
                    break;
            }
        }
        public void Feel_Down()
        {

            switch (Save.Page)
            {
                case 1:
                    if (Livingroom.Btn_Num != 0)
                        if(Livingroom.livingroom.pgb_Feel.Value - GetRandom()<=0)


                        Livingroom.livingroom.pgb_Feel.Value -= GetRandom();
                    break;
                case 2:
                    if (Kitchen.Btn_Num != 0)
                        Kitchen.kitchen.pgb_Feel.Value -= GetRandom();
                    break;
                case 3:
                    if (Bathroom.Btn_Num != 0)
                        Bathroom.bathroom.pgb_Feel.Value -= GetRandom();
                    break;
                case 4:
                    if (Room.Btn_Num != 0)
                        Room.room.pgb_Feel.Value -= GetRandom();
                    break;
                case 5:
                    if (Hospital.Btn_Num != 0)
                        Hospital.hospital.pgb_Feel.Value -= GetRandom();
                    break;

            }
        }
        public void Full_Up()
        {
            switch (Save.Page)
            {
                case 1:
                    if (Livingroom.Btn_Num != 0)
                        if (Livingroom.livingroom.pgb_Full.Value + GetRandom() >= 100)
                        {
                            Livingroom.Level_Cnt++;
                            Livingroom.livingroom.pgb_Full.Value = 30;
                        }
                        else
                            Livingroom.livingroom.pgb_Full.Value += GetRandom();
                    break;
                case 2:
                    if (Kitchen.Btn_Num != 0)
                        if (Kitchen.kitchen.pgb_Full.Value + GetRandom() >= 100)
                        {
                            Livingroom.Level_Cnt++;
                            Kitchen.kitchen.pgb_Full.Value = 30;
                        }
                        else
                            Kitchen.kitchen.pgb_Full.Value += GetRandom();
                    break;
                case 3:
                    if (Bathroom.Btn_Num != 0)
                        if (Bathroom.bathroom.pgb_Full.Value + GetRandom() >= 100)
                        {
                            Livingroom.Level_Cnt++;
                            Bathroom.bathroom.pgb_Full.Value = 30;
                        }
                        else
                            Bathroom.bathroom.pgb_Full.Value += GetRandom();
                    break;
                case 4:
                    if (Room.Btn_Num != 0)
                        if (Room.room.pgb_Full.Value + GetRandom() >= 100)
                        {
                            Livingroom.Level_Cnt++;
                            Room.room.pgb_Full.Value = 30;
                        }
                        else
                            Room.room.pgb_Full.Value += GetRandom();
                    break;
                case 5:
                    if (Hospital.Btn_Num != 0)
                        if (Hospital.hospital.pgb_Full.Value + GetRandom() >= 100)
                        {
                            Livingroom.Level_Cnt++;
                            Hospital.hospital.pgb_Full.Value = 30;
                        }
                        else
                            Hospital.hospital.pgb_Full.Value += GetRandom();
                    break;
            }

        }
        public void Full_Down()
        {
            switch (Save.Page)
            {
                case 1:
                    if (Livingroom.Btn_Num != 0)
                        Livingroom.livingroom.pgb_Full.Value -= GetRandom();
                    break;
                case 2:
                    if (Kitchen.Btn_Num != 0)
                        Kitchen.kitchen.pgb_Full.Value -= GetRandom();
                    break;
                case 3:
                    if (Bathroom.Btn_Num != 0)
                        Bathroom.bathroom.pgb_Full.Value -= GetRandom();
                    break;
                case 4:
                    if (Room.Btn_Num != 0)
                        Room.room.pgb_Full.Value -= GetRandom();
                    break;
                case 5:
                    if (Hospital.Btn_Num != 0)
                        Hospital.hospital.pgb_Full.Value -= GetRandom();
                    break;
            }

        }
        public void Clean_Up()
        {
            switch (Save.Page)
            {
                case 1:
                    if (Livingroom.Btn_Num != 0)
                        if (Livingroom.livingroom.pgb_Clean.Value + GetRandom() >= 100)
                        {
                            Livingroom.Level_Cnt++;
                            Livingroom.livingroom.pgb_Clean.Value = 30;
                        }
                        else
                            Livingroom.livingroom.pgb_Clean.Value += GetRandom();
                    break;
                case 2:
                    if (Kitchen.Btn_Num != 0)
                        if (Kitchen.kitchen.pgb_Clean.Value + GetRandom() >= 100)
                        {
                            Livingroom.Level_Cnt++;
                            Kitchen.kitchen.pgb_Clean.Value = 30;
                        }
                        else
                            Kitchen.kitchen.pgb_Clean.Value += GetRandom();
                    break;
                case 3:
                    if (Bathroom.Btn_Num != 0)
                        if (Bathroom.bathroom.pgb_Clean.Value + GetRandom() >= 100)
                        {
                            Livingroom.Level_Cnt++;
                            Bathroom.bathroom.pgb_Clean.Value = 30;
                        }
                        else
                            Bathroom.bathroom.pgb_Clean.Value += GetRandom();
                    break;
                case 4:
                    if (Room.Btn_Num != 0)
                        if (Room.room.pgb_Clean.Value + GetRandom() >= 100)
                        {
                            Livingroom.Level_Cnt++;
                            Room.room.pgb_Clean.Value = 30;
                        }
                        else
                            Room.room.pgb_Clean.Value += GetRandom();
                    break;
                case 5:
                    if (Hospital.Btn_Num != 0)
                        if (Hospital.hospital.pgb_Clean.Value + GetRandom() >= 100)
                        {
                            Livingroom.Level_Cnt++;
                            Hospital.hospital.pgb_Clean.Value = 30;
                        }
                        else
                            Hospital.hospital.pgb_Clean.Value += GetRandom();
                    break;
            }
        }
        public void Clean_Down()
        {
            switch (Save.Page)
            {
                case 1:
                    if (Livingroom.Btn_Num != 0)
                        Livingroom.livingroom.pgb_Clean.Value -= GetRandom();
                    break;
                case 2:
                    if (Kitchen.Btn_Num != 0)
                        Kitchen.kitchen.pgb_Clean.Value -= GetRandom();
                    break;
                case 3:
                    if (Bathroom.Btn_Num != 0)
                        Bathroom.bathroom.pgb_Clean.Value -= GetRandom();
                    break;
                case 4:
                    if (Room.Btn_Num != 0)
                        Room.room.pgb_Clean.Value -= GetRandom();
                    break;
                case 5:
                    if (Hospital.Btn_Num != 0)
                        Hospital.hospital.pgb_Clean.Value -= GetRandom();
                    break;
            }
        }

        //여기까지는 랜덤으로 숫자가 변하는 코드
        public void Change_Color(object x, object y, object z)
        {
            if ((int)x < 20)
            {

                if (Livingroom.Btn_Num != 0)
                    Livingroom.livingroom.pgb_Feel.ForeColor = Color.Red;
                if (Kitchen.Btn_Num != 0)
                    Kitchen.kitchen.pgb_Feel.ForeColor = Color.Red;
                if (Bathroom.Btn_Num != 0)
                    Bathroom.bathroom.pgb_Feel.ForeColor = Color.Red;

                if (Room.Btn_Num != 0)
                    Room.room.pgb_Feel.ForeColor = Color.Red;
                if (Hospital.Btn_Num != 0)
                    Hospital.hospital.pgb_Feel.ForeColor = Color.Red;


            }
            else
            {
                {
                    if (Livingroom.Btn_Num != 0)
                        Livingroom.livingroom.pgb_Feel.ForeColor = Color.SteelBlue;
                    if (Kitchen.Btn_Num != 0)
                        Kitchen.kitchen.pgb_Feel.ForeColor = Color.SteelBlue;
                    if (Bathroom.Btn_Num != 0)
                        Bathroom.bathroom.pgb_Feel.ForeColor = Color.SteelBlue;
                    if (Room.Btn_Num != 0)
                        Room.room.pgb_Feel.ForeColor = Color.SteelBlue;
                    if (Hospital.Btn_Num != 0)
                        Hospital.hospital.pgb_Feel.ForeColor = Color.SteelBlue;

                }

            }
            if ((int)y < 20)
            {
                if (Livingroom.Btn_Num != 0)
                    Livingroom.livingroom.pgb_Full.ForeColor = Color.Red;
                if (Kitchen.Btn_Num != 0)
                    Kitchen.kitchen.pgb_Full.ForeColor = Color.Red;
                if (Bathroom.Btn_Num != 0)
                    Bathroom.bathroom.pgb_Full.ForeColor = Color.Red;
                if (Room.Btn_Num != 0)
                    Room.room.pgb_Full.ForeColor = Color.Red;
                if (Hospital.Btn_Num != 0)
                    Hospital.hospital.pgb_Full.ForeColor = Color.Red;

            }
            else
            {
                if (Livingroom.Btn_Num != 0)
                    Livingroom.livingroom.pgb_Full.ForeColor = Color.SteelBlue;
                if (Kitchen.Btn_Num != 0)
                    Kitchen.kitchen.pgb_Full.ForeColor = Color.SteelBlue;
                if (Bathroom.Btn_Num != 0)
                    Bathroom.bathroom.pgb_Full.ForeColor = Color.SteelBlue;
                if (Room.Btn_Num != 0)
                    Room.room.pgb_Full.ForeColor = Color.SteelBlue;
                if (Hospital.Btn_Num != 0)
                    Hospital.hospital.pgb_Full.ForeColor = Color.SteelBlue;

            }
            if ((int)z < 20)
            {
                if (Livingroom.Btn_Num != 0)
                    Livingroom.livingroom.pgb_Clean.ForeColor = Color.Red;
                if (Kitchen.Btn_Num != 0)
                    Kitchen.kitchen.pgb_Clean.ForeColor = Color.Red;
                if (Bathroom.Btn_Num != 0)
                    Bathroom.bathroom.pgb_Clean.ForeColor = Color.Red;
                if (Room.Btn_Num != 0)
                    Room.room.pgb_Clean.ForeColor = Color.Red;
                if (Hospital.Btn_Num != 0)
                    Hospital.hospital.pgb_Clean.ForeColor = Color.Red;
            }
            else
            {
                if (Livingroom.Btn_Num != 0)
                    Livingroom.livingroom.pgb_Clean.ForeColor = Color.SteelBlue;
                if (Kitchen.Btn_Num != 0)
                    Kitchen.kitchen.pgb_Clean.ForeColor = Color.SteelBlue;
                if (Bathroom.Btn_Num != 0)
                    Bathroom.bathroom.pgb_Clean.ForeColor = Color.SteelBlue;
                if (Room.Btn_Num != 0)
                    Room.room.pgb_Clean.ForeColor = Color.SteelBlue;
                if (Hospital.Btn_Num != 0)
                    Hospital.hospital.pgb_Clean.ForeColor = Color.SteelBlue;
            }
        }

        public static string State = "";
        public void Face_Change(object x, object y, object z)
        {
            if ((int)x < 10 || (int)y < 10 || (int)z < 10)
            {
                if (Livingroom.Btn_Num != 0)
                {
                    Livingroom.livingroom.FaceState.Image = Properties.Resources.우는_춘식이;
                    Livingroom.livingroom.label6.ForeColor = Color.Navy;
                    State = "슬픔";
                }
                if (Kitchen.Btn_Num != 0)
                {
                    Kitchen.kitchen.FaceState.Image = Properties.Resources.우는_춘식이;
                    Kitchen.kitchen.label6.ForeColor = Color.Navy;
                    State = "슬픔";
                }
                if (Bathroom.Btn_Num != 0)
                {
                    Bathroom.bathroom.FaceState.Image = Properties.Resources.우는_춘식이;
                    Bathroom.bathroom.label6.ForeColor = Color.Navy;

                    State = "슬픔";
                }
                if (Room.Btn_Num != 0)
                {
                    Room.room.FaceState.Image = Properties.Resources.우는_춘식이;
                    Room.room.label6.ForeColor = Color.Navy;


                    State = "슬픔";
                }
                if (Hospital.Btn_Num != 0)
                {
                    Hospital.hospital.FaceState.Image = Properties.Resources.우는_춘식이;
                    Hospital.hospital.label6.ForeColor = Color.Navy;


                    State = "슬픔";
                }
            }
            else if ((int)x < 20 || (int)y < 20 || (int)z < 20)
            {
                if (Livingroom.Btn_Num != 0)
                {
                    Livingroom.livingroom.FaceState.Image = Properties.Resources.식빵춘식이;
                    Livingroom.livingroom.label6.ForeColor = Color.Crimson;

                    State = "화남";
                }
                if (Kitchen.Btn_Num != 0)
                {
                    Kitchen.kitchen.FaceState.Image = Properties.Resources.식빵춘식이;
                    Kitchen.kitchen.label6.ForeColor = Color.Crimson;

                    State = "화남";
                }
                if (Bathroom.Btn_Num != 0)
                {
                    Bathroom.bathroom.FaceState.Image = Properties.Resources.식빵춘식이;
                    Bathroom.bathroom.label6.ForeColor = Color.Crimson;

                    State = "화남";
                }
                if (Room.Btn_Num != 0)
                {
                    Room.room.FaceState.Image = Properties.Resources.식빵춘식이;
                    Room.room.label6.ForeColor = Color.Crimson;

                    State = "화남";
                }
                if (Hospital.Btn_Num != 0)
                {
                    Hospital.hospital.FaceState.Image = Properties.Resources.식빵춘식이;
                    Hospital.hospital.label6.ForeColor = Color.Crimson;

                    State = "화남";
                }
            }

            else if ((int)x > 50 && (int)y > 50 && (int)z > 50)
            {
                if (Livingroom.Btn_Num != 0)
                {
                    Livingroom.livingroom.FaceState.Image = Properties.Resources.신난_춘식이;
                    Livingroom.livingroom.label6.ForeColor = Color.DarkOrchid;

                    State = "신남";
                }
                if (Kitchen.Btn_Num != 0)
                {
                    Kitchen.kitchen.FaceState.Image = Properties.Resources.신난_춘식이;
                    Kitchen.kitchen.label6.ForeColor = Color.DarkOrchid;

                    State = "신남";
                }
                if (Bathroom.Btn_Num != 0)
                {
                    Bathroom.bathroom.FaceState.Image = Properties.Resources.신난_춘식이;
                    Bathroom.bathroom.label6.ForeColor = Color.DarkOrchid;

                    State = "신남";
                }
                if (Room.Btn_Num != 0)
                {
                    Room.room.FaceState.Image = Properties.Resources.신난_춘식이;
                    Room.room.label6.ForeColor = Color.DarkOrchid;

                    State = "신남";
                }
                if (Hospital.Btn_Num != 0)
                {
                    Hospital.hospital.FaceState.Image = Properties.Resources.신난_춘식이;
                    Hospital.hospital.label6.ForeColor = Color.DarkOrchid;

                    State = "신남";
                }
            }

            else if ((int)x > 20 && (int)y > 20 && (int)z > 20)
            {
                if (Livingroom.Btn_Num != 0)
                {
                    Livingroom.livingroom.FaceState.Image = Properties.Resources.기본얼굴;
                    Livingroom.livingroom.label6.ForeColor = Color.DarkGreen;

                    State = "좋음";
                }
                if (Kitchen.Btn_Num != 0)
                {
                    Kitchen.kitchen.FaceState.Image = Properties.Resources.기본얼굴;
                    Kitchen.kitchen.label6.ForeColor = Color.DarkGreen;

                    State = "좋음";
                }
                if (Bathroom.Btn_Num != 0)
                {
                    Bathroom.bathroom.FaceState.Image = Properties.Resources.기본얼굴;
                    Bathroom.bathroom.label6.ForeColor = Color.DarkGreen;

                    State = "좋음";
                }
                if (Room.Btn_Num != 0)
                {
                    Room.room.FaceState.Image = Properties.Resources.기본얼굴;
                    Room.room.label6.ForeColor = Color.DarkGreen;

                    State = "좋음";
                }
                if (Hospital.Btn_Num != 0)
                {
                    Hospital.hospital.FaceState.Image = Properties.Resources.기본얼굴;
                    Hospital.hospital.label6.ForeColor = Color.DarkGreen;

                    State = "좋음";
                }
            }

        }
        public void Night_Time()
        {
            if (Livingroom.Day_Cnt == 7)
            {
                HappyEnding happyEnding = new HappyEnding();
                happyEnding.Show();
            }
            else
            {
                MessageBox.Show("춘식아 자러가야지", "밤이 되었습니다.", MessageBoxButtons.OK);
                Night night = new Night();
                night.Show();
                night.Location = new Point(560, 216);

            }

        }//뒤에 항상 this.Close()를 붙여준다.

    }
}
//하나하나 텍스트를 바꾸는 코드를 넣어주기 