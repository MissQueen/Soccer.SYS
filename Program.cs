using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soccer.SYS.DBController;
namespace Soccer.SYS
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new ConnMySQL().MySqlConnection1();
            UserLogin login = new UserLogin();
            GlobalVariables.MAINWINDDOW = new MainWindow();
            login.ShowDialog();
            if (GlobalVariables.LOGIN_STATE == 1)
            {
                Application.Run(GlobalVariables.MAINWINDDOW);
            }
                
           
            else
                Application.Exit();
        }
    }
}
