
namespace Soccer.SYS
{
    partial class ObjectTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectTracking));
            this.video_choose = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            this.panel1 = new System.Windows.Forms.Panel();
            this.start_tracking_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tracker_method = new System.Windows.Forms.ComboBox();
            this.track_method_label = new System.Windows.Forms.Label();
            this.player_no = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.del_player_no = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.video_count_label = new System.Windows.Forms.Label();
            this.video_nums = new System.Windows.Forms.NumericUpDown();
            this.single_obj_check = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.video_choose)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video_nums)).BeginInit();
            this.SuspendLayout();
            // 
            // video_choose
            // 
            this.video_choose.CaptionFont = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.video_choose.ColorScheme.RibbonCaptionApplicationText.SetColor("VistaBlack", System.Drawing.Color.WhiteSmoke, false);
            this.video_choose.LocalFont = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.video_choose.Location = new System.Drawing.Point(0, 0);
            this.video_choose.Name = "video_choose";
            this.video_choose.Size = new System.Drawing.Size(401, 28);
            this.video_choose.TabIndex = 2;
            this.video_choose.Text = "¸ú×ÙÉèÖÃ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.start_tracking_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 39);
            this.panel1.TabIndex = 4;
            // 
            // start_tracking_btn
            // 
            this.start_tracking_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start_tracking_btn.Location = new System.Drawing.Point(0, 0);
            this.start_tracking_btn.Margin = new System.Windows.Forms.Padding(20);
            this.start_tracking_btn.Name = "start_tracking_btn";
            this.start_tracking_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_tracking_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Black;
            this.start_tracking_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.start_tracking_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_tracking_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.start_tracking_btn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.start_tracking_btn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.start_tracking_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_tracking_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Black;
            this.start_tracking_btn.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.start_tracking_btn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_tracking_btn.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.start_tracking_btn.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.start_tracking_btn.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.start_tracking_btn.Size = new System.Drawing.Size(401, 39);
            this.start_tracking_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_tracking_btn.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.start_tracking_btn.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.start_tracking_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_tracking_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.start_tracking_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.start_tracking_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.start_tracking_btn.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.start_tracking_btn.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_tracking_btn.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_tracking_btn.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_tracking_btn.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.start_tracking_btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_tracking_btn.StateNormal.Back.Color2 = System.Drawing.Color.Black;
            this.start_tracking_btn.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.start_tracking_btn.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_tracking_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.start_tracking_btn.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.start_tracking_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_tracking_btn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_tracking_btn.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.start_tracking_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.start_tracking_btn.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.start_tracking_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_tracking_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.start_tracking_btn.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.start_tracking_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.start_tracking_btn.TabIndex = 12;
            this.start_tracking_btn.Values.Text = "¿ª Ê¼ ¸ú ×Ù";
            this.start_tracking_btn.Click += new System.EventHandler(this.start_tracking_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.8995F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.1005F));
            this.tableLayoutPanel1.Controls.Add(this.tracker_method, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.track_method_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.player_no, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.video_count_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.video_nums, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.single_obj_check, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(401, 157);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tracker_method
            // 
            this.tracker_method.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tracker_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tracker_method.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tracker_method.FormattingEnabled = true;
            this.tracker_method.Items.AddRange(new object[] {
            "ÇëÑ¡Ôñ¸ú×Ù·½Ê½",
            "CSRT",
            "KCF"});
            this.tracker_method.Location = new System.Drawing.Point(122, 116);
            this.tracker_method.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.tracker_method.Name = "tracker_method";
            this.tracker_method.Size = new System.Drawing.Size(276, 28);
            this.tracker_method.TabIndex = 23;
            // 
            // track_method_label
            // 
            this.track_method_label.AutoSize = true;
            this.track_method_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.track_method_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.track_method_label.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.track_method_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.track_method_label.Location = new System.Drawing.Point(3, 107);
            this.track_method_label.Margin = new System.Windows.Forms.Padding(3);
            this.track_method_label.Name = "track_method_label";
            this.track_method_label.Size = new System.Drawing.Size(113, 47);
            this.track_method_label.TabIndex = 18;
            this.track_method_label.Text = "¸ú×Ù·½Ê½";
            this.track_method_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player_no
            // 
            this.player_no.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.del_player_no});
            this.player_no.Dock = System.Windows.Forms.DockStyle.Fill;
            this.player_no.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.player_no.Location = new System.Drawing.Point(122, 64);
            this.player_no.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.player_no.Name = "player_no";
            this.player_no.Size = new System.Drawing.Size(276, 28);
            this.player_no.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.player_no.StateActive.Content.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player_no.StateActive.Content.Padding = new System.Windows.Forms.Padding(12, 2, 2, 2);
            this.player_no.StateCommon.Content.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player_no.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.player_no.StateDisabled.Content.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player_no.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(2);
            this.player_no.StateNormal.Content.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.player_no.StateNormal.Content.Padding = new System.Windows.Forms.Padding(2);
            this.player_no.TabIndex = 17;
            this.player_no.Text = "ÇëÊäÈëÇòÔ±±àºÅ";
            // 
            // del_player_no
            // 
            this.del_player_no.Image = ((System.Drawing.Image)(resources.GetObject("del_player_no.Image")));
            this.del_player_no.UniqueName = "6DFED7A303C94FC75380EB1F5C6CAF3E";
            this.del_player_no.Click += new System.EventHandler(this.del_player_no_Click);
            // 
            // video_count_label
            // 
            this.video_count_label.AutoSize = true;
            this.video_count_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.video_count_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.video_count_label.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.video_count_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.video_count_label.Location = new System.Drawing.Point(3, 3);
            this.video_count_label.Margin = new System.Windows.Forms.Padding(3);
            this.video_count_label.Name = "video_count_label";
            this.video_count_label.Size = new System.Drawing.Size(113, 46);
            this.video_count_label.TabIndex = 14;
            this.video_count_label.Text = "ÊÓÆµÊýÁ¿";
            this.video_count_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // video_nums
            // 
            this.video_nums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.video_nums.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.video_nums.Location = new System.Drawing.Point(122, 12);
            this.video_nums.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.video_nums.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.video_nums.Name = "video_nums";
            this.video_nums.Size = new System.Drawing.Size(276, 29);
            this.video_nums.TabIndex = 15;
            this.video_nums.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.video_nums.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // single_obj_check
            // 
            this.single_obj_check.AutoSize = true;
            this.single_obj_check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.single_obj_check.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.single_obj_check.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.single_obj_check.Location = new System.Drawing.Point(15, 55);
            this.single_obj_check.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.single_obj_check.Name = "single_obj_check";
            this.single_obj_check.Size = new System.Drawing.Size(101, 46);
            this.single_obj_check.TabIndex = 16;
            this.single_obj_check.Text = "µ¥Ä¿±ê¸ú×Ù";
            this.single_obj_check.UseVisualStyleBackColor = true;
            this.single_obj_check.CheckedChanged += new System.EventHandler(this.single_obj_check_CheckedChanged);
            // 
            // ObjectTracking
            // 
            this.ClientSize = new System.Drawing.Size(401, 224);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.video_choose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ObjectTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¸ú×ÙÉèÖÃ";
            this.Load += new System.EventHandler(this.ObjectTracking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.video_choose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video_nums)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Qios.DevSuite.Components.Ribbon.QRibbonCaption video_choose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton start_tracking_btn;
        private System.Windows.Forms.Label video_count_label;
        private System.Windows.Forms.NumericUpDown video_nums;
        private System.Windows.Forms.CheckBox single_obj_check;
        private System.Windows.Forms.Label track_method_label;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox player_no;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny del_player_no;
        private System.Windows.Forms.ComboBox tracker_method;
    }
}