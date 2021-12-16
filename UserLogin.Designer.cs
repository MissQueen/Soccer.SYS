
namespace Soccer.SYS
{
    partial class UserLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.kryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.user_label = new System.Windows.Forms.Label();
            this.username_text = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.clear_username = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.psw_text = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.clear_psw = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.psw_label = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Label();
            this.forgotten_psw = new System.Windows.Forms.Label();
            this.login_btn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // kryptonManager
            // 
            this.kryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Black;
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.BackColor = System.Drawing.Color.Transparent;
            this.user_label.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.user_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user_label.Location = new System.Drawing.Point(326, 54);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(58, 21);
            this.user_label.TabIndex = 0;
            this.user_label.Text = "ÓÃ»§Ãû";
            // 
            // username_text
            // 
            this.username_text.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.clear_username});
            this.username_text.Location = new System.Drawing.Point(330, 91);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(178, 28);
            this.username_text.StateActive.Content.Padding = new System.Windows.Forms.Padding(4);
            this.username_text.TabIndex = 0;
            this.username_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_text_KeyDown);
            // 
            // clear_username
            // 
            this.clear_username.AllowInheritExtraText = false;
            this.clear_username.AllowInheritImage = false;
            this.clear_username.AllowInheritText = false;
            this.clear_username.AllowInheritToolTipTitle = false;
            this.clear_username.ColorMap = System.Drawing.Color.Transparent;
            this.clear_username.Edge = ComponentFactory.Krypton.Toolkit.PaletteRelativeEdgeAlign.Far;
            this.clear_username.Image = ((System.Drawing.Image)(resources.GetObject("clear_username.Image")));
            this.clear_username.ImageStates.ImageCheckedNormal = ((System.Drawing.Image)(resources.GetObject("clear_username.ImageStates.ImageCheckedNormal")));
            this.clear_username.ImageStates.ImageCheckedPressed = ((System.Drawing.Image)(resources.GetObject("clear_username.ImageStates.ImageCheckedPressed")));
            this.clear_username.ImageStates.ImageCheckedTracking = ((System.Drawing.Image)(resources.GetObject("clear_username.ImageStates.ImageCheckedTracking")));
            this.clear_username.ImageStates.ImageDisabled = ((System.Drawing.Image)(resources.GetObject("clear_username.ImageStates.ImageDisabled")));
            this.clear_username.ImageStates.ImageNormal = ((System.Drawing.Image)(resources.GetObject("clear_username.ImageStates.ImageNormal")));
            this.clear_username.ImageStates.ImagePressed = ((System.Drawing.Image)(resources.GetObject("clear_username.ImageStates.ImagePressed")));
            this.clear_username.ImageStates.ImageTracking = ((System.Drawing.Image)(resources.GetObject("clear_username.ImageStates.ImageTracking")));
            this.clear_username.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.clear_username.Orientation = ComponentFactory.Krypton.Toolkit.PaletteButtonOrientation.FixedRight;
            this.clear_username.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.clear_username.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.clear_username.UniqueName = "BAFC8315CDAF4884EF87BBF729062257";
            this.clear_username.Click += new System.EventHandler(this.clear_username_Click);
            // 
            // psw_text
            // 
            this.psw_text.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.clear_psw});
            this.psw_text.Location = new System.Drawing.Point(330, 168);
            this.psw_text.Name = "psw_text";
            this.psw_text.PasswordChar = '*';
            this.psw_text.Size = new System.Drawing.Size(178, 26);
            this.psw_text.StateActive.Content.Padding = new System.Windows.Forms.Padding(4);
            this.psw_text.TabIndex = 3;
            this.psw_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.psw_text_KeyDown);
            // 
            // clear_psw
            // 
            this.clear_psw.Image = ((System.Drawing.Image)(resources.GetObject("clear_psw.Image")));
            this.clear_psw.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.ListItem;
            this.clear_psw.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.clear_psw.UniqueName = "8796CC878EE143503197E914AA8EAE6E";
            this.clear_psw.Click += new System.EventHandler(this.clear_psw_Click);
            // 
            // psw_label
            // 
            this.psw_label.AutoSize = true;
            this.psw_label.BackColor = System.Drawing.Color.Transparent;
            this.psw_label.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.psw_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.psw_label.Location = new System.Drawing.Point(326, 131);
            this.psw_label.Name = "psw_label";
            this.psw_label.Size = new System.Drawing.Size(42, 21);
            this.psw_label.TabIndex = 2;
            this.psw_label.Text = "ÃÜÂë";
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.BackColor = System.Drawing.Color.Transparent;
            this.register.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.register.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.register.Location = new System.Drawing.Point(330, 198);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(32, 17);
            this.register.TabIndex = 4;
            this.register.Text = "×¢²á";
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // forgotten_psw
            // 
            this.forgotten_psw.AutoSize = true;
            this.forgotten_psw.BackColor = System.Drawing.Color.Transparent;
            this.forgotten_psw.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.forgotten_psw.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.forgotten_psw.Location = new System.Drawing.Point(452, 198);
            this.forgotten_psw.Name = "forgotten_psw";
            this.forgotten_psw.Size = new System.Drawing.Size(56, 17);
            this.forgotten_psw.TabIndex = 5;
            this.forgotten_psw.Text = "Íü¼ÇÃÜÂë";
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(333, 239);
            this.login_btn.Name = "login_btn";
            this.login_btn.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.OverrideDefault.Back.Color2 = System.Drawing.Color.Black;
            this.login_btn.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.login_btn.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.login_btn.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.login_btn.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.login_btn.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.OverrideFocus.Back.Color2 = System.Drawing.Color.Black;
            this.login_btn.OverrideFocus.Border.Color1 = System.Drawing.Color.Black;
            this.login_btn.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.login_btn.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.login_btn.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.login_btn.Size = new System.Drawing.Size(175, 30);
            this.login_btn.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.login_btn.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.login_btn.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.login_btn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.login_btn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.login_btn.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.login_btn.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.login_btn.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.StateNormal.Back.Color2 = System.Drawing.Color.Black;
            this.login_btn.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.login_btn.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.login_btn.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.login_btn.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.login_btn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.login_btn.StateTracking.Back.Color1 = System.Drawing.Color.Black;
            this.login_btn.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.login_btn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.login_btn.TabIndex = 6;
            this.login_btn.Values.Text = "µÇ Â¼";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.forgotten_psw);
            this.Controls.Add(this.register);
            this.Controls.Add(this.psw_text);
            this.Controls.Add(this.psw_label);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.user_label);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 360);
            this.MinimumSize = new System.Drawing.Size(600, 360);
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateActive.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateActive.Header.Content.ShortText.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Text = "UserLogin";
            this.Activated += new System.EventHandler(this.UserLogin_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserLogin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager;
        private System.Windows.Forms.Label user_label;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox username_text;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox psw_text;
        private System.Windows.Forms.Label psw_label;
        private System.Windows.Forms.Label register;
        private System.Windows.Forms.Label forgotten_psw;
        private ComponentFactory.Krypton.Toolkit.KryptonButton login_btn;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny clear_username;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny clear_psw;
    }
}

