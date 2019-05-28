namespace MMIS.UI.Common
{
    partial class frmTreeListEditBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeListEditBase));
            this.pnlTree = new System.Windows.Forms.Panel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.txtParentNode = new MMIS.Component.XEditBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRootNode = new MMIS.Component.XCheckBox();
            this.btnSave = new MMIS.Component.XButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.xCommandManager1 = new MMIS.Component.XCommandManager();
            this.BottomRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.uiCommandBar1 = new Janus.Windows.UI.CommandBars.UICommandBar();
            this.cdAddNew1 = new Janus.Windows.UI.CommandBars.UICommand("cdAddNew");
            this.cmEdit1 = new Janus.Windows.UI.CommandBars.UICommand("cmEdit");
            this.cmDelete1 = new Janus.Windows.UI.CommandBars.UICommand("cmDelete");
            this.Separator1 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdRefresh1 = new Janus.Windows.UI.CommandBars.UICommand("cmdRefresh");
            this.Separator2 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdQuery1 = new Janus.Windows.UI.CommandBars.UICommand("cmdQuery");
            this.Separator3 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdImport1 = new Janus.Windows.UI.CommandBars.UICommand("cmdImport");
            this.cmdExport1 = new Janus.Windows.UI.CommandBars.UICommand("cmdExport");
            this.Separator5 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdExit1 = new Janus.Windows.UI.CommandBars.UICommand("cmdExit");
            this.cdAddNew = new Janus.Windows.UI.CommandBars.UICommand("cdAddNew");
            this.cmEdit = new Janus.Windows.UI.CommandBars.UICommand("cmEdit");
            this.cmDelete = new Janus.Windows.UI.CommandBars.UICommand("cmDelete");
            this.cmdRefresh = new Janus.Windows.UI.CommandBars.UICommand("cmdRefresh");
            this.cmdExport = new Janus.Windows.UI.CommandBars.UICommand("cmdExport");
            this.cmdImport = new Janus.Windows.UI.CommandBars.UICommand("cmdImport");
            this.cmdExit = new Janus.Windows.UI.CommandBars.UICommand("cmdExit");
            this.cmdQuery = new Janus.Windows.UI.CommandBars.UICommand("cmdQuery");
            this.cmdPrint = new Janus.Windows.UI.CommandBars.UICommand("cmdPrint");
            this.cmRight = new Janus.Windows.UI.CommandBars.UIContextMenu();
            this.cdAddNew2 = new Janus.Windows.UI.CommandBars.UICommand("cdAddNew");
            this.cmEdit2 = new Janus.Windows.UI.CommandBars.UICommand("cmEdit");
            this.cmDelete2 = new Janus.Windows.UI.CommandBars.UICommand("cmDelete");
            this.Separator6 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdRefresh2 = new Janus.Windows.UI.CommandBars.UICommand("cmdRefresh");
            this.Separator7 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdImport2 = new Janus.Windows.UI.CommandBars.UICommand("cmdImport");
            this.cmdExport2 = new Janus.Windows.UI.CommandBars.UICommand("cmdExport");
            this.Separator8 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
            this.cmdExit2 = new Janus.Windows.UI.CommandBars.UICommand("cmdExit");
            this.LeftRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.RightRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.TopRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.pnlTree.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).BeginInit();
            this.TopRebar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTree
            // 
            this.pnlTree.Controls.Add(this.treeView);
            this.pnlTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTree.Location = new System.Drawing.Point(0, 28);
            this.pnlTree.Name = "pnlTree";
            this.pnlTree.Size = new System.Drawing.Size(412, 382);
            this.pnlTree.TabIndex = 0;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(412, 382);
            this.treeView.TabIndex = 0;
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeExpand);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(412, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 382);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlEdit
            // 
            this.pnlEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEdit.Controls.Add(this.txtParentNode);
            this.pnlEdit.Controls.Add(this.label1);
            this.pnlEdit.Controls.Add(this.chkRootNode);
            this.pnlEdit.Controls.Add(this.btnSave);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEdit.Location = new System.Drawing.Point(415, 28);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(199, 382);
            this.pnlEdit.TabIndex = 2;
            // 
            // txtParentNode
            // 
            this.txtParentNode.IsAllowEmpty = true;
            this.txtParentNode.Location = new System.Drawing.Point(75, 38);
            this.txtParentNode.Name = "txtParentNode";
            this.txtParentNode.ReadOnly = true;
            this.txtParentNode.Size = new System.Drawing.Size(111, 23);
            this.txtParentNode.TabIndex = 3;
            this.txtParentNode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "上级节点";
            // 
            // chkRootNode
            // 
            this.chkRootNode.Enabled = false;
            this.chkRootNode.Location = new System.Drawing.Point(16, 10);
            this.chkRootNode.Model = null;
            this.chkRootNode.Name = "chkRootNode";
            this.chkRootNode.Size = new System.Drawing.Size(71, 23);
            this.chkRootNode.TabIndex = 1;
            this.chkRootNode.Text = "根节点";
            this.chkRootNode.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.chkRootNode.CheckedChanged += new System.EventHandler(this.chkRootNode_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.ImageIndex = 113;
            this.btnSave.ImageList = this.imageList;
            this.btnSave.Location = new System.Drawing.Point(16, 111);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 26);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // xCommandManager1
            // 
            this.xCommandManager1.BottomRebar = this.BottomRebar1;
            this.xCommandManager1.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.uiCommandBar1});
            this.xCommandManager1.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cdAddNew,
            this.cmEdit,
            this.cmDelete,
            this.cmdRefresh,
            this.cmdExport,
            this.cmdImport,
            this.cmdExit,
            this.cmdQuery,
            this.cmdPrint});
            this.xCommandManager1.ContainerControl = this;
            this.xCommandManager1.ContextMenus.AddRange(new Janus.Windows.UI.CommandBars.UIContextMenu[] {
            this.cmRight});
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
            this.BottomRebar1.Location = new System.Drawing.Point(0, 0);
            this.BottomRebar1.Name = "BottomRebar1";
            this.BottomRebar1.Size = new System.Drawing.Size(0, 0);
            this.BottomRebar1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // uiCommandBar1
            // 
            this.uiCommandBar1.AllowClose = Janus.Windows.UI.InheritableBoolean.False;
            this.uiCommandBar1.AllowCustomize = Janus.Windows.UI.InheritableBoolean.False;
            this.uiCommandBar1.AllowMerge = Janus.Windows.UI.InheritableBoolean.True;
            this.uiCommandBar1.CommandManager = this.xCommandManager1;
            this.uiCommandBar1.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cdAddNew1,
            this.cmEdit1,
            this.cmDelete1,
            this.Separator1,
            this.cmdRefresh1,
            this.Separator2,
            this.cmdQuery1,
            this.Separator3,
            this.cmdImport1,
            this.cmdExport1,
            this.Separator5,
            this.cmdExit1});
            this.uiCommandBar1.Key = "ListToolBar";
            this.uiCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.uiCommandBar1.Name = "uiCommandBar1";
            this.uiCommandBar1.RowIndex = 0;
            this.uiCommandBar1.ShowCustomizeButton = Janus.Windows.UI.InheritableBoolean.False;
            this.uiCommandBar1.Size = new System.Drawing.Size(506, 28);
            this.uiCommandBar1.Text = "ListToolBar";
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
            // cmdQuery1
            // 
            this.cmdQuery1.Key = "cmdQuery";
            this.cmdQuery1.Name = "cmdQuery1";
            // 
            // Separator3
            // 
            this.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator3.Key = "Separator";
            this.Separator3.Name = "Separator3";
            // 
            // cmdImport1
            // 
            this.cmdImport1.Enabled = Janus.Windows.UI.InheritableBoolean.True;
            this.cmdImport1.Key = "cmdImport";
            this.cmdImport1.Name = "cmdImport1";
            // 
            // cmdExport1
            // 
            this.cmdExport1.Enabled = Janus.Windows.UI.InheritableBoolean.True;
            this.cmdExport1.Key = "cmdExport";
            this.cmdExport1.Name = "cmdExport1";
            // 
            // Separator5
            // 
            this.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator5.Key = "Separator";
            this.Separator5.Name = "Separator5";
            // 
            // cmdExit1
            // 
            this.cmdExit1.Key = "cmdExit";
            this.cmdExit1.Name = "cmdExit1";
            // 
            // cdAddNew
            // 
            this.cdAddNew.ImageIndex = 120;
            this.cdAddNew.Key = "cdAddNew";
            this.cdAddNew.LargeImageIndex = 120;
            this.cdAddNew.Name = "cdAddNew";
            this.cdAddNew.Text = "添加";
            this.cdAddNew.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdAddNew_Click);
            // 
            // cmEdit
            // 
            this.cmEdit.ImageIndex = 41;
            this.cmEdit.Key = "cmEdit";
            this.cmEdit.LargeImageIndex = 41;
            this.cmEdit.Name = "cmEdit";
            this.cmEdit.Text = "编辑";
            this.cmEdit.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.cmdEdit_Click);
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
            // 
            // cmdImport
            // 
            this.cmdImport.ImageIndex = 80;
            this.cmdImport.Key = "cmdImport";
            this.cmdImport.LargeImageIndex = 80;
            this.cmdImport.Name = "cmdImport";
            this.cmdImport.Text = "导入";
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
            // 
            // cmdPrint
            // 
            this.cmdPrint.Key = "cmdPrint";
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Text = "打印";
            // 
            // cmRight
            // 
            this.cmRight.CommandManager = this.xCommandManager1;
            this.cmRight.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cdAddNew2,
            this.cmEdit2,
            this.cmDelete2,
            this.Separator6,
            this.cmdRefresh2,
            this.Separator7,
            this.cmdImport2,
            this.cmdExport2,
            this.Separator8,
            this.cmdExit2});
            this.cmRight.Key = "cmRight";
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
            // Separator6
            // 
            this.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator6.Key = "Separator";
            this.Separator6.Name = "Separator6";
            // 
            // cmdRefresh2
            // 
            this.cmdRefresh2.Key = "cmdRefresh";
            this.cmdRefresh2.Name = "cmdRefresh2";
            // 
            // Separator7
            // 
            this.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator7.Key = "Separator";
            this.Separator7.Name = "Separator7";
            // 
            // cmdImport2
            // 
            this.cmdImport2.Key = "cmdImport";
            this.cmdImport2.Name = "cmdImport2";
            // 
            // cmdExport2
            // 
            this.cmdExport2.Key = "cmdExport";
            this.cmdExport2.Name = "cmdExport2";
            // 
            // Separator8
            // 
            this.Separator8.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
            this.Separator8.Key = "Separator";
            this.Separator8.Name = "Separator8";
            // 
            // cmdExit2
            // 
            this.cmdExit2.Key = "cmdExit";
            this.cmdExit2.Name = "cmdExit2";
            // 
            // LeftRebar1
            // 
            this.LeftRebar1.CommandManager = this.xCommandManager1;
            this.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftRebar1.Location = new System.Drawing.Point(0, 0);
            this.LeftRebar1.Name = "LeftRebar1";
            this.LeftRebar1.Size = new System.Drawing.Size(0, 0);
            // 
            // RightRebar1
            // 
            this.RightRebar1.CommandManager = this.xCommandManager1;
            this.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightRebar1.Location = new System.Drawing.Point(0, 0);
            this.RightRebar1.Name = "RightRebar1";
            this.RightRebar1.Size = new System.Drawing.Size(0, 0);
            // 
            // TopRebar1
            // 
            this.TopRebar1.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.uiCommandBar1});
            this.TopRebar1.CommandManager = this.xCommandManager1;
            this.TopRebar1.Controls.Add(this.uiCommandBar1);
            this.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopRebar1.Location = new System.Drawing.Point(0, 0);
            this.TopRebar1.Name = "TopRebar1";
            this.TopRebar1.Size = new System.Drawing.Size(614, 28);
            this.TopRebar1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // frmTreeListEditBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 410);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlTree);
            this.Controls.Add(this.TopRebar1);
            this.Name = "frmTreeListEditBase";
            this.Text = "frmTreeEditBase";
            this.pnlTree.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.TopRebar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       
        #endregion

        private System.Windows.Forms.Panel pnlTree;
        private System.Windows.Forms.Splitter splitter1;
        protected Component.XCommandManager xCommandManager1;
        private Janus.Windows.UI.CommandBars.UIRebar BottomRebar1;
        private Janus.Windows.UI.CommandBars.UICommandBar uiCommandBar1;
        private Janus.Windows.UI.CommandBars.UICommand cdAddNew1;
        private Janus.Windows.UI.CommandBars.UICommand cmEdit1;
        private Janus.Windows.UI.CommandBars.UICommand cmDelete1;
        private Janus.Windows.UI.CommandBars.UICommand Separator1;
        private Janus.Windows.UI.CommandBars.UICommand cmdRefresh1;
        private Janus.Windows.UI.CommandBars.UICommand Separator2;
        private Janus.Windows.UI.CommandBars.UICommand cmdQuery1;
        private Janus.Windows.UI.CommandBars.UICommand Separator3;
        private Janus.Windows.UI.CommandBars.UICommand cmdImport1;
        private Janus.Windows.UI.CommandBars.UICommand cmdExport1;
        private Janus.Windows.UI.CommandBars.UICommand Separator5;
        private Janus.Windows.UI.CommandBars.UICommand cmdExit1;
        private Janus.Windows.UI.CommandBars.UICommand cmdAddNew;
        private Janus.Windows.UI.CommandBars.UICommand cmdEdit;
        private Janus.Windows.UI.CommandBars.UICommand cmDelete;
        private Janus.Windows.UI.CommandBars.UICommand cmdRefresh;
        private Janus.Windows.UI.CommandBars.UICommand cmdExport;
        private Janus.Windows.UI.CommandBars.UICommand cmdImport;
        private Janus.Windows.UI.CommandBars.UICommand cmdExit;
        private Janus.Windows.UI.CommandBars.UICommand cmdQuery;
        private Janus.Windows.UI.CommandBars.UICommand cmdPrint;
        private Janus.Windows.UI.CommandBars.UIRebar TopRebar1;
        protected Janus.Windows.UI.CommandBars.UIContextMenu cmRight;
        private Janus.Windows.UI.CommandBars.UICommand cdAddNew2;
        private Janus.Windows.UI.CommandBars.UICommand cmEdit2;
        private Janus.Windows.UI.CommandBars.UICommand cmDelete2;
        private Janus.Windows.UI.CommandBars.UICommand Separator6;
        private Janus.Windows.UI.CommandBars.UICommand cmdRefresh2;
        private Janus.Windows.UI.CommandBars.UICommand Separator7;
        private Janus.Windows.UI.CommandBars.UICommand cmdImport2;
        private Janus.Windows.UI.CommandBars.UICommand cmdExport2;
        private Janus.Windows.UI.CommandBars.UICommand Separator8;
        private Janus.Windows.UI.CommandBars.UICommand cmdExit2;
        private Janus.Windows.UI.CommandBars.UIRebar LeftRebar1;
        private Janus.Windows.UI.CommandBars.UIRebar RightRebar1;
        protected Component.XButton btnSave;
        protected System.Windows.Forms.Panel pnlEdit;
        protected System.Windows.Forms.TreeView treeView;
        private Janus.Windows.UI.CommandBars.UICommand cdAddNew;
        private Janus.Windows.UI.CommandBars.UICommand cmEdit;
        private System.Windows.Forms.ImageList imageList;
        protected Component.XCheckBox chkRootNode;
        protected System.Windows.Forms.Label label1;
        protected Component.XEditBox txtParentNode;
    }
}