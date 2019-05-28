using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.UI.Common
{
    public partial class frmFileInfoList : frmListBase
    {
        private string m_MainId = string.Empty;
        private XBusinessBase m_Business = null;

        public frmFileInfoList(XBusinessBase business, string mainId)
        {
            InitializeComponent();
            this.m_Business = business;
            this.m_MainId = mainId;
        }

        protected override bool IsAllowOperateData
        {
            get
            {
                return false;
            }
        }

        protected override IList<Model.XModelBase> GetFormLoadList()
        {
            return this.m_Business.GetFileInfoes(this.m_MainId, "");
        }

        protected override IList<Model.XModelBase> GetQueryList(string where)
        {
            return this.m_Business.GetFileInfoes(this.m_MainId, where);
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        protected override bool DeleteOperate()
        {
            return this.m_Business.DeleteFiles(this.m_SelectedModels, this.UserId);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (this.grdData.CurrentRow != null && this.grdData.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
            {
                XModelBase model = this.grdData.CurrentRow.DataRow as XModelBase;
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileId = model.ID;
                    if (this.m_Business.Download(fileId, fbd.SelectedPath))
                    {
                        XMessageBox.ShowRemindMessage("下载完成！");
                    }
                    else
                    {
                        XMessageBox.ShowError("下载失败！");
                    }
                }
            }
            else
            {
                XMessageBox.ShowError("请选择要下载的文件！");
            }
        }
    }
}
