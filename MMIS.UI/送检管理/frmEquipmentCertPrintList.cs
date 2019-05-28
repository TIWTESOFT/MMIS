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
using MMIS.Model;
using System.Diagnostics;

namespace MMIS.UI
{
    public partial class frmEquipmentCertPrintList : frmEquipmentReceiveList
    {
        private XFileAttachmentBusiness m_FileAttachBusiness = new XFileAttachmentBusiness();
        private XEquipmentPDFReportBusiness m_PdfAttachBusiness = new XEquipmentPDFReportBusiness();

        public frmEquipmentCertPrintList()
        {
            InitializeComponent();
            //Word版本
            this.cmdWord.Click += cmdWord_Click;
            this.cmdPdf.Click += cmdPdf_Click;
        }

        void cmdPdf_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (this.grdData.CurrentRow != null &&
                this.grdData.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
            {
                XVEquipmentReceiveInfo receiveInfo = this.grdData.CurrentRow.DataRow as XVEquipmentReceiveInfo;

                if (!this.m_PdfAttachBusiness.IsFileExist(receiveInfo.RID))
                {
                    XMessageBox.ShowError("未找到要打印的PDF文档，请确认是否已上传PDF报告！");
                    return;
                }

                string path = XCommon.TempPath;
                string tempFileName = Guid.NewGuid().ToString();

                tempFileName = this.m_PdfAttachBusiness.DownLoadFile(receiveInfo.ID,
                    path, tempFileName);

                if (tempFileName != string.Empty)
                {
                    try
                    {
                        Process.Start(tempFileName);
                    }
                    catch (Exception ex)
                    {
                        XMessageBox.ShowError(ex.Message);
                        XErrorLogTool.WriteLog(ex.ToString());
                    }
                }
                else
                {
                    XMessageBox.ShowError("未找到要打印的PDF报告文档！");
                    this.Close();
                }
            }
        }

        void cmdWord_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Print();
        }

        protected override string GetQueryConditon()
        {
            string where = base.GetQueryConditon();

            where += " AND DispatchUserId=(SELECT MAX(RID) FROM StaffInfo WHERE UserId='" +
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
                return "制证";
            }
        }

        protected override string CurrentQueryStatus
        {
            get
            {
                return "签发";
            }
        }

        protected override bool ValidateEditCustom()
        {
            XEquipmentReceiveBusiness business = this.m_Business as XEquipmentReceiveBusiness;

            string status = business.GetStatus(this.m_CurrentModel.ID);
            if (status != "制证" && status != "签发")
            {
                XMessageBox.ShowError("当前状态为：[" + status + "]，不能制证打印！");
                return false;
            }

            return true;
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmEquipmentCertPrintEdit(m_CurrentModel);
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

                frmPrintPreview frm = new frmPrintPreview(receiveInfo, true);
                frm.ShowDialog();
            }
        }

        protected override bool IsAllowDownLoad
        {
            get
            {
                return false;
            }
        }

    }
}
