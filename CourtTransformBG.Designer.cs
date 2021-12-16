
namespace Soccer.SYS
{
    partial class CourtTransformBG
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
            this.court_transform = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            this.court_picbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.court_transform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.court_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // court_transform
            // 
            this.court_transform.CaptionFont = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.court_transform.ColorScheme.RibbonCaptionApplicationText.SetColor("VistaBlack", System.Drawing.Color.WhiteSmoke, false);
            this.court_transform.LocalFont = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.court_transform.Location = new System.Drawing.Point(0, 0);
            this.court_transform.Margin = new System.Windows.Forms.Padding(0);
            this.court_transform.Name = "court_transform";
            this.court_transform.Size = new System.Drawing.Size(296, 28);
            this.court_transform.TabIndex = 1;
            this.court_transform.Text = "Çò³¡×ª»»";
            // 
            // court_picbox
            // 
            this.court_picbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.court_picbox.Location = new System.Drawing.Point(0, 28);
            this.court_picbox.Margin = new System.Windows.Forms.Padding(0);
            this.court_picbox.Name = "court_picbox";
            this.court_picbox.Size = new System.Drawing.Size(296, 268);
            this.court_picbox.TabIndex = 2;
            this.court_picbox.TabStop = false;
            this.court_picbox.Click += new System.EventHandler(this.court_picbox_Click);
            // 
            // CourtTransformBG
            // 
            this.Appearance.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.RectangleShapedWindow);
            this.ClientSize = new System.Drawing.Size(296, 296);
            this.Controls.Add(this.court_picbox);
            this.Controls.Add(this.court_transform);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourtTransformBG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Çò³¡×ª»»";
            this.Load += new System.EventHandler(this.CourtTransformBG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.court_transform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.court_picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Qios.DevSuite.Components.Ribbon.QRibbonCaption court_transform;
        private System.Windows.Forms.PictureBox court_picbox;
    }
}