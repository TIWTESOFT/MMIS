namespace MMIS.UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tmDispose = new System.Windows.Forms.Timer(this.components);
            this.cmdEditPass = new Janus.Windows.UI.CommandBars.UICommand("cmdEditPass");
            this.cmdEditPass1 = new Janus.Windows.UI.CommandBars.UICommand("cmdEditPass");
            this.tmTask = new System.Windows.Forms.Timer(this.components);
            this.cmdSystemConfig = new Janus.Windows.UI.CommandBars.UICommand("cmdSystemConfig");
            this.cmdSystemConfig1 = new Janus.Windows.UI.CommandBars.UICommand("cmdSystemConfig");
            ((System.ComponentModel.ISupportInitialize)(this.pnlMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).BeginInit();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xPanelManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).BeginInit();
            this.TopRebar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonStatusBar1
            // 
            // 
            // 
            // 
            this.ribbonStatusBar1.SuperTipComponent.AutoPopDelay = 2000;
            this.ribbonStatusBar1.SuperTipComponent.ImageList = null;
            // 
            // pnlFill
            // 
            this.pnlFill.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlFill.Location = new System.Drawing.Point(177, 30);
            this.pnlFill.Size = new System.Drawing.Size(671, 320);
            // 
            // xPanelManager1
            // 
            this.xPanelManager1.TabbedMdiSettings.UseFormIcons = true;
            this.xPanelManager1.TabbedMdiSettings.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
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
            this.panelMenu.Location = new System.Drawing.Point(3, 30);
            this.panelMenu.Size = new System.Drawing.Size(174, 320);
            // 
            // LeftRebar1
            // 
            this.LeftRebar1.Location = new System.Drawing.Point(0, 27);
            this.LeftRebar1.Size = new System.Drawing.Size(0, 349);
            // 
            // xCommandManager1
            // 
            this.xCommandManager1.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdEditPass,
            this.cmdSystemConfig});
            // 
            // menuBar
            // 
            this.menuBar.Size = new System.Drawing.Size(851, 27);
            // 
            // cmdFile
            // 
            this.cmdFile.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdEditPass1,
            this.cmdSystemConfig1});
            // 
            // RightRebar1
            // 
            this.RightRebar1.Location = new System.Drawing.Point(851, 27);
            this.RightRebar1.Size = new System.Drawing.Size(0, 349);
            // 
            // TopRebar1
            // 
            this.TopRebar1.Size = new System.Drawing.Size(851, 27);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
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
            // tmDispose
            // 
            this.tmDispose.Interval = 600000;
            this.tmDispose.Tick += new System.EventHandler(this.tmDispose_Tick);
            // 
            // cmdEditPass
            // 
            this.cmdEditPass.Key = "cmdEditPass";
            this.cmdEditPass.Name = "cmdEditPass";
            this.cmdEditPass.Text = "修改密码";
            // 
            // cmdEditPass1
            // 
            this.cmdEditPass1.Key = "cmdEditPass";
            this.cmdEditPass1.Name = "cmdEditPass1";
            // 
            // tmTask
            // 
            this.tmTask.Enabled = true;
            this.tmTask.Interval = 60000;
            this.tmTask.Tick += new System.EventHandler(this.tmTask_Tick);
            // 
            // cmdSystemConfig
            // 
            this.cmdSystemConfig.ImageIndex = 10;
            this.cmdSystemConfig.Key = "cmdSystemConfig";
            this.cmdSystemConfig.Name = "cmdSystemConfig";
            this.cmdSystemConfig.Text = "系统设置";
            // 
            // cmdSystemConfig1
            // 
            this.cmdSystemConfig1.Key = "cmdSystemConfig";
            this.cmdSystemConfig1.Name = "cmdSystemConfig1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 376);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMain";
            this.Text = "计量中心信息管理系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Controls.SetChildIndex(this.BottomRebar1, 0);
            this.Controls.SetChildIndex(this.TopRebar1, 0);
            this.Controls.SetChildIndex(this.RightRebar1, 0);
            this.Controls.SetChildIndex(this.LeftRebar1, 0);
            this.Controls.SetChildIndex(this.ribbonStatusBar1, 0);
            this.Controls.SetChildIndex(this.panelMenu, 0);
            this.Controls.SetChildIndex(this.pnlFill, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).EndInit();
            this.pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xPanelManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmDispose;
        private Janus.Windows.UI.CommandBars.UICommand cmdEditPass;
        private Janus.Windows.UI.CommandBars.UICommand cmdEditPass1;
        private System.Windows.Forms.Timer tmTask;
        private Janus.Windows.UI.CommandBars.UICommand cmdSystemConfig;
        private Janus.Windows.UI.CommandBars.UICommand cmdSystemConfig1;
    }
}