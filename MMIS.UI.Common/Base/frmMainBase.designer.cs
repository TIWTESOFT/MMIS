namespace MMIS.UI.Common
{
    partial class frmMainBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainBase));
            this.pnlMenu = new Janus.Windows.UI.Dock.UIPanel();
            this.pnlMenuContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.ribbonStatusBar1 = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.lblLoginUser = new Janus.Windows.Ribbon.LabelCommand();
            this.lblVersion = new Janus.Windows.Ribbon.LabelCommand();
            this.lblVersionTime = new Janus.Windows.Ribbon.LabelCommand();
            this.xPanelManager1 = new MMIS.Component.XPanelManager();
            this.panelMenu = new Janus.Windows.UI.Dock.UIPanelGroup();
            this.pnlFill = new Janus.Windows.UI.Dock.UIPanel();
            this.pnlFillContainer = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            this.xCommandManager1 = new MMIS.Component.XCommandManager();
            this.BottomRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.menuBar = new Janus.Windows.UI.CommandBars.UICommandBar();
            this.cmdFile1 = new Janus.Windows.UI.CommandBars.UICommand("cmdFile");
            this.cmdWindow1 = new Janus.Windows.UI.CommandBars.UICommand("cmdWindow");
            this.cmdHelp1 = new Janus.Windows.UI.CommandBars.UICommand("cmdHelp");
            this.cmdFile = new Janus.Windows.UI.CommandBars.UICommand("cmdFile");
            this.cmdSignOut1 = new Janus.Windows.UI.CommandBars.UICommand("cmdSignOut");
            this.cmdExit1 = new Janus.Windows.UI.CommandBars.UICommand("cmdExit");
            this.cmdHelp = new Janus.Windows.UI.CommandBars.UICommand("cmdHelp");
            this.cmdExit = new Janus.Windows.UI.CommandBars.UICommand("cmdExit");
            this.cmdSignOut = new Janus.Windows.UI.CommandBars.UICommand("cmdSignOut");
            this.cmdWindow = new Janus.Windows.UI.CommandBars.UICommand("cmdWindow");
            this.cmdCloseAll1 = new Janus.Windows.UI.CommandBars.UICommand("cmdCloseAll");
            this.cmdCloseAll = new Janus.Windows.UI.CommandBars.UICommand("cmdCloseAll");
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.LeftRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.RightRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.TopRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.proExecute = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).BeginInit();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).BeginInit();
            this.TopRebar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoHide = true;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 200);
            this.pnlMenu.TabIndex = 4;
            this.pnlMenu.Text = "功能区";
            // 
            // pnlMenuContainer
            // 
            this.pnlMenuContainer.Location = new System.Drawing.Point(1, 23);
            this.pnlMenuContainer.Name = "pnlMenuContainer";
            this.pnlMenuContainer.Size = new System.Drawing.Size(194, 232);
            this.pnlMenuContainer.TabIndex = 0;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ImageSize = new System.Drawing.Size(16, 16);
            this.ribbonStatusBar1.LeftPanelCommands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.lblLoginUser,
            this.lblVersion,
            this.lblVersionTime});
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 353);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Office2007CustomColor = System.Drawing.Color.Empty;
            this.ribbonStatusBar1.ShowToolTips = false;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(851, 23);
            // 
            // 
            // 
            this.ribbonStatusBar1.SuperTipComponent.AutoPopDelay = 2000;
            this.ribbonStatusBar1.SuperTipComponent.ImageList = null;
            this.ribbonStatusBar1.TabIndex = 0;
            this.ribbonStatusBar1.Text = "ribbonStatusBar1";
            this.ribbonStatusBar1.UseCompatibleTextRendering = false;
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AllowAddToQuickAccessBar = true;
            this.lblLoginUser.Key = "labelCommand1";
            this.lblLoginUser.Name = "labelCommand1";
            this.lblLoginUser.Text = "登陆人：";
            // 
            // lblVersion
            // 
            this.lblVersion.AllowAddToQuickAccessBar = true;
            this.lblVersion.Key = "labelCommand1";
            this.lblVersion.Name = "labelCommand1";
            this.lblVersion.Text = "version";
            // 
            // lblVersionTime
            // 
            this.lblVersionTime.AllowAddToQuickAccessBar = true;
            this.lblVersionTime.Key = "labelCommand1";
            this.lblVersionTime.Name = "labelCommand1";
            this.lblVersionTime.Text = "versiontime";
            // 
            // xPanelManager1
            // 
            this.xPanelManager1.BuiltInTextsData = resources.GetString("xPanelManager1.BuiltInTextsData");
            this.xPanelManager1.ContainerControl = this;
            this.xPanelManager1.TabbedMdi = true;
            this.xPanelManager1.TabbedMdiSettings.UseFormIcons = true;
            this.xPanelManager1.TabbedMdiSettings.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            this.xPanelManager1.Tag = null;
            this.xPanelManager1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            this.panelMenu.Id = new System.Guid("0030b1bd-85c0-4ae3-a0f9-16255b098c5c");
            this.panelMenu.StaticGroup = true;
            this.xPanelManager1.Panels.Add(this.panelMenu);
            this.pnlFill.Id = new System.Guid("157f3a53-8090-4198-9122-eb3f597d1d51");
            this.xPanelManager1.Panels.Add(this.pnlFill);
            // 
            // Design Time Panel Info:
            // 
            this.xPanelManager1.BeginPanelInfo();
            this.xPanelManager1.AddDockPanelInfo(new System.Guid("0030b1bd-85c0-4ae3-a0f9-16255b098c5c"), Janus.Windows.UI.Dock.PanelGroupStyle.OutlookNavigator, Janus.Windows.UI.Dock.PanelDockStyle.Left, true, new System.Drawing.Size(174, 320), true);
            this.xPanelManager1.AddDockPanelInfo(new System.Guid("157f3a53-8090-4198-9122-eb3f597d1d51"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, new System.Drawing.Size(671, 320), true);
            this.xPanelManager1.AddFloatingPanelInfo(new System.Guid("e6b83dfa-12b0-4a13-9dfb-4c377cdb1fa0"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.xPanelManager1.AddFloatingPanelInfo(new System.Guid("157f3a53-8090-4198-9122-eb3f597d1d51"), new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.xPanelManager1.AddFloatingPanelInfo(new System.Guid("0030b1bd-85c0-4ae3-a0f9-16255b098c5c"), Janus.Windows.UI.Dock.PanelGroupStyle.OutlookNavigator, true, new System.Drawing.Point(-1, -1), new System.Drawing.Size(-1, -1), false);
            this.xPanelManager1.EndPanelInfo();
            // 
            // panelMenu
            // 
            this.panelMenu.ActiveCaptionMode = Janus.Windows.UI.Dock.ActiveCaptionMode.Never;
            this.panelMenu.AllowPanelDrag = Janus.Windows.UI.InheritableBoolean.False;
            this.panelMenu.AllowPanelDrop = Janus.Windows.UI.InheritableBoolean.False;
            this.panelMenu.AutoHideButtonVisible = Janus.Windows.UI.InheritableBoolean.True;
            this.panelMenu.CaptionDisplayMode = Janus.Windows.UI.Dock.PanelCaptionDisplayMode.ImageAndText;
            this.panelMenu.CaptionDoubleClickAction = Janus.Windows.UI.Dock.CaptionDoubleClickAction.None;
            this.panelMenu.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.panelMenu.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelMenu.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.OutlookNavigator;
            this.panelMenu.Location = new System.Drawing.Point(3, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 320);
            this.panelMenu.TabIndex = 4;
            this.panelMenu.Text = "Panel 0";
            // 
            // pnlFill
            // 
            this.pnlFill.AutoHideButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.pnlFill.BorderCaption = Janus.Windows.UI.InheritableBoolean.False;
            this.pnlFill.CaptionVisible = Janus.Windows.UI.InheritableBoolean.False;
            this.pnlFill.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlFill.InnerContainer = this.pnlFillContainer;
            this.pnlFill.Location = new System.Drawing.Point(177, 30);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(671, 320);
            this.pnlFill.TabIndex = 7;
            // 
            // pnlFillContainer
            // 
            this.pnlFillContainer.Location = new System.Drawing.Point(1, 1);
            this.pnlFillContainer.Name = "pnlFillContainer";
            this.pnlFillContainer.Size = new System.Drawing.Size(669, 318);
            this.pnlFillContainer.TabIndex = 0;
            // 
            // xCommandManager1
            // 
            this.xCommandManager1.BottomRebar = this.BottomRebar1;
            this.xCommandManager1.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.menuBar});
            this.xCommandManager1.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdFile,
            this.cmdHelp,
            this.cmdExit,
            this.cmdSignOut,
            this.cmdWindow,
            this.cmdCloseAll});
            this.xCommandManager1.ContainerControl = this;
            this.xCommandManager1.Id = new System.Guid("353b18a7-4ce1-4eec-a602-754bdedc87c1");
            this.xCommandManager1.ImageList = this.imageList;
            this.xCommandManager1.LeftRebar = this.LeftRebar1;
            this.xCommandManager1.RightRebar = this.RightRebar1;
            this.xCommandManager1.Tag = null;
            this.xCommandManager1.TopRebar = this.TopRebar1;
            this.xCommandManager1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // BottomRebar1
            // 
            this.BottomRebar1.CommandManager = this.xCommandManager1;
            this.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomRebar1.Location = new System.Drawing.Point(0, 376);
            this.BottomRebar1.Name = "BottomRebar1";
            this.BottomRebar1.Size = new System.Drawing.Size(851, 0);
            // 
            // menuBar
            // 
            this.menuBar.AllowMerge = Janus.Windows.UI.InheritableBoolean.False;
            this.menuBar.CommandBarType = Janus.Windows.UI.CommandBars.CommandBarType.Menu;
            this.menuBar.CommandManager = this.xCommandManager1;
            this.menuBar.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdFile1,
            this.cmdWindow1,
            this.cmdHelp1});
            this.menuBar.Key = "menuBar";
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.RowIndex = 0;
            this.menuBar.ShowAddRemoveButton = Janus.Windows.UI.InheritableBoolean.False;
            this.menuBar.ShowCustomizeButton = Janus.Windows.UI.InheritableBoolean.False;
            this.menuBar.Size = new System.Drawing.Size(851, 27);
            this.menuBar.Text = "CommandBar1";
            // 
            // cmdFile1
            // 
            this.cmdFile1.Key = "cmdFile";
            this.cmdFile1.Name = "cmdFile1";
            // 
            // cmdWindow1
            // 
            this.cmdWindow1.Key = "cmdWindow";
            this.cmdWindow1.Name = "cmdWindow1";
            // 
            // cmdHelp1
            // 
            this.cmdHelp1.Key = "cmdHelp";
            this.cmdHelp1.Name = "cmdHelp1";
            // 
            // cmdFile
            // 
            this.cmdFile.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdSignOut1,
            this.cmdExit1});
            this.cmdFile.Key = "cmdFile";
            this.cmdFile.Name = "cmdFile";
            this.cmdFile.Text = "文件";
            // 
            // cmdSignOut1
            // 
            this.cmdSignOut1.Key = "cmdSignOut";
            this.cmdSignOut1.Name = "cmdSignOut1";
            // 
            // cmdExit1
            // 
            this.cmdExit1.Key = "cmdExit";
            this.cmdExit1.Name = "cmdExit1";
            // 
            // cmdHelp
            // 
            this.cmdHelp.Key = "cmdHelp";
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Text = "帮助";
            // 
            // cmdExit
            // 
            this.cmdExit.ImageIndex = 122;
            this.cmdExit.Key = "cmdExit";
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Text = "退出";
            this.cmdExit.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdExit_Click);
            // 
            // cmdSignOut
            // 
            this.cmdSignOut.ImageIndex = 69;
            this.cmdSignOut.Key = "cmdSignOut";
            this.cmdSignOut.Name = "cmdSignOut";
            this.cmdSignOut.Text = "注销";
            this.cmdSignOut.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdSignOut_Click);
            // 
            // cmdWindow
            // 
            this.cmdWindow.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdCloseAll1});
            this.cmdWindow.Key = "cmdWindow";
            this.cmdWindow.Name = "cmdWindow";
            this.cmdWindow.Text = "窗口";
            // 
            // cmdCloseAll1
            // 
            this.cmdCloseAll1.Key = "cmdCloseAll";
            this.cmdCloseAll1.Name = "cmdCloseAll1";
            // 
            // cmdCloseAll
            // 
            this.cmdCloseAll.ImageIndex = 122;
            this.cmdCloseAll.Key = "cmdCloseAll";
            this.cmdCloseAll.Name = "cmdCloseAll";
            this.cmdCloseAll.Text = "关闭所有";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "");
            this.imageList.Images.SetKeyName(1, "");
            this.imageList.Images.SetKeyName(2, "");
            this.imageList.Images.SetKeyName(3, "");
            this.imageList.Images.SetKeyName(4, "");
            this.imageList.Images.SetKeyName(5, "");
            this.imageList.Images.SetKeyName(6, "");
            this.imageList.Images.SetKeyName(7, "");
            this.imageList.Images.SetKeyName(8, "");
            this.imageList.Images.SetKeyName(9, "");
            this.imageList.Images.SetKeyName(10, "");
            this.imageList.Images.SetKeyName(11, "");
            this.imageList.Images.SetKeyName(12, "");
            this.imageList.Images.SetKeyName(13, "");
            this.imageList.Images.SetKeyName(14, "");
            this.imageList.Images.SetKeyName(15, "");
            this.imageList.Images.SetKeyName(16, "");
            this.imageList.Images.SetKeyName(17, "");
            this.imageList.Images.SetKeyName(18, "");
            this.imageList.Images.SetKeyName(19, "");
            this.imageList.Images.SetKeyName(20, "");
            this.imageList.Images.SetKeyName(21, "");
            this.imageList.Images.SetKeyName(22, "");
            this.imageList.Images.SetKeyName(23, "");
            this.imageList.Images.SetKeyName(24, "");
            this.imageList.Images.SetKeyName(25, "");
            this.imageList.Images.SetKeyName(26, "");
            this.imageList.Images.SetKeyName(27, "");
            this.imageList.Images.SetKeyName(28, "");
            this.imageList.Images.SetKeyName(29, "");
            this.imageList.Images.SetKeyName(30, "");
            this.imageList.Images.SetKeyName(31, "");
            this.imageList.Images.SetKeyName(32, "");
            this.imageList.Images.SetKeyName(33, "");
            this.imageList.Images.SetKeyName(34, "");
            this.imageList.Images.SetKeyName(35, "");
            this.imageList.Images.SetKeyName(36, "");
            this.imageList.Images.SetKeyName(37, "");
            this.imageList.Images.SetKeyName(38, "");
            this.imageList.Images.SetKeyName(39, "");
            this.imageList.Images.SetKeyName(40, "");
            this.imageList.Images.SetKeyName(41, "");
            this.imageList.Images.SetKeyName(42, "");
            this.imageList.Images.SetKeyName(43, "");
            this.imageList.Images.SetKeyName(44, "");
            this.imageList.Images.SetKeyName(45, "");
            this.imageList.Images.SetKeyName(46, "");
            this.imageList.Images.SetKeyName(47, "");
            this.imageList.Images.SetKeyName(48, "");
            this.imageList.Images.SetKeyName(49, "");
            this.imageList.Images.SetKeyName(50, "");
            this.imageList.Images.SetKeyName(51, "");
            this.imageList.Images.SetKeyName(52, "");
            this.imageList.Images.SetKeyName(53, "");
            this.imageList.Images.SetKeyName(54, "");
            this.imageList.Images.SetKeyName(55, "");
            this.imageList.Images.SetKeyName(56, "");
            this.imageList.Images.SetKeyName(57, "");
            this.imageList.Images.SetKeyName(58, "");
            this.imageList.Images.SetKeyName(59, "");
            this.imageList.Images.SetKeyName(60, "");
            this.imageList.Images.SetKeyName(61, "");
            this.imageList.Images.SetKeyName(62, "");
            this.imageList.Images.SetKeyName(63, "");
            this.imageList.Images.SetKeyName(64, "");
            this.imageList.Images.SetKeyName(65, "");
            this.imageList.Images.SetKeyName(66, "");
            this.imageList.Images.SetKeyName(67, "");
            this.imageList.Images.SetKeyName(68, "");
            this.imageList.Images.SetKeyName(69, "");
            this.imageList.Images.SetKeyName(70, "");
            this.imageList.Images.SetKeyName(71, "");
            this.imageList.Images.SetKeyName(72, "");
            this.imageList.Images.SetKeyName(73, "");
            this.imageList.Images.SetKeyName(74, "");
            this.imageList.Images.SetKeyName(75, "");
            this.imageList.Images.SetKeyName(76, "");
            this.imageList.Images.SetKeyName(77, "");
            this.imageList.Images.SetKeyName(78, "");
            this.imageList.Images.SetKeyName(79, "");
            this.imageList.Images.SetKeyName(80, "");
            this.imageList.Images.SetKeyName(81, "");
            this.imageList.Images.SetKeyName(82, "");
            this.imageList.Images.SetKeyName(83, "");
            this.imageList.Images.SetKeyName(84, "");
            this.imageList.Images.SetKeyName(85, "");
            this.imageList.Images.SetKeyName(86, "");
            this.imageList.Images.SetKeyName(87, "");
            this.imageList.Images.SetKeyName(88, "");
            this.imageList.Images.SetKeyName(89, "");
            this.imageList.Images.SetKeyName(90, "");
            this.imageList.Images.SetKeyName(91, "");
            this.imageList.Images.SetKeyName(92, "");
            this.imageList.Images.SetKeyName(93, "");
            this.imageList.Images.SetKeyName(94, "");
            this.imageList.Images.SetKeyName(95, "");
            this.imageList.Images.SetKeyName(96, "");
            this.imageList.Images.SetKeyName(97, "");
            this.imageList.Images.SetKeyName(98, "");
            this.imageList.Images.SetKeyName(99, "");
            this.imageList.Images.SetKeyName(100, "");
            this.imageList.Images.SetKeyName(101, "");
            this.imageList.Images.SetKeyName(102, "");
            this.imageList.Images.SetKeyName(103, "");
            this.imageList.Images.SetKeyName(104, "");
            this.imageList.Images.SetKeyName(105, "");
            this.imageList.Images.SetKeyName(106, "");
            this.imageList.Images.SetKeyName(107, "");
            this.imageList.Images.SetKeyName(108, "");
            this.imageList.Images.SetKeyName(109, "");
            this.imageList.Images.SetKeyName(110, "");
            this.imageList.Images.SetKeyName(111, "");
            this.imageList.Images.SetKeyName(112, "");
            this.imageList.Images.SetKeyName(113, "");
            this.imageList.Images.SetKeyName(114, "");
            this.imageList.Images.SetKeyName(115, "");
            this.imageList.Images.SetKeyName(116, "");
            this.imageList.Images.SetKeyName(117, "");
            this.imageList.Images.SetKeyName(118, "");
            this.imageList.Images.SetKeyName(119, "");
            this.imageList.Images.SetKeyName(120, "");
            this.imageList.Images.SetKeyName(121, "");
            this.imageList.Images.SetKeyName(122, "");
            this.imageList.Images.SetKeyName(123, "");
            // 
            // LeftRebar1
            // 
            this.LeftRebar1.CommandManager = this.xCommandManager1;
            this.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftRebar1.Location = new System.Drawing.Point(0, 27);
            this.LeftRebar1.Name = "LeftRebar1";
            this.LeftRebar1.Size = new System.Drawing.Size(0, 349);
            // 
            // RightRebar1
            // 
            this.RightRebar1.CommandManager = this.xCommandManager1;
            this.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightRebar1.Location = new System.Drawing.Point(851, 27);
            this.RightRebar1.Name = "RightRebar1";
            this.RightRebar1.Size = new System.Drawing.Size(0, 349);
            // 
            // TopRebar1
            // 
            this.TopRebar1.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.menuBar});
            this.TopRebar1.CommandManager = this.xCommandManager1;
            this.TopRebar1.Controls.Add(this.menuBar);
            this.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopRebar1.Location = new System.Drawing.Point(0, 0);
            this.TopRebar1.Name = "TopRebar1";
            this.TopRebar1.Size = new System.Drawing.Size(851, 27);
            // 
            // proExecute
            // 
            this.proExecute.Location = new System.Drawing.Point(108, 2);
            this.proExecute.Name = "proExecute";
            this.proExecute.Size = new System.Drawing.Size(100, 20);
            this.proExecute.TabIndex = 13;
            // 
            // frmMainBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 376);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.LeftRebar1);
            this.Controls.Add(this.RightRebar1);
            this.Controls.Add(this.TopRebar1);
            this.Controls.Add(this.BottomRebar1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMainBase";
            this.Text = "系统名称";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).EndInit();
            this.pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        protected Janus.Windows.UI.Dock.UIPanel pnlMenu;
        protected Janus.Windows.UI.Dock.UIPanelInnerContainer pnlMenuContainer;
        protected Janus.Windows.Ribbon.RibbonStatusBar ribbonStatusBar1;
        protected Janus.Windows.UI.Dock.UIPanel pnlFill;
        protected Janus.Windows.UI.Dock.UIPanelInnerContainer pnlFillContainer;
        protected Component.XPanelManager xPanelManager1;
        protected Janus.Windows.Ribbon.LabelCommand lblVersion;
        protected Janus.Windows.UI.Dock.UIPanelGroup panelMenu;
        protected Janus.Windows.UI.CommandBars.UIRebar LeftRebar1;
        protected Component.XCommandManager xCommandManager1;
        protected Janus.Windows.UI.CommandBars.UIRebar BottomRebar1;
        protected Janus.Windows.UI.CommandBars.UICommandBar menuBar;
        protected Janus.Windows.UI.CommandBars.UICommand cmdFile;
        protected Janus.Windows.UI.CommandBars.UICommand cmdHelp;
        protected Janus.Windows.UI.CommandBars.UIRebar RightRebar1;
        protected Janus.Windows.UI.CommandBars.UIRebar TopRebar1;
        protected Janus.Windows.UI.CommandBars.UICommand cmdFile1;
        protected Janus.Windows.UI.CommandBars.UICommand cmdHelp1;
        protected Janus.Windows.UI.CommandBars.UICommand cmdExit1;
        protected Janus.Windows.UI.CommandBars.UICommand cmdExit;
        private Janus.Windows.UI.CommandBars.UICommand cmdSignOut1;
        private Janus.Windows.UI.CommandBars.UICommand cmdSignOut;
        protected System.Windows.Forms.ImageList imageList;
        protected Janus.Windows.Ribbon.LabelCommand lblLoginUser;
        private System.Windows.Forms.ProgressBar proExecute;
        private Janus.Windows.UI.CommandBars.UICommand cmdWindow1;
        private Janus.Windows.UI.CommandBars.UICommand cmdWindow;
        private Janus.Windows.UI.CommandBars.UICommand cmdCloseAll;
        protected Janus.Windows.Ribbon.LabelCommand lblVersionTime;
        public Janus.Windows.UI.CommandBars.UICommand cmdCloseAll1;



    }
}

