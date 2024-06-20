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
    public partial class PickUp : Form
    {
        public PickUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_Question.Text = "춘식이를 주워가시겠습니까?";

            button1.Visible = false;
            button1.Enabled = false;

            btn_Yes.Visible = true;
            btn_No.Visible = true;

            btn_Yes.Enabled = true;
            btn_No.Enabled = true;


        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            Loding loding = new Loding();
            loding.ShowDialog();

            Ending_No noEnding = new Ending_No();
            noEnding.ShowDialog();
            this.Close();
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            Loding loding = new Loding();
            loding.ShowDialog();

            Naming naming = new Naming();
            naming.Show();

            this.Close();
        }
    }
}
