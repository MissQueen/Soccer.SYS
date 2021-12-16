using System;
using System.Windows.Forms;
using Soccer.SYS.DBController;
namespace Soccer.SYS
{
    public partial class UserLogin : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public UserLogin()
        {
            InitializeComponent();
        }


        private void clear_username_Click(object sender, EventArgs e)
        {
            username_text.Text = string.Empty;
        }

        private void clear_psw_Click(object sender, EventArgs e)
        {
            psw_text.Text = string.Empty;
        }

        private void register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
        /*用户登录*/
        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_text.Text;
            string password = psw_text.Text;
            if (username == null || username == "" || password == null || password == "")
            {
                MessageBox.Show("用户名或密码不能为空", "提示", MessageBoxButtons.OK);
            }
            else
            {
                UserUtil user = new UserUtil(username, password);
                int state = new ConnMySQL().QueryUser(user);
                switch (state)
                {
                    case 0:
                        MessageBox.Show("用户不存在！", "提示", MessageBoxButtons.OK);
                        break;
                    case 1:
                        //设置登录状态
                        GlobalVariables.LOGIN_STATE = 1;
                        //当前用户
                        GlobalVariables.USERNAME = username;
                        GlobalVariables.PASSWORD = password;
                        this.Close();
                        break;
                    case 2:
                        MessageBox.Show("密码错误！", "提示", MessageBoxButtons.OK);
                        break;
                }
            }
        }
        /*回车事件*/
        private void UserLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                login_btn_Click(null,null);
            }
        }
        /*回车事件*/
        private void psw_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                login_btn_Click(null, null);
            }
        }
        /*回车事件*/
        private void username_text_KeyDown(object sender, KeyEventArgs e)
        {

        }

        /*注册成功后，保存用户信息*/
        private void UserLogin_Activated(object sender, EventArgs e)
        {
            username_text.Text = GlobalVariables.USERNAME;
            psw_text.Text = GlobalVariables.PASSWORD;
        }
    }
}