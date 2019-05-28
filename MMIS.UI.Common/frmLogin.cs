using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.Model;
using MMIS.BLL;
using MMIS.Helper;
using System.Configuration;

namespace MMIS.UI.Common
{
    public partial class frmLogin : frmBase
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public XUsersInfo m_UserInfo = null;

        /// <summary>
        /// 登录的用户信息
        /// </summary>
        public XUsersInfo LoginUsersInfo
        {
            get { return this.m_UserInfo; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                XUsersBusiness usersBusiness = new XUsersBusiness();
                //if (usersBusiness.GetServerTime() >= new DateTime(2014, 2, 28))
                //{
                //    XMessageBox.ShowError("出现异常，无法登录！");
                //    return;
                //}

                if (this.ValidateLogin())
                {
                    this.m_UserInfo = this.GetLoginUsersInfo();
                    if (this.m_UserInfo == null)
                    {
                        XMessageBox.ShowError("用户名或者密码错误！");
                        return;
                    }

                    if (this.m_UserInfo.IsUsed == false)
                    {
                        XMessageBox.ShowError("该用户不可用！");
                        return;
                    }

                    XCommon.LoginUsersInfo = this.m_UserInfo.Clone() as XUsersInfo;
                    if (this.m_UserInfo != null)
                    {
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        try
                        {
                            this.LoginLog();
                        }
                        catch (Exception ex)
                        {
                            XErrorLogTool.WriteLog(ex.ToString());
                        }
                    }
                    this.RememberLoginUser();
                }
            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.Message);
                XErrorLogTool.WriteLog(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void LoginLog()
        {
            XLoginLogBusiness loginLogBusiness = new XLoginLogBusiness();

            string id = Guid.NewGuid().ToString();
            XCommon.LoginId = id;
            loginLogBusiness.Login(id, this.txtUserName.Text.Trim());
        }

        private void RememberLoginUser()
        {
            IList<XAppSettingInfo> settingInfos = new List<XAppSettingInfo>();

            string isRemember = this.chkRememberUser.Checked ? "Y" : "N";
            XAppSettingInfo rememberInfo = new XAppSettingInfo();
            rememberInfo.Key = "IsRememberUserId";
            rememberInfo.Value = isRemember;
            settingInfos.Add(rememberInfo);

            string loginUser = this.txtUserName.Text.Trim();
            XAppSettingInfo userInfo = new XAppSettingInfo();
            userInfo.Key = "LoginUserId";
            userInfo.Value = this.txtUserName.Text.Trim();
            settingInfos.Add(userInfo);

            XAppSettingHelper.Save(settingInfos);
        }

        /// <summary>
        /// 获取登录信息
        /// </summary>
        /// <returns></returns>
        private XVUsersInfo GetLoginUsersInfo()
        {
            XVUsersInfo usersInfo = null;

            XUsersBusiness usersBusiness = new XUsersBusiness();

            string where = " and UserName='{0}' and Password='{1}'";
            XEncodeAndDecodeBase tool = XEncodeAndDecodeContext.GetEncodeAndDecodeTool(EncodeType.Md5);
            string password = tool.Encode(this.txtPassWord.Text.Trim());
            string userId = this.txtUserName.Text.Trim();
            where = string.Format(where, userId, password);
          
            IList<XModelBase> models = usersBusiness.QueryViewByWhere(where);
            if (models.Count > 0)
            {
                usersInfo = models[0] as XVUsersInfo;
                return usersInfo;
            }
            return usersInfo;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 校验登录
        /// </summary>
        /// <returns></returns>
        protected bool ValidateLogin()
        {
            this.errorProvider.Clear();

            if (this.txtUserName.Text.Trim() == string.Empty)
            {
                this.txtUserName.Focus();
                this.errorProvider.SetError(this.txtUserName, "用户名不能为空！");
                return false;
            }

            if (this.txtPassWord.Text.Trim() == string.Empty)
            {
                this.txtPassWord.Focus();
                this.errorProvider.SetError(this.txtPassWord, "用户名不能为空！");
                return false;
            }

            return true;
        }

        private void tmWelcome_Tick(object sender, EventArgs e)
        {
            if (this.lblWelcome.Right <= 0)
            {
                //如果已经移出左侧
                this.lblWelcome.Left = this.lblWelcome.Parent.Width - 30;
            }
            else
            {
                this.lblWelcome.Left -= 10;
            }
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            bool isRemember = ConfigurationManager.AppSettings["IsRememberUserId"] == "Y";
            if (isRemember)
            {
                this.txtUserName.Text = ConfigurationManager.AppSettings["LoginUserId"];
            }
            this.chkRememberUser.Checked = isRemember;
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            base.FormLoadFunction(sender, e);

            this.lblSystem.Text = ConfigurationManager.AppSettings["SystemName"];
            this.Text = this.lblSystem.Text;
            this.lblWelcome.Text = "欢迎使用" + this.Text;
        }
    }
}
