namespace MMIS.UI
{
    partial class frmUseDeptTreeList
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
            this.txtDeptName = new MMIS.Component.XEditBox();
            this.nebNameNum = new MMIS.Component.XNumberEditBox();
            this.txtSpell = new MMIS.Component.XEditBox();
            this.txtSpellHeader = new MMIS.Component.XEditBox();
            this.chkIsUsed = new MMIS.Component.XCheckBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.lblDeptName = new MMIS.Component.XLabel();
            this.lblNameNum = new MMIS.Component.XLabel();
            this.lblSpell = new MMIS.Component.XLabel();
            this.lblSpellHeader = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmRight)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 130);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.txtDeptName);
            this.pnlEdit.Controls.Add(this.nebNameNum);
            this.pnlEdit.Controls.Add(this.txtSpell);
            this.pnlEdit.Controls.Add(this.txtSpellHeader);
            this.pnlEdit.Controls.Add(this.chkIsUsed);
            this.pnlEdit.Controls.Add(this.txtRemark);
            this.pnlEdit.Controls.Add(this.lblDeptName);
            this.pnlEdit.Controls.Add(this.lblNameNum);
            this.pnlEdit.Controls.Add(this.lblSpell);
            this.pnlEdit.Controls.Add(this.lblSpellHeader);
            this.pnlEdit.Controls.Add(this.lblRemark);
            this.pnlEdit.Location = new System.Drawing.Point(415, 28);
            this.pnlEdit.Size = new System.Drawing.Size(271, 382);
            this.pnlEdit.Controls.SetChildIndex(this.label1, 0);
            this.pnlEdit.Controls.SetChildIndex(this.txtParentNode, 0);
            this.pnlEdit.Controls.SetChildIndex(this.btnSave, 0);
            this.pnlEdit.Controls.SetChildIndex(this.chkRootNode, 0);
            this.pnlEdit.Controls.SetChildIndex(this.lblRemark, 0);
            this.pnlEdit.Controls.SetChildIndex(this.lblSpellHeader, 0);
            this.pnlEdit.Controls.SetChildIndex(this.lblSpell, 0);
            this.pnlEdit.Controls.SetChildIndex(this.lblNameNum, 0);
            this.pnlEdit.Controls.SetChildIndex(this.lblDeptName, 0);
            this.pnlEdit.Controls.SetChildIndex(this.txtRemark, 0);
            this.pnlEdit.Controls.SetChildIndex(this.chkIsUsed, 0);
            this.pnlEdit.Controls.SetChildIndex(this.txtSpellHeader, 0);
            this.pnlEdit.Controls.SetChildIndex(this.txtSpell, 0);
            this.pnlEdit.Controls.SetChildIndex(this.nebNameNum, 0);
            this.pnlEdit.Controls.SetChildIndex(this.txtDeptName, 0);
            // 
            // treeView
            // 
            this.treeView.LineColor = System.Drawing.Color.Black;
            this.treeView.Size = new System.Drawing.Size(412, 382);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Text = "上级部门";
            // 
            // txtParentNode
            // 
            this.txtParentNode.Location = new System.Drawing.Point(71, 36);
            this.txtParentNode.Size = new System.Drawing.Size(185, 23);
            // 
            // txtDeptName
            // 
            this.txtDeptName.IsAllowEmpty = false;
            this.txtDeptName.Location = new System.Drawing.Point(71, 69);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(185, 23);
            this.txtDeptName.TabIndex = 102;
            this.txtDeptName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtDeptName.Leave += new System.EventHandler(this.txtDeptName_Leave);
            // 
            // nebNameNum
            // 
            this.nebNameNum.FormatString = "0";
            this.nebNameNum.IsAllowEmpty = false;
            this.nebNameNum.IsAllowLessThanZero = false;
            this.nebNameNum.IsAllowZero = true;
            this.nebNameNum.Location = new System.Drawing.Point(85, 276);
            this.nebNameNum.Name = "nebNameNum";
            this.nebNameNum.Size = new System.Drawing.Size(185, 23);
            this.nebNameNum.TabIndex = 112;
            this.nebNameNum.Text = "0";
            this.nebNameNum.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebNameNum.Visible = false;
            this.nebNameNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpell
            // 
            this.txtSpell.IsAllowEmpty = false;
            this.txtSpell.Location = new System.Drawing.Point(85, 306);
            this.txtSpell.Name = "txtSpell";
            this.txtSpell.Size = new System.Drawing.Size(185, 23);
            this.txtSpell.TabIndex = 105;
            this.txtSpell.Visible = false;
            this.txtSpell.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpellHeader
            // 
            this.txtSpellHeader.IsAllowEmpty = false;
            this.txtSpellHeader.Location = new System.Drawing.Point(85, 336);
            this.txtSpellHeader.Name = "txtSpellHeader";
            this.txtSpellHeader.Size = new System.Drawing.Size(185, 23);
            this.txtSpellHeader.TabIndex = 107;
            this.txtSpellHeader.Visible = false;
            this.txtSpellHeader.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // chkIsUsed
            // 
            this.chkIsUsed.Location = new System.Drawing.Point(48, 305);
            this.chkIsUsed.Model = null;
            this.chkIsUsed.Name = "chkIsUsed";
            this.chkIsUsed.Size = new System.Drawing.Size(185, 23);
            this.chkIsUsed.TabIndex = 109;
            this.chkIsUsed.Text = "是否可用";
            this.chkIsUsed.Visible = false;
            this.chkIsUsed.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(71, 101);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(185, 23);
            this.txtRemark.TabIndex = 110;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.ForeColor = System.Drawing.Color.Black;
            this.lblDeptName.Location = new System.Drawing.Point(9, 72);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(56, 17);
            this.lblDeptName.TabIndex = 103;
            this.lblDeptName.Text = "部门名称";
            // 
            // lblNameNum
            // 
            this.lblNameNum.AutoSize = true;
            this.lblNameNum.ForeColor = System.Drawing.Color.Black;
            this.lblNameNum.Location = new System.Drawing.Point(23, 279);
            this.lblNameNum.Name = "lblNameNum";
            this.lblNameNum.Size = new System.Drawing.Size(56, 17);
            this.lblNameNum.TabIndex = 104;
            this.lblNameNum.Text = "数值代码";
            this.lblNameNum.Visible = false;
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.ForeColor = System.Drawing.Color.Black;
            this.lblSpell.Location = new System.Drawing.Point(23, 309);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(32, 17);
            this.lblSpell.TabIndex = 106;
            this.lblSpell.Text = "拼音";
            this.lblSpell.Visible = false;
            // 
            // lblSpellHeader
            // 
            this.lblSpellHeader.AutoSize = true;
            this.lblSpellHeader.ForeColor = System.Drawing.Color.Black;
            this.lblSpellHeader.Location = new System.Drawing.Point(23, 339);
            this.lblSpellHeader.Name = "lblSpellHeader";
            this.lblSpellHeader.Size = new System.Drawing.Size(44, 17);
            this.lblSpellHeader.TabIndex = 108;
            this.lblSpellHeader.Text = "拼音头";
            this.lblSpellHeader.Visible = false;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(9, 104);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 111;
            this.lblRemark.Text = "备注信息";
            // 
            // frmUseDeptTreeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 410);
            this.Name = "frmUseDeptTreeList";
            this.Text = "部门档案";
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmRight)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Component.XEditBox txtDeptName;
        private Component.XNumberEditBox nebNameNum;
        private Component.XEditBox txtSpell;
        private Component.XEditBox txtSpellHeader;
        private Component.XCheckBox chkIsUsed;
        private Component.XEditBox txtRemark;
        private Component.XLabel lblDeptName;
        private Component.XLabel lblNameNum;
        private Component.XLabel lblSpell;
        private Component.XLabel lblSpellHeader;
        private Component.XLabel lblRemark;
    }
}