using MMIS.BLL;
using MMIS.Helper;
using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMIS.UI.Common
{
    public partial class frmTreeBase : frmBase
    {
        protected XBusinessBase m_TreeBusiness;
        private XModelBase m_SelectedModel = null;

        public XModelBase SelectedModel
        {
            get { return this.m_SelectedModel; }
        }

        protected virtual bool IsSelectForm
        {
            get { return false; }
        }

        public frmTreeBase()
        {
            InitializeComponent();

            this.m_TreeBusiness = this.InitTreeBusiness();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            base.FormLoadFunction(sender, e);
            this.InitTreeNode();
            this.InitRightMenuCommandEvent();
            if (this.IsSelectForm)
            {
                this.Text = this.SelectFormTitle;
            }
        }

        protected virtual string SelectFormTitle
        {
            get { return this.Text; }
        }

        private void InitRightMenuCommandEvent()
        {

        }

        protected virtual XBusinessBase InitTreeBusiness()
        {
            return new XBusinessBase();
        }

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
            return this.m_TreeBusiness.IsEndModel(model);
        }

        protected virtual void AddTitleRootNode()
        {
            TreeNode rootNode = new TreeNode();
            rootNode.Text = this.treeView.RootTitle;
            this.treeView.Nodes.Add(rootNode);
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
            frmTreeEditBase frm = this.GetEditForm();
            if (frm != null)
            {
                frm.ShowDialog();
            }
        }

        protected virtual frmTreeEditBase GetEditForm()
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

        protected virtual void Select()
        {
            if (this.treeView.SelectedNode != null)
            {
                this.m_SelectedModel = this.treeView.SelectedNode.Tag as XModelBase;
            }
            else
            {
                this.m_SelectedModel = null;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void treeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (IsSelectForm)
            {
                this.Select();
            }
            else
            {
                this.cmdTreeEdit_Click(null, null);
            }
        }

        protected virtual bool IsAllowDoubleClickEdit
        {
            get { return true; }
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
    }
}
