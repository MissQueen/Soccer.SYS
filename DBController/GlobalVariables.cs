using OpenCvSharp;
using OpenCvSharp.CPlusPlus;
using System.Collections.Generic;

namespace Soccer.SYS.DBController
{
    /*所有全局变量*/
    class GlobalVariables
    {
        /*主窗口*/
        public static MainWindow MAINWINDDOW;
        /*登录成功状态*/
        public static int LOGIN_STATE = 0;
        /*当前登录的用户ID*/
        public static int USER_ID;
        /*当前用户名*/
        public static string USERNAME = "";
        /*当前用户密码*/
        public static string PASSWORD = "";
        /*主界面做菜单选项*/
        public static int MENUITEM = 0;
        /*当前选中的项目id*/
        public static int PROJECTID = 0;
        /*当前选中的项目状态*/
        public static int PROJECTSTATE = 0;
        /*当前选中项目名称*/
        public static string PROJECTNAME = "";
        /*当前选中的项目创建者*/
        public static string PROJECTOWNER = "";
        /*当前项目地址*/
        public static string PROJECT_PATH;
        /*总视频数*/
        public static int SUM_VIDEO = 1;
        /*当前处理的视频编号*/
        public static int CURRENT_VIDEO = 0;
        /*当前处理的视频地址*/
        public static string CURRENT_VIDEO_PATH = "";
        /*透视变换src点*/
        public static Point2f[] SRCPOINT = new Point2f[4];
        /*透视变换dst点*/
        public static Point2f[] DSTPOINT = new Point2f[4];
        /*透视变换源窗口单击次数*/
        public static int SRCCOUNT = 0;
        /*透视变换目的窗口单击次数*/
        public static int DSTCOUNT = 0;
        /*单目标跟踪状态下球员编号，默认-1*/
        public static int PLAYER_NO = -1;
        /*跟踪方法，默认CSRT*/
        public static int TRACKER_METHOD = 0;
        /*刚创建项目的id*/
        public static long NEW_PROJ_ID = 0;
        /*是否自定义球场*/
        public static bool IF_CUS_COURT = false;
        /*编辑的是新建项目或已有项目*/
        public static bool IF_OLD_PROJ = false;
        /*dpi*/
        public static float DPI = 0.0f;
        /*所有视频路径*/
        public static List<string> ALL_VIDEO_PATH;
        /*球员起始编号*/
        public static int PLAYER_START_NO = 0;
        /*球员位置*/
        public static List<List<PlayerUtil>> PLAYER_POS = new List<List<PlayerUtil>>();
        /*视频当前帧*/
        public static int CURRENTFRAME = 0;
     }
}
