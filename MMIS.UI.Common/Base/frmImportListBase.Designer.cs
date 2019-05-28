namespace MMIS.UI.Common
{
    partial class frmImportListBase
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
            Janus.Windows.GridEX.GridEXLayout grdData_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportListBase));
            this.pnlEnd = new System.Windows.Forms.Panel();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.grdData = new MMIS.Component.XGridEx();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.xGroupBox1 = new MMIS.Component.XGroupBox();
            this.btnImport = new MMIS.Component.XButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.proImport = new MMIS.Component.XProgressBar();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.txtFileName = new MMIS.Component.XEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.pnlEnd.SuspendLayout();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).BeginInit();
            this.xGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEnd
            // 
            this.pnlEnd.Controls.Add(this.pnlFill);
            this.pnlEnd.Controls.Add(this.pnlTop);
            this.pnlEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEnd.Location = new System.Drawing.Point(0, 0);
            this.pnlEnd.Name = "pnlEnd";
            this.pnlEnd.Size = new System.Drawing.Size(722, 398);
            this.pnlEnd.TabIndex = 0;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.grdData);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 91);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(722, 307);
            this.pnlFill.TabIndex = 1;
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
            this.grdData.Size = new System.Drawing.Size(722, 307);
            this.grdData.TabIndex = 1;
            this.grdData.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.xGroupBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(722, 91);
            this.pnlTop.TabIndex = 0;
            // 
            // xGroupBox1
            // 
            this.xGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xGroupBox1.Controls.Add(this.btnImport);
            this.xGroupBox1.Controls.Add(this.proImport);
            this.xGroupBox1.Controls.Add(this.xLabel2);
            this.xGroupBox1.Controls.Add(this.txtFileName);
            this.xGroupBox1.Controls.Add(this.xLabel1);
            this.xGroupBox1.Location = new System.Drawing.Point(5, 2);
            this.xGroupBox1.Name = "xGroupBox1";
            this.xGroupBox1.Size = new System.Drawing.Size(711, 82);
            this.xGroupBox1.TabIndex = 0;
            this.xGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.ImageIndex = 80;
            this.btnImport.ImageList = this.imageList;
            this.btnImport.Location = new System.Drawing.Point(626, 48);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "导入";
            this.btnImport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
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
            // proImport
            // 
            this.proImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.proImport.Location = new System.Drawing.Point(69, 48);
            this.proImport.Name = "proImport";
            this.proImport.Size = new System.Drawing.Size(553, 23);
            this.proImport.TabIndex = 3;
            this.proImport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(10, 51);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(56, 17);
            this.xLabel2.TabIndex = 2;
            this.xLabel2.Text = "导入进度";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtFileName.IsAllowEmpty = false;
            this.txtFileName.Location = new System.Drawing.Point(69, 18);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(633, 23);
            this.txtFileName.TabIndex = 1;
            this.txtFileName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtFileName.ButtonClick += new System.EventHandler(this.ebFileName_ButtonClick);
            this.txtFileName.DoubleClick += new System.EventHandler(this.txtFileName_DoubleClick);
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(10, 20);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 0;
            this.xLabel1.Text = "选择文件";
            // 
            // frmImportListBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 398);
            this.Controls.Add(this.pnlEnd);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmImportListBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmImportList";
            this.pnlEnd.ResumeLayout(false);
            this.pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).EndInit();
            this.xGroupBox1.ResumeLayout(false);
            this.xGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected Component.XGridEx grdData;
        protected System.Windows.Forms.ImageList imageList;
        protected System.Windows.Forms.Panel pnlEnd;
        protected System.Windows.Forms.Panel pnlFill;
        protected System.Windows.Forms.Panel pnlTop;
        protected Component.XGroupBox xGroupBox1;
        protected Component.XLabel xLabel1;
        protected Component.XEditBox txtFileName;
        protected Component.XLabel xLabel2;
        protected Component.XButton btnImport;
        protected Component.XProgressBar proImport;
    }
}