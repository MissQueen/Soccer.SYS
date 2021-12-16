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
        /*�Ƿ��Զ�����*/
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
        /*�����Ŀ����*/
        private void del_name_btn_Click(object sender, EventArgs e)
        {
            proj_name_text.Text = "";
        }
        /*�����������*/
        private void del_teamaname_btn_Click(object sender, EventArgs e)
        {
            team_a_text.Text = "";
        }
        /*��տͶ�����*/
        private void del_teambname_btn_Click(object sender, EventArgs e)
        {
            team_b_text.Text = "";
        }
        /*ѡ����Ŀ�洢·��*/
        private void proj_loc_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "��ѡ����Ŀ�洢·��";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                proj_loc_text.Text = dialog.SelectedPath+"\\"+proj_name_text.Text;
            }
        }
        /*��������Ŀ������Ŀ������Ϣ�������ݿ�**/
        private void create_proj_btn_Click(object sender, EventArgs e)
        {
            GlobalVariables.IF_OLD_PROJ = false;//�Ƿ�༭������Ƶ
            GlobalVariables.CURRENT_VIDEO = 0;//ȫ�ֵ�ǰ��Ƶ
            string projName = proj_name_text.Text;//��Ŀ��
            DateTime dateTime = DateTime.Now;//����ʱ��
            int projType = games_type_combox.SelectedIndex;//��������
            string projLoc = proj_loc_text.Text;//��Ŀλ��
            //projLoc = projLoc.ToString().Replace("\\","\\\\");//���ļ�·��������
            int videoCount = (int) proj_video_count.Value;//��Ƶ��
            string teamaName = team_a_text.Text;//������
            string teambName = team_b_text.Text;//�Ͷ���
            ProjectUtil projectUtil = new ProjectUtil(GlobalVariables.USER_ID, projName, dateTime, 
                                                    projType, projLoc, videoCount, teamaName, teambName,GlobalVariables.USERNAME);
            
            //����Ŀ·����������Ŀ�ļ���
            if (ControlsOperations.CreatePorjectFile(projLoc))
            {
                //������Ŀ·��
                projectUtil.ProjLocation = GlobalVariables.PROJECT_PATH.Replace("\\", "\\\\");
                //��Ŀ��Ϣ�������ݿ�
                if(new ConnMySQL().InsertNewProj(projectUtil) == 1)
                {
                    GlobalVariables.SUM_VIDEO = (int)proj_video_count.Value; //ȫ�ֱ���������Ƶ��
                    GlobalVariables.PROJECTSTATE = 2;//��Ŀ�½�ʱ����ʼ״̬Ϊ2
                    GlobalVariables.PLAYER_START_NO = (int)player_start_no.Value; //ȫ�ֱ�������Ա��ʼ���
                    /**********/
                    if (tracker_method.SelectedIndex != 0) GlobalVariables.TRACKER_METHOD = tracker_method.SelectedIndex - 1;//���ø��ٷ���
                    else GlobalVariables.TRACKER_METHOD = 0;
                    if (if_single_object.Checked)
                    {
                        int playerno = -1;
                        try
                        {
                            playerno = int.Parse(player_no.Text);
                            GlobalVariables.PLAYER_NO = int.Parse(player_no.Text);//��Ϊ��Ŀ����٣�������Ա���
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
                    /***�ŵ�Ŀ�����ģ����***/
                    this.Close();
                }
                else
                {
                    MessageBox.Show("���ݿ����ʧ��");
                }
            }
            else
            {
                MessageBox.Show("�ļ��д���ʧ�ܣ�");
            }
        }
        /*��������Ĭ��ѡ��5v5*/
        private void CreateProject_Load(object sender, EventArgs e)
        {
            games_type_combox.SelectedIndex = 0;
            tracker_method.SelectedIndex = 0;
            if_single_object.Checked = false;
            player_no.Enabled = false;
            Image img = Image.FromFile("court_bg.png");
            img.Save("court_.png");
        }
        /*���봰�ں�Ĭ�Ͼ۽����ı���*/
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
        /*������ͼƬ*/
        private string setImage()
        {
            double width = Double.Parse(court_height_text.Text)/4;//�򳡳���/4(��С4��)
            double heigth = Double.Parse(court_width_text.Text)/4;//�򳡿��/4����С4����
            double y_width = width / 2.54;
            double y_height = heigth / 2.54;//תӢ��
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            float dpiX = g.DpiX;//dpi
            GlobalVariables.DPI = dpiX;//ȫ�ֱ���DPI
            int w = (int)y_width * (int)dpiX;
            int h = (int)y_height * (int)dpiX;
            Image img = Image.FromFile(@"court_bg.png");
            Bitmap bitmap = new Bitmap(img, w, h);
            custom_court_picbox.Image = bitmap;
            custom_court_picbox.Image.Save("court_analysis_.png");
            return w.ToString()+" "+h.ToString();
        }
        Point[] default_points;
        /*���ɱ�ʶ���ı���ͼƬ��С*/
        private void creat_signs_btn_Click(object sender, EventArgs e)
        {
            string w_h = setImage();
            string[] strs = w_h.Split(' ');
            int w = int.Parse(strs[0]);
            int h = int.Parse(strs[1]);
            
            int sign_count = int.Parse(signs_count_text.Text);//��ȡ��ʶ��
            //��ʶ��Ϊż��ƽ�����������ߣ��������϶�����
            //����λ��
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
            //����
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
        //ͼƬ�ϻ���
        private void PaintDot(Point[] points)
        {
            //���ɻ���
            Graphics graph = Graphics.FromImage(custom_court_picbox.Image);
            for(int i = 1; i < points.Length; i++)
            {
                graph.FillEllipse(Brushes.Blue, points[i].X, points[i].Y, 10, 10);
                graph.DrawString(i.ToString(), new Font("΢���ź�", 10, FontStyle.Bold), new SolidBrush(Color.White), points[i].X, points[i].Y);
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
            double width = Double.Parse(court_height_text.Text);//�򳡳���
            double height = Double.Parse(court_width_text.Text);//�򳡿��

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
            //����ͼƬ
            
        }
    }
}