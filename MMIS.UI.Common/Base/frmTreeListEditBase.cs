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
using MMIS.Component;

namespace MMIS.UI.Common
{
    public partial class frmTreeListEditBase : frmBase
    {
        protected XBusinessBase m_Business;

        protected TreeNode m_PreSelecedNode = null;

        protected XFormValidateTool m_ValidateFormTool = new XFormValidateTool();

        protected XEditStatus m_EditStatus = XEditStatus.None;

        /// <summary>
        /// 主键
        /// </summary>
        protected string m_PrimaryKey = string.Empty;

        /// <summary>
        /// 当前选择的实体
        /// </summary>
        protected XModelBase m_CurrentModel = null;

        public frmTreeListEditBase()
        {
            InitializeComponent();
            this.m_Business = this.InitBusiness();
        }

        protected virtual XBusinessBase InitBusiness()
        {
            return new XBusinessBase();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            base.FormLoadFunction(sender, e);
            this.InitSavedForm();
            this.InitTreeNode();
        }


        /// <summary>
        /// 获取选择的节点的ID
        /// </summary>
        /// <returns></returns>
        protected virtual string GetParentID()
        {
            //if (this.chkRootNode.Checked)
            //{
            //    return string.Empty;
            //}
            //if (this.treeView.SelectedNode != null)
            //{
            //    XModelBase model = this.treeView.SelectedNode.Tag as XModelBase;
            //    return model.ID;
            //}
            //else
            //{
            //    return string.Empty;
            //}

            XModelBase model = this.txtParentNode.Tag as XModelBase;

            if (model != null)
            {
                return model.ID;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 初始化树
        /// </summary>
        protected virtual void InitTreeNode()
        {
            IList<XModelBase> treeModels = this.m_Business.GetRootModelList();

            foreach (XModelBase treeModel in treeModels)
            {
                TreeNode rootNode = this.GetTreeNodeByModel(treeModel);
                if (!this.IsEndModel(treeModel))
                {
                    rootNode.Nodes.Add(" ");
                }
                this.treeView.Nodes.Add(rootNode);
            }
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

        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cmDelete_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Delete();
        }

        protected virtual void Delete()
        {
            if (this.ValidateDeleteCommon())
            {
                if (this.DeleteOperate())
                {
                    this.treeView.SelectedNode.Remove();
                }
            }
        }

        protected virtual bool ValidateDeleteCommon()
        {
            if (this.treeView.SelectedNode == null)
            {
                XMessageBox.ShowError("请选择要删除的节点！");
                return false;
            }

            XModelBase model = this.treeView.SelectedNode.Tag as XModelBase;
            if (this.m_Business.IsEndNode(model))
            {
                XMessageBox.ShowError("该节点下有子节点，删除前需要先删除子节点！");
                return false;
            }

            if (this.m_Business.IsUsed(model.ID))
            {
                return false;
            }

            if (XMessageBox.ShowQuestion("确定要删除选中的记录吗？") == System.Windows.Forms.DialogResult.No)
            {
                return false;
            }

            return true;
        }

        protected virtual bool DeleteOperate()
        {
            TreeNode selectedNode = this.treeView.SelectedNode;
            XModelBase currentModel = selectedNode.Tag as XModelBase;
            return this.m_Business.Delete(currentModel, this.UserId);
        }

        /// <summary>
        /// 修改操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cmdEdit_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Edit();
        }

        protected virtual void InitEdit()
        {
            if (this.treeView.SelectedNode.Parent == null)
            {
                this.chkRootNode.Checked = true;
            }
            else
            {
                this.chkRootNode.Checked = false;
            }
            chkRootNode_CheckedChanged(null, null);
        }

        protected virtual void Edit()
        {
            this.m_EditStatus = XEditStatus.Edit;
            this.InitEdit();
            this.InitEditForm();
            if (this.ValidateBeforeEdit())
            {
                m_CurrentModel = this.treeView.SelectedNode.Tag as XModelBase;
                if (m_CurrentModel != null)
                {
                    this.FillEditControl(m_CurrentModel);
                }
            }
        }

        /// <summary>
        /// 填充要保存的模型
        /// </summary>
        protected virtual void FillModelInfo()
        {

        }

        /// <summary>
        /// 修改前校验
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateBeforeEdit()
        {
            if (this.treeView.SelectedNode == null)
            {
                XMessageBox.ShowError("请选择要修改的节点！");
                return false;
            }
            return true;
        }

        /// <summary>
        /// 添加操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cmdAddNew_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.AddNew();
        }

        protected virtual void AddNew()
        {
            this.m_EditStatus = XEditStatus.AddNew;
            this.InitAddNew();
            this.InitAddForm();
        }

        protected virtual void InitAddNew()
        {
            if (this.treeView.Nodes.Count == 0 || this.treeView.SelectedNode == null)
            {
                this.chkRootNode.Checked = true;
            }
            else
            {
                this.chkRootNode.Checked = false;
            }
            chkRootNode_CheckedChanged(null, null);
        }

        /// <summary>
        /// 初始化保存后的窗体
        /// </summary>
        protected virtual void InitSavedForm()
        {
            foreach (Control c in this.pnlEdit.Controls)
            {
                c.Enabled = false;
            }
        }

        /// <summary>
        /// 初始化添加窗体
        /// </summary>
        protected virtual void InitAddForm()
        {
            foreach (Control contorl in this.pnlEdit.Controls)
            {
                contorl.Enabled = true;
                if (contorl is XEditBox)
                {
                    if (contorl.Name != "txtParentNode")
                    {
                        contorl.Text = string.Empty;
                    }
                }
                else if (contorl is XCheckBox)
                {
                    XCheckBox checkBox = contorl as XCheckBox;
                    checkBox.Checked = false;
                }
                else if (contorl is XNumberEditBox)
                {
                    XNumberEditBox numberEditBox = contorl as XNumberEditBox;
                    numberEditBox.Value = 0;
                }
            }
        }

        /// <summary>
        /// 初始化修改窗体
        /// </summary>
        protected virtual void InitEditForm()
        {
            foreach (Control contorl in this.pnlEdit.Controls)
            {
                contorl.Enabled = true;
            }
            if (this.m_EditStatus == XEditStatus.Edit)
            {
                this.chkRootNode.Enabled = false;
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.m_EditStatus = XEditStatus.None;
            if (this.m_PreSelecedNode != null)
            {
                this.m_PreSelecedNode.ForeColor = Color.Black;
            }
            TreeNode currentNode = e.Node;
            currentNode.ForeColor = Color.Blue;
            this.m_PreSelecedNode = currentNode;
            this.InitSavedForm();
            XModelBase model = currentNode.Tag as XModelBase;
            if (e.Node.Parent == null)
            {
                this.chkRootNode.Checked = true;
            }
            else
            {
                this.chkRootNode.Checked = false;
            }
            this.chkRootNode_CheckedChanged(null, null);
            if (model != null)
            {
                this.FillEditControl(model);
            }
        }

        /// <summary>
        /// 根据实体值填写控件
        /// </summary>
        /// <param name="modelBase"></param>
        protected virtual void FillEditControl(XModelBase modelBase)
        {

        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cmdRefresh_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.RefreshData();
        }

        /// <summary>
        /// 刷新数据
        /// </summary>
        protected virtual void RefreshData()
        {
            this.treeView.Nodes.Clear();
            this.InitTreeNode();
            this.InitSavedForm();
        }

        /// <summary>
        /// 打开折叠时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        IList<XModelBase> childModels = this.m_Business.GetChildModelLists(currentModel);

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

        /// <summary>
        /// 是否是叶子节点
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsEndModel(XModelBase model)
        {
            // return false;
            return this.m_Business.IsEndModel(model);
        }

        /// <summary>
        /// 校验窗体
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateForm()
        {
            return this.m_ValidateFormTool.ValidateControls(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateForm() && this.ValidateCommon())
            {
                if (this.SaveOperate())
                {
                    this.FillAddAndEditTreeNode();
                    this.InitSavedForm();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void FillAddAndEditTreeNode()
        {
            TreeNode selectedNode = this.treeView.SelectedNode;

            TreeNode addOrEditNode = null;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                addOrEditNode = new TreeNode();
            }
            else
            {
                addOrEditNode = selectedNode;
            }
            addOrEditNode.Tag = m_CurrentModel;
            addOrEditNode.Text = this.GetModelText(m_CurrentModel);
            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                //如果是新增
                if (this.chkRootNode.Checked)
                {
                    //如果是根节点
                    this.treeView.Nodes.Add(addOrEditNode);
                }
                else
                {
                    //如果不是根节点
                    selectedNode.Nodes.Add(addOrEditNode);
                }
            }
        }

        /// <summary>
        /// 公共校验
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateCommon()
        {
            if (this.m_EditStatus == XEditStatus.AddNew && this.chkRootNode.Checked == false)
            {
                if (this.treeView.SelectedNode == null)
                {
                    XMessageBox.ShowError("请选择父节点！");
                    return false;
                }
            }
            return true;
        }

        protected void FillTreeNode()
        {

        }

        /// <summary>
        /// 保存操作
        /// </summary>
        /// <returns></returns>
        protected virtual bool SaveOperate()
        {
            bool isSuccess = false;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                this.m_CurrentModel = this.InitNewModel();
                this.m_CurrentModel.ModelStatus = XModelStatus.Add;
                this.FillModelInfo();
                isSuccess = this.m_Business.Insert(this.m_CurrentModel);
            }
            else if (this.m_EditStatus == XEditStatus.Edit)
            {
                this.m_CurrentModel.ModelStatus = XModelStatus.Modify;
                this.FillModelInfo();
                isSuccess = this.m_Business.Update(this.m_CurrentModel);
            }

            if (isSuccess)
            {
                this.FillSavedModelInfo();
            }

            return isSuccess;
        }

        /// <summary>
        /// 填充保存后的实体值
        /// </summary>
        protected virtual void FillSavedModelInfo()
        {
            //this.m_CurrentModel.TimeStamp = XHelper.GetFormatedTime(this.m_Business.GetTimeStamp(m_CurrentModel.ID));
        }

        protected virtual XModelBase InitNewModel()
        {
            return new XModelBase();
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cmdExit_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Close();
        }

        private void chkRootNode_CheckedChanged(object sender, EventArgs e)
        {
            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                if (this.chkRootNode.Checked)
                {
                    //this.txtParentNode.Enabled = false;
                    this.txtParentNode.Text = string.Empty;
                    this.txtParentNode.Tag = null;
                }
                else
                {
                    if (this.treeView.Nodes.Count > 0)
                    {
                        this.txtParentNode.Text = this.treeView.SelectedNode.Text;
                        this.txtParentNode.Tag = this.treeView.SelectedNode.Tag;
                    }
                }
            }
            else if (this.m_EditStatus == XEditStatus.Edit || this.m_EditStatus == XEditStatus.None)
            {
                TreeNode parentNode = this.treeView.SelectedNode.Parent;
                if (parentNode != null)
                {
                    this.txtParentNode.Text = parentNode.Text;
                    this.txtParentNode.Tag = parentNode.Tag;
                }
                else
                {
                    this.txtParentNode.Text = string.Empty;
                    this.txtParentNode.Tag = null;
                }
            }
        }

    }
}
