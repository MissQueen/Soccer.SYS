using Qios.DevSuite.Components;
using Soccer.SYS.ControlsOperation;
using Soccer.SYS.DBController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Soccer.SYS
{
    /*ѡ����Ƶ*/
    public partial class VideoChoose : Qios.DevSuite.Components.Ribbon.QRibbonForm
    {
        public VideoChoose()
        {
            InitializeComponent();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (Application.OpenForms.Count <= 2)
                GlobalVariables.MAINWINDDOW.Visible = true;
        }
        private void VideoChoose_Load(object sender, EventArgs e)
        {
            GlobalVariables.CURRENT_VIDEO += 1;//��ǰ������Ƶ���
            video_choose.Text = "��ѡ���" + GlobalVariables.CURRENT_VIDEO.ToString() + "����Ƶ";
        }
        /*��Ƶѡ��ť*/
        [DllImport("DLLDemo1.dll", CallingConvention = CallingConvention.Cdecl)]
        extern static void TrackingObjects(int trackerType, int videoCount, int playerno);
        private void add_video_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog videoFile = new OpenFileDialog();
            videoFile.Filter = "ý���ļ����������ͣ�|*.mp4;*.mpeg;*.wma;*.wmv;*.wav;*.avi";
            if (videoFile.ShowDialog() == DialogResult.OK)
            {
                GlobalVariables.CURRENT_VIDEO_PATH = videoFile.FileName;//��ȡ��Ƶλ��
                ControlsOperations.WritePath(GlobalVariables.CURRENT_VIDEO_PATH);//�Ƚ���Ƶ·��д��̶��ļ���
                //��Ƶ·���������ݿ�
                ProjAnalysisMySQL.CreateVideoTable(videoFile.FileName, (int)GlobalVariables.PROJECTID);
                CourtTransformBG bg = new CourtTransformBG();//͸�ӱ任��Ƶ��һ֡
                VideoFirstFrame vff = new VideoFirstFrame();//͸�ӱ任��ƽ��ͼ
                GlobalVariables.SRCCOUNT = 0;//��Ƶ֡��ѡ��ĵ�����¼
                GlobalVariables.DSTCOUNT = 0;//��ƽ��ͼ��ѡ��ĵ�����¼
                vff.Show();
                bg.Show();
                MessageBox.Show("�������Ҵ����зֱ�ѡ���ĸ�͸�ӱ任��Ӧ��", "��ʾ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                //��Ƶ������ɺ���Ŀ�ĳɴ�����״̬

                //�ص�������
                

            }

        }
    }
}