namespace MMIS.UI
{
    partial class frmRemindConfigList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemindConfigList));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdData = new MMIS.Component.XGridEx();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtCode = new MMIS.Component.XQueryEditBox();
            this.lblDeptCode = new MMIS.Component.XLabel();
            this.btnQuery = new MMIS.Component.XButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xTabControl1 = new MMIS.Component.XTabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.tvRole = new System.Windows.Forms.TreeView();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.tvUsers = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeSelect = new MMIS.Component.XButton();
            this.btnSelectAll = new MMIS.Component.XButton();
            this.btnSave = new MMIS.Component.XButton();
            this.btnEdit = new MMIS.Component.XButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xTabControl1)).BeginInit();
            this.xTabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grdData);
            this.splitContainer1.Panel1.Controls.Add(this.pnlTop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1001, 467);
            this.splitContainer1.SplitterDistance = 683;
            this.splitContainer1.TabIndex = 1;
            // 
            // grdData
            // 
            this.grdData.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdData.AlternatingColors = true;
            this.grdData.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>拖动列名至此" +
    "进行分组</GroupByBoxInfo></LocalizableData>";
            grdData_DesignTimeLayout.LayoutString = resources.GetString("grdData_DesignTimeLayout.LayoutString");
            this.grdData.DesignTimeLayout = grdData_DesignTimeLayout;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdData.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.grdData.Location = new System.Drawing.Point(0, 42);
            this.grdData.Name = "grdData";
            this.grdData.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.grdData.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdData.Size = new System.Drawing.Size(683, 425);
            this.grdData.TabIndex = 1;
            this.grdData.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdData.Click += new System.EventHandler(this.grdData_Click);
            this.grdData.DoubleClick += new System.EventHandler(this.grdData_DoubleClick);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnEdit);
            this.pnlTop.Controls.Add(this.txtCode);
            this.pnlTop.Controls.Add(this.lblDeptCode);
            this.pnlTop.Controls.Add(this.btnQuery);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(683, 42);
            this.pnlTop.TabIndex = 0;
            // 
            // txtCode
            // 
            this.txtCode.IsAllowEmpty = false;
            this.txtCode.Location = new System.Drawing.Point(71, 10);
            this.txtCode.Name = "txtCode";
            this.txtCode.QueryCheckBox = null;
            this.txtCode.QueryFieldName = "ConfigType";
            this.txtCode.QueryOperateType = MMIS.Component.XQueryOperateType.Contain;
            this.txtCode.Size = new System.Drawing.Size(105, 23);
            this.txtCode.TabIndex = 1023;
            this.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblDeptCode
            // 
            this.lblDeptCode.AutoSize = true;
            this.lblDeptCode.ForeColor = System.Drawing.Color.Black;
            this.lblDeptCode.Location = new System.Drawing.Point(9, 13);
            this.lblDeptCode.Name = "lblDeptCode";
            this.lblDeptCode.Size = new System.Drawing.Size(56, 17);
            this.lblDeptCode.TabIndex = 1021;
            this.lblDeptCode.Text = "提醒类型";
            // 
            // btnQuery
            // 
            this.btnQuery.ImageIndex = 118;
            this.btnQuery.Location = new System.Drawing.Point(180, 9);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(67, 25);
            this.btnQuery.TabIndex = 1007;
            this.btnQuery.Text = "查询";
            this.btnQuery.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xTabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 425);
            this.panel2.TabIndex = 2;
            // 
            // xTabControl1
            // 
            this.xTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xTabControl1.Name = "xTabControl1";
            this.xTabControl1.Size = new System.Drawing.Size(314, 425);
            this.xTabControl1.TabIndex = 0;
            this.xTabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            this.xTabControl1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007;
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.tvRole);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 25);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(312, 399);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "被提醒角色";
            // 
            // tvRole
            // 
            this.tvRole.CheckBoxes = true;
            this.tvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRole.Location = new System.Drawing.Point(0, 0);
            this.tvRole.Name = "tvRole";
            this.tvRole.Size = new System.Drawing.Size(312, 399);
            this.tvRole.TabIndex = 1;
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.tvUsers);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 25);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(312, 399);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "被提醒用户";
            // 
            // tvUsers
            // 
            this.tvUsers.CheckBoxes = true;
            this.tvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvUsers.Location = new System.Drawing.Point(0, 0);
            this.tvUsers.Name = "tvUsers";
            this.tvUsers.Size = new System.Drawing.Size(312, 399);
            this.tvUsers.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeSelect);
            this.panel1.Controls.Add(this.btnSelectAll);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 42);
            this.panel1.TabIndex = 1;
            // 
            // btnDeSelect
            // 
            this.btnDeSelect.ImageIndex = 113;
            this.btnDeSelect.Location = new System.Drawing.Point(81, 9);
            this.btnDeSelect.Name = "btnDeSelect";
            this.btnDeSelect.Size = new System.Drawing.Size(67, 25);
            this.btnDeSelect.TabIndex = 102;
            this.btnDeSelect.Text = "反选";
            this.btnDeSelect.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnDeSelect.Click += new System.EventHandler(this.btnDeSelect_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.ImageIndex = 113;
            this.btnSelectAll.Location = new System.Drawing.Point(8, 9);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(67, 25);
            this.btnSelectAll.TabIndex = 101;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageIndex = 113;
            this.btnSave.Location = new System.Drawing.Point(154, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 25);
            this.btnSave.TabIndex = 100;
            this.btnSave.Text = "保存";
            this.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageIndex = 118;
            this.btnEdit.Location = new System.Drawing.Point(253, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(67, 25);
            this.btnEdit.TabIndex = 1024;
            this.btnEdit.Text = "修改";
            this.btnEdit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmRemindConfigList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 467);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmRemindConfigList";
            this.Text = "提醒设置";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xTabControl1)).EndInit();
            this.xTabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        protected Component.XGridEx grdData;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public Component.XButton btnDeSelect;
        public Component.XButton btnSelectAll;
        public Component.XButton btnSave;
        private Component.XQueryEditBox txtCode;
        private Component.XLabel lblDeptCode;
        protected Component.XButton btnQuery;
        private Component.XTabControl xTabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private System.Windows.Forms.TreeView tvRole;
        private System.Windows.Forms.TreeView tvUsers;
        protected Component.XButton btnEdit;
    }
}