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
            //默认展示所有项目
            menu_list.SelectedIndex = 0;
            //Panel中添加列表项
            ControlsOperations.GetPanelDetails(project_list, 0);
        }
        /*根据左侧菜单选项展示不同内容*/
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
        /*点击添加项目，打开创建新项目窗口*/
        private void create_proj_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreateProject createProj = new CreateProject();
            createProj.Show();
            
        }
        /*项目查询文本框聚焦*/
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
                query_text.Text = "请输入项目名称或创建者";
                query_text.ForeColor = Color.LightGray;
                query_has_text = false;
            }
            else
            {
                query_has_text = true;
            }
        }
        /*项目查询*/
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
        /*窗体被重新激活时，刷新面板内容*/
        private void MainWindow_Activated(object sender, EventArgs e)
        {
            if (query_text.Text == ""||query_text.Text== "请输入项目名称或创建者")
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