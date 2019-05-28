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
    public partial class frmEquipmentCheckEdit : frmEditBase
    {

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XEquipmentCheckBusiness m_EquipmentCheckBusiness = new XEquipmentCheckBusiness();

        private string m_OldEquipmentNo = string.Empty;

        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmEquipmentCheckEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;

            grpupdate.Enabled = false;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmEquipmentCheckEdit(XModelBase currentModel)
        {
            InitializeComponent();
            this.m_CurrentModel = currentModel;
            this.m_EditStatus = XEditStatus.Edit;
            this.SetDefaultValue();

            grpupdate.Enabled = true;
        }


        #endregion

        /// <summary>
        /// 获取业务操作对象
        /// </summary>
        /// <returns></returns>
        protected override XBusinessBase InitBusiness()
        {
            return new XEquipmentCheckBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVEquipmentCheckInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVEquipmentCheckInfo info = this.m_CurrentModel as XVEquipmentCheckInfo;

            if (info.EquipmentType != string.Empty)
            {
                this.txtEquipmentType.Text = info.EquipmentTypeName;
                this.txtEquipmentType.DisplayMember = info.EquipmentTypeName;
                this.txtEquipmentType.ValueMember = info.EquipmentType;
            }
            //this.cboEquipmentType.Text = info.EquipmentType;

            if (info.EquipmentCustId != string.Empty)
            {
                this.txtEquipmentCustId.Text = info.CustName;
                this.txtEquipmentCustId.DisplayMember = info.CustName;
                this.txtEquipmentCustId.ValueMember = info.EquipmentCustId;
            }
            this.txtEquipmentName.Text = info.EquipmentName;
            this.txtFactoryNo.Text = info.FactoryNo;
            this.txtSpec.Text = info.Spec;
            this.txtModel.Text = info.Model;
            this.txtFactoryName.Text = info.FactoryName;
            this.dtSourceTime.Value = XHelper.GetDateTime(info.SourceTime);
            this.dtUseTime.Value = XHelper.GetDateTime(info.UseTime);

            this.cboSourceTypeId.Text = info.SourceTypeId;
            if (info.EquipmentStatusId != string.Empty)
            {
                this.txtEquipmentStatusId.Text = info.EquipmentState;
                this.txtEquipmentStatusId.DisplayMember = info.EquipmentState;
                this.txtEquipmentStatusId.ValueMember = info.EquipmentStatusId;
            }
            this.cboSignStatus.Text = info.SignStatus;
            this.nebQuanlity.Value = info.Quanlity;
            this.txtLinkMan.Text = info.LinkMan;
            //2016-11-21,mxj,modify
            this.txtTel.Text = info.Tel;
            //this.txtTel.Text = info.MobileNo;
            this.txtEmail.Text = info.Email;
            this.txtCheckAccord.Text = info.CheckAccord;
            this.dtLastCheckDate.Value = XHelper.GetDateTime(info.LastCheckDate);
            this.txtCheckResult.Text = info.CheckResult;
            this.dtValidDate.Value = XHelper.GetDateTime(info.ValidDate);
            this.txtCertNo.Text = info.CertNo;
            this.txtEquipmentDesc.Text = info.EquipmentDesc;
            this.txtRemark.Text = info.Remark;

            this.txtEquipmentNo.Text = info.EquipmentNo;
            this.txtBillNo.Text = info.BillNo;


            //this.txtSourceCustId.Text = info.SourceCustId;
            //2015-07-13,mxj,add============================
            if (info.SourceCustId != string.Empty)
            {
                string sqlget = "select * from StaffInfo where rid='" + info.SourceCustId + "'";
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
                    disname = info.SourceCustId;
                }
                this.txtCheckUserId.Text = disname;
                this.txtCheckUserId.ValueMember = info.SourceCustId;
                this.txtCheckUserId.DisplayMember = disname;
            }

            if (this.m_EditStatus == XEditStatus.Edit)
            {
                // info.EquipmentName = this.txtEquipmentName.Text;

                if (cbodevselect.Items != null)
                {
                    for (int i = 0; i < cbodevselect.Items.Count; i++)
                    {
                        cbodevselect.Items.RemoveAt(0);
                    }
                }

                cbodevselect.Items.Add(info.EquipmentName, info.EquipmentName);
                cbodevselect.SelectedIndex = 0;
            }


            m_OldEquipmentNo = this.txtEquipmentNo.Text.Trim();
        }


        /// <summary>
        /// 自定义UI校验
        /// </summary>
        /// <returns></returns>
        protected override bool ValidateCustom()
        {
            bool isValidateExist = false;

            string equipmentNo = this.txtEquipmentNo.Text.Trim();

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                isValidateExist = true;
            }
            else if (this.m_OldEquipmentNo != equipmentNo)
            {
                isValidateExist = true;
            }

            if (isValidateExist)
            {
                if (this.m_EquipmentCheckBusiness.IsEquipmentNoExist(equipmentNo))
                {
                    XMessageBox.ShowError("设备编号已存在！");
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
            XVEquipmentCheckInfo info = this.m_CurrentModel as XVEquipmentCheckInfo;

            if (this.m_EditStatus == XEditStatus.AddNew || chkcopy.Checked)
            {
                info.RID = this.GetNewId();
                info.ID = info.RID;
            }

            info.EquipmentType = this.txtEquipmentType.ValueMember;
            info.EquipmentTypeName = this.txtEquipmentType.DisplayMember;
            info.EquipmentCustId = this.txtEquipmentCustId.ValueMember;
            info.CustName = this.txtEquipmentCustId.DisplayMember;
            info.EquipmentName = this.txtEquipmentName.Text;
            info.FactoryNo = this.txtFactoryNo.Text;
            info.Spec = this.txtSpec.Text;
            info.Model = this.txtModel.Text;
            info.FactoryName = this.txtFactoryName.Text;
            info.SourceTime = XHelper.GetFormatedDate(this.dtSourceTime.Value);
            info.UseTime = XHelper.GetFormatedDate(this.dtUseTime.Value);
            //info.SourceCustId = this.txtSourceCustId.Text;//2015-07-13,mxj,del
            info.SourceTypeId = this.cboSourceTypeId.Text;
            info.EquipmentStatusId = this.txtEquipmentStatusId.ValueMember;
            info.EquipmentState = this.txtEquipmentStatusId.DisplayMember;
            info.SignStatus = this.cboSignStatus.Text;
            info.Quanlity = XHelper.GetInt(this.nebQuanlity.Value);
            info.LinkMan = this.txtLinkMan.Text;
            info.MobileNo = this.txtTel.Text;
            info.Tel = this.txtTel.Text;//2016-11-21,mxj,启动，实现单条送检设备联系人及电话修改后同步问题
            info.Email = this.txtEmail.Text;
            info.CheckAccord = this.txtCheckAccord.Text;
            info.LastCheckDate = XHelper.GetFormatedDate(this.dtLastCheckDate.Value);

            //2015-07-13,mxj,add=======================
            info.SourceCustId = this.txtCheckUserId.ValueMember;


            //20151019,mxj,临时借用传递指定检定人名称===
            //2015-07-13,mxj,add===========================
            if (info.SourceCustId != null && info.SourceCustId != "")
            {
                string sqlget = "select * from StaffInfo where rid='" + info.SourceCustId + "'";
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
                    info.CheckResult = disname;
                }


            }

            //==========================================
            info.ValidDate = XHelper.GetFormatedDate(this.dtValidDate.Value);
            info.CertNo = this.txtCertNo.Text;
            info.EquipmentDesc = this.txtEquipmentDesc.Text;
            info.Remark = this.txtRemark.Text;

            info.BillNo = this.txtBillNo.Text.Trim();




            info.EquipmentNo = this.txtEquipmentNo.Text.Trim();

            if (this.txtEquipmentStatusId.SelectedModel != null)
            {
                XCodeEquipmentStateInfo stateInfo = this.txtEquipmentStatusId.SelectedModel as XCodeEquipmentStateInfo;
                info.ColorRGB = stateInfo.ColorRGB;
            }

            base.FillModelInfo();
        }

        private void txtEquipmentCustId_TextChanged(object sender, EventArgs e)
        {
            if (this.txtEquipmentCustId.SelectedModel != null)
            {
                XEquipmentCustInfo custInfo = this.txtEquipmentCustId.SelectedModel as XEquipmentCustInfo;

                this.txtLinkMan.Text = custInfo.LinkPeople;
                this.txtTel.Text = custInfo.MobileNo;// WorkTel;
                this.txtEmail.Text = custInfo.Email;
            }
        }

        private void txtEquipmentType_TextChanged(object sender, EventArgs e)
        {
            XCodeEquipmentTypeInfo checkTypeInfo = this.txtEquipmentType.SelectedModel as XCodeEquipmentTypeInfo;

            XEquipmentCheckBusiness business = this.m_Business as XEquipmentCheckBusiness;

            if (checkTypeInfo != null)
            {
                if (this.txtEquipmentNo.Text.Trim() == string.Empty)
                {
                    //生成设备编号
                    string equipmentNo = business.GetEquipmentNo(checkTypeInfo.RuleCode);
                    this.txtEquipmentNo.Text = equipmentNo;


                }


                string sqlget = "select * from codedef where NameEN='EquipmentType' and ParentID='" + checkTypeInfo.RID + "'";
                DataTable dt = new DataTable();
                dt = SQLHelper.GetDataSet(sqlget);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        if (cbodevselect.Items != null)
                        {
                            for (int i = 0; i < cbodevselect.Items.Count; i++)
                            {
                                cbodevselect.Items.RemoveAt(0);
                                i--;
                            }
                        }

                        cbodevselect.DataSource = dt;
                        cbodevselect.DisplayMember = "NameCN";
                        cbodevselect.ValueMember = "RID";

                    }
                }
            }
        }

        /// <summary>
        /// 2016-11-24,mxj,add,自动填充规格
        /// </summary>
        private void BandCobo()
        {
            if (cbodevselect.Text == "")
            {
                return;
            }
            try
            {
                string sqlget = "select * from codedef where NameEN='EquipmentTypeSpec' and ParentID='" + cbodevselect.SelectedValue.ToString() + "'";
                DataTable dt = new DataTable();
                dt = SQLHelper.GetDataSet(sqlget);

                if (cbospec.Items != null)
                {
                    for (int i = 0; i < cbospec.Items.Count; i++)
                    {
                        cbospec.Items.RemoveAt(0);
                        i--;
                    }
                }

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        cbospec.DataSource = dt;
                        cbospec.DisplayMember = "NameCN";
                        cbospec.ValueMember = "RID";

                        cbospec.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cbodevselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEquipmentName.Text = cbodevselect.Text;
            //2016-11-24,mxj,add,自动填充规格
            //cbospec

            BandCobo();

        }

        private void frmEquipmentCheckEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.m_EditStatus == XEditStatus.AddNew)
                {
                    string sqlget = "select * from CodeEquipmentState where NameCn='正常'";
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
                    string disrid = "";
                    string color = "";
                    if (ishad)
                    {
                        disname = dt.Rows[0]["NameCn"] + "";
                        disrid = dt.Rows[0]["Rid"] + "";
                        color = dt.Rows[0]["ColorRGB"] + "";
                    }

                    if (disname != "")
                    {
                        this.txtEquipmentStatusId.Text = disname;
                        this.txtEquipmentStatusId.DisplayMember = disname;
                        this.txtEquipmentStatusId.ValueMember = disrid;
                    }

                    chkcopy.Enabled = false;
                    chknumtb.Enabled = false;
                }
                else
                {
                    chkcopy.Enabled = true;
                    chknumtb.Enabled = true;
                }

            }
            catch (Exception ex)
            {

            }

        }

        protected override bool SaveAdd()
        {
            XEquipmentCheckBusiness business = this.m_Business as XEquipmentCheckBusiness;
            //this.m_CurrentModel.ModelStatus == XModelStatus.Add;
            return business.Checked(this.m_CurrentModel, XCommon.LoginUsersInfo.RID);


        }

        protected override bool SaveEdit()
        {
            XEquipmentCheckBusiness business = this.m_Business as XEquipmentCheckBusiness;
            if (chkcopy.Checked==false)
            {
                //2016-11-21,mxj,add
                if (chknumtb.Checked)
                {
                    XVEquipmentCheckInfo info = this.m_CurrentModel as XVEquipmentCheckInfo;
                    string sql = "update  EquipmentReceive set Quanlity=" + XHelper.GetInt(this.nebQuanlity.Value) + " ,ReceiveDate='" + dtUseTime.Value.ToString("yyyy-MM-dd") + " 00:00:00' ";
                    string sqlwhere = " where  EquipmentCheckId='" + info.RID + "'";

                    if (chkCheckedDate.Checked)
                    {
                        sql = sql + " , CheckedDate='" + dtCheckedDate.Value.ToString("yyyy-MM-dd")  + " 00:00:00'";
                    }
                    if (chkVerifyedDate.Checked)
                    {
                        sql = sql + " , VerifyedDate='" + dtVerifyedDate.Value.ToString("yyyy-MM-dd") + " 00:00:00'";
                    }
                    if (chkSignedDate.Checked)
                    {
                        sql = sql + " , SignedDate='" + dtSignedDate.Value.ToString("yyyy-MM-dd") + " 00:00:00'";
                    }


                    sql = sql + sqlwhere;
                   
                    if (SQLHelper.ExecuteCommand(sql) > 0)
                    {
     
                    
                    }
                }
                return business.Update(this.m_CurrentModel);

            }
            else
            {
                this.m_CurrentModel.ModelStatus = XModelStatus.Add;
                 
                return business.Checked(this.m_CurrentModel, XCommon.LoginUsersInfo.RID);
            }



        }
        /// <summary>
        /// 2016-11-24,mxj,add,自动填充规格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbospec_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSpec.Text = cbospec.Text;
        }





    }
}