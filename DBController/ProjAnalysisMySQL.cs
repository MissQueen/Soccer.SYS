using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer.SYS.DBController
{
    class ProjAnalysisMySQL
    {
        /*创建项目中用到的视频所在位置的数据表 project_项目id*/
        public static bool CreateVideoTable(string path, int id)
        {
            bool state = false;
            //判断数据库中是否存在某张表，若存在则将path插入该表，否则创建数据表并插入path
            ConnMySQL conn = new ConnMySQL();
            string tableName = "project_videos_" + id.ToString();
            path = path.Replace("\\", "\\\\");
            string search = "SELECT * FROM information_schema.TABLES WHERE table_name='" + tableName + "' AND TABLE_SCHEMA='soccer_database'";
            string create = "CREATE TABLE IF NOT EXISTS soccer_database." + tableName + "(id int(11) NOT NULL AUTO_INCREMENT," +
                "path varchar(100) DEFAULT NULL," +
                "PRIMARY KEY (id)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8";
            if (conn.CreateTable(tableName, search, create))
            {
                conn.InsertContentAccordName(tableName, "path", path);
                state = true;
            }
            return state;
        }
        /*创建项目中球员坐标记录表*/
        public static bool CreatePlayerTable(int id)
        {
            bool state = false;
            ConnMySQL conn = new ConnMySQL();
            string tableName = "project_player_" + id.ToString();
            string search = "SELECT * FROM information_schema.TABLES WHERE table_name='" + tableName + "' AND TABLE_SCHEMA='soccer_database'";
            string create = "CREATE TABLE IF NOT EXISTS soccer_database." + tableName +
                "(id int(11) NOT NULL AUTO_INCREMENT," + "frame int(11) DEFAULT 1, " +
                "playerx1 double DEFAULT 0.0," + "playery1 double DEFAULT 0.0," + "player1_count int(11) DEFAULT 0," +
                "playerx2 double DEFAULT 0.0," + "playery2 double DEFAULT 0.0," + "player2_count int(11) DEFAULT 0," +
                "playerx3 double DEFAULT 0.0," + "playery3 double DEFAULT 0.0," + "player3_count int(11) DEFAULT 0," +
                "playerx4 double DEFAULT 0.0," + "playery4 double DEFAULT 0.0," + "player4_count int(11) DEFAULT 0," +
                "playerx5 double DEFAULT 0.0," + "playery5 double DEFAULT 0.0," + "player5_count int(11) DEFAULT 0," +
                "playerx6 double DEFAULT 0.0," + "playery6 double DEFAULT 0.0," + "player6_count int(11) DEFAULT 0," +
                "playerx7 double DEFAULT 0.0," + "playery7 double DEFAULT 0.0," + "player7_count int(11) DEFAULT 0," +
                "playerx8 double DEFAULT 0.0," + "playery8 double DEFAULT 0.0," + "player8_count int(11) DEFAULT 0," +
                "playerx9 double DEFAULT 0.0," + "playery9 double DEFAULT 0.0," + "player9_count int(11) DEFAULT 0," +
                "playerx10 double DEFAULT 0.0," + "playery10 double DEFAULT 0.0," + "player10_count int(11) DEFAULT 0," +
                "playerx11 double DEFAULT 0.0," + "playery11 double DEFAULT 0.0," + "player11_count int(11) DEFAULT 0," +
                "playerx12 double DEFAULT 0.0," + "playery12 double DEFAULT 0.0," + "player12_count int(11) DEFAULT 0," +
                "playerx13 double DEFAULT 0.0," + "playery13 double DEFAULT 0.0," + "player13_count int(11) DEFAULT 0," +
                "playerx14 double DEFAULT 0.0," + "playery14 double DEFAULT 0.0," + "player14_count int(11) DEFAULT 0," +
                "playerx15 double DEFAULT 0.0," + "playery15 double DEFAULT 0.0," + "player15_count int(11) DEFAULT 0," +
                "playerx16 double DEFAULT 0.0," + "playery16 double DEFAULT 0.0," + "player16_count int(11) DEFAULT 0," +
                "playerx17 double DEFAULT 0.0," + "playery17 double DEFAULT 0.0," + "player17_count int(11) DEFAULT 0," +
                "playerx18 double DEFAULT 0.0," + "playery18 double DEFAULT 0.0," + "player18_count int(11) DEFAULT 0," +
                "playerx19 double DEFAULT 0.0," + "playery19 double DEFAULT 0.0," + "player19_count int(11) DEFAULT 0," +
                "playerx20 double DEFAULT 0.0," + "playery20 double DEFAULT 0.0," + "player20_count int(11) DEFAULT 0," +
                "playerx21 double DEFAULT 0.0," + "playery21 double DEFAULT 0.0," + "player21_count int(11) DEFAULT 0," +
                "playerx22 double DEFAULT 0.0," + "playery22 double DEFAULT 0.0," + "player22_count int(11) DEFAULT 0," +
                "playerx23 double DEFAULT 0.0," + "playery23 double DEFAULT 0.0," + "player23_count int(11) DEFAULT 0," +
                "playerx24 double DEFAULT 0.0," + "playery24 double DEFAULT 0.0," + "player24_count int(11) DEFAULT 0," +
                "playerx25 double DEFAULT 0.0," + "playery25 double DEFAULT 0.0," + "player25_count int(11) DEFAULT 0," +
                "playerx26 double DEFAULT 0.0," + "playery26 double DEFAULT 0.0," + "player26_count int(11) DEFAULT 0," +
                "PRIMARY KEY (id)) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8";
            return conn.CreateTable(tableName, search, create);
        }

        /*根据项目id创建项目分析表*/
        public static bool CreateAnalysisTable(int id)
        {
            bool state = false;
            ConnMySQL conn = new ConnMySQL();
            string tableName = "project_analysis_" + id.ToString();
            string playerTableName = "project_player_analysis_" + id.ToString();
            string search = "SELECT * FROM information_schema.TABLES WHERE table_name='" + tableName + "' AND TABLE_SCHEMA='soccer_database'";
            string searchplayer = "SELECT * FROM information_schema.TABLES WHERE table_name='" + playerTableName + "' AND TABLE_SCHEMA='soccer_database'";
            string createpalyer = "";
            string create = "";
            return conn.CreateTable(tableName, search, create);
            return state;
        }

        /*根据项目id获取视频路径并存入GlobalVariables.ALL_VIDEO_PATH*/
        public static void GetVideoPaths(int id)
        {
            string tableName = "project_videos_" + id.ToString();
            GlobalVariables.ALL_VIDEO_PATH = new ConnMySQL().GetContentAccordName(tableName); 
        }

        /*根据id获取球员坐标信息并存入数据库，在分析时处理*/
        public static void ReadPlayerPosition(int id)
        {
            //当前项目路径
            string path = GlobalVariables.PROJECT_PATH;
            //获取当前路径下的所有文件夹
            DirectoryInfo dir = new DirectoryInfo(path);

            DirectoryInfo[] dirs  = dir.GetDirectories();

            FileInfo[] files;
            List<string> dirPaths = new List<string>();
            ConnMySQL connMySQL = new ConnMySQL();
            //打开数据库连接
            MySqlConnection conn = connMySQL.MySqlConnection1();
            //没有player表则创建表
            CreatePlayerTable(id);
            //以数字命名的文件夹的路径存入dirpaths
            foreach (DirectoryInfo dirpath in dirs)
            {
                dirPaths.Add(dirpath.FullName);
            }
            //每个文件夹下的txt文件内容分别存入数据库
            foreach (string dirname in dirPaths)
            {
                dir = new DirectoryInfo(dirname);
                files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    int playerno = getNo(file.Name,'.');
                    //读取file文件内容并存入数据库
                    string txtpath = file.FullName;
                    StreamReader sr = new StreamReader(txtpath);
                    while (!sr.EndOfStream)
                    {
                        string content = sr.ReadLine();
                        string[] pos = content.Split(' ');
                        //获取帧号、player的坐标和被跟踪到的次数，为空则插入，否则更新
                        int frameno = int.Parse(pos[0]);//帧号
                        string tablename = "project_player_" + id.ToString();//表名
                        string query = "SELECT * FROM " + tablename + " WHERE frame='" + frameno.ToString() + "'";//根据帧号查询
                        MySqlCommand command = new MySqlCommand(query, conn);
                        MySqlDataReader dataReader = command.ExecuteReader();
                        string columnplayerx = "playerx" + playerno.ToString();//列名x
                        string columnplayery = "playery" + playerno.ToString();//列明y
                        string columnplayercount = "player"+ playerno.ToString() + "_count";//列明 跟踪数
                        if (dataReader.Read())
                        {
                            //数据库里有数据则更新
                            int playercount = dataReader.GetInt32(playerno * 3 + 1) + 1;
                            double playerx = dataReader.GetDouble(playerno * 3 - 1) + double.Parse(pos[1]);
                            double playery = dataReader.GetDouble(playerno * 3) + double.Parse(pos[2]);
                            dataReader.Close();
                            string update = "UPDATE " + tablename + " SET " + columnplayerx + "=" + playerx + "," + columnplayery + "=" +
                                playery + "," + columnplayercount + "=" + playercount + " WHERE frame=" + frameno;
                            MySqlCommand updateCommand = new MySqlCommand(update, conn);
                            updateCommand.ExecuteNonQuery();
                            updateCommand.Dispose();
                        }
                        else
                        {
                            dataReader.Close();
                            //数据库里无数据则插入
                            string insert = "INSERT INTO " + tablename + " (frame," + columnplayerx +"," + columnplayery + "," +columnplayercount +") VALUES ("+frameno+"," + double.Parse(pos[1]) + "," + double.Parse(pos[2]) + ", 1)";
                            MySqlCommand insertCommand = new MySqlCommand(insert, conn);
                            insertCommand.ExecuteNonQuery();
                            insertCommand.Dispose();
                        }
                        command.Dispose();
                    }
                    
                }
            }
            string table_name = "project_player_" + id.ToString();
            string updatedata = "UPDATE " + table_name + " SET playerx1=if(player1_count<>0,playerx1/player1_count,0.0),playery1=if(player1_count<>0,playery1/player1_count,0.0)," +
                "playerx2=if(player2_count<>0,playerx2/player2_count,0.0),playery2=if(player2_count<>0,playery2/player2_count,0.0)," +
                "playerx3=if(player3_count<>0,playerx3/player3_count,0.0),playery3=if(player3_count<>0,playery3/player3_count,0.0)," +
                "playerx4=if(player4_count<>0,playerx4/player4_count,0.0),playery4=if(player4_count<>0,playery4/player4_count,0.0)," +
                "playerx5=if(player5_count<>0,playerx5/player5_count,0.0),playery5=if(player5_count<>0,playery5/player5_count,0.0)," +
                "playerx6=if(player6_count<>0,playerx6/player6_count,0.0),playery6=if(player6_count<>0,playery6/player6_count,0.0)," +
                "playerx7=if(player7_count<>0,playerx7/player7_count,0.0),playery7=if(player7_count<>0,playery7/player7_count,0.0)," +
                "playerx8=if(player8_count<>0,playerx8/player8_count,0.0),playery8=if(player8_count<>0,playery8/player8_count,0.0)," +
                "playerx9=if(player9_count<>0,playerx9/player9_count,0.0),playery9=if(player9_count<>0,playery9/player9_count,0.0)," +
                "playerx10=if(player10_count<>0,playerx10/player10_count,0.0),playery10=if(player10_count<>0,playery10/player10_count,0.0)," +
                "playerx11=if(player11_count<>0,playerx11/player11_count,0.0),playery11=if(player11_count<>0,playery11/player11_count,0.0)," +
                "playerx12=if(player12_count<>0,playerx12/player12_count,0.0),playery12=if(player12_count<>0,playery12/player12_count,0.0)," +
                "playerx13=if(player13_count<>0,playerx13/player13_count,0.0),playery13=if(player13_count<>0,playery13/player13_count,0.0)," +
                "playerx14=if(player14_count<>0,playerx14/player14_count,0.0),playery14=if(player14_count<>0,playery14/player14_count,0.0)," +
                "playerx15=if(player15_count<>0,playerx15/player15_count,0.0),playery15=if(player15_count<>0,playery15/player15_count,0.0)," +
                "playerx16=if(player16_count<>0,playerx16/player16_count,0.0),playery16=if(player16_count<>0,playery16/player16_count,0.0)," +
                "playerx17=if(player17_count<>0,playerx17/player17_count,0.0),playery17=if(player17_count<>0,playery17/player17_count,0.0)," +
                "playerx18=if(player18_count<>0,playerx18/player18_count,0.0),playery18=if(player18_count<>0,playery18/player18_count,0.0)," +
                "playerx19=if(player19_count<>0,playerx19/player19_count,0.0),playery19=if(player19_count<>0,playery19/player19_count,0.0)," +
                "playerx20=if(player20_count<>0,playerx20/player20_count,0.0),playery20=if(player20_count<>0,playery20/player20_count,0.0)," +
                "playerx21=if(player21_count<>0,playerx21/player21_count,0.0),playery21=if(player21_count<>0,playery21/player21_count,0.0)," +
                "playerx22=if(player22_count<>0,playerx22/player22_count,0.0),playery22=if(player22_count<>0,playery22/player22_count,0.0)," +
                "playerx23=if(player23_count<>0,playerx23/player23_count,0.0),playery23=if(player23_count<>0,playery23/player23_count,0.0)," +
                "playerx24=if(player24_count<>0,playerx24/player24_count,0.0),playery24=if(player24_count<>0,playery24/player24_count,0.0)," +
                "playerx25=if(player25_count<>0,playerx25/player25_count,0.0),playery25=if(player25_count<>0,playery25/player25_count,0.0)," +
                "playerx26=if(player26_count<>0,playerx26/player26_count,0.0),playery26=if(player26_count<>0,playery26/player26_count,0.0)";
            MySqlCommand update_Command = new MySqlCommand(updatedata, conn);
            update_Command.ExecuteNonQuery();
            update_Command.Dispose();
            conn.Close();//关闭数据库连接
        }

        //根据ch分割filename
        public static int getNo(string filename,char ch)
        {
            string str = "";
            for(int i = 0; i < filename.Length; i++)
            {
                if (filename[i] != ch) str += filename[i];
                else break;
            }
            return int.Parse(str); ;
        }

        //查找
        public static void updateTable(string tablename,string[] pos)
        {

        } 

        /*根据表名获取数据条数*/
        public static int GetDataRows(string tablename)
        {
            int counts = 0;
            //打开数据库连接
            MySqlConnection conn = new ConnMySQL().MySqlConnection1();
            string query = "SELECT count(*) FROM " + tablename;
            /*MySqlCommand command = new MySqlCommand(query, conn);
            */
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = query;
            counts = Convert.ToInt32(command.ExecuteScalar());
            command.Dispose();
            conn.Close();
            return counts;
            
        }
        /*获取数据库中记录的球员位置*/
        public static void GetDBPlayerList(string tablename)
        {
            MySqlConnection conn = new ConnMySQL().MySqlConnection1();
            string query = "SELECT * FROM " + tablename;
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            if (GlobalVariables.PLAYER_POS.Count > 0) GlobalVariables.PLAYER_POS.Clear();
            while (dataReader.Read())
            {
                List<PlayerUtil> list = new List<PlayerUtil>();
                for (int i = 2; i < 78; i += 3)
                {
                    
                    PlayerUtil player = new PlayerUtil();
                    player.x = (double)dataReader.GetDouble(i);
                    player.y = (double)dataReader.GetDouble(i + 1);
                    player.playercount = (int)dataReader.GetInt32(i + 2);
                    list.Add(player);
                }
                GlobalVariables.PLAYER_POS.Add(list);
                Console.WriteLine("GlobalVariables.PLAYER_POS" + GlobalVariables.PLAYER_POS[0].Count.ToString());
            }
            dataReader.Close();
            command.Dispose();
            conn.Close();
        }



        /*根据坐标判断场区，0为前场，1为中场，2为后场*/
    }
}
