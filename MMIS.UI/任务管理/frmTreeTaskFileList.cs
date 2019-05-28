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
using MMIS.BLL;
using MMIS.UI.Common;

namespace MMIS.UI
{
    public partial class frmTreeTaskFileList : frmTreeTaskList
    {
        private XTaskFilesBusiness m_TaskFilesBusiness = new XTaskFilesBusiness();

        public frmTreeTaskFileList()
        {
            InitializeComponent();
            this.InitFilesCommands();
        }

        private void InitFilesCommands()
        {
            this.cmdNewFiles.Click += cmdNewFiles_Click;
            this.cmdEditFile.Click += cmdEditFile_Click;
            this.cmdDeleteFile.Click += cmdDeleteFile_Click;
        }

        void cmdDeleteFile_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.DeleteFiles();
        }

        private void DeleteFiles()
        {
            if (this.grdFiles.GetCheckedRows().Length == 0)
            {
                XMessageBox.ShowError("请选择要删除的记录！");
                return;
            }

            IList<XModelBase> deletedModels = new List<XModelBase>();

            foreach (Janus.Windows.GridEX.GridEXRow gridExRow in this.grdFiles.GetCheckedRows())
            {
                XModelBase model = gridExRow.DataRow as XModelBase;

                XTaskFilesInfo taskFilesInfo = model as XTaskFilesInfo;
                if (taskFilesInfo.InputUserId != XCommon.LoginUsersInfo.RID)
                {
                    XMessageBox.ShowError("不能删除非本人提交的任务文档！");
                    return;
                }

                deletedModels.Add(model);
            }

            if (this.m_TaskFilesBusiness.Delete(deletedModels, XCommon.LoginUsersInfo.RID))
            {
                XMessageBox.ShowRemindMessage("删除成功！");

                IList<XModelBase> modelLists = this.grdFiles.DataSource as IList<XModelBase>;

                foreach (XModelBase model in deletedModels)
                {
                    Janus.Windows.GridEX.GridEXRow row = this.grdFiles.GetRow(model);
                    row.Delete();
                    modelLists.Remove(model);
                }
            }
            else
            {
                XMessageBox.ShowError("删除失败！");
            }
        }

        void cmdEditFile_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.EditFiles();
        }

        private void EditFiles()
        {
            if (this.grdFiles.CurrentRow == null ||
                this.grdFiles.CurrentRow.RowType != Janus.Windows.GridEX.RowType.Record)
            {
                XMessageBox.ShowError("请选择要编辑的记录！");
                return;
            }

            XModelBase currentModel = this.grdFiles.CurrentRow.DataRow as XModelBase;

            XTaskFilesInfo taskFileInfo = currentModel as XTaskFilesInfo;
            if (taskFileInfo.InputUserId != XCommon.LoginUsersInfo.RID)
            {
                XMessageBox.ShowError("不能修改非本人提交的任务文档！");
                return;
            }

            frmTaskFilesEdit frm = new frmTaskFilesEdit(currentModel);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.grdFiles.Refresh();
            }
        }

        void cmdNewFiles_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.AddFiles();
        }

        private void AddFiles()
        {
            TreeNode selectedNode = this.tvTask.SelectedNode;

            if (!this.IsChildTaskNode(selectedNode))
            {
                XMessageBox.ShowError("请选择要提交文档的子任务！");
                return;
            }

            IList<XModelBase> gridList = this.grdFiles.DataSource as IList<XModelBase>;

            XTaskInfo taskInfo = selectedNode.Tag as XTaskInfo;
            if (taskInfo.AssignPeople != XCommon.LoginUsersInfo.RID)
            {
                XMessageBox.ShowError("当前登录人不是任务负责人，不能提交文档！");
                return;
            }

            frmTaskFilesEdit frm = new frmTaskFilesEdit(gridList, selectedNode);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.grdFiles.DataSource = null;
                this.grdFiles.DataSource = frm.ModelList;
                this.grdFiles.Refresh();
            }
        }

        protected override void grdFiles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.cmTaskFiles.Show(this.grdFiles);
            }
        }

        protected override bool IsAllowOperateTask
        {
            get
            {
                return false;
            }
        }

        protected override bool IsFormLoadExpandNodes
        {
            get
            {
                return true;
            }
        }

        protected override string GetWhereCondition()
        {
            string where = base.GetWhereCondition();

            //获取分配给当前用户的任务
            where += " AND RID IN (SELECT RID FROM Task WHERE ParentId IS NOT NULL " +
                " AND ParentId<>'' AND AssignPeople='" + XCommon.LoginUsersInfo.RID + "') ";

            return where;
        }

        protected override string GetFirstLoadChildWhere()
        {
            string where = base.GetFirstLoadChildWhere();
            where += " AND AssignPeople='" + XCommon.LoginUsersInfo.RID + "'";
            return where;
        }

        protected override string GetChildWhere()
        {
            return GetFirstLoadChildWhere();
        }

        protected override string GetIsEndModelWhere()
        {
            string where = base.GetIsEndModelWhere();
            where += " AND AssignPeople='" + XCommon.LoginUsersInfo.RID + "'";
            return where;
        }

        protected override bool IsAutoRefresh
        {
            get
            {
                return true;
            }
        }

        protected override IList<XModelBase> GetRootViewModelList(string where)
        {
            return this.m_TaskBusiness.GetTaskFileRootViewModelList(where);
        }
    }
}
