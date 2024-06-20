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
    public partial class Login : Form
    {

        // 관리자 ID
        //string s_id = "1234";
        //string s_password = "1234";

        static public List<string> list_s_id = new List<string>() { "1234" };
        static public List<string> list_s_password = new List<string>() { "1234" };




        public Login()
        {
            InitializeComponent();


        }

        private void btn_Join_membership_Click(object sender, EventArgs e)
        {
            Join_membership join_membership = new Join_membership();
            join_membership.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            bool a = true;
            for (int i = 0; i < list_s_id.Count; i++)
            {
                if (tb_ID.Text == list_s_id[i] && tb_Password.Text == list_s_password[i])
                {
                    MessageBox.Show("로그인 되었습니다.");
                    a = false;

                    this.Visible = false;
                    Loding loding = new Loding();
                    loding.ShowDialog();        // 로딩후 거실에서 시작
                    
                                     
                    PickUp pickUp = new PickUp();
                    pickUp.ShowDialog();
                }
            }
            if (a == true) MessageBox.Show("회원정보가 틀렸습니다.");


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
