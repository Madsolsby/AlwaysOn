namespace AlwaysOn
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pTop = new Bunifu.UI.WinForms.BunifuPanel();
            this.toggle = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            this.btnMin = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lTitle = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.lFrequency = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.lStartWithWindows = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsEnableOrDisable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lLastRun = new System.Windows.Forms.Label();
            this.lLastRunTitle = new System.Windows.Forms.Label();
            this.timerTextChanged = new System.Windows.Forms.Timer(this.components);
            this.toggleStartup = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            this.linfo1 = new System.Windows.Forms.Label();
            this.bLoader = new Bunifu.UI.WinForms.BunifuLoader();
            this.tbInterval = new Bunifu.UI.WinForms.BunifuTextBox();
            this.timerInfo = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pTop.SuspendLayout();
            this.cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // drag
            // 
            this.drag.Fixed = true;
            this.drag.Horizontal = true;
            this.drag.TargetControl = this.pTop;
            this.drag.Vertical = true;
            // 
            // pTop
            // 
            this.pTop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pTop.BackgroundImage")));
            this.pTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pTop.BorderColor = System.Drawing.Color.Transparent;
            this.pTop.BorderRadius = 3;
            this.pTop.BorderThickness = 1;
            this.pTop.Controls.Add(this.pictureBox1);
            this.pTop.Controls.Add(this.toggle);
            this.pTop.Controls.Add(this.btnMin);
            this.pTop.Controls.Add(this.lTitle);
            this.pTop.Controls.Add(this.linfo1);
            this.pTop.Controls.Add(this.btnClose);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Margin = new System.Windows.Forms.Padding(0);
            this.pTop.Name = "pTop";
            this.pTop.ShowBorders = true;
            this.pTop.Size = new System.Drawing.Size(484, 58);
            this.pTop.TabIndex = 0;
            // 
            // toggle
            // 
            this.toggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.toggle.Checked = false;
            this.toggle.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.toggle.CheckedSwitchColor = System.Drawing.Color.White;
            this.toggle.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.toggle.Location = new System.Drawing.Point(149, 19);
            this.toggle.Name = "toggle";
            this.toggle.OutlineThickness = 2;
            this.toggle.Size = new System.Drawing.Size(53, 27);
            this.toggle.TabIndex = 3;
            this.toggle.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.toggle.UncheckedSwitchColor = System.Drawing.Color.White;
            this.toggle.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.toggle.CheckedChanged += new System.EventHandler(this.toggle_CheckedChanged);
            this.toggle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toggle_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.ActiveImage = null;
            this.btnMin.AllowAnimations = true;
            this.btnMin.AllowBuffering = false;
            this.btnMin.AllowToggling = false;
            this.btnMin.AllowZooming = false;
            this.btnMin.AllowZoomingOnFocus = false;
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnMin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMin.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMin.ErrorImage")));
            this.btnMin.FadeWhenInactive = true;
            this.btnMin.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnMin.Image = global::AlwaysOn.Properties.Resources.minimize;
            this.btnMin.ImageActive = null;
            this.btnMin.ImageLocation = null;
            this.btnMin.ImageMargin = 20;
            this.btnMin.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMin.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnMin.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnMin.InitialImage")));
            this.btnMin.Location = new System.Drawing.Point(385, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Rotation = 0;
            this.btnMin.ShowActiveImage = true;
            this.btnMin.ShowCursorChanges = true;
            this.btnMin.ShowImageBorders = true;
            this.btnMin.ShowSizeMarkers = false;
            this.btnMin.Size = new System.Drawing.Size(50, 50);
            this.btnMin.TabIndex = 2;
            this.btnMin.ToolTipText = "";
            this.btnMin.WaitOnLoad = false;
            this.btnMin.Zoom = 20;
            this.btnMin.ZoomSpeed = 10;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lTitle.Font = new System.Drawing.Font("Brandon Grotesque Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(50, 16);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(95, 27);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "AlwaysOn";
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = false;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = true;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = global::AlwaysOn.Properties.Resources.close;
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 20;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(427, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 20;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lFrequency
            // 
            this.lFrequency.AutoSize = true;
            this.lFrequency.Font = new System.Drawing.Font("Brandon Grotesque Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFrequency.Location = new System.Drawing.Point(12, 67);
            this.lFrequency.Name = "lFrequency";
            this.lFrequency.Size = new System.Drawing.Size(170, 27);
            this.lFrequency.TabIndex = 2;
            this.lFrequency.Text = "Frequency in seconds";
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // lStartWithWindows
            // 
            this.lStartWithWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lStartWithWindows.AutoSize = true;
            this.lStartWithWindows.Font = new System.Drawing.Font("Brandon Grotesque Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStartWithWindows.Location = new System.Drawing.Point(291, 140);
            this.lStartWithWindows.Name = "lStartWithWindows";
            this.lStartWithWindows.Size = new System.Drawing.Size(149, 27);
            this.lStartWithWindows.TabIndex = 4;
            this.lStartWithWindows.Text = "Start with windows";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.cms;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Always On";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEnableOrDisable,
            this.tsExit});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(110, 48);
            // 
            // tsEnableOrDisable
            // 
            this.tsEnableOrDisable.Name = "tsEnableOrDisable";
            this.tsEnableOrDisable.Size = new System.Drawing.Size(109, 22);
            this.tsEnableOrDisable.Text = "Enable";
            this.tsEnableOrDisable.Click += new System.EventHandler(this.tsEnableOrDisable_Click);
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(109, 22);
            this.tsExit.Text = "Exit";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // lLastRun
            // 
            this.lLastRun.AutoSize = true;
            this.lLastRun.Font = new System.Drawing.Font("Brandon Grotesque Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLastRun.ForeColor = System.Drawing.Color.DarkGray;
            this.lLastRun.Location = new System.Drawing.Point(77, 148);
            this.lLastRun.Name = "lLastRun";
            this.lLastRun.Size = new System.Drawing.Size(18, 23);
            this.lLastRun.TabIndex = 6;
            this.lLastRun.Text = "-";
            // 
            // lLastRunTitle
            // 
            this.lLastRunTitle.AutoSize = true;
            this.lLastRunTitle.Font = new System.Drawing.Font("Brandon Grotesque Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLastRunTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lLastRunTitle.Location = new System.Drawing.Point(13, 147);
            this.lLastRunTitle.Name = "lLastRunTitle";
            this.lLastRunTitle.Size = new System.Drawing.Size(64, 23);
            this.lLastRunTitle.TabIndex = 7;
            this.lLastRunTitle.Text = "Last run:";
            // 
            // timerTextChanged
            // 
            this.timerTextChanged.Interval = 3000;
            this.timerTextChanged.Tick += new System.EventHandler(this.timerTextChanged_Tick);
            // 
            // toggleStartup
            // 
            this.toggleStartup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleStartup.BackColor = System.Drawing.Color.Transparent;
            this.toggleStartup.Checked = false;
            this.toggleStartup.CheckedBackColor = System.Drawing.Color.OrangeRed;
            this.toggleStartup.CheckedSwitchColor = System.Drawing.Color.White;
            this.toggleStartup.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Outline;
            this.toggleStartup.Location = new System.Drawing.Point(439, 146);
            this.toggleStartup.Name = "toggleStartup";
            this.toggleStartup.OutlineThickness = 2;
            this.toggleStartup.Size = new System.Drawing.Size(34, 19);
            this.toggleStartup.TabIndex = 8;
            this.toggleStartup.UncheckedBackColor = System.Drawing.Color.Gray;
            this.toggleStartup.UncheckedSwitchColor = System.Drawing.Color.White;
            this.toggleStartup.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Outline;
            this.toggleStartup.CheckedChanged += new System.EventHandler(this.toggleStartup_CheckedChanged);
            // 
            // linfo1
            // 
            this.linfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linfo1.AutoSize = true;
            this.linfo1.BackColor = System.Drawing.Color.Transparent;
            this.linfo1.Font = new System.Drawing.Font("Brandon Grotesque Light", 12F);
            this.linfo1.ForeColor = System.Drawing.Color.Gray;
            this.linfo1.Location = new System.Drawing.Point(210, 23);
            this.linfo1.Name = "linfo1";
            this.linfo1.Size = new System.Drawing.Size(99, 23);
            this.linfo1.TabIndex = 9;
            this.linfo1.Text = "Version 1.0.1.2";
            // 
            // bLoader
            // 
            this.bLoader.AllowStylePresets = true;
            this.bLoader.BackColor = System.Drawing.Color.Transparent;
            this.bLoader.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.bLoader.Color = System.Drawing.Color.OrangeRed;
            this.bLoader.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.bLoader.Customization = "";
            this.bLoader.DashWidth = 0.3F;
            this.bLoader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bLoader.Image = null;
            this.bLoader.Location = new System.Drawing.Point(202, 103);
            this.bLoader.Name = "bLoader";
            this.bLoader.NoRounding = false;
            this.bLoader.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.bLoader.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.bLoader.ShowText = false;
            this.bLoader.Size = new System.Drawing.Size(32, 32);
            this.bLoader.Speed = 7;
            this.bLoader.TabIndex = 11;
            this.bLoader.Text = "bunifuLoader1";
            this.bLoader.TextPadding = new System.Windows.Forms.Padding(0);
            this.bLoader.Thickness = 6;
            this.bLoader.Transparent = true;
            this.bLoader.Visible = false;
            // 
            // tbInterval
            // 
            this.tbInterval.AcceptsReturn = false;
            this.tbInterval.AcceptsTab = false;
            this.tbInterval.AnimationSpeed = 200;
            this.tbInterval.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbInterval.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbInterval.AutoSizeHeight = true;
            this.tbInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbInterval.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbInterval.BackgroundImage")));
            this.tbInterval.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbInterval.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbInterval.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbInterval.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbInterval.BorderRadius = 3;
            this.tbInterval.BorderThickness = 1;
            this.tbInterval.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbInterval.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbInterval.DefaultFont = new System.Drawing.Font("Brandon Grotesque Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInterval.DefaultText = "60";
            this.tbInterval.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tbInterval.HideSelection = true;
            this.tbInterval.IconLeft = null;
            this.tbInterval.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbInterval.IconPadding = 10;
            this.tbInterval.IconRight = null;
            this.tbInterval.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbInterval.Lines = new string[] {
        "60"};
            this.tbInterval.Location = new System.Drawing.Point(17, 97);
            this.tbInterval.MaxLength = 5;
            this.tbInterval.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbInterval.Modified = false;
            this.tbInterval.Multiline = false;
            this.tbInterval.Name = "tbInterval";
            stateProperties1.BorderColor = System.Drawing.Color.OrangeRed;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbInterval.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbInterval.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Tomato;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbInterval.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbInterval.OnIdleState = stateProperties4;
            this.tbInterval.Padding = new System.Windows.Forms.Padding(3);
            this.tbInterval.PasswordChar = '\0';
            this.tbInterval.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbInterval.PlaceholderText = "";
            this.tbInterval.ReadOnly = false;
            this.tbInterval.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbInterval.SelectedText = "";
            this.tbInterval.SelectionLength = 0;
            this.tbInterval.SelectionStart = 2;
            this.tbInterval.ShortcutsEnabled = false;
            this.tbInterval.Size = new System.Drawing.Size(225, 44);
            this.tbInterval.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbInterval.TabIndex = 3;
            this.tbInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbInterval.TextMarginBottom = 0;
            this.tbInterval.TextMarginLeft = 3;
            this.tbInterval.TextMarginTop = 1;
            this.tbInterval.TextPlaceholder = "";
            this.tbInterval.UseSystemPasswordChar = false;
            this.tbInterval.WordWrap = true;
            this.tbInterval.TextChanged += new System.EventHandler(this.tbInterval_TextChanged);
            this.tbInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInterval_KeyPress);
            // 
            // timerInfo
            // 
            this.timerInfo.Enabled = true;
            this.timerInfo.Interval = 30000;
            this.timerInfo.Tick += new System.EventHandler(this.timerInfo_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(484, 176);
            this.Controls.Add(this.bLoader);
            this.Controls.Add(this.toggleStartup);
            this.Controls.Add(this.lLastRunTitle);
            this.Controls.Add(this.lLastRun);
            this.Controls.Add(this.lStartWithWindows);
            this.Controls.Add(this.tbInterval);
            this.Controls.Add(this.lFrequency);
            this.Controls.Add(this.pTop);
            this.Font = new System.Drawing.Font("Brandon Grotesque Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.cms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pTop;
        private System.Windows.Forms.Label lTitle;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuDragControl drag;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 toggle;
        private Bunifu.UI.WinForms.BunifuImageButton btnMin;
        private System.Windows.Forms.Label lFrequency;
        private System.Windows.Forms.Timer timerMain;
        private Bunifu.UI.WinForms.BunifuTextBox tbInterval;
        private System.Windows.Forms.Label lStartWithWindows;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsEnableOrDisable;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.Label lLastRun;
        private System.Windows.Forms.Label lLastRunTitle;
        private System.Windows.Forms.Timer timerTextChanged;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 toggleStartup;
        private System.Windows.Forms.Label linfo1;
        private Bunifu.UI.WinForms.BunifuLoader bLoader;
        private System.Windows.Forms.Timer timerInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

