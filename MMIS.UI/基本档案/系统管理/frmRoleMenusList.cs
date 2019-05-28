using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.UI.Common;
using MMIS.BLL;
using MMIS.Model;
using MMIS.Helper;
using MMIS.FolderModel;

namespace MMIS.UI
{
    public partial class frmRoleMenusList : frmBase
    {
        private XRoleBusiness m_RoleBusiness = new XRoleBusiness();
        private XRoleMenusBusiness m_RoleMenusBusiness = new XRoleMenusBusiness();
        private XMenuBusiness m_MenuBusiness = new XMenuBusiness();
        private XMenuFolderBusiness m_MenuFolderBusiness = new XMenuFolderBusiness();
        private XMenuGroupBusiness m_MenuGroupBusienss = new XMenuGroupBusiness();

        public frmRoleMenusList()
        {
            InitializeComponent();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            base.FormLoadFunction(sender, e);
            this.InitRoleGrid();
            this.InitMenuTree();

            IList<XModelBase> modelInfos = this.grdData.DataSource as IList<XModelBase>;
            if (modelInfos.Count > 0)
            {
                this.FillRoleMenus(modelInfos[0] as XRoleInfo);
            }
        }

        private void InitRoleGrid()
        {
            this.grdData.DataSource = this.m_RoleBusiness.GetAll();
            this.grdData.AutoSizeColumns();
        }

        private void InitMenuTree()
        {
            this.tvRole.Nodes.Clear();

            IList<XModelBase> folderInfos = this.m_MenuFolderBusiness.GetAll();
            IList<XModelBase> groupInfos = this.m_MenuGroupBusienss.GetAll();
            IList<XModelBase> menuInfos = this.m_MenuBusiness.GetAll();

            foreach (XModelBase folderModel in folderInfos)
            {
                XMenuFolderInfo folderInfo = folderModel as XMenuFolderInfo;

                XTreeNode folderNode = new XTreeNode();

                folderNode.Code = folderInfo.ID;
                folderNode.Name = folderInfo.FolderName;
                folderNode.Model = folderInfo;
                folderNode.Text = folderInfo.FolderName;

                IList<XMenuGroupInfo> menuGroupInfos = this.GetMenuGroups(groupInfos, folderInfo);
                foreach (XMenuGroupInfo groupInfo in menuGroupInfos)
                {
                    XTreeNode groupNode = new XTreeNode();

                    groupNode.Code = groupInfo.ID;
                    groupNode.Name = groupInfo.GroupName;
                    groupNode.Model = groupInfo;
                    groupNode.Text = groupInfo.GroupName;

                    IList<XMenuInfo> menuInfs = this.GetMenuInfos(menuInfos, groupInfo);
                    foreach (XMenuInfo menuInfo in menuInfs)
                    {
                        XTreeNode menuNode = new XTreeNode();

                        menuNode.Code = menuInfo.ID;
                        menuNode.Name = menuInfo.MenuName;
                        menuNode.Model = menuInfo;
                        menuNode.Text = menuInfo.MenuName;

                        groupNode.Nodes.Add(menuNode);
                    }

                    folderNode.Nodes.Add(groupNode);
                }

                this.tvRole.Nodes.Add(folderNode);
            }
        }

        /// <summary>
        /// 获取菜单分组
        /// </summary>
        /// <param name="menuInfos"></param>
        /// <param name="folderInfo"></param>
        /// <returns></returns>
        private IList<XMenuGroupInfo> GetMenuGroups(IList<XModelBase> menuGroupInfos, XMenuFolderInfo folderInfo)
        {
            IList<XMenuGroupInfo> groupInfos = new List<XMenuGroupInfo>();

            foreach (XModelBase groupModel in menuGroupInfos)
            {
                XMenuGroupInfo groupInfo = groupModel as XMenuGroupInfo;
                if (groupInfo.FolderId == folderInfo.ID)
                {
                    groupInfos.Add(groupInfo);
                }
            }

            return groupInfos;
        }

        /// <summary>
        /// 获取菜单
        /// </summary>
        /// <param name="menuInfos"></param>
        /// <param name="groupInfo"></param>
        /// <returns></returns>
        private IList<XMenuInfo> GetMenuInfos(IList<XModelBase> menuInfos, XMenuGroupInfo groupInfo)
        {
            IList<XMenuInfo> infos = new List<XMenuInfo>();

            foreach (XModelBase menuModel in menuInfos)
            {
                XMenuInfo menuInfo = menuModel as XMenuInfo;
                if (menuInfo.GroupId == groupInfo.ID)
                {
                    infos.Add(menuInfo);
                }
            }

            return infos;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {

        }

        private void btnDeSelect_Click(object sender, EventArgs e)
        {

        }

        private void grdData_Click(object sender, EventArgs e)
        {
            if (this.grdData.CurrentRow != null &&
               this.grdData.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
            {
                XRoleInfo roleInfo = this.grdData.CurrentRow.DataRow as XRoleInfo;
                this.FillRoleMenus(roleInfo);
            }
        }

        private IList<TreeNode> m_SelectedMenuNodes;

        private void FillRoleMenus(XRoleInfo roleInfo)
        {
            if (roleInfo != null)
            {
                m_SelectedMenuNodes = new List<TreeNode>();

                IList<XModelBase> roleMenus = this.m_RoleMenusBusiness.GetRoleMenus(roleInfo.RID);

                foreach (XTreeNode treeNode in this.tvRole.Nodes)
                {
                    this.GetSelectedMenuNodes(treeNode);
                    treeNode.Checked = false;
                }

                foreach (XTreeNode menuNode in this.m_SelectedMenuNodes)
                {
                    string menuId = menuNode.Code;
                    if (IsMenuInRoleMenus(menuId, roleMenus))
                    {
                        menuNode.Checked = true;
                    }
                }
            }

            this.tvRole.ExpandAll();
        }


        private bool IsMenuInRoleMenus(string menuId, IList<XModelBase> roleMenus)
        {
            foreach (XModelBase model in roleMenus)
            {
                XRoleMenusInfo roleMenuInfo = model as XRoleMenusInfo;
                if (roleMenuInfo.MenuId == menuId)
                {
                    return true;
                }
            }

            return false;
        }

        private void GetSelectedMenuNodes(TreeNode treeNode)
        {
            if (treeNode.Nodes.Count > 0)
            {
                foreach (TreeNode childNode in treeNode.Nodes)
                {
                    childNode.Checked = false;
                    GetSelectedMenuNodes(childNode);
                }
            }
            else
            {
                treeNode.Checked = false;
                this.m_SelectedMenuNodes.Add(treeNode);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdData.CurrentRow == null || this.grdData.CurrentRow.RowType != Janus.Windows.GridEX.RowType.Record)
            {
                XMessageBox.ShowError("请选择角色！");
                return;
            }

            XRoleInfo roleInfo = this.grdData.CurrentRow.DataRow as XRoleInfo;


            IList<XMenuInfo> selectedMenus = this.GetSelectedMenus();
            if (this.m_RoleMenusBusiness.SaveRoleMenus(roleInfo.RID, selectedMenus, XCommon.LoginUsersInfo.RID))
            {
                XMessageBox.ShowRemindMessage("保存成功！");
            }
            else
            {
                XMessageBox.ShowError("保存失败！");
            }
        }

        private IList<XMenuInfo> m_SelectedMenus;

        /// <summary>
        /// 获取选中的菜单
        /// </summary>
        /// <returns></returns>
        private IList<XMenuInfo> GetSelectedMenus()
        {
            m_SelectedMenus = new List<XMenuInfo>();

            foreach (XTreeNode treeNode in this.tvRole.Nodes)
            {
                this.GetSelectedMenus(treeNode);
            }

            return m_SelectedMenus;
        }

        private void GetSelectedMenus(XTreeNode treeNode)
        {
            if (treeNode.Nodes.Count > 0)
            {
                //如果有子节点，则继续递归查找末级节点
                foreach (XTreeNode node in treeNode.Nodes)
                {
                    this.GetSelectedMenus(node);
                }
            }
            else
            {
                if (treeNode.Model is XMenuInfo)
                {
                    XMenuInfo menuInfo = treeNode.Model as XMenuInfo;
                    if (treeNode.Checked)
                    {
                        this.m_SelectedMenus.Add(menuInfo);
                    }
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string whereCondition = XQueryTool.GetQueryCondition(this.pnlTop);

            IList<XModelBase> userModelInfos = this.m_RoleBusiness.QueryByWhere(whereCondition);

            this.grdData.DataSource = userModelInfos;

            if (userModelInfos.Count > 0)
            {
                this.FillRoleMenus(userModelInfos[0] as XRoleInfo);
            }

           
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            this.tvRole.CollapseAll();
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            this.tvRole.ExpandAll();
        }

    }
}
