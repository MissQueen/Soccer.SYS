using AxWMPLib;
using Qios.DevSuite.Components;
using Soccer.SYS.DBController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Soccer.SYS
{
    public partial class VideoAnalysis : Qios.DevSuite.Components.Ribbon.QRibbonForm
    {
        public VideoAnalysis()
        {
            InitializeComponent();
        }
        public string videoPath { get; set; }
        int black_left_width;//图片左边留白
        int black_top_height;//图片右边留白
        double rate;//缩放比例
        List<Button> btns = new List<Button>();
        private void VideoAnalysis_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"court_analysis_.png");
            Bitmap bitmap = new Bitmap(img, img.Width, img.Height);
            choosed_player_list.SelectedIndex = 0;
            wanted_tables_list.SelectedIndex = 0;
            court_picbox.Image = bitmap;
            btns.Clear();
            btns.Add(player_btn_1);
            btns.Add(player_btn_2);
            btns.Add(player_btn_3);
            btns.Add(player_btn_4);
            btns.Add(player_btn_5);
            btns.Add(player_btn_6);
            btns.Add(player_btn_7);
            btns.Add(player_btn_8);
            btns.Add(player_btn_9);
            btns.Add(player_btn_10);
            btns.Add(player_btn_11);
            btns.Add(player_btn_12);
            btns.Add(player_btn_13);
            btns.Add(player_btn_14);
            btns.Add(player_btn_15);
            btns.Add(player_btn_16);
            btns.Add(player_btn_17);
            btns.Add(player_btn_18);
            btns.Add(player_btn_19);
            btns.Add(player_btn_20);
            btns.Add(player_btn_21);
            btns.Add(player_btn_22);
            btns.Add(player_btn_23);
            btns.Add(player_btn_24);
            Console.WriteLine(btns[0].Visible.ToString() + "设置的啥：" + btns[23].Visible.ToString());
            int originalWidth = court_picbox.Image.Width;//原始图片宽度
            int originalHeight = court_picbox.Image.Height;//原始图片高度
            PropertyInfo rectangleProperty = court_picbox.GetType().GetProperty("ImageRectangle", BindingFlags.Instance | BindingFlags.NonPublic);
            Rectangle rectangle = (Rectangle)rectangleProperty.GetValue(court_picbox, null);
            int currentWidth = rectangle.Width;
            int currentHeight = rectangle.Height;
            rate = (double)currentHeight / (double)originalHeight;//比例
            black_left_width = (currentWidth == court_picbox.Width) ? 0 : (court_picbox.Width - currentWidth)/2;
            black_top_height = (currentHeight == court_picbox.Height) ? 0 : (court_picbox.Height - currentHeight) / 2;
            Console.WriteLine("rate：" + rate.ToString() + "location：" + currentWidth.ToString() + " " + currentHeight.ToString());
            int currentvideosum = GlobalVariables.ALL_VIDEO_PATH.Count;
            //将球员信息存入列表
            ProjAnalysisMySQL.GetDBPlayerList("project_player_" + GlobalVariables.PROJECTID.ToString());
            if (currentvideosum == 1)
            {
                tableLayoutPanel8.SetColumnSpan(video_player, 2);
            }
            video_player.URL = videoPath;
            video_player.Ctlcontrols.stop();
            //视频总帧数
            int frames = ProjAnalysisMySQL.GetDataRows("project_player_" + GlobalVariables.PROJECTID);
            video_play_timer.Interval = 40;
            
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count <= 2)
                GlobalVariables.MAINWINDDOW.Visible = true;
        }
        int i = 0;
     
        
        private void video_play_timer_Tick(object sender, EventArgs e)
        {
            //生成画板
            if (GlobalVariables.PLAYER_POS.Count > 0)
            {
                Console.WriteLine("PLAYER_POS.Count"+ GlobalVariables.PLAYER_POS.Count.ToString()+" "+ GlobalVariables.PLAYER_POS[0].Count.ToString());
                for(int j = 0; j < GlobalVariables.PLAYER_POS[0].Count; j++)
                {
                    Console.WriteLine("j：" + j.ToString());
                    if (GlobalVariables.PLAYER_POS[i][j].playercount > 0)
                    {
                        PointF posc = new PointF((float)GlobalVariables.PLAYER_POS[i][j].x, (float)GlobalVariables.PLAYER_POS[i][j].y);
                        Console.WriteLine(posc.X.ToString() + "  ***  " + posc.Y.ToString());
                        btns[j].Location = new Point((int)(posc.X * rate + black_left_width), (int)(posc.Y * rate + black_top_height));
                        if (btns[j].Visible == false)
                        {
                            btns[j].Visible = true;
                        }
                    }
                }
            }
            i++;
        }

        private void video_player_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 3)
            {
                video_play_timer.Start();
            }
            if (e.newState == 2)
            {
                video_play_timer.Stop();
            }
            if (e.newState == 1)
            {
                video_play_timer.Dispose();
                i = 0;
                for (int i = 0; i < btns.Count; i++) btns[i].Visible = false;
            }
            Console.WriteLine(video_play_timer.ToString());
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}