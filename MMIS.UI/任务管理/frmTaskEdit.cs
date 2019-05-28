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
    public partial class frmTaskEdit : frmEditBase
    {

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XTaskBusiness m_TaskBusiness = new XTaskBusiness();

        #region 构造函数

        private TreeView m_TreeView;
        private TreeNode m_TreeNode;

        //添加任务
        public frmTaskEdit(TreeView treeView)
        {
            InitializeComponent();
            this.m_TreeView = treeView;
            this.m_EditStatus = XEditStatus.AddNew;
            //this.txtParentTask.Enabled = false;
            this.grpParent.Enabled = false;
        }

        //添加子任务
        public frmTaskEdit(TreeNode treeNode)
        {
            InitializeComponent();
            this.m_TreeNode = treeNode;
            this.m_EditStatus = XEditStatus.AddNew;
            this.InitParentTask();
        }

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmTaskEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmTaskEdit(TreeNode treeNode, XModelBase currentModel)
        {
            InitializeComponent();
            this.m_CurrentModel = currentModel;
            this.m_TreeNode = treeNode;
            this.m_EditStatus = XEditStatus.Edit;
            this.SetDefaultValue();
        }


        #endregion

        private void InitParentTask()
        {
            if (this.m_TreeNode != null)
            {
                XTaskInfo parentTask = this.m_TreeNode.Tag as XTaskInfo;
                this.txtParentTask.Text = parentTask.TaskName;
                this.txtParentTask.Tag = parentTask.RID;

                this.txtParentNo.Text = parentTask.TaskNo;
                this.dtParentStartDate.Value = XHelper.GetDateTime(parentTask.StartDate);
                this.dtParentPreEndDate.Value = XHelper.GetDateTime(parentTask.PreEndDate);
            }
        }

        /// <summary>
        /// 获取业务操作对象
        /// </summary>
        /// <returns></returns>
        protected override XBusinessBase InitBusiness()
        {
            return new XTaskBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVTaskInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVTaskInfo info = this.m_CurrentModel as XVTaskInfo;

            if (info == null)
            {
                return;
            }

            if (info.TaskTypeId != string.Empty)
            {
                this.txtTaskTypeId.Text = info.TaskType;
                this.txtTaskTypeId.ValueMember = info.TaskTypeId;
                this.txtTaskTypeId.DisplayMember = info.TaskName;
            }

            this.txtTaskName.Text = info.TaskName;
            this.txtTaskNo.Text = info.TaskNo;
            this.txtStartPeople.Text = info.StartPeople;
            this.dtDispatchDate.Value = XHelper.GetDateTime(info.DispatchDate);
            if (info.AssignPeople != string.Empty)
            {
                this.txtAssignPeople.Text = info.AssignPeopleName;
                this.txtAssignPeople.ValueMember = info.AssignPeople;
                this.txtAssignPeople.DisplayMember = info.AssignPeopleName;
            }
            this.dtStartDate.Value = XHelper.GetDateTime(info.StartDate);
            this.dtPreEndDate.Value = XHelper.GetDateTime(info.PreEndDate);
            this.txtShortDesc.Text = info.ShortDesc;
            this.txtRequire.Text = info.Require;
            this.txtContent.Text = info.Content;
            this.txtRemark.Text = info.Remark;

            this.txtTaskStatus.Text = info.TaskStatus;

            if (this.m_TreeNode.Parent != null)
            {
                XTaskInfo parentTaskInfo = this.m_TreeNode.Parent.Tag as XTaskInfo;
                this.txtParentTask.Text = parentTaskInfo.TaskName;
                this.txtParentTask.Tag = parentTaskInfo;
            }

        }


        /// <summary>
        /// 自定义UI校验
        /// </summary>
        /// <returns></returns>
        protected override bool ValidateCustom()
        {
            XTaskBusiness taskBusiness = this.m_Business as XTaskBusiness;

            if (this.m_EditStatus == XEditStatus.Edit)
            {
                string status = taskBusiness.GetTaskStatus(this.m_CurrentModel.ID);
                if (status == "结束")
                {
                    XMessageBox.ShowError("该任务已结束，不能修改！");
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
            XVTaskInfo info = this.m_CurrentModel as XVTaskInfo;

            if (this.m_EditStatus == XEditStatus.AddNew || this.m_EditStatus == XEditStatus.AddContinue)
            {
                info.RID = this.GetNewId();
                info.ID = info.RID;
                if (this.m_TreeNode != null)
                {
                    XTaskInfo parentTaskInfo = this.m_TreeNode.Tag as XTaskInfo;
                    info.ParentId = parentTaskInfo.RID;
                }
            }

            info.TaskTypeId = this.txtTaskTypeId.ValueMember;
            info.TaskType = this.txtTaskTypeId.DisplayMember;
            info.TaskName = this.txtTaskName.Text;
            info.TaskNo = this.txtTaskNo.Text;
            info.StartPeople = this.txtStartPeople.Text;
            info.DispatchDate = XHelper.GetFormatedDate(this.dtDispatchDate.Value);
            info.AssignPeople = this.txtAssignPeople.ValueMember;
            info.AssignPeopleName = this.txtAssignPeople.DisplayMember;
            info.StartDate = XHelper.GetFormatedDate(this.dtStartDate.Value);
            info.PreEndDate = XHelper.GetFormatedDate(this.dtPreEndDate.Value);
            info.ShortDesc = this.txtShortDesc.Text;
            info.Require = this.txtRequire.Text;
            info.Content = this.txtContent.Text;
            info.Remark = this.txtRemark.Text;

            info.TaskStatus = this.txtTaskStatus.Text.Trim();

            this.FillSaveDetailList();

            if (this.m_EditStatus == XEditStatus.Edit)
            {
                this.FillDeleteList();//填充删除的明细字典
            }

            base.FillModelInfo();
        }

        protected override void SavedAfterOperate()
        {
            XTaskInfo taskInfo = this.m_CurrentModel as XTaskInfo;
            TreeNode treeNode = null;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                treeNode = new TreeNode();
                treeNode.Text = taskInfo.TaskName;
                if (this.m_TreeView != null)
                {
                    this.m_TreeView.Nodes.Add(treeNode);
                }
                else
                {
                    this.m_TreeNode.Nodes.Add(treeNode);
                }
            }
            else
            {
                treeNode = this.m_TreeNode;
                this.m_TreeNode.Text = taskInfo.TaskName;
            }

            treeNode.Tag = taskInfo;
        }


        /// <summary>
        /// 修改前的明细字典
        /// </summary>
        protected IList<XModelBase> m_OldAttachList = null;

        /// <summary>
        /// 要保存的明细字典
        /// </summary>
        protected IList<XModelBase> m_DetailList = null;

        /// <summary>
        /// 要删除的明细字典
        /// </summary>
        protected IList<XModelBase> m_DeleteList = null;

        /// <summary>
        /// 明细字典
        /// </summary>
        public IList<XModelBase> DetailList
        {
            get { return this.m_DetailList; }
        }

        private XTaskAttachmentBusiness m_TaskAttachBusiness = new XTaskAttachmentBusiness();

        /// <summary>
        /// 填充修改前的字典
        /// </summary>
        protected virtual void FillOldAttachList()
        {
            this.m_OldAttachList = new List<XModelBase>();

            IList<XModelBase> detailList = this.grdFiles.DataSource as IList<XModelBase>;

            foreach (XModelBase model in detailList)
            {
                XModelBase oldModel = model.Clone() as XModelBase;

                this.m_OldAttachList.Add(oldModel);
            }
        }

        /// <summary>
        /// 填充删除的List
        /// </summary>
        protected virtual void FillDeleteList()
        {
            this.m_DeleteList = new List<XModelBase>();

            foreach (XModelBase model in this.m_OldAttachList)
            {
                if (!IsInGridList(model.ID))
                {
                    m_DeleteList.Add(model);
                }
            }
        }

        private bool IsInGridList(string id)
        {
            IList<XModelBase> gridList = this.grdFiles.DataSource as IList<XModelBase>;

            foreach (XModelBase model in gridList)
            {
                if (model.ID == id)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnAddNewFile_Click(object sender, EventArgs e)
        {
            IList<XModelBase> gridList = this.grdFiles.DataSource as IList<XModelBase>;

            frmTaskAttachmentEdit frm = new frmTaskAttachmentEdit(gridList);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.grdFiles.DataSource = null;
                this.grdFiles.DataSource = frm.ModelList;
                this.grdFiles.Refresh();
            }
        }

        private void btnEditFile_Click(object sender, EventArgs e)
        {
            if (this.grdFiles.CurrentRow == null ||
                this.grdFiles.CurrentRow.RowType != Janus.Windows.GridEX.RowType.Record)
            {
                XMessageBox.ShowError("请选择要编辑的记录！");
                return;
            }

            XModelBase currentModel = this.grdFiles.CurrentRow.DataRow as XModelBase;

            frmTaskAttachmentEdit frm = new frmTaskAttachmentEdit(currentModel);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.grdFiles.Refresh();
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            IList<XModelBase> modelLists = this.grdFiles.DataSource as IList<XModelBase>;

            IList<XModelBase> selectedModels = new List<XModelBase>();
            foreach (Janus.Windows.GridEX.GridEXRow gridRow in this.grdFiles.GetCheckedRows())
            {
                selectedModels.Add(gridRow.DataRow as XModelBase);
            }

            foreach (XModelBase model in selectedModels)
            {
                Janus.Windows.GridEX.GridEXRow row = grdFiles.GetRow(model);
                row.Delete();
                modelLists.Remove(model);
            }
        }

        protected virtual void FillSaveDetailList()
        {
            this.m_DetailList = this.grdFiles.DataSource as IList<XModelBase>;
        }

        protected override void FormLoadFunction(object sender, System.EventArgs e)
        {
            base.FormLoadFunction(sender, e);

            string mainId = string.Empty;
            if (this.m_CurrentModel != null)
            {
                mainId = this.m_CurrentModel.ID;
            }
            this.FillDetailGrid(mainId);
            this.FillOldAttachList();
        }

        private void FillDetailGrid(string mainId)
        {
            this.grdFiles.DataSource = this.m_TaskAttachBusiness.GetViewByMainId(mainId, "");
            this.grdFiles.AutoSizeColumns();
        }

        protected override bool SaveAdd()
        {
            IDictionary<string, IList<XModelBase>> detailDict = new Dictionary<string, IList<XModelBase>>();
            detailDict.Add("grdFiles", this.m_DetailList);

            return this.m_Business.Insert(this.m_CurrentModel, detailDict);
        }

        protected override bool SaveEdit()
        {
            IDictionary<string, IList<XModelBase>> detailDict = new Dictionary<string, IList<XModelBase>>();
            detailDict.Add("grdFiles", this.m_DetailList);

            IDictionary<string, IList<XModelBase>> deleteDict = new Dictionary<string, IList<XModelBase>>();
            deleteDict.Add("grdFiles", this.m_DeleteList);

            return this.m_Business.Update(this.m_CurrentModel, detailDict, deleteDict);
        }

    }
}