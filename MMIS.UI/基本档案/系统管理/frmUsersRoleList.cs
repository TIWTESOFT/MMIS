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

namespace MMIS.UI
{
    public partial class frmUsersRoleList : frmBase
    {
        private XUsersBusiness m_UserBusiness = new XUsersBusiness();
        private XUsersRoleBusiness m_UserRoleBusiness = new XUsersRoleBusiness();
        private XRoleBusiness m_RoleBusiness = new XRoleBusiness();

        public frmUsersRoleList()
        {
            InitializeComponent();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            base.FormLoadFunction(sender, e);
            this.InitUserGrid();
            this.InitRoleTree();

            IList<XModelBase> modelInfos = this.grdData.DataSource as IList<XModelBase>;
            if (modelInfos.Count > 0)
            {
                this.FillUserRoles(modelInfos[0] as XUsersInfo);
            }
        }

        private void InitUserGrid()
        {
            this.grdData.DataSource = this.m_UserBusiness.GetAllView();
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

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (XTreeNode treeNode in this.tvRole.Nodes)
            {
                treeNode.Checked = true;
            }
        }

        private void btnDeSelect_Click(object sender, EventArgs e)
        {
            foreach (XTreeNode treeNode in this.tvRole.Nodes)
            {
                treeNode.Checked = !treeNode.Checked;
            }
        }

        private void grdData_Click(object sender, EventArgs e)
        {
            if (this.grdData.CurrentRow != null &&
                this.grdData.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
            {
                XUsersInfo userInfo = this.grdData.CurrentRow.DataRow as XUsersInfo;
                this.FillUserRoles(userInfo);
            }
        }

        private void FillUserRoles(XUsersInfo userInfo)
        {
            if (userInfo != null)
            {
                IList<XModelBase> userRoleInfos = this.m_UserRoleBusiness.GetUserRoles(userInfo.RID);

                foreach (XTreeNode treeNode in this.tvRole.Nodes)
                {
                    string roleCode = treeNode.Code;
                    if (IsRoleInUserRoles(roleCode, userRoleInfos))
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

        private bool IsRoleInUserRoles(string roleId, IList<XModelBase> userRoleInfos)
        {
            foreach (XModelBase model in userRoleInfos)
            {
                XUsersRoleInfo userRoleInfo = model as XUsersRoleInfo;
                if (userRoleInfo.RoleID == roleId)
                {
                    return true;
                }
            }

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.grdData.CurrentRow == null || this.grdData.CurrentRow.RowType != Janus.Windows.GridEX.RowType.Record)
            {
                XMessageBox.ShowError("请选择用户！");
                return;
            }

            XUsersInfo usersInfo = this.grdData.CurrentRow.DataRow as XUsersInfo;


            IList<XRoleInfo> selectedRoles = this.GetSelectedRoles();
            if (this.m_UserRoleBusiness.SaveUserRoles(usersInfo.RID, selectedRoles, XCommon.LoginUsersInfo.RID))
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string whereCondition = XQueryTool.GetQueryCondition(this.pnlTop);

            IList<XModelBase> userModelInfos = this.m_UserBusiness.QueryByWhere(whereCondition);

            this.grdData.DataSource = userModelInfos;

            if (userModelInfos.Count > 0)
            {
                this.FillUserRoles(userModelInfos[0] as XUsersInfo);
            }
        }
    }
}
