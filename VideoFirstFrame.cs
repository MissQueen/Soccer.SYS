using OpenCvSharp;
using Qios.DevSuite.Components;
using Soccer.SYS.ControlsOperation;
using Soccer.SYS.DBController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Soccer.SYS
{
    public partial class VideoFirstFrame : Qios.DevSuite.Components.Ribbon.QRibbonForm
    {
        public VideoFirstFrame()
        {
            InitializeComponent();
        }

        private void VideoFirstFrame_Load(object sender, EventArgs e)
        {
            //获取视频第一帧
            Process process = new Process();
            process.StartInfo.FileName = @"E:\CProj\C-WinForm\Soccer.SYS\bin\Debug\ffmpeg.exe";
            process.StartInfo.Arguments = @"-y -i " + GlobalVariables.CURRENT_VIDEO_PATH + " -ss 1 -f image2 "+ GlobalVariables.PROJECT_PATH + @"\firstframe.jpg";
            process.Start();
            process.WaitForExit();
            process.Close();
            process.Dispose();
            //减小图片尺寸到原来的1/4，并设置窗口属性
            Image img = Image.FromFile(GlobalVariables.PROJECT_PATH + @"\firstframe.jpg");
            Bitmap bitmap = new Bitmap(img, img.Width / 2, img.Height / 2);
            this.Width = bitmap.Width + 4;
            this.Height = bitmap.Height + 32;
            first_frame_picbox.Image = bitmap ;
            this.MaximumSize = new System.Drawing.Size(this.Width, this.Height);
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
        }
/*        protected override void OnClosing(CancelEventArgs e)
        {
            if (Application.OpenForms.Count <= 2)
                GlobalVariables.MAINWINDDOW.Visible = true;
        }*/
        /*透视变换src四个点*/
        [DllImport("DLLDemo1.dll", CallingConvention = CallingConvention.Cdecl)]
        extern static void TrackingObjects(int trackerType, int videoCount, int playerno, int startno);
        [DllImport("DLLDemo1.dll", CallingConvention = CallingConvention.Cdecl)]
        extern static void getSrcPoint();
        private void first_frame_picbox_Click(object sender, EventArgs e)
        {
            //点数不足4个时可以继续添加
            if (GlobalVariables.SRCCOUNT < 4)
            {
                Graphics g = first_frame_picbox.CreateGraphics();
                Point2f pos = new Point2f(Control.MousePosition.X, Control.MousePosition.Y);
                g.FillEllipse(Brushes.Red, pos.X - this.Location.X, pos.Y - this.Location.Y - this.court_transform.Size.Height, 8, 8);
                GlobalVariables.SRCPOINT[GlobalVariables.SRCCOUNT] = new Point2f((pos.X - this.Location.X)*2,
                                                                                (pos.Y - this.Location.Y - this.court_transform.Size.Height)*2);
                GlobalVariables.SRCCOUNT += 1;
            }
            //点数超过4个时打开视频分析窗口
            if (GlobalVariables.SRCCOUNT >= 4 && GlobalVariables.DSTCOUNT >= 4)
            {
                Console.WriteLine(GlobalVariables.SRCPOINT[0].ToString()+" "+ GlobalVariables.SRCPOINT[1].ToString());
                Application.OpenForms["CourtTransformBG"].Close();
                Application.OpenForms["VideoFirstFrame"].Close();
                //点写入txt文件
                ControlsOperations.WritePoints();
               //打开视频分析窗口~~调用自定义库函数
                TrackingObjects(GlobalVariables.TRACKER_METHOD, GlobalVariables.CURRENT_VIDEO, GlobalVariables.PLAYER_NO, GlobalVariables.PLAYER_START_NO);
                if (GlobalVariables.CURRENT_VIDEO < GlobalVariables.SUM_VIDEO)
                {
                    VideoChoose vc = new VideoChoose();
                    vc.Show();
                }
                else
                {
                    //更新刚创建的项目或之前创建的项目
                    if (GlobalVariables.IF_OLD_PROJ)                   
                        new ConnMySQL().UpdateNewProj(GlobalVariables.PROJECTID);
                    else
                        new ConnMySQL().UpdateNewProj(GlobalVariables.NEW_PROJ_ID);
                    
                    //存有球员位置信息的txt文件路径写入txt
                    ControlsOperations.WritePaths(GlobalVariables.PROJECT_PATH);
                    getSrcPoint();
                    //球员位置信息存入数据库
                    ProjAnalysisMySQL.ReadPlayerPosition(GlobalVariables.PROJECTID);
                    //处理已存入数据库的球员坐标信息
                    GlobalVariables.MAINWINDDOW.Visible = true;
                    GlobalVariables.MAINWINDDOW.Activate();
                    System.Diagnostics.Process.Start("explorer.exe", GlobalVariables.PROJECT_PATH);
                }
            }
        }
    }
}