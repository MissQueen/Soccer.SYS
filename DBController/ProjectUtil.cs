using System;

namespace Soccer.SYS.DBController
{
    class ProjectUtil
    {
        /*项目id*/
        public int Id { set; get; }
        /*当前登录用户的id*/
        public int Owner_ID { set; get; }
        /*项目名称*/
        public string ProjName { set; get; }
        /*项目状态： 完成与否*/
        public int ProjState { set; get; }
        /*项目创建日期*/
        public DateTime ProjDate { set; get; }
        /*项目类型： 11vs11 or 5vs5*/
        public int ProjType { set; get; }
        /*项目位置*/
        public string ProjLocation { set; get; }
        /*视频数量*/
        public int ProjVideoCount { set; get; }
        /*主队名称*/
        public string TeamAName { set; get; }
        /*客队名称*/
        public string TeamBName { set; get; }
        /*项目创建者名称*/
        public string ProjOwnerName { set; get; }

        public ProjectUtil()
        {

        }
        public ProjectUtil(string projName)
        {
            this.ProjName = ProjName;
        }
        public ProjectUtil(string projName, int projState, DateTime projTime, int projType)
        {
            this.ProjName = projName;
            this.ProjState = projState;
            this.ProjDate = projTime;
            this.ProjType = projType;
        }
        public ProjectUtil(int id,  string projName, int projState, DateTime projTime, int projType)
        {
            this.Id = id;
            this.ProjName = projName;
            this.ProjState = projState;
            this.ProjDate = projTime;
            this.ProjType = projType;
        }

        public ProjectUtil(int ownerID, string projName, DateTime projTime, int projType, string projLoc, int videoCount, string teamaName, string teambName, string projOwnerName)
        {
            this.Owner_ID = ownerID;
            this.ProjName = projName;
            this.ProjDate = projTime;
            this.ProjType = projType;
            this.ProjLocation = projLoc;
            this.ProjVideoCount = videoCount;
            this.TeamAName = teamaName;
            this.TeamBName = teambName;
            this.ProjOwnerName = projOwnerName;
        }
        /*项目完成状态转string*/
        public string GetProjStateToString(int projState)
        {
            if (projState==0)
            {
                return "待分析";
            }else if (projState == 1)
            {
                return "已完成";
            }
            else
            {
                return "其他";
            }
        }
        /*比赛类型转string*/
        public string GetProjTypeToString(int projType)
        {
            if (projType == 1)
            {
                return "5 vs 5";
            }else if(projType == 2)
            {
                return "11 vs 11";
            }
            else{
                return "其他";
            }
        }
    }
}
