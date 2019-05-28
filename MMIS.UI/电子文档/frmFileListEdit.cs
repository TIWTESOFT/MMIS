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
    public partial class frmFileListEdit : frmEditBase
    {

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XFileListBusiness m_FileListBusiness = new XFileListBusiness();

        private XFileAttachmentBusiness m_FileAttachBusiness = new XFileAttachmentBusiness();

        

        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmFileListEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmFileListEdit(IList<XModelBase> modelList, XModelBase selectedTreeModel)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
            this.m_SelectedTreeModel = selectedTreeModel;

            if (selectedTreeModel != null)
            {
                XCodeFolderTypeInfo folderTypeInfo = selectedTreeModel as XCodeFolderTypeInfo;
                if (folderTypeInfo != null)
                {
                    this.txtFolderTypeId.Text = folderTypeInfo.NameCN;
                    this.txtFolderTypeId.ValueMember = folderTypeInfo.RID;
                    this.txtFolderTypeId.DisplayMember = folderTypeInfo.NameCN;
                }
            }
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmFileListEdit(XModelBase currentModel)
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
            return new XFileListBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVFileListInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVFileListInfo info = this.m_CurrentModel as XVFileListInfo;

            this.txtFileNo.Text = info.FileNo;
            this.txtFileName.Text = info.FileName;
            this.txtFileDesc.Text = info.FileDesc;
            if (info.FolderTypeId != string.Empty)
            {
                this.txtFolderTypeId.Text = info.FolderType;
                this.txtFolderTypeId.DisplayMember = info.FolderType;
                this.txtFolderTypeId.ValueMember = info.FolderTypeId;
            }
            if (info.FileTypeId != string.Empty)
            {
                this.txtFileTypeId.Text = info.FileType;
                this.txtFileTypeId.DisplayMember = info.FileType;
                this.txtFileTypeId.ValueMember = info.FileTypeId;
            }
            if (info.FileLevelId != string.Empty)
            {
                this.txtFileLevelId.Text = info.FileLevel;
                this.txtFileLevelId.DisplayMember = info.FileLevel;
                this.txtFileLevelId.ValueMember = info.FileLevelId;
            }
            if (info.FileStateId != string.Empty)
            {
                this.txtFileStateId.Text = info.FileState;
                this.txtFileStateId.DisplayMember = info.FileState;
                this.txtFileStateId.ValueMember = info.FileStateId;
            }
            this.nebPageNum.Value = info.PageNum;
            this.txtUserId.Text = info.UserId;
            this.txtDeptId.Text = info.DeptId;
            this.txtRemark.Text = info.Remark;
        }


        /// <summary>
        /// 自定义UI校验
        /// </summary>
        /// <returns></returns>
        protected override bool ValidateCustom()
        {
            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                if (this.txtFilePath.Text.Trim() == string.Empty)
                {
                    XMessageBox.ShowError("文档路径不能为空！");
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
            XVFileListInfo info = this.m_CurrentModel as XVFileListInfo;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                info.RID = this.GetNewId();
                info.ID = info.RID;
            }

            info.FileNo = this.txtFileNo.Text;
            info.FileName = this.txtFileName.Text;
            info.FileDesc = this.txtFileDesc.Text;
            info.FolderTypeId = this.txtFolderTypeId.ValueMember;
            info.FolderType = this.txtFolderTypeId.DisplayMember;
            info.FileTypeId = this.txtFileTypeId.ValueMember;
            info.FileType = this.txtFileTypeId.DisplayMember;
            info.FileLevelId = this.txtFileLevelId.ValueMember;
            info.FileLevel = this.txtFileLevelId.DisplayMember;
            info.FileStateId = this.txtFileStateId.ValueMember;
            info.FileState = this.txtFileStateId.DisplayMember;
            info.PageNum = XHelper.GetInt(this.nebPageNum.Value);
            info.UserId = this.txtUserId.Text;
            info.DeptId = this.txtDeptId.Text;
            info.Remark = this.txtRemark.Text;

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
                    XFileListInfo fileInfo = this.m_CurrentModel as XFileListInfo;

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