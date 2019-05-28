using MMIS.BLL;
using MMIS.Helper;
using MMIS.Model;
using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMIS.UI
{
    public partial class frmUsersDeptList : frmBase
    {
        private XUsersBusiness m_UserBusiness = new XUsersBusiness();
        private XUseUserDeptBusiness m_UserDeptBusiness = new XUseUserDeptBusiness();
        private XUseDeptBusiness m_DeptBusiness = new XUseDeptBusiness();

        public frmUsersDeptList()
        {
            InitializeComponent();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            base.FormLoadFunction(sender, e);
            this.InitUserGrid();
            this.InitDeptTree();

            IList<XModelBase> modelInfos = this.grdData.DataSource as IList<XModelBase>;
            if (modelInfos.Count > 0)
            {
                this.FillUserDepts(modelInfos[0] as XUsersInfo);
            }
        }

        private void InitUserGrid()
        {
            this.grdData.DataSource = this.m_UserBusiness.GetAllView();
            this.grdData.AutoSizeColumns();
        }

        private void InitDeptTree()
        {
            this.tvDepts.Nodes.Clear();

            IList<XModelBase> deptInfos = this.m_DeptBusiness.GetAll();

            foreach (XModelBase modelInfo in deptInfos)
            {
                XUseDeptInfo deptInfo = modelInfo as XUseDeptInfo;

                XTreeNode treeNode = new XTreeNode();

                treeNode.Code = deptInfo.ID;
                treeNode.Name = deptInfo.DeptName;
                treeNode.Model = deptInfo;
                //treeNode.Text = "(" + roleInfo.ID + ")" + roleInfo.RoleName;
                treeNode.Text = deptInfo.DeptName;

                this.tvDepts.Nodes.Add(treeNode);
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (XTreeNode treeNode in this.tvDepts.Nodes)
            {
                treeNode.Checked = true;
            }
        }

        private void btnDeSelect_Click(object sender, EventArgs e)
        {
            foreach (XTreeNode treeNode in this.tvDepts.Nodes)
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
                this.FillUserDepts(userInfo);
            }
        }

        private void FillUserDepts(XUsersInfo userInfo)
        {
            if (userInfo != null)
            {
                IList<XModelBase> userRoleInfos = this.m_UserDeptBusiness.GetUserDepts(userInfo.RID);

                foreach (XTreeNode treeNode in this.tvDepts.Nodes)
                {
                    string roleCode = treeNode.Code;
                    if (IsDeptInUserDepts(roleCode, userRoleInfos))
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

        private bool IsDeptInUserDepts(string deptId, IList<XModelBase> userDeptInfos)
        {
            foreach (XModelBase model in userDeptInfos)
            {
                XUseUserDeptInfo userDeptInfo = model as XUseUserDeptInfo;
                if (userDeptInfo.DeptID == deptId)
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

            IList<XUseDeptInfo> selectedDepts = this.GetSelectedDepts();
            if (this.m_UserDeptBusiness.SaveUserDepts(usersInfo.RID, selectedDepts, XCommon.LoginUsersInfo.RID))
            {
                XMessageBox.ShowRemindMessage("保存成功！");
            }
            else
            {
                XMessageBox.ShowError("保存失败！");
            }
        }

        /// <summary>
        /// 获取选中的部门
        /// </summary>
        /// <returns></returns>
        private IList<XUseDeptInfo> GetSelectedDepts()
        {
            IList<XUseDeptInfo> deptInfos = new List<XUseDeptInfo>();

            foreach (XTreeNode treeNode in this.tvDepts.Nodes)
            {
                if (treeNode.Checked)
                {
                    XUseDeptInfo deptInfo = treeNode.Model as XUseDeptInfo;
                    if (deptInfo != null)
                    {
                        deptInfos.Add(deptInfo);
                    }
                }
            }

            return deptInfos;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string whereCondition = XQueryTool.GetQueryCondition(this.pnlTop);

            IList<XModelBase> userModelInfos = this.m_UserBusiness.QueryByWhere(whereCondition);

            this.grdData.DataSource = userModelInfos;

            if (userModelInfos.Count > 0)
            {
                this.FillUserDepts(userModelInfos[0] as XUsersInfo);
            }
        }

    }
}
