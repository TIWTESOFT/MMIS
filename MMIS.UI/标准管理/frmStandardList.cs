using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.UI.Common;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.UI
{
    public partial class frmStandardList : frmTabListBase
    {
        protected XFileAttachmentBusiness m_FileAttachBusiness = new XFileAttachmentBusiness();

        public frmStandardList()
        {
            InitializeComponent();
            this.cmdDownloadFile.Click += cmdDownloadFile_Click;
            this.cmdPreviewFile.Click += cmdPreviewFile_Click;
        }

        void cmdPreviewFile_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (this.grdData.CurrentRow != null && this.grdData.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
            {
                XStandFilesInfo model = this.grdFiles.CurrentRow.DataRow as XStandFilesInfo;
                string mainId = model.RID;
                XFilePreviewTool.Preview(mainId);
            }
        }

        protected override XBusinessBase InitBusiness()
        {
            return new XStandardBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmStandardEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmStandardEdit(this.m_CurrentModel);
        }

        protected override bool IsQueryDataFromView
        {
            get
            {
                return true;
            }
        }

        protected override void InitDetailBusiness()
        {
            foreach (Janus.Windows.UI.Tab.UITabPage tabPage in this.tabDetail.TabPages)
            {
                XBusinessBase business = null;
                switch (tabPage.Name)
                {
                    case "pageFiles":
                        business = new XStandFilesBusiness();
                        break;
                    case "pageEquipments":
                        business = new XStandEquipmentBusiness();
                        break;
                }
                tabPage.Tag = business;
            }
        }

        protected override IList<Model.XModelBase> GetTabPageDetailList(XBusinessBase tabPageBusiness, string mainId)
        {
            return tabPageBusiness.GetViewByMainId(mainId, "");
        }

        private void grdFiles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.cmFiles.Show(this.grdFiles);
            }
        }

        /// <summary>
        /// 文件下载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cmdDownloadFile_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (this.grdData.CurrentRow != null && this.grdData.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
            {
                XStandFilesInfo model = this.grdFiles.CurrentRow.DataRow as XStandFilesInfo;

                string mainId = model.RID;

                bool isExist = this.m_FileAttachBusiness.IsFileExist(mainId);
                if (!isExist)
                {
                    XMessageBox.ShowError("未找到附件！");
                    return;
                }

                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileName = this.m_FileAttachBusiness.DownloadFile(mainId, fbd.SelectedPath);

                    if (fileName != string.Empty)
                    {
                        XMessageBox.ShowRemindMessage("下载完成！");
                        this.DownloadAfter(fileName, model);
                    }
                    else
                    {
                        XMessageBox.ShowError("下载失败！");
                    }
                }
            }
            else
            {
                XMessageBox.ShowError("请选择要下载附件的记录！");
            }
        }
    }
}