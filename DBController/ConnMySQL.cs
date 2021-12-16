using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
//using MySQLDriverCS;
using MySql.Data.MySqlClient;
namespace Soccer.SYS.DBController
{
    class ConnMySQL
    {
        //数据库配置信息
        const string connection = "data source=localhost;database=soccer_database;user id=root;password=root;pooling=true;charset=utf8";

        /*数据库连接-使用MySQLDriver 只能在x86下编译*/
        /*        public MySQLConnection MySqlConnection()
                {
                    MySQLConnection conn = null;
                    try
                    {
                        conn = new MySQLConnection(new MySQLConnectionString(DB_NAME, USER, PASSWORD).AsString);
                        //打开连接
                        conn.Open();
                        //汉字编码问题。执行一遍之后，读出的汉字不乱码
                        MySQLCommand commn = new MySQLCommand("set names gb2312", conn);
                        commn.ExecuteNonQuery();
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    return conn;
                }
        */

        public MySqlConnection MySqlConnection1()
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(connection); 
                //打开连接
                conn.Open();
  
            }
            catch (Exception e)
            {
                Console.WriteLine("****************"+e.ToString()+"*******************");
            }
            return conn;
        }

        /*登录查询 state---0：用户不存在 1：成功 2：密码错*/
        public int QueryUser(UserUtil user)
        {
            MySqlConnection conn = MySqlConnection1();
            string query = "select * from user_list where user_name='" + user.username + "'";
            int state = 0;
            List<UserUtil> list = new List<UserUtil>();
            MySqlCommand command = new MySqlCommand(query,conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read()) {
                if (dataReader.GetString(2) == user.password)
                {
                    GlobalVariables.USER_ID = dataReader.GetInt32(0);//设置当前登录用户的USER_ID
                    state = 1;//查询到该用户且密码正确
                }
                else state = 2;//查询到该用户但密码错误
            }
            //未查询到用户
            dataReader.Close();
            conn.Close();
            return state;
        }
        /*根据菜单选项查询数据库中项目信息*/
        string[] querys = { "select * from project_list", "select * from project_list where project_state='1'", "select * from project_list where project_state='0'", "select * from project_list where project_state='2'",
                            "select * from project_list where proj_owner_id='"+GlobalVariables.USER_ID+"'"};
        public List<ProjectUtil> QueryAllProject(int listboxindex)
        {
            string query = "";
            switch (listboxindex)
            {
                case 0://全部项目
                    query = querys[0];
                    break;
                case 1://当前登录用户创建的项目
                    query = querys[4];
                    break;
                case 2://已完成项目
                    query = querys[1];
                    break;
                case 3://未完成项目
                    query = querys[2];
                    break;
                case 4://其他项目
                    query = querys[3];
                    break;
            }
            return GetDBProjectList(query); ;
        }
        /*根据项目名称或创建者查询数据库信息*/
        public List<ProjectUtil> QueryConditionProject(string context,int menuitem)
        {
            string query = "";
            string condition = "project_name like '%" + context + "%' OR proj_owner_name like '%" + context + "%'";
            switch (menuitem)
            {
                case 0:
                    query = querys[0] + " WHERE " + condition;
                    break;
                case 1:
                    query = querys[1] + " and (" + condition + ")";
                    break;
                case 2:
                    query = querys[2] + " and (" + condition + ")";
                    break;
                case 3:
                    query = querys[3] + " and (" + condition + ")";
                    break;
                case 4:
                    query = querys[4] + " and (" + condition + ")";
                    break;
            }
            return GetDBProjectList(query);
        }
        /*根据表名获取表中全部内容*/
        public List<string> GetContentAccordName(string tableName)
        {
            List<string> lists = new List<string>();
            string query = "SELECT * FROM " + tableName;
            MySqlConnection conn = MySqlConnection1();
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lists.Add(dataReader.GetString(1));
            }
            dataReader.Close();
            command.Dispose();
            conn.Close();
            return lists;
        }
       
        public List<ProjectUtil> GetDBProjectList(string query)
        {
            List<ProjectUtil> list = new List<ProjectUtil>();
            MySqlConnection conn = MySqlConnection1();
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ProjectUtil project = new ProjectUtil();
                project.Id = dataReader.GetInt32(0);
                //project.Id = (int)dataReader[0];
                project.ProjName = dataReader.GetString(2);
                //project.ProjName = dataReader[2].ToString();
                project.ProjState = dataReader.GetInt32(3);
                //project.ProjState = (int)dataReader[3];
                project.ProjDate = dataReader.GetDateTime(4);
                //project.ProjDate = (DateTime)dataReader[4];
                project.ProjType = dataReader.GetInt32(5);
                //project.ProjType = (int)dataReader[5];
                project.ProjOwnerName = dataReader.GetString(10);
                //project.ProjOwnerName = dataReader[10].ToString();
                project.ProjLocation = dataReader.GetString(6);
                list.Add(project);
            }
            dataReader.Close();
            command.Dispose();
            conn.Close();
            return list;
        }
        /*修改：更新刚创建的项目状态*/
        public int UpdateNewProj(long proj_id)
        {
            int state = 0;
            MySqlConnection conn = MySqlConnection1();
            string command = "UPDATE project_list SET project_state=0 WHERE project_id=" + proj_id.ToString();
            try
            {
                MySqlCommand sqlCommand = new MySqlCommand(command, conn);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                state = 1;
            }catch(Exception e)
            {
                state = 0;
                Console.WriteLine(e.ToString());
            }
            conn.Close();
            return state;
        }
        /*增加：向数据库添加新项目*/
        public int InsertNewProj(ProjectUtil projectUtil)
        {
            int state = 0;
            MySqlConnection conn = MySqlConnection1();
            string command = "INSERT INTO project_list (proj_owner_id, project_name, project_date, project_type, project_location," +
                       " video_count, team_a, team_b, proj_owner_name) VALUES ("+projectUtil.Owner_ID + ",'"  + projectUtil.ProjName + "','" + projectUtil.ProjDate + "'," + projectUtil.ProjType +
                       ",'" + projectUtil.ProjLocation + "'," + projectUtil.ProjVideoCount + ",'" + projectUtil.TeamAName + "','" + projectUtil.TeamBName+"','"+projectUtil.ProjOwnerName + "')";

            try
            {
                MySqlCommand sqlCommand = new MySqlCommand(command, conn);
                sqlCommand.ExecuteNonQuery();
                //获取刚插入数据的id
                GlobalVariables.NEW_PROJ_ID = sqlCommand.LastInsertedId;
                //当前项目id也即刚插入的项目id
                GlobalVariables.PROJECTID = (int)GlobalVariables.NEW_PROJ_ID;

                sqlCommand.Dispose();
                state = 1;
            }catch(Exception e)
            {
                state = 0;
                Console.WriteLine(e.ToString());
            }
            conn.Close();
            return state;
        }
        /*增加：向数据库添加新用户*/
        public int InsertNewUser(UserUtil user)
        {
            int state = 0;
            try
            {
                MySqlConnection conn = MySqlConnection1();
                string query = "select * from user_list where user_name='" + user.username + "'";
                MySqlCommand sqlCommand = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    state = 1;//用户已存在
                    dataReader.Close();
                }
                else
                {
                    string insert = "insert into user_list (user_name,user_password) values ('" + user.username + "','" + user.password + "')";
                    sqlCommand = new MySqlCommand(insert, conn);
                    sqlCommand.ExecuteNonQuery();
                    state = 2;//注册成功
                }
                dataReader.Close();
                sqlCommand.Dispose();
                conn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                state = 0;
            }
            return state;
        }
        /*增加：向tableName的colName列添加content*/
        public int InsertContentAccordName(string tableName, string colName, string content)
        {
            int state = 0;
            try
            {
                string insert_sql = "INSERT INTO " + tableName + " (" + colName +") values ('" + content + "')";
                MySqlConnection conn = MySqlConnection1();
                MySqlCommand sqlCommand = new MySqlCommand(insert_sql, conn);
                sqlCommand.ExecuteNonQuery();
                state = 1;
                sqlCommand.Dispose();
                conn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                state = 0;
            }
          
            return state;
        }

        /*根据项目id删除项目*/
        public bool DeleteProject(int ID)
        {
            bool state = false;
            string getpath = "SELECT project_location FROM project_list WHERE project_id=" + ID;
            string deleteproj = "DELETE FROM project_list WHERE project_id=" + ID;
            string deleteprojvideotable = "DROP TABLE IF EXISTS soccer_database." + "project_videos_" + ID.ToString();
            string deleteprojtable = "DROP TABLE IF EXISTS soccer_database." + "project_player_" + ID.ToString();
            try
            {
                MySqlConnection conn = MySqlConnection1();
                MySqlCommand getpathcommand = new MySqlCommand(getpath, conn);
                MySqlCommand deletecommand = new MySqlCommand(deleteproj, conn) ;
                MySqlCommand deletevideotable = new MySqlCommand(deleteprojvideotable, conn);
                MySqlCommand deleteprojplayertable = new MySqlCommand(deleteprojtable, conn);
                MySqlDataReader dataReader = getpathcommand.ExecuteReader();
                if (dataReader.Read())
                {
                    //根据项目路径删除文件夹内容
                    //string path = dataReader[0].ToString();
                    string path = dataReader.GetString(0);
                    DirectoryInfo dir = new DirectoryInfo(path);//获取文件夹
                    if (dir.Exists)//若文件夹非空则删除文件夹即子文件夹
                    {
                        DirectoryInfo[] children = dir.GetDirectories();
                        foreach(DirectoryInfo child in children)
                        {
                            child.Delete(true);
                        }
                        dir.Delete(true);
                    }
                }
                dataReader.Close();
                deletecommand.ExecuteNonQuery();
                deletevideotable.ExecuteNonQuery();
                deleteprojplayertable.ExecuteNonQuery();
                deletecommand.Dispose();
                deletevideotable.Dispose();
                deleteprojplayertable.Dispose();
                state = true;
                conn.Close();

            }
            catch(Exception e)
            {
                state = false;
                Console.WriteLine(e.ToString());
            }
            return state;
        }

        /*查询并创建数据表*/
        public bool CreateTable(string tableName,string search_table_sql, string create_table_sql)
        {
            bool state = false;
            //查询是否存在表格tableName
            try
            {
                MySqlConnection conn = MySqlConnection1();
                MySqlDataAdapter adapter = new MySqlDataAdapter(search_table_sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    //数据表不存在 创建数据表
                    MySqlCommand cmd = new MySqlCommand(create_table_sql, conn);
                    cmd.ExecuteNonQuery();
                }
                adapter.Dispose();
                ds.Dispose();
                conn.Close();
                state = true;
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                state = false;
            }
            return state;
        }

    }
}
