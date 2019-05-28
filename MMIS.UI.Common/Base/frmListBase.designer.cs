namespace MMIS.UI.Common
{
    /// <summary>
    /// frmListBase 窗口
    /// 名称: frmListBase 窗口 分布类
    /// 时间: 2011/9/4 8:54:04
    /// 作者: Administrator
    /// </summary>
    partial class frmListBase
    {
        #region Windows 窗体设计器生成的代码

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

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Janus.Windows.GridEX.GridEXLayout grdData_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListBase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.grdData = new MMIS.Component.XGridEx();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpQuery = new MMIS.Component.XGroupBox();
            this.chkChecked = new MMIS.Component.XQueryCheckBox();
            this.btnQuery = new MMIS.Component.XButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.TopRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.ListToolBar = new Janus.Windows.UI.CommandBars.UICommandBar();
            this.xCommandManager1 = new MMIS.Component.XCommandManager();
            this.BottomRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.cdAddNew = new Janus.Windows.UI.CommandBars.UICommand("cdAddNew");
            this.cmEdit = new Janus.Windows.UI.CommandBars.UICommand("cmEdit");
            this.cmDelete = new Janus.Windows.UI.CommandBars.UICommand("cmDelete");
            this.cmdRefresh = new Janus.Windows.UI.CommandBars.UICommand("cmdRefresh");
            this.cmdExport = new Janus.Windows.UI.CommandBars.UICommand("cmdExport");
            this.cmdImport = new Janus.Windows.UI.CommandBars.UICommand("cmdImport");
            this.cmdExit = new Janus.Windows.UI.CommandBars.UICommand("cmdExit");
            this.cmdQuery = new Janus.Windows.UI.CommandBars.UICommand("cmdQuery");
            this.cmdPrint = new Janus.Windows.UI.CommandBars.UICommand("cmdPrint");
            this.cmdSend = new Janus.Windows.UI.CommandBars.UICommand("cmdSend");
            this.cmdFile = new Janus.Windows.UI.CommandBars.UICommand("cmdFile");
            this.cmdViewFile1 = new Janus.Windows.UI.CommandBars.UICommand("cmdViewFile");
            this.cmdUploadFile1 = new Janus.Windows.UI.CommandBars.UICommand("cmdUploadFile");
            this.cmdDownload1 = new Janus.Windows.UI.CommandBars.UICommand("cmdDownload");
            this.cmdViewFile = new Janus.Windows.UI.CommandBars.UICommand("cmdViewFile");
            this.cmdUploadFile = new Janus.Windows.UI.CommandBars.UICommand("cmdUploadFile");
            this.cmdDownload = new Janus.Windows.UI.CommandBars.UICommand("cmdDownload");
            this.cmdCommit = new Janus.Windows.UI.CommandBars.UICommand("cmdCommit");
            this.cmdRollback = new Janus.Windows.UI.CommandBars.UICommand("cmdRollback");
            this.cmdCheck = new Janus.Windows.UI.CommandBars.UICommand("cmdCheck");
            this.cmdBackCheck = new Janus.Windows.UI.CommandBars.UICommand("cmdBackCheck");
            this.cmdBackSend = new Janus.Windows.UI.CommandBars.UICommand("cmdBackSend");
            this.cmdViewWorkFlow = new Janus.Windows.UI.CommandBars.UICommand("cmdViewWorkFlow");
            this.cmdFeedback = new Janus.Windows.UI.CommandBars.UICommand("cmdFeedback");
            this.cmdBackFeedback = new Janus.Windows.UI.CommandBars.UICommand("cmdBackFeedback");
            this.cmdPreview = new Janus.Windows.UI.CommandBars.UICommand("cmdPreview");
            this.cmRight = new Janus.Windows.UI.CommandBars.UIContextMenu();
            this.cdAddNew1 = new Janus.Windows.UI.CommandBars.UICommand("cdAddNew");
            this.cmEdit1 = new Janus.Windows.UI.CommandBars.UICommand("cmEdit");
            this.cmDelete1 = new Janus.Windows.UI.CommandBars.UICommand("cmDelete");
            this.Separator1 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdPrint2 = new Janus.Windows.UI.CommandBars.UICommand("cmdPrint");
            this.Separator10 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdRefresh1 = new Janus.Windows.UI.CommandBars.UICommand("cmdRefresh");
            this.Separator2 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdSend1 = new Janus.Windows.UI.CommandBars.UICommand("cmdSend");
            this.cmdBackSend1 = new Janus.Windows.UI.CommandBars.UICommand("cmdBackSend");
            this.Separator9 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdFeedback1 = new Janus.Windows.UI.CommandBars.UICommand("cmdFeedback");
            this.cmdBackFeedback1 = new Janus.Windows.UI.CommandBars.UICommand("cmdBackFeedback");
            this.Separator7 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdCommit1 = new Janus.Windows.UI.CommandBars.UICommand("cmdCommit");
            this.cmdRollback1 = new Janus.Windows.UI.CommandBars.UICommand("cmdRollback");
            this.cmdViewWorkFlow1 = new Janus.Windows.UI.CommandBars.UICommand("cmdViewWorkFlow");
            this.Separator12 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdImport1 = new Janus.Windows.UI.CommandBars.UICommand("cmdImport");
            this.cmdExport1 = new Janus.Windows.UI.CommandBars.UICommand("cmdExport");
            this.Separator11 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdFile1 = new Janus.Windows.UI.CommandBars.UICommand("cmdFile");
            this.cmdDownload2 = new Janus.Windows.UI.CommandBars.UICommand("cmdDownload");
            this.Separator3 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdPreview1 = new Janus.Windows.UI.CommandBars.UICommand("cmdPreview");
            this.Separator13 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdExit1 = new Janus.Windows.UI.CommandBars.UICommand("cmdExit");
            this.cmCheck = new Janus.Windows.UI.CommandBars.UIContextMenu();
            this.cmdCheck3 = new Janus.Windows.UI.CommandBars.UICommand("cmdCheck");
            this.cmdBackCheck3 = new Janus.Windows.UI.CommandBars.UICommand("cmdBackCheck");
            this.LeftRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.RightRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.cdAddNew2 = new Janus.Windows.UI.CommandBars.UICommand("cdAddNew");
            this.cmEdit2 = new Janus.Windows.UI.CommandBars.UICommand("cmEdit");
            this.cmDelete2 = new Janus.Windows.UI.CommandBars.UICommand("cmDelete");
            this.Separator4 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdRefresh2 = new Janus.Windows.UI.CommandBars.UICommand("cmdRefresh");
            this.Separator5 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdPrint1 = new Janus.Windows.UI.CommandBars.UICommand("cmdPrint");
            this.Separator8 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdImport2 = new Janus.Windows.UI.CommandBars.UICommand("cmdImport");
            this.cmdExport2 = new Janus.Windows.UI.CommandBars.UICommand("cmdExport");
            this.Separator6 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdExit2 = new Janus.Windows.UI.CommandBars.UICommand("cmdExit");
            this.cmdCheck1 = new Janus.Windows.UI.CommandBars.UICommand("cmdCheck");
            this.cmdBackCheck1 = new Janus.Windows.UI.CommandBars.UICommand("cmdBackCheck");
            this.grdExporter = new Janus.Windows.GridEX.Export.GridEXExporter(this.components);
            this.grdPrinter = new Janus.Windows.GridEX.GridEXPrintDocument();
            this.tmRefresh = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpQuery)).BeginInit();
            this.grpQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).BeginInit();
            this.TopRebar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 361);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(623, 288);
            this.panel3.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.grdData);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(10, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(603, 268);
            this.panel8.TabIndex = 4;
            // 
            // grdData
            // 
            this.grdData.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdData.AlternatingColors = true;
            this.grdData.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>拖动列名至此" +
    "进行分组</GroupByBoxInfo></LocalizableData>";
            grdData_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>";
            this.grdData.DesignTimeLayout = grdData_DesignTimeLayout;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.grdData.Location = new System.Drawing.Point(0, 0);
            this.grdData.Name = "grdData";
            this.grdData.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.grdData.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdData.Size = new System.Drawing.Size(603, 268);
            this.grdData.TabIndex = 0;
            this.grdData.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdData.Click += new System.EventHandler(this.grdData_Click);
            this.grdData.DoubleClick += new System.EventHandler(this.grdData_DoubleClick);
            this.grdData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdData_MouseDown);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(10, 278);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(603, 10);
            this.panel7.TabIndex = 3;
            this.panel7.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(613, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 278);
            this.panel6.TabIndex = 2;
            this.panel6.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 278);
            this.panel5.TabIndex = 1;
            this.panel5.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(623, 10);
            this.panel4.TabIndex = 0;
            this.panel4.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpQuery);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 73);
            this.panel2.TabIndex = 0;
            // 
            // grpQuery
            // 
            this.grpQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpQuery.Controls.Add(this.chkChecked);
            this.grpQuery.Controls.Add(this.btnQuery);
            this.grpQuery.Location = new System.Drawing.Point(6, 7);
            this.grpQuery.Name = "grpQuery";
            this.grpQuery.Size = new System.Drawing.Size(612, 55);
            this.grpQuery.TabIndex = 2;
            this.grpQuery.Text = "操作区";
            this.grpQuery.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // chkChecked
            // 
            this.chkChecked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkChecked.IsBoolValue = true;
            this.chkChecked.IsStringValue = false;
            this.chkChecked.Location = new System.Drawing.Point(455, 20);
            this.chkChecked.Model = null;
            this.chkChecked.Name = "chkChecked";
            this.chkChecked.QueryCheckBox = null;
            this.chkChecked.QueryCheckedValue = "1";
            this.chkChecked.QueryFieldName = "IsCheck";
            this.chkChecked.QueryIsNotCheckedIsAll = true;
            this.chkChecked.QueryNotCheckedValue = "0";
            this.chkChecked.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.chkChecked.Size = new System.Drawing.Size(63, 23);
            this.chkChecked.TabIndex = 1000;
            this.chkChecked.Text = "已审核";
            this.chkChecked.Visible = false;
            this.chkChecked.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.ImageIndex = 118;
            this.btnQuery.ImageList = this.imageList;
            this.btnQuery.Location = new System.Drawing.Point(524, 18);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 27);
            this.btnQuery.TabIndex = 999;
            this.btnQuery.Text = "查询";
            this.btnQuery.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
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
            // TopRebar1
            // 
            this.TopRebar1.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.ListToolBar});
            this.TopRebar1.CommandManager = this.xCommandManager1;
            this.TopRebar1.Controls.Add(this.ListToolBar);
            this.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopRebar1.Location = new System.Drawing.Point(0, 0);
            this.TopRebar1.Name = "TopRebar1";
            this.TopRebar1.Size = new System.Drawing.Size(623, 28);
            this.TopRebar1.Visible = false;
            this.TopRebar1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // ListToolBar
            // 
            this.ListToolBar.AllowClose = Janus.Windows.UI.InheritableBoolean.False;
            this.ListToolBar.AllowCustomize = Janus.Windows.UI.InheritableBoolean.False;
            this.ListToolBar.AllowMerge = Janus.Windows.UI.InheritableBoolean.True;
            this.ListToolBar.CausesValidation = false;
            this.ListToolBar.CommandManager = this.xCommandManager1;
            this.ListToolBar.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cdAddNew2,
            this.cmEdit2,
            this.cmDelete2,
            this.Separator4,
            this.cmdRefresh2,
            this.Separator5,
            this.cmdPrint1,
            this.Separator8,
            this.cmdImport2,
            this.cmdExport2,
            this.Separator6,
            this.cmdExit2});
            this.ListToolBar.Key = "ListToolBar";
            this.ListToolBar.Location = new System.Drawing.Point(0, 0);
            this.ListToolBar.Name = "ListToolBar";
            this.ListToolBar.RowIndex = 0;
            this.ListToolBar.ShowAddRemoveButton = Janus.Windows.UI.InheritableBoolean.False;
            this.ListToolBar.ShowCustomizeButton = Janus.Windows.UI.InheritableBoolean.False;
            this.ListToolBar.Size = new System.Drawing.Size(506, 28);
            this.ListToolBar.Text = "CommandBar1";
            // 
            // xCommandManager1
            // 
            this.xCommandManager1.BottomRebar = this.BottomRebar1;
            this.xCommandManager1.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.ListToolBar});
            this.xCommandManager1.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cdAddNew,
            this.cmEdit,
            this.cmDelete,
            this.cmdRefresh,
            this.cmdExport,
            this.cmdImport,
            this.cmdExit,
            this.cmdQuery,
            this.cmdPrint,
            this.cmdSend,
            this.cmdFile,
            this.cmdViewFile,
            this.cmdUploadFile,
            this.cmdDownload,
            this.cmdCommit,
            this.cmdRollback,
            this.cmdCheck,
            this.cmdBackCheck,
            this.cmdBackSend,
            this.cmdViewWorkFlow,
            this.cmdFeedback,
            this.cmdBackFeedback,
            this.cmdPreview});
            this.xCommandManager1.ContainerControl = this;
            this.xCommandManager1.ContextMenus.AddRange(new Janus.Windows.UI.CommandBars.UIContextMenu[] {
            this.cmRight,
            this.cmCheck});
            this.xCommandManager1.Id = new System.Guid("19942ba8-ff53-4cc6-874e-13d1027a5708");
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
            this.BottomRebar1.Location = new System.Drawing.Point(0, 569);
            this.BottomRebar1.Name = "BottomRebar1";
            this.BottomRebar1.Size = new System.Drawing.Size(824, 0);
            this.BottomRebar1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // cdAddNew
            // 
            this.cdAddNew.ImageIndex = 120;
            this.cdAddNew.Key = "cdAddNew";
            this.cdAddNew.LargeImageIndex = 120;
            this.cdAddNew.Name = "cdAddNew";
            this.cdAddNew.Text = "添加";
            this.cdAddNew.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cdAddNew_Click);
            // 
            // cmEdit
            // 
            this.cmEdit.ImageIndex = 41;
            this.cmEdit.Key = "cmEdit";
            this.cmEdit.LargeImageIndex = 41;
            this.cmEdit.Name = "cmEdit";
            this.cmEdit.Text = "编辑";
            this.cmEdit.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmEdit_Click);
            // 
            // cmDelete
            // 
            this.cmDelete.ImageIndex = 42;
            this.cmDelete.Key = "cmDelete";
            this.cmDelete.LargeImageIndex = 42;
            this.cmDelete.Name = "cmDelete";
            this.cmDelete.Text = "删除";
            this.cmDelete.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmDelete_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.ImageIndex = 6;
            this.cmdRefresh.Key = "cmdRefresh";
            this.cmdRefresh.LargeImageIndex = 6;
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Text = "刷新";
            this.cmdRefresh.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdRefresh_Click);
            // 
            // cmdExport
            // 
            this.cmdExport.ImageIndex = 79;
            this.cmdExport.Key = "cmdExport";
            this.cmdExport.LargeImageIndex = 79;
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Text = "导出";
            this.cmdExport.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdExport_Click);
            // 
            // cmdImport
            // 
            this.cmdImport.ImageIndex = 80;
            this.cmdImport.Key = "cmdImport";
            this.cmdImport.LargeImageIndex = 80;
            this.cmdImport.Name = "cmdImport";
            this.cmdImport.Text = "导入";
            this.cmdImport.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdImport_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.ImageIndex = 122;
            this.cmdExit.Key = "cmdExit";
            this.cmdExit.LargeImageIndex = 122;
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Text = "退出";
            this.cmdExit.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdExit_Click);
            // 
            // cmdQuery
            // 
            this.cmdQuery.ImageIndex = 118;
            this.cmdQuery.Key = "cmdQuery";
            this.cmdQuery.LargeImageIndex = 118;
            this.cmdQuery.Name = "cmdQuery";
            this.cmdQuery.Text = "查询";
            this.cmdQuery.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdQuery_Click);
            // 
            // cmdPrint
            // 
            this.cmdPrint.ImageIndex = 84;
            this.cmdPrint.Key = "cmdPrint";
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Text = "打印";
            this.cmdPrint.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdPrint_Click);
            // 
            // cmdSend
            // 
            this.cmdSend.ImageIndex = 91;
            this.cmdSend.Key = "cmdSend";
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Text = "发布";
            this.cmdSend.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdSend_Click);
            // 
            // cmdFile
            // 
            this.cmdFile.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdViewFile1,
            this.cmdUploadFile1,
            this.cmdDownload1});
            this.cmdFile.ImageIndex = 89;
            this.cmdFile.Key = "cmdFile";
            this.cmdFile.Name = "cmdFile";
            this.cmdFile.Text = "附件";
            // 
            // cmdViewFile1
            // 
            this.cmdViewFile1.Key = "cmdViewFile";
            this.cmdViewFile1.Name = "cmdViewFile1";
            // 
            // cmdUploadFile1
            // 
            this.cmdUploadFile1.Key = "cmdUploadFile";
            this.cmdUploadFile1.Name = "cmdUploadFile1";
            // 
            // cmdDownload1
            // 
            this.cmdDownload1.Key = "cmdDownload";
            this.cmdDownload1.Name = "cmdDownload1";
            // 
            // cmdViewFile
            // 
            this.cmdViewFile.ImageIndex = 48;
            this.cmdViewFile.Key = "cmdViewFile";
            this.cmdViewFile.Name = "cmdViewFile";
            this.cmdViewFile.Text = "查看";
            // 
            // cmdUploadFile
            // 
            this.cmdUploadFile.ImageIndex = 79;
            this.cmdUploadFile.Key = "cmdUploadFile";
            this.cmdUploadFile.Name = "cmdUploadFile";
            this.cmdUploadFile.Text = "上传";
            // 
            // cmdDownload
            // 
            this.cmdDownload.ImageIndex = 80;
            this.cmdDownload.Key = "cmdDownload";
            this.cmdDownload.Name = "cmdDownload";
            this.cmdDownload.Text = "下载";
            // 
            // cmdCommit
            // 
            this.cmdCommit.ImageIndex = 98;
            this.cmdCommit.Key = "cmdCommit";
            this.cmdCommit.Name = "cmdCommit";
            this.cmdCommit.Text = "提交";
            this.cmdCommit.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdCommit_Click);
            // 
            // cmdRollback
            // 
            this.cmdRollback.ImageIndex = 99;
            this.cmdRollback.Key = "cmdRollback";
            this.cmdRollback.Name = "cmdRollback";
            this.cmdRollback.Text = "收回";
            this.cmdRollback.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdRollback_Click);
            // 
            // cmdCheck
            // 
            this.cmdCheck.ImageIndex = 80;
            this.cmdCheck.Key = "cmdCheck";
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Text = "审核";
            this.cmdCheck.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdCheck_Click);
            // 
            // cmdBackCheck
            // 
            this.cmdBackCheck.ImageIndex = 79;
            this.cmdBackCheck.Key = "cmdBackCheck";
            this.cmdBackCheck.Name = "cmdBackCheck";
            this.cmdBackCheck.Text = "弃审";
            this.cmdBackCheck.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdBackCheck_Click);
            // 
            // cmdBackSend
            // 
            this.cmdBackSend.ImageIndex = 48;
            this.cmdBackSend.Key = "cmdBackSend";
            this.cmdBackSend.Name = "cmdBackSend";
            this.cmdBackSend.Text = "撤销";
            this.cmdBackSend.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdBackSend_Click);
            // 
            // cmdViewWorkFlow
            // 
            this.cmdViewWorkFlow.ImageIndex = 36;
            this.cmdViewWorkFlow.Key = "cmdViewWorkFlow";
            this.cmdViewWorkFlow.Name = "cmdViewWorkFlow";
            this.cmdViewWorkFlow.Text = "流程";
            // 
            // cmdFeedback
            // 
            this.cmdFeedback.ImageIndex = 4;
            this.cmdFeedback.Key = "cmdFeedback";
            this.cmdFeedback.Name = "cmdFeedback";
            this.cmdFeedback.Text = "反馈";
            // 
            // cmdBackFeedback
            // 
            this.cmdBackFeedback.ImageIndex = 107;
            this.cmdBackFeedback.Key = "cmdBackFeedback";
            this.cmdBackFeedback.Name = "cmdBackFeedback";
            this.cmdBackFeedback.Text = "撤回";
            // 
            // cmdPreview
            // 
            this.cmdPreview.ImageIndex = 48;
            this.cmdPreview.Key = "cmdPreview";
            this.cmdPreview.Name = "cmdPreview";
            this.cmdPreview.Text = "预览";
            // 
            // cmRight
            // 
            this.cmRight.CommandManager = this.xCommandManager1;
            this.cmRight.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cdAddNew1,
            this.cmEdit1,
            this.cmDelete1,
            this.Separator1,
            this.cmdPrint2,
            this.Separator10,
            this.cmdRefresh1,
            this.Separator2,
            this.cmdSend1,
            this.cmdBackSend1,
            this.Separator9,
            this.cmdFeedback1,
            this.cmdBackFeedback1,
            this.Separator7,
            this.cmdCommit1,
            this.cmdRollback1,
            this.cmdViewWorkFlow1,
            this.Separator12,
            this.cmdImport1,
            this.cmdExport1,
            this.Separator11,
            this.cmdFile1,
            this.cmdDownload2,
            this.Separator3,
            this.cmdPreview1,
            this.Separator13,
            this.cmdExit1});
            this.cmRight.Key = "cmRight";
            this.cmRight.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // cdAddNew1
            // 
            this.cdAddNew1.Key = "cdAddNew";
            this.cdAddNew1.Name = "cdAddNew1";
            // 
            // cmEdit1
            // 
            this.cmEdit1.Key = "cmEdit";
            this.cmEdit1.Name = "cmEdit1";
            // 
            // cmDelete1
            // 
            this.cmDelete1.Key = "cmDelete";
            this.cmDelete1.Name = "cmDelete1";
            // 
            // Separator1
            // 
            this.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator1.Key = "Separator";
            this.Separator1.Name = "Separator1";
            // 
            // cmdPrint2
            // 
            this.cmdPrint2.Key = "cmdPrint";
            this.cmdPrint2.Name = "cmdPrint2";
            // 
            // Separator10
            // 
            this.Separator10.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator10.Key = "Separator";
            this.Separator10.Name = "Separator10";
            // 
            // cmdRefresh1
            // 
            this.cmdRefresh1.Key = "cmdRefresh";
            this.cmdRefresh1.Name = "cmdRefresh1";
            // 
            // Separator2
            // 
            this.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator2.Key = "Separator";
            this.Separator2.Name = "Separator2";
            // 
            // cmdSend1
            // 
            this.cmdSend1.Key = "cmdSend";
            this.cmdSend1.Name = "cmdSend1";
            // 
            // cmdBackSend1
            // 
            this.cmdBackSend1.Key = "cmdBackSend";
            this.cmdBackSend1.Name = "cmdBackSend1";
            // 
            // Separator9
            // 
            this.Separator9.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator9.Key = "Separator";
            this.Separator9.Name = "Separator9";
            // 
            // cmdFeedback1
            // 
            this.cmdFeedback1.Key = "cmdFeedback";
            this.cmdFeedback1.Name = "cmdFeedback1";
            // 
            // cmdBackFeedback1
            // 
            this.cmdBackFeedback1.Key = "cmdBackFeedback";
            this.cmdBackFeedback1.Name = "cmdBackFeedback1";
            // 
            // Separator7
            // 
            this.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator7.Key = "Separator";
            this.Separator7.Name = "Separator7";
            // 
            // cmdCommit1
            // 
            this.cmdCommit1.Key = "cmdCommit";
            this.cmdCommit1.Name = "cmdCommit1";
            // 
            // cmdRollback1
            // 
            this.cmdRollback1.Key = "cmdRollback";
            this.cmdRollback1.Name = "cmdRollback1";
            // 
            // cmdViewWorkFlow1
            // 
            this.cmdViewWorkFlow1.Key = "cmdViewWorkFlow";
            this.cmdViewWorkFlow1.Name = "cmdViewWorkFlow1";
            // 
            // Separator12
            // 
            this.Separator12.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator12.Key = "Separator";
            this.Separator12.Name = "Separator12";
            // 
            // cmdImport1
            // 
            this.cmdImport1.Key = "cmdImport";
            this.cmdImport1.Name = "cmdImport1";
            // 
            // cmdExport1
            // 
            this.cmdExport1.Key = "cmdExport";
            this.cmdExport1.Name = "cmdExport1";
            // 
            // Separator11
            // 
            this.Separator11.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator11.Key = "Separator";
            this.Separator11.Name = "Separator11";
            // 
            // cmdFile1
            // 
            this.cmdFile1.Key = "cmdFile";
            this.cmdFile1.Name = "cmdFile1";
            // 
            // cmdDownload2
            // 
            this.cmdDownload2.Key = "cmdDownload";
            this.cmdDownload2.Name = "cmdDownload2";
            // 
            // Separator3
            // 
            this.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator3.Key = "Separator";
            this.Separator3.Name = "Separator3";
            // 
            // cmdPreview1
            // 
            this.cmdPreview1.Key = "cmdPreview";
            this.cmdPreview1.Name = "cmdPreview1";
            // 
            // Separator13
            // 
            this.Separator13.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator13.Key = "Separator";
            this.Separator13.Name = "Separator13";
            // 
            // cmdExit1
            // 
            this.cmdExit1.Key = "cmdExit";
            this.cmdExit1.Name = "cmdExit1";
            // 
            // cmCheck
            // 
            this.cmCheck.CommandManager = this.xCommandManager1;
            this.cmCheck.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdCheck3,
            this.cmdBackCheck3});
            this.cmCheck.Key = "cmCheck";
            // 
            // cmdCheck3
            // 
            this.cmdCheck3.Key = "cmdCheck";
            this.cmdCheck3.Name = "cmdCheck3";
            // 
            // cmdBackCheck3
            // 
            this.cmdBackCheck3.Key = "cmdBackCheck";
            this.cmdBackCheck3.Name = "cmdBackCheck3";
            // 
            // LeftRebar1
            // 
            this.LeftRebar1.CommandManager = this.xCommandManager1;
            this.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftRebar1.Location = new System.Drawing.Point(0, 0);
            this.LeftRebar1.Name = "LeftRebar1";
            this.LeftRebar1.Size = new System.Drawing.Size(0, 569);
            // 
            // RightRebar1
            // 
            this.RightRebar1.CommandManager = this.xCommandManager1;
            this.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightRebar1.Location = new System.Drawing.Point(824, 0);
            this.RightRebar1.Name = "RightRebar1";
            this.RightRebar1.Size = new System.Drawing.Size(0, 569);
            // 
            // cdAddNew2
            // 
            this.cdAddNew2.Key = "cdAddNew";
            this.cdAddNew2.Name = "cdAddNew2";
            // 
            // cmEdit2
            // 
            this.cmEdit2.Key = "cmEdit";
            this.cmEdit2.Name = "cmEdit2";
            // 
            // cmDelete2
            // 
            this.cmDelete2.Key = "cmDelete";
            this.cmDelete2.Name = "cmDelete2";
            // 
            // Separator4
            // 
            this.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator4.Key = "Separator";
            this.Separator4.Name = "Separator4";
            // 
            // cmdRefresh2
            // 
            this.cmdRefresh2.Key = "cmdRefresh";
            this.cmdRefresh2.Name = "cmdRefresh2";
            // 
            // Separator5
            // 
            this.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator5.Key = "Separator";
            this.Separator5.Name = "Separator5";
            // 
            // cmdPrint1
            // 
            this.cmdPrint1.ImageIndex = 84;
            this.cmdPrint1.Key = "cmdPrint";
            this.cmdPrint1.Name = "cmdPrint1";
            // 
            // Separator8
            // 
            this.Separator8.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator8.Key = "Separator";
            this.Separator8.Name = "Separator8";
            // 
            // cmdImport2
            // 
            this.cmdImport2.Enabled = Janus.Windows.UI.InheritableBoolean.True;
            this.cmdImport2.Key = "cmdImport";
            this.cmdImport2.Name = "cmdImport2";
            // 
            // cmdExport2
            // 
            this.cmdExport2.Enabled = Janus.Windows.UI.InheritableBoolean.True;
            this.cmdExport2.Key = "cmdExport";
            this.cmdExport2.Name = "cmdExport2";
            // 
            // Separator6
            // 
            this.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator6.Key = "Separator";
            this.Separator6.Name = "Separator6";
            // 
            // cmdExit2
            // 
            this.cmdExit2.Key = "cmdExit";
            this.cmdExit2.Name = "cmdExit2";
            // 
            // cmdCheck1
            // 
            this.cmdCheck1.Key = "cmdCheck";
            this.cmdCheck1.Name = "cmdCheck1";
            // 
            // cmdBackCheck1
            // 
            this.cmdBackCheck1.Key = "cmdBackCheck";
            this.cmdBackCheck1.Name = "cmdBackCheck1";
            // 
            // grdExporter
            // 
            this.grdExporter.ExportMode = Janus.Windows.GridEX.ExportMode.CheckedRows;
            this.grdExporter.GridEX = this.grdData;
            // 
            // grdPrinter
            // 
            this.grdPrinter.GridEX = this.grdData;
            // 
            // tmRefresh
            // 
            this.tmRefresh.Tick += new System.EventHandler(this.tmRefresh_Tick);
            // 
            // frmListBase
            // 
            this.ClientSize = new System.Drawing.Size(623, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopRebar1);
            this.Name = "frmListBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmListBase_FormClosing);
            this.Load += new System.EventHandler(this.frmListBase_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpQuery)).EndInit();
            this.grpQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).EndInit();
            this.ResumeLayout(false);

        }

        

    
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private Janus.Windows.UI.CommandBars.UIRebar BottomRebar1;
        private Janus.Windows.UI.CommandBars.UICommand cmdRefresh;
        private Janus.Windows.UI.CommandBars.UICommand cmdImport;
        private Janus.Windows.UI.CommandBars.UICommand cmdExit;
        private Janus.Windows.UI.CommandBars.UIRebar LeftRebar1;
        private Janus.Windows.UI.CommandBars.UIRebar RightRebar1;
        private Janus.Windows.UI.CommandBars.UIRebar TopRebar1;
        private Janus.Windows.UI.CommandBars.UICommand cdAddNew1;
        private Janus.Windows.UI.CommandBars.UICommand cmEdit1;
        private Janus.Windows.UI.CommandBars.UICommand cmDelete1;
        private Janus.Windows.UI.CommandBars.UICommand Separator1;
        private Janus.Windows.UI.CommandBars.UICommand cmdRefresh1;
        private Janus.Windows.UI.CommandBars.UICommand Separator2;
        private Janus.Windows.UI.CommandBars.UICommand cmdExit1;
        protected MMIS.Component.XGridEx grdData;
        protected MMIS.Component.XGroupBox grpQuery;
        private Janus.Windows.UI.CommandBars.UICommand cdAddNew2;
        private Janus.Windows.UI.CommandBars.UICommand cmEdit2;
        private Janus.Windows.UI.CommandBars.UICommand cmDelete2;
        private Janus.Windows.UI.CommandBars.UICommand cmdRefresh2;
        private Janus.Windows.UI.CommandBars.UICommand cmdExit2;
        private Janus.Windows.UI.CommandBars.UICommand cmdImport1;
        private Janus.Windows.UI.CommandBars.UICommand cmdExport1;
        private Janus.Windows.UI.CommandBars.UICommand Separator3;
        private Janus.Windows.UI.CommandBars.UICommand Separator4;
        private Janus.Windows.UI.CommandBars.UICommand Separator5;
        private Janus.Windows.UI.CommandBars.UICommand cmdImport2;
        private Janus.Windows.UI.CommandBars.UICommand cmdExport2;
        private Janus.Windows.UI.CommandBars.UICommand Separator6;
        protected MMIS.Component.XButton btnQuery;
        protected MMIS.Component.XCommandManager xCommandManager1;
        protected Janus.Windows.UI.CommandBars.UIContextMenu cmRight;
        protected System.Windows.Forms.Panel panel2;
        public Janus.Windows.UI.CommandBars.UICommandBar ListToolBar;
        public Janus.Windows.UI.CommandBars.UICommand cdAddNew;
        public Janus.Windows.UI.CommandBars.UICommand cmEdit;
        public Janus.Windows.UI.CommandBars.UICommand cmDelete;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Panel panel7;
        protected System.Windows.Forms.Panel panel8;
        private Janus.Windows.UI.CommandBars.UICommand cmdQuery;
        private Janus.Windows.GridEX.Export.GridEXExporter grdExporter;
        private Janus.Windows.GridEX.GridEXPrintDocument grdPrinter;
        private Janus.Windows.UI.CommandBars.UICommand cmdPrint1;
        private Janus.Windows.UI.CommandBars.UICommand Separator8;
        protected System.Windows.Forms.ImageList imageList;
        private Janus.Windows.UI.CommandBars.UICommand cmdSend;
        private Janus.Windows.UI.CommandBars.UICommand cmdSend1;
        private Janus.Windows.UI.CommandBars.UICommand Separator9;
        private Janus.Windows.UI.CommandBars.UICommand cmdPrint2;
        private Janus.Windows.UI.CommandBars.UICommand Separator10;
        private Janus.Windows.UI.CommandBars.UICommand cmdFile;
        private Janus.Windows.UI.CommandBars.UICommand cmdViewFile1;
        private Janus.Windows.UI.CommandBars.UICommand cmdUploadFile1;
        private Janus.Windows.UI.CommandBars.UICommand cmdViewFile;
        private Janus.Windows.UI.CommandBars.UICommand cmdUploadFile;
        private Janus.Windows.UI.CommandBars.UICommand Separator11;
        private Janus.Windows.UI.CommandBars.UICommand cmdFile1;
        private Janus.Windows.UI.CommandBars.UICommand cmdDownload1;
        private Janus.Windows.UI.CommandBars.UICommand cmdCommit;
        private Janus.Windows.UI.CommandBars.UICommand cmdRollback;
        private Janus.Windows.UI.CommandBars.UICommand cmdCommit1;
        private Janus.Windows.UI.CommandBars.UICommand cmdRollback1;
        private Janus.Windows.UI.CommandBars.UICommand Separator12;
        private Janus.Windows.UI.CommandBars.UICommand cmdCheck;
        private Janus.Windows.UI.CommandBars.UICommand cmdBackCheck;
        private Janus.Windows.UI.CommandBars.UICommand cmdCheck1;
        private Janus.Windows.UI.CommandBars.UICommand cmdBackCheck1;
        private Janus.Windows.UI.CommandBars.UIContextMenu cmCheck;
        private Janus.Windows.UI.CommandBars.UICommand cmdCheck3;
        private Janus.Windows.UI.CommandBars.UICommand cmdBackCheck3;
        protected Component.XQueryCheckBox chkChecked;
        private Janus.Windows.UI.CommandBars.UICommand cmdBackSend;
        private Janus.Windows.UI.CommandBars.UICommand cmdBackSend1;
        private Janus.Windows.UI.CommandBars.UICommand cmdViewWorkFlow;
        private Janus.Windows.UI.CommandBars.UICommand cmdViewWorkFlow1;
        public Janus.Windows.UI.CommandBars.UICommand cmdFeedback;
        public Janus.Windows.UI.CommandBars.UICommand cmdBackFeedback;
        private Janus.Windows.UI.CommandBars.UICommand cmdFeedback1;
        private Janus.Windows.UI.CommandBars.UICommand cmdBackFeedback1;
        private Janus.Windows.UI.CommandBars.UICommand Separator7;
        private Janus.Windows.UI.CommandBars.UICommand cmdDownload2;
        public Janus.Windows.UI.CommandBars.UICommand cmdExport;
        public Janus.Windows.UI.CommandBars.UICommand cmdPrint;
        private Janus.Windows.UI.CommandBars.UICommand cmdPreview;
        private Janus.Windows.UI.CommandBars.UICommand cmdPreview1;
        private Janus.Windows.UI.CommandBars.UICommand Separator13;
        protected Janus.Windows.UI.CommandBars.UICommand cmdDownload;
        protected System.Windows.Forms.Timer tmRefresh;
    }
}
