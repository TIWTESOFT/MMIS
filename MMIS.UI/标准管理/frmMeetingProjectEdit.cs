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
    public partial class frmMeetingProjectEdit : frmEditBase
    {
    
       /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XMeetingProjectBusiness m_MeetingProjectBusiness = new XMeetingProjectBusiness();
        
        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmMeetingProjectEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmMeetingProjectEdit(XModelBase currentModel)
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
            return new XMeetingProjectBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVMeetingProjectInfo();
        }
        
          /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVMeetingProjectInfo info = this.m_CurrentModel as XVMeetingProjectInfo;

            this.txtProjectName.Text = info.ProjectName;
            this.txtProjectDesc.Text = info.ProjectDesc;
            this.dtStartTime.Value = XHelper.GetDateTime(info.StartTime);
            this.dtEndTime.Value = XHelper.GetDateTime(info.EndTime);
            this.txtPurveyor.Text = info.Purveyor;
            this.txtLinkman.Text = info.Linkman;
            this.txtTel.Text = info.Tel;

            if (info.ProjectTypeId != string.Empty)
            {
                this.txtProjectTypeId.Text = info.ProjectType;
                this.txtProjectTypeId.ValueMember = info.ProjectTypeId;
                this.txtProjectTypeId.DisplayMember = info.ProjectType;
            }

            if (info.DeptId != string.Empty)
            {
                this.txtDeptId.Text = info.DeptName;
                this.txtDeptId.ValueMember = info.DeptId;
                this.txtDeptId.DisplayMember = info.DeptName;
            }

            this.txtRemark.Text = info.Remark;
        }
        
        
        /// <summary>
        /// 自定义UI校验
        /// </summary>
        /// <returns></returns>
        protected override bool ValidateCustom()
        {
            return true;
        }

        /// <summary>
        /// 填充实体信息
        /// </summary>
        protected override void FillModelInfo()
        {
            XVMeetingProjectInfo info = this.m_CurrentModel as XVMeetingProjectInfo;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                info.RID = this.GetNewId();
            }

            info.ProjectName = this.txtProjectName.Text;
            info.ProjectDesc = this.txtProjectDesc.Text;
            info.StartTime = XHelper.GetFormatedDate(this.dtStartTime.Value);
            info.EndTime = XHelper.GetFormatedDate(this.dtEndTime.Value);
            info.Purveyor = this.txtPurveyor.Text;
            info.Linkman = this.txtLinkman.Text;
            info.Tel = this.txtTel.Text;
            info.ProjectTypeId = this.txtProjectTypeId.ValueMember;
            info.ProjectType = this.txtProjectTypeId.DisplayMember;
            info.DeptId = this.txtDeptId.ValueMember;
            info.DeptName = this.txtDeptId.DisplayMember;
            info.Remark = this.txtRemark.Text;
            
            base.FillModelInfo();
        }
    }
}