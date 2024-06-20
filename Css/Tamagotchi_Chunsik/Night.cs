using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamagotchi
{
    public partial class Night : Form
    {
        public Night()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer2.Interval = 300;
            timer2.Start();
        }

        int count = 0;
        int count2 = 0;

        private void Night_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 5)
            {
                Livingroom.Click_Cnt = 0;
                Livingroom.Day_Cnt++;
                Livingroom livingroom = new Livingroom();
                livingroom.Show();

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
                dot1.Visible = false;
                dot2.Visible = false;
                dot3.Visible = false;
            }

            if (count == 5)
                timer2.Stop();

        }
    }
}
