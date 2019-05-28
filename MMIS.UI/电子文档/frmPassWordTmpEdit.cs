using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.UI.Common;
using MMIS.Model;
using MMIS.Helper;
using System.Net;

namespace MMIS.UI
{
    public partial class frmPassWordTmpEdit : frmEditBase
    {

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XPassWordTmpBusiness m_PassWordTmpBusiness = new XPassWordTmpBusiness();

        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmPassWordTmpEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;

            this.txtUseIP.Text = XNetHelper.GetLocalIP4Address();
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmPassWordTmpEdit(XModelBase currentModel)
        {
            InitializeComponent();
            this.m_CurrentModel = currentModel;
            this.m_EditStatus = XEditStatus.Edit;
            this.SetDefaultValue();
        }


        #endregion


        /// <summary>
        /// 获取业务操作对象
        /// </summary>
        /// <returns></returns>
        protected override XBusinessBase InitBusiness()
        {
            return new XPassWordTmpBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XPassWordTmpInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XPassWordTmpInfo info = this.m_CurrentModel as XPassWordTmpInfo;

            this.txtPassDesc.Text = info.PassDesc;
            this.txtUserId.Text = info.UserId;
            this.txtUserName.Text = info.UserName;
            this.txtPassStateId.Text = info.PassStateId;
            this.txtUseIP.Text = info.UseIP;
            this.dtUseStartTime.Value = XHelper.GetDateTime(info.UseStartTime);
            this.dtUseEndTime.Value = XHelper.GetDateTime(info.UseEndTime);
            this.nebUseLimit.Value = info.UseLimit;
            this.chkIsTelAudit.Checked = info.IsTelAudit;
            this.txtPassword.Text = info.Password;
            this.txtRepassword.Text = info.Password;

            this.txtRemark.Text = info.Remark;
        }


        /// <summary>
        /// 自定义UI校验
        /// </summary>
        /// <returns></returns>
        protected override bool ValidateCustom()
        {
            if (this.txtPassword.Text.Trim() != this.txtRepassword.Text.Trim())
            {
                XMessageBox.ShowError("两次输入的密码不一致！");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 填充实体信息
        /// </summary>
        protected override void FillModelInfo()
        {
            XPassWordTmpInfo info = this.m_CurrentModel as XPassWordTmpInfo;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                info.RID = this.GetNewId();
                info.ID = info.RID;

                info.UserId = XCommon.LoginUsersInfo.RID;
                info.UserName = XCommon.LoginUsersInfo.UserName;
            }

            info.PassDesc = this.txtPassDesc.Text;

            info.PassStateId = this.txtPassStateId.Text;
            info.UseIP = this.txtUseIP.Text;
            info.UseStartTime = XHelper.GetFormatedTime(this.dtUseStartTime.Value);
            info.UseEndTime = XHelper.GetFormatedTime(this.dtUseEndTime.Value);
            info.UseLimit = XHelper.GetInt(this.nebUseLimit.Value);
            info.IsTelAudit = this.chkIsTelAudit.Checked;
            info.Remark = this.txtRemark.Text;
            info.Password = this.txtPassword.Text.Trim();

            base.FillModelInfo();
        }

        protected override bool IsNeedCheck
        {
            get
            {
                return true;
            }
        }
    }
}