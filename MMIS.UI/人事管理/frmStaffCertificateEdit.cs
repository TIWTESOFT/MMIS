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
using System.IO;

namespace MMIS.UI
{
    public partial class frmStaffCertificateEdit : frmEditBase
    {

        private XFileAttachmentBusiness m_FileAttachBusiness = new XFileAttachmentBusiness();

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XStaffCertificateBusiness m_StaffCertificateBusiness = new XStaffCertificateBusiness();

        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmStaffCertificateEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmStaffCertificateEdit(XModelBase currentModel)
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
            return new XStaffCertificateBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVStaffCertificateInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVStaffCertificateInfo info = this.m_CurrentModel as XVStaffCertificateInfo;

            if (info.UserId != string.Empty)
            {
                this.txtUserId.Text = info.UserName;
                this.txtUserId.ValueMember = info.UserId;
                this.txtUserId.DisplayMember = info.UserName;
            }

            this.m_PrimaryKeyId = info.RID;

            this.txtCertName.Text = info.CertName;
            this.txtCertNo.Text = info.CertNo;
            this.dtCertGetTime.Value = XHelper.GetDateTime(info.CertGetTime);
            this.dtRegisterDate.Value = XHelper.GetDateTime(info.RegisterDate);
            this.dtNextRegisterDate.Value = XHelper.GetDateTime(info.NextRegisterDate);
            this.txtCertItem.Text = info.CertItem;
            this.txtRemark.Text = info.Remark;

            this.btnPreviewCert.Enabled = true;
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
            XVStaffCertificateInfo info = this.m_CurrentModel as XVStaffCertificateInfo;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                info.RID = this.GetNewId();
                info.ID = info.RID;
            }

            info.UserId = this.txtUserId.ValueMember;
            info.UserName = this.txtUserId.DisplayMember;
            info.CertName = this.txtCertName.Text;
            info.CertNo = this.txtCertNo.Text;
            info.CertGetTime = XHelper.GetFormatedDate(this.dtCertGetTime.Value);
            info.CertItem = this.txtCertItem.Text;
            info.Remark = this.txtRemark.Text;
            info.RegisterDate = XHelper.GetFormatedDate(this.dtRegisterDate.Value);
            info.NextRegisterDate = XHelper.GetFormatedDate(this.dtNextRegisterDate.Value);

            base.FillModelInfo();
        }

        private void txtRemark_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRemark_Click(object sender, EventArgs e)
        {

        }

        private void frmStaffCertificateEdit_Load(object sender, EventArgs e)
        {

        }

        private void txtFilePath_ButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtFilePath.Text = ofd.FileName;
            }
        }

        private void txtFilePath_DoubleClick(object sender, EventArgs e)
        {
            txtFilePath_ButtonClick(null, null);
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(this.txtFilePath.Text.Trim()))
            {
                FileInfo fileInfo = new FileInfo(this.txtFilePath.Text.Trim());
                if (this.txtCertName.Text.Trim() == string.Empty)
                {
                    this.txtCertName.Text = fileInfo.Name;
                }
            }
        }

        protected override void SavedAfterOperate()
        {
            string filePath = this.txtFilePath.Text.Trim();

            if (filePath != string.Empty)
            {
                if (File.Exists(filePath))
                {
                    XStaffCertificateInfo fileInfo = this.m_CurrentModel as XStaffCertificateInfo;

                    if (!this.m_FileAttachBusiness.InsertFile(Guid.NewGuid().ToString(),
                        fileInfo.RID, filePath, XCommon.LoginUsersInfo.RID))
                    {
                        XMessageBox.ShowError("上传附件失败，请点击修改重新上传附件！");
                    }
                }
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            XFilePreviewTool.Preview(this.m_PrimaryKeyId);
        }
    }
}