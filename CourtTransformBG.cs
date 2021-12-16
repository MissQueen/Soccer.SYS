using OpenCvSharp;
using Qios.DevSuite.Components;
using Soccer.SYS.ControlsOperation;
using Soccer.SYS.DBController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Soccer.SYS
{
    public partial class CourtTransformBG : Qios.DevSuite.Components.Ribbon.QRibbonForm
    {
        public CourtTransformBG()
        {
            InitializeComponent();
        }
/*        protected override void OnClosing(CancelEventArgs e)
        {
            if(Application.OpenForms.Count<=2)
                GlobalVariables.MAINWINDDOW.Visible = true;
        }*/
        private void CourtTransformBG_Load(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width / 2,200);//设置窗口位置为右半区域
            FileStream fs = new FileStream(@"court_.png", FileMode.Open, FileAccess.Read);//加载球场平面图
            /*窗口属性设置*/
            Image img = Image.FromStream(fs);
            this.Width = img.Width+4;
            this.Height = img.Height+32;
            court_picbox.Image = img;
            this.MaximumSize = new System.Drawing.Size(this.Width, this.Height);
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
           /* Console.WriteLine("court_transform-x：" + court_transform.Size.Width.ToString() + "    court_transform-y：" + court_transform.Size.Height.ToString());
            Console.WriteLine("x：" + court_picbox.Size.Width.ToString() + "   y：" + court_picbox.Size.Height.ToString());
            */
        }
        /*透视变换dst四个点*/
        [DllImport("DLLDemo1.dll", CallingConvention = CallingConvention.Cdecl)]
        extern static void TrackingObjects(int trackerType, int videoCount, int playerno, int startno);
        [DllImport("DLLDemo1.dll", CallingConvention = CallingConvention.Cdecl)]
        extern static void getSrcPoint();
        private void court_picbox_Click(object sender, EventArgs e)
        {
            //所选点数不足4个 可继续添加
            if (GlobalVariables.DSTCOUNT < 4)
            {
                Graphics g = court_picbox.CreateGraphics();
                Point2f pos = new Point2f(Control.MousePosition.X, Control.MousePosition.Y);
                g.FillEllipse(Brushes.Red, pos.X - this.Location.X, pos.Y - this.Location.Y - this.court_transform.Size.Height, 8, 8);
                GlobalVariables.DSTPOINT[GlobalVariables.DSTCOUNT] = new Point2f(pos.X - this.Location.X,
                                                                                pos.Y - this.Location.Y - this.court_transform.Size.Height);
                GlobalVariables.DSTCOUNT += 1;
            }
            //所选点数大于等于四个时跳转到视频分析窗口
            if (GlobalVariables.SRCCOUNT >= 4 && GlobalVariables.DSTCOUNT >= 4)
            {
                Console.WriteLine(GlobalVariables.SRCPOINT[0].ToString() + " " + GlobalVariables.SRCPOINT[1].ToString());
                Application.OpenForms["CourtTransformBG"].Close();
                Application.OpenForms["VideoFirstFrame"].Close();
                //点写入txt文件
                ControlsOperations.WritePoints();
                //此处展示目标跟踪模块
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
                    ProjAnalysisMySQL.ReadPlayerPosition(GlobalVariables.PROJECTID);

                    GlobalVariables.MAINWINDDOW.Visible = true;
                    GlobalVariables.MAINWINDDOW.Activate();

                    System.Diagnostics.Process.Start("explorer.exe", GlobalVariables.PROJECT_PATH);
                }
            }
        }
    }
}