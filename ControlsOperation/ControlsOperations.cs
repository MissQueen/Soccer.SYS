using OpenCvSharp;
using Soccer.SYS.DBController;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Soccer.SYS.ControlsOperation
{
    class ControlsOperations
    {
        /*设置列表项格式*/
        public static TableLayoutPanel GetLayoutPanel(int ColumnCount)
        {
            TableLayoutPanel tableLayout = new TableLayoutPanel();
            tableLayout.Dock = DockStyle.Top;
            tableLayout.Height = 40;
            tableLayout.ColumnCount = 6;
            for (int i = 0; i < tableLayout.ColumnCount; i++)
            {
                tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, tableLayout.Width * 0.167f));    //利用百分比计算，0.2f表示占用本行长度的20%

            }
            return tableLayout;
        }
        /*设置主窗口项目列表时label格式*/
        public static Label GetLabel()
        {
            Label label = new Label();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Fill;
            label.Font = new Font("微软雅黑", 13, FontStyle.Regular);
            label.MouseDown += Label_MouseDown;
            label.MouseEnter += Label_MouseEnter;
            label.MouseLeave += Label_MouseLeave;
            label.MouseCaptureChanged += Label_MouseCaptureChanged;//选择别的项时
            label.Click += Label_Click;
            return label;
        }

        private static void Label_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            TableLayoutPanel tableLayout = (TableLayoutPanel)lb.Parent;
            tableLayout.BackColor = Color.FromArgb(46, 45, 47);
            string[] names = tableLayout.Name.Split('_');
            GlobalVariables.PROJECTID = int.Parse(names[1]);
            GlobalVariables.PROJECTSTATE = int.Parse(names[2]);
            GlobalVariables.PROJECTNAME = names[3];
            GlobalVariables.PROJECTOWNER = names[4];
            //根据项目id查找项目路径并赋值到全局变量
            string command = "select * from project_list where project_id=" + int.Parse(names[1]);
            string path = new ConnMySQL().GetDBProjectList(command)[0].ProjLocation;
            GlobalVariables.PROJECT_PATH = path;
            Console.WriteLine("获取到的路径呢？？" + path);

            ProjectMore proj = new ProjectMore();
            proj.ShowDialog();

        }

        private static void Label_MouseCaptureChanged(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            TableLayoutPanel tableLayout = (TableLayoutPanel)lb.Parent;
            tableLayout.BackColor = Color.FromArgb(70, 70, 70);

        }

        private static void Label_MouseLeave(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            TableLayoutPanel tableLayout = (TableLayoutPanel)lb.Parent;
            tableLayout.BackColor = Color.FromArgb(70, 70, 70);
        }

        private static void Label_MouseEnter(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            TableLayoutPanel tableLayout = (TableLayoutPanel)lb.Parent;
            tableLayout.BackColor = Color.FromArgb(46, 45, 47);
        }

        private static void Label_MouseDown(object sender, MouseEventArgs e)
        {
            Label lb = (Label)sender;
            TableLayoutPanel tableLayout = (TableLayoutPanel)lb.Parent;
            tableLayout.BackColor = Color.FromArgb(46, 45, 47);
        }
        /*添加列表项内容*/
        public static void AddItemContent(ProjectUtil project_list_content, List<Label> labellist)
        {
            int k = 0;
            labellist[k++].Text = project_list_content.Id.ToString();
            labellist[k++].Text = project_list_content.ProjName.ToString();
            labellist[k++].Text = project_list_content.GetProjStateToString(project_list_content.ProjState).ToString();
            labellist[k++].Text = project_list_content.ProjDate.ToShortDateString();
            labellist[k++].Text = project_list_content.GetProjTypeToString(project_list_content.ProjType).ToString();
            labellist[k++].Text = project_list_content.ProjOwnerName;
        }
        /*获取主窗口显示内容*/
        public static void GetPanelDetails(Panel panel, int listboxindex)
        {
            List<ProjectUtil> project_list_content = new ConnMySQL().QueryAllProject(listboxindex);
            UpdatePanelContent(panel, project_list_content);
        }
        /*获取主窗口搜索结果*/
        public static void SearchPanelContent(Panel panel, string context, int menuitem)
        {
            List<ProjectUtil> project_list_content = new ConnMySQL().QueryConditionProject(context, menuitem);
            UpdatePanelContent(panel, project_list_content);
        }
        /*更新主窗口显示内容*/
        public static void UpdatePanelContent(Panel panel, List<ProjectUtil> project_list_content)
        {
            panel.Controls.Clear();//清空panel面板的内容
            List<TableLayoutPanel> project_list_table = new List<TableLayoutPanel>();
            int columncount = 6;
            for (int i = project_list_content.Count - 1; i >= 0; i--)
            {
                TableLayoutPanel tableLayout = ControlsOperations.GetLayoutPanel(columncount);//新建设置好格式的列表项
                List<Label> labellist = new List<Label>();
                for (int j = 0; j < columncount; j++)
                {
                    Label label = ControlsOperations.GetLabel();//新建设置好格式的Label
                    labellist.Add(label);
                }
                ControlsOperations.AddItemContent(project_list_content[i], labellist);
                for (int j = 0; j < columncount; j++)
                {
                    tableLayout.Controls.Add(labellist[j]);
                }
                //项目（id，完成状态，创建者名称等）信息存储到列表项Name中
                tableLayout.Name = "tableheader_" + project_list_content[i].Id.ToString() + "_" + project_list_content[i].ProjState.ToString() + "_" + project_list_content[i].ProjName + "_" + project_list_content[i].ProjOwnerName;
                panel.Controls.Add(tableLayout);
                project_list_table.Add(tableLayout);
            }
        }

        //创建项目文件夹
        public static bool CreatePorjectFile(string path)
        {
            bool state = false;
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                else
                {
                    path = path + "(1)";
                    Directory.CreateDirectory(path);
                }
                GlobalVariables.PROJECT_PATH = path;
                state = true;
            }
            catch (Exception e)
            {
                state = false;
            }

            return state;
        }

        //删除路径下的文件
        public static void DeleteFile(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
        }
        //项目路径写入项目路径下的path.txt文件
        public static void WritePath(string path)
        {
            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}
            DeleteFile("D:\\Program Files\\soccer\\path.txt");
            FileStream fileStream = new FileStream("D:\\Program Files\\soccer\\path.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fileStream);
            path = path.Replace("\\", "/");
            string project_path = GlobalVariables.PROJECT_PATH;
            project_path = project_path.Replace("\\", "/");
            sw.WriteLine(path);
            sw.WriteLine(project_path);
            sw.Close();
            fileStream.Close();
        }

        public static void WritePoints()
        {
            DeleteFile("D:\\Program Files\\soccer\\points.txt");
            FileStream fileStream = new FileStream("D:\\Program Files\\soccer\\points.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fileStream);
            sw.WriteLine(GlobalVariables.CURRENT_VIDEO);
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine(GlobalVariables.SRCPOINT[i].X + " " + GlobalVariables.SRCPOINT[i].Y);
            }
            for (int i = 0; i < 4; i++)
            {
                sw.WriteLine(GlobalVariables.DSTPOINT[i].X + " " + GlobalVariables.DSTPOINT[i].Y);
            }
            sw.Close();
            fileStream.Close();
        }

        public static void WritePaths(string path)
        {
            DeleteFile("D:\\Program Files\\soccer\\playerdata.txt");
            FileStream fileStream = new FileStream("D:\\Program Files\\soccer\\playerdata.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fileStream);
            //获得path路径下的txt
            DirectoryInfo root = new DirectoryInfo(path);
            FileInfo[] files = root.GetFiles();
            foreach (FileInfo f in root.GetFiles())
            {
                string name = f.FullName;
                if (name.Contains(".txt"))
                {
                    sw.WriteLine(name);
                }
            }
            sw.Close();
        }
    }
}
