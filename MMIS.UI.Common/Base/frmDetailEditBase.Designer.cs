namespace MMIS.UI.Common
{
    partial class frmDetailEditBase
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
            Janus.Windows.GridEX.GridEXLayout grdDetail_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.xGroupBox1 = new MMIS.Component.XGroupBox();
            this.btnDeleteDetail = new MMIS.Component.XButton();
            this.btnEditDetail = new MMIS.Component.XButton();
            this.btnAddDetail = new MMIS.Component.XButton();
            this.grdDetail = new MMIS.Component.XGridEx();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).BeginInit();
            this.xGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(386, 345);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(473, 345);
            // 
            // xGroupBox1
            // 
            this.xGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xGroupBox1.Controls.Add(this.btnDeleteDetail);
            this.xGroupBox1.Controls.Add(this.btnEditDetail);
            this.xGroupBox1.Controls.Add(this.btnAddDetail);
            this.xGroupBox1.Controls.Add(this.grdDetail);
            this.xGroupBox1.Location = new System.Drawing.Point(7, 149);
            this.xGroupBox1.Name = "xGroupBox1";
            this.xGroupBox1.Size = new System.Drawing.Size(543, 187);
            this.xGroupBox1.TabIndex = 2;
            this.xGroupBox1.Text = "明细信息";
            this.xGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Location = new System.Drawing.Point(458, 77);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDetail.TabIndex = 3;
            this.btnDeleteDetail.Text = "删除";
            this.btnDeleteDetail.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // btnEditDetail
            // 
            this.btnEditDetail.Location = new System.Drawing.Point(458, 48);
            this.btnEditDetail.Name = "btnEditDetail";
            this.btnEditDetail.Size = new System.Drawing.Size(75, 23);
            this.btnEditDetail.TabIndex = 2;
            this.btnEditDetail.Text = "修改";
            this.btnEditDetail.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnEditDetail.Click += new System.EventHandler(this.btnEditDetail_Click);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(458, 19);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(75, 23);
            this.btnAddDetail.TabIndex = 1;
            this.btnAddDetail.Text = "添加";
            this.btnAddDetail.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // grdDetail
            // 
            this.grdDetail.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            grdDetail_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>";
            this.grdDetail.DesignTimeLayout = grdDetail_DesignTimeLayout;
            this.grdDetail.GroupByBoxVisible = false;
            this.grdDetail.Location = new System.Drawing.Point(8, 19);
            this.grdDetail.Name = "grdDetail";
            this.grdDetail.Size = new System.Drawing.Size(441, 159);
            this.grdDetail.TabIndex = 0;
            this.grdDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmDetailEditBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 384);
            this.Controls.Add(this.xGroupBox1);
            this.Name = "frmDetailEditBase";
            this.Text = "frmDetailEditBase";
            this.Controls.SetChildIndex(this.xGroupBox1, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).EndInit();
            this.xGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected MMIS.Component.XGroupBox xGroupBox1;
        protected MMIS.Component.XGridEx grdDetail;
        protected MMIS.Component.XButton btnAddDetail;
        protected MMIS.Component.XButton btnDeleteDetail;
        protected MMIS.Component.XButton btnEditDetail;
    }
}