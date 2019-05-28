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
    public partial class frmTaskAttachmentEdit : frmEditBase
    {

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XTaskAttachmentBusiness m_TaskAttachmentBusiness = new XTaskAttachmentBusiness();

        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmTaskAttachmentEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmTaskAttachmentEdit(XModelBase currentModel)
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
            return new XTaskAttachmentBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVTaskAttachmentInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVTaskAttachmentInfo info = this.m_CurrentModel as XVTaskAttachmentInfo;

            this.txtMainId.Text = info.MainId;
            this.txtFileName.Text = info.FileName;
            this.txtFileDesc.Text = info.FileDesc;
            this.txtRemark.Text = info.Remark;
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
            XVTaskAttachmentInfo info = this.m_CurrentModel as XVTaskAttachmentInfo;

            if (this.m_EditStatus == XEditStatus.AddNew || this.m_EditStatus == XEditStatus.AddContinue)
            {
                info.RID = this.GetNewId();
                info.ID = info.RID;
            }

            info.MainId = this.txtMainId.Text;
            info.FileName = this.txtFileName.Text;
            info.FileDesc = this.txtFileDesc.Text;
            info.Remark = this.txtRemark.Text;

            info.FileFullName = this.txtFilePath.Text.Trim();

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

        protected override bool SaveAdd()
        {
            return true;
        }

        protected override bool SaveEdit()
        {
            return true;
        }

        protected override bool GetIsShowSaveMessage()
        {
            return false;
        }

        protected override void SavedAfterOperate()
        {

        }
    }
}