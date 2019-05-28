using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.Model;
using MMIS.BLL;
using MMIS.Helper;

namespace MMIS.UI.Common
{
    public partial class frmTreeListBase : frmBase
    {
        protected XFileAttachmentBusiness m_FileAttachBusiness = null;

        protected XBusinessBase m_TreeBusiness;
        protected XBusinessBase m_ListBusiness;
        protected XModelBase m_TreeModel = null;
        /// <summary>
        /// 编辑状态
        /// </summary>
        protected XEditStatus m_EditStauts;
        protected string m_SelectedDeleteIds = "";

        protected IList<XModelBase> m_SelectedModels;

        private XModelBase m_SelectedModel = null;

        /// <summary>
        /// 当前操作的实体集
        /// </summary>
        protected IList<XModelBase> m_CurrentList;

        /// <summary>
        /// 追加的删除消息
        /// </summary>
        protected string m_AppendDeleteMessage = "";

        /// <summary>
        /// 是否显示删除成功提示
        /// </summary>
        protected bool m_IsShowDeleteSuccessMessage = false;


        /// <summary>
        /// 当前操作的记录
        /// </summary>
        protected XModelBase m_CurrentModel;

        /// <summary>
        /// where查询条件
        /// </summary>
        protected string m_WhereCondition = "";

        /// <summary>
        /// 是否允许操作数据：
        /// </summary>
        protected virtual bool IsAllowOperateData
        {
            get { return true; }
        }

        public frmTreeListBase()
        {
            InitializeComponent();
            this.m_TreeBusiness = this.InitTreeBusiness();
            this.m_ListBusiness = this.InitListBusiness();
            this.InitFileAttachBusiness();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            base.FormLoadFunction(sender, e);
            this.InitTreeNode();
            this.InitRightMenuCommandEvent();
            this.InitCommandVisible();
        }

        protected virtual void InitCommandVisible()
        {
            if (this.IsAllowDownload)
            {
                this.cmdDownload.Visible = Janus.Windows.UI.InheritableBoolean.True;
            }
        }

        protected virtual XBusinessBase InitTreeBusiness()
        {
            return new XBusinessBase();
        }

        protected virtual XBusinessBase InitListBusiness()
        {
            return new XBusinessBase();
        }

        private void InitRightMenuCommandEvent()
        {
            this.cdAddNew.Click += cdAddNew_Click;
            this.cmEdit.Click += cmEdit_Click;
            this.cmDelete.Click += cmDelete_Click;
            this.cmdRefresh.Click += cmdRefresh_Click;
        }

        #region 查询操作

        void cmdRefresh_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.RefreshListData();
        }

        protected virtual void RefreshListData()
        {
            this.QueryList();
        }

        protected virtual void QueryList()
        {
            if (!this.ValidateListQuery())
            {
                return;
            }
            this.m_WhereCondition = string.Empty;
            this.GetAuthonWhereCondition();
            this.m_WhereCondition += this.GetQueryListConditon();
            this.m_WhereCondition += this.GetListOtherCondition();
            this.QueryListOperation();
        }

        protected virtual bool ValidateListQuery()
        {
            return true;
        }

        /// <summary>
        /// 获取grid控件的查询条件
        /// </summary>
        protected virtual void GetAuthonWhereCondition()
        {

        }

        /// <summary>
        /// 获取查询条件
        /// </summary>
        /// <returns></returns>
        protected virtual string GetQueryListConditon()
        {
            return XQueryTool.GetQueryCondition(this.grpQuery);
        }

        /// <summary>
        /// 获取其他的查询条件
        /// </summary>
        /// <returns></returns>
        protected virtual string GetListOtherCondition()
        {
            string otherCondition = string.Empty;

            if (!this.chkAllNodes.Checked)
            {
                //没有选择查询全部节点，则只查选当前选中节点下的数据
                XModelBase selectedTreeMode = this.GetSelectedTreeModel();

                if (selectedTreeMode != null)
                {
                    //如果选中节点不为空，则在选中节点下过滤
                    otherCondition += " AND " + this.ListTreeFieldName + "='" + selectedTreeMode.ID + "'";
                }
            }

            return otherCondition;
        }

        /// <summary>
        /// 列表中与树形关联的字段名称
        /// </summary>
        protected virtual string ListTreeFieldName
        {
            get { return string.Empty; }
        }

        /// <summary>
        /// 查询操作
        /// </summary>
        protected virtual void QueryListOperation()
        {
            if (this.m_ListBusiness != null)
            {
                this.m_CurrentList = this.GetQueryList(this.m_WhereCondition);
                this.grdData.DataSource = null;
                this.grdData.DataSource = this.m_CurrentList;
                this.grdData.AutoSizeColumns();
            }
        }

        /// <summary>
        /// 是否是审核或弃审
        /// </summary>
        protected virtual bool IsCheckOrBackCheck
        {
            get { return false; }
        }

        /// <summary>
        /// 获取查询结果
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected virtual IList<XModelBase> GetQueryList(string where)
        {
            if (IsCheckOrBackCheck)
            {
                if (this.chkChecked.Checked)
                {
                    //查询已审核
                    return this.m_ListBusiness.GetCheckedViewList(UserId, where);
                }
                else
                {
                    //查询应审核
                    return this.GetToCheckList(where);
                }
            }
            else
            {
                if (this.IsQueryDataFromView)
                {
                    return this.m_ListBusiness.QueryViewByWhere(where);
                }
                else
                {
                    return this.m_ListBusiness.QueryByWhere(where);
                }
            }
        }

        protected virtual IList<XModelBase> GetToCheckList(string where)
        {
            return this.m_ListBusiness.GetToCheckViewList(JobCode, where);
        }

        /// <summary>
        /// 是否从视图加载数据
        /// </summary>
        protected virtual bool IsQueryDataFromView
        {
            get { return false; }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.QueryList();
            this.Cursor = Cursors.Default;
        }

        #endregion


        #region 列表删除操作

        void cmDelete_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Delete();
        }

        protected virtual void Delete()
        {
            this.m_EditStauts = XEditStatus.Delete;

            if (this.IsSelectedRowByCheckBox())
            {
                if (this.ConfimDelete() == false)
                {
                    return;
                }

                if (this.ValidateDelete() == false)
                {
                    return;
                }

                bool isDeleteSuccess = false;
                try
                {
                    isDeleteSuccess = this.DeleteOperate();
                    this.m_ErrorInfo = string.Empty;
                }
                catch (Exception ex)
                {
                    this.m_ErrorInfo = ex.ToString();
                    XErrorLogTool.WriteLog(ex.ToString());
                }
                if (isDeleteSuccess)
                {
                    //删除成功
                    this.DeleteRowsFromMemory();
                    if (this.m_IsShowDeleteSuccessMessage)
                    {
                        this.ShowDeleteMessage(true);
                    }
                }
                else
                {
                    //删除失败
                    this.ShowDeleteMessage(false);
                }
            }
        }

        /// <summary>
        /// 校验删除操作
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateDelete()
        {
            return this.ValidateDeleteCommon() && this.ValidateDeleteCustom();
        }

        protected virtual bool ValidateDeleteCommon()
        {

            return true;
        }

        protected virtual bool ValidateDeleteCustom()
        {
            return true;
        }


        protected virtual void ShowDeleteMessage(bool isSuccess)
        {
            string showMessage = "";
            if (isSuccess)
            {
                showMessage = "删除成功！";
            }
            else
            {
                showMessage = "删除失败";
            }
            if (this.m_ErrorInfo.Trim() != string.Empty && isSuccess == false)
            {
                showMessage += this.m_ErrorInfo;
            }
            if (this.m_AppendDeleteMessage.Trim() != string.Empty)
            {
                showMessage += this.m_AppendDeleteMessage;
            }
            XMessageBox.ShowRemindMessage(showMessage);
        }

        protected virtual bool ConfimDelete()
        {
            if (XMessageBox.ShowQuestion(this.GetConfirmDeleteMessage()) == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected virtual void DeleteRowsFromMemory()
        {
            IList<XModelBase> modelLists = this.grdData.DataSource as IList<XModelBase>;

            foreach (XModelBase model in this.m_SelectedModels)
            {
                Janus.Windows.GridEX.GridEXRow row = this.grdData.GetRow(model);
                row.Delete();
                modelLists.Remove(model);
            }
        }


        protected virtual string GetConfirmDeleteMessage()
        {
            if (this.m_SelectedModel != null)
            {
                return "确定要删除选中的" + this.m_SelectedModels.Count + "条记录吗？";
            }
            else
            {
                return "确定要删除选中的记录吗？";
            }
        }


        /// <summary>
        /// 删除操作
        /// </summary>
        protected virtual bool DeleteOperate()
        {
            return this.m_ListBusiness.Delete(this.m_SelectedModels, this.UserId);
        }

        /// <summary>
        /// 检查是否有复选框选中的记录
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsSelectedRowByCheckBox()
        {
            int selectedRowsCount = 0;

            m_SelectedDeleteIds = "";
            m_SelectedModels = new List<XModelBase>();

            foreach (Janus.Windows.GridEX.GridEXRow gridRow in this.grdData.GetRows())
            {
                if (gridRow.IsChecked)
                {
                    selectedRowsCount += 1;
                    XModelBase currentModel = gridRow.DataRow as XModelBase;
                    m_SelectedModels.Add(currentModel);
                    string id = currentModel.ID;
                    m_SelectedDeleteIds += "'" + id + "',";
                }
            }
            m_SelectedDeleteIds = m_SelectedDeleteIds.TrimEnd(',');
            if (selectedRowsCount > 0)
            {
                return true;
            }
            else
            {
                string showMessage = this.GetShowNotSelectRowMessage();
                XMessageBox.ShowRemindMessage(showMessage);
                return false;
            }
        }



        #endregion

        #region 类内公共方法

        /// <summary>
        /// 获得没有选中记录时显示的信息
        /// </summary>
        /// <returns></returns>
        protected virtual string GetShowNotSelectRowMessage()
        {
            string showMessage = "";
            switch (this.m_EditStauts)
            {
                case XEditStatus.Edit:
                    showMessage = "请选择要编辑的记录！";
                    break;
                case XEditStatus.Delete:
                    showMessage = "请选择要删除的记录";
                    break;
                case XEditStatus.Copy:
                    showMessage = "请选择要复制的记录";
                    break;
                case XEditStatus.Commit:
                    showMessage = "请选择要提交的记录";
                    break;
                case XEditStatus.Rollback:
                    showMessage = "请选择要收回的记录";
                    break;
                case XEditStatus.Check:
                    showMessage = "请选择要审核的记录";
                    break;
                case XEditStatus.BackCheck:
                    showMessage = "请选择要弃审的记录";
                    break;
                case XEditStatus.Send:
                    showMessage = "请选择要发布的记录";
                    break;
                case XEditStatus.BackSend:
                    showMessage = "请选择要撤销的记录";
                    break;
                case XEditStatus.Feedback:
                    showMessage = "请选择要反馈的记录";
                    break;
                case XEditStatus.BackFeedback:
                    showMessage = "请选择要撤回的记录";
                    break;
                default:
                    showMessage = "请选择要操作的记录";
                    break;
            }
            return showMessage;
        }

        #endregion

        #region 列表修改操作

        void cmEdit_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Edit();
        }

        /// <summary>
        /// 修改
        /// </summary>
        protected virtual void Edit()
        {
            if (!this.IsAllowOperateData)
            {
                return;
            }
            this.m_EditStauts = XEditStatus.Edit;
            if (IsSelectedRow() && ValidateEdit())
            {
                frmEditBase frm = this.GetEditForm();
                if (frm == null)
                {
                    return;
                }
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.grdData.Refresh();
                    this.EditAfter(frm);
                }
                //this.EditOperate();
            }
        }

        protected virtual void EditAfter(frmEditBase frm)
        {
            this.AddAfter(frm);
        }


        /// <summary>
        /// 校验是否选中记录
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsSelectedRow()
        {
            if (this.grdData.CurrentRow == null || this.grdData.CurrentRow.RowType != Janus.Windows.GridEX.RowType.Record)
            {
                string showMessage = this.GetShowNotSelectRowMessage();
                XMessageBox.ShowRemindMessage(showMessage);
                return false;
            }
            this.m_CurrentModel = this.grdData.CurrentRow.DataRow as XModelBase;

            return true;
        }

        /// <summary>
        /// 获取编辑窗体
        /// </summary>
        /// <returns></returns>
        protected virtual frmEditBase GetEditForm()
        {
            return new frmEditBase(this.m_CurrentModel);
        }

        #endregion

        #region 列表添加操作

        void cdAddNew_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.AddNew();
        }

        protected virtual void AddNew()
        {
            this.m_EditStauts = XEditStatus.AddNew;
            this.GetGridTable();
            if (ValiedateAddNew())
            {
                this.m_TreeModel = this.GetSelectedTreeModel();

                frmEditBase frm = this.GetAddForm(this.m_TreeModel);
                if (frm == null)
                {
                    return;
                }
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.grdData.DataSource = null;
                    this.grdData.DataSource = frm.ModelList;
                    this.grdData.Refresh();
                    this.AddAfter(frm);
                }
                //this.AddNewOperate();
            }
        }

        /// <summary>
        /// 添加成功后执行的操作
        /// </summary>
        protected virtual void AddAfter(frmEditBase frm)
        {

        }

        /// <summary>
        /// 获取增加窗体
        /// </summary>
        /// <returns></returns>
        protected virtual frmEditBase GetAddForm(XModelBase selectedTreeModel)
        {
            return new frmEditBase(this.m_CurrentList);
        }

        protected virtual XModelBase GetSelectedTreeModel()
        {
            if (this.treeView.SelectedNode == null)
            {
                return null;
            }

            if (this.treeView.SelectedNode.Tag == null)
            {
                return null;
            }
            else
            {
                return this.treeView.SelectedNode.Tag as XModelBase;
            }
        }

        /// <summary>
        /// 校验添加
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValiedateAddNew()
        {
            return this.ValidateAddNewCommon() && this.ValidateAddNewCustom();
        }

        /// <summary>
        /// 获得网格的表格
        /// </summary>
        protected virtual void GetGridTable()
        {
            if (this.grdData.DataSource == null)
            {
                this.m_CurrentList = this.grdData.DataSource as IList<XModelBase>;
            }
        }

        protected virtual bool ValidateAddNewCommon()
        {
            return true;
        }

        protected virtual bool ValidateAddNewCustom()
        {
            return true;
        }

        #endregion

        #region 树形操作

        /// <summary>
        /// 初始化树
        /// </summary>
        protected virtual void InitTreeNode()
        {
            IList<XModelBase> treeModels = this.m_TreeBusiness.GetRootModelList();

            if (this.treeView.IsHaveTitleRootNode)
            {
                //是否自动添加根节点
                this.AddTitleRootNode();
            }
            foreach (XModelBase treeModel in treeModels)
            {
                TreeNode rootNode = this.GetTreeNodeByModel(treeModel);
                if (!this.IsEndModel(treeModel))
                {
                    rootNode.Nodes.Add(" ");
                }
                if (this.treeView.IsHaveTitleRootNode)
                {
                    this.treeView.Nodes[0].Nodes.Add(rootNode);
                    this.treeView.Nodes[0].Expand();
                }
                else
                {
                    this.treeView.Nodes.Add(rootNode);
                }
            }
        }

        /// <summary>
        /// 是否是叶子节点
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsEndModel(XModelBase model)
        {
            return false;
        }

        private TreeNode GetTreeNodeByModel(XModelBase model)
        {
            TreeNode treeNode = new TreeNode();

            string text = this.GetModelText(model);
            treeNode.Text = text;
            treeNode.ToolTipText = text;
            treeNode.Tag = model;

            return treeNode;
        }

        /// <summary>
        /// 获取显示值
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual string GetModelText(XModelBase model)
        {
            return model.ID;
        }

        private void treeView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (this.IsShowTreeMenu())
                {
                    this.cmdTreeView.Show(this.treeView);
                }
            }
        }

        /// <summary>
        /// 是否显示树形右键菜单
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsShowTreeMenu()
        {
            return true;
        }

        void cmdTreeDelete_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (this.ValidateTreeDelete())
            {
                this.TreeDelete();
            }
        }

        protected virtual void TreeDelete()
        {
            TreeNode selectedNode = this.treeView.SelectedNode;
            if (selectedNode.Tag != null)
            {
                XModelBase model = selectedNode.Tag as XModelBase;
                if (this.m_TreeBusiness.Delete(model, XCommon.LoginUsersInfo.ID))
                {
                    selectedNode.Remove();
                }
            }
        }

        protected virtual bool ValidateTreeDelete()
        {
            return this.ValidateTreeDeleteCommon() && this.ValidateTreeDeleteCustom();
        }

        protected virtual bool ValidateTreeDeleteCustom()
        {
            return true;
        }

        protected virtual bool ValidateTreeDeleteCommon()
        {
            if (this.treeView.SelectedNode == null)
            {
                XMessageBox.ShowError("请选择要删除的节点！");
                return false;
            }
            if (this.treeView.SelectedNode.Tag == null)
            {
                return false;
            }

            XModelBase model = this.treeView.SelectedNode.Tag as XModelBase;
            if (!this.m_TreeBusiness.IsEndModel(model))
            {
                XMessageBox.ShowError("该文件夹下有子文件夹，不能删除！");
                return false;
            }

            if (XMessageBox.ShowQuestion("确定要删除选中的节点吗？") == System.Windows.Forms.DialogResult.No)
            {
                return false;
            }
            return true;
        }

        #region 树形修改

        void cmdTreeEdit_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (this.ValidateEdit())
            {
                this.TreeEdit();
            }
        }

        protected virtual void TreeEdit()
        {
            frmTreeEditBase frm = this.GetTreeEditForm();
            if (frm != null)
            {
                frm.ShowDialog();
            }
        }

        protected virtual frmTreeEditBase GetTreeEditForm()
        {
            return null;
        }

        protected virtual bool ValidateEdit()
        {
            return this.ValidateEditCommon() && this.ValidateEditCustom();
        }

        protected virtual bool ValidateEditCustom()
        {
            return true;
        }

        protected virtual bool ValidateEditCommon()
        {
            if (this.treeView.SelectedNode == null)
            {
                XMessageBox.ShowError("请选择要修改的节点！");
                return false;
            }
            if (this.treeView.SelectedNode.Tag == null)
            {
                return false;
            }
            return true;
        }

        #endregion

        /// <summary>
        /// 树形是否允许有子节点
        /// </summary>
        protected virtual bool IsAllowHaveChilds
        {
            get { return true; }
        }

        #region 树形新增

        void cmdTreeAddNew_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.TreeAddNew();
        }

        protected virtual void TreeAddNew()
        {
            if (this.ValidateTreeAddNew())
            {
                frmTreeEditBase frm = this.GetAddNewForm();
                frm.ShowDialog();
            }
        }

        /// <summary>
        /// 获取新增窗体
        /// </summary>
        /// <returns></returns>
        protected virtual frmTreeEditBase GetAddNewForm()
        {
            return new frmTreeEditBase(this.treeView);
        }

        /// <summary>
        /// 新增校验
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateTreeAddNew()
        {
            return this.ValidateTreeAddNewCommon() && this.ValidateTreeAddNewCustom();
        }

        /// <summary>
        /// 公共新增校验
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateTreeAddNewCommon()
        {
            return true;
        }

        /// <summary>
        /// 自定义新增校验
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateTreeAddNewCustom()
        {
            return true;
        }

        #endregion


        protected virtual void AddTitleRootNode()
        {
            TreeNode rootNode = new TreeNode();
            rootNode.Text = this.treeView.RootTitle;
            this.treeView.Nodes.Add(rootNode);
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
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

                        //如果Tag为空，则说明是首次加载
                        IList<XModelBase> childModels = this.m_TreeBusiness.GetChildModelLists(currentModel);

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
                }
            }
        }

        #endregion


        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cmdExit_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Close();
        }

        void cmdRefreshTree_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.RefreshTreeData();
        }

        /// <summary>
        /// 刷新数据
        /// </summary>
        protected virtual void RefreshTreeData()
        {
            this.treeView.Nodes.Clear();
            this.InitTreeNode();
        }

        private void grdData_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.cmRight.Show(this.grdData);
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.chkAllNodes.Checked = false;
            this.QueryList();
        }

        protected virtual bool IsAllowDownload
        {
            get { return false; }
        }

        protected virtual void Download()
        {
            if (this.grdData.CurrentRow != null && this.grdData.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
            {
                XModelBase model = this.grdData.CurrentRow.DataRow as XModelBase;

                this.m_CurrentModel = model;

                string mainId = this.GetModelPKValue(model);

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
                        this.DownloadAfter();
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

        protected virtual string GetModelPKValue(XModelBase model)
        {
            return model.ID;
        }

        protected virtual void InitFileAttachBusiness()
        {
            this.m_FileAttachBusiness = new XFileAttachmentBusiness();
        }



        protected virtual void DownloadAfter()
        {

        }

    }
}
