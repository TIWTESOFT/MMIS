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
    public partial class frmTaskFilesEdit : frmEditBase
    {

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XTaskFilesBusiness m_TaskFilesBusiness = new XTaskFilesBusiness();

        private TreeNode m_ChildTaskTreeNode = null;

        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmTaskFilesEdit(IList<XModelBase> modelList, TreeNode childTaskTreeNode)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
            this.m_ChildTaskTreeNode = childTaskTreeNode;
            this.FillTaskInfoByNode();
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmTaskFilesEdit(XModelBase currentModel)
        {
            InitializeComponent();
            this.m_CurrentModel = currentModel;
            this.m_EditStatus = XEditStatus.Edit;
            this.SetDefaultValue();
        }


        #endregion

        private void FillTaskInfoByNode()
        {
            XVTaskInfo childTaskInfo = this.m_ChildTaskTreeNode.Tag as XVTaskInfo;
            if (childTaskInfo != null)
            {
                this.txtChildTaskName.Text = childTaskInfo.TaskName;
                this.txtChildTaskName.Tag = childTaskInfo.RID;
                this.txtChildTaskNo.Text = childTaskInfo.TaskNo;
                this.dtChildTaskStartDate.Value = XHelper.GetDateTime(childTaskInfo.StartDate);
                this.dtChildTaskPreEnd.Value = XHelper.GetDateTime(childTaskInfo.PreEndDate);
            }

            TreeNode parentTaskNode = this.m_ChildTaskTreeNode.Parent;
            if (parentTaskNode != null)
            {
                XVTaskInfo parentTaskInfo = parentTaskNode.Tag as XVTaskInfo;

                this.txtMainId.Text = parentTaskInfo.TaskName;
                this.txtTaskNo.Text = parentTaskInfo.TaskNo;
                this.dtStartDate.Value = XHelper.GetDateTime(parentTaskInfo.StartDate);
                this.dtPreEndDate.Value = XHelper.GetDateTime(parentTaskInfo.PreEndDate);
            }
        }


        /// <summary>
        /// 获取业务操作对象
        /// </summary>
        /// <returns></returns>
        protected override XBusinessBase InitBusiness()
        {
            return new XTaskFilesBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVTaskFilesInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVTaskFilesInfo info = this.m_CurrentModel as XVTaskFilesInfo;

            //this.txtMainId.Text = info.MainId;
            this.txtFileName.Text = info.FileName;
            this.txtFileDesc.Text = info.FileDesc;
            this.txtRemark.Text = info.Remark;

            this.txtChildTaskName.Text = info.TaskName;
            this.txtChildTaskName.Tag = info.RID;
            this.txtChildTaskNo.Text = info.TaskNo;
            this.dtChildTaskStartDate.Value = XHelper.GetDateTime(info.StartDate);
            this.dtChildTaskPreEnd.Value = XHelper.GetDateTime(info.PreEndDate);
            this.txtMainId.Text = info.ParentTaskName;
            this.txtTaskNo.Text = info.ParentTaskNo;
            this.dtStartDate.Value = XHelper.GetDateTime(info.ParentStartDate);
            this.dtPreEndDate.Value = XHelper.GetDateTime(info.ParentPreEndDate);
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
            XVTaskFilesInfo info = this.m_CurrentModel as XVTaskFilesInfo;

            if (this.m_EditStatus == XEditStatus.AddNew || this.m_EditStatus == XEditStatus.AddContinue)
            {
                info.RID = this.GetNewId();
                info.ID = info.RID;
                info.MainId = XHelper.GetString(txtChildTaskName.Tag);
            }

            info.FileName = this.txtFileName.Text;
            info.FileDesc = this.txtFileDesc.Text;
            info.Remark = this.txtRemark.Text;
            info.FileFullName = this.txtFilePath.Text.Trim();
            info.UpdateUserName = XCommon.LoginUsersInfo.RealName;
            info.InputUserName = XCommon.LoginUsersInfo.RealName;

            info.TaskName = this.txtChildTaskName.Text;
            info.TaskNo = this.txtChildTaskNo.Text;
            info.StartDate = XHelper.GetFormatedDate(this.dtChildTaskStartDate.Value);
            info.PreEndDate = XHelper.GetFormatedDate(this.dtChildTaskPreEnd.Value);
            info.ParentTaskName = this.txtMainId.Text;
            info.ParentTaskNo = this.txtTaskNo.Text;
            info.ParentStartDate = XHelper.GetFormatedDate(this.dtStartDate.Value);
            info.ParentPreEndDate = XHelper.GetFormatedDate(this.dtPreEndDate.Value);

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
            this.txtFilePath_ButtonClick(null, null);
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
            XTaskFilesBusiness business = this.m_Business as XTaskFilesBusiness;
            return business.InsertCustom(this.m_CurrentModel);
        }

        protected override bool SaveEdit()
        {
            XTaskFilesBusiness business = this.m_Business as XTaskFilesBusiness;
            return business.UpdateCustom(this.m_CurrentModel);
        }
    }
}