namespace MMIS.UI
{
    partial class frmRoleMenusList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoleMenusList));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grdData = new MMIS.Component.XGridEx();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtName = new MMIS.Component.XQueryEditBox();
            this.txtCode = new MMIS.Component.XQueryEditBox();
            this.lblRoleName = new MMIS.Component.XLabel();
            this.lblRoleCode = new MMIS.Component.XLabel();
            this.btnQuery = new MMIS.Component.XButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvRole = new MMIS.Component.XCheckTreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExpand = new MMIS.Component.XButton();
            this.btnCollapse = new MMIS.Component.XButton();
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
            this.splitContainer1.SplitterDistance = 557;
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
            this.grdData.Size = new System.Drawing.Size(557, 379);
            this.grdData.TabIndex = 1;
            this.grdData.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdData.Click += new System.EventHandler(this.grdData_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtName);
            this.pnlTop.Controls.Add(this.txtCode);
            this.pnlTop.Controls.Add(this.lblRoleName);
            this.pnlTop.Controls.Add(this.lblRoleCode);
            this.pnlTop.Controls.Add(this.btnQuery);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(557, 42);
            this.pnlTop.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.IsAllowEmpty = false;
            this.txtName.Location = new System.Drawing.Point(274, 10);
            this.txtName.Name = "txtName";
            this.txtName.QueryCheckBox = null;
            this.txtName.QueryFieldName = "RoleName";
            this.txtName.QueryOperateType = MMIS.Component.XQueryOperateType.Contain;
            this.txtName.Size = new System.Drawing.Size(135, 23);
            this.txtName.TabIndex = 1011;
            this.txtName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCode
            // 
            this.txtCode.IsAllowEmpty = true;
            this.txtCode.Location = new System.Drawing.Point(73, 10);
            this.txtCode.Name = "txtCode";
            this.txtCode.QueryCheckBox = null;
            this.txtCode.QueryFieldName = "RoleCode";
            this.txtCode.QueryOperateType = MMIS.Component.XQueryOperateType.Contain;
            this.txtCode.Size = new System.Drawing.Size(135, 23);
            this.txtCode.TabIndex = 1010;
            this.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.ForeColor = System.Drawing.Color.Black;
            this.lblRoleName.Location = new System.Drawing.Point(214, 13);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(56, 17);
            this.lblRoleName.TabIndex = 1009;
            this.lblRoleName.Text = "角色名称";
            // 
            // lblRoleCode
            // 
            this.lblRoleCode.AutoSize = true;
            this.lblRoleCode.ForeColor = System.Drawing.Color.Black;
            this.lblRoleCode.Location = new System.Drawing.Point(11, 13);
            this.lblRoleCode.Name = "lblRoleCode";
            this.lblRoleCode.Size = new System.Drawing.Size(56, 17);
            this.lblRoleCode.TabIndex = 1008;
            this.lblRoleCode.Text = "角色编码";
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
            this.panel2.Size = new System.Drawing.Size(371, 379);
            this.panel2.TabIndex = 2;
            // 
            // tvRole
            // 
            this.tvRole.CheckBoxes = true;
            this.tvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRole.IsHaveTitleRootNode = true;
            this.tvRole.Location = new System.Drawing.Point(0, 0);
            this.tvRole.Name = "tvRole";
            this.tvRole.RootTitle = "";
            this.tvRole.Size = new System.Drawing.Size(371, 379);
            this.tvRole.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExpand);
            this.panel1.Controls.Add(this.btnCollapse);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 42);
            this.panel1.TabIndex = 1;
            // 
            // btnExpand
            // 
            this.btnExpand.ImageIndex = 113;
            this.btnExpand.Location = new System.Drawing.Point(81, 9);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(67, 25);
            this.btnExpand.TabIndex = 104;
            this.btnExpand.Text = "展开";
            this.btnExpand.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.ImageIndex = 113;
            this.btnCollapse.Location = new System.Drawing.Point(8, 9);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(67, 25);
            this.btnCollapse.TabIndex = 103;
            this.btnCollapse.Text = "折叠";
            this.btnCollapse.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
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
            // frmRoleMenusList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 421);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRoleMenusList";
            this.Text = "角色权限";
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
        protected Component.XGridEx grdData;
        private System.Windows.Forms.Panel pnlTop;
        protected Component.XButton btnQuery;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        public Component.XButton btnSave;
        private Component.XQueryEditBox txtName;
        private Component.XQueryEditBox txtCode;
        private Component.XLabel lblRoleName;
        private Component.XLabel lblRoleCode;
        public Component.XButton btnExpand;
        public Component.XButton btnCollapse;
        private Component.XCheckTreeView tvRole;
    }
}