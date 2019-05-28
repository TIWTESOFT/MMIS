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
    public partial class frmEquipmentCustEdit : frmEditBase
    {
    
       /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XEquipmentCustBusiness m_EquipmentCustBusiness = new XEquipmentCustBusiness();
        
        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmEquipmentCustEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmEquipmentCustEdit(XModelBase currentModel)
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
            return new XEquipmentCustBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVEquipmentCustInfo();
        }
        
          /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVEquipmentCustInfo info = this.m_CurrentModel as XVEquipmentCustInfo;

            if (info.CustTypeId != string.Empty)
            {
                this.txtCustTypeId.Text = info.CustTypeNameCN;
                this.txtCustTypeId.DisplayMember = info.CustTypeNameCN;
                this.txtCustTypeId.ValueMember = info.CustTypeId;
            }
            this.txtCustName.Text = info.CustName;
            this.txtCustNo.Text = info.CustNo;
            this.txtCustAddress.Text = info.CustAddress;
            this.txtLinkPeople.Text = info.LinkPeople;
            this.txtMobileNo.Text = info.MobileNo;
            this.txtWorkTel.Text = info.WorkTel;
            this.txtEmail.Text = info.Email;
            this.txtWebSite.Text = info.WebSite;
            this.txtCustDesc.Text = info.CustDesc;
            this.txtRemark.Text = info.Remark;

            this.txtInvoiceTitle.Text = info.InvoiceTitle;
            this.txtTaxNo.Text = info.TaxNo;
            this.txtBank.Text = info.BankName;
            this.txtAccountNo.Text = info.BankAccountNo;
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
            XVEquipmentCustInfo info = this.m_CurrentModel as XVEquipmentCustInfo;
            //2016-11-21,mxj,add || chkcopy.Checked
            if (this.m_EditStatus == XEditStatus.AddNew || chkcopy.Checked)
            {
                info.RID = this.GetNewId();
                //2016-11-21,mxj,add
                info.ID = info.RID;
            }

            info.CustTypeId = this.txtCustTypeId.ValueMember;
            info.CustTypeNameCN = this.txtCustTypeId.DisplayMember;
            info.CustName = this.txtCustName.Text;
            info.CustNo = this.txtCustNo.Text;
            info.CustAddress = this.txtCustAddress.Text;
            info.LinkPeople = this.txtLinkPeople.Text;
            info.MobileNo = this.txtMobileNo.Text;
            info.WorkTel = this.txtWorkTel.Text;
            info.Email = this.txtEmail.Text;
            info.WebSite = this.txtWebSite.Text;
            info.CustDesc = this.txtCustDesc.Text;
            info.Remark = this.txtRemark.Text;

            info.BankAccountNo = this.txtAccountNo.Text.Trim();
            info.BankName = this.txtBank.Text.Trim();
            info.TaxNo = this.txtTaxNo.Text.Trim();
            info.InvoiceTitle = this.txtInvoiceTitle.Text.Trim();
            
            base.FillModelInfo();
        }

        //2016-11-21,mxj,add
        private void frmEquipmentCustEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.m_EditStatus == XEditStatus.AddNew)
                {
                    chkcopy.Enabled = false;
                }
                else
                {
                    chkcopy.Enabled = true;
                }

            }
            catch (Exception ex)
            {

            }

        }

        //2016-11-21,mxj,add
        private void chkcopy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkcopy.Enabled)
            {
                if (chkcopy.Checked)
                {
                    this.m_EditStatus = XEditStatus.AddNew;
                    this.m_CurrentModel.ModelStatus = XModelStatus.Add;
                }
                else
                {
                    this.m_EditStatus = XEditStatus.Edit;
                    this.m_CurrentModel.ModelStatus = XModelStatus.Modify;
                }
            }
        }


    }
}