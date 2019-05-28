namespace MMIS.UI
{
    public partial class frmCodeEquipmentStateEdit
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
            this.txtDeptId = new MMIS.UI.XSelectUseDeptEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.txtParentID = new MMIS.Component.XEditBox();
            this.txtUserID = new MMIS.Component.XEditBox();
            this.lblDeptId = new MMIS.Component.XLabel();
            this.lblParentID = new MMIS.Component.XLabel();
            this.lblUserID = new MMIS.Component.XLabel();
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
            this.lblRemark = new MMIS.Component.XLabel();
            this.btnColor = new MMIS.Component.XColorButton();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(358, 105);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(445, 105);
            // 
            // txtDeptId
            // 
            this.txtDeptId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtDeptId.DisplayMember = "";
            this.txtDeptId.IsAllowEmpty = true;
            this.txtDeptId.Location = new System.Drawing.Point(75, 295);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.QueryCheckBox = null;
            this.txtDeptId.QueryFieldName = null;
            this.txtDeptId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtDeptId.ReadOnly = true;
            this.txtDeptId.SelectedModel = null;
            this.txtDeptId.Size = new System.Drawing.Size(185, 23);
            this.txtDeptId.TabIndex = 181;
            this.txtDeptId.ValueMember = "";
            this.txtDeptId.Visible = false;
            this.txtDeptId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(14, 74);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 182;
            this.xLabel1.Text = "颜色标识";
            // 
            // txtParentID
            // 
            this.txtParentID.IsAllowEmpty = true;
            this.txtParentID.Location = new System.Drawing.Point(75, 324);
            this.txtParentID.Name = "txtParentID";
            this.txtParentID.Size = new System.Drawing.Size(185, 23);
            this.txtParentID.TabIndex = 178;
            this.txtParentID.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtUserID
            // 
            this.txtUserID.IsAllowEmpty = false;
            this.txtUserID.Location = new System.Drawing.Point(75, 354);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(185, 23);
            this.txtUserID.TabIndex = 180;
            this.txtUserID.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.ForeColor = System.Drawing.Color.Black;
            this.lblDeptId.Location = new System.Drawing.Point(13, 298);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(56, 17);
            this.lblDeptId.TabIndex = 176;
            this.lblDeptId.Text = "部门名称";
            this.lblDeptId.Visible = false;
            // 
            // lblParentID
            // 
            this.lblParentID.AutoSize = true;
            this.lblParentID.ForeColor = System.Drawing.Color.Black;
            this.lblParentID.Location = new System.Drawing.Point(13, 327);
            this.lblParentID.Name = "lblParentID";
            this.lblParentID.Size = new System.Drawing.Size(56, 17);
            this.lblParentID.TabIndex = 177;
            this.lblParentID.Text = "上级节点";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.ForeColor = System.Drawing.Color.Black;
            this.lblUserID.Location = new System.Drawing.Point(13, 357);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(45, 17);
            this.lblUserID.TabIndex = 179;
            this.lblUserID.Text = "用户ID";
            // 
            // txtNameEN
            // 
            this.txtNameEN.IsAllowEmpty = true;
            this.txtNameEN.Location = new System.Drawing.Point(335, 12);
            this.txtNameEN.Name = "txtNameEN";
            this.txtNameEN.Size = new System.Drawing.Size(185, 23);
            this.txtNameEN.TabIndex = 1;
            this.txtNameEN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtNameCN
            // 
            this.txtNameCN.IsAllowEmpty = false;
            this.txtNameCN.Location = new System.Drawing.Point(75, 12);
            this.txtNameCN.Name = "txtNameCN";
            this.txtNameCN.Size = new System.Drawing.Size(185, 23);
            this.txtNameCN.TabIndex = 0;
            this.txtNameCN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtNameCN.Leave += new System.EventHandler(this.txtNameCN_Leave);
            // 
            // txtNameBig5
            // 
            this.txtNameBig5.IsAllowEmpty = true;
            this.txtNameBig5.Location = new System.Drawing.Point(75, 42);
            this.txtNameBig5.Name = "txtNameBig5";
            this.txtNameBig5.Size = new System.Drawing.Size(185, 23);
            this.txtNameBig5.TabIndex = 2;
            this.txtNameBig5.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCode
            // 
            this.txtCode.IsAllowEmpty = true;
            this.txtCode.Location = new System.Drawing.Point(335, 42);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(185, 23);
            this.txtCode.TabIndex = 3;
            this.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebCodeNum
            // 
            this.nebCodeNum.FormatString = "0";
            this.nebCodeNum.IsAllowEmpty = false;
            this.nebCodeNum.IsAllowLessThanZero = false;
            this.nebCodeNum.IsAllowZero = true;
            this.nebCodeNum.Location = new System.Drawing.Point(76, 225);
            this.nebCodeNum.Name = "nebCodeNum";
            this.nebCodeNum.Size = new System.Drawing.Size(105, 23);
            this.nebCodeNum.TabIndex = 4;
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
            this.txtCodeEN.Location = new System.Drawing.Point(258, 225);
            this.txtCodeEN.Name = "txtCodeEN";
            this.txtCodeEN.Size = new System.Drawing.Size(118, 23);
            this.txtCodeEN.TabIndex = 5;
            this.txtCodeEN.Visible = false;
            this.txtCodeEN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpell
            // 
            this.txtSpell.IsAllowEmpty = false;
            this.txtSpell.Location = new System.Drawing.Point(76, 256);
            this.txtSpell.Name = "txtSpell";
            this.txtSpell.Size = new System.Drawing.Size(185, 23);
            this.txtSpell.TabIndex = 7;
            this.txtSpell.Visible = false;
            this.txtSpell.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpellHeader
            // 
            this.txtSpellHeader.IsAllowEmpty = false;
            this.txtSpellHeader.Location = new System.Drawing.Point(336, 256);
            this.txtSpellHeader.Name = "txtSpellHeader";
            this.txtSpellHeader.Size = new System.Drawing.Size(185, 23);
            this.txtSpellHeader.TabIndex = 8;
            this.txtSpellHeader.Visible = false;
            this.txtSpellHeader.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebProirNum
            // 
            this.nebProirNum.FormatString = "0";
            this.nebProirNum.IsAllowEmpty = false;
            this.nebProirNum.IsAllowLessThanZero = false;
            this.nebProirNum.IsAllowZero = true;
            this.nebProirNum.Location = new System.Drawing.Point(446, 225);
            this.nebProirNum.Name = "nebProirNum";
            this.nebProirNum.Size = new System.Drawing.Size(75, 23);
            this.nebProirNum.TabIndex = 6;
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
            this.chkIsUsed.Location = new System.Drawing.Point(15, 105);
            this.chkIsUsed.Model = null;
            this.chkIsUsed.Name = "chkIsUsed";
            this.chkIsUsed.Size = new System.Drawing.Size(68, 23);
            this.chkIsUsed.TabIndex = 10;
            this.chkIsUsed.Text = "是否可用";
            this.chkIsUsed.Visible = false;
            this.chkIsUsed.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(336, 72);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(185, 23);
            this.txtRemark.TabIndex = 9;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblNameEN
            // 
            this.lblNameEN.AutoSize = true;
            this.lblNameEN.ForeColor = System.Drawing.Color.Black;
            this.lblNameEN.Location = new System.Drawing.Point(273, 15);
            this.lblNameEN.Name = "lblNameEN";
            this.lblNameEN.Size = new System.Drawing.Size(56, 17);
            this.lblNameEN.TabIndex = 165;
            this.lblNameEN.Text = "英文名称";
            // 
            // lblNameCN
            // 
            this.lblNameCN.AutoSize = true;
            this.lblNameCN.ForeColor = System.Drawing.Color.Black;
            this.lblNameCN.Location = new System.Drawing.Point(13, 15);
            this.lblNameCN.Name = "lblNameCN";
            this.lblNameCN.Size = new System.Drawing.Size(56, 17);
            this.lblNameCN.TabIndex = 166;
            this.lblNameCN.Text = "中文名称";
            // 
            // lblNameBig5
            // 
            this.lblNameBig5.AutoSize = true;
            this.lblNameBig5.ForeColor = System.Drawing.Color.Black;
            this.lblNameBig5.Location = new System.Drawing.Point(13, 45);
            this.lblNameBig5.Name = "lblNameBig5";
            this.lblNameBig5.Size = new System.Drawing.Size(56, 17);
            this.lblNameBig5.TabIndex = 167;
            this.lblNameBig5.Text = "繁体名称";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.ForeColor = System.Drawing.Color.Black;
            this.lblCode.Location = new System.Drawing.Point(273, 45);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 17);
            this.lblCode.TabIndex = 168;
            this.lblCode.Text = "代码";
            // 
            // lblCodeNum
            // 
            this.lblCodeNum.AutoSize = true;
            this.lblCodeNum.ForeColor = System.Drawing.Color.Black;
            this.lblCodeNum.Location = new System.Drawing.Point(14, 228);
            this.lblCodeNum.Name = "lblCodeNum";
            this.lblCodeNum.Size = new System.Drawing.Size(56, 17);
            this.lblCodeNum.TabIndex = 169;
            this.lblCodeNum.Text = "数字代码";
            this.lblCodeNum.Visible = false;
            // 
            // lblCodeEN
            // 
            this.lblCodeEN.AutoSize = true;
            this.lblCodeEN.ForeColor = System.Drawing.Color.Black;
            this.lblCodeEN.Location = new System.Drawing.Point(196, 228);
            this.lblCodeEN.Name = "lblCodeEN";
            this.lblCodeEN.Size = new System.Drawing.Size(56, 17);
            this.lblCodeEN.TabIndex = 170;
            this.lblCodeEN.Text = "字母代码";
            this.lblCodeEN.Visible = false;
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.ForeColor = System.Drawing.Color.Black;
            this.lblSpell.Location = new System.Drawing.Point(14, 259);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(32, 17);
            this.lblSpell.TabIndex = 171;
            this.lblSpell.Text = "拼音";
            this.lblSpell.Visible = false;
            // 
            // lblSpellHeader
            // 
            this.lblSpellHeader.AutoSize = true;
            this.lblSpellHeader.ForeColor = System.Drawing.Color.Black;
            this.lblSpellHeader.Location = new System.Drawing.Point(274, 259);
            this.lblSpellHeader.Name = "lblSpellHeader";
            this.lblSpellHeader.Size = new System.Drawing.Size(56, 17);
            this.lblSpellHeader.TabIndex = 172;
            this.lblSpellHeader.Text = "拼音缩写";
            this.lblSpellHeader.Visible = false;
            // 
            // lblProirNum
            // 
            this.lblProirNum.AutoSize = true;
            this.lblProirNum.ForeColor = System.Drawing.Color.Black;
            this.lblProirNum.Location = new System.Drawing.Point(384, 228);
            this.lblProirNum.Name = "lblProirNum";
            this.lblProirNum.Size = new System.Drawing.Size(44, 17);
            this.lblProirNum.TabIndex = 173;
            this.lblProirNum.Text = "顺序号";
            this.lblProirNum.Visible = false;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(295, 74);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(32, 17);
            this.lblRemark.TabIndex = 175;
            this.lblRemark.Text = "备注";
            // 
            // btnColor
            // 
            // 
            // 
            // 
            this.btnColor.ColorPicker.BorderStyle = Janus.Windows.UI.BorderStyle.None;
            this.btnColor.ColorPicker.Location = new System.Drawing.Point(0, 0);
            this.btnColor.ColorPicker.Name = "";
            this.btnColor.ColorPicker.Size = new System.Drawing.Size(100, 100);
            this.btnColor.ColorPicker.TabIndex = 0;
            this.btnColor.ColorPicker.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnColor.Location = new System.Drawing.Point(76, 72);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(185, 23);
            this.btnColor.TabIndex = 183;
            this.btnColor.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // frmCodeEquipmentStateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(532, 140);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.xLabel1);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.txtParentID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblDeptId);
            this.Controls.Add(this.lblParentID);
            this.Controls.Add(this.lblUserID);
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
            this.Controls.Add(this.lblRemark);
            this.Name = "frmCodeEquipmentStateEdit";
            this.Text = "设备状态";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblRemark, 0);
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
            this.Controls.SetChildIndex(this.lblUserID, 0);
            this.Controls.SetChildIndex(this.lblParentID, 0);
            this.Controls.SetChildIndex(this.lblDeptId, 0);
            this.Controls.SetChildIndex(this.txtUserID, 0);
            this.Controls.SetChildIndex(this.txtParentID, 0);
            this.Controls.SetChildIndex(this.txtDeptId, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.btnColor, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private Component.XLabel lblRemark;
        private XSelectUseDeptEditBox txtDeptId;
        private Component.XEditBox txtParentID;
        private Component.XEditBox txtUserID;
        private Component.XLabel lblDeptId;
        private Component.XLabel lblParentID;
        private Component.XLabel lblUserID;
        private Component.XLabel xLabel1;
        private Component.XColorButton btnColor;


    }
}