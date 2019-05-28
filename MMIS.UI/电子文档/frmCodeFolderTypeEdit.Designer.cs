namespace MMIS.UI
{
    public partial class frmCodeFolderTypeEdit
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
            this.lblUserID = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtNameEN = new MMIS.Component.XEditBox();
            this.txtNameCN = new MMIS.Component.XEditBox();
            this.txtNameBig5 = new MMIS.Component.XEditBox();
            this.txtCode = new MMIS.Component.XEditBox();
            this.nebCodeNum = new MMIS.Component.XNumberEditBox();
            this.txtCodeEN = new MMIS.Component.XEditBox();
            this.txtSpell = new MMIS.Component.XEditBox();
            this.txtSpellHeader = new MMIS.Component.XEditBox();
            this.nebProirNum = new MMIS.Component.XNumberEditBox();
            this.txtDeptId = new MMIS.Component.XEditBox();
            this.chkIsUsed = new MMIS.Component.XCheckBox();
            this.txtParentID = new MMIS.Component.XEditBox();
            this.txtUserID = new MMIS.Component.XEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(467, 390);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(554, 390);
            // 
            // lblNameEN
            // 
            this.lblNameEN.AutoSize = true;
            this.lblNameEN.ForeColor = System.Drawing.Color.Black;
            this.lblNameEN.Location = new System.Drawing.Point(22, 33);
            this.lblNameEN.Name = "lblNameEN";
            this.lblNameEN.Size = new System.Drawing.Size(56, 17);
            this.lblNameEN.TabIndex = 1;
            this.lblNameEN.Text = "英文名称";
            // 
            // lblNameCN
            // 
            this.lblNameCN.AutoSize = true;
            this.lblNameCN.ForeColor = System.Drawing.Color.Black;
            this.lblNameCN.Location = new System.Drawing.Point(22, 63);
            this.lblNameCN.Name = "lblNameCN";
            this.lblNameCN.Size = new System.Drawing.Size(56, 17);
            this.lblNameCN.TabIndex = 2;
            this.lblNameCN.Text = "中文名称";
            // 
            // lblNameBig5
            // 
            this.lblNameBig5.AutoSize = true;
            this.lblNameBig5.ForeColor = System.Drawing.Color.Black;
            this.lblNameBig5.Location = new System.Drawing.Point(22, 93);
            this.lblNameBig5.Name = "lblNameBig5";
            this.lblNameBig5.Size = new System.Drawing.Size(56, 17);
            this.lblNameBig5.TabIndex = 3;
            this.lblNameBig5.Text = "繁体名称";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.ForeColor = System.Drawing.Color.Black;
            this.lblCode.Location = new System.Drawing.Point(22, 123);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 17);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "代码";
            // 
            // lblCodeNum
            // 
            this.lblCodeNum.AutoSize = true;
            this.lblCodeNum.ForeColor = System.Drawing.Color.Black;
            this.lblCodeNum.Location = new System.Drawing.Point(22, 153);
            this.lblCodeNum.Name = "lblCodeNum";
            this.lblCodeNum.Size = new System.Drawing.Size(56, 17);
            this.lblCodeNum.TabIndex = 5;
            this.lblCodeNum.Text = "数字代码";
            // 
            // lblCodeEN
            // 
            this.lblCodeEN.AutoSize = true;
            this.lblCodeEN.ForeColor = System.Drawing.Color.Black;
            this.lblCodeEN.Location = new System.Drawing.Point(22, 183);
            this.lblCodeEN.Name = "lblCodeEN";
            this.lblCodeEN.Size = new System.Drawing.Size(56, 17);
            this.lblCodeEN.TabIndex = 6;
            this.lblCodeEN.Text = "字母代码";
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.ForeColor = System.Drawing.Color.Black;
            this.lblSpell.Location = new System.Drawing.Point(22, 213);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(32, 17);
            this.lblSpell.TabIndex = 7;
            this.lblSpell.Text = "拼音";
            // 
            // lblSpellHeader
            // 
            this.lblSpellHeader.AutoSize = true;
            this.lblSpellHeader.ForeColor = System.Drawing.Color.Black;
            this.lblSpellHeader.Location = new System.Drawing.Point(22, 243);
            this.lblSpellHeader.Name = "lblSpellHeader";
            this.lblSpellHeader.Size = new System.Drawing.Size(56, 17);
            this.lblSpellHeader.TabIndex = 8;
            this.lblSpellHeader.Text = "拼音缩写";
            // 
            // lblProirNum
            // 
            this.lblProirNum.AutoSize = true;
            this.lblProirNum.ForeColor = System.Drawing.Color.Black;
            this.lblProirNum.Location = new System.Drawing.Point(22, 273);
            this.lblProirNum.Name = "lblProirNum";
            this.lblProirNum.Size = new System.Drawing.Size(44, 17);
            this.lblProirNum.TabIndex = 9;
            this.lblProirNum.Text = "顺序号";
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.ForeColor = System.Drawing.Color.Black;
            this.lblDeptId.Location = new System.Drawing.Point(22, 303);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(56, 17);
            this.lblDeptId.TabIndex = 10;
            this.lblDeptId.Text = "部门名称";
            // 
            // lblParentID
            // 
            this.lblParentID.AutoSize = true;
            this.lblParentID.ForeColor = System.Drawing.Color.Black;
            this.lblParentID.Location = new System.Drawing.Point(22, 363);
            this.lblParentID.Name = "lblParentID";
            this.lblParentID.Size = new System.Drawing.Size(56, 17);
            this.lblParentID.TabIndex = 12;
            this.lblParentID.Text = "上级节点";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.ForeColor = System.Drawing.Color.Black;
            this.lblUserID.Location = new System.Drawing.Point(22, 393);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(45, 17);
            this.lblUserID.TabIndex = 13;
            this.lblUserID.Text = "用户ID";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(22, 423);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(32, 17);
            this.lblRemark.TabIndex = 14;
            this.lblRemark.Text = "备注";
            // 
            // txtNameEN
            // 
            this.txtNameEN.IsAllowEmpty = false;
            this.txtNameEN.Location = new System.Drawing.Point(84, 30);
            this.txtNameEN.Name = "txtNameEN";
            this.txtNameEN.Size = new System.Drawing.Size(185, 23);
            this.txtNameEN.TabIndex = 1;
            this.txtNameEN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtNameCN
            // 
            this.txtNameCN.IsAllowEmpty = false;
            this.txtNameCN.Location = new System.Drawing.Point(84, 60);
            this.txtNameCN.Name = "txtNameCN";
            this.txtNameCN.Size = new System.Drawing.Size(185, 23);
            this.txtNameCN.TabIndex = 2;
            this.txtNameCN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtNameBig5
            // 
            this.txtNameBig5.IsAllowEmpty = false;
            this.txtNameBig5.Location = new System.Drawing.Point(84, 90);
            this.txtNameBig5.Name = "txtNameBig5";
            this.txtNameBig5.Size = new System.Drawing.Size(185, 23);
            this.txtNameBig5.TabIndex = 3;
            this.txtNameBig5.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCode
            // 
            this.txtCode.IsAllowEmpty = false;
            this.txtCode.Location = new System.Drawing.Point(84, 120);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(185, 23);
            this.txtCode.TabIndex = 4;
            this.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebCodeNum
            // 
            this.nebCodeNum.FormatString = "0";
            this.nebCodeNum.IsAllowEmpty = false;
            this.nebCodeNum.IsAllowLessThanZero = false;
            this.nebCodeNum.IsAllowZero = false;
            this.nebCodeNum.Location = new System.Drawing.Point(84, 150);
            this.nebCodeNum.Name = "nebCodeNum";
            this.nebCodeNum.Size = new System.Drawing.Size(185, 23);
            this.nebCodeNum.TabIndex = 101;
            this.nebCodeNum.Text = "0";
            this.nebCodeNum.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebCodeNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCodeEN
            // 
            this.txtCodeEN.IsAllowEmpty = false;
            this.txtCodeEN.Location = new System.Drawing.Point(84, 180);
            this.txtCodeEN.Name = "txtCodeEN";
            this.txtCodeEN.Size = new System.Drawing.Size(185, 23);
            this.txtCodeEN.TabIndex = 6;
            this.txtCodeEN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpell
            // 
            this.txtSpell.IsAllowEmpty = false;
            this.txtSpell.Location = new System.Drawing.Point(84, 210);
            this.txtSpell.Name = "txtSpell";
            this.txtSpell.Size = new System.Drawing.Size(185, 23);
            this.txtSpell.TabIndex = 7;
            this.txtSpell.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpellHeader
            // 
            this.txtSpellHeader.IsAllowEmpty = false;
            this.txtSpellHeader.Location = new System.Drawing.Point(84, 240);
            this.txtSpellHeader.Name = "txtSpellHeader";
            this.txtSpellHeader.Size = new System.Drawing.Size(185, 23);
            this.txtSpellHeader.TabIndex = 8;
            this.txtSpellHeader.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebProirNum
            // 
            this.nebProirNum.FormatString = "0";
            this.nebProirNum.IsAllowEmpty = false;
            this.nebProirNum.IsAllowLessThanZero = false;
            this.nebProirNum.IsAllowZero = false;
            this.nebProirNum.Location = new System.Drawing.Point(84, 270);
            this.nebProirNum.Name = "nebProirNum";
            this.nebProirNum.Size = new System.Drawing.Size(185, 23);
            this.nebProirNum.TabIndex = 101;
            this.nebProirNum.Text = "0";
            this.nebProirNum.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebProirNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtDeptId
            // 
            this.txtDeptId.IsAllowEmpty = false;
            this.txtDeptId.Location = new System.Drawing.Point(84, 300);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.Size = new System.Drawing.Size(185, 23);
            this.txtDeptId.TabIndex = 10;
            this.txtDeptId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // chkIsUsed
            // 
            this.chkIsUsed.Location = new System.Drawing.Point(84, 330);
            this.chkIsUsed.Model = null;
            this.chkIsUsed.Name = "chkIsUsed";
            this.chkIsUsed.Size = new System.Drawing.Size(185, 23);
            this.chkIsUsed.TabIndex = 11;
            this.chkIsUsed.Text = "是否可用";
            this.chkIsUsed.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtParentID
            // 
            this.txtParentID.IsAllowEmpty = false;
            this.txtParentID.Location = new System.Drawing.Point(84, 360);
            this.txtParentID.Name = "txtParentID";
            this.txtParentID.Size = new System.Drawing.Size(185, 23);
            this.txtParentID.TabIndex = 12;
            this.txtParentID.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtUserID
            // 
            this.txtUserID.IsAllowEmpty = false;
            this.txtUserID.Location = new System.Drawing.Point(84, 390);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(185, 23);
            this.txtUserID.TabIndex = 13;
            this.txtUserID.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = false;
            this.txtRemark.Location = new System.Drawing.Point(84, 420);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(185, 23);
            this.txtRemark.TabIndex = 14;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmCodeFolderTypeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(728, 500);
            this.Controls.Add(this.txtNameEN);
            this.Controls.Add(this.txtNameCN);
            this.Controls.Add(this.txtNameBig5);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.nebCodeNum);
            this.Controls.Add(this.txtCodeEN);
            this.Controls.Add(this.txtSpell);
            this.Controls.Add(this.txtSpellHeader);
            this.Controls.Add(this.nebProirNum);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.chkIsUsed);
            this.Controls.Add(this.txtParentID);
            this.Controls.Add(this.txtUserID);
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
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblRemark);
            this.Name = "frmCodeFolderTypeEdit";
            this.Text = "默认检定项目";
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblUserID, 0);
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
            this.Controls.SetChildIndex(this.txtUserID, 0);
            this.Controls.SetChildIndex(this.txtParentID, 0);
            this.Controls.SetChildIndex(this.chkIsUsed, 0);
            this.Controls.SetChildIndex(this.txtDeptId, 0);
            this.Controls.SetChildIndex(this.nebProirNum, 0);
            this.Controls.SetChildIndex(this.txtSpellHeader, 0);
            this.Controls.SetChildIndex(this.txtSpell, 0);
            this.Controls.SetChildIndex(this.txtCodeEN, 0);
            this.Controls.SetChildIndex(this.nebCodeNum, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.Controls.SetChildIndex(this.txtNameBig5, 0);
            this.Controls.SetChildIndex(this.txtNameCN, 0);
            this.Controls.SetChildIndex(this.txtNameEN, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MMIS.Component.XLabel lblNameEN;
        private MMIS.Component.XLabel lblNameCN;
        private MMIS.Component.XLabel lblNameBig5;
        private MMIS.Component.XLabel lblCode;
        private MMIS.Component.XLabel lblCodeNum;
        private MMIS.Component.XLabel lblCodeEN;
        private MMIS.Component.XLabel lblSpell;
        private MMIS.Component.XLabel lblSpellHeader;
        private MMIS.Component.XLabel lblProirNum;
        private MMIS.Component.XLabel lblDeptId;
        private MMIS.Component.XLabel lblParentID;
        private MMIS.Component.XLabel lblUserID;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtNameEN;
        private MMIS.Component.XEditBox txtNameCN;
        private MMIS.Component.XEditBox txtNameBig5;
        private MMIS.Component.XEditBox txtCode;
        private MMIS.Component.XNumberEditBox nebCodeNum;
        private MMIS.Component.XEditBox txtCodeEN;
        private MMIS.Component.XEditBox txtSpell;
        private MMIS.Component.XEditBox txtSpellHeader;
        private MMIS.Component.XNumberEditBox nebProirNum;
        private MMIS.Component.XEditBox txtDeptId;
        private MMIS.Component.XCheckBox chkIsUsed;
        private MMIS.Component.XEditBox txtParentID;
        private MMIS.Component.XEditBox txtUserID;
        private MMIS.Component.XEditBox txtRemark;
        
    }
}