using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.Model;
using MMIS.BLL;
using MMIS.Helper;

namespace MMIS.UI
{
    public partial class frmTreeTaskList : frmBase
    {
        protected XTaskBusiness m_TaskBusiness = new XTaskBusiness();
        private XTaskFilesBusiness m_TaskFilesBusiness = new XTaskFilesBusiness();
        protected XFileAttachmentBusiness m_FileAttachBusiness = new XFileAttachmentBusiness();
        private XTaskAttachmentBusiness m_TaskAttachBusiness = new XTaskAttachmentBusiness();

        private bool m_IsFormLoad = true;

        public frmTreeTaskList()
        {
            InitializeComponent();
            this.InitCommandEvent();
            //IList<XModelBase> treeModels = this.m_TaskBusiness.GetRootViewModelList("");
            //this.InitTree(treeModels);

        }

        private void InitCommandEvent()
        {
            this.cmdNewTask.Click += cmdNewTask_Click;
            this.cmdEditTask.Click += cmdEditTask_Click;
            this.cmdDeleteTask.Click += cmdDeleteTask_Click;
            this.cmdNewChildTask.Click += cmdNewChildTask_Click;
            this.cmdFinishTask.Click += cmdFinishTask_Click;
            this.cmdRefreshTask.Click += cmdRefreshTask_Click;
            this.cmdDownload.Click += cmdDownload_Click;
            this.cmdPreview.Click += cmdPreview_Click;
            this.cmdPreviewAttach.Click += cmdPreviewAttach_Click;
            this.cmdDownloadAttach.Click += cmdDownloadAttach_Click;
        }

        /// <summary>
        /// 下载附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cmdDownloadAttach_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (this.grdTaskAttach.CurrentRow != null
                && this.grdTaskAttach.CurrentRow.RowType != Janus.Windows.GridEX.RowType.Record)
            {
                XMessageBox.ShowError("请选择要下载附件的记录！");
                return;
            }

            XTaskAttachmentInfo model = this.grdTaskAttach.CurrentRow.DataRow as XTaskAttachmentInfo;

            string mainId = model.RID;

            bool isExist = this.m_FileAttachBusiness.IsFileExist(mainId);
            if (!isExist)
            {
                XMessageBox.ShowError("未找到附件！");
                return;
            }

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = this.m_FileAttachBusiness.DownloadFile(mainId, fbd.SelectedPath);

                if (fileName != string.Empty)
                {
                    XMessageBox.ShowRemindMessage("下载完成！");
                }
                else
                {
                    XMessageBox.ShowError("下载失败！");
                }
            }

        }

        /// <summary>
        /// 预览附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cmdPreviewAttach_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (this.grdTaskAttach.CurrentRow != null
              && this.grdTaskAttach.CurrentRow.RowType != Janus.Windows.GridEX.RowType.Record)
            {
                XMessageBox.ShowError("请选择要预览附件的记录！");
                return;
            }

            XTaskAttachmentInfo model = this.grdTaskAttach.CurrentRow.DataRow as XTaskAttachmentInfo;
            string mainId = model.RID;
            XFilePreviewTool.Preview(mainId);

        }

        void cmdPreview_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (this.tvTask.SelectedNode != null)
            {
                XTaskFilesInfo model = this.tvTask.SelectedNode.Tag as XTaskFilesInfo;

                string mainId = model.RID;

                XFilePreviewTool.Preview(mainId);
            }
        }

        void cmdDownload_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (this.tvTask.SelectedNode != null)
            {
                XTaskFilesInfo model = this.tvTask.SelectedNode.Tag as XTaskFilesInfo;

                string mainId = model.RID;

                bool isExist = this.m_FileAttachBusiness.IsFileExist(mainId);
                if (!isExist)
                {
                    XMessageBox.ShowError("未找到附件！");
                    return;
                }

                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileName = this.m_FileAttachBusiness.DownloadFile(mainId, fbd.SelectedPath);

                    if (fileName != string.Empty)
                    {
                        XMessageBox.ShowRemindMessage("下载完成！");
                    }
                    else
                    {
                        XMessageBox.ShowError("下载失败！");
                    }
                }
            }
            else
            {
                XMessageBox.ShowError("请选择要下载附件的记录！");
            }
        }

        void cmdRefreshTask_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.tvTask.Nodes.Clear();
            string where = XQueryTool.GetQueryCondition(this.pnlEndTop);
            IList<XModelBase> treeModels = this.m_TaskBusiness.GetRootViewModelList(where);
            this.InitTree(treeModels);
        }

        void cmdFinishTask_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            TreeNode selectedNode = this.tvTask.SelectedNode;

            if (selectedNode == null)
            {
                XMessageBox.ShowError("请选择要结束的任务！");
                return;
            }

            XTaskInfo taskInfo = selectedNode.Tag as XTaskInfo;
            if (taskInfo == null)
            {
                XMessageBox.ShowError("请选择要结束的任务！");
                return;
            }

            if (XMessageBox.ShowQuestion("确定要结束选中的任务吗？") == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            if (this.m_TaskBusiness.UpdateTaskStatus("结束", taskInfo.ID))
            {
                XMessageBox.ShowRemindMessage("结束任务成功！");
            }
            else
            {
                XMessageBox.ShowError("结束任务失败！");
            }
        }

        void cmdNewChildTask_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            TreeNode selectedNode = this.tvTask.SelectedNode;
            if (selectedNode == null)
            {
                XMessageBox.ShowError("请选择要创建子任务的任务!");
            }
            if (!(selectedNode.Tag is XTaskInfo))
            {
                //如果选中的节点不是任务节点
                XMessageBox.ShowError("该节点下不能添加子任务！");
                return;
            }
            if (selectedNode.Parent != null)
            {
                XMessageBox.ShowError("该节点下不能添加子任务！");
                return;
            }
            frmTaskEdit frm = new frmTaskEdit(selectedNode);
            frm.ShowDialog();
        }

        void cmdDeleteTask_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            TreeNode selectedNode = this.tvTask.SelectedNode;
            if (selectedNode != null)
            {
                XModelBase model = selectedNode.Tag as XModelBase;

                if (!this.m_TaskBusiness.IsEndModel(model))
                {
                    XMessageBox.ShowError("该任务下有子任务，不能删除！");
                    return;
                }

                if (this.m_TaskBusiness.IsHaveFile(model.ID))
                {
                    XMessageBox.ShowError("该任务下已有任务提交，不能删除！");
                    return;
                }

                if (XMessageBox.ShowQuestion("确定要删除选中的任务吗？") ==
                    System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                if (this.m_TaskBusiness.Delete(model, XCommon.LoginUsersInfo.RID))
                {
                    XMessageBox.ShowRemindMessage("删除成功！");
                    if (selectedNode.Parent == null)
                    {
                        this.tvTask.Nodes.Remove(selectedNode);
                    }
                    else
                    {
                        selectedNode.Parent.Nodes.Remove(selectedNode);
                    }
                }
                else
                {
                    XMessageBox.ShowError("删除失败！");
                }
            }
            else
            {
                XMessageBox.ShowError("请选择要删除的任务！");
            }
        }

        void cmdEditTask_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            TreeNode selectedNode = this.tvTask.SelectedNode;
            if (selectedNode != null)
            {
                XModelBase model = selectedNode.Tag as XModelBase;

                string status = this.m_TaskBusiness.GetTaskStatus(model.ID);
                if (status == "结束")
                {
                    XMessageBox.ShowError("该任务已结束，不能修改！");
                    return;
                }

                frmTaskEdit frm = new frmTaskEdit(selectedNode, model);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowError("请选择要修改的任务！");
            }
        }

        void cmdNewTask_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            frmTaskEdit frm = new frmTaskEdit(this.tvTask);
            frm.ShowDialog();
        }

        protected virtual void InitTree(IList<XModelBase> treeModels)
        {
            this.tvTask.Nodes.Clear();

            foreach (XModelBase treeModel in treeModels)
            {
                TreeNode rootNode = this.GetTreeNodeByModel(treeModel);
                if (!this.IsEndModel(treeModel))
                {
                    rootNode.Nodes.Add(" ");
                }
                this.tvTask.Nodes.Add(rootNode);
            }
        }

        private TreeNode GetTreeNodeByModel(XModelBase model)
        {
            TreeNode treeNode = new TreeNode();

            XVTaskInfo taskInfo = model as XVTaskInfo;

            string text = taskInfo.TaskName;
            treeNode.Text = text;
            treeNode.ToolTipText = text;
            treeNode.Tag = model;

            return treeNode;
        }

        protected virtual bool IsEndModel(XModelBase model)
        {
            if (model is XTaskInfo)
            {
                XTaskInfo taskInfo = model as XTaskInfo;

                string parentId = taskInfo.ParentId;
                if (parentId == string.Empty)
                {
                    string where = this.GetIsEndModelWhere();
                    //如果是根任务
                    return this.m_TaskBusiness.IsEndModel(model, where);
                }
                else
                {
                    return this.m_TaskFilesBusiness.GetCountByMainId(taskInfo.ID) == 0;
                }
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 获取是否末级节点的查询条件
        /// </summary>
        /// <returns></returns>
        protected virtual string GetIsEndModelWhere()
        {
            return XQueryTool.GetQueryCondition(this.pnlEndTop);
        }

        private void tvTask_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                TreeNode selectedNode = this.tvTask.SelectedNode;
                if (selectedNode == null)
                {
                    if (this.IsAllowOperateTask)
                    {
                        this.cmTaskMenu.Show(this.tvTask);
                    }
                }
                else
                {
                    XModelBase selectedModel = selectedNode.Tag as XModelBase;
                    if (selectedModel is XTaskInfo)
                    {
                        if (this.IsAllowOperateTask)
                        {
                            this.cmTaskMenu.Show(this.tvTask);
                        }
                    }
                    else if (selectedModel is XTaskFilesInfo)
                    {
                        this.cmFile.Show(this.tvTask);
                    }
                }
            }

        }

        private TreeNode m_LastSelctedNode = null;

        private void tvTask_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            XVTaskInfo info = selectedNode.Tag as XVTaskInfo;

            if (m_LastSelctedNode != null)
            {
                m_LastSelctedNode.BackColor = Color.White;
            }
            selectedNode.BackColor = Color.LightBlue;
            m_LastSelctedNode = selectedNode;

            if (info != null)
            {
                //如果选中的是任务节点
                this.tabTask.SelectedIndex = 0;

                this.txtTaskTypeId.Text = info.TaskType;
                this.txtTaskName.Text = info.TaskName;
                this.txtTaskNo.Text = info.TaskNo;
                this.txtStartPeople.Text = info.StartPeople;
                this.dtDispatchDate.Value = XHelper.GetDateTime(info.DispatchDate);
                this.txtAssignPeople.Text = info.AssignPeopleName;
                this.dtStartDate.Value = XHelper.GetDateTime(info.StartDate);
                this.dtPreEndDate.Value = XHelper.GetDateTime(info.PreEndDate);
                this.txtShortDesc.Text = info.ShortDesc;
                this.txtRequire.Text = info.Require;
                this.txtContent.Text = info.Content;
                this.txtRemark.Text = info.Remark;

                if (selectedNode.Parent != null)
                {
                    XTaskInfo parentTaskInfo = selectedNode.Parent.Tag as XTaskInfo;
                    this.txtParentTask.Text = parentTaskInfo.TaskName;
                    this.txtParentTaskNo.Text = parentTaskInfo.TaskNo;
                    this.dtParentStartDate.Value = XHelper.GetDateTime(parentTaskInfo.StartDate);
                    this.dtParentPreEndDate.Value = XHelper.GetDateTime(parentTaskInfo.PreEndDate);
                }
                else
                {
                    this.txtParentTask.Text = string.Empty;
                    this.txtParentTaskNo.Text = string.Empty;
                    //this.dtParentStartDate.Value = 
                    //this.dtParentPreEndDate.Value = XHelper.GetDateTime(parentTaskInfo.PreEndDate);
                }

                if (this.IsChildTaskNode(selectedNode))
                {
                    //如果选择的是子任务
                    this.FillFilesGrid(info.RID);
                }
                else
                {
                    //如果是根级节点
                    this.grdFiles.DataSource = this.m_TaskFilesBusiness.GetViewListByRootTaskId(info.RID);
                    this.grdFiles.AutoSizeColumns();
                }

                this.FillTaskAttachGrid(info.RID);
            }
            else
            {
                this.tabTask.SelectedIndex = 1;

                //文件节点
                XVTaskFilesInfo taskFileInfo = selectedNode.Tag as XVTaskFilesInfo;

                this.txtFileName.Text = taskFileInfo.FileName;
                this.txtFileDesc.Text = taskFileInfo.FileDesc;
                this.txtFileRemark.Text = taskFileInfo.Remark;
            }

        }

        /// <summary>
        /// 填充任务附件
        /// </summary>
        /// <param name="mainId"></param>
        private void FillTaskAttachGrid(string mainId)
        {
            this.grdTaskAttach.DataSource = this.m_TaskAttachBusiness.GetByMainId(mainId, "");
            this.grdTaskAttach.AutoSizeColumns();
        }

        private void FillFilesGrid(string mainId)
        {
            this.grdFiles.DataSource = this.m_TaskFilesBusiness.GetViewByMainId(mainId, "");
            this.grdFiles.AutoSizeColumns();
        }

        private void tvTask_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode currentNode = e.Node;

            XModelBase currentModel = currentNode.Tag as XModelBase;
            if (currentModel != null)
            {
                TreeNodeCollection childNodes = currentNode.Nodes;
                if (childNodes.Count > 0)
                {
                    if (childNodes[0].Tag == null)
                    {
                        currentNode.Nodes.Clear();

                        if (!this.IsChildTaskNode(currentNode))
                        {
                            //如果不是子任务
                            //如果Tag为空，则说明是首次加载

                            string where = this.GetFirstLoadChildWhere();
                            IList<XModelBase> childModels = this.m_TaskBusiness.GetChildViewModelLists(currentModel, where);

                            foreach (XModelBase childModel in childModels)
                            {
                                TreeNode childTreeNode = this.GetTreeNodeByModel(childModel);
                                if (!this.IsEndModel(childModel))
                                {
                                    childTreeNode.Nodes.Add(" ");
                                }
                                currentNode.Nodes.Add(childTreeNode);
                            }
                        }
                        else
                        {
                            string childWhere = this.GetChildWhere();

                            IList<XModelBase> taskFiles = this.m_TaskFilesBusiness.GetViewByMainId(currentModel.ID, childWhere);

                            foreach (XVTaskFilesInfo fileInfo in taskFiles)
                            {
                                TreeNode taskFileNode = new TreeNode();
                                taskFileNode.Text = fileInfo.FileName;
                                taskFileNode.Tag = fileInfo;
                                currentNode.Nodes.Add(taskFileNode);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 获取第一次加载子节点的时候的Where条件
        /// </summary>
        /// <returns></returns>
        protected virtual string GetFirstLoadChildWhere()
        {
            return XQueryTool.GetQueryCondition(this.pnlEndTop);
        }

        /// <summary>
        /// 获取子节点的条件
        /// </summary>
        /// <returns></returns>
        protected virtual string GetChildWhere()
        {
            return string.Empty;
            //return XQueryTool.GetQueryCondition(this.pnlEndTop);
        }

        protected virtual void grdFiles_MouseDown(object sender, MouseEventArgs e)
        {

        }

        /// <summary>
        /// 是否子任务节点
        /// </summary>
        /// <param name="treeNode"></param>
        /// <returns></returns>
        protected virtual bool IsChildTaskNode(TreeNode treeNode)
        {
            if (!(treeNode.Tag is XVTaskInfo))
            {
                return false;
            }

            TreeNode parentNode = treeNode.Parent as TreeNode;

            if (parentNode == null || !(parentNode.Tag is XVTaskInfo))
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 是否允许操作任务
        /// </summary>
        protected virtual bool IsAllowOperateTask
        {
            get { return true; }
        }

        protected virtual string GetWhereCondition()
        {
            return XQueryTool.GetQueryCondition(this.pnlEndTop);
        }

        protected virtual IList<XModelBase> GetRootViewModelList(string where)
        {
            return this.m_TaskBusiness.GetRootViewModelList(where);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string where = this.GetWhereCondition();

            //IList<XModelBase> treeModels = this.m_TaskBusiness.GetRootViewModelList(where);

            IList<XModelBase> treeModels = this.GetRootViewModelList(where);

            this.InitTree(treeModels);

            if (this.tvTask.Nodes.Count > 0)
            {
                bool isExpand = false;

                if (!m_IsFormLoad)
                {
                    //非窗体加载的时候点击查询展开节点
                    isExpand = true;
                }
                else
                {
                    //窗体加载的时候
                    if (IsFormLoadExpandNodes)
                    {
                        isExpand = true;
                    }
                }

                if (isExpand)
                {
                    TreeNode firstNode = this.tvTask.Nodes[0];

                    firstNode.Expand();
                }
            }

            m_IsFormLoad = false;
        }

        /// <summary>
        /// 是否在窗体加载的时候展开节点
        /// </summary>
        protected virtual bool IsFormLoadExpandNodes
        {
            get { return false; }
        }

        private void frmTreeTaskList_Load(object sender, EventArgs e)
        {
            this.btnQuery_Click(null, null);
            this.InitAutoRefresh();
        }

        private void InitAutoRefresh()
        {
            if (IsAutoRefresh)
            {
                int refreshMinutes = XUICommon.SystemConfigInfo.RefreshMinutes;

                this.tmRefresh.Interval = refreshMinutes * 60 * 1000;
                this.tmRefresh.Enabled = true;
                this.tmRefresh.Start();
            }
        }

        /// <summary>
        /// 是否自动刷新
        /// </summary>
        protected virtual bool IsAutoRefresh
        {
            get { return false; }
        }

        private void grdTaskAttach_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.cmTaskAttach.Show(this.grdTaskAttach);
            }
        }

        private void tmRefresh_Tick(object sender, EventArgs e)
        {
            btnQuery_Click(null, null);
        }
    }
}
