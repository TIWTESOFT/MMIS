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

namespace MMIS.UI
{
    public partial class frmUsersEdit : frmEditBase
    {

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XUsersBusiness m_UsersBusiness = new XUsersBusiness();

        private string m_OldUserName = string.Empty;
        private string m_OldRealName = string.Empty;

        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmUsersEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmUsersEdit(XModelBase currentModel)
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
            return new XUsersBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVUsersInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVUsersInfo info = this.m_CurrentModel as XVUsersInfo;

            if (info.UserType != string.Empty)
            {
                this.txtUserType.Text = info.UserTypeName;
                this.txtUserType.ValueMember = info.UserType;
                this.txtUserType.DisplayMember = info.UserTypeName;
            }

            this.txtUserName.Text = info.UserName;
            this.txtRealName.Text = info.RealName;
            this.nebNameNum.Value = info.NameNum;
            this.txtPassWord.Text = info.PassWord;
            this.txtRepass.Text = info.PassWord;
            this.txtUserState.Text = info.UserState;
            this.chkIsAdmin.Checked = info.IsAdmin;
            this.chkIsUsed.Checked = info.IsUsed;
            this.txtAuditTel.Text = info.AuditTel;
            this.chkIsDownPower.Checked = info.IsDownPower;
            this.nebOrderIndex.Value = info.OrderIndex;
            this.txtRemark.Text = info.Remark;

            this.m_OldUserName = this.txtUserName.Text.Trim();
            this.m_OldRealName = this.txtRealName.Text.Trim();

            this.txtPassWord.Enabled = false;
            this.txtRepass.Enabled = false;
        }


        /// <summary>
        /// 自定义UI校验
        /// </summary>
        /// <returns></returns>
        protected override bool ValidateCustom()
        {
            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                if (this.txtPassWord.Text.Trim() != this.txtRepass.Text.Trim())
                {
                    XMessageBox.ShowError("两次密码输入的不一致!");
                    return false;
                }
            }

            bool isValidateExist = false;
            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                isValidateExist = true;
            }
            else if (this.m_EditStatus == XEditStatus.Edit)
            {
                if (this.m_OldUserName != this.txtUserName.Text.Trim())
                {
                    isValidateExist = true;
                }
            }

            if (isValidateExist)
            {
                if (this.m_Business.IsExist(this.txtUserName.Text.Trim()))
                {
                    XMessageBox.ShowError("用户名已存在！");
                    return false;
                }
            }

            bool isValidateRealNameExist = false;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                isValidateRealNameExist = true;
            }
            else if (this.m_EditStatus == XEditStatus.Edit)
            {
                if (this.m_OldRealName != this.txtRealName.Text.Trim())
                {
                    isValidateRealNameExist = true;
                }
            }

            if (isValidateRealNameExist && this.m_UsersBusiness.IsRealNameExist(this.txtRealName.Text.Trim()))
            {
                XMessageBox.ShowError("真实姓名已存在！");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 填充实体信息
        /// </summary>
        protected override void FillModelInfo()
        {
            XVUsersInfo info = this.m_CurrentModel as XVUsersInfo;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                info.RID = this.GetNewId();
                info.ID = info.RID;
            }

            info.UserType = this.txtUserType.ValueMember;
            info.UserTypeName = this.txtUserType.DisplayMember;
            info.UserName = this.txtUserName.Text;
            info.RealName = this.txtRealName.Text;
            info.NameNum = XHelper.GetInt(this.nebNameNum.Value);
            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                if (this.m_EditStatus == XEditStatus.AddNew)
                {
                    XEncodeAndDecodeBase encodeTool = XEncodeAndDecodeContext.GetEncodeAndDecodeTool(EncodeType.Md5);
                    info.PassWord = encodeTool.Encode(this.txtPassWord.Text);
                }
            }
            info.UserState = this.txtUserState.Text;
            info.IsAdmin = this.chkIsAdmin.Checked;
            info.IsUsed = this.chkIsUsed.Checked;
            info.AuditTel = this.txtAuditTel.Text;
            info.IsDownPower = this.chkIsDownPower.Checked;
            info.OrderIndex = XHelper.GetInt(this.nebOrderIndex.Value);
            info.Remark = this.txtRemark.Text;

            base.FillModelInfo();
        }
    }
}