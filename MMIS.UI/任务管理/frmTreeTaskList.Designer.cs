namespace MMIS.UI
{
    partial class frmTreeTaskList
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
            Janus.Windows.GridEX.GridEXLayout grdFiles_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeTaskList));
            Janus.Windows.GridEX.GridEXLayout grdTaskAttach_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem4 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem5 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem6 = new Janus.Windows.EditControls.UIComboBoxItem();
            this.pnlAll = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlRightFill = new System.Windows.Forms.Panel();
            this.grdFiles = new MMIS.Component.XGridEx();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlRightTop = new System.Windows.Forms.Panel();
            this.tabTask = new MMIS.Component.XTabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.xGroupBox2 = new MMIS.Component.XGroupBox();
            this.dtParentStartDate = new MMIS.Component.XDateTimePicker();
            this.dtParentPreEndDate = new MMIS.Component.XDateTimePicker();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.txtParentTaskNo = new MMIS.Component.XEditBox();
            this.xLabel3 = new MMIS.Component.XLabel();
            this.txtParentTask = new MMIS.Component.XEditBox();
            this.lblMainId = new MMIS.Component.XLabel();
            this.xGroupBox1 = new MMIS.Component.XGroupBox();
            this.txtShortDesc = new MMIS.Component.XEditBox();
            this.txtRequire = new MMIS.Component.XEditBox();
            this.txtContent = new MMIS.Component.XEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.lblShortDesc = new MMIS.Component.XLabel();
            this.lblRequire = new MMIS.Component.XLabel();
            this.lblContent = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtAssignPeople = new MMIS.Component.XEditBox();
            this.dtStartDate = new MMIS.Component.XDateTimePicker();
            this.dtPreEndDate = new MMIS.Component.XDateTimePicker();
            this.lblAssignPeople = new MMIS.Component.XLabel();
            this.lblStartDate = new MMIS.Component.XLabel();
            this.lblPreEndDate = new MMIS.Component.XLabel();
            this.dtDispatchDate = new MMIS.Component.XDateTimePicker();
            this.lblDispatchDate = new MMIS.Component.XLabel();
            this.txtStartPeople = new MMIS.Component.XEditBox();
            this.lblStartPeople = new MMIS.Component.XLabel();
            this.txtTaskNo = new MMIS.Component.XEditBox();
            this.lblTaskNo = new MMIS.Component.XLabel();
            this.txtTaskName = new MMIS.Component.XEditBox();
            this.lblTaskName = new MMIS.Component.XLabel();
            this.txtTaskTypeId = new MMIS.Component.XEditBox();
            this.lblTaskTypeId = new MMIS.Component.XLabel();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.txtFileName = new MMIS.Component.XEditBox();
            this.txtFileDesc = new MMIS.Component.XEditBox();
            this.txtFileRemark = new MMIS.Component.XEditBox();
            this.lblFileName = new MMIS.Component.XLabel();
            this.lblFileDesc = new MMIS.Component.XLabel();
            this.xLabel4 = new MMIS.Component.XLabel();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.grdTaskAttach = new MMIS.Component.XGridEx();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlTree = new System.Windows.Forms.Panel();
            this.tvTask = new System.Windows.Forms.TreeView();
            this.xCommandManager1 = new MMIS.Component.XCommandManager();
            this.BottomRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.cmdNewTask = new Janus.Windows.UI.CommandBars.UICommand("cmdNewTask");
            this.cmdEditTask = new Janus.Windows.UI.CommandBars.UICommand("cmdEditTask");
            this.cmdDeleteTask = new Janus.Windows.UI.CommandBars.UICommand("cmdDeleteTask");
            this.cmdFinishTask = new Janus.Windows.UI.CommandBars.UICommand("cmdFinishTask");
            this.cmdNewChildTask = new Janus.Windows.UI.CommandBars.UICommand("cmdNewChildTask");
            this.cmdRefreshTask = new Janus.Windows.UI.CommandBars.UICommand("cmdRefreshTask");
            this.cmdDownload = new Janus.Windows.UI.CommandBars.UICommand("cmdDownload");
            this.cmdPreview = new Janus.Windows.UI.CommandBars.UICommand("cmdPreview");
            this.cmdDownloadAttach = new Janus.Windows.UI.CommandBars.UICommand("cmdDownloadAttach");
            this.cmdPreviewAttach = new Janus.Windows.UI.CommandBars.UICommand("cmdPreviewAttach");
            this.cmTaskMenu = new Janus.Windows.UI.CommandBars.UIContextMenu();
            this.cmdNewTask1 = new Janus.Windows.UI.CommandBars.UICommand("cmdNewTask");
            this.cmdNewChildTask1 = new Janus.Windows.UI.CommandBars.UICommand("cmdNewChildTask");
            this.cmdEditTask1 = new Janus.Windows.UI.CommandBars.UICommand("cmdEditTask");
            this.cmdDeleteTask1 = new Janus.Windows.UI.CommandBars.UICommand("cmdDeleteTask");
            this.cmdFinishTask1 = new Janus.Windows.UI.CommandBars.UICommand("cmdFinishTask");
            this.cmdRefreshTask1 = new Janus.Windows.UI.CommandBars.UICommand("cmdRefreshTask");
            this.cmFile = new Janus.Windows.UI.CommandBars.UIContextMenu();
            this.cmdDownload1 = new Janus.Windows.UI.CommandBars.UICommand("cmdDownload");
            this.cmdPreview1 = new Janus.Windows.UI.CommandBars.UICommand("cmdPreview");
            this.cmTaskAttach = new Janus.Windows.UI.CommandBars.UIContextMenu();
            this.cmdDownloadAttach1 = new Janus.Windows.UI.CommandBars.UICommand("cmdDownloadAttach");
            this.cmdPreviewAttach1 = new Janus.Windows.UI.CommandBars.UICommand("cmdPreviewAttach");
            this.LeftRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.RightRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.TopRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
            this.pnlEnd = new System.Windows.Forms.Panel();
            this.pnlEndFill = new System.Windows.Forms.Panel();
            this.pnlEndTop = new System.Windows.Forms.Panel();
            this.xQueryCombobox1 = new MMIS.Component.XQueryCombobox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQuery = new MMIS.Component.XButton();
            this.xQueryEditBox4 = new MMIS.Component.XQueryEditBox();
            this.label5 = new System.Windows.Forms.Label();
            this.xQueryEditBox3 = new MMIS.Component.XQueryEditBox();
            this.label4 = new System.Windows.Forms.Label();
            this.xQueryDatePicker2 = new MMIS.Component.XQueryDatePicker();
            this.xQueryDatePicker1 = new MMIS.Component.XQueryDatePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.xQueryEditBox2 = new MMIS.Component.XQueryEditBox();
            this.xQueryEditBox1 = new MMIS.Component.XQueryEditBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmRefresh = new System.Windows.Forms.Timer(this.components);
            this.pnlAll.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlRightFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).BeginInit();
            this.pnlRightTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabTask)).BeginInit();
            this.tabTask.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox2)).BeginInit();
            this.xGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).BeginInit();
            this.xGroupBox1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskAttach)).BeginInit();
            this.pnlTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmTaskMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmTaskAttach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).BeginInit();
            this.pnlEnd.SuspendLayout();
            this.pnlEndFill.SuspendLayout();
            this.pnlEndTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAll
            // 
            this.pnlAll.Controls.Add(this.pnlRight);
            this.pnlAll.Controls.Add(this.splitter1);
            this.pnlAll.Controls.Add(this.pnlTree);
            this.pnlAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAll.Location = new System.Drawing.Point(0, 0);
            this.pnlAll.Name = "pnlAll";
            this.pnlAll.Size = new System.Drawing.Size(1130, 438);
            this.pnlAll.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlRightFill);
            this.pnlRight.Controls.Add(this.splitter2);
            this.pnlRight.Controls.Add(this.pnlRightTop);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(392, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(738, 438);
            this.pnlRight.TabIndex = 2;
            // 
            // pnlRightFill
            // 
            this.pnlRightFill.Controls.Add(this.grdFiles);
            this.pnlRightFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightFill.Location = new System.Drawing.Point(0, 385);
            this.pnlRightFill.Name = "pnlRightFill";
            this.pnlRightFill.Size = new System.Drawing.Size(738, 53);
            this.pnlRightFill.TabIndex = 2;
            // 
            // grdFiles
            // 
            this.grdFiles.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdFiles.AlternatingColors = true;
            this.grdFiles.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>任务文档</" +
    "GroupByBoxInfo></LocalizableData>";
            grdFiles_DesignTimeLayout.LayoutString = resources.GetString("grdFiles_DesignTimeLayout.LayoutString");
            this.grdFiles.DesignTimeLayout = grdFiles_DesignTimeLayout;
            this.grdFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFiles.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdFiles.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.grdFiles.Location = new System.Drawing.Point(0, 0);
            this.grdFiles.Name = "grdFiles";
            this.grdFiles.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.grdFiles.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdFiles.Size = new System.Drawing.Size(738, 53);
            this.grdFiles.TabIndex = 0;
            this.grdFiles.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdFiles_MouseDown);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 382);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(738, 3);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // pnlRightTop
            // 
            this.pnlRightTop.Controls.Add(this.tabTask);
            this.pnlRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTop.Location = new System.Drawing.Point(0, 0);
            this.pnlRightTop.Name = "pnlRightTop";
            this.pnlRightTop.Size = new System.Drawing.Size(738, 382);
            this.pnlRightTop.TabIndex = 0;
            // 
            // tabTask
            // 
            this.tabTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTask.Location = new System.Drawing.Point(0, 0);
            this.tabTask.Name = "tabTask";
            this.tabTask.Size = new System.Drawing.Size(738, 382);
            this.tabTask.TabIndex = 0;
            this.tabTask.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2,
            this.uiTabPage3});
            this.tabTask.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007;
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.xGroupBox2);
            this.uiTabPage1.Controls.Add(this.xGroupBox1);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 25);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(736, 356);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "任务信息";
            // 
            // xGroupBox2
            // 
            this.xGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xGroupBox2.Controls.Add(this.dtParentStartDate);
            this.xGroupBox2.Controls.Add(this.dtParentPreEndDate);
            this.xGroupBox2.Controls.Add(this.xLabel1);
            this.xGroupBox2.Controls.Add(this.xLabel2);
            this.xGroupBox2.Controls.Add(this.txtParentTaskNo);
            this.xGroupBox2.Controls.Add(this.xLabel3);
            this.xGroupBox2.Controls.Add(this.txtParentTask);
            this.xGroupBox2.Controls.Add(this.lblMainId);
            this.xGroupBox2.Location = new System.Drawing.Point(6, -1);
            this.xGroupBox2.Name = "xGroupBox2";
            this.xGroupBox2.Size = new System.Drawing.Size(725, 72);
            this.xGroupBox2.TabIndex = 3;
            this.xGroupBox2.Text = "上级任务";
            this.xGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // dtParentStartDate
            // 
            this.dtParentStartDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtParentStartDate.DropDownCalendar.Name = "";
            this.dtParentStartDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtParentStartDate.Location = new System.Drawing.Point(70, 43);
            this.dtParentStartDate.Name = "dtParentStartDate";
            this.dtParentStartDate.ReadOnly = true;
            this.dtParentStartDate.Size = new System.Drawing.Size(333, 23);
            this.dtParentStartDate.TabIndex = 48;
            this.dtParentStartDate.TabStop = false;
            this.dtParentStartDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtParentPreEndDate
            // 
            this.dtParentPreEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtParentPreEndDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtParentPreEndDate.DropDownCalendar.Name = "";
            this.dtParentPreEndDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtParentPreEndDate.Location = new System.Drawing.Point(495, 43);
            this.dtParentPreEndDate.Name = "dtParentPreEndDate";
            this.dtParentPreEndDate.ReadOnly = true;
            this.dtParentPreEndDate.Size = new System.Drawing.Size(221, 23);
            this.dtParentPreEndDate.TabIndex = 50;
            this.dtParentPreEndDate.TabStop = false;
            this.dtParentPreEndDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(8, 46);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 49;
            this.xLabel1.Text = "起始日期";
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(409, 46);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(80, 17);
            this.xLabel2.TabIndex = 51;
            this.xLabel2.Text = "预计完成日期";
            // 
            // txtParentTaskNo
            // 
            this.txtParentTaskNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParentTaskNo.IsAllowEmpty = true;
            this.txtParentTaskNo.Location = new System.Drawing.Point(495, 15);
            this.txtParentTaskNo.Name = "txtParentTaskNo";
            this.txtParentTaskNo.ReadOnly = true;
            this.txtParentTaskNo.Size = new System.Drawing.Size(221, 23);
            this.txtParentTaskNo.TabIndex = 46;
            this.txtParentTaskNo.TabStop = false;
            this.txtParentTaskNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.ForeColor = System.Drawing.Color.Black;
            this.xLabel3.Location = new System.Drawing.Point(433, 18);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(56, 17);
            this.xLabel3.TabIndex = 47;
            this.xLabel3.Text = "任务编号";
            // 
            // txtParentTask
            // 
            this.txtParentTask.IsAllowEmpty = true;
            this.txtParentTask.Location = new System.Drawing.Point(70, 15);
            this.txtParentTask.Name = "txtParentTask";
            this.txtParentTask.ReadOnly = true;
            this.txtParentTask.Size = new System.Drawing.Size(333, 23);
            this.txtParentTask.TabIndex = 44;
            this.txtParentTask.TabStop = false;
            this.txtParentTask.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblMainId
            // 
            this.lblMainId.AutoSize = true;
            this.lblMainId.ForeColor = System.Drawing.Color.Black;
            this.lblMainId.Location = new System.Drawing.Point(8, 18);
            this.lblMainId.Name = "lblMainId";
            this.lblMainId.Size = new System.Drawing.Size(56, 17);
            this.lblMainId.TabIndex = 45;
            this.lblMainId.Text = "任务名称";
            // 
            // xGroupBox1
            // 
            this.xGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xGroupBox1.Controls.Add(this.txtShortDesc);
            this.xGroupBox1.Controls.Add(this.txtRequire);
            this.xGroupBox1.Controls.Add(this.txtContent);
            this.xGroupBox1.Controls.Add(this.txtRemark);
            this.xGroupBox1.Controls.Add(this.lblShortDesc);
            this.xGroupBox1.Controls.Add(this.lblRequire);
            this.xGroupBox1.Controls.Add(this.lblContent);
            this.xGroupBox1.Controls.Add(this.lblRemark);
            this.xGroupBox1.Controls.Add(this.txtAssignPeople);
            this.xGroupBox1.Controls.Add(this.dtStartDate);
            this.xGroupBox1.Controls.Add(this.dtPreEndDate);
            this.xGroupBox1.Controls.Add(this.lblAssignPeople);
            this.xGroupBox1.Controls.Add(this.lblStartDate);
            this.xGroupBox1.Controls.Add(this.lblPreEndDate);
            this.xGroupBox1.Controls.Add(this.dtDispatchDate);
            this.xGroupBox1.Controls.Add(this.lblDispatchDate);
            this.xGroupBox1.Controls.Add(this.txtStartPeople);
            this.xGroupBox1.Controls.Add(this.lblStartPeople);
            this.xGroupBox1.Controls.Add(this.txtTaskNo);
            this.xGroupBox1.Controls.Add(this.lblTaskNo);
            this.xGroupBox1.Controls.Add(this.txtTaskName);
            this.xGroupBox1.Controls.Add(this.lblTaskName);
            this.xGroupBox1.Controls.Add(this.txtTaskTypeId);
            this.xGroupBox1.Controls.Add(this.lblTaskTypeId);
            this.xGroupBox1.Location = new System.Drawing.Point(6, 70);
            this.xGroupBox1.Name = "xGroupBox1";
            this.xGroupBox1.Size = new System.Drawing.Size(725, 281);
            this.xGroupBox1.TabIndex = 2;
            this.xGroupBox1.Text = "任务信息";
            this.xGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtShortDesc
            // 
            this.txtShortDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShortDesc.IsAllowEmpty = false;
            this.txtShortDesc.Location = new System.Drawing.Point(70, 90);
            this.txtShortDesc.Multiline = true;
            this.txtShortDesc.Name = "txtShortDesc";
            this.txtShortDesc.ReadOnly = true;
            this.txtShortDesc.Size = new System.Drawing.Size(646, 44);
            this.txtShortDesc.TabIndex = 40;
            this.txtShortDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRequire
            // 
            this.txtRequire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequire.IsAllowEmpty = false;
            this.txtRequire.Location = new System.Drawing.Point(70, 137);
            this.txtRequire.Multiline = true;
            this.txtRequire.Name = "txtRequire";
            this.txtRequire.ReadOnly = true;
            this.txtRequire.Size = new System.Drawing.Size(646, 44);
            this.txtRequire.TabIndex = 42;
            this.txtRequire.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.IsAllowEmpty = false;
            this.txtContent.Location = new System.Drawing.Point(70, 184);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(646, 44);
            this.txtContent.TabIndex = 44;
            this.txtContent.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemark.IsAllowEmpty = false;
            this.txtRemark.Location = new System.Drawing.Point(70, 231);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(646, 44);
            this.txtRemark.TabIndex = 46;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblShortDesc
            // 
            this.lblShortDesc.AutoSize = true;
            this.lblShortDesc.ForeColor = System.Drawing.Color.Black;
            this.lblShortDesc.Location = new System.Drawing.Point(8, 93);
            this.lblShortDesc.Name = "lblShortDesc";
            this.lblShortDesc.Size = new System.Drawing.Size(56, 17);
            this.lblShortDesc.TabIndex = 41;
            this.lblShortDesc.Text = "任务简介";
            // 
            // lblRequire
            // 
            this.lblRequire.AutoSize = true;
            this.lblRequire.ForeColor = System.Drawing.Color.Black;
            this.lblRequire.Location = new System.Drawing.Point(8, 139);
            this.lblRequire.Name = "lblRequire";
            this.lblRequire.Size = new System.Drawing.Size(56, 17);
            this.lblRequire.TabIndex = 43;
            this.lblRequire.Text = "任务要求";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.ForeColor = System.Drawing.Color.Black;
            this.lblContent.Location = new System.Drawing.Point(8, 187);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(56, 17);
            this.lblContent.TabIndex = 45;
            this.lblContent.Text = "工作内容";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(8, 234);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 47;
            this.lblRemark.Text = "备注信息";
            // 
            // txtAssignPeople
            // 
            this.txtAssignPeople.IsAllowEmpty = false;
            this.txtAssignPeople.Location = new System.Drawing.Point(70, 64);
            this.txtAssignPeople.Name = "txtAssignPeople";
            this.txtAssignPeople.ReadOnly = true;
            this.txtAssignPeople.Size = new System.Drawing.Size(185, 23);
            this.txtAssignPeople.TabIndex = 34;
            this.txtAssignPeople.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtStartDate.DropDownCalendar.Name = "";
            this.dtStartDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtStartDate.Location = new System.Drawing.Point(326, 64);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.ReadOnly = true;
            this.dtStartDate.Size = new System.Drawing.Size(136, 23);
            this.dtStartDate.TabIndex = 36;
            this.dtStartDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtPreEndDate
            // 
            this.dtPreEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPreEndDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtPreEndDate.DropDownCalendar.Name = "";
            this.dtPreEndDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtPreEndDate.Location = new System.Drawing.Point(554, 38);
            this.dtPreEndDate.Name = "dtPreEndDate";
            this.dtPreEndDate.ReadOnly = true;
            this.dtPreEndDate.Size = new System.Drawing.Size(162, 23);
            this.dtPreEndDate.TabIndex = 38;
            this.dtPreEndDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // lblAssignPeople
            // 
            this.lblAssignPeople.AutoSize = true;
            this.lblAssignPeople.ForeColor = System.Drawing.Color.Black;
            this.lblAssignPeople.Location = new System.Drawing.Point(8, 67);
            this.lblAssignPeople.Name = "lblAssignPeople";
            this.lblAssignPeople.Size = new System.Drawing.Size(44, 17);
            this.lblAssignPeople.TabIndex = 35;
            this.lblAssignPeople.Text = "负责人";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.ForeColor = System.Drawing.Color.Black;
            this.lblStartDate.Location = new System.Drawing.Point(264, 67);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(56, 17);
            this.lblStartDate.TabIndex = 37;
            this.lblStartDate.Text = "起始日期";
            // 
            // lblPreEndDate
            // 
            this.lblPreEndDate.AutoSize = true;
            this.lblPreEndDate.ForeColor = System.Drawing.Color.Black;
            this.lblPreEndDate.Location = new System.Drawing.Point(468, 67);
            this.lblPreEndDate.Name = "lblPreEndDate";
            this.lblPreEndDate.Size = new System.Drawing.Size(80, 17);
            this.lblPreEndDate.TabIndex = 39;
            this.lblPreEndDate.Text = "预计完成日期";
            // 
            // dtDispatchDate
            // 
            this.dtDispatchDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDispatchDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtDispatchDate.DropDownCalendar.Name = "";
            this.dtDispatchDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtDispatchDate.Location = new System.Drawing.Point(554, 64);
            this.dtDispatchDate.Name = "dtDispatchDate";
            this.dtDispatchDate.ReadOnly = true;
            this.dtDispatchDate.Size = new System.Drawing.Size(162, 23);
            this.dtDispatchDate.TabIndex = 32;
            this.dtDispatchDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // lblDispatchDate
            // 
            this.lblDispatchDate.AutoSize = true;
            this.lblDispatchDate.ForeColor = System.Drawing.Color.Black;
            this.lblDispatchDate.Location = new System.Drawing.Point(468, 41);
            this.lblDispatchDate.Name = "lblDispatchDate";
            this.lblDispatchDate.Size = new System.Drawing.Size(56, 17);
            this.lblDispatchDate.TabIndex = 33;
            this.lblDispatchDate.Text = "发派日期";
            // 
            // txtStartPeople
            // 
            this.txtStartPeople.IsAllowEmpty = false;
            this.txtStartPeople.Location = new System.Drawing.Point(326, 38);
            this.txtStartPeople.Name = "txtStartPeople";
            this.txtStartPeople.ReadOnly = true;
            this.txtStartPeople.Size = new System.Drawing.Size(136, 23);
            this.txtStartPeople.TabIndex = 28;
            this.txtStartPeople.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblStartPeople
            // 
            this.lblStartPeople.AutoSize = true;
            this.lblStartPeople.ForeColor = System.Drawing.Color.Black;
            this.lblStartPeople.Location = new System.Drawing.Point(264, 41);
            this.lblStartPeople.Name = "lblStartPeople";
            this.lblStartPeople.Size = new System.Drawing.Size(44, 17);
            this.lblStartPeople.TabIndex = 30;
            this.lblStartPeople.Text = "发起人";
            // 
            // txtTaskNo
            // 
            this.txtTaskNo.IsAllowEmpty = false;
            this.txtTaskNo.Location = new System.Drawing.Point(70, 38);
            this.txtTaskNo.Name = "txtTaskNo";
            this.txtTaskNo.ReadOnly = true;
            this.txtTaskNo.Size = new System.Drawing.Size(185, 23);
            this.txtTaskNo.TabIndex = 29;
            this.txtTaskNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblTaskNo
            // 
            this.lblTaskNo.AutoSize = true;
            this.lblTaskNo.ForeColor = System.Drawing.Color.Black;
            this.lblTaskNo.Location = new System.Drawing.Point(8, 41);
            this.lblTaskNo.Name = "lblTaskNo";
            this.lblTaskNo.Size = new System.Drawing.Size(56, 17);
            this.lblTaskNo.TabIndex = 31;
            this.lblTaskNo.Text = "任务编号";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaskName.IsAllowEmpty = false;
            this.txtTaskName.Location = new System.Drawing.Point(326, 12);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.ReadOnly = true;
            this.txtTaskName.Size = new System.Drawing.Size(390, 23);
            this.txtTaskName.TabIndex = 26;
            this.txtTaskName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.ForeColor = System.Drawing.Color.Black;
            this.lblTaskName.Location = new System.Drawing.Point(264, 15);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(56, 17);
            this.lblTaskName.TabIndex = 27;
            this.lblTaskName.Text = "任务名称";
            // 
            // txtTaskTypeId
            // 
            this.txtTaskTypeId.IsAllowEmpty = false;
            this.txtTaskTypeId.Location = new System.Drawing.Point(70, 12);
            this.txtTaskTypeId.Name = "txtTaskTypeId";
            this.txtTaskTypeId.ReadOnly = true;
            this.txtTaskTypeId.Size = new System.Drawing.Size(185, 23);
            this.txtTaskTypeId.TabIndex = 24;
            this.txtTaskTypeId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblTaskTypeId
            // 
            this.lblTaskTypeId.AutoSize = true;
            this.lblTaskTypeId.ForeColor = System.Drawing.Color.Black;
            this.lblTaskTypeId.Location = new System.Drawing.Point(8, 15);
            this.lblTaskTypeId.Name = "lblTaskTypeId";
            this.lblTaskTypeId.Size = new System.Drawing.Size(56, 17);
            this.lblTaskTypeId.TabIndex = 25;
            this.lblTaskTypeId.Text = "任务类型";
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.txtFileName);
            this.uiTabPage2.Controls.Add(this.txtFileDesc);
            this.uiTabPage2.Controls.Add(this.txtFileRemark);
            this.uiTabPage2.Controls.Add(this.lblFileName);
            this.uiTabPage2.Controls.Add(this.lblFileDesc);
            this.uiTabPage2.Controls.Add(this.xLabel4);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 25);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(736, 356);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "文档信息";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.IsAllowEmpty = false;
            this.txtFileName.Location = new System.Drawing.Point(72, 6);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(656, 23);
            this.txtFileName.TabIndex = 111;
            this.txtFileName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFileDesc
            // 
            this.txtFileDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileDesc.IsAllowEmpty = true;
            this.txtFileDesc.Location = new System.Drawing.Point(72, 37);
            this.txtFileDesc.Multiline = true;
            this.txtFileDesc.Name = "txtFileDesc";
            this.txtFileDesc.ReadOnly = true;
            this.txtFileDesc.Size = new System.Drawing.Size(656, 144);
            this.txtFileDesc.TabIndex = 112;
            this.txtFileDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFileRemark
            // 
            this.txtFileRemark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileRemark.IsAllowEmpty = true;
            this.txtFileRemark.Location = new System.Drawing.Point(72, 187);
            this.txtFileRemark.Multiline = true;
            this.txtFileRemark.Name = "txtFileRemark";
            this.txtFileRemark.ReadOnly = true;
            this.txtFileRemark.Size = new System.Drawing.Size(656, 166);
            this.txtFileRemark.TabIndex = 113;
            this.txtFileRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.ForeColor = System.Drawing.Color.Black;
            this.lblFileName.Location = new System.Drawing.Point(10, 8);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(56, 17);
            this.lblFileName.TabIndex = 114;
            this.lblFileName.Text = "文档名称";
            // 
            // lblFileDesc
            // 
            this.lblFileDesc.AutoSize = true;
            this.lblFileDesc.ForeColor = System.Drawing.Color.Black;
            this.lblFileDesc.Location = new System.Drawing.Point(10, 37);
            this.lblFileDesc.Name = "lblFileDesc";
            this.lblFileDesc.Size = new System.Drawing.Size(56, 17);
            this.lblFileDesc.TabIndex = 115;
            this.lblFileDesc.Text = "文档描述";
            // 
            // xLabel4
            // 
            this.xLabel4.AutoSize = true;
            this.xLabel4.ForeColor = System.Drawing.Color.Black;
            this.xLabel4.Location = new System.Drawing.Point(10, 190);
            this.xLabel4.Name = "xLabel4";
            this.xLabel4.Size = new System.Drawing.Size(56, 17);
            this.xLabel4.TabIndex = 116;
            this.xLabel4.Text = "备注信息";
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.Controls.Add(this.grdTaskAttach);
            this.uiTabPage3.Location = new System.Drawing.Point(1, 25);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(736, 356);
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "任务附件";
            // 
            // grdTaskAttach
            // 
            this.grdTaskAttach.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdTaskAttach.AlternatingColors = true;
            this.grdTaskAttach.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>拖动列名至此" +
    "进行分组</GroupByBoxInfo></LocalizableData>";
            grdTaskAttach_DesignTimeLayout.LayoutString = resources.GetString("grdTaskAttach_DesignTimeLayout.LayoutString");
            this.grdTaskAttach.DesignTimeLayout = grdTaskAttach_DesignTimeLayout;
            this.grdTaskAttach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTaskAttach.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdTaskAttach.GroupByBoxVisible = false;
            this.grdTaskAttach.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.grdTaskAttach.Location = new System.Drawing.Point(0, 0);
            this.grdTaskAttach.Name = "grdTaskAttach";
            this.grdTaskAttach.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.grdTaskAttach.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdTaskAttach.Size = new System.Drawing.Size(736, 356);
            this.grdTaskAttach.TabIndex = 11;
            this.grdTaskAttach.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdTaskAttach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdTaskAttach_MouseDown);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(389, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 438);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlTree
            // 
            this.pnlTree.Controls.Add(this.tvTask);
            this.pnlTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTree.Location = new System.Drawing.Point(0, 0);
            this.pnlTree.Name = "pnlTree";
            this.pnlTree.Size = new System.Drawing.Size(389, 438);
            this.pnlTree.TabIndex = 0;
            // 
            // tvTask
            // 
            this.tvTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTask.Location = new System.Drawing.Point(0, 0);
            this.tvTask.Name = "tvTask";
            this.tvTask.Size = new System.Drawing.Size(389, 438);
            this.tvTask.TabIndex = 0;
            this.tvTask.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvTask_BeforeExpand);
            this.tvTask.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvTask_AfterSelect);
            this.tvTask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tvTask_MouseDown);
            // 
            // xCommandManager1
            // 
            this.xCommandManager1.BottomRebar = this.BottomRebar1;
            this.xCommandManager1.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdNewTask,
            this.cmdEditTask,
            this.cmdDeleteTask,
            this.cmdFinishTask,
            this.cmdNewChildTask,
            this.cmdRefreshTask,
            this.cmdDownload,
            this.cmdPreview,
            this.cmdDownloadAttach,
            this.cmdPreviewAttach});
            this.xCommandManager1.ContainerControl = this;
            this.xCommandManager1.ContextMenus.AddRange(new Janus.Windows.UI.CommandBars.UIContextMenu[] {
            this.cmTaskMenu,
            this.cmFile,
            this.cmTaskAttach});
            this.xCommandManager1.Id = new System.Guid("19942ba8-ff53-4cc6-874e-13d1027a5708");
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
            // 
            // cmdNewTask
            // 
            this.cmdNewTask.Key = "cmdNewTask";
            this.cmdNewTask.Name = "cmdNewTask";
            this.cmdNewTask.Text = "新建任务";
            // 
            // cmdEditTask
            // 
            this.cmdEditTask.Key = "cmdEditTask";
            this.cmdEditTask.Name = "cmdEditTask";
            this.cmdEditTask.Text = "修改任务";
            // 
            // cmdDeleteTask
            // 
            this.cmdDeleteTask.Key = "cmdDeleteTask";
            this.cmdDeleteTask.Name = "cmdDeleteTask";
            this.cmdDeleteTask.Text = "删除任务";
            // 
            // cmdFinishTask
            // 
            this.cmdFinishTask.Key = "cmdFinishTask";
            this.cmdFinishTask.Name = "cmdFinishTask";
            this.cmdFinishTask.Text = "结束任务";
            // 
            // cmdNewChildTask
            // 
            this.cmdNewChildTask.Key = "cmdNewChildTask";
            this.cmdNewChildTask.Name = "cmdNewChildTask";
            this.cmdNewChildTask.Text = "新建子任务";
            // 
            // cmdRefreshTask
            // 
            this.cmdRefreshTask.Key = "cmdRefreshTask";
            this.cmdRefreshTask.Name = "cmdRefreshTask";
            this.cmdRefreshTask.Text = "刷新任务";
            // 
            // cmdDownload
            // 
            this.cmdDownload.Key = "cmdDownload";
            this.cmdDownload.Name = "cmdDownload";
            this.cmdDownload.Text = "下载";
            // 
            // cmdPreview
            // 
            this.cmdPreview.Key = "cmdPreview";
            this.cmdPreview.Name = "cmdPreview";
            this.cmdPreview.Text = "预览";
            // 
            // cmdDownloadAttach
            // 
            this.cmdDownloadAttach.Key = "cmdDownloadAttach";
            this.cmdDownloadAttach.Name = "cmdDownloadAttach";
            this.cmdDownloadAttach.Text = "下载附件";
            // 
            // cmdPreviewAttach
            // 
            this.cmdPreviewAttach.Key = "cmdPreviewAttach";
            this.cmdPreviewAttach.Name = "cmdPreviewAttach";
            this.cmdPreviewAttach.Text = "预览附件";
            // 
            // cmTaskMenu
            // 
            this.cmTaskMenu.CommandManager = this.xCommandManager1;
            this.cmTaskMenu.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdNewTask1,
            this.cmdNewChildTask1,
            this.cmdEditTask1,
            this.cmdDeleteTask1,
            this.cmdFinishTask1,
            this.cmdRefreshTask1});
            this.cmTaskMenu.Key = "cmTaskMenu";
            // 
            // cmdNewTask1
            // 
            this.cmdNewTask1.Key = "cmdNewTask";
            this.cmdNewTask1.Name = "cmdNewTask1";
            // 
            // cmdNewChildTask1
            // 
            this.cmdNewChildTask1.Key = "cmdNewChildTask";
            this.cmdNewChildTask1.Name = "cmdNewChildTask1";
            // 
            // cmdEditTask1
            // 
            this.cmdEditTask1.Key = "cmdEditTask";
            this.cmdEditTask1.Name = "cmdEditTask1";
            // 
            // cmdDeleteTask1
            // 
            this.cmdDeleteTask1.Key = "cmdDeleteTask";
            this.cmdDeleteTask1.Name = "cmdDeleteTask1";
            // 
            // cmdFinishTask1
            // 
            this.cmdFinishTask1.Key = "cmdFinishTask";
            this.cmdFinishTask1.Name = "cmdFinishTask1";
            // 
            // cmdRefreshTask1
            // 
            this.cmdRefreshTask1.Key = "cmdRefreshTask";
            this.cmdRefreshTask1.Name = "cmdRefreshTask1";
            // 
            // cmFile
            // 
            this.cmFile.CommandManager = this.xCommandManager1;
            this.cmFile.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdDownload1,
            this.cmdPreview1});
            this.cmFile.Key = "cmFile";
            // 
            // cmdDownload1
            // 
            this.cmdDownload1.Key = "cmdDownload";
            this.cmdDownload1.Name = "cmdDownload1";
            // 
            // cmdPreview1
            // 
            this.cmdPreview1.Key = "cmdPreview";
            this.cmdPreview1.Name = "cmdPreview1";
            // 
            // cmTaskAttach
            // 
            this.cmTaskAttach.CommandManager = this.xCommandManager1;
            this.cmTaskAttach.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdDownloadAttach1,
            this.cmdPreviewAttach1});
            this.cmTaskAttach.Key = "cmTaskAttach";
            // 
            // cmdDownloadAttach1
            // 
            this.cmdDownloadAttach1.Key = "cmdDownloadAttach";
            this.cmdDownloadAttach1.Name = "cmdDownloadAttach1";
            // 
            // cmdPreviewAttach1
            // 
            this.cmdPreviewAttach1.Key = "cmdPreviewAttach";
            this.cmdPreviewAttach1.Name = "cmdPreviewAttach1";
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
            this.TopRebar1.CommandManager = this.xCommandManager1;
            this.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopRebar1.Location = new System.Drawing.Point(0, 0);
            this.TopRebar1.Name = "TopRebar1";
            this.TopRebar1.Size = new System.Drawing.Size(1130, 0);
            // 
            // pnlEnd
            // 
            this.pnlEnd.Controls.Add(this.pnlEndFill);
            this.pnlEnd.Controls.Add(this.pnlEndTop);
            this.pnlEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEnd.Location = new System.Drawing.Point(0, 0);
            this.pnlEnd.Name = "pnlEnd";
            this.pnlEnd.Size = new System.Drawing.Size(1130, 475);
            this.pnlEnd.TabIndex = 1;
            // 
            // pnlEndFill
            // 
            this.pnlEndFill.Controls.Add(this.pnlAll);
            this.pnlEndFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEndFill.Location = new System.Drawing.Point(0, 37);
            this.pnlEndFill.Name = "pnlEndFill";
            this.pnlEndFill.Size = new System.Drawing.Size(1130, 438);
            this.pnlEndFill.TabIndex = 2;
            // 
            // pnlEndTop
            // 
            this.pnlEndTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEndTop.Controls.Add(this.xQueryCombobox1);
            this.pnlEndTop.Controls.Add(this.label6);
            this.pnlEndTop.Controls.Add(this.btnQuery);
            this.pnlEndTop.Controls.Add(this.xQueryEditBox4);
            this.pnlEndTop.Controls.Add(this.label5);
            this.pnlEndTop.Controls.Add(this.xQueryEditBox3);
            this.pnlEndTop.Controls.Add(this.label4);
            this.pnlEndTop.Controls.Add(this.xQueryDatePicker2);
            this.pnlEndTop.Controls.Add(this.xQueryDatePicker1);
            this.pnlEndTop.Controls.Add(this.label3);
            this.pnlEndTop.Controls.Add(this.xQueryEditBox2);
            this.pnlEndTop.Controls.Add(this.xQueryEditBox1);
            this.pnlEndTop.Controls.Add(this.label2);
            this.pnlEndTop.Controls.Add(this.label1);
            this.pnlEndTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEndTop.Location = new System.Drawing.Point(0, 0);
            this.pnlEndTop.Name = "pnlEndTop";
            this.pnlEndTop.Size = new System.Drawing.Size(1130, 37);
            this.pnlEndTop.TabIndex = 1;
            // 
            // xQueryCombobox1
            // 
            this.xQueryCombobox1.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.xQueryCombobox1.IsAllowEmpty = false;
            uiComboBoxItem4.FormatStyle.Alpha = 0;
            uiComboBoxItem4.IsSeparator = false;
            uiComboBoxItem4.Text = "";
            uiComboBoxItem5.FormatStyle.Alpha = 0;
            uiComboBoxItem5.IsSeparator = false;
            uiComboBoxItem5.Text = "开始";
            uiComboBoxItem5.Value = "开始";
            uiComboBoxItem6.FormatStyle.Alpha = 0;
            uiComboBoxItem6.IsSeparator = false;
            uiComboBoxItem6.Text = "结束";
            uiComboBoxItem6.Value = "结束";
            this.xQueryCombobox1.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem4,
            uiComboBoxItem5,
            uiComboBoxItem6});
            this.xQueryCombobox1.Location = new System.Drawing.Point(698, 6);
            this.xQueryCombobox1.Name = "xQueryCombobox1";
            this.xQueryCombobox1.QueryCheckBox = null;
            this.xQueryCombobox1.QueryFieldName = "TaskStatus";
            this.xQueryCombobox1.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.xQueryCombobox1.Size = new System.Drawing.Size(73, 23);
            this.xQueryCombobox1.TabIndex = 14;
            this.xQueryCombobox1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "任务状态";
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(1049, 7);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "查询";
            this.btnQuery.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // xQueryEditBox4
            // 
            this.xQueryEditBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xQueryEditBox4.IsAllowEmpty = false;
            this.xQueryEditBox4.Location = new System.Drawing.Point(942, 7);
            this.xQueryEditBox4.Name = "xQueryEditBox4";
            this.xQueryEditBox4.QueryCheckBox = null;
            this.xQueryEditBox4.QueryFieldName = "AssignPeople";
            this.xQueryEditBox4.QueryOperateType = MMIS.Component.XQueryOperateType.Contain;
            this.xQueryEditBox4.Size = new System.Drawing.Size(104, 23);
            this.xQueryEditBox4.TabIndex = 11;
            this.xQueryEditBox4.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(897, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "负责人";
            // 
            // xQueryEditBox3
            // 
            this.xQueryEditBox3.IsAllowEmpty = false;
            this.xQueryEditBox3.Location = new System.Drawing.Point(824, 6);
            this.xQueryEditBox3.Name = "xQueryEditBox3";
            this.xQueryEditBox3.QueryCheckBox = null;
            this.xQueryEditBox3.QueryFieldName = "StartPeople";
            this.xQueryEditBox3.QueryOperateType = MMIS.Component.XQueryOperateType.Contain;
            this.xQueryEditBox3.Size = new System.Drawing.Size(67, 23);
            this.xQueryEditBox3.TabIndex = 9;
            this.xQueryEditBox3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(777, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "发起人";
            // 
            // xQueryDatePicker2
            // 
            this.xQueryDatePicker2.Checked = false;
            // 
            // 
            // 
            this.xQueryDatePicker2.DropDownCalendar.Name = "";
            this.xQueryDatePicker2.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.xQueryDatePicker2.Location = new System.Drawing.Point(531, 6);
            this.xQueryDatePicker2.Name = "xQueryDatePicker2";
            this.xQueryDatePicker2.QueryCheckBox = null;
            this.xQueryDatePicker2.QueryFieldName = "StartDate";
            this.xQueryDatePicker2.QueryOperateType = MMIS.Component.XQueryOperateType.LessThanOrEqual;
            this.xQueryDatePicker2.ShowCheckBox = true;
            this.xQueryDatePicker2.Size = new System.Drawing.Size(104, 23);
            this.xQueryDatePicker2.TabIndex = 7;
            this.xQueryDatePicker2.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // xQueryDatePicker1
            // 
            this.xQueryDatePicker1.Checked = false;
            // 
            // 
            // 
            this.xQueryDatePicker1.DropDownCalendar.Name = "";
            this.xQueryDatePicker1.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.xQueryDatePicker1.Location = new System.Drawing.Point(421, 6);
            this.xQueryDatePicker1.Name = "xQueryDatePicker1";
            this.xQueryDatePicker1.QueryCheckBox = null;
            this.xQueryDatePicker1.QueryFieldName = "StartDate";
            this.xQueryDatePicker1.QueryOperateType = MMIS.Component.XQueryOperateType.MoreThanOrEqual;
            this.xQueryDatePicker1.ShowCheckBox = true;
            this.xQueryDatePicker1.Size = new System.Drawing.Size(104, 23);
            this.xQueryDatePicker1.TabIndex = 6;
            this.xQueryDatePicker1.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "起始日期";
            // 
            // xQueryEditBox2
            // 
            this.xQueryEditBox2.IsAllowEmpty = false;
            this.xQueryEditBox2.Location = new System.Drawing.Point(287, 6);
            this.xQueryEditBox2.Name = "xQueryEditBox2";
            this.xQueryEditBox2.QueryCheckBox = null;
            this.xQueryEditBox2.QueryFieldName = "TaskNo";
            this.xQueryEditBox2.QueryOperateType = MMIS.Component.XQueryOperateType.Contain;
            this.xQueryEditBox2.Size = new System.Drawing.Size(71, 23);
            this.xQueryEditBox2.TabIndex = 4;
            this.xQueryEditBox2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xQueryEditBox1
            // 
            this.xQueryEditBox1.IsAllowEmpty = false;
            this.xQueryEditBox1.Location = new System.Drawing.Point(70, 6);
            this.xQueryEditBox1.Name = "xQueryEditBox1";
            this.xQueryEditBox1.QueryCheckBox = null;
            this.xQueryEditBox1.QueryFieldName = "TaskName";
            this.xQueryEditBox1.QueryOperateType = MMIS.Component.XQueryOperateType.Contain;
            this.xQueryEditBox1.Size = new System.Drawing.Size(155, 23);
            this.xQueryEditBox1.TabIndex = 3;
            this.xQueryEditBox1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "任务编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "任务名称";
            // 
            // tmRefresh
            // 
            this.tmRefresh.Tick += new System.EventHandler(this.tmRefresh_Tick);
            // 
            // frmTreeTaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 475);
            this.Controls.Add(this.pnlEnd);
            this.Controls.Add(this.TopRebar1);
            this.Name = "frmTreeTaskList";
            this.Text = "任务信息";
            this.Load += new System.EventHandler(this.frmTreeTaskList_Load);
            this.pnlAll.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRightFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).EndInit();
            this.pnlRightTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabTask)).EndInit();
            this.tabTask.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox2)).EndInit();
            this.xGroupBox2.ResumeLayout(false);
            this.xGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).EndInit();
            this.xGroupBox1.ResumeLayout(false);
            this.xGroupBox1.PerformLayout();
            this.uiTabPage2.ResumeLayout(false);
            this.uiTabPage2.PerformLayout();
            this.uiTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskAttach)).EndInit();
            this.pnlTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmTaskMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmTaskAttach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
            this.pnlEnd.ResumeLayout(false);
            this.pnlEndFill.ResumeLayout(false);
            this.pnlEndTop.ResumeLayout(false);
            this.pnlEndTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAll;
        private System.Windows.Forms.Panel pnlTree;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlRightTop;
        private System.Windows.Forms.Panel pnlRightFill;
        private System.Windows.Forms.Splitter splitter2;
        protected Component.XCommandManager xCommandManager1;
        private Janus.Windows.UI.CommandBars.UIRebar BottomRebar1;
        private Janus.Windows.UI.CommandBars.UICommand cmdNewTask;
        private Janus.Windows.UI.CommandBars.UICommand cmdEditTask;
        private Janus.Windows.UI.CommandBars.UICommand cmdDeleteTask;
        private Janus.Windows.UI.CommandBars.UICommand cmdFinishTask;
        private Janus.Windows.UI.CommandBars.UICommand cmdNewChildTask;
        private Janus.Windows.UI.CommandBars.UIRebar TopRebar1;
        private Janus.Windows.UI.CommandBars.UICommand cmdNewTask1;
        private Janus.Windows.UI.CommandBars.UICommand cmdEditTask1;
        private Janus.Windows.UI.CommandBars.UICommand cmdDeleteTask1;
        private Janus.Windows.UI.CommandBars.UIRebar LeftRebar1;
        private Janus.Windows.UI.CommandBars.UIRebar RightRebar1;
        private Janus.Windows.UI.CommandBars.UICommand cmdNewChildTask1;
        protected Janus.Windows.UI.CommandBars.UIContextMenu cmTaskMenu;
        protected Component.XGridEx grdFiles;
        protected System.Windows.Forms.TreeView tvTask;
        private Janus.Windows.UI.CommandBars.UICommand cmdRefreshTask;
        private Janus.Windows.UI.CommandBars.UICommand cmdFinishTask1;
        private Janus.Windows.UI.CommandBars.UICommand cmdRefreshTask1;
        private Component.XTabControl tabTask;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Component.XGroupBox xGroupBox2;
        private Component.XDateTimePicker dtParentStartDate;
        private Component.XDateTimePicker dtParentPreEndDate;
        private Component.XLabel xLabel1;
        private Component.XLabel xLabel2;
        private Component.XEditBox txtParentTaskNo;
        private Component.XLabel xLabel3;
        private Component.XEditBox txtParentTask;
        private Component.XLabel lblMainId;
        private Component.XGroupBox xGroupBox1;
        private Component.XEditBox txtShortDesc;
        private Component.XEditBox txtRequire;
        private Component.XEditBox txtContent;
        private Component.XEditBox txtRemark;
        private Component.XLabel lblShortDesc;
        private Component.XLabel lblRequire;
        private Component.XLabel lblContent;
        private Component.XLabel lblRemark;
        private Component.XEditBox txtAssignPeople;
        private Component.XDateTimePicker dtStartDate;
        private Component.XDateTimePicker dtPreEndDate;
        private Component.XLabel lblAssignPeople;
        private Component.XLabel lblStartDate;
        private Component.XLabel lblPreEndDate;
        private Component.XDateTimePicker dtDispatchDate;
        private Component.XLabel lblDispatchDate;
        private Component.XEditBox txtStartPeople;
        private Component.XLabel lblStartPeople;
        private Component.XEditBox txtTaskNo;
        private Component.XLabel lblTaskNo;
        private Component.XEditBox txtTaskName;
        private Component.XLabel lblTaskName;
        private Component.XEditBox txtTaskTypeId;
        private Component.XLabel lblTaskTypeId;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private Component.XEditBox txtFileName;
        private Component.XEditBox txtFileDesc;
        private Component.XEditBox txtFileRemark;
        private Component.XLabel lblFileName;
        private Component.XLabel lblFileDesc;
        private Component.XLabel xLabel4;
        private Janus.Windows.UI.CommandBars.UICommand cmdDownload;
        private Janus.Windows.UI.CommandBars.UIContextMenu cmFile;
        private Janus.Windows.UI.CommandBars.UICommand cmdDownload1;
        private System.Windows.Forms.Panel pnlEnd;
        private System.Windows.Forms.Panel pnlEndTop;
        private System.Windows.Forms.Panel pnlEndFill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Component.XQueryEditBox xQueryEditBox2;
        private Component.XQueryEditBox xQueryEditBox1;
        private Component.XButton btnQuery;
        private Component.XQueryEditBox xQueryEditBox4;
        private System.Windows.Forms.Label label5;
        private Component.XQueryEditBox xQueryEditBox3;
        private System.Windows.Forms.Label label4;
        private Component.XQueryDatePicker xQueryDatePicker2;
        private Component.XQueryDatePicker xQueryDatePicker1;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.UI.CommandBars.UICommand cmdPreview;
        private Janus.Windows.UI.CommandBars.UICommand cmdPreview1;
        private System.Windows.Forms.Label label6;
        protected Component.XQueryCombobox xQueryCombobox1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        protected Component.XGridEx grdTaskAttach;
        private Janus.Windows.UI.CommandBars.UICommand cmdDownloadAttach;
        private Janus.Windows.UI.CommandBars.UICommand cmdPreviewAttach;
        private Janus.Windows.UI.CommandBars.UIContextMenu cmTaskAttach;
        private Janus.Windows.UI.CommandBars.UICommand cmdDownloadAttach1;
        private Janus.Windows.UI.CommandBars.UICommand cmdPreviewAttach1;
        private System.Windows.Forms.Timer tmRefresh;
    }
}