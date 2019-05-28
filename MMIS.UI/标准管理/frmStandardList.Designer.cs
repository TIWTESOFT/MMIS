namespace MMIS.UI
{
    public partial class frmStandardList
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
            Janus.Windows.GridEX.GridEXLayout grdData_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdFiles_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStandardList));
            Janus.Windows.GridEX.GridEXLayout grdEquipments_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.xQueryEditBox1 = new MMIS.Component.XQueryEditBox();
            this.xQueryEditBox2 = new MMIS.Component.XQueryEditBox();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.pageFiles = new Janus.Windows.UI.Tab.UITabPage();
            this.grdFiles = new MMIS.Component.XGridEx();
            this.pageEquipments = new Janus.Windows.UI.Tab.UITabPage();
            this.grdEquipments = new MMIS.Component.XGridEx();
            this.cmFiles = new Janus.Windows.UI.CommandBars.UIContextMenu();
            this.cmdDownloadFile1 = new Janus.Windows.UI.CommandBars.UICommand("cmdDownloadFile");
            this.cmdPreviewFile1 = new Janus.Windows.UI.CommandBars.UICommand("cmdPreviewFile");
            this.cmdDownloadFile = new Janus.Windows.UI.CommandBars.UICommand("cmdDownloadFile");
            this.cmdPreviewFile = new Janus.Windows.UI.CommandBars.UICommand("cmdPreviewFile");
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).BeginInit();
            this.tabDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpQuery)).BeginInit();
            this.grpQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmRight)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListToolBar)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pageFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).BeginInit();
            this.pageEquipments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDetail
            // 
            this.tabDetail.Size = new System.Drawing.Size(774, 315);
            this.tabDetail.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.pageFiles,
            this.pageEquipments});
            // 
            // grdData
            // 
            grdData_DesignTimeLayout.LayoutString = resources.GetString("grdData_DesignTimeLayout.LayoutString");
            this.grdData.DesignTimeLayout = grdData_DesignTimeLayout;
            this.grdData.Size = new System.Drawing.Size(774, 31);
            // 
            // grpQuery
            // 
            this.grpQuery.Controls.Add(this.xQueryEditBox2);
            this.grpQuery.Controls.Add(this.xLabel2);
            this.grpQuery.Controls.Add(this.xQueryEditBox1);
            this.grpQuery.Controls.Add(this.xLabel1);
            this.grpQuery.Size = new System.Drawing.Size(783, 55);
            this.grpQuery.Controls.SetChildIndex(this.btnQuery, 0);
            this.grpQuery.Controls.SetChildIndex(this.chkChecked, 0);
            this.grpQuery.Controls.SetChildIndex(this.xLabel1, 0);
            this.grpQuery.Controls.SetChildIndex(this.xQueryEditBox1, 0);
            this.grpQuery.Controls.SetChildIndex(this.xLabel2, 0);
            this.grpQuery.Controls.SetChildIndex(this.xQueryEditBox2, 0);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(4457, 18);
            // 
            // xCommandManager1
            // 
            this.xCommandManager1.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdDownloadFile,
            this.cmdPreviewFile});
            this.xCommandManager1.ContextMenus.AddRange(new Janus.Windows.UI.CommandBars.UIContextMenu[] {
            this.cmFiles});
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(794, 73);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(794, 356);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(10, 41);
            this.panel7.Size = new System.Drawing.Size(774, 315);
            // 
            // panel8
            // 
            this.panel8.Size = new System.Drawing.Size(774, 31);
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
            // chkChecked
            // 
            this.chkChecked.Location = new System.Drawing.Point(4388, 20);
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(9, 24);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 1001;
            this.xLabel1.Text = "标准编号";
            // 
            // xQueryEditBox1
            // 
            this.xQueryEditBox1.IsAllowEmpty = false;
            this.xQueryEditBox1.Location = new System.Drawing.Point(68, 21);
            this.xQueryEditBox1.Name = "xQueryEditBox1";
            this.xQueryEditBox1.QueryCheckBox = null;
            this.xQueryEditBox1.QueryFieldName = "StandNo";
            this.xQueryEditBox1.QueryOperateType = MMIS.Component.XQueryOperateType.Contain;
            this.xQueryEditBox1.Size = new System.Drawing.Size(100, 23);
            this.xQueryEditBox1.TabIndex = 1002;
            this.xQueryEditBox1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xQueryEditBox2
            // 
            this.xQueryEditBox2.IsAllowEmpty = false;
            this.xQueryEditBox2.Location = new System.Drawing.Point(244, 21);
            this.xQueryEditBox2.Name = "xQueryEditBox2";
            this.xQueryEditBox2.QueryCheckBox = null;
            this.xQueryEditBox2.QueryFieldName = "StandName";
            this.xQueryEditBox2.QueryOperateType = MMIS.Component.XQueryOperateType.Contain;
            this.xQueryEditBox2.Size = new System.Drawing.Size(169, 23);
            this.xQueryEditBox2.TabIndex = 1004;
            this.xQueryEditBox2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(185, 24);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(56, 17);
            this.xLabel2.TabIndex = 1003;
            this.xLabel2.Text = "标准名称";
            // 
            // pageFiles
            // 
            this.pageFiles.Controls.Add(this.grdFiles);
            this.pageFiles.Location = new System.Drawing.Point(1, 25);
            this.pageFiles.Name = "pageFiles";
            this.pageFiles.Size = new System.Drawing.Size(772, 289);
            this.pageFiles.TabStop = true;
            this.pageFiles.Text = "标准文件集";
            // 
            // grdFiles
            // 
            this.grdFiles.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdFiles.AlternatingColors = true;
            this.grdFiles.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>拖动列名至此" +
    "进行分组</GroupByBoxInfo></LocalizableData>";
            grdFiles_DesignTimeLayout.LayoutString = resources.GetString("grdFiles_DesignTimeLayout.LayoutString");
            this.grdFiles.DesignTimeLayout = grdFiles_DesignTimeLayout;
            this.grdFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFiles.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdFiles.GroupByBoxVisible = false;
            this.grdFiles.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.grdFiles.Location = new System.Drawing.Point(0, 0);
            this.grdFiles.Name = "grdFiles";
            this.grdFiles.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.grdFiles.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdFiles.Size = new System.Drawing.Size(772, 289);
            this.grdFiles.TabIndex = 6;
            this.grdFiles.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdFiles_MouseDown);
            // 
            // pageEquipments
            // 
            this.pageEquipments.Controls.Add(this.grdEquipments);
            this.pageEquipments.Location = new System.Drawing.Point(1, 25);
            this.pageEquipments.Name = "pageEquipments";
            this.pageEquipments.Size = new System.Drawing.Size(772, 289);
            this.pageEquipments.TabStop = true;
            this.pageEquipments.Text = "标准设备";
            // 
            // grdEquipments
            // 
            this.grdEquipments.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdEquipments.AlternatingColors = true;
            this.grdEquipments.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>拖动列名至此" +
    "进行分组</GroupByBoxInfo></LocalizableData>";
            grdEquipments_DesignTimeLayout.LayoutString = resources.GetString("grdEquipments_DesignTimeLayout.LayoutString");
            this.grdEquipments.DesignTimeLayout = grdEquipments_DesignTimeLayout;
            this.grdEquipments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEquipments.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdEquipments.GroupByBoxVisible = false;
            this.grdEquipments.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.grdEquipments.Location = new System.Drawing.Point(0, 0);
            this.grdEquipments.Name = "grdEquipments";
            this.grdEquipments.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.grdEquipments.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdEquipments.Size = new System.Drawing.Size(772, 289);
            this.grdEquipments.TabIndex = 10;
            this.grdEquipments.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // cmFiles
            // 
            this.cmFiles.CommandManager = this.xCommandManager1;
            this.cmFiles.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdDownloadFile1,
            this.cmdPreviewFile1});
            this.cmFiles.Key = "cmFiles";
            // 
            // cmdDownloadFile1
            // 
            this.cmdDownloadFile1.Key = "cmdDownloadFile";
            this.cmdDownloadFile1.Name = "cmdDownloadFile1";
            this.cmdDownloadFile1.Text = "下载文件";
            // 
            // cmdPreviewFile1
            // 
            this.cmdPreviewFile1.Key = "cmdPreviewFile";
            this.cmdPreviewFile1.Name = "cmdPreviewFile1";
            // 
            // cmdDownloadFile
            // 
            this.cmdDownloadFile.ImageIndex = 80;
            this.cmdDownloadFile.Key = "cmdDownloadFile";
            this.cmdDownloadFile.Name = "cmdDownloadFile";
            this.cmdDownloadFile.Text = "下载文件";
            // 
            // cmdPreviewFile
            // 
            this.cmdPreviewFile.ImageIndex = 48;
            this.cmdPreviewFile.Key = "cmdPreviewFile";
            this.cmdPreviewFile.Name = "cmdPreviewFile";
            this.cmdPreviewFile.Text = "预览文件";
            // 
            // frmStandardList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(794, 457);
            this.Name = "frmStandardList";
            this.Text = "计量标准";
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).EndInit();
            this.tabDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpQuery)).EndInit();
            this.grpQuery.ResumeLayout(false);
            this.grpQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmRight)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListToolBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pageFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).EndInit();
            this.pageEquipments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Component.XLabel xLabel1;
        private Component.XQueryEditBox xQueryEditBox1;
        private Component.XQueryEditBox xQueryEditBox2;
        private Component.XLabel xLabel2;
        //protected Component.XGridEx grdFiles;
        //protected Component.XGridEx grdEquipments;
        private Janus.Windows.UI.Tab.UITabPage pageFiles;
        private Janus.Windows.UI.Tab.UITabPage pageEquipments;
        protected Component.XGridEx grdEquipments;
        protected Component.XGridEx grdFiles;
        private Janus.Windows.UI.CommandBars.UICommand cmdDownloadFile;
        private Janus.Windows.UI.CommandBars.UIContextMenu cmFiles;
        private Janus.Windows.UI.CommandBars.UICommand cmdDownloadFile1;
        private Janus.Windows.UI.CommandBars.UICommand cmdPreviewFile;
        private Janus.Windows.UI.CommandBars.UICommand cmdPreviewFile1;

        
    }
}