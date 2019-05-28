using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.Helper;
using MMIS.Component;
using MMIS.Model;
using MMIS.BLL;

namespace MMIS.UI.Common
{
    /// <summary>
    /// frmEditBase 窗口
    /// 名称: 编辑窗体基类
    /// 功能: 
    /// 时间: 6/23/2011 3:52:44 PM
    /// 作者: Wss
    /// </summary>
    public partial class frmEditBase : frmBase
    {
        #region 构造和析构

        protected IList<XModelBase> m_ModelList;

        protected XModelBase m_SelectedTreeModel;

        public IList<XModelBase> ModelList
        {
            get { return this.m_ModelList; }
        }

        protected XModelBase m_CurrentModel;
        protected XBusinessBase m_Business;

        public XModelBase CurrentModel
        {
            get { return this.m_CurrentModel; }
        }

        protected XFormValidateTool m_FormValidateTool = new XFormValidateTool();

        public frmEditBase()
        {
            InitializeComponent();
            this.m_Business = this.InitBusiness();
            this.m_EditStatus = XEditStatus.AddNew;
        }

        public frmEditBase(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_Business = this.InitBusiness();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        public frmEditBase(XModelBase currentModel)
        {
            InitializeComponent();
            this.m_Business = this.InitBusiness();
            this.m_CurrentModel = currentModel;
            this.m_EditStatus = XEditStatus.Edit;
        }

        #endregion // 构造和析构

        #region 公有方法

        #endregion // 公有方法

        #region 保护方法

        /// <summary>
        /// 初始化业务实体
        /// </summary>
        protected virtual XBusinessBase InitBusiness()
        {
            return new XBusinessBase();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        protected virtual bool Save()
        {
            bool isSuccess = false;
            try
            {
                isSuccess = this.SaveOperate();
                this.m_ErrorInfo = "";
            }
            catch (Exception ex)
            {
                this.m_ErrorInfo = ex.ToString();
            }
            if (isSuccess == false)
            {
                //如果保存失败，必须弹出失败的消息
                this.ShowSaveMessage(isSuccess);
            }
            else
            {
                //如果保存成功，则需要判断是否弹出保存消息
                if (this.GetIsShowSaveMessage())
                {
                    this.ShowSaveMessage(isSuccess);
                }
            }
            return isSuccess;
        }

        protected virtual bool GetIsShowSaveMessage()
        {
            return true;
        }

        protected virtual void SetDefaultValue()
        {

        }

        /// <summary>
        /// 保存执行的操作
        /// </summary>
        /// <returns></returns>
        protected virtual bool SaveOperate()
        {
            bool isSaveSuccess = false;

            if (this.m_EditStatus == XEditStatus.AddNew || this.m_EditStatus == XEditStatus.AddContinue ||
                this.m_EditStatus == XEditStatus.Copy)
            {
                //添加、继续添加、复制
                this.m_CurrentModel = this.InitNewModel();
                this.m_CurrentModel.ModelStatus = XModelStatus.Add;
                this.m_PrimaryKeyId = this.GetNewId();
                this.m_CurrentModel.ID = this.m_PrimaryKeyId;
                this.FillModelInfo();
                isSaveSuccess = this.SaveAdd();
                if (isSaveSuccess)
                {
                    if (this.m_ModelList != null)
                    {
                        //添加成功则执行
                        this.m_ModelList.Add(this.m_CurrentModel);
                    }
                }
            }
            else if (this.m_EditStatus == XEditStatus.Edit)
            {
                this.m_CurrentModel.ModelStatus = XModelStatus.Modify;
                this.FillModelInfo();
                isSaveSuccess = this.SaveEdit();
                if (isSaveSuccess)
                {

                }
            }
            return isSaveSuccess;
        }

        /// <summary>
        /// 获取新的主键
        /// </summary>
        /// <returns></returns>
        protected virtual string GetNewId()
        {
            //return DateTime.Now.ToString("yyyyMMddHHmmssfffffff");
            return Guid.NewGuid().ToString();
        }

        /// <summary>
        /// 初始化新实体
        /// </summary>
        /// <returns></returns>
        protected virtual XModelBase InitNewModel()
        {
            return new XModelBase();
        }

        /// <summary>
        /// 填充实体信息
        /// </summary>
        protected virtual void FillModelInfo()
        {
            if (this.m_EditStatus == XEditStatus.AddNew || this.m_EditStatus == XEditStatus.AddContinue)
            {
                this.m_CurrentModel.InputUserId = XCommon.LoginUsersInfo.RID;
                this.m_CurrentModel.InputTime = XHelper.GetFormatedTime(DateTime.Now);
                this.m_CurrentModel.UpdateUserId = XCommon.LoginUsersInfo.RID;
                this.m_CurrentModel.UpdateTime = XHelper.GetFormatedTime(DateTime.Now);
                this.m_CurrentModel.ModelStatus = XModelStatus.Add;
            }
            else if (this.m_EditStatus == XEditStatus.Edit)
            {
                this.m_CurrentModel.UpdateUserId = XCommon.LoginUsersInfo.RID;
                this.m_CurrentModel.UpdateTime = XHelper.GetFormatedTime(DateTime.Now);
                this.m_CurrentModel.ModelStatus = XModelStatus.Modify;
            }
        }

        /// <summary>
        /// 保存添加
        /// </summary>
        /// <returns></returns>
        protected virtual bool SaveAdd()
        {
            return this.m_Business.Insert(this.m_CurrentModel);
        }

        /// <summary>
        /// 保存修改
        /// </summary>
        /// <returns></returns>
        protected virtual bool SaveEdit()
        {
            return this.m_Business.Update(this.m_CurrentModel);
        }

        /// <summary>
        /// 显示保存的消息
        /// </summary>
        /// <param name="isSuccess">是否保存成功</param>
        protected virtual void ShowSaveMessage(bool isSuccess)
        {
            string showMessage = "";
            if (isSuccess)
            {
                showMessage = "保存成功！";
            }
            else
            {
                showMessage = "保存失败";
            }
            //获取追加的消息
            this.GetAppendShowMessage(isSuccess);
            if (this.m_ErrorInfo.Trim() != string.Empty && isSuccess == false)
            {
                showMessage += this.m_ErrorInfo;
            }
            if (this.m_AppendShowMessage.Trim() != string.Empty)
            {
                showMessage += m_AppendShowMessage;
            }
            XMessageBox.ShowRemindMessage(showMessage);
        }

        /// <summary>
        /// 获取追加的要显示的消息
        /// </summary>
        /// <returns></returns>
        protected virtual string GetAppendShowMessage(bool isSuccess)
        {
            return "";
        }

        /// <summary>
        /// 关闭
        /// </summary>
        protected virtual void Cancel()
        {
            this.Close();
        }

        /// <summary>
        /// 数据校验
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidataForm()
        {
            return this.ValidateCommon() && this.ValidateCustom();
        }

        /// <summary>
        /// 公共数据校验
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateCommon()
        {
            bool validateControls = this.m_FormValidateTool.ValidateControls(this);
            if (!validateControls)
            {
                return false;
            }

            //if (IsNeedSend && this.m_EditStatus == XEditStatus.Edit)
            //{
            //    if (this.m_Business.IsSend(this.m_CurrentModel))
            //    {
            //        XMessageBox.ShowError("本记录已发布，不能修改！");
            //        return false;
            //    }
            //}

            //if (IsNeedCommit && this.m_EditStatus == XEditStatus.Edit)
            //{
            //    if (this.m_Business.IsCommit(this.m_CurrentModel))
            //    {
            //        XMessageBox.ShowError("本记录已提交，不能修改！");
            //        return false;
            //    }
            //}

            if (this.m_EditStatus == XEditStatus.Edit && IsNeedCheck &&
                this.m_Business.IsCheck(this.m_CurrentModel))
            {
                XMessageBox.ShowError("选择的记录已审核，不能修改！");
                return false;
            }

            return true;
        }


        /// <summary>
        /// 是否审核
        /// </summary>
        protected virtual bool IsNeedCheck
        {
            get { return false; }
        }

        /// <summary>
        /// 是否审核
        /// </summary>
        protected virtual bool IsNeedCommit
        {
            get { return false; }
        }

        /// <summary>
        /// 自定义数据校验
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateCustom()
        {
            return true;
        }

        /// <summary>
        /// 是否需要已存在校验
        /// </summary>
        /// <param name="editStatus"></param>
        /// <param name="control"></param>
        /// <returns></returns>
        protected virtual bool IsNeedExistValidata(XEditStatus editStatus, Control control)
        {
            //是否已存在校验
            bool isNeedValidateTypeExist = false;

            if (editStatus == XEditStatus.AddNew || editStatus == XEditStatus.Copy ||
                              editStatus == XEditStatus.AddContinue)
            {
                isNeedValidateTypeExist = true;
            }
            else if (this.m_EditStatus == XEditStatus.Edit)
            {
                if (control.Tag.ToString().Trim() != control.Text.Trim())
                {
                    isNeedValidateTypeExist = true;
                }
            }

            return isNeedValidateTypeExist;
        }

        /// <summary>
        /// 绑定下拉列表
        /// </summary>
        protected virtual void BindCombobox()
        {

        }

        #endregion // 保护方法

        #region 私有方法

        /// <summary>
        /// 保存按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            SaveFunction();
        }

        protected virtual void SaveFunction()
        {
            if (ValidataForm() == false)
            {
                return;
            }
            if (this.Save())
            {
                this.SavedAfterOperate();
                if (this.IsAllowAddContinue)
                {
                    //允许继续添加
                    this.m_IsCloseAfterSaved = false;
                    this.btnOk.Text = "继续添加";
                    this.Text += "[继续添加]";
                }
                if (this.m_IsCloseAfterSaved)
                {
                    this.Close();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
        }

        /// <summary>
        /// 保存后执行的操作
        /// </summary>
        protected virtual void SavedAfterOperate()
        {

        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Cancel();
        }

        protected virtual void SetControlTextByEditStatus()
        {
            switch (this.m_EditStatus)
            {
                case XEditStatus.AddNew:
                    this.Text += "[添加]";
                    this.btnOk.Text = "保存";
                    break;
                case XEditStatus.Copy:
                    this.Text += "[复制]";
                    this.btnOk.Text = "复制";
                    break;
                case XEditStatus.Edit:
                    this.Text += "[编辑]";
                    this.btnOk.Text = "保存";
                    break;
                default:
                    this.btnOk.Text = "保存";
                    break;
            }
        }


        private void frmEditBase_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.FormLoadFunction(sender, e);
            }
        }

        #endregion // 私有方法

        #region 属性及其私有变量

        /// <summary>
        /// 是否允许继续添加
        /// </summary>
        protected virtual bool IsAllowAddContinue
        {
            get { return false; }
        }

        /// <summary>
        /// 当前操作状态
        /// </summary>
        protected XEditStatus m_EditStatus = XEditStatus.AddNew;

        /// <summary>
        /// 保存结束后是否关闭窗体
        /// </summary>
        protected bool m_IsCloseAfterSaved = true;

        /// <summary>
        /// 追加的显示消息
        /// </summary>
        protected string m_AppendShowMessage = "";

        /// <summary>
        /// 要复制的记录
        /// </summary>
        protected DataRow m_CopyRow;

        /// <summary>
        /// 主键
        /// </summary>
        protected string m_PrimaryKeyId = "";

        /// <summary>
        /// 操作时间
        /// </summary>
        protected DateTime m_OperateTime;

        #endregion // 属性及其私有变量

        public virtual string VoucherTypeCode
        {
            get { return string.Empty; }
        }

        /// <summary>
        /// 是否需要发布，需要的话，则在修改时将校验是否已发布
        /// </summary>
        protected virtual bool IsNeedSend
        {
            get { return false; }
        }
    }
}
