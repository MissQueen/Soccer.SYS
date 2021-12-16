using ComponentFactory.Krypton.Toolkit;
using Soccer.SYS.DBController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Soccer.SYS
{
    public partial class Register : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void clear_username_Click_1(object sender, EventArgs e)
        {
            username_text.Text = string.Empty;
        }

        private void clear_psw_Click(object sender, EventArgs e)
        {
            psw_txt.Text = string.Empty;
        }

        private void clear_verify_Click(object sender, EventArgs e)
        {
            verification_txt.Text = string.Empty;
        }
        /*注册*/
        private void register_btn_Click(object sender, EventArgs e)
        {
            string name = username_text.Text;
            string psw = psw_txt.Text;
            string vpsw = verification_txt.Text;
            if (name == "" || name == null || psw == "" || psw == null || vpsw == "" || vpsw == null)
            {
                MessageBox.Show("注册信息不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (psw != vpsw)
            {
                MessageBox.Show("两次输入密码不一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserUtil user = new UserUtil(name, psw);
                int state = new ConnMySQL().InsertNewUser(user);
                if (state == 0)
                {
                    MessageBox.Show("数据库操作失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else if (state == 1)
                {
                    MessageBox.Show("该用户已被注册！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GlobalVariables.USERNAME = name;
                    GlobalVariables.PASSWORD = psw;
                    this.Close();
                }
            }
        }

        private void username_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                register_btn_Click(null, null);
            }
        }

        private void psw_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                register_btn_Click(null, null);
            }
        }

        private void verification_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                register_btn_Click(null, null);
            }
        }
    }
}