using System;
using System.Drawing;
using Soccer.SYS.ControlsOperation;
using ComponentFactory.Krypton.Toolkit;
using Soccer.SYS.DBController;

namespace Soccer.SYS
{
    public partial class MainWindow : Qios.DevSuite.Components.Ribbon.QRibbonForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Ĭ��չʾ������Ŀ
            menu_list.SelectedIndex = 0;
            //Panel������б���
            ControlsOperations.GetPanelDetails(project_list, 0);
        }
        /*�������˵�ѡ��չʾ��ͬ����*/
        private void menu_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            KryptonListBox listbox = (KryptonListBox)sender;
            GlobalVariables.MENUITEM = listbox.SelectedIndex;
            query_text.Text = "";
            switch (listbox.SelectedIndex)
            {
                case 0:
                    ControlsOperations.GetPanelDetails(project_list, 0);
                    break;
                case 1:
                    ControlsOperations.GetPanelDetails(project_list, 1);
                    break;
                case 2:
                    ControlsOperations.GetPanelDetails(project_list, 2);
                    break;
                case 3:
                    ControlsOperations.GetPanelDetails(project_list, 3);
                    break;
                case 4:
                    ControlsOperations.GetPanelDetails(project_list, 4);
                    break;
            }
        }
        /*��������Ŀ���򿪴�������Ŀ����*/
        private void create_proj_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreateProject createProj = new CreateProject();
            createProj.Show();
            
        }
        /*��Ŀ��ѯ�ı���۽�*/
        bool query_has_text = false;
        private void query_text_Enter(object sender, EventArgs e)
        {
            if (!query_has_text)
            {
                query_text.Text = "";
            }
            query_text.ForeColor = Color.Black;
        }

        private void query_text_Leave(object sender, EventArgs e)
        {
            if (query_text.Text == "")
            {
                query_text.Text = "��������Ŀ���ƻ򴴽���";
                query_text.ForeColor = Color.LightGray;
                query_has_text = false;
            }
            else
            {
                query_has_text = true;
            }
        }
        /*��Ŀ��ѯ*/
        private void search_proj_btn_Click(object sender, EventArgs e)
        {
            string condition = query_text.Text;
            int menuitem = GlobalVariables.MENUITEM;
            ControlsOperations.SearchPanelContent(project_list, condition, menuitem);

        }

        private void query_btn_Click(object sender, EventArgs e)
        {
            string condition = query_text.Text;
            int menuitem = GlobalVariables.MENUITEM;
            ControlsOperations.SearchPanelContent(project_list, condition, menuitem);
        }
        /*���屻���¼���ʱ��ˢ���������*/
        private void MainWindow_Activated(object sender, EventArgs e)
        {
            if (query_text.Text == ""||query_text.Text== "��������Ŀ���ƻ򴴽���")
            {
                ControlsOperations.GetPanelDetails(project_list, GlobalVariables.MENUITEM);
            }
            else
            {
                ControlsOperations.SearchPanelContent(project_list, query_text.Text, GlobalVariables.MENUITEM);
            }
        }
    }
}