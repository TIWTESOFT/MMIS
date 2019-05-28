namespace MMIS.UI
{
    public partial class frmRoleEdit
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
            this.lblRoleName = new MMIS.Component.XLabel();
            this.lblNameNum = new MMIS.Component.XLabel();
            this.lblSpell = new MMIS.Component.XLabel();
            this.lblSpellHeader = new MMIS.Component.XLabel();
            this.lblOrderIndex = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtRoleName = new MMIS.Component.XEditBox();
            this.nebNameNum = new MMIS.Component.XNumberEditBox();
            this.txtSpell = new MMIS.Component.XEditBox();
            this.txtSpellHeader = new MMIS.Component.XEditBox();
            this.nebOrderIndex = new MMIS.Component.XNumberEditBox();
            this.chkIsUsed = new MMIS.Component.XCheckBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(249, 226);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(336, 226);
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.ForeColor = System.Drawing.Color.Black;
            this.lblRoleName.Location = new System.Drawing.Point(10, 13);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(56, 17);
            this.lblRoleName.TabIndex = 1;
            this.lblRoleName.Text = "角色名称";
            // 
            // lblNameNum
            // 
            this.lblNameNum.AutoSize = true;
            this.lblNameNum.ForeColor = System.Drawing.Color.Black;
            this.lblNameNum.Location = new System.Drawing.Point(10, 45);
            this.lblNameNum.Name = "lblNameNum";
            this.lblNameNum.Size = new System.Drawing.Size(56, 17);
            this.lblNameNum.TabIndex = 2;
            this.lblNameNum.Text = "数值代码";
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.ForeColor = System.Drawing.Color.Black;
            this.lblSpell.Location = new System.Drawing.Point(10, 75);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(32, 17);
            this.lblSpell.TabIndex = 3;
            this.lblSpell.Text = "拼音";
            // 
            // lblSpellHeader
            // 
            this.lblSpellHeader.AutoSize = true;
            this.lblSpellHeader.ForeColor = System.Drawing.Color.Black;
            this.lblSpellHeader.Location = new System.Drawing.Point(10, 105);
            this.lblSpellHeader.Name = "lblSpellHeader";
            this.lblSpellHeader.Size = new System.Drawing.Size(44, 17);
            this.lblSpellHeader.TabIndex = 4;
            this.lblSpellHeader.Text = "拼音头";
            // 
            // lblOrderIndex
            // 
            this.lblOrderIndex.AutoSize = true;
            this.lblOrderIndex.ForeColor = System.Drawing.Color.Black;
            this.lblOrderIndex.Location = new System.Drawing.Point(10, 135);
            this.lblOrderIndex.Name = "lblOrderIndex";
            this.lblOrderIndex.Size = new System.Drawing.Size(32, 17);
            this.lblOrderIndex.TabIndex = 5;
            this.lblOrderIndex.Text = "排序";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(10, 195);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 7;
            this.lblRemark.Text = "备注信息";
            // 
            // txtRoleName
            // 
            this.txtRoleName.IsAllowEmpty = false;
            this.txtRoleName.Location = new System.Drawing.Point(72, 10);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(339, 23);
            this.txtRoleName.TabIndex = 1;
            this.txtRoleName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtRoleName.TextChanged += new System.EventHandler(this.txtRoleName_TextChanged);
            this.txtRoleName.Leave += new System.EventHandler(this.txtRoleName_Leave);
            // 
            // nebNameNum
            // 
            this.nebNameNum.FormatString = "0";
            this.nebNameNum.IsAllowEmpty = false;
            this.nebNameNum.IsAllowLessThanZero = false;
            this.nebNameNum.IsAllowZero = true;
            this.nebNameNum.Location = new System.Drawing.Point(72, 42);
            this.nebNameNum.Name = "nebNameNum";
            this.nebNameNum.Size = new System.Drawing.Size(339, 23);
            this.nebNameNum.TabIndex = 101;
            this.nebNameNum.Text = "0";
            this.nebNameNum.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebNameNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpell
            // 
            this.txtSpell.IsAllowEmpty = false;
            this.txtSpell.Location = new System.Drawing.Point(72, 72);
            this.txtSpell.Name = "txtSpell";
            this.txtSpell.Size = new System.Drawing.Size(339, 23);
            this.txtSpell.TabIndex = 3;
            this.txtSpell.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpellHeader
            // 
            this.txtSpellHeader.IsAllowEmpty = false;
            this.txtSpellHeader.Location = new System.Drawing.Point(72, 102);
            this.txtSpellHeader.Name = "txtSpellHeader";
            this.txtSpellHeader.Size = new System.Drawing.Size(339, 23);
            this.txtSpellHeader.TabIndex = 4;
            this.txtSpellHeader.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebOrderIndex
            // 
            this.nebOrderIndex.FormatString = "0";
            this.nebOrderIndex.IsAllowEmpty = false;
            this.nebOrderIndex.IsAllowLessThanZero = false;
            this.nebOrderIndex.IsAllowZero = true;
            this.nebOrderIndex.Location = new System.Drawing.Point(72, 132);
            this.nebOrderIndex.Name = "nebOrderIndex";
            this.nebOrderIndex.Size = new System.Drawing.Size(339, 23);
            this.nebOrderIndex.TabIndex = 101;
            this.nebOrderIndex.Text = "0";
            this.nebOrderIndex.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebOrderIndex.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // chkIsUsed
            // 
            this.chkIsUsed.Location = new System.Drawing.Point(72, 162);
            this.chkIsUsed.Model = null;
            this.chkIsUsed.Name = "chkIsUsed";
            this.chkIsUsed.Size = new System.Drawing.Size(339, 23);
            this.chkIsUsed.TabIndex = 6;
            this.chkIsUsed.Text = "是否可用";
            this.chkIsUsed.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(72, 192);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(339, 23);
            this.txtRemark.TabIndex = 7;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmRoleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(423, 265);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.nebNameNum);
            this.Controls.Add(this.txtSpell);
            this.Controls.Add(this.txtSpellHeader);
            this.Controls.Add(this.nebOrderIndex);
            this.Controls.Add(this.chkIsUsed);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.lblNameNum);
            this.Controls.Add(this.lblSpell);
            this.Controls.Add(this.lblSpellHeader);
            this.Controls.Add(this.lblOrderIndex);
            this.Controls.Add(this.lblRemark);
            this.Name = "frmRoleEdit";
            this.Text = "角色信息";
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblOrderIndex, 0);
            this.Controls.SetChildIndex(this.lblSpellHeader, 0);
            this.Controls.SetChildIndex(this.lblSpell, 0);
            this.Controls.SetChildIndex(this.lblNameNum, 0);
            this.Controls.SetChildIndex(this.lblRoleName, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.chkIsUsed, 0);
            this.Controls.SetChildIndex(this.nebOrderIndex, 0);
            this.Controls.SetChildIndex(this.txtSpellHeader, 0);
            this.Controls.SetChildIndex(this.txtSpell, 0);
            this.Controls.SetChildIndex(this.nebNameNum, 0);
            this.Controls.SetChildIndex(this.txtRoleName, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MMIS.Component.XLabel lblRoleName;
        private MMIS.Component.XLabel lblNameNum;
        private MMIS.Component.XLabel lblSpell;
        private MMIS.Component.XLabel lblSpellHeader;
        private MMIS.Component.XLabel lblOrderIndex;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtRoleName;
        private MMIS.Component.XNumberEditBox nebNameNum;
        private MMIS.Component.XEditBox txtSpell;
        private MMIS.Component.XEditBox txtSpellHeader;
        private MMIS.Component.XNumberEditBox nebOrderIndex;
        private MMIS.Component.XCheckBox chkIsUsed;
        private MMIS.Component.XEditBox txtRemark;
        
    }
}