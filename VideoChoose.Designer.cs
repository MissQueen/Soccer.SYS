
namespace Soccer.SYS
{
    partial class VideoChoose
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoChoose));
            this.video_choose = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            this.add_video_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.video_choose)).BeginInit();
            this.SuspendLayout();
            // 
            // video_choose
            // 
            this.video_choose.CaptionFont = new System.Drawing.Font("Œ¢»Ì—≈∫⁄", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.video_choose.ColorScheme.RibbonCaptionApplicationText.SetColor("VistaBlack", System.Drawing.Color.WhiteSmoke, false);
            this.video_choose.LocalFont = new System.Drawing.Font("Œ¢»Ì—≈∫⁄", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.video_choose.Location = new System.Drawing.Point(0, 0);
            this.video_choose.Name = "video_choose";
            this.video_choose.Size = new System.Drawing.Size(294, 28);
            this.video_choose.TabIndex = 0;
            this.video_choose.Text = " ”∆µ—°‘Ò";
            // 
            // add_video_btn
            // 
            this.add_video_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add_video_btn.BackgroundImage")));
            this.add_video_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_video_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_video_btn.Location = new System.Drawing.Point(0, 28);
            this.add_video_btn.Margin = new System.Windows.Forms.Padding(0);
            this.add_video_btn.Name = "add_video_btn";
            this.add_video_btn.Size = new System.Drawing.Size(294, 206);
            this.add_video_btn.TabIndex = 1;
            this.add_video_btn.UseVisualStyleBackColor = true;
            this.add_video_btn.Click += new System.EventHandler(this.add_video_btn_Click);
            // 
            // VideoChoose
            // 
            this.ClientSize = new System.Drawing.Size(294, 234);
            this.Controls.Add(this.add_video_btn);
            this.Controls.Add(this.video_choose);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 240);
            this.Name = "VideoChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ”∆µ—°‘Ò";
            this.Load += new System.EventHandler(this.VideoChoose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.video_choose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Qios.DevSuite.Components.Ribbon.QRibbonCaption video_choose;
        private System.Windows.Forms.Button add_video_btn;
    }
}