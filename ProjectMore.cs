using Qios.DevSuite.Components;
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
    public partial class ProjectMore : Qios.DevSuite.Components.Ribbon.QRibbonForm
    {
        public ProjectMore()
        {
            InitializeComponent();
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count <= 2)
                GlobalVariables.MAINWINDDOW.Visible = true;
        }
        private void ProjectMore_Load(object sender, EventArgs e)
        {
            main_caption.Text = GlobalVariables.PROJECTNAME;
            if (GlobalVariables.PROJECTOWNER != GlobalVariables.USERNAME)
            {
                //项目拥有者可以删除项目，其他人可以编辑项目
                delete_proj_btn.Enabled = false;
            }
        }
        /*打开项目*/
        private void open_proj_btn_Click(object sender, EventArgs e)
        {

        }
        /*编辑项目（只有登录用户创建的项目，且处于待分析状态或完成状态的项目才能编辑）*/
        private void edit_proj_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            TrackOrAnalysis trackOrAnalysis = new TrackOrAnalysis();
            trackOrAnalysis.ShowDialog();
            GlobalVariables.MAINWINDDOW.Visible = false;
        }
        /*删除项目（只有登录用户创建的项目才能删除）*/
        private void delete_proj_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("*******************************************");
            if (MessageBox.Show("是否确定删除项目？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                //根据项目id删除项目
                if(new ConnMySQL().DeleteProject(GlobalVariables.PROJECTID))
                {
                    MessageBox.Show("项目删除成功");
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
            
        }
    }
}