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
    public partial class frmStandCodeEquipmentEdit : frmEditBase
    {

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XStandCodeEquipmentBusiness m_StandCodeEquipmentBusiness = new XStandCodeEquipmentBusiness();

        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmStandCodeEquipmentEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmStandCodeEquipmentEdit(XModelBase currentModel)
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
            return new XStandCodeEquipmentBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVStandCodeEquipmentInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVStandCodeEquipmentInfo info = this.m_CurrentModel as XVStandCodeEquipmentInfo;

            this.cboEquipmentType.Text = info.EquipmentType;
            this.txtEquipmentCustId.Text = info.EquipmentCustId;
            this.txtEquipmentName.Text = info.EquipmentName;
            this.txtFactoryNo.Text = info.FactoryNo;
            this.txtSpec.Text = info.Spec;
            this.txtModel.Text = info.Model;
            this.txtFactoryName.Text = info.FactoryName;
            this.dtSourceTime.Value = XHelper.GetDateTime(info.SourceTime);
            this.dtUseTime.Value = XHelper.GetDateTime(info.UseTime);
            this.txtSourceCustId.Text = info.SourceCustId;
            this.cboSourceTypeId.Text = info.SourceTypeId;
            if (info.EquipmentStatusId != string.Empty)
            {
                this.txtEquipmentStatusId.Text = info.EquipStatus;
                this.txtEquipmentStatusId.ValueMember = info.EquipmentStatusId;
                this.txtEquipmentStatusId.DisplayMember = info.EquipStatus;
            }
            
            this.txtSignStatus.Text = info.SignStatus;
            this.nebQuanlity.Value = info.Quanlity;
            this.txtLinkMan.Text = info.LinkMan;
            this.txtTel.Text = info.Tel;
            this.txtEmail.Text = info.Email;
            this.txtCheckAccord.Text = info.CheckAccord;
            this.dtLastCheckDate.Value = XHelper.GetDateTime(info.LastCheckDate);
            this.txtCheckResult.Text = info.CheckResult;
            this.dtValidDate.Value = XHelper.GetDateTime(info.ValidDate);
            this.txtCertNo.Text = info.CertNo;
            this.txtEquipmentDesc.Text = info.EquipmentDesc;
            this.txtRemark.Text = info.Remark;
            this.txtEquipmentNo.Text = info.EquipmentNo;
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
            XVStandCodeEquipmentInfo info = this.m_CurrentModel as XVStandCodeEquipmentInfo;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                info.RID = this.GetNewId();
            }

            info.EquipmentType = this.cboEquipmentType.Text;
            info.EquipmentCustId = this.txtEquipmentCustId.Text;
            info.EquipmentName = this.txtEquipmentName.Text;
            info.FactoryNo = this.txtFactoryNo.Text;
            info.Spec = this.txtSpec.Text;
            info.Model = this.txtModel.Text;
            info.FactoryName = this.txtFactoryName.Text;
            info.SourceTime = XHelper.GetFormatedDate(this.dtSourceTime.Value);
            info.UseTime = XHelper.GetFormatedDate(this.dtUseTime.Value);
            info.SourceCustId = this.txtSourceCustId.Text;
            info.SourceTypeId = this.cboSourceTypeId.Text;
            info.EquipmentStatusId = this.txtEquipmentStatusId.ValueMember;
            info.EquipStatus = this.txtEquipmentStatusId.DisplayMember;
            info.SignStatus = this.txtSignStatus.Text;
            info.Quanlity = XHelper.GetInt(this.nebQuanlity.Value);
            info.LinkMan = this.txtLinkMan.Text;
            info.Tel = this.txtTel.Text;
            info.Email = this.txtEmail.Text;
            info.CheckAccord = this.txtCheckAccord.Text;
            info.LastCheckDate = XHelper.GetFormatedDate(this.dtLastCheckDate.Value);
            info.CheckResult = this.txtCheckResult.Text;
            info.ValidDate = XHelper.GetFormatedDate(this.dtValidDate.Value);
            info.CertNo = this.txtCertNo.Text;
            info.EquipmentDesc = this.txtEquipmentDesc.Text;
            info.Remark = this.txtRemark.Text;
            info.EquipmentNo = this.txtEquipmentNo.Text;

            base.FillModelInfo();
        }
    }
}