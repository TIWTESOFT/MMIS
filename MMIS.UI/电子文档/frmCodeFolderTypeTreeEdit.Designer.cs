namespace MMIS.UI
{
    partial class frmCodeFolderTypeTreeEdit
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
            this.txtNameEN = new MMIS.Component.XEditBox();
            this.txtNameCN = new MMIS.Component.XEditBox();
            this.txtNameBig5 = new MMIS.Component.XEditBox();
            this.txtCode = new MMIS.Component.XEditBox();
            this.nebCodeNum = new MMIS.Component.XNumberEditBox();
            this.txtCodeEN = new MMIS.Component.XEditBox();
            this.txtSpell = new MMIS.Component.XEditBox();
            this.txtSpellHeader = new MMIS.Component.XEditBox();
            this.nebProirNum = new MMIS.Component.XNumberEditBox();
            this.chkIsUsed = new MMIS.Component.XCheckBox();
            this.txtParentID = new MMIS.Component.XEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.lblNameEN = new MMIS.Component.XLabel();
            this.lblNameCN = new MMIS.Component.XLabel();
            this.lblNameBig5 = new MMIS.Component.XLabel();
            this.lblCode = new MMIS.Component.XLabel();
            this.lblCodeNum = new MMIS.Component.XLabel();
            this.lblCodeEN = new MMIS.Component.XLabel();
            this.lblSpell = new MMIS.Component.XLabel();
            this.lblSpellHeader = new MMIS.Component.XLabel();
            this.lblProirNum = new MMIS.Component.XLabel();
            this.lblDeptId = new MMIS.Component.XLabel();
            this.lblParentID = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtDeptId = new MMIS.UI.XSelectUseDeptEditBox();
            this.SuspendLayout();
            // 
            // chkIsRootNode
            // 
            this.chkIsRootNode.Location = new System.Drawing.Point(17, 11);
            this.chkIsRootNode.Size = new System.Drawing.Size(129, 23);
            this.chkIsRootNode.TabIndex = 0;
            this.chkIsRootNode.Text = "是否第一级文件夹";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(360, 105);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(447, 105);
            // 
            // txtNameEN
            // 
            this.txtNameEN.IsAllowEmpty = true;
            this.txtNameEN.Location = new System.Drawing.Point(337, 41);
            this.txtNameEN.Name = "txtNameEN";
            this.txtNameEN.Size = new System.Drawing.Size(185, 23);
            this.txtNameEN.TabIndex = 2;
            this.txtNameEN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtNameCN
            // 
            this.txtNameCN.IsAllowEmpty = false;
            this.txtNameCN.Location = new System.Drawing.Point(77, 41);
            this.txtNameCN.Name = "txtNameCN";
            this.txtNameCN.Size = new System.Drawing.Size(185, 23);
            this.txtNameCN.TabIndex = 1;
            this.txtNameCN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtNameBig5
            // 
            this.txtNameBig5.IsAllowEmpty = true;
            this.txtNameBig5.Location = new System.Drawing.Point(77, 227);
            this.txtNameBig5.Name = "txtNameBig5";
            this.txtNameBig5.Size = new System.Drawing.Size(185, 23);
            this.txtNameBig5.TabIndex = 158;
            this.txtNameBig5.Visible = false;
            this.txtNameBig5.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCode
            // 
            this.txtCode.IsAllowEmpty = true;
            this.txtCode.Location = new System.Drawing.Point(337, 227);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(185, 23);
            this.txtCode.TabIndex = 159;
            this.txtCode.Visible = false;
            this.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebCodeNum
            // 
            this.nebCodeNum.FormatString = "0";
            this.nebCodeNum.IsAllowEmpty = false;
            this.nebCodeNum.IsAllowLessThanZero = false;
            this.nebCodeNum.IsAllowZero = true;
            this.nebCodeNum.Location = new System.Drawing.Point(77, 258);
            this.nebCodeNum.Name = "nebCodeNum";
            this.nebCodeNum.Size = new System.Drawing.Size(105, 23);
            this.nebCodeNum.TabIndex = 160;
            this.nebCodeNum.Text = "0";
            this.nebCodeNum.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebCodeNum.Visible = false;
            this.nebCodeNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCodeEN
            // 
            this.txtCodeEN.IsAllowEmpty = true;
            this.txtCodeEN.Location = new System.Drawing.Point(259, 258);
            this.txtCodeEN.Name = "txtCodeEN";
            this.txtCodeEN.Size = new System.Drawing.Size(118, 23);
            this.txtCodeEN.TabIndex = 161;
            this.txtCodeEN.Visible = false;
            this.txtCodeEN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpell
            // 
            this.txtSpell.IsAllowEmpty = false;
            this.txtSpell.Location = new System.Drawing.Point(77, 289);
            this.txtSpell.Name = "txtSpell";
            this.txtSpell.Size = new System.Drawing.Size(185, 23);
            this.txtSpell.TabIndex = 163;
            this.txtSpell.Visible = false;
            this.txtSpell.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpellHeader
            // 
            this.txtSpellHeader.IsAllowEmpty = false;
            this.txtSpellHeader.Location = new System.Drawing.Point(337, 289);
            this.txtSpellHeader.Name = "txtSpellHeader";
            this.txtSpellHeader.Size = new System.Drawing.Size(185, 23);
            this.txtSpellHeader.TabIndex = 164;
            this.txtSpellHeader.Visible = false;
            this.txtSpellHeader.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebProirNum
            // 
            this.nebProirNum.FormatString = "0";
            this.nebProirNum.IsAllowEmpty = false;
            this.nebProirNum.IsAllowLessThanZero = false;
            this.nebProirNum.IsAllowZero = true;
            this.nebProirNum.Location = new System.Drawing.Point(447, 258);
            this.nebProirNum.Name = "nebProirNum";
            this.nebProirNum.Size = new System.Drawing.Size(75, 23);
            this.nebProirNum.TabIndex = 162;
            this.nebProirNum.Text = "0";
            this.nebProirNum.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebProirNum.Visible = false;
            this.nebProirNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // chkIsUsed
            // 
            this.chkIsUsed.Location = new System.Drawing.Point(17, 117);
            this.chkIsUsed.Model = null;
            this.chkIsUsed.Name = "chkIsUsed";
            this.chkIsUsed.Size = new System.Drawing.Size(68, 23);
            this.chkIsUsed.TabIndex = 176;
            this.chkIsUsed.Text = "是否可用";
            this.chkIsUsed.Visible = false;
            this.chkIsUsed.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtParentID
            // 
            this.txtParentID.IsAllowEmpty = true;
            this.txtParentID.Location = new System.Drawing.Point(88, 388);
            this.txtParentID.Name = "txtParentID";
            this.txtParentID.Size = new System.Drawing.Size(185, 23);
            this.txtParentID.TabIndex = 178;
            this.txtParentID.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(77, 73);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(445, 23);
            this.txtRemark.TabIndex = 3;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblNameEN
            // 
            this.lblNameEN.AutoSize = true;
            this.lblNameEN.ForeColor = System.Drawing.Color.Black;
            this.lblNameEN.Location = new System.Drawing.Point(275, 44);
            this.lblNameEN.Name = "lblNameEN";
            this.lblNameEN.Size = new System.Drawing.Size(56, 17);
            this.lblNameEN.TabIndex = 166;
            this.lblNameEN.Text = "英文名称";
            // 
            // lblNameCN
            // 
            this.lblNameCN.AutoSize = true;
            this.lblNameCN.ForeColor = System.Drawing.Color.Black;
            this.lblNameCN.Location = new System.Drawing.Point(15, 44);
            this.lblNameCN.Name = "lblNameCN";
            this.lblNameCN.Size = new System.Drawing.Size(56, 17);
            this.lblNameCN.TabIndex = 167;
            this.lblNameCN.Text = "中文名称";
            // 
            // lblNameBig5
            // 
            this.lblNameBig5.AutoSize = true;
            this.lblNameBig5.ForeColor = System.Drawing.Color.Black;
            this.lblNameBig5.Location = new System.Drawing.Point(15, 230);
            this.lblNameBig5.Name = "lblNameBig5";
            this.lblNameBig5.Size = new System.Drawing.Size(56, 17);
            this.lblNameBig5.TabIndex = 168;
            this.lblNameBig5.Text = "繁体名称";
            this.lblNameBig5.Visible = false;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.ForeColor = System.Drawing.Color.Black;
            this.lblCode.Location = new System.Drawing.Point(275, 230);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 17);
            this.lblCode.TabIndex = 169;
            this.lblCode.Text = "代码";
            this.lblCode.Visible = false;
            // 
            // lblCodeNum
            // 
            this.lblCodeNum.AutoSize = true;
            this.lblCodeNum.ForeColor = System.Drawing.Color.Black;
            this.lblCodeNum.Location = new System.Drawing.Point(15, 261);
            this.lblCodeNum.Name = "lblCodeNum";
            this.lblCodeNum.Size = new System.Drawing.Size(56, 17);
            this.lblCodeNum.TabIndex = 170;
            this.lblCodeNum.Text = "数字代码";
            this.lblCodeNum.Visible = false;
            // 
            // lblCodeEN
            // 
            this.lblCodeEN.AutoSize = true;
            this.lblCodeEN.ForeColor = System.Drawing.Color.Black;
            this.lblCodeEN.Location = new System.Drawing.Point(197, 261);
            this.lblCodeEN.Name = "lblCodeEN";
            this.lblCodeEN.Size = new System.Drawing.Size(56, 17);
            this.lblCodeEN.TabIndex = 171;
            this.lblCodeEN.Text = "字母代码";
            this.lblCodeEN.Visible = false;
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.ForeColor = System.Drawing.Color.Black;
            this.lblSpell.Location = new System.Drawing.Point(15, 292);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(32, 17);
            this.lblSpell.TabIndex = 172;
            this.lblSpell.Text = "拼音";
            this.lblSpell.Visible = false;
            // 
            // lblSpellHeader
            // 
            this.lblSpellHeader.AutoSize = true;
            this.lblSpellHeader.ForeColor = System.Drawing.Color.Black;
            this.lblSpellHeader.Location = new System.Drawing.Point(275, 292);
            this.lblSpellHeader.Name = "lblSpellHeader";
            this.lblSpellHeader.Size = new System.Drawing.Size(56, 17);
            this.lblSpellHeader.TabIndex = 173;
            this.lblSpellHeader.Text = "拼音缩写";
            this.lblSpellHeader.Visible = false;
            // 
            // lblProirNum
            // 
            this.lblProirNum.AutoSize = true;
            this.lblProirNum.ForeColor = System.Drawing.Color.Black;
            this.lblProirNum.Location = new System.Drawing.Point(385, 261);
            this.lblProirNum.Name = "lblProirNum";
            this.lblProirNum.Size = new System.Drawing.Size(44, 17);
            this.lblProirNum.TabIndex = 174;
            this.lblProirNum.Text = "顺序号";
            this.lblProirNum.Visible = false;
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.ForeColor = System.Drawing.Color.Black;
            this.lblDeptId.Location = new System.Drawing.Point(26, 362);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(56, 17);
            this.lblDeptId.TabIndex = 175;
            this.lblDeptId.Text = "部门名称";
            this.lblDeptId.Visible = false;
            // 
            // lblParentID
            // 
            this.lblParentID.AutoSize = true;
            this.lblParentID.ForeColor = System.Drawing.Color.Black;
            this.lblParentID.Location = new System.Drawing.Point(26, 391);
            this.lblParentID.Name = "lblParentID";
            this.lblParentID.Size = new System.Drawing.Size(56, 17);
            this.lblParentID.TabIndex = 177;
            this.lblParentID.Text = "上级节点";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(15, 76);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(32, 17);
            this.lblRemark.TabIndex = 179;
            this.lblRemark.Text = "备注";
            // 
            // txtDeptId
            // 
            this.txtDeptId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtDeptId.DisplayMember = "";
            this.txtDeptId.IsAllowEmpty = true;
            this.txtDeptId.Location = new System.Drawing.Point(88, 359);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.QueryCheckBox = null;
            this.txtDeptId.QueryFieldName = null;
            this.txtDeptId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtDeptId.ReadOnly = true;
            this.txtDeptId.SelectedModel = null;
            this.txtDeptId.Size = new System.Drawing.Size(185, 23);
            this.txtDeptId.TabIndex = 180;
            this.txtDeptId.ValueMember = "";
            this.txtDeptId.Visible = false;
            this.txtDeptId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmCodeFolderTypeTreeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 143);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.txtNameEN);
            this.Controls.Add(this.txtNameCN);
            this.Controls.Add(this.txtNameBig5);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.nebCodeNum);
            this.Controls.Add(this.txtCodeEN);
            this.Controls.Add(this.txtSpell);
            this.Controls.Add(this.txtSpellHeader);
            this.Controls.Add(this.nebProirNum);
            this.Controls.Add(this.chkIsUsed);
            this.Controls.Add(this.txtParentID);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblNameEN);
            this.Controls.Add(this.lblNameCN);
            this.Controls.Add(this.lblNameBig5);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblCodeNum);
            this.Controls.Add(this.lblCodeEN);
            this.Controls.Add(this.lblSpell);
            this.Controls.Add(this.lblSpellHeader);
            this.Controls.Add(this.lblProirNum);
            this.Controls.Add(this.lblDeptId);
            this.Controls.Add(this.lblParentID);
            this.Controls.Add(this.lblRemark);
            this.Name = "frmCodeFolderTypeTreeEdit";
            this.Text = "文件夹";
            this.Controls.SetChildIndex(this.chkIsRootNode, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblParentID, 0);
            this.Controls.SetChildIndex(this.lblDeptId, 0);
            this.Controls.SetChildIndex(this.lblProirNum, 0);
            this.Controls.SetChildIndex(this.lblSpellHeader, 0);
            this.Controls.SetChildIndex(this.lblSpell, 0);
            this.Controls.SetChildIndex(this.lblCodeEN, 0);
            this.Controls.SetChildIndex(this.lblCodeNum, 0);
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.Controls.SetChildIndex(this.lblNameBig5, 0);
            this.Controls.SetChildIndex(this.lblNameCN, 0);
            this.Controls.SetChildIndex(this.lblNameEN, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.txtParentID, 0);
            this.Controls.SetChildIndex(this.chkIsUsed, 0);
            this.Controls.SetChildIndex(this.nebProirNum, 0);
            this.Controls.SetChildIndex(this.txtSpellHeader, 0);
            this.Controls.SetChildIndex(this.txtSpell, 0);
            this.Controls.SetChildIndex(this.txtCodeEN, 0);
            this.Controls.SetChildIndex(this.nebCodeNum, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.Controls.SetChildIndex(this.txtNameBig5, 0);
            this.Controls.SetChildIndex(this.txtNameCN, 0);
            this.Controls.SetChildIndex(this.txtNameEN, 0);
            this.Controls.SetChildIndex(this.txtDeptId, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XSelectUseDeptEditBox txtDeptId;
        private Component.XEditBox txtNameEN;
        private Component.XEditBox txtNameCN;
        private Component.XEditBox txtNameBig5;
        private Component.XEditBox txtCode;
        private Component.XNumberEditBox nebCodeNum;
        private Component.XEditBox txtCodeEN;
        private Component.XEditBox txtSpell;
        private Component.XEditBox txtSpellHeader;
        private Component.XNumberEditBox nebProirNum;
        private Component.XCheckBox chkIsUsed;
        private Component.XEditBox txtParentID;
        private Component.XEditBox txtRemark;
        private Component.XLabel lblNameEN;
        private Component.XLabel lblNameCN;
        private Component.XLabel lblNameBig5;
        private Component.XLabel lblCode;
        private Component.XLabel lblCodeNum;
        private Component.XLabel lblCodeEN;
        private Component.XLabel lblSpell;
        private Component.XLabel lblSpellHeader;
        private Component.XLabel lblProirNum;
        private Component.XLabel lblDeptId;
        private Component.XLabel lblParentID;
        private Component.XLabel lblRemark;
    }
}