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

namespace MMIS.UI
{
    public partial class frmRemindList : frmBase
    {
        private XEquipmentReceiveBusiness m_EquipmentReceiveBusiness = new XEquipmentReceiveBusiness();
        private XVoucherRemindBusiness m_VoucherRemindBusiness = new XVoucherRemindBusiness();
        private XTaskBusiness m_TaskBusiness = new XTaskBusiness();

        private DataTable m_VoucherRemindTable = null;
        private DataTable m_TaskTodoTable = null;

        public frmRemindList(DataTable voucherRemindTable, DataTable taskToDoTable)
        {
            InitializeComponent();
            this.m_VoucherRemindTable = voucherRemindTable;
            this.m_TaskTodoTable = taskToDoTable;
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            base.FormLoadFunction(sender, e);
            //this.FillEquipmentRemind();
            this.FillVoucherRemind();
            this.FillTaskToDo();
        }

        private void FillEquipmentRemind()
        {
            this.grdTaskToDo.DataSource = this.m_EquipmentReceiveBusiness.
                GetRemind(XCommon.LoginUsersInfo.RID);
            this.grdTaskToDo.AutoSizeColumns();
        }

        private void FillTaskToDo()
        {
            if (this.m_TaskTodoTable.Rows.Count == 0)
            {
                this.pnlTop.Visible = false;
                return;
            }
            this.grdTaskToDo.DataSource = this.m_TaskTodoTable;
            this.grdTaskToDo.AutoSizeColumns();
        }

        private void FillVoucherRemind()
        {
            if (this.m_VoucherRemindTable.Rows.Count == 0)
            {
                this.pnlFill.Visible = false;
                this.pnlTop.Dock = DockStyle.Fill;
                return;
            }
            this.grdVoucher.DataSource = this.m_VoucherRemindTable;
            this.grdVoucher.AutoSizeColumns();
        }

        private void RefreshVoucherRemind()
        {
            this.grdVoucher.DataSource = this.m_VoucherRemindBusiness.GetVoucherRemind(XCommon.LoginUsersInfo.RID);
            this.grdVoucher.AutoSizeColumns();
        }

        private void btnRefreshVoucherRemind_Click(object sender, EventArgs e)
        {
            this.RefreshVoucherRemind();
        }

        private void btnRefreshTaskToDo_Click(object sender, EventArgs e)
        {
            this.RefreshTaskToDo();
        }

        private void RefreshTaskToDo()
        {
            this.grdTaskToDo.DataSource = this.m_TaskBusiness.GetTaskToDo(XCommon.LoginUsersInfo.RID);
            this.grdTaskToDo.AutoSizeColumns();
        }
    }
}
