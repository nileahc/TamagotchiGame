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
    public partial class Naming : Form
    {
        public Naming()
        {
            InitializeComponent();
        }

        static public string user_nickname = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text == "")
            {
                MessageBox.Show("이름을 입력하세요");
                return;
            }
            user_nickname = tb_Name.Text;

            Loding loding = new Loding();
            loding.ShowDialog();

            Livingroom livingroom = new Livingroom();
            livingroom.Show();
            this.Close();
        }
    }
}
