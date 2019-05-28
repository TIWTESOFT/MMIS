using MMIS.BLL;
using MMIS.Helper;
using MMIS.Model;
using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMIS.UI
{
    public partial class frmEquipmentVerifyedEdit : frmEditBase
    {
        public frmEquipmentVerifyedEdit()
        {
            InitializeComponent();
        }

        public frmEquipmentVerifyedEdit(XModelBase model)
            : base(model)
        {
            InitializeComponent();
            this.SetDefaultValue();
        }

        /// <summary>
        /// 获取业务操作对象
        /// </summary>
        /// <returns></returns>
        protected override XBusinessBase InitBusiness()
        {
            return new XEquipmentReceiveBusiness();
        }

        protected override void SetDefaultValue()
        {
            XVEquipmentReceiveInfo info = this.m_CurrentModel as XVEquipmentReceiveInfo;

            if (info.EquipmentCheckId != string.Empty)
            {
                this.txtEquipmentCheckId.Text = info.EquipmentName;
                this.txtEquipmentCheckId.DisplayMember = info.EquipmentName;
                this.txtEquipmentCheckId.ValueMember = info.EquipmentCheckId;
            }

            this.cboEquipmentType.Text = info.EquipmentTypeName;
            this.txtEquipmentNo.Text = info.EquipmentNo;
            this.txtEquipmentCustId.Text = info.CustName;
            this.txtSpec.Text = info.Spec;
            this.txtModel.Text = info.Model;
            this.nebQuanlity.Value = info.Quanlity;
            //this.dtLastCheckDate.Value = XHelper.GetDateTime(info.LastCheckDate);
            this.cboSourceTypeId.Text = info.SourceTypeId;
            //this.txtSourceCustId.Text = info.SourceCustId;
            this.dtSourceTime.Value = XHelper.GetDateTime(info.SourceTime);
            //2016-03-39,mxj,add==========================
            this.dtCheckedDate.Value = XHelper.GetDateTime(info.CheckedDate);
            //============================================

            this.txtReceiveDesc.Text = info.ReceiveDesc;
            this.txtReceiveUser.Text = info.ReceiveUserName;
            this.txtCheckedDesc.Text = info.CheckedDesc;

            //指定签收员
            if (info.SignUserId != string.Empty)
            {
                this.txtSignUserId.ValueMember = info.SignUserId;
                this.txtSignUserId.DisplayMember = info.SignUserName;
                this.txtSignUserId.Text = info.SignUserName;
            }

            //核验时间
            if (XHelper.GetDateTime(info.VerifyedDate).Date == new DateTime(2000, 1, 1).Date)
            {
                this.dtVerifyedDate.Value = DateTime.Now;
            }
            else
            {
                this.dtVerifyedDate.Value = XHelper.GetDateTime(info.VerifyedDate);
            }

            //核验描述
            this.txtVerifyedDesc.Text = info.VerifyedDesc;

            //检定员
            this.txtCheckedUserName.Text = info.CheckedUserName;

            this.txtFactoryName.Text = info.FactoryName;
            this.txtFactoryNo.Text = info.FactoryNo;
            this.txtCheckAccord.Text = info.CheckAccord;
        }

        protected override void FillModelInfo()
        {
            XVEquipmentReceiveInfo info = this.m_CurrentModel as XVEquipmentReceiveInfo;

            info.SignUserId = this.txtSignUserId.ValueMember;
            info.SignUserName = this.txtSignUserId.DisplayMember;
            info.VerifyedDate = XHelper.GetFormatedDate(this.dtVerifyedDate.Value);
            info.VerifyedDesc = this.txtVerifyedDesc.Text.Trim();
            info.CurrentStatus = "核验";
            info.FlowStatus = "签发";

            info.IsBack = this.chkIsBack.Checked;
            info.BackReason = this.txtBackReason.Text.Trim();
            info.BackUserId = XCommon.LoginUsersInfo.RID;
            info.BackStatus = info.CurrentStatus;

        }

        protected override bool SaveEdit()
        {
            XEquipmentReceiveBusiness business = this.m_Business as XEquipmentReceiveBusiness;
            if (this.chkIsBack.Checked)
            {
                //退回重新检定
                return business.Back(this.m_CurrentModel);
            }
            else
            {
                return business.Verify(this.m_CurrentModel, XCommon.LoginUsersInfo.RID);
            }
        }

        protected override bool ValidataForm()
        {
            XEquipmentReceiveBusiness business = this.m_Business as XEquipmentReceiveBusiness;

            string status = business.GetStatus(this.m_CurrentModel.ID);
            if (status != "核验" && status != "检定")
            {
                XMessageBox.ShowError("当前状态为：[" + status + "]，不能核验！");
                return false;
            }

            return true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPrintPreview frm = new frmPrintPreview(this.m_CurrentModel as XVEquipmentReceiveInfo, false);
            frm.ShowDialog();
        }
    }
}
