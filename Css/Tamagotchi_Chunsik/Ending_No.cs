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
    public partial class Ending_No : Form
    {
        public Ending_No()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Gray;
        }

        private void btn_Exit_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Exit.BackColor = Color.Gray;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void btn_Exit_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Exit.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //다시하기 버튼
            
            Naming naming = new Naming();
            if (Naming.user_nickname == "")
            {
                PickUp pickUp = new PickUp();
                pickUp.Show();
            }

            else
            {
                Save.SaveFeel = 30;
                Save.SaveFull = 30;
                Save.SaveClean = 30;
                Livingroom.Day_Cnt = 1;
                Livingroom.Click_Cnt = 0;
                Livingroom.Level_Cnt = 1;
                naming.Show();
            }


            this.Close();
        }
    }
}
