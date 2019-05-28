using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.Helper;
using MMIS.Model;
using System.Configuration;

namespace MMIS.UI
{
    public partial class frmFileDownloadEdit : frmEditBase
    {
        private XPassWordTmpInfo m_PasswordTempInfo;

        public XPassWordTmpInfo PasswordTempInfo
        {
            get { return this.m_PasswordTempInfo; }
        }

        public frmFileDownloadEdit()
        {
            InitializeComponent();
            this.InitPassword();
        }

        private void InitPassword()
        {
            XPassWordTmpBusiness business = this.m_Business as XPassWordTmpBusiness;
            this.m_PasswordTempInfo = business.GetValidTempPasswordInfo(XCommon.LoginUsersInfo.RID) as XPassWordTmpInfo;

            if (this.m_PasswordTempInfo != null)
            {
                this.txtPassword.Text = this.m_PasswordTempInfo.Password;
            }
        }

        protected override XBusinessBase InitBusiness()
        {
            return new XPassWordTmpBusiness();
        }

        protected override void SaveFunction()
        {
            XPassWordTmpBusiness business = this.m_Business as XPassWordTmpBusiness;

            this.m_PasswordTempInfo = business.GetTempPasswordInfo(XCommon.LoginUsersInfo.RID,
                this.txtPassword.Text.Trim()) as XPassWordTmpInfo;
            if (this.m_PasswordTempInfo == null)
            {
                XMessageBox.ShowError("您输入的密码已失效或尚未审批通过！");
                this.DialogResult = System.Windows.Forms.DialogResult.No;
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnApplyPassword_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.Text.Trim() == string.Empty)
            {
                XMessageBox.ShowError("请输入要申请的密码！");
                return;
            }

            XPassWordTmpBusiness business = this.m_Business as XPassWordTmpBusiness;
            XPassWordTmpInfo passwordTmpInfo = business.GetTempPasswordInfo(XCommon.LoginUsersInfo.RID)
                as XPassWordTmpInfo;

            if (passwordTmpInfo != null)
            {
                XMessageBox.ShowError("已存在有效期内的密码，请不要重复申请！");
                return;
            }

            int validDays = XHelper.GetInt(ConfigurationManager.AppSettings["PassworkValidDays"]);

            XPassWordTmpInfo newInfo = new XPassWordTmpInfo();
            newInfo.RID = Guid.NewGuid().ToString();
            newInfo.Password = this.txtPassword.Text.Trim();
            newInfo.UseStartTime = XHelper.GetFormatedTime(DateTime.Now);
            newInfo.UseEndTime = XHelper.GetFormatedTime(DateTime.Now.AddDays(validDays));
            newInfo.UserId = XCommon.LoginUsersInfo.RID;
            newInfo.UserName = XCommon.LoginUsersInfo.UserName;
            newInfo.UseIP = XNetHelper.GetLocalIP4Address();
            if (business.Insert(newInfo))
            {
                XMessageBox.ShowRemindMessage("密码申请成功，请等待审核！");
            }
            else
            {
                XMessageBox.ShowError("密码申请失败！");
            }
        }
    }
}
