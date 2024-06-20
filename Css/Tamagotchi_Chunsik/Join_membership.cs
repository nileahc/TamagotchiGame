using System;
using System.Collections;
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
    public partial class Join_membership : Form
    {

        public Join_membership()
        {
            InitializeComponent();
        }

        int id_check = 0;
        bool password_check = false;

        private void btn_Check_Duplication_Click(object sender, EventArgs e)
        {// 아이디 중복 확인 이벤트
            // 기존 id 리스트와 비교해서 중복 되는지 확인해야함
            foreach (var a in Login.list_s_id)
            {
                if (tb_ID.Text == a)
                {
                    id_check = 1;   // 중복 된거임
                    MessageBox.Show("사용 불가능한 아이디입니다");
                    break;
                }
            }

            if (id_check != 1 &&tb_ID.Text !="")
            {
                MessageBox.Show("사용가능한 아이디입니다");
                id_check = 2;       // 초기 값이 0, 3이 되야 돌아가게 설정 
            }
            else
                MessageBox.Show("아이디를 입력해주세요.");


            if (id_check == 2 && password_check == true && tb_Enter_password.Text != "" && tb_Enter_password_two.Text != "")
            {
                btn_Join.Enabled = true;
                btn_Join.BackColor = Color.Ivory;
            }

        }

        private void btn_Password_Check_Click(object sender, EventArgs e)
        {
            if (tb_Enter_password.Text == tb_Enter_password_two.Text && tb_Enter_password.Text != "" && tb_Enter_password_two.Text != "")
            {
                password_check = true;
                MessageBox.Show("일치합니다.");
                if (id_check == 2 && password_check == true&&tb_Enter_password.Text!="" &&tb_Enter_password_two.Text!="")
                {
                    btn_Join.Enabled = true;
                    btn_Join.BackColor = Color.Ivory;
                }
            }
            else if(tb_Enter_password.Text == "" || tb_Enter_password_two.Text == "")
                MessageBox.Show("비밀번호를 입력해주세요.");
            else
            {
                password_check = false;
                MessageBox.Show("일치하지 않습니다.");
                return;
            }
        }

        private void btn_Join_Click(object sender, EventArgs e)
        {            
            Login.list_s_id.Add(tb_ID.Text);
            Login.list_s_password.Add(tb_Enter_password.Text);

            MessageBox.Show("회원가입이 완료되었습니다");
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
