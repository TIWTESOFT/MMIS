using MMIS.BLL;
using MMIS.Helper;
using MMIS.Model;
using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMIS.UI
{
    public partial class frmEquipmentSignedEdit : frmEditBase
    {
        public frmEquipmentSignedEdit()
        {
            InitializeComponent();
        }

        public frmEquipmentSignedEdit(XModelBase model)
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

            //指定收发员
            if (info.DispatchUserId != string.Empty)
            {
                this.txtDispatchUserId.ValueMember = info.DispatchUserId;
                this.txtDispatchUserId.DisplayMember = info.DispatchUserName;
                this.txtDispatchUserId.Text = info.DispatchUserName;
            }

            //签发时间
            if (XHelper.GetDateTime(info.SignedDate).Date == new DateTime(2000, 1, 1).Date)
            {
                this.dtSignedDate.Value = DateTime.Now;
            }
            else
            {
                this.dtSignedDate.Value = XHelper.GetDateTime(info.SignedDate);
            }

            //签发描述
            this.txtSignedDesc.Text = info.SignedDesc;

            //检定员
            this.txtCheckedUserName.Text = info.CheckedUserName;
            //核验员
            this.txtVerifyUserName.Text = info.VerifyedUserName;
            //核验描述
            this.txtVerifyDesc.Text = info.VerifyedDesc;

            this.txtFactoryName.Text = info.FactoryName;
            this.txtFactoryNo.Text = info.FactoryNo;
            this.txtCheckAccord.Text = info.CheckAccord;
        }

        protected override void FillModelInfo()
        {
            XVEquipmentReceiveInfo info = this.m_CurrentModel as XVEquipmentReceiveInfo;

            info.DispatchUserId = this.txtDispatchUserId.ValueMember;
            info.DispatchUserName = this.txtDispatchUserId.DisplayMember;
            info.SignedDate = XHelper.GetFormatedDate(this.dtSignedDate.Value);
            info.SignedDesc = this.txtSignedDesc.Text.Trim();
            info.CurrentStatus = "签发";
            info.FlowStatus = "制证";

            if (this.txtFilePath.Text.Trim() != string.Empty)
            {
                FileInfo fileInfo = new FileInfo(this.txtFilePath.Text.Trim());
                info.PdfReportFileName = fileInfo.Name;
            }
            info.PdfReportFileFullName = this.txtFilePath.Text.Trim();

            info.IsBack = this.chkIsBack.Checked;
            info.BackReason = this.txtBackReason.Text.Trim();
            info.BackUserId = XCommon.LoginUsersInfo.RID;
            info.BackStatus = info.CurrentStatus;
        }

        protected override bool ValidataForm()
        {
            XEquipmentReceiveBusiness business = this.m_Business as XEquipmentReceiveBusiness;

            string status = business.GetStatus(this.m_CurrentModel.ID);
            if (status != "核验" && status != "签发")
            {
                XMessageBox.ShowError("当前状态为：[" + status + "]，不能签发！");
                return false;
            }

            //XEquipmentReceiveInfo receiveInfo = this.m_CurrentModel as XEquipmentReceiveInfo;
            //if (receiveInfo.PdfReportFileName == string.Empty)
            //{
            //    if (this.txtFilePath.Text.Trim() == string.Empty)
            //    {
            //        XMessageBox.ShowError("请上传PDF报告！");
            //        return false;
            //    }
            //}

            return true;
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
                return business.Sign(this.m_CurrentModel, XCommon.LoginUsersInfo.RID);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPrintPreview frm = new frmPrintPreview(this.m_CurrentModel as XVEquipmentReceiveInfo, false);
            frm.ShowDialog();
        }

        private void txtFilePath_ButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "pdf报告(*.pdf)|*.pdf";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtFilePath.Text = ofd.FileName;
            }
        }

        private void txtFilePath_DoubleClick(object sender, EventArgs e)
        {
            txtFilePath_ButtonClick(null, null);
        }

    }
}
