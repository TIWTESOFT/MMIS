namespace MMIS.UI
{
    public partial class frmUsersEdit
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
            this.lblUserType = new MMIS.Component.XLabel();
            this.lblUserName = new MMIS.Component.XLabel();
            this.lblRealName = new MMIS.Component.XLabel();
            this.lblNameNum = new MMIS.Component.XLabel();
            this.lblPassWord = new MMIS.Component.XLabel();
            this.lblUserState = new MMIS.Component.XLabel();
            this.lblAuditTel = new MMIS.Component.XLabel();
            this.lblOrderIndex = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtUserName = new MMIS.Component.XEditBox();
            this.txtRealName = new MMIS.Component.XEditBox();
            this.nebNameNum = new MMIS.Component.XNumberEditBox();
            this.txtPassWord = new MMIS.Component.XEditBox();
            this.txtUserState = new MMIS.Component.XEditBox();
            this.chkIsAdmin = new MMIS.Component.XCheckBox();
            this.chkIsUsed = new MMIS.Component.XCheckBox();
            this.txtAuditTel = new MMIS.Component.XEditBox();
            this.chkIsDownPower = new MMIS.Component.XCheckBox();
            this.nebOrderIndex = new MMIS.Component.XNumberEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.txtRepass = new MMIS.Component.XEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.txtUserType = new MMIS.UI.XSelectCodeUserTypeEditBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(352, 135);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(439, 135);
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.ForeColor = System.Drawing.Color.Black;
            this.lblUserType.Location = new System.Drawing.Point(11, 15);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(56, 17);
            this.lblUserType.TabIndex = 1;
            this.lblUserType.Text = "用户类型";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(197, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(44, 17);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "用户名";
            // 
            // lblRealName
            // 
            this.lblRealName.AutoSize = true;
            this.lblRealName.ForeColor = System.Drawing.Color.Black;
            this.lblRealName.Location = new System.Drawing.Point(352, 15);
            this.lblRealName.Name = "lblRealName";
            this.lblRealName.Size = new System.Drawing.Size(56, 17);
            this.lblRealName.TabIndex = 3;
            this.lblRealName.Text = "真实姓名";
            // 
            // lblNameNum
            // 
            this.lblNameNum.AutoSize = true;
            this.lblNameNum.ForeColor = System.Drawing.Color.Black;
            this.lblNameNum.Location = new System.Drawing.Point(69, 205);
            this.lblNameNum.Name = "lblNameNum";
            this.lblNameNum.Size = new System.Drawing.Size(56, 17);
            this.lblNameNum.TabIndex = 4;
            this.lblNameNum.Text = "数值代码";
            this.lblNameNum.Visible = false;
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.ForeColor = System.Drawing.Color.Black;
            this.lblPassWord.Location = new System.Drawing.Point(11, 44);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(32, 17);
            this.lblPassWord.TabIndex = 5;
            this.lblPassWord.Text = "密码";
            // 
            // lblUserState
            // 
            this.lblUserState.AutoSize = true;
            this.lblUserState.ForeColor = System.Drawing.Color.Black;
            this.lblUserState.Location = new System.Drawing.Point(99, 176);
            this.lblUserState.Name = "lblUserState";
            this.lblUserState.Size = new System.Drawing.Size(56, 17);
            this.lblUserState.TabIndex = 6;
            this.lblUserState.Text = "用户状态";
            this.lblUserState.Visible = false;
            // 
            // lblAuditTel
            // 
            this.lblAuditTel.AutoSize = true;
            this.lblAuditTel.ForeColor = System.Drawing.Color.Black;
            this.lblAuditTel.Location = new System.Drawing.Point(11, 76);
            this.lblAuditTel.Name = "lblAuditTel";
            this.lblAuditTel.Size = new System.Drawing.Size(116, 17);
            this.lblAuditTel.TabIndex = 9;
            this.lblAuditTel.Text = "审核临时密码手机号";
            // 
            // lblOrderIndex
            // 
            this.lblOrderIndex.AutoSize = true;
            this.lblOrderIndex.ForeColor = System.Drawing.Color.Black;
            this.lblOrderIndex.Location = new System.Drawing.Point(22, 333);
            this.lblOrderIndex.Name = "lblOrderIndex";
            this.lblOrderIndex.Size = new System.Drawing.Size(32, 17);
            this.lblOrderIndex.TabIndex = 11;
            this.lblOrderIndex.Text = "排序";
            this.lblOrderIndex.Visible = false;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(11, 107);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 12;
            this.lblRemark.Text = "备注信息";
            // 
            // txtUserName
            // 
            this.txtUserName.IsAllowEmpty = false;
            this.txtUserName.Location = new System.Drawing.Point(247, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(99, 23);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRealName
            // 
            this.txtRealName.IsAllowEmpty = false;
            this.txtRealName.Location = new System.Drawing.Point(409, 12);
            this.txtRealName.Name = "txtRealName";
            this.txtRealName.Size = new System.Drawing.Size(106, 23);
            this.txtRealName.TabIndex = 2;
            this.txtRealName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebNameNum
            // 
            this.nebNameNum.FormatString = "0";
            this.nebNameNum.IsAllowEmpty = false;
            this.nebNameNum.IsAllowLessThanZero = false;
            this.nebNameNum.IsAllowZero = true;
            this.nebNameNum.Location = new System.Drawing.Point(131, 202);
            this.nebNameNum.Name = "nebNameNum";
            this.nebNameNum.Size = new System.Drawing.Size(185, 23);
            this.nebNameNum.TabIndex = 3;
            this.nebNameNum.Text = "0";
            this.nebNameNum.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebNameNum.Visible = false;
            this.nebNameNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtPassWord
            // 
            this.txtPassWord.IsAllowEmpty = false;
            this.txtPassWord.Location = new System.Drawing.Point(73, 41);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(185, 23);
            this.txtPassWord.TabIndex = 4;
            this.txtPassWord.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtUserState
            // 
            this.txtUserState.IsAllowEmpty = true;
            this.txtUserState.Location = new System.Drawing.Point(161, 173);
            this.txtUserState.Name = "txtUserState";
            this.txtUserState.Size = new System.Drawing.Size(185, 23);
            this.txtUserState.TabIndex = 6;
            this.txtUserState.Visible = false;
            this.txtUserState.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.Location = new System.Drawing.Point(12, 135);
            this.chkIsAdmin.Model = null;
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(78, 23);
            this.chkIsAdmin.TabIndex = 10;
            this.chkIsAdmin.Text = "是否管理员";
            this.chkIsAdmin.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // chkIsUsed
            // 
            this.chkIsUsed.Location = new System.Drawing.Point(330, 73);
            this.chkIsUsed.Model = null;
            this.chkIsUsed.Name = "chkIsUsed";
            this.chkIsUsed.Size = new System.Drawing.Size(73, 23);
            this.chkIsUsed.TabIndex = 7;
            this.chkIsUsed.Text = "是否可用";
            this.chkIsUsed.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtAuditTel
            // 
            this.txtAuditTel.IsAllowEmpty = true;
            this.txtAuditTel.Location = new System.Drawing.Point(131, 73);
            this.txtAuditTel.Name = "txtAuditTel";
            this.txtAuditTel.Size = new System.Drawing.Size(185, 23);
            this.txtAuditTel.TabIndex = 6;
            this.txtAuditTel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // chkIsDownPower
            // 
            this.chkIsDownPower.Location = new System.Drawing.Point(409, 73);
            this.chkIsDownPower.Model = null;
            this.chkIsDownPower.Name = "chkIsDownPower";
            this.chkIsDownPower.Size = new System.Drawing.Size(106, 23);
            this.chkIsDownPower.TabIndex = 8;
            this.chkIsDownPower.Text = "是否超权限下载";
            this.chkIsDownPower.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // nebOrderIndex
            // 
            this.nebOrderIndex.FormatString = "0";
            this.nebOrderIndex.IsAllowEmpty = true;
            this.nebOrderIndex.IsAllowLessThanZero = true;
            this.nebOrderIndex.IsAllowZero = true;
            this.nebOrderIndex.Location = new System.Drawing.Point(84, 330);
            this.nebOrderIndex.Name = "nebOrderIndex";
            this.nebOrderIndex.Size = new System.Drawing.Size(185, 23);
            this.nebOrderIndex.TabIndex = 101;
            this.nebOrderIndex.Text = "0";
            this.nebOrderIndex.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebOrderIndex.Visible = false;
            this.nebOrderIndex.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(73, 104);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(442, 23);
            this.txtRemark.TabIndex = 9;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRepass
            // 
            this.txtRepass.IsAllowEmpty = false;
            this.txtRepass.Location = new System.Drawing.Point(330, 41);
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.PasswordChar = '*';
            this.txtRepass.Size = new System.Drawing.Size(185, 23);
            this.txtRepass.TabIndex = 5;
            this.txtRepass.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(268, 44);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 103;
            this.xLabel1.Text = "重复密码";
            // 
            // txtUserType
            // 
            this.txtUserType.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtUserType.DisplayMember = "";
            this.txtUserType.IsAllowEmpty = false;
            this.txtUserType.Location = new System.Drawing.Point(73, 12);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.QueryCheckBox = null;
            this.txtUserType.QueryFieldName = null;
            this.txtUserType.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtUserType.ReadOnly = true;
            this.txtUserType.SelectedModel = null;
            this.txtUserType.Size = new System.Drawing.Size(113, 23);
            this.txtUserType.TabIndex = 0;
            this.txtUserType.ValueMember = "";
            this.txtUserType.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmUsersEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(526, 174);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.txtRepass);
            this.Controls.Add(this.xLabel1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtRealName);
            this.Controls.Add(this.nebNameNum);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserState);
            this.Controls.Add(this.chkIsAdmin);
            this.Controls.Add(this.txtAuditTel);
            this.Controls.Add(this.chkIsDownPower);
            this.Controls.Add(this.nebOrderIndex);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblRealName);
            this.Controls.Add(this.lblNameNum);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.lblUserState);
            this.Controls.Add(this.lblAuditTel);
            this.Controls.Add(this.lblOrderIndex);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.chkIsUsed);
            this.Name = "frmUsersEdit";
            this.Text = "用户信息";
            this.Controls.SetChildIndex(this.chkIsUsed, 0);
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblOrderIndex, 0);
            this.Controls.SetChildIndex(this.lblAuditTel, 0);
            this.Controls.SetChildIndex(this.lblUserState, 0);
            this.Controls.SetChildIndex(this.lblPassWord, 0);
            this.Controls.SetChildIndex(this.lblNameNum, 0);
            this.Controls.SetChildIndex(this.lblRealName, 0);
            this.Controls.SetChildIndex(this.lblUserName, 0);
            this.Controls.SetChildIndex(this.lblUserType, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.nebOrderIndex, 0);
            this.Controls.SetChildIndex(this.chkIsDownPower, 0);
            this.Controls.SetChildIndex(this.txtAuditTel, 0);
            this.Controls.SetChildIndex(this.chkIsAdmin, 0);
            this.Controls.SetChildIndex(this.txtUserState, 0);
            this.Controls.SetChildIndex(this.txtPassWord, 0);
            this.Controls.SetChildIndex(this.nebNameNum, 0);
            this.Controls.SetChildIndex(this.txtRealName, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.txtRepass, 0);
            this.Controls.SetChildIndex(this.txtUserType, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MMIS.Component.XLabel lblUserType;
        private MMIS.Component.XLabel lblUserName;
        private MMIS.Component.XLabel lblRealName;
        private MMIS.Component.XLabel lblNameNum;
        private MMIS.Component.XLabel lblPassWord;
        private MMIS.Component.XLabel lblUserState;
        private MMIS.Component.XLabel lblAuditTel;
        private MMIS.Component.XLabel lblOrderIndex;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtUserName;
        private MMIS.Component.XEditBox txtRealName;
        private MMIS.Component.XNumberEditBox nebNameNum;
        private MMIS.Component.XEditBox txtPassWord;
        private MMIS.Component.XEditBox txtUserState;
        private MMIS.Component.XCheckBox chkIsAdmin;
        private MMIS.Component.XCheckBox chkIsUsed;
        private MMIS.Component.XEditBox txtAuditTel;
        private MMIS.Component.XCheckBox chkIsDownPower;
        private MMIS.Component.XNumberEditBox nebOrderIndex;
        private MMIS.Component.XEditBox txtRemark;
        private Component.XEditBox txtRepass;
        private Component.XLabel xLabel1;
        private XSelectCodeUserTypeEditBox txtUserType;
        
    }
}