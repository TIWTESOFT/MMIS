using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.Model;
using Janus.Windows.UI.Tab;
using MMIS.Helper;

namespace MMIS.UI
{
    public partial class frmRemindConfigList : frmBase
    {
        private XRemindConfigBusiness m_RemindConfigBusiness = new XRemindConfigBusiness();
        private XUsersBusiness m_UserBusiness = new XUsersBusiness();
        private XRoleBusiness m_RoleBusiness = new XRoleBusiness();
        private XRemindUsersBusiness m_RemindUsersBusiness = new XRemindUsersBusiness();
        private XRemindRolesBusiness m_RemindRoleBusiness = new XRemindRolesBusiness();

        public frmRemindConfigList()
        {
            InitializeComponent();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            base.FormLoadFunction(sender, e);
            this.InitRemindGrid();
            this.InitRoleTree();
            this.InitUserTree();

            IList<XModelBase> modelInfos = this.grdData.DataSource as IList<XModelBase>;
            if (modelInfos.Count > 0)
            {
                this.FillRemindRoles(modelInfos[0] as XRemindConfigInfo);
                this.FillRemindUsers(modelInfos[0] as XRemindConfigInfo);
            }
        }

        private void InitRemindGrid()
        {
            this.grdData.DataSource = this.m_RemindConfigBusiness.GetAll();
            this.grdData.AutoSizeColumns();
        }

        private void InitRoleTree()
        {
            this.tvRole.Nodes.Clear();

            IList<XModelBase> roleInfos = this.m_RoleBusiness.GetAll();

            foreach (XModelBase modelInfo in roleInfos)
            {
                XRoleInfo roleInfo = modelInfo as XRoleInfo;

                XTreeNode treeNode = new XTreeNode();

                treeNode.Code = roleInfo.ID;
                treeNode.Name = roleInfo.RoleName;
                treeNode.Model = roleInfo;
                //treeNode.Text = "(" + roleInfo.ID + ")" + roleInfo.RoleName;
                treeNode.Text = roleInfo.RoleName;

                this.tvRole.Nodes.Add(treeNode);
            }
        }

        private void InitUserTree()
        {
            this.tvUsers.Nodes.Clear();

            IList<XModelBase> userInfos = this.m_UserBusiness.GetAll();

            foreach (XModelBase modelInfo in userInfos)
            {
                XUsersInfo usersInfo = modelInfo as XUsersInfo;

                XTreeNode treeNode = new XTreeNode();

                treeNode.Code = usersInfo.ID;
                treeNode.Name = usersInfo.RealName;
                treeNode.Model = usersInfo;
                //treeNode.Text = "(" + roleInfo.ID + ")" + roleInfo.RoleName;
                treeNode.Text = usersInfo.RealName;

                this.tvUsers.Nodes.Add(treeNode);
            }
        }

        private void FillRemindRoles(XRemindConfigInfo remindInfo)
        {
            if (remindInfo != null)
            {
                IList<XModelBase> remindRoleInfos = this.m_RemindRoleBusiness.GetRemindRoles(remindInfo.RID);

                foreach (XTreeNode treeNode in this.tvRole.Nodes)
                {
                    string roleCode = treeNode.Code;
                    if (IsRoleInRemindRoles(roleCode, remindRoleInfos))
                    {
                        //如果有该角色，则勾选
                        treeNode.Checked = true;
                    }
                    else
                    {
                        treeNode.Checked = false;
                    }
                }
            }
        }

        private bool IsRoleInRemindRoles(string roleId, IList<XModelBase> remindRoleInfos)
        {
            foreach (XModelBase model in remindRoleInfos)
            {
                XRemindRolesInfo remindRoleInfo = model as XRemindRolesInfo;
                if (remindRoleInfo.RoleId == roleId)
                {
                    return true;
                }
            }

            return false;
        }

        private void FillRemindUsers(XRemindConfigInfo remindInfo)
        {
            if (remindInfo != null)
            {
                IList<XModelBase> remindUsersInfo = this.m_RemindUsersBusiness.GetRemindUsers(remindInfo.RID);

                foreach (XTreeNode treeNode in this.tvUsers.Nodes)
                {
                    string userId = treeNode.Code;
                    if (IsRoleInRemindUsers(userId, remindUsersInfo))
                    {
                        //如果有该角色，则勾选
                        treeNode.Checked = true;
                    }
                    else
                    {
                        treeNode.Checked = false;
                    }
                }
            }
        }

        private bool IsRoleInRemindUsers(string userId, IList<XModelBase> remindUserInfos)
        {
            foreach (XModelBase model in remindUserInfos)
            {
                XRemindUsersInfo remindUserInfo = model as XRemindUsersInfo;
                if (remindUserInfo.UserId == userId)
                {
                    return true;
                }
            }

            return false;
        }

        private void grdData_Click(object sender, EventArgs e)
        {
            if (this.grdData.CurrentRow != null &&
                this.grdData.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
            {
                XRemindConfigInfo remindConfigInfo = this.grdData.CurrentRow.DataRow as XRemindConfigInfo;
                this.FillRemindRoles(remindConfigInfo);
                this.FillRemindUsers(remindConfigInfo);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string whereCondition = XQueryTool.GetQueryCondition(this.pnlTop);

            IList<XModelBase> remindInfos = this.m_RemindConfigBusiness.QueryByWhere(whereCondition);

            this.grdData.DataSource = remindInfos;

            if (remindInfos.Count > 0)
            {
                this.FillRemindRoles(remindInfos[0] as XRemindConfigInfo);
                this.FillRemindUsers(remindInfos[0] as XRemindConfigInfo);
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            UITabPage selectedTab = this.xTabControl1.SelectedTab;
            TreeView treeView = this.FindTreeView(selectedTab);
            if (treeView != null)
            {
                foreach (XTreeNode treeNode in treeView.Nodes)
                {
                    treeNode.Checked = true;
                }
            }
        }

        private TreeView FindTreeView(UITabPage selectedTab)
        {
            if (selectedTab != null)
            {
                if (selectedTab.Controls.Count > 0)
                {
                    TreeView treeView = selectedTab.Controls[0] as TreeView;
                    if (treeView != null)
                    {
                        return treeView;
                    }
                }
            }

            return null;
        }

        private void btnDeSelect_Click(object sender, EventArgs e)
        {
            UITabPage selectedTab = this.xTabControl1.SelectedTab;
            TreeView treeView = this.FindTreeView(selectedTab);
            if (treeView != null)
            {
                foreach (XTreeNode treeNode in treeView.Nodes)
                {
                    treeNode.Checked = !treeNode.Checked;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XRemindConfigInfo remindConfigInfo = this.grdData.CurrentRow.DataRow as XRemindConfigInfo;

            IList<XRoleInfo> selectedRoles = this.GetSelectedRoles();
            IList<XUsersInfo> selectedUsers = this.GetSelectedUsers();

            if (this.m_RemindConfigBusiness.SaveRemindConfig(remindConfigInfo, selectedUsers, selectedRoles))
            {
                XMessageBox.ShowRemindMessage("保存成功！");
            }
            else
            {
                XMessageBox.ShowError("保存失败！");
            }
        }

        /// <summary>
        /// 获取选中的角色
        /// </summary>
        /// <returns></returns>
        private IList<XRoleInfo> GetSelectedRoles()
        {
            IList<XRoleInfo> roleInfos = new List<XRoleInfo>();

            foreach (XTreeNode treeNode in this.tvRole.Nodes)
            {
                if (treeNode.Checked)
                {
                    XRoleInfo roleInfo = treeNode.Model as XRoleInfo;
                    if (roleInfo != null)
                    {
                        roleInfos.Add(roleInfo);
                    }
                }
            }

            return roleInfos;
        }

        /// <summary>
        /// 获取选中的角色
        /// </summary>
        /// <returns></returns>
        private IList<XUsersInfo> GetSelectedUsers()
        {
            IList<XUsersInfo> userInfos = new List<XUsersInfo>();

            foreach (XTreeNode treeNode in this.tvUsers.Nodes)
            {
                if (treeNode.Checked)
                {
                    XUsersInfo userInfo = treeNode.Model as XUsersInfo;
                    if (userInfo != null)
                    {
                        userInfos.Add(userInfo);
                    }
                }
            }

            return userInfos;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Edit();
        }

        private void Edit()
        {
            if (this.grdData.CurrentRow != null || this.grdData.CurrentRow.RowType == 
                Janus.Windows.GridEX.RowType.Record)
            {
                XRemindConfigInfo remindConfigInfo = this.grdData.CurrentRow.DataRow as XRemindConfigInfo;

                frmRemindConfigEdit frm = new frmRemindConfigEdit(remindConfigInfo);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.grdData.Refresh();
                }
            }
        }

        private void grdData_DoubleClick(object sender, EventArgs e)
        {
            this.Edit();
        }
    }
}
