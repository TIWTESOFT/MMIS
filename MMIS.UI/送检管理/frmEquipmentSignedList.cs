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
    public partial class frmEquipmentSignedList : frmEquipmentReceiveList
    {
        public frmEquipmentSignedList()
        {
            InitializeComponent();
        }

        protected override string GetQueryConditon()
        {
            string where = base.GetQueryConditon();

            where += " AND SignUserId=(SELECT MAX(RID) FROM StaffInfo WHERE UserId='" +
                XCommon.LoginUsersInfo.RID + "')";

            return where;
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            this.dtCheckedStart.Value = this.dtCheckedEnd.Value.AddMonths(-1);
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
                return "签发";
            }
        }

        protected override string CurrentQueryStatus
        {
            get
            {
                return "核验";
            }
        }

        protected override bool ValidateEditCustom()
        {
            XEquipmentReceiveBusiness business = this.m_Business as XEquipmentReceiveBusiness;

            string status = business.GetStatus(this.m_CurrentModel.ID);
            if (status != "核验" && status != "签发")
            {
                XMessageBox.ShowError("当前状态为：[" + status + "]，不能签发！");
                return false;
            }

            return true;
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmEquipmentSignedEdit(m_CurrentModel);
        }

        protected override bool IsAllowDownLoad
        {
            get
            {
                return false;
            }
        }

        protected override void Print()
        {
            if (this.grdData.CurrentRow != null &&
               this.grdData.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
            {
                XVEquipmentReceiveInfo receiveInfo = this.grdData.CurrentRow.DataRow as XVEquipmentReceiveInfo;

                if (!this.m_FileAttachBusiness.IsFileExist(receiveInfo.RID))
                {
                    XMessageBox.ShowError("未找到要打印的报告文档，请确认是否已上传报告！");
                    return;
                }

                frmPrintPreview frm = new frmPrintPreview(receiveInfo, false);
                frm.ShowDialog();
            }
        }
    }
}
