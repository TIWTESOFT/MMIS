namespace MMIS.UI.Common
{
    partial class frmDetailListBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailListBase));
            Janus.Windows.GridEX.GridEXLayout grdDetail_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdDetail = new MMIS.Component.XGridEx();
            this.cmDetailRight = new Janus.Windows.UI.CommandBars.UIContextMenu();
            this.cmdAddDetail1 = new Janus.Windows.UI.CommandBars.UICommand("cmdAddDetail");
            this.cmdEditDetail1 = new Janus.Windows.UI.CommandBars.UICommand("cmdEditDetail");
            this.cmdDeleteDetail1 = new Janus.Windows.UI.CommandBars.UICommand("cmdDeleteDetail");
            this.cmdAddDetail = new Janus.Windows.UI.CommandBars.UICommand("cmdAddDetail");
            this.cmdEditDetail = new Janus.Windows.UI.CommandBars.UICommand("cmdEditDetail");
            this.cmdDeleteDetail = new Janus.Windows.UI.CommandBars.UICommand("cmdDeleteDetail");
            this.splitter1 = new System.Windows.Forms.Splitter();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmDetailRight)).BeginInit();
            this.SuspendLayout();
            // 
            // grdData
            // 
            grdData_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>";
            this.grdData.DesignTimeLayout = grdData_DesignTimeLayout;
            this.grdData.Size = new System.Drawing.Size(713, 220);
            // 
            // grpQuery
            // 
            this.grpQuery.Size = new System.Drawing.Size(722, 55);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(1077, 17);
            // 
            // xCommandManager1
            // 
            this.xCommandManager1.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdAddDetail,
            this.cmdEditDetail,
            this.cmdDeleteDetail});
            this.xCommandManager1.ContextMenus.AddRange(new Janus.Windows.UI.CommandBars.UIContextMenu[] {
            this.cmDetailRight});
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(733, 73);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.splitter1);
            this.panel3.Size = new System.Drawing.Size(733, 445);
            this.panel3.Controls.SetChildIndex(this.panel7, 0);
            this.panel3.Controls.SetChildIndex(this.panel8, 0);
            this.panel3.Controls.SetChildIndex(this.splitter1, 0);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.grdDetail);
            this.panel7.Location = new System.Drawing.Point(10, 230);
            this.panel7.Size = new System.Drawing.Size(713, 215);
            this.panel7.Visible = true;
            // 
            // panel8
            // 
            this.panel8.Size = new System.Drawing.Size(713, 220);
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
            // grdDetail
            // 
            this.grdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdDetail.AlternatingColors = true;
            this.grdDetail.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>明细信息</" +
    "GroupByBoxInfo></LocalizableData>";
            grdDetail_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>";
            this.grdDetail.DesignTimeLayout = grdDetail_DesignTimeLayout;
            this.grdDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetail.Location = new System.Drawing.Point(0, 0);
            this.grdDetail.Name = "grdDetail";
            this.grdDetail.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.grdDetail.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdDetail.Size = new System.Drawing.Size(713, 215);
            this.grdDetail.TabIndex = 0;
            this.grdDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdDetail.DoubleClick += new System.EventHandler(this.grdDetail_DoubleClick);
            this.grdDetail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdDetail_MouseDown);
            // 
            // cmDetailRight
            // 
            this.cmDetailRight.CommandManager = this.xCommandManager1;
            this.cmDetailRight.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdAddDetail1,
            this.cmdEditDetail1,
            this.cmdDeleteDetail1});
            this.cmDetailRight.Key = "cmDetailRight";
            // 
            // cmdAddDetail1
            // 
            this.cmdAddDetail1.Key = "cmdAddDetail";
            this.cmdAddDetail1.Name = "cmdAddDetail1";
            // 
            // cmdEditDetail1
            // 
            this.cmdEditDetail1.Key = "cmdEditDetail";
            this.cmdEditDetail1.Name = "cmdEditDetail1";
            // 
            // cmdDeleteDetail1
            // 
            this.cmdDeleteDetail1.Key = "cmdDeleteDetail";
            this.cmdDeleteDetail1.Name = "cmdDeleteDetail1";
            // 
            // cmdAddDetail
            // 
            this.cmdAddDetail.ImageIndex = 66;
            this.cmdAddDetail.Key = "cmdAddDetail";
            this.cmdAddDetail.Name = "cmdAddDetail";
            this.cmdAddDetail.Text = "添加明细";
            // 
            // cmdEditDetail
            // 
            this.cmdEditDetail.ImageIndex = 41;
            this.cmdEditDetail.Key = "cmdEditDetail";
            this.cmdEditDetail.Name = "cmdEditDetail";
            this.cmdEditDetail.Text = "编辑明细";
            // 
            // cmdDeleteDetail
            // 
            this.cmdDeleteDetail.ImageIndex = 42;
            this.cmdDeleteDetail.Key = "cmdDeleteDetail";
            this.cmdDeleteDetail.Name = "cmdDeleteDetail";
            this.cmdDeleteDetail.Text = "删除明细";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(10, 227);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(713, 3);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // frmDetailListBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 546);
            this.Name = "frmDetailListBase";
            this.Text = "frmDetailListBase";
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpQuery)).EndInit();
            this.grpQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmRight)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListToolBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmDetailRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected MMIS.Component.XGridEx grdDetail;
        private Janus.Windows.UI.CommandBars.UICommand cmdAddDetail;
        private Janus.Windows.UI.CommandBars.UICommand cmdEditDetail;
        private Janus.Windows.UI.CommandBars.UICommand cmdDeleteDetail;
        private Janus.Windows.UI.CommandBars.UIContextMenu cmDetailRight;
        private Janus.Windows.UI.CommandBars.UICommand cmdAddDetail1;
        private Janus.Windows.UI.CommandBars.UICommand cmdEditDetail1;
        private Janus.Windows.UI.CommandBars.UICommand cmdDeleteDetail1;
        private System.Windows.Forms.Splitter splitter1;

    }
}