using Qios.DevSuite.Components;
using Soccer.SYS.DBController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Soccer.SYS
{
    public partial class TrackOrAnalysis : Qios.DevSuite.Components.Ribbon.QRibbonForm
    {
        public TrackOrAnalysis()
        {
            InitializeComponent();
        }

        private void TrackOrAnalysis_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.PROJECTSTATE == 2) analysis_btn.Enabled = false;//��Ŀδ�����Ƶ����ǰ���������ֹ��ܲ�����

        }

        private void track_btn_Click(object sender, EventArgs e)
        {
            ObjectTracking objectTracking = new ObjectTracking();
            objectTracking.Show();
            this.Close();
        }

        private void analysis_btn_Click(object sender, EventArgs e)
        {
            ProjAnalysisMySQL.GetVideoPaths(GlobalVariables.PROJECTID);
            VideoAnalysis videoAnalysis = new VideoAnalysis();
            videoAnalysis.videoPath = GlobalVariables.ALL_VIDEO_PATH[0];
            this.Close();
            videoAnalysis.Show();
        }
    }
}