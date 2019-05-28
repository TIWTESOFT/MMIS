using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.UI.Common;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.UI
{
    public partial class frmUsersList : frmListBase
    {
        public frmUsersList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XUsersBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmUsersEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmUsersEdit(this.m_CurrentModel);
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (this.grdData.GetCheckedRows().Length == 0)
            {
                XMessageBox.ShowError("请选择要重置密码的记录！");
                return;
            }

            string selectedUserId = string.Empty;

            foreach (Janus.Windows.GridEX.GridEXRow gridRow in this.grdData.GetCheckedRows())
            {
                XUsersInfo usersInfo = gridRow.DataRow as XUsersInfo;
                selectedUserId += "'" + usersInfo.RID + "',";
            }

            selectedUserId = selectedUserId.TrimEnd(',');

            frmResetPassword frm = new frmResetPassword(selectedUserId);
            frm.ShowDialog();
        }

        protected override bool IsQueryDataFromView
        {
            get
            {
                return true;
            }
        }
    }
}