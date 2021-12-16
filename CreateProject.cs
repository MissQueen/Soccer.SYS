using Soccer.SYS.ControlsOperation;
using Soccer.SYS.DBController;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Soccer.SYS
{
    public partial class CreateProject : Qios.DevSuite.Components.Ribbon.QRibbonForm
    {
        public CreateProject()
        {
            InitializeComponent();
        }
        /*是否自定义球场*/
        private void custom_court_checkbox_CheckStateChanged(object sender, EventArgs e)
        {
            if (custom_court_checkbox.Checked)
            {
                splitContainer1.Panel2.Enabled = true;
                GlobalVariables.IF_CUS_COURT = true;
            }
            else
            {
                splitContainer1.Panel2.Enabled = false;
                GlobalVariables.IF_CUS_COURT = false;
            }
        }
        /*清空项目名称*/
        private void del_name_btn_Click(object sender, EventArgs e)
        {
            proj_name_text.Text = "";
        }
        /*清空主队名称*/
        private void del_teamaname_btn_Click(object sender, EventArgs e)
        {
            team_a_text.Text = "";
        }
        /*清空客队名称*/
        private void del_teambname_btn_Click(object sender, EventArgs e)
        {
            team_b_text.Text = "";
        }
        /*选择项目存储路径*/
        private void proj_loc_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择项目存储路径";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                proj_loc_text.Text = dialog.SelectedPath+"\\"+proj_name_text.Text;
            }
        }
        /*创建新项目，将项目基本信息存入数据库**/
        private void create_proj_btn_Click(object sender, EventArgs e)
        {
            GlobalVariables.IF_OLD_PROJ = false;//是否编辑已有视频
            GlobalVariables.CURRENT_VIDEO = 0;//全局当前视频
            string projName = proj_name_text.Text;//项目名
            DateTime dateTime = DateTime.Now;//创建时间
            int projType = games_type_combox.SelectedIndex;//比赛类型
            string projLoc = proj_loc_text.Text;//项目位置
            //projLoc = projLoc.ToString().Replace("\\","\\\\");//对文件路径作处理
            int videoCount = (int) proj_video_count.Value;//视频数
            string teamaName = team_a_text.Text;//主队名
            string teambName = team_b_text.Text;//客队名
            ProjectUtil projectUtil = new ProjectUtil(GlobalVariables.USER_ID, projName, dateTime, 
                                                    projType, projLoc, videoCount, teamaName, teambName,GlobalVariables.USERNAME);
            
            //在项目路径处创建项目文件夹
            if (ControlsOperations.CreatePorjectFile(projLoc))
            {
                //更新项目路径
                projectUtil.ProjLocation = GlobalVariables.PROJECT_PATH.Replace("\\", "\\\\");
                //项目信息插入数据库
                if(new ConnMySQL().InsertNewProj(projectUtil) == 1)
                {
                    GlobalVariables.SUM_VIDEO = (int)proj_video_count.Value; //全局变量：总视频数
                    GlobalVariables.PROJECTSTATE = 2;//项目新建时，初始状态为2
                    GlobalVariables.PLAYER_START_NO = (int)player_start_no.Value; //全局变量：球员起始编号
                    /**********/
                    if (tracker_method.SelectedIndex != 0) GlobalVariables.TRACKER_METHOD = tracker_method.SelectedIndex - 1;//设置跟踪方法
                    else GlobalVariables.TRACKER_METHOD = 0;
                    if (if_single_object.Checked)
                    {
                        int playerno = -1;
                        try
                        {
                            playerno = int.Parse(player_no.Text);
                            GlobalVariables.PLAYER_NO = int.Parse(player_no.Text);//若为单目标跟踪，设置球员编号
                        }catch(Exception exp)
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
                    /***放到目标跟踪模块下***/
                    this.Close();
                }
                else
                {
                    MessageBox.Show("数据库操作失败");
                }
            }
            else
            {
                MessageBox.Show("文件夹创建失败！");
            }
        }
        /*比赛类型默认选择5v5*/
        private void CreateProject_Load(object sender, EventArgs e)
        {
            games_type_combox.SelectedIndex = 0;
            tracker_method.SelectedIndex = 0;
            if_single_object.Checked = false;
            player_no.Enabled = false;
            Image img = Image.FromFile("court_bg.png");
            img.Save("court_.png");
        }
        /*进入窗口后默认聚焦到文本框*/
        private void CreateProject_Activated(object sender, EventArgs e)
        {
            proj_name_text.Focus();
        }

        private void if_single_object_CheckStateChanged(object sender, EventArgs e)
        {
            if (if_single_object.Checked == true)
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
        /*设置球场图片*/
        private string setImage()
        {
            double width = Double.Parse(court_height_text.Text)/4;//球场长度/4(缩小4倍)
            double heigth = Double.Parse(court_width_text.Text)/4;//球场宽度/4（缩小4倍）
            double y_width = width / 2.54;
            double y_height = heigth / 2.54;//转英寸
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            float dpiX = g.DpiX;//dpi
            GlobalVariables.DPI = dpiX;//全局变量DPI
            int w = (int)y_width * (int)dpiX;
            int h = (int)y_height * (int)dpiX;
            Image img = Image.FromFile(@"court_bg.png");
            Bitmap bitmap = new Bitmap(img, w, h);
            custom_court_picbox.Image = bitmap;
            custom_court_picbox.Image.Save("court_analysis_.png");
            return w.ToString()+" "+h.ToString();
        }
        Point[] default_points;
        /*生成标识，改变球场图片大小*/
        private void creat_signs_btn_Click(object sender, EventArgs e)
        {
            string w_h = setImage();
            string[] strs = w_h.Split(' ');
            int w = int.Parse(strs[0]);
            int h = int.Parse(strs[1]);
            
            int sign_count = int.Parse(signs_count_text.Text);//获取标识数
            //标识若为偶数平均放在球场两边，奇数则上多下少
            //计算位置
            int up, down;
            if (sign_count % 2 == 0)
            {
                up = sign_count / 2;
                
            }
            else
            {
                up = sign_count / 2 + 1;
            }
            down = sign_count / 2;
            //画点
            int updis = w / (up + 1);
            int downdis = w / (down + 1);
            Point[] points = new Point[sign_count+1];
            for(int i = 1; i <= up; i++)
            {
                points[i].X = updis * i;
                points[i].Y = 3;
            }
            for(int i = up + 1; i <= sign_count; i++)
            {
                points[i].X = downdis * (i - up);
                points[i].Y = h - 10;
            }
            default_points = points;
            PaintDot(points);
            
        }
        //图片上画点
        private void PaintDot(Point[] points)
        {
            //生成画板
            Graphics graph = Graphics.FromImage(custom_court_picbox.Image);
            for(int i = 1; i < points.Length; i++)
            {
                graph.FillEllipse(Brushes.Blue, points[i].X, points[i].Y, 10, 10);
                graph.DrawString(i.ToString(), new Font("微软雅黑", 10, FontStyle.Bold), new SolidBrush(Color.White), points[i].X, points[i].Y);
            }
            custom_court_picbox.Image.Save("court_.png");
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if(Application.OpenForms.Count<=2)
                GlobalVariables.MAINWINDDOW.Visible = true;
        }

        private void edit_signs_btn_Click(object sender, EventArgs e)
        {
            string w_h = setImage();
            string[] strs = w_h.Split(' ');
            int w = int.Parse(strs[0]);
            int h = int.Parse(strs[1]);
            double width = Double.Parse(court_height_text.Text);//球场长度
            double height = Double.Parse(court_width_text.Text);//球场宽度

            int signs_count = int.Parse(signs_count_text.Text);
            Point[] points = new Point[signs_count+1];
            double[] x = {0,Double.Parse(sign1_x_text.Text),Double.Parse(sign2_x_text.Text),Double.Parse(sign3_x_text.Text),Double.Parse(sign4_x_text.Text),
                            Double.Parse(sign5_x_text.Text),Double.Parse(sign6_x_text.Text),Double.Parse(sign7_x_text.Text),Double.Parse(sign8_x_text.Text),
                            Double.Parse(sign9_x_text.Text)};
            double[] y = {0,Double.Parse(sign1_y_text.Text),Double.Parse(sign2_y_text.Text),Double.Parse(sign3_y_text.Text),Double.Parse(sign4_y_text.Text),
                            Double.Parse(sign5_y_text.Text),Double.Parse(sign6_y_text.Text),Double.Parse(sign7_y_text.Text),Double.Parse(sign8_y_text.Text),
                            Double.Parse(sign9_y_text.Text)};
            for(int i = 1; i <= signs_count; i++)
            {
                if (x[i] != 0)
                {
                    points[i].X = (int)(x[i]/width*w);
                    if (y[i] <= 10) points[i].Y = 3;
                    else points[i].Y = h - 10;
                }
                else
                {
                    points[i] = default_points[i];
                }
            }
            PaintDot(points);
            //保存图片
            
        }
    }
}