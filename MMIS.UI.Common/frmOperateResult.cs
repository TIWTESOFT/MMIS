using MMIS.Helper;
using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace MMIS.UI.Common
{
    public partial class frmOperateResult : frmBase
    {
        private IList<XOperateSingleResultInfo> m_ResultInfos = null;

        public frmOperateResult(IList<XOperateSingleResultInfo> results)
        {
            InitializeComponent();
            this.m_ResultInfos = results;
            this.InitGrid();
        }

        private void InitGrid()
        {
            int keyCount = 0;


            int loopNo = 0;

            foreach (XOperateSingleResultInfo result in m_ResultInfos)
            {
                loopNo += 1;

                string[] values = result.Key.Split('-');

                if (loopNo == 1)
                {
                    keyCount = values.Length;

                    foreach (GridEXColumn column in this.grdData.RootTable.Columns)
                    {
                        if (column.DataMember.Contains("Key"))
                        {
                            string strIndex = column.DataMember.Replace("Key", "");
                            int index = XHelper.GetInt(strIndex);
                            if (index > keyCount)
                            {
                                column.Visible = false;
                            }
                        }
                    }
                }

                if (values.Length >= 1)
                {
                    result.Key1 = values[0];
                }
                if (values.Length >= 2)
                {
                    result.Key2 = values[1];
                }
                if (values.Length >= 3)
                {
                    result.Key3 = values[2];
                }
                if (values.Length >= 4)
                {
                    result.Key4 = values[3];
                }
                if (values.Length >= 5)
                {
                    result.Key5 = values[4];
                }
            }

            this.grdData.DataSource = m_ResultInfos;
            this.grdData.AutoSizeColumns();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            this.grdData.AutoSizeColumns();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel文件(*.xls)|*.xls";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.grdExporter.SheetName = this.Text;
                    System.IO.Stream stream = new System.IO.FileStream(sfd.FileName, System.IO.FileMode.CreateNew);
                    this.grdExporter.Export(stream);
                    stream.Close();
                    XMessageBox.ShowRemindMessage("导出完成!");
                }
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
                XMessageBox.ShowError("导出失败!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
