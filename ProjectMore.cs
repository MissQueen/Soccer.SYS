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
                //��Ŀӵ���߿���ɾ����Ŀ�������˿��Ա༭��Ŀ
                delete_proj_btn.Enabled = false;
            }
        }
        /*����Ŀ*/
        private void open_proj_btn_Click(object sender, EventArgs e)
        {

        }
        /*�༭��Ŀ��ֻ�е�¼�û���������Ŀ���Ҵ��ڴ�����״̬�����״̬����Ŀ���ܱ༭��*/
        private void edit_proj_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            TrackOrAnalysis trackOrAnalysis = new TrackOrAnalysis();
            trackOrAnalysis.ShowDialog();
            GlobalVariables.MAINWINDDOW.Visible = false;
        }
        /*ɾ����Ŀ��ֻ�е�¼�û���������Ŀ����ɾ����*/
        private void delete_proj_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("*******************************************");
            if (MessageBox.Show("�Ƿ�ȷ��ɾ����Ŀ��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                //������Ŀidɾ����Ŀ
                if(new ConnMySQL().DeleteProject(GlobalVariables.PROJECTID))
                {
                    MessageBox.Show("��Ŀɾ���ɹ�");
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