
namespace Soccer.SYS
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.main_caption = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            this.menu_list = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.qPanel1 = new Qios.DevSuite.Components.QPanel();
            this.panel_label = new System.Windows.Forms.TableLayoutPanel();
            this.create_proj_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.search_proj_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.query_text = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.query_btn = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.title_list = new System.Windows.Forms.TableLayoutPanel();
            this.proj_date_label = new System.Windows.Forms.Label();
            this.proj_type_label = new System.Windows.Forms.Label();
            this.proj_more_label = new System.Windows.Forms.Label();
            this.proj_no_label = new System.Windows.Forms.Label();
            this.proj_name_label = new System.Windows.Forms.Label();
            this.proj_state_label = new System.Windows.Forms.Label();
            this.titile_label_panel = new System.Windows.Forms.Panel();
            this.project_list = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.main_caption)).BeginInit();
            this.qPanel1.SuspendLayout();
            this.panel_label.SuspendLayout();
            this.title_list.SuspendLayout();
            this.titile_label_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_caption
            // 
            this.main_caption.CaptionFont = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.main_caption.ColorScheme.RibbonCaptionApplicationText.SetColor("VistaBlack", System.Drawing.Color.WhiteSmoke, false);
            this.main_caption.ColorScheme.RibbonCaptionBackground2.SetColor("VistaBlack", System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))), false);
            this.main_caption.LocalFont = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.main_caption.Location = new System.Drawing.Point(0, 0);
            this.main_caption.Name = "main_caption";
            this.main_caption.Size = new System.Drawing.Size(994, 28);
            this.main_caption.TabIndex = 0;
            this.main_caption.Text = "×ãÇò·ÖÎöÏµÍ³";
            // 
            // menu_list
            // 
            this.menu_list.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.FormMain;
            this.menu_list.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlClient;
            this.menu_list.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_list.Items.AddRange(new object[] {
            "ÏîÄ¿ÁÐ±í",
            "ÎÒµÄÏîÄ¿",
            "ÒÑÍê³ÉÏîÄ¿",
            "´ý·ÖÎöÏîÄ¿",
            "ÆäËû"});
            this.menu_list.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.menu_list.Location = new System.Drawing.Point(0, 28);
            this.menu_list.Margin = new System.Windows.Forms.Padding(20);
            this.menu_list.Name = "menu_list";
            this.menu_list.OverrideFocus.Item.Content.ShortText.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu_list.Size = new System.Drawing.Size(160, 566);
            this.menu_list.StateCheckedNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu_list.StateCheckedPressed.Item.Content.ShortText.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu_list.StateCheckedTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu_list.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu_list.StateDisabled.Item.Content.ShortText.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu_list.StateNormal.Item.Content.ShortText.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu_list.StatePressed.Item.Content.ShortText.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu_list.StateTracking.Item.Content.ShortText.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu_list.TabIndex = 2;
            this.menu_list.SelectedIndexChanged += new System.EventHandler(this.menu_list_SelectedIndexChanged);
            // 
            // qPanel1
            // 
            this.qPanel1.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Metallic;
            this.qPanel1.Appearance.BorderWidth = 0;
            this.qPanel1.CausesValidation = false;
            this.qPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.Transparent, false);
            this.qPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.Color.Transparent, false);
            this.qPanel1.Controls.Add(this.panel_label);
            this.qPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.qPanel1.Location = new System.Drawing.Point(160, 28);
            this.qPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.qPanel1.Name = "qPanel1";
            this.qPanel1.Size = new System.Drawing.Size(834, 60);
            this.qPanel1.TabIndex = 9;
            // 
            // panel_label
            // 
            this.panel_label.ColumnCount = 3;
            this.panel_label.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panel_label.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.29976F));
            this.panel_label.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.70024F));
            this.panel_label.Controls.Add(this.create_proj_btn, 0, 0);
            this.panel_label.Controls.Add(this.search_proj_btn, 0, 0);
            this.panel_label.Controls.Add(this.query_text, 0, 0);
            this.panel_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_label.Location = new System.Drawing.Point(0, 0);
            this.panel_label.Name = "panel_label";
            this.panel_label.RowCount = 1;
            this.panel_label.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_label.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_label.Size = new System.Drawing.Size(834, 60);
            this.panel_label.TabIndex = 0;
            // 
            // create_proj_btn
            // 
            this.create_proj_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.create_proj_btn.Location = new System.Drawing.Point(640, 12);
            this.create_proj_btn.Margin = new System.Windows.Forms.Padding(12);
            this.create_proj_btn.Name = "create_proj_btn";
            this.create_proj_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            this.create_proj_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkRed;
            this.create_proj_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.create_proj_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.create_proj_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.create_proj_btn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.create_proj_btn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.create_proj_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.Red;
            this.create_proj_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.DarkRed;
            this.create_proj_btn.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.create_proj_btn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.create_proj_btn.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.create_proj_btn.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.create_proj_btn.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.create_proj_btn.Size = new System.Drawing.Size(182, 36);
            this.create_proj_btn.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.create_proj_btn.StateCommon.Back.Color2 = System.Drawing.Color.DarkRed;
            this.create_proj_btn.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.create_proj_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.create_proj_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.create_proj_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.create_proj_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.create_proj_btn.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.create_proj_btn.StateDisabled.Back.Color2 = System.Drawing.Color.Gray;
            this.create_proj_btn.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.create_proj_btn.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.create_proj_btn.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.create_proj_btn.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.create_proj_btn.StateNormal.Back.Color2 = System.Drawing.Color.DarkRed;
            this.create_proj_btn.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.create_proj_btn.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.create_proj_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.create_proj_btn.StatePressed.Back.Color1 = System.Drawing.Color.Red;
            this.create_proj_btn.StatePressed.Back.Color2 = System.Drawing.Color.DarkRed;
            this.create_proj_btn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.create_proj_btn.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.create_proj_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.create_proj_btn.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.create_proj_btn.StateTracking.Back.Color2 = System.Drawing.Color.DarkRed;
            this.create_proj_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.create_proj_btn.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.create_proj_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.create_proj_btn.TabIndex = 11;
            this.create_proj_btn.Values.Text = "Ìí ¼Ó Ïî Ä¿";
            this.create_proj_btn.Click += new System.EventHandler(this.create_proj_btn_Click);
            // 
            // search_proj_btn
            // 
            this.search_proj_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search_proj_btn.Location = new System.Drawing.Point(429, 12);
            this.search_proj_btn.Margin = new System.Windows.Forms.Padding(12);
            this.search_proj_btn.Name = "search_proj_btn";
            this.search_proj_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_proj_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Black;
            this.search_proj_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.search_proj_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_proj_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.search_proj_btn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.search_proj_btn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.search_proj_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_proj_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Black;
            this.search_proj_btn.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.search_proj_btn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_proj_btn.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.search_proj_btn.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.search_proj_btn.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.search_proj_btn.Size = new System.Drawing.Size(187, 36);
            this.search_proj_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_proj_btn.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.search_proj_btn.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.search_proj_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_proj_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.search_proj_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.search_proj_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.search_proj_btn.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.search_proj_btn.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_proj_btn.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_proj_btn.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_proj_btn.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.search_proj_btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_proj_btn.StateNormal.Back.Color2 = System.Drawing.Color.Black;
            this.search_proj_btn.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.search_proj_btn.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_proj_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.search_proj_btn.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.search_proj_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_proj_btn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_proj_btn.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.search_proj_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.search_proj_btn.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.search_proj_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_proj_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search_proj_btn.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.search_proj_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.search_proj_btn.TabIndex = 10;
            this.search_proj_btn.Values.Text = "ËÑ Ë÷ Ïî Ä¿";
            this.search_proj_btn.Click += new System.EventHandler(this.search_proj_btn_Click);
            // 
            // query_text
            // 
            this.query_text.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.query_btn});
            this.query_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.query_text.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon;
            this.query_text.Location = new System.Drawing.Point(12, 16);
            this.query_text.Margin = new System.Windows.Forms.Padding(12, 16, 12, 14);
            this.query_text.Name = "query_text";
            this.query_text.Size = new System.Drawing.Size(393, 28);
            this.query_text.StateActive.Content.Color1 = System.Drawing.Color.Gray;
            this.query_text.StateActive.Content.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query_text.StateActive.Content.Padding = new System.Windows.Forms.Padding(12, 2, 2, 2);
            this.query_text.StateCommon.Content.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query_text.StateCommon.Content.Padding = new System.Windows.Forms.Padding(2);
            this.query_text.StateDisabled.Content.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query_text.StateDisabled.Content.Padding = new System.Windows.Forms.Padding(2);
            this.query_text.StateNormal.Content.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.query_text.StateNormal.Content.Padding = new System.Windows.Forms.Padding(2);
            this.query_text.TabIndex = 9;
            this.query_text.Text = "ÇëÊäÈëÏîÄ¿Ãû³Æ»ò´´½¨Õß";
            this.query_text.Enter += new System.EventHandler(this.query_text_Enter);
            this.query_text.Leave += new System.EventHandler(this.query_text_Leave);
            // 
            // query_btn
            // 
            this.query_btn.Image = ((System.Drawing.Image)(resources.GetObject("query_btn.Image")));
            this.query_btn.UniqueName = "6DFED7A303C94FC75380EB1F5C6CAF3E";
            this.query_btn.Click += new System.EventHandler(this.query_btn_Click);
            // 
            // title_list
            // 
            this.title_list.ColumnCount = 6;
            this.title_list.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.title_list.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.title_list.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.title_list.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.title_list.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.title_list.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.title_list.Controls.Add(this.proj_date_label, 0, 0);
            this.title_list.Controls.Add(this.proj_type_label, 0, 0);
            this.title_list.Controls.Add(this.proj_more_label, 0, 0);
            this.title_list.Controls.Add(this.proj_no_label, 0, 0);
            this.title_list.Controls.Add(this.proj_name_label, 0, 0);
            this.title_list.Controls.Add(this.proj_state_label, 0, 0);
            this.title_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_list.Location = new System.Drawing.Point(0, 0);
            this.title_list.Margin = new System.Windows.Forms.Padding(0);
            this.title_list.Name = "title_list";
            this.title_list.RowCount = 1;
            this.title_list.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.title_list.Size = new System.Drawing.Size(834, 40);
            this.title_list.TabIndex = 0;
            // 
            // proj_date_label
            // 
            this.proj_date_label.AutoSize = true;
            this.proj_date_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proj_date_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proj_date_label.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.proj_date_label.Location = new System.Drawing.Point(414, 0);
            this.proj_date_label.Margin = new System.Windows.Forms.Padding(0);
            this.proj_date_label.Name = "proj_date_label";
            this.proj_date_label.Size = new System.Drawing.Size(138, 40);
            this.proj_date_label.TabIndex = 16;
            this.proj_date_label.Text = "´´½¨Ê±¼ä";
            this.proj_date_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proj_type_label
            // 
            this.proj_type_label.AutoSize = true;
            this.proj_type_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proj_type_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proj_type_label.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.proj_type_label.Location = new System.Drawing.Point(552, 0);
            this.proj_type_label.Margin = new System.Windows.Forms.Padding(0);
            this.proj_type_label.Name = "proj_type_label";
            this.proj_type_label.Size = new System.Drawing.Size(138, 40);
            this.proj_type_label.TabIndex = 15;
            this.proj_type_label.Text = "±ÈÈüÀàÐÍ";
            this.proj_type_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proj_more_label
            // 
            this.proj_more_label.AutoSize = true;
            this.proj_more_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proj_more_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proj_more_label.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.proj_more_label.Location = new System.Drawing.Point(690, 0);
            this.proj_more_label.Margin = new System.Windows.Forms.Padding(0);
            this.proj_more_label.Name = "proj_more_label";
            this.proj_more_label.Size = new System.Drawing.Size(144, 40);
            this.proj_more_label.TabIndex = 14;
            this.proj_more_label.Text = "´´½¨Õß";
            this.proj_more_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proj_no_label
            // 
            this.proj_no_label.AutoSize = true;
            this.proj_no_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proj_no_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proj_no_label.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.proj_no_label.Location = new System.Drawing.Point(0, 0);
            this.proj_no_label.Margin = new System.Windows.Forms.Padding(0);
            this.proj_no_label.Name = "proj_no_label";
            this.proj_no_label.Size = new System.Drawing.Size(138, 40);
            this.proj_no_label.TabIndex = 12;
            this.proj_no_label.Text = "ÏîÄ¿±àºÅ";
            this.proj_no_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proj_name_label
            // 
            this.proj_name_label.AutoSize = true;
            this.proj_name_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proj_name_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proj_name_label.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.proj_name_label.Location = new System.Drawing.Point(138, 0);
            this.proj_name_label.Margin = new System.Windows.Forms.Padding(0);
            this.proj_name_label.Name = "proj_name_label";
            this.proj_name_label.Size = new System.Drawing.Size(138, 40);
            this.proj_name_label.TabIndex = 7;
            this.proj_name_label.Text = "ÏîÄ¿Ãû³Æ";
            this.proj_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // proj_state_label
            // 
            this.proj_state_label.AutoSize = true;
            this.proj_state_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proj_state_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proj_state_label.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.proj_state_label.Location = new System.Drawing.Point(276, 0);
            this.proj_state_label.Margin = new System.Windows.Forms.Padding(0);
            this.proj_state_label.Name = "proj_state_label";
            this.proj_state_label.Size = new System.Drawing.Size(138, 40);
            this.proj_state_label.TabIndex = 0;
            this.proj_state_label.Text = "Íê³É×´Ì¬";
            this.proj_state_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titile_label_panel
            // 
            this.titile_label_panel.AutoScroll = true;
            this.titile_label_panel.Controls.Add(this.project_list);
            this.titile_label_panel.Controls.Add(this.title_list);
            this.titile_label_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titile_label_panel.Location = new System.Drawing.Point(160, 88);
            this.titile_label_panel.Name = "titile_label_panel";
            this.titile_label_panel.Size = new System.Drawing.Size(834, 506);
            this.titile_label_panel.TabIndex = 10;
            // 
            // project_list
            // 
            this.project_list.AutoScroll = true;
            this.project_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.project_list.Location = new System.Drawing.Point(0, 40);
            this.project_list.Name = "project_list";
            this.project_list.Size = new System.Drawing.Size(834, 466);
            this.project_list.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(994, 594);
            this.Controls.Add(this.titile_label_panel);
            this.Controls.Add(this.qPanel1);
            this.Controls.Add(this.menu_list);
            this.Controls.Add(this.main_caption);
            this.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "×ãÇò·ÖÎöÏµÍ³";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main_caption)).EndInit();
            this.qPanel1.ResumeLayout(false);
            this.panel_label.ResumeLayout(false);
            this.panel_label.PerformLayout();
            this.title_list.ResumeLayout(false);
            this.title_list.PerformLayout();
            this.titile_label_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Qios.DevSuite.Components.Ribbon.QRibbonCaption main_caption;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox menu_list;
        private Qios.DevSuite.Components.QPanel qPanel1;
        private System.Windows.Forms.TableLayoutPanel panel_label;
        private ComponentFactory.Krypton.Toolkit.KryptonButton create_proj_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton search_proj_btn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox query_text;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny query_btn;
        private System.Windows.Forms.TableLayoutPanel title_list;
        private System.Windows.Forms.Label proj_date_label;
        private System.Windows.Forms.Label proj_type_label;
        private System.Windows.Forms.Label proj_more_label;
        private System.Windows.Forms.Label proj_no_label;
        private System.Windows.Forms.Label proj_name_label;
        private System.Windows.Forms.Label proj_state_label;
        private System.Windows.Forms.Panel titile_label_panel;
        private System.Windows.Forms.Panel project_list;
    }
}