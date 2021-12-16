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
        /*�û���¼*/
        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_text.Text;
            string password = psw_text.Text;
            if (username == null || username == "" || password == null || password == "")
            {
                MessageBox.Show("�û��������벻��Ϊ��", "��ʾ", MessageBoxButtons.OK);
            }
            else
            {
                UserUtil user = new UserUtil(username, password);
                int state = new ConnMySQL().QueryUser(user);
                switch (state)
                {
                    case 0:
                        MessageBox.Show("�û������ڣ�", "��ʾ", MessageBoxButtons.OK);
                        break;
                    case 1:
                        //���õ�¼״̬
                        GlobalVariables.LOGIN_STATE = 1;
                        //��ǰ�û�
                        GlobalVariables.USERNAME = username;
                        GlobalVariables.PASSWORD = password;
                        this.Close();
                        break;
                    case 2:
                        MessageBox.Show("�������", "��ʾ", MessageBoxButtons.OK);
                        break;
                }
            }
        }
        /*�س��¼�*/
        private void UserLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                login_btn_Click(null,null);
            }
        }
        /*�س��¼�*/
        private void psw_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                login_btn_Click(null, null);
            }
        }
        /*�س��¼�*/
        private void username_text_KeyDown(object sender, KeyEventArgs e)
        {

        }

        /*ע��ɹ��󣬱����û���Ϣ*/
        private void UserLogin_Activated(object sender, EventArgs e)
        {
            username_text.Text = GlobalVariables.USERNAME;
            psw_text.Text = GlobalVariables.PASSWORD;
        }
    }
}