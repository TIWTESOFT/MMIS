namespace MMIS.UI
{
    public partial class frmUseDeptEdit
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
            this.lblParentID = new MMIS.Component.XLabel();
            this.lblDeptName = new MMIS.Component.XLabel();
            this.lblNameNum = new MMIS.Component.XLabel();
            this.lblSpell = new MMIS.Component.XLabel();
            this.lblSpellHeader = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtParentID = new MMIS.Component.XEditBox();
            this.txtDeptName = new MMIS.Component.XEditBox();
            this.nebNameNum=new MMIS.Component.XNumberEditBox();
            this.txtSpell = new MMIS.Component.XEditBox();
            this.txtSpellHeader = new MMIS.Component.XEditBox();
            this.chkIsUsed=new MMIS.Component.XCheckBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.SuspendLayout();
            this.Controls.Add(this.txtParentID);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.nebNameNum);
            this.Controls.Add(this.txtSpell);
            this.Controls.Add(this.txtSpellHeader);
            this.Controls.Add(this.chkIsUsed);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblParentID);
            this.Controls.Add(this.lblDeptName);
            this.Controls.Add(this.lblNameNum);
            this.Controls.Add(this.lblSpell);
            this.Controls.Add(this.lblSpellHeader);
            this.Controls.Add(this.lblRemark);
            // 
            // lblParentID
            // 
            this.lblParentID.AutoSize = true;
            this.lblParentID.Location = new System.Drawing.Point(22, 33);
            this.lblParentID.Name = "lblParentID";
            this.lblParentID.Size = new System.Drawing.Size(56, 17);
            this.lblParentID.TabIndex = 1;
            this.lblParentID.Text = "父级主键";
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(22, 63);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(56, 17);
            this.lblDeptName.TabIndex = 2;
            this.lblDeptName.Text = "部门名称";
            // 
            // lblNameNum
            // 
            this.lblNameNum.AutoSize = true;
            this.lblNameNum.Location = new System.Drawing.Point(22, 93);
            this.lblNameNum.Name = "lblNameNum";
            this.lblNameNum.Size = new System.Drawing.Size(56, 17);
            this.lblNameNum.TabIndex = 3;
            this.lblNameNum.Text = "数值代码";
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.Location = new System.Drawing.Point(22, 123);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(56, 17);
            this.lblSpell.TabIndex = 4;
            this.lblSpell.Text = "拼音";
            // 
            // lblSpellHeader
            // 
            this.lblSpellHeader.AutoSize = true;
            this.lblSpellHeader.Location = new System.Drawing.Point(22, 153);
            this.lblSpellHeader.Name = "lblSpellHeader";
            this.lblSpellHeader.Size = new System.Drawing.Size(56, 17);
            this.lblSpellHeader.TabIndex = 5;
            this.lblSpellHeader.Text = "拼音头";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(22, 213);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 7;
            this.lblRemark.Text = "备注信息";
            // 
            // txtParentID
            // 
            this.txtParentID.Location = new System.Drawing.Point(84, 30);
            this.txtParentID.Name = "txtParentID";
            this.txtParentID.Size = new System.Drawing.Size(185, 23);
            this.txtParentID.TabIndex = 1;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(84, 60);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(185, 23);
            this.txtDeptName.TabIndex = 2;
            this.nebNameNum.FormatString = "0.00";
            this.nebNameNum.IsAllowEmpty = false;
            this.nebNameNum.IsAllowLessThanZero = false;
            this.nebNameNum.IsAllowZero = false;
            this.nebNameNum.Location = new System.Drawing.Point(84, 90);
            this.nebNameNum.Name = "nebNameNum";
            this.nebNameNum.Size = new System.Drawing.Size(185, 23);
            this.nebNameNum.TabIndex = 101;
            this.nebNameNum.FormatString = "0";
            this.nebNameNum.Text = "0";
            this.nebNameNum.Value = 0;
            this.nebNameNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpell
            // 
            this.txtSpell.Location = new System.Drawing.Point(84, 120);
            this.txtSpell.Name = "txtSpell";
            this.txtSpell.Size = new System.Drawing.Size(185, 23);
            this.txtSpell.TabIndex = 4;
            // 
            // txtSpellHeader
            // 
            this.txtSpellHeader.Location = new System.Drawing.Point(84, 150);
            this.txtSpellHeader.Name = "txtSpellHeader";
            this.txtSpellHeader.Size = new System.Drawing.Size(185, 23);
            this.txtSpellHeader.TabIndex = 5;
            // 
            // chkIsUsed
            // 
            this.chkIsUsed.Location =  new System.Drawing.Point(84, 180);
            this.chkIsUsed.Name = "chkIsUsed";
            this.chkIsUsed.Size = new System.Drawing.Size(185, 23);
            this.chkIsUsed.TabIndex = 6;
            this.chkIsUsed.Text = "是否可用";
            this.chkIsUsed.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(84, 210);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(185, 23);
            this.txtRemark.TabIndex = 7;
            // 
            // frmUsedeptEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(413, 252);
            this.Name = "frmUsedeptEdit";
            this.Text = "部门档案";
            this.ResumeLayout(false);
        }

        #endregion
        
        private MMIS.Component.XLabel lblParentID;
        private MMIS.Component.XLabel lblDeptName;
        private MMIS.Component.XLabel lblNameNum;
        private MMIS.Component.XLabel lblSpell;
        private MMIS.Component.XLabel lblSpellHeader;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtParentID;
        private MMIS.Component.XEditBox txtDeptName;
        private MMIS.Component.XNumberEditBox nebNameNum;
        private MMIS.Component.XEditBox txtSpell;
        private MMIS.Component.XEditBox txtSpellHeader;
        private MMIS.Component.XCheckBox chkIsUsed;
        private MMIS.Component.XEditBox txtRemark;
        
    }
}