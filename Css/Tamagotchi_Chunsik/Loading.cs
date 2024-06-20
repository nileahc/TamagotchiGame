using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagotchi
{
    public partial class Loding : Form
    {
        int count = 0;
        int count2 = 0;
        public Loding()
        {
            InitializeComponent();


            timer1.Interval = 1000;
            timer1.Start();
            timer2.Interval = 300;
            timer2.Start();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count >= 3)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            count2++;
            if (count2 == 1)
            {
                dot1.Visible = true;
            }
            else if (count2 == 2)
            {
                dot2.Visible = true;
            }
            else if (count2 == 3)
            {
                dot3.Visible = true;
            }
            else
            {
                count2 = 0;
                dot1.Visible=false;
                dot2.Visible=false;
                dot3.Visible=false;
            }
            
            if(count >=3)
                timer2.Stop();

        }



    }
}
