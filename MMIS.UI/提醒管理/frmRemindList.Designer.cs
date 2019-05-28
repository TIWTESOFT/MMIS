namespace MMIS.UI
{
    partial class frmRemindList
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
            Janus.Windows.GridEX.GridEXLayout grdVoucher_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemindList));
            Janus.Windows.GridEX.GridEXLayout grdTaskToDo_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.pnlAll = new System.Windows.Forms.Panel();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.btnRefreshVoucherRemind = new MMIS.Component.XButton();
            this.grdVoucher = new MMIS.Component.XGridEx();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnRefreshTaskToDo = new MMIS.Component.XButton();
            this.grdTaskToDo = new MMIS.Component.XGridEx();
            this.pnlAll.SuspendLayout();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVoucher)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskToDo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAll
            // 
            this.pnlAll.Controls.Add(this.pnlFill);
            this.pnlAll.Controls.Add(this.splitter1);
            this.pnlAll.Controls.Add(this.pnlTop);
            this.pnlAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAll.Location = new System.Drawing.Point(0, 0);
            this.pnlAll.Name = "pnlAll";
            this.pnlAll.Size = new System.Drawing.Size(656, 430);
            this.pnlAll.TabIndex = 0;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.btnRefreshVoucherRemind);
            this.pnlFill.Controls.Add(this.grdVoucher);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 290);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(656, 140);
            this.pnlFill.TabIndex = 2;
            // 
            // btnRefreshVoucherRemind
            // 
            this.btnRefreshVoucherRemind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshVoucherRemind.Location = new System.Drawing.Point(574, 6);
            this.btnRefreshVoucherRemind.Name = "btnRefreshVoucherRemind";
            this.btnRefreshVoucherRemind.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshVoucherRemind.TabIndex = 2;
            this.btnRefreshVoucherRemind.Text = "刷新";
            this.btnRefreshVoucherRemind.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnRefreshVoucherRemind.Click += new System.EventHandler(this.btnRefreshVoucherRemind_Click);
            // 
            // grdVoucher
            // 
            this.grdVoucher.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdVoucher.AlternatingColors = true;
            this.grdVoucher.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>单据提醒信息" +
    "</GroupByBoxInfo></LocalizableData>";
            grdVoucher_DesignTimeLayout.LayoutString = resources.GetString("grdVoucher_DesignTimeLayout.LayoutString");
            this.grdVoucher.DesignTimeLayout = grdVoucher_DesignTimeLayout;
            this.grdVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdVoucher.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.grdVoucher.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.grdVoucher.Location = new System.Drawing.Point(0, 0);
            this.grdVoucher.Name = "grdVoucher";
            this.grdVoucher.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.grdVoucher.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdVoucher.Size = new System.Drawing.Size(656, 140);
            this.grdVoucher.TabIndex = 1;
            this.grdVoucher.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 287);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(656, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnRefreshTaskToDo);
            this.pnlTop.Controls.Add(this.grdTaskToDo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(656, 287);
            this.pnlTop.TabIndex = 0;
            // 
            // btnRefreshTaskToDo
            // 
            this.btnRefreshTaskToDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshTaskToDo.Location = new System.Drawing.Point(574, 6);
            this.btnRefreshTaskToDo.Name = "btnRefreshTaskToDo";
            this.btnRefreshTaskToDo.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshTaskToDo.TabIndex = 3;
            this.btnRefreshTaskToDo.Text = "刷新";
            this.btnRefreshTaskToDo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnRefreshTaskToDo.Click += new System.EventHandler(this.btnRefreshTaskToDo_Click);
            // 
            // grdTaskToDo
            // 
            this.grdTaskToDo.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdTaskToDo.AlternatingColors = true;
            this.grdTaskToDo.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>待办任务</" +
    "GroupByBoxInfo></LocalizableData>";
            grdTaskToDo_DesignTimeLayout.LayoutString = resources.GetString("grdTaskToDo_DesignTimeLayout.LayoutString");
            this.grdTaskToDo.DesignTimeLayout = grdTaskToDo_DesignTimeLayout;
            this.grdTaskToDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTaskToDo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.grdTaskToDo.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.grdTaskToDo.Location = new System.Drawing.Point(0, 0);
            this.grdTaskToDo.Name = "grdTaskToDo";
            this.grdTaskToDo.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.grdTaskToDo.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdTaskToDo.Size = new System.Drawing.Size(656, 287);
            this.grdTaskToDo.TabIndex = 0;
            this.grdTaskToDo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmRemindList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 430);
            this.Controls.Add(this.pnlAll);
            this.Name = "frmRemindList";
            this.Text = "提醒信息";
            this.pnlAll.ResumeLayout(false);
            this.pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVoucher)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskToDo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAll;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlFill;
        private Component.XGridEx grdTaskToDo;
        private Component.XGridEx grdVoucher;
        private Component.XButton btnRefreshVoucherRemind;
        private Component.XButton btnRefreshTaskToDo;
    }
}