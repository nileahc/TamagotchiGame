using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{

    internal class State_Random
    {
        Random random = new Random();
        Kitchen kitchen = new Kitchen();

        // main 폼에서 가져오는 변수들로 생각하자
        int feel = 0;
        int full = 0;
        int clean = 0;
        int hp = 0;

        int rand;

        public State_Random() { } // 생성자

        public void Do_eat()
        {
            feel += Up();  // do eat 하면 랜덤으로 기분, 배부름 올라가고, 청결 랜덤으로 내려간다 
            full += Up();
            clean -= Up();
        }
        public int Up()
        {
            return random.Next(1, 5);
        }

        public int Down()
        {
            return -random.Next(1, 5);
        }

        public void Pgb_Feel_Show()
        {

        }

    }
}
