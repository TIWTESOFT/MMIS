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
    public partial class frmEquipmentCertPrintEdit : frmEditBase
    {
        public frmEquipmentCertPrintEdit()
        {
            InitializeComponent();
        }

        public frmEquipmentCertPrintEdit(XModelBase model)
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

            this.cboEquipmentType.Text = info.EquipmentType;
            this.txtEquipmentNo.Text = info.EquipmentNo;
            this.txtEquipmentCustId.Text = info.CustName;
            this.txtSpec.Text = info.Spec;
            this.txtModel.Text = info.Model;
            this.nebQuanlity.Value = info.Quanlity;
            //this.dtLastCheckDate.Value = XHelper.GetDateTime(info.LastCheckDate);
            this.cboSourceTypeId.Text = info.SourceTypeId;
            //this.txtSourceCustId.Text = info.SourceCustId;
            this.dtSourceTime.Value = XHelper.GetDateTime(info.SourceTime);


            this.txtReceiveDesc.Text = info.ReceiveDesc;
            this.txtReceiveUser.Text = info.ReceiveUserName;
            this.txtCheckedDesc.Text = info.CheckedDesc;

            //签发描述
            this.txtSignedDesc.Text = info.SignedDesc;

            //检定员
            this.txtCheckedUserName.Text = info.CheckedUserName;
            //核验员
            this.txtVerifyUserName.Text = info.VerifyedUserName;
            //核验描述
            this.txtVerifyDesc.Text = info.VerifyedDesc;
            //签发员
            this.txtSignedUserName.Text = info.SignedUserName;

            //收发员
            this.txtDispatchUserName.Text = XCommon.LoginUsersInfo.RealName;

            this.txtFactoryName.Text = info.FactoryName;
            this.txtFactoryNo.Text = info.FactoryNo;
            this.txtCheckAccord.Text = info.CheckAccord;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPrintPreview frm = new frmPrintPreview(this.m_CurrentModel as XVEquipmentReceiveInfo, true);
            frm.ShowDialog();
        }

    }
}
