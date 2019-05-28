namespace MMIS.UI
{
    public partial class frmCodeEquipmentTypeEdit
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
            this.lblRuleCode = new MMIS.Component.XLabel();
            this.txtRuleCode = new MMIS.Component.XEditBox();
            this.txtNameEN = new MMIS.Component.XEditBox();
            this.txtNameCN = new MMIS.Component.XEditBox();
            this.txtNameBig5 = new MMIS.Component.XEditBox();
            this.txtCode = new MMIS.Component.XEditBox();
            this.nebCodeNum = new MMIS.Component.XNumberEditBox();
            this.txtSpell = new MMIS.Component.XEditBox();
            this.txtSpellHeader = new MMIS.Component.XEditBox();
            this.nebProirNum = new MMIS.Component.XNumberEditBox();
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
            this.xLabel1 = new MMIS.Component.XLabel();
            this.btnNewitem = new MMIS.Component.XButton();
            this.txtStandId = new MMIS.UI.XSelectStandEditBox();
            this.btnmodifyitem = new MMIS.Component.XButton();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(359, 178);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(446, 178);
            // 
            // lblRuleCode
            // 
            this.lblRuleCode.AutoSize = true;
            this.lblRuleCode.ForeColor = System.Drawing.Color.Black;
            this.lblRuleCode.Location = new System.Drawing.Point(14, 76);
            this.lblRuleCode.Name = "lblRuleCode";
            this.lblRuleCode.Size = new System.Drawing.Size(56, 17);
            this.lblRuleCode.TabIndex = 3;
            this.lblRuleCode.Text = "编号规则";
            // 
            // txtRuleCode
            // 
            this.txtRuleCode.IsAllowEmpty = false;
            this.txtRuleCode.Location = new System.Drawing.Point(76, 73);
            this.txtRuleCode.Name = "txtRuleCode";
            this.txtRuleCode.Size = new System.Drawing.Size(185, 23);
            this.txtRuleCode.TabIndex = 4;
            this.txtRuleCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtNameEN
            // 
            this.txtNameEN.IsAllowEmpty = true;
            this.txtNameEN.Location = new System.Drawing.Point(336, 12);
            this.txtNameEN.Name = "txtNameEN";
            this.txtNameEN.Size = new System.Drawing.Size(185, 23);
            this.txtNameEN.TabIndex = 1;
            this.txtNameEN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtNameCN
            // 
            this.txtNameCN.IsAllowEmpty = false;
            this.txtNameCN.Location = new System.Drawing.Point(76, 12);
            this.txtNameCN.Name = "txtNameCN";
            this.txtNameCN.Size = new System.Drawing.Size(185, 23);
            this.txtNameCN.TabIndex = 0;
            this.txtNameCN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtNameBig5
            // 
            this.txtNameBig5.IsAllowEmpty = true;
            this.txtNameBig5.Location = new System.Drawing.Point(76, 42);
            this.txtNameBig5.Name = "txtNameBig5";
            this.txtNameBig5.Size = new System.Drawing.Size(185, 23);
            this.txtNameBig5.TabIndex = 2;
            this.txtNameBig5.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCode
            // 
            this.txtCode.IsAllowEmpty = true;
            this.txtCode.Location = new System.Drawing.Point(336, 42);
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
            this.nebCodeNum.Location = new System.Drawing.Point(95, 392);
            this.nebCodeNum.Name = "nebCodeNum";
            this.nebCodeNum.Size = new System.Drawing.Size(105, 23);
            this.nebCodeNum.TabIndex = 159;
            this.nebCodeNum.Text = "0";
            this.nebCodeNum.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebCodeNum.Visible = false;
            this.nebCodeNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpell
            // 
            this.txtSpell.IsAllowEmpty = false;
            this.txtSpell.Location = new System.Drawing.Point(95, 423);
            this.txtSpell.Name = "txtSpell";
            this.txtSpell.Size = new System.Drawing.Size(185, 23);
            this.txtSpell.TabIndex = 162;
            this.txtSpell.Visible = false;
            this.txtSpell.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpellHeader
            // 
            this.txtSpellHeader.IsAllowEmpty = false;
            this.txtSpellHeader.Location = new System.Drawing.Point(355, 423);
            this.txtSpellHeader.Name = "txtSpellHeader";
            this.txtSpellHeader.Size = new System.Drawing.Size(185, 23);
            this.txtSpellHeader.TabIndex = 163;
            this.txtSpellHeader.Visible = false;
            this.txtSpellHeader.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebProirNum
            // 
            this.nebProirNum.FormatString = "0";
            this.nebProirNum.IsAllowEmpty = false;
            this.nebProirNum.IsAllowLessThanZero = false;
            this.nebProirNum.IsAllowZero = true;
            this.nebProirNum.Location = new System.Drawing.Point(465, 392);
            this.nebProirNum.Name = "nebProirNum";
            this.nebProirNum.Size = new System.Drawing.Size(75, 23);
            this.nebProirNum.TabIndex = 161;
            this.nebProirNum.Text = "0";
            this.nebProirNum.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebProirNum.Visible = false;
            this.nebProirNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(76, 104);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(445, 64);
            this.txtRemark.TabIndex = 5;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblNameEN
            // 
            this.lblNameEN.AutoSize = true;
            this.lblNameEN.ForeColor = System.Drawing.Color.Black;
            this.lblNameEN.Location = new System.Drawing.Point(274, 15);
            this.lblNameEN.Name = "lblNameEN";
            this.lblNameEN.Size = new System.Drawing.Size(56, 17);
            this.lblNameEN.TabIndex = 165;
            this.lblNameEN.Text = "英文名称";
            // 
            // lblNameCN
            // 
            this.lblNameCN.AutoSize = true;
            this.lblNameCN.ForeColor = System.Drawing.Color.Black;
            this.lblNameCN.Location = new System.Drawing.Point(14, 15);
            this.lblNameCN.Name = "lblNameCN";
            this.lblNameCN.Size = new System.Drawing.Size(56, 17);
            this.lblNameCN.TabIndex = 166;
            this.lblNameCN.Text = "中文名称";
            // 
            // lblNameBig5
            // 
            this.lblNameBig5.AutoSize = true;
            this.lblNameBig5.ForeColor = System.Drawing.Color.Black;
            this.lblNameBig5.Location = new System.Drawing.Point(14, 45);
            this.lblNameBig5.Name = "lblNameBig5";
            this.lblNameBig5.Size = new System.Drawing.Size(56, 17);
            this.lblNameBig5.TabIndex = 167;
            this.lblNameBig5.Text = "繁体名称";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.ForeColor = System.Drawing.Color.Black;
            this.lblCode.Location = new System.Drawing.Point(274, 45);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 17);
            this.lblCode.TabIndex = 168;
            this.lblCode.Text = "代码";
            // 
            // lblCodeNum
            // 
            this.lblCodeNum.AutoSize = true;
            this.lblCodeNum.ForeColor = System.Drawing.Color.Black;
            this.lblCodeNum.Location = new System.Drawing.Point(33, 395);
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
            this.lblCodeEN.Location = new System.Drawing.Point(215, 395);
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
            this.lblSpell.Location = new System.Drawing.Point(33, 426);
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
            this.lblSpellHeader.Location = new System.Drawing.Point(293, 426);
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
            this.lblProirNum.Location = new System.Drawing.Point(403, 395);
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
            this.lblRemark.Location = new System.Drawing.Point(14, 107);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(32, 17);
            this.lblRemark.TabIndex = 174;
            this.lblRemark.Text = "备注";
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(274, 77);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 3;
            this.xLabel1.Text = "检定标准";
            // 
            // btnNewitem
            // 
            this.btnNewitem.Location = new System.Drawing.Point(76, 181);
            this.btnNewitem.Name = "btnNewitem";
            this.btnNewitem.Size = new System.Drawing.Size(96, 23);
            this.btnNewitem.TabIndex = 176;
            this.btnNewitem.Text = "新增设备选项";
            this.btnNewitem.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnNewitem.Click += new System.EventHandler(this.btnNewitem_Click);
            // 
            // txtStandId
            // 
            this.txtStandId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtStandId.DisplayMember = "";
            this.txtStandId.IsAllowEmpty = false;
            this.txtStandId.Location = new System.Drawing.Point(336, 73);
            this.txtStandId.Name = "txtStandId";
            this.txtStandId.QueryCheckBox = null;
            this.txtStandId.QueryFieldName = null;
            this.txtStandId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtStandId.ReadOnly = true;
            this.txtStandId.SelectedModel = null;
            this.txtStandId.Size = new System.Drawing.Size(185, 23);
            this.txtStandId.TabIndex = 175;
            this.txtStandId.ValueMember = "";
            this.txtStandId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // btnmodifyitem
            // 
            this.btnmodifyitem.Location = new System.Drawing.Point(194, 181);
            this.btnmodifyitem.Name = "btnmodifyitem";
            this.btnmodifyitem.Size = new System.Drawing.Size(96, 23);
            this.btnmodifyitem.TabIndex = 177;
            this.btnmodifyitem.Text = "修改设备选项";
            this.btnmodifyitem.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnmodifyitem.Click += new System.EventHandler(this.btnmodifyitem_Click);
            // 
            // frmCodeEquipmentTypeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(534, 216);
            this.Controls.Add(this.btnmodifyitem);
            this.Controls.Add(this.btnNewitem);
            this.Controls.Add(this.txtStandId);
            this.Controls.Add(this.txtNameEN);
            this.Controls.Add(this.txtNameCN);
            this.Controls.Add(this.txtNameBig5);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.nebCodeNum);
            this.Controls.Add(this.txtSpell);
            this.Controls.Add(this.txtSpellHeader);
            this.Controls.Add(this.nebProirNum);
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
            this.Controls.Add(this.txtRuleCode);
            this.Controls.Add(this.xLabel1);
            this.Controls.Add(this.lblRuleCode);
            this.Name = "frmCodeEquipmentTypeEdit";
            this.Text = "设备类型";
            this.Controls.SetChildIndex(this.lblRuleCode, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.txtRuleCode, 0);
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
            this.Controls.SetChildIndex(this.nebProirNum, 0);
            this.Controls.SetChildIndex(this.txtSpellHeader, 0);
            this.Controls.SetChildIndex(this.txtSpell, 0);
            this.Controls.SetChildIndex(this.nebCodeNum, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.Controls.SetChildIndex(this.txtNameBig5, 0);
            this.Controls.SetChildIndex(this.txtNameCN, 0);
            this.Controls.SetChildIndex(this.txtNameEN, 0);
            this.Controls.SetChildIndex(this.txtStandId, 0);
            this.Controls.SetChildIndex(this.btnNewitem, 0);
            this.Controls.SetChildIndex(this.btnmodifyitem, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MMIS.Component.XLabel lblRuleCode;
        private MMIS.Component.XEditBox txtRuleCode;
        private Component.XEditBox txtNameEN;
        private Component.XEditBox txtNameCN;
        private Component.XEditBox txtNameBig5;
        private Component.XEditBox txtCode;
        private Component.XNumberEditBox nebCodeNum;
        private Component.XEditBox txtSpell;
        private Component.XEditBox txtSpellHeader;
        private Component.XNumberEditBox nebProirNum;
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
        private Component.XLabel xLabel1;
        private XSelectStandEditBox txtStandId;
        private Component.XButton btnNewitem;
        private Component.XButton btnmodifyitem;
        
    }
}