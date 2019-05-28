namespace MMIS.UI
{
    public partial class frmPassWordTmpEdit
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
            this.lblPassDesc = new MMIS.Component.XLabel();
            this.lblUserId = new MMIS.Component.XLabel();
            this.lblUserName = new MMIS.Component.XLabel();
            this.lblPassStateId = new MMIS.Component.XLabel();
            this.lblUseIP = new MMIS.Component.XLabel();
            this.lblUseStartTime = new MMIS.Component.XLabel();
            this.lblUseEndTime = new MMIS.Component.XLabel();
            this.lblUseLimit = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtPassDesc = new MMIS.Component.XEditBox();
            this.txtUserId = new MMIS.Component.XEditBox();
            this.txtUserName = new MMIS.Component.XEditBox();
            this.txtPassStateId = new MMIS.Component.XEditBox();
            this.txtUseIP = new MMIS.Component.XEditBox();
            this.dtUseStartTime = new MMIS.Component.XDateTimePicker();
            this.dtUseEndTime = new MMIS.Component.XDateTimePicker();
            this.nebUseLimit = new MMIS.Component.XNumberEditBox();
            this.chkIsTelAudit = new MMIS.Component.XCheckBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.txtPassword = new MMIS.Component.XEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.txtRepassword = new MMIS.Component.XEditBox();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(394, 170);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(481, 170);
            // 
            // lblPassDesc
            // 
            this.lblPassDesc.AutoSize = true;
            this.lblPassDesc.ForeColor = System.Drawing.Color.Black;
            this.lblPassDesc.Location = new System.Drawing.Point(13, 46);
            this.lblPassDesc.Name = "lblPassDesc";
            this.lblPassDesc.Size = new System.Drawing.Size(56, 17);
            this.lblPassDesc.TabIndex = 1;
            this.lblPassDesc.Text = "密码描述";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.ForeColor = System.Drawing.Color.Black;
            this.lblUserId.Location = new System.Drawing.Point(22, 348);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(45, 17);
            this.lblUserId.TabIndex = 2;
            this.lblUserId.Text = "用户ID";
            this.lblUserId.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(22, 378);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(56, 17);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "用户名称";
            this.lblUserName.Visible = false;
            // 
            // lblPassStateId
            // 
            this.lblPassStateId.AutoSize = true;
            this.lblPassStateId.ForeColor = System.Drawing.Color.Black;
            this.lblPassStateId.Location = new System.Drawing.Point(291, 306);
            this.lblPassStateId.Name = "lblPassStateId";
            this.lblPassStateId.Size = new System.Drawing.Size(56, 17);
            this.lblPassStateId.TabIndex = 4;
            this.lblPassStateId.Text = "密码状态";
            // 
            // lblUseIP
            // 
            this.lblUseIP.AutoSize = true;
            this.lblUseIP.ForeColor = System.Drawing.Color.Black;
            this.lblUseIP.Location = new System.Drawing.Point(13, 108);
            this.lblUseIP.Name = "lblUseIP";
            this.lblUseIP.Size = new System.Drawing.Size(43, 17);
            this.lblUseIP.TabIndex = 5;
            this.lblUseIP.Text = "使用IP";
            // 
            // lblUseStartTime
            // 
            this.lblUseStartTime.AutoSize = true;
            this.lblUseStartTime.ForeColor = System.Drawing.Color.Black;
            this.lblUseStartTime.Location = new System.Drawing.Point(13, 77);
            this.lblUseStartTime.Name = "lblUseStartTime";
            this.lblUseStartTime.Size = new System.Drawing.Size(80, 17);
            this.lblUseStartTime.TabIndex = 6;
            this.lblUseStartTime.Text = "使用开始时间";
            // 
            // lblUseEndTime
            // 
            this.lblUseEndTime.AutoSize = true;
            this.lblUseEndTime.ForeColor = System.Drawing.Color.Black;
            this.lblUseEndTime.Location = new System.Drawing.Point(285, 77);
            this.lblUseEndTime.Name = "lblUseEndTime";
            this.lblUseEndTime.Size = new System.Drawing.Size(80, 17);
            this.lblUseEndTime.TabIndex = 7;
            this.lblUseEndTime.Text = "使用结束时间";
            // 
            // lblUseLimit
            // 
            this.lblUseLimit.AutoSize = true;
            this.lblUseLimit.ForeColor = System.Drawing.Color.Black;
            this.lblUseLimit.Location = new System.Drawing.Point(309, 108);
            this.lblUseLimit.Name = "lblUseLimit";
            this.lblUseLimit.Size = new System.Drawing.Size(56, 17);
            this.lblUseLimit.TabIndex = 8;
            this.lblUseLimit.Text = "使用期限";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(13, 140);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 10;
            this.lblRemark.Text = "备注信息";
            // 
            // txtPassDesc
            // 
            this.txtPassDesc.IsAllowEmpty = false;
            this.txtPassDesc.Location = new System.Drawing.Point(94, 43);
            this.txtPassDesc.Name = "txtPassDesc";
            this.txtPassDesc.Size = new System.Drawing.Size(462, 23);
            this.txtPassDesc.TabIndex = 2;
            this.txtPassDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtUserId
            // 
            this.txtUserId.IsAllowEmpty = true;
            this.txtUserId.Location = new System.Drawing.Point(84, 345);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(185, 23);
            this.txtUserId.TabIndex = 2;
            this.txtUserId.Visible = false;
            this.txtUserId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtUserName
            // 
            this.txtUserName.IsAllowEmpty = true;
            this.txtUserName.Location = new System.Drawing.Point(84, 375);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(185, 23);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Visible = false;
            this.txtUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtPassStateId
            // 
            this.txtPassStateId.IsAllowEmpty = true;
            this.txtPassStateId.Location = new System.Drawing.Point(353, 303);
            this.txtPassStateId.Name = "txtPassStateId";
            this.txtPassStateId.Size = new System.Drawing.Size(165, 23);
            this.txtPassStateId.TabIndex = 4;
            this.txtPassStateId.Visible = false;
            this.txtPassStateId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtUseIP
            // 
            this.txtUseIP.IsAllowEmpty = true;
            this.txtUseIP.Location = new System.Drawing.Point(94, 105);
            this.txtUseIP.Name = "txtUseIP";
            this.txtUseIP.Size = new System.Drawing.Size(185, 23);
            this.txtUseIP.TabIndex = 5;
            this.txtUseIP.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // dtUseStartTime
            // 
            this.dtUseStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtUseStartTime.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom;
            // 
            // 
            // 
            this.dtUseStartTime.DropDownCalendar.Name = "";
            this.dtUseStartTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtUseStartTime.Location = new System.Drawing.Point(94, 74);
            this.dtUseStartTime.Name = "dtUseStartTime";
            this.dtUseStartTime.Size = new System.Drawing.Size(185, 23);
            this.dtUseStartTime.TabIndex = 3;
            this.dtUseStartTime.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtUseEndTime
            // 
            this.dtUseEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtUseEndTime.DateFormat = Janus.Windows.CalendarCombo.DateFormat.Custom;
            // 
            // 
            // 
            this.dtUseEndTime.DropDownCalendar.Name = "";
            this.dtUseEndTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtUseEndTime.Location = new System.Drawing.Point(371, 74);
            this.dtUseEndTime.Name = "dtUseEndTime";
            this.dtUseEndTime.Size = new System.Drawing.Size(185, 23);
            this.dtUseEndTime.TabIndex = 4;
            this.dtUseEndTime.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // nebUseLimit
            // 
            this.nebUseLimit.FormatString = "0";
            this.nebUseLimit.IsAllowEmpty = false;
            this.nebUseLimit.IsAllowLessThanZero = false;
            this.nebUseLimit.IsAllowZero = true;
            this.nebUseLimit.Location = new System.Drawing.Point(371, 105);
            this.nebUseLimit.Name = "nebUseLimit";
            this.nebUseLimit.Size = new System.Drawing.Size(185, 23);
            this.nebUseLimit.TabIndex = 6;
            this.nebUseLimit.Text = "0";
            this.nebUseLimit.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebUseLimit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // chkIsTelAudit
            // 
            this.chkIsTelAudit.Location = new System.Drawing.Point(292, 372);
            this.chkIsTelAudit.Model = null;
            this.chkIsTelAudit.Name = "chkIsTelAudit";
            this.chkIsTelAudit.Size = new System.Drawing.Size(185, 23);
            this.chkIsTelAudit.TabIndex = 9;
            this.chkIsTelAudit.Text = "是否手机审批";
            this.chkIsTelAudit.Visible = false;
            this.chkIsTelAudit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(94, 137);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(462, 23);
            this.txtRemark.TabIndex = 7;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtPassword
            // 
            this.txtPassword.IsAllowEmpty = false;
            this.txtPassword.Location = new System.Drawing.Point(94, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(185, 23);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(13, 15);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 102;
            this.xLabel1.Text = "申请密码";
            // 
            // txtRepassword
            // 
            this.txtRepassword.IsAllowEmpty = false;
            this.txtRepassword.Location = new System.Drawing.Point(371, 12);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.PasswordChar = '*';
            this.txtRepassword.Size = new System.Drawing.Size(185, 23);
            this.txtRepassword.TabIndex = 1;
            this.txtRepassword.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(290, 15);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(56, 17);
            this.xLabel2.TabIndex = 104;
            this.xLabel2.Text = "重复密码";
            // 
            // frmPassWordTmpEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(570, 209);
            this.Controls.Add(this.txtRepassword);
            this.Controls.Add(this.xLabel2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.xLabel1);
            this.Controls.Add(this.txtPassDesc);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassStateId);
            this.Controls.Add(this.txtUseIP);
            this.Controls.Add(this.dtUseStartTime);
            this.Controls.Add(this.dtUseEndTime);
            this.Controls.Add(this.nebUseLimit);
            this.Controls.Add(this.chkIsTelAudit);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblPassDesc);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPassStateId);
            this.Controls.Add(this.lblUseIP);
            this.Controls.Add(this.lblUseStartTime);
            this.Controls.Add(this.lblUseEndTime);
            this.Controls.Add(this.lblUseLimit);
            this.Controls.Add(this.lblRemark);
            this.Name = "frmPassWordTmpEdit";
            this.Text = "临时密码";
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblUseLimit, 0);
            this.Controls.SetChildIndex(this.lblUseEndTime, 0);
            this.Controls.SetChildIndex(this.lblUseStartTime, 0);
            this.Controls.SetChildIndex(this.lblUseIP, 0);
            this.Controls.SetChildIndex(this.lblPassStateId, 0);
            this.Controls.SetChildIndex(this.lblUserName, 0);
            this.Controls.SetChildIndex(this.lblUserId, 0);
            this.Controls.SetChildIndex(this.lblPassDesc, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.chkIsTelAudit, 0);
            this.Controls.SetChildIndex(this.nebUseLimit, 0);
            this.Controls.SetChildIndex(this.dtUseEndTime, 0);
            this.Controls.SetChildIndex(this.dtUseStartTime, 0);
            this.Controls.SetChildIndex(this.txtUseIP, 0);
            this.Controls.SetChildIndex(this.txtPassStateId, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.txtUserId, 0);
            this.Controls.SetChildIndex(this.txtPassDesc, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.xLabel2, 0);
            this.Controls.SetChildIndex(this.txtRepassword, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MMIS.Component.XLabel lblPassDesc;
        private MMIS.Component.XLabel lblUserId;
        private MMIS.Component.XLabel lblUserName;
        private MMIS.Component.XLabel lblPassStateId;
        private MMIS.Component.XLabel lblUseIP;
        private MMIS.Component.XLabel lblUseStartTime;
        private MMIS.Component.XLabel lblUseEndTime;
        private MMIS.Component.XLabel lblUseLimit;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtPassDesc;
        private MMIS.Component.XEditBox txtUserId;
        private MMIS.Component.XEditBox txtUserName;
        private MMIS.Component.XEditBox txtPassStateId;
        private MMIS.Component.XEditBox txtUseIP;
        private MMIS.Component.XDateTimePicker dtUseStartTime;
        private MMIS.Component.XDateTimePicker dtUseEndTime;
        private MMIS.Component.XNumberEditBox nebUseLimit;
        private MMIS.Component.XCheckBox chkIsTelAudit;
        private MMIS.Component.XEditBox txtRemark;
        private Component.XEditBox txtPassword;
        private Component.XLabel xLabel1;
        private Component.XEditBox txtRepassword;
        private Component.XLabel xLabel2;
        
    }
}