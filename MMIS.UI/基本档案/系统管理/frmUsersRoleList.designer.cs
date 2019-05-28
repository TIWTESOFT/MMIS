namespace MMIS.UI
{
    partial class frmUsersRoleList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersRoleList));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdData = new MMIS.Component.XGridEx();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtName = new MMIS.Component.XQueryEditBox();
            this.txtCode = new MMIS.Component.XQueryEditBox();
            this.lblDeptCode = new MMIS.Component.XLabel();
            this.lblDeptName = new MMIS.Component.XLabel();
            this.btnQuery = new MMIS.Component.XButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvRole = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeSelect = new MMIS.Component.XButton();
            this.btnSelectAll = new MMIS.Component.XButton();
            this.btnSave = new MMIS.Component.XButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(932, 421);
            this.splitContainer1.SplitterDistance = 636;
            this.splitContainer1.TabIndex = 0;
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
            this.grdData.Size = new System.Drawing.Size(636, 379);
            this.grdData.TabIndex = 1;
            this.grdData.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdData.Click += new System.EventHandler(this.grdData_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtName);
            this.pnlTop.Controls.Add(this.txtCode);
            this.pnlTop.Controls.Add(this.lblDeptCode);
            this.pnlTop.Controls.Add(this.lblDeptName);
            this.pnlTop.Controls.Add(this.btnQuery);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(636, 42);
            this.pnlTop.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.IsAllowEmpty = false;
            this.txtName.Location = new System.Drawing.Point(237, 10);
            this.txtName.Name = "txtName";
            this.txtName.QueryCheckBox = null;
            this.txtName.QueryFieldName = "UserName";
            this.txtName.QueryOperateType = MMIS.Component.XQueryOperateType.Contain;
            this.txtName.Size = new System.Drawing.Size(173, 23);
            this.txtName.TabIndex = 1024;
            this.txtName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCode
            // 
            this.txtCode.IsAllowEmpty = false;
            this.txtCode.Location = new System.Drawing.Point(47, 10);
            this.txtCode.Name = "txtCode";
            this.txtCode.QueryCheckBox = null;
            this.txtCode.QueryFieldName = "UserId";
            this.txtCode.QueryOperateType = MMIS.Component.XQueryOperateType.Contain;
            this.txtCode.Size = new System.Drawing.Size(122, 23);
            this.txtCode.TabIndex = 1023;
            this.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblDeptCode
            // 
            this.lblDeptCode.AutoSize = true;
            this.lblDeptCode.ForeColor = System.Drawing.Color.Black;
            this.lblDeptCode.Location = new System.Drawing.Point(2, 13);
            this.lblDeptCode.Name = "lblDeptCode";
            this.lblDeptCode.Size = new System.Drawing.Size(44, 17);
            this.lblDeptCode.TabIndex = 1021;
            this.lblDeptCode.Text = "用户Id";
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.ForeColor = System.Drawing.Color.Black;
            this.lblDeptName.Location = new System.Drawing.Point(175, 13);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(56, 17);
            this.lblDeptName.TabIndex = 1022;
            this.lblDeptName.Text = "用户名称";
            // 
            // btnQuery
            // 
            this.btnQuery.ImageIndex = 118;
            this.btnQuery.Location = new System.Drawing.Point(416, 9);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(67, 25);
            this.btnQuery.TabIndex = 1007;
            this.btnQuery.Text = "查询";
            this.btnQuery.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvRole);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 379);
            this.panel2.TabIndex = 2;
            // 
            // tvRole
            // 
            this.tvRole.CheckBoxes = true;
            this.tvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRole.Location = new System.Drawing.Point(0, 0);
            this.tvRole.Name = "tvRole";
            this.tvRole.Size = new System.Drawing.Size(292, 379);
            this.tvRole.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeSelect);
            this.panel1.Controls.Add(this.btnSelectAll);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 42);
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
            // frmUsersRoleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 421);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmUsersRoleList";
            this.Text = "用户角色";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlTop;
        protected Component.XGridEx grdData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvRole;
        public Component.XButton btnSave;
        protected Component.XButton btnQuery;
        private Component.XQueryEditBox txtName;
        private Component.XQueryEditBox txtCode;
        private Component.XLabel lblDeptCode;
        private Component.XLabel lblDeptName;
        private System.Windows.Forms.Panel panel2;
        public Component.XButton btnDeSelect;
        public Component.XButton btnSelectAll;
    }
}