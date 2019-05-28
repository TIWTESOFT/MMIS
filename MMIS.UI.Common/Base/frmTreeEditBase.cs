using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.Model;
using MMIS.Component;

namespace MMIS.UI.Common
{
    public partial class frmTreeEditBase : frmEditBase
    {
        /// <summary>
        /// 是否是根节点
        /// </summary>
        protected bool m_IsRootNode = false;

        public bool IsRootNode
        {
            get
            {
                return this.m_IsRootNode;
            }
            set
            {
                this.chkIsRootNode.Checked = value;
            }
        }

        protected XTreeView m_TreeView = null;
        protected TreeNode m_TreeNode = null;

        public frmTreeEditBase()
            : base()
        {
            InitializeComponent();
            this.Init();
        }

        public frmTreeEditBase(XTreeView treeView)
            : base()
        {
            InitializeComponent();
            this.m_TreeView = treeView;
            if (treeView.Nodes.Count == 0)
            {
                this.chkIsRootNode.Checked = true;
                this.chkIsRootNode.Enabled = false;
            }
            this.Init();
        }

        public frmTreeEditBase(TreeNode treeNode)
            : base(treeNode.Tag as XModelBase)
        {
            InitializeComponent();
            this.m_TreeView = treeNode.TreeView as XTreeView;
            this.m_TreeNode = treeNode;
            this.Init();
        }

        protected virtual void Init()
        {
            if (!IsAllowHaveChilds)
            {
                this.IsRootNode = true;
                this.chkIsRootNode.Visible = false;
            }
        }

        /// <summary>
        /// 是否允许有子节点
        /// </summary>
        protected virtual bool IsAllowHaveChilds
        {
            get { return true; }
        }

        protected override void SavedAfterOperate()
        {
            TreeNode treeNode = this.Model2TreeNode(this.m_CurrentModel);

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                if (this.IsAllowHaveChilds)
                {
                    //如果允许有子节点
                    //新增
                    if (this.m_TreeView.IsHaveTitleRootNode)
                    {
                        //如果有标题根节点，则往选中节点添加子节点
                        TreeNode selectedNode = this.m_TreeView.SelectedNode;
                        selectedNode.Nodes.Add(treeNode);
                    }
                    else
                    {
                        if (this.chkIsRootNode.Checked)
                        {
                            this.m_TreeView.Nodes.Add(treeNode);
                        }
                        else
                        {
                            TreeNode selectedNode = this.m_TreeView.SelectedNode;
                            selectedNode.Nodes.Add(treeNode);
                        }
                    }
                }
                else
                {
                    //如果不允许有子节点
                    if (this.m_TreeView.IsHaveTitleRootNode)
                    {
                        //如果有标题根节点，则往选中节点添加子节点
                        if (this.m_TreeView.Nodes.Count > 0)
                        {
                            this.m_TreeView.Nodes[0].Nodes.Add(treeNode);
                        }
                    }
                    else
                    {
                        this.m_TreeView.Nodes.Add(treeNode);
                    }
                }
            }
            else if (this.m_EditStatus == XEditStatus.Edit)
            {
                this.m_TreeNode.Text = this.GetTreeNodeText(this.m_CurrentModel);
            }
        }

        /// <summary>
        /// 将实体转换为树形节点
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual TreeNode Model2TreeNode(XModelBase model)
        {
            TreeNode treeNode = new TreeNode();

            treeNode.Tag = model;
            treeNode.Text = this.GetTreeNodeText(model);

            return treeNode;
        }

        /// <summary>
        /// 获得树形节点的显示文本
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual string GetTreeNodeText(XModelBase model)
        {
            return model.ID;
        }


    }
}
