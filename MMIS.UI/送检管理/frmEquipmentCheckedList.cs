using MMIS.BLL;
using MMIS.Helper;
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
    public partial class frmEquipmentCheckedList : frmEquipmentReceiveList
    {
        public frmEquipmentCheckedList()
        {
            InitializeComponent();
        }

        protected override string GetQueryConditon()
        {
            string where = base.GetQueryConditon();

            where += " AND CheckUserId=(SELECT MAX(RID) FROM StaffInfo WHERE UserId='" +
                XCommon.LoginUsersInfo.RID + "')";

            return where;
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            this.dtCheckedBegin.Value = this.dtCheckedEnd.Value.AddMonths(-1);
            base.FormLoadFunction(sender, e);
            this.cmDelete.Visible = Janus.Windows.UI.InheritableBoolean.False;
        }

        protected override bool IsAllowAddNew
        {
            get
            {
                return false;
            }
        }

        protected override bool IsAllowEdit
        {
            get
            {
                return false;
            }
        }

        protected override bool IsAllowDelete
        {
            get
            {
                return false;
            }
        }

        protected override bool IsAllowDoubleEdit
        {
            get
            {
                return true;
            }
        }

        protected override string CurrentFormStatus
        {
            get
            {
                return "检定";
            }
        }

        protected override string CurrentQueryStatus
        {
            get
            {
                return "接收";
            }
        }

        protected override bool ValidateEditCustom()
        {
            XEquipmentReceiveBusiness business = this.m_Business as XEquipmentReceiveBusiness;

            string status = business.GetStatus(this.m_CurrentModel.ID);
            if (status != "接收" && status != "检定")
            {
                XMessageBox.ShowError("当前状态为：[" + status + "]，不能检定！");
                return false;
            }

            return true;
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmEquipmentCheckedEdit(m_CurrentModel);
        }

        protected override bool IsAllowDownLoad
        {
            get
            {
                return false;
            }
        }

        protected override void DownloadAfter(string fileName, Model.XModelBase model)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                XEquipmentReceiveWordTool.FillWordValue(fileName, model as Model.XVEquipmentReceiveInfo);

            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.Message);
                XErrorLogTool.WriteLog(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
