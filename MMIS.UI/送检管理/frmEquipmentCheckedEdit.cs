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
using MMIS.BLL;

namespace MMIS.UI
{
    public partial class frmEquipmentCheckedEdit : frmEditBase
    {
        private XStandardBusiness m_StandardBusiness = new BLL.XStandardBusiness();

        public frmEquipmentCheckedEdit(XModelBase model)
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
            this.dtReceiveDate.Value=XHelper.GetDateTime(info.ReceiveDate);
            //============================================

            if (XHelper.GetDateTime(info.CheckedDate).Date == new DateTime(2000, 1, 1).Date)
            {
                this.dtCheckedDate.Value = DateTime.Now;
            }
            else
            {
                this.dtCheckedDate.Value = XHelper.GetDateTime(info.CheckedDate);
            }
            this.txtReceiveDesc.Text = info.ReceiveDesc;
            this.txtReceiveUser.Text = info.ReceiveUserName;

            if (info.VerifyUserId != string.Empty)
            {
                this.txtVerifyUserId.Text = info.VerifyUserName;
                this.txtVerifyUserId.DisplayMember = info.VerifyUserName;
                this.txtVerifyUserId.ValueMember = info.VerifyUserId;
            }

            if (info.StandId != string.Empty)
            {
                this.txtStandId.Text = info.StandName;
                this.txtStandId.ValueMember = info.StandId;
                this.txtStandId.DisplayMember = info.StandName;
            }
            else
            {
                //20151019,mxj,add
                if (info.CurrentStatus == "接收")
                {
                    string sqlget = "select * from CodeEquipmentType where rid='" + info.EquipmentType + "'";
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
                    string val = "";
                    if (ishad)
                    {
                        disname = dt.Rows[0]["SpellHeader"] + "";
                        val = dt.Rows[0]["Spell"] + "";

                        this.txtStandId.Text = disname;
                        this.txtStandId.ValueMember = val;
                        this.txtStandId.DisplayMember = disname;
                    }

                }
            }

            this.txtCheckedReport.Text = info.CheckedReport;
            this.txtCheckedDesc.Text = info.CheckedDesc;

            this.txtFactoryName.Text = info.FactoryName;
            this.txtFactoryNo.Text = info.FactoryNo;
            this.txtCheckAccord.Text = info.CheckAccord;
        }

        protected override void FillModelInfo()
        {
            XVEquipmentReceiveInfo info = this.m_CurrentModel as XVEquipmentReceiveInfo;

            info.CheckedDesc = this.txtCheckedDesc.Text.Trim();
            info.CheckedReport = this.txtCheckedReport.Text.Trim();
            info.VerifyUserId = this.txtVerifyUserId.ValueMember;
            info.VerifyUserName = this.txtVerifyUserId.DisplayMember;
            info.CheckedDate = XHelper.GetFormatedDate(this.dtCheckedDate.Value);
            info.CurrentStatus = "检定";
            info.FlowStatus = "核验";
            info.StandId = this.txtStandId.ValueMember;
            info.StandName = this.txtStandId.DisplayMember;

            info.IsBack = false;
            info.BackDate = string.Empty;
            info.BackReason = string.Empty;
            info.BackUserName = string.Empty;
            info.BackUserId = string.Empty;

            info.ReportFileFullName = this.txtFilePath.Text.Trim();
        }

        protected override bool SaveEdit()
        {
            XEquipmentReceiveBusiness business = this.m_Business as XEquipmentReceiveBusiness;
            return business.Checked(this.m_CurrentModel, XCommon.LoginUsersInfo.RID);
        }

        private void txtFilePath_ButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Word报告文件(*.doc,*.docx)|*.doc;*.docx";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtFilePath.Text = ofd.FileName;
            }
        }

        private void txtFilePath_DoubleClick(object sender, EventArgs e)
        {
            this.txtFilePath_ButtonClick(null, null);
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            string fileName = this.txtFilePath.Text.Trim();
            if (fileName != string.Empty)
            {
                FileInfo fileInfo = new FileInfo(this.txtFilePath.Text.Trim());
                this.txtCheckedReport.Text = fileInfo.Name;
            }
        }

        protected override bool ValidataForm()
        {
            XEquipmentReceiveBusiness business = this.m_Business as XEquipmentReceiveBusiness;

            string status = business.GetStatus(this.m_CurrentModel.ID);
            if (status != "接收" && status != "检定")
            {
                XMessageBox.ShowError("当前状态为：[" + status + "]，不能检定！");
                return false;
            }

            string standId = this.txtStandId.ValueMember;

            if (standId == string.Empty)
            {
                XMessageBox.ShowError("请选择计量标准！");
                return false;
            }

            if (this.txtCheckedReport.Text.Trim() == string.Empty)
            {
                XMessageBox.ShowError("请上传检定报告！");
                return false;
            }

            if (this.m_StandardBusiness.IsToCheck(standId))
            {
                if (XMessageBox.ShowQuestion("选择的标准或标准下的设备已送检，是否继续？") ==
                    System.Windows.Forms.DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
