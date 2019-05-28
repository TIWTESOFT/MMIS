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
    public partial class frmEquipmentReceiveEdit : frmEditBase
    {

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XEquipmentReceiveBusiness m_EquipmentReceiveBusiness = new XEquipmentReceiveBusiness();

        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmEquipmentReceiveEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmEquipmentReceiveEdit(XModelBase currentModel)
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
            return new XEquipmentReceiveBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVEquipmentReceiveInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVEquipmentReceiveInfo info = this.m_CurrentModel as XVEquipmentReceiveInfo;

            if (info.EquipmentCheckId != string.Empty)
            {
                this.txtEquipmentCheckId.Text = info.EquipmentName;
                this.txtEquipmentCheckId.DisplayMember = info.EquipmentName;
                this.txtEquipmentCheckId.ValueMember = info.EquipmentCheckId;
            }
            if (info.CheckUserId != string.Empty)
            {
                this.txtCheckUserId.Text = info.CheckUserName;
                this.txtCheckUserId.ValueMember = info.CheckUserId;
                this.txtCheckUserId.DisplayMember = info.CheckUserName;
            }

            this.txtRemark.Text = info.Remark;

            this.cboEquipmentType.Text = info.EquipmentTypeName;
            this.txtEquipmentNo.Text = info.EquipmentNo;
            this.txtEquipmentCustId.Text = info.CustName;
            this.txtSpec.Text = info.Spec;
            this.txtModel.Text = info.Model;
            this.nebQuanlity.Value = info.Quanlity;
            this.dtLastCheckDate.Value = XHelper.GetDateTime(info.LastCheckDate);
            this.cboSourceTypeId.Text = info.SourceTypeId;
            this.txtSourceCustId.Text = info.SourceCustId;
            this.dtSourceTime.Value = XHelper.GetDateTime(info.SourceTime);

            this.dtReceive.Value = XHelper.GetDateTime(info.ReceiveDate);
            this.txtReceiveDesc.Text = info.ReceiveDesc;

            this.txtFactoryName.Text = info.FactoryName;
            this.txtFactoryNo.Text = info.FactoryNo;
            this.txtCheckAccord.Text = info.CheckAccord;
        }


        /// <summary>
        /// 自定义UI校验
        /// </summary>
        /// <returns></returns>
        protected override bool ValidateCustom()
        {
            XEquipmentReceiveBusiness business = this.m_Business as XEquipmentReceiveBusiness;

            if (this.m_EditStatus == XEditStatus.Edit)
            {
                string status = business.GetStatus(this.m_CurrentModel.ID);
                if (status != "接收")
                {
                    XMessageBox.ShowError("当前状态为：[" + status + "]，不能修改！");
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 填充实体信息
        /// </summary>
        protected override void FillModelInfo()
        {
            XVEquipmentReceiveInfo info = this.m_CurrentModel as XVEquipmentReceiveInfo;

            info.EquipmentCheckId = this.txtEquipmentCheckId.ValueMember;
            info.EquipmentName = this.txtEquipmentCheckId.DisplayMember;
            info.CheckUserId = this.txtCheckUserId.ValueMember;
            info.CheckUserName = this.txtCheckUserId.DisplayMember;
            info.Remark = this.txtRemark.Text;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                info.RID = this.GetNewId();
                info.ID = info.RID;
            }

            info.EquipmentType = this.cboEquipmentType.Text;
            info.EquipmentNo = this.txtEquipmentNo.Text;
            info.CustName = this.txtEquipmentCustId.Text;
            info.Spec = this.txtSpec.Text;
            info.Model = this.txtModel.Text;
            info.Quanlity = XHelper.GetInt(this.nebQuanlity.Value);
            info.LastCheckDate = XHelper.GetFormatedDate(this.dtLastCheckDate.Value);
            info.SourceTypeId = this.cboSourceTypeId.Text;
            info.SourceCustId = this.txtSourceCustId.Text;
            info.SourceTime = XHelper.GetFormatedDate(this.dtSourceTime.Value);

            info.ReceiveDate = XHelper.GetFormatedDate(this.dtReceive.Value);
            info.ReceiveDesc = this.txtReceiveDesc.Text.Trim();

            info.ReceiveUserId = XCommon.LoginUsersInfo.RID;
            //info.ReceiveUserName = XCommon.LoginUsersInfo.UserName;

            info.CurrentStatus = "接收";
            info.FlowUserId = this.txtCheckUserId.ValueMember;
            info.FlowStatus = "检定";

            base.FillModelInfo();
        }

        private void txtEquipmentCheckId_TextChanged(object sender, EventArgs e)
        {
            XModelBase selectedModel = this.txtEquipmentCheckId.SelectedModel;

            if (this.txtEquipmentCheckId.SelectedModel != null)
            {
                XVEquipmentCheckInfo equipmentCheckInfo = selectedModel as XVEquipmentCheckInfo;

                this.cboEquipmentType.Text = equipmentCheckInfo.EquipmentTypeName;
                this.txtEquipmentNo.Text = equipmentCheckInfo.EquipmentNo;
                this.txtEquipmentCustId.Text = equipmentCheckInfo.CustName;
                this.txtSpec.Text = equipmentCheckInfo.Spec;
                this.txtModel.Text = equipmentCheckInfo.Model;
                //2015-08-10，mxj,add增加，数量=====================
                if (equipmentCheckInfo.Quanlity > 0)
                {
                    this.nebQuanlity.Value = equipmentCheckInfo.Quanlity;
                }
                //============================================
                this.dtLastCheckDate.Value = XHelper.GetDateTime(equipmentCheckInfo.LastCheckDate);
                this.cboSourceTypeId.Text = equipmentCheckInfo.SourceTypeId;
                //this.txtSourceCustId.Text = equipmentCheckInfo.SourceCustId;//2015-07-13,dell
                this.dtSourceTime.Value = XHelper.GetDateTime(equipmentCheckInfo.SourceTime);

                this.txtFactoryName.Text = equipmentCheckInfo.FactoryName;
                this.txtFactoryNo.Text = equipmentCheckInfo.FactoryNo;
                this.txtCheckAccord.Text = equipmentCheckInfo.CheckAccord;

                //2016-3-29，mxj,add======================
                this.dtReceive.Value = XHelper.GetDateTime(equipmentCheckInfo.UseTime);
                //========================================

                //2015-07-13,mxj,add===========================
                if (equipmentCheckInfo.SourceCustId != null && equipmentCheckInfo.SourceCustId != "")
                {
                    string sqlget = "select * from StaffInfo where rid='" + equipmentCheckInfo.SourceCustId + "'";
                    DataTable dt = new DataTable();
                    dt = SQLHelper.GetDataSet(sqlget);
                    bool ishad = false;
                    if (dt != null)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            ishad = true;
                        }
                    }
                    string disname = "";
                    if (ishad)
                    {
                        disname = dt.Rows[0]["UserName"] + "";
                    }
                    else
                    {
                        disname = equipmentCheckInfo.SourceCustId;
                    }
                    this.txtCheckUserId.Text = disname;
                    this.txtCheckUserId.ValueMember = equipmentCheckInfo.SourceCustId;
                    this.txtCheckUserId.DisplayMember = disname;
                }

            }
            else
            {
                this.cboEquipmentType.Text = string.Empty;
                this.txtEquipmentNo.Text = string.Empty;
                this.txtEquipmentCustId.Text = string.Empty;
                this.txtSpec.Text = string.Empty;
                this.txtModel.Text = string.Empty;
                //this.nebQuanlity.Value = 0;
                //this.dtLastCheckDate.Value = XHelper.GetDateTime(equipmentCheckInfo.LastCheckDate);
                this.cboSourceTypeId.Text = string.Empty;
                this.txtSourceCustId.Text = string.Empty;
                //this.dtSourceTime.Value = XHelper.GetDateTime(equipmentCheckInfo.SourceTime);
            }
        }

    }
}