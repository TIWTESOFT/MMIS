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
    public partial class frmStandFilesEdit : frmEditBase
    {

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XStandFilesBusiness m_StandFilesBusiness = new XStandFilesBusiness();

        private XFileAttachmentBusiness m_FileAttachBusiness = new XFileAttachmentBusiness();

        #region 构造函数

        public frmStandFilesEdit()
        {
            InitializeComponent();
        }

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmStandFilesEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmStandFilesEdit(XModelBase currentModel)
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
            return new XStandFilesBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVStandFilesInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVStandFilesInfo info = this.m_CurrentModel as XVStandFilesInfo;

            if (info.MainId != string.Empty)
            {
                this.txtMainId.Text = info.StandName;
                this.txtMainId.DisplayMember = info.StandName;
                this.txtMainId.ValueMember = info.MainId;
            }
            this.txtFileName.Text = info.FileName;
            this.txtFileNo.Text = info.FileNo;
            this.txtFileDesc.Text = info.FileDesc;
            this.txtRemark.Text = info.Remark;
            this.chkIsMaxVersion.Checked = info.IsMaxVersion;
            this.chkIsNeedCheck.Checked = info.IsNeedCheck;
            this.dtNextCheckDate.Value = XHelper.GetDateTime(info.NextCheckDate);
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
            XVStandFilesInfo info = this.m_CurrentModel as XVStandFilesInfo;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                info.RID = this.GetNewId();
            }

            info.MainId = this.txtMainId.ValueMember;
            info.StandName = this.txtMainId.DisplayMember;
            info.FileName = this.txtFileName.Text;
            info.FileNo = this.txtFileNo.Text;
            info.FileDesc = this.txtFileDesc.Text;
            info.Remark = this.txtRemark.Text;
            info.IsMaxVersion = this.chkIsMaxVersion.Checked;

            info.FileFullName = this.txtFilePath.Text.Trim();
            info.IsNeedCheck = this.chkIsNeedCheck.Checked;
            info.NextCheckDate = XHelper.GetFormatedDate(this.dtNextCheckDate.Value);

            base.FillModelInfo();
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
                this.txtFileName.Text = fileInfo.Name;
            }
        }

        protected override void SavedAfterOperate()
        {
            string filePath = this.txtFilePath.Text.Trim();

            if (filePath != string.Empty)
            {
                if (File.Exists(filePath))
                {
                    XStandFilesInfo fileInfo = this.m_CurrentModel as XStandFilesInfo;

                    if (!this.m_FileAttachBusiness.InsertFile(Guid.NewGuid().ToString(),
                        fileInfo.RID, filePath, XCommon.LoginUsersInfo.RID))
                    {
                        XMessageBox.ShowError("上传附件失败，请点击修改重新上传附件！");
                    }
                }
            }
        }
    }
}