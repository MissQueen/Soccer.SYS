using Qios.DevSuite.Components;
using Soccer.SYS.ControlsOperation;
using Soccer.SYS.DBController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Soccer.SYS
{
    public partial class ObjectTracking : Qios.DevSuite.Components.Ribbon.QRibbonForm
    {
        public ObjectTracking()
        {
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (Application.OpenForms.Count <= 2)
                GlobalVariables.MAINWINDDOW.Visible = true;
        }
        private void ObjectTracking_Load(object sender, EventArgs e)
        {
            single_obj_check.Checked = false;
            player_no.Enabled = false;
            tracker_method.SelectedIndex = 0;
        }

        private void single_obj_check_CheckedChanged(object sender, EventArgs e)
        {
            if (single_obj_check.Checked)
            {
                player_no.Enabled = true;
                tracker_method.Items.Add("MOSSE");
            }
            else
            {
                player_no.Enabled = false;
                tracker_method.Items.Remove("MOSSE");
            }
        }

        private void del_player_no_Click(object sender, EventArgs e)
        {
            player_no.Text = "";
        }

        private void start_tracking_btn_Click(object sender, EventArgs e)
        {
            GlobalVariables.IF_OLD_PROJ = true;//�Ƿ�༭������Ƶ
            int videoCount = (int)video_nums.Value;//��Ƶ��
            GlobalVariables.SUM_VIDEO = videoCount;//����ȫ������Ƶ��
            GlobalVariables.CURRENT_VIDEO = 0;//����ȫ�ֵ�ǰ��Ƶ��
            //����·�������ļ��в���
            if (!Directory.Exists(GlobalVariables.PROJECT_PATH))
            {
                ControlsOperations.CreatePorjectFile(GlobalVariables.PROJECT_PATH);
            }
            if (tracker_method.SelectedIndex != 0) GlobalVariables.TRACKER_METHOD = tracker_method.SelectedIndex - 1;//���ø��ٷ���
            else GlobalVariables.TRACKER_METHOD = 0;
            if (single_obj_check.Checked)
            {
                int playerno = -1;
                try
                {
                    playerno = int.Parse(player_no.Text);
                    GlobalVariables.PLAYER_NO = int.Parse(player_no.Text);//��Ϊ��Ŀ����٣�������Ա���
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.ToString());
                    GlobalVariables.PLAYER_NO = 99;
                }

            }
            else
            {
                GlobalVariables.PLAYER_NO = -1;
            }
            VideoChoose videoChoose = new VideoChoose();
            videoChoose.Show();
            /***�ŵ�Ŀ�����ģ����***/
            this.Close();
        }
    }
}