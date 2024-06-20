using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal class Save//임시로 담는 통으로 사용하기 위해서 만들었다.
    {
        public static int Page; //페이지가 로드 되면 Page를 변화시킨다.
        // 거실 : 1 / 부엌 : 2 / 화장실 : 3 / 방 : 4
        public static int SaveFeel = 30;//현재 수치를 저장하는 저장소를 만들었다.
        public static int SaveFull = 30;
        public static int SaveClean = 30;
        

        public static void Save_pgb() //폼을 이동할 때 상태에 대한 데이터를 저장하는 코드
        {
            switch (Page)
            {
                case 1:
                    SaveFeel = Livingroom.livingroom.pgb_Feel.Value;
                    SaveFull = Livingroom.livingroom.pgb_Full.Value;
                    SaveClean = Livingroom.livingroom.pgb_Clean.Value;
                    break;
                case 2:
                    SaveFeel = Kitchen.kitchen.pgb_Feel.Value;
                    SaveFull = Kitchen.kitchen.pgb_Full.Value;
                    SaveClean = Kitchen.kitchen.pgb_Clean.Value;
                    break;
                case 3:
                    SaveFeel = Bathroom.bathroom.pgb_Feel.Value;
                    SaveFull = Bathroom.bathroom.pgb_Full.Value;
                    SaveClean = Bathroom.bathroom.pgb_Clean.Value;
                    break;
                case 4:
                    SaveFeel = Room.room.pgb_Feel.Value;
                    SaveFull = Room.room.pgb_Full.Value;
                    SaveClean = Room.room.pgb_Clean.Value;
                    break;
                case 5:
                    SaveFeel = Hospital.hospital.pgb_Feel.Value;
                    SaveFull = Hospital.hospital.pgb_Full.Value;
                    SaveClean = Hospital.hospital.pgb_Clean.Value;
                    break;
            }
        }
        public static void Load_pgb() //폼을 이동할 때 이전 폼에 대한 데이터를 불러오는 코드
        {
            switch (Page)
            {
                case 1:
                    Livingroom.livingroom.pgb_Feel.Value = (int)SaveFeel;
                    Livingroom.livingroom.pgb_Full.Value = (int)SaveFull;
                    Livingroom.livingroom.pgb_Clean.Value = (int)SaveClean;
                    Livingroom.livingroom.Level.Text = Livingroom.Level_Cnt.ToString();
                    break;
                case 2:
                    Kitchen.kitchen.pgb_Feel.Value = (int)SaveFeel;
                    Kitchen.kitchen.pgb_Full.Value = (int)SaveFull;
                    Kitchen.kitchen.pgb_Clean.Value = (int)SaveClean;
                    Kitchen.kitchen.Level.Text = Livingroom.Level_Cnt.ToString();

                    break;
                case 3:
                    Bathroom.bathroom.pgb_Feel.Value = (int)SaveFeel;
                    Bathroom.bathroom.pgb_Full.Value =(int)SaveFull;
                    Bathroom.bathroom.pgb_Clean.Value = (int)SaveClean;
                    Bathroom.bathroom.Level.Text = Livingroom.Level_Cnt.ToString();

                    break;
                case 4:
                    Room.room.pgb_Feel.Value = (int)SaveFeel;
                    Room.room.pgb_Full.Value = (int)SaveFull;
                    Room.room.pgb_Clean.Value = (int)SaveClean;
                    Room.room.Level.Text = Livingroom.Level_Cnt.ToString();

                    break; 
                case 5:
                    Hospital.hospital.pgb_Feel.Value = (int)SaveFeel;
                    Hospital.hospital.pgb_Full.Value = (int)SaveFull;
                    Hospital.hospital.pgb_Clean.Value = (int)SaveClean;
                    Hospital.hospital.Level.Text = Livingroom.Level_Cnt.ToString();

                    break;  
            }
        }
    }
}
