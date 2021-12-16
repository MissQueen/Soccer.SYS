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
    /*选择视频*/
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
            GlobalVariables.CURRENT_VIDEO += 1;//当前处理视频编号
            video_choose.Text = "请选择第" + GlobalVariables.CURRENT_VIDEO.ToString() + "个视频";
        }
        /*视频选择按钮*/
        [DllImport("DLLDemo1.dll", CallingConvention = CallingConvention.Cdecl)]
        extern static void TrackingObjects(int trackerType, int videoCount, int playerno);
        private void add_video_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog videoFile = new OpenFileDialog();
            videoFile.Filter = "媒体文件（所有类型）|*.mp4;*.mpeg;*.wma;*.wmv;*.wav;*.avi";
            if (videoFile.ShowDialog() == DialogResult.OK)
            {
                GlobalVariables.CURRENT_VIDEO_PATH = videoFile.FileName;//获取视频位置
                ControlsOperations.WritePath(GlobalVariables.CURRENT_VIDEO_PATH);//先将视频路径写入固定文件夹
                //视频路径存入数据库
                ProjAnalysisMySQL.CreateVideoTable(videoFile.FileName, (int)GlobalVariables.PROJECTID);
                CourtTransformBG bg = new CourtTransformBG();//透视变换视频第一帧
                VideoFirstFrame vff = new VideoFirstFrame();//透视变换球场平面图
                GlobalVariables.SRCCOUNT = 0;//视频帧中选择的点数记录
                GlobalVariables.DSTCOUNT = 0;//球场平面图中选择的点数记录
                vff.Show();
                bg.Show();
                MessageBox.Show("请在左右窗口中分别选择四个透视变换对应点", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                //视频分析完成后将项目改成待分析状态

                //回到主界面
                

            }

        }
    }
}