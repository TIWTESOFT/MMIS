using MMIS.Helper;
using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;

namespace MMIS.UI.Common
{
    public partial class frmImportListBase : frmBase
    {
        protected XBusinessBase m_Business;

        public frmImportListBase()
        {
            InitializeComponent();
            this.m_Business = this.InitBusiness();
        }

        protected virtual XBusinessBase InitBusiness()
        {
            return new XBusinessBase();
        }

        private void ebFileName_ButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel文件|*.xls;*.xlsx";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtFileName.Text = ofd.FileName;
                this.grdData.DataSource = XImportExcelTool.GetDataFormExcel(this.txtFileName.Text.Trim());
                this.grdData.RetrieveStructure();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            this.Import();
        }

        protected string m_TimePk = string.Empty;

        protected virtual void Import()
        {
            if (!this.ValidateImport())
            {
                return;
            }

            DataTable excelTable = this.grdData.DataSource as DataTable;

            int rowCount = excelTable.Rows.Count;

            m_TimePk = DateTime.Now.ToString("yyyyMMddHHmmss");

            XImportResultInfo resultInfo = this.ImportOperate(excelTable);
            resultInfo.Count = rowCount;
            if (resultInfo.FailureCount > 0)
            {
                int failueCount = resultInfo.FailureCount;
                int successCount = resultInfo.SuccessCount;

                int notExecCount = resultInfo.Count - successCount - failueCount;

                XMessageBox.ShowRemindMessage("成功导入" + successCount + "条，失败" + failueCount + "条，未执行" + notExecCount + "条！");
                frmOperateResult frm = new frmOperateResult(resultInfo.Results);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowRemindMessage("成功导入" + rowCount + "条！");
            }
        }

        protected int m_LoopNo = 0;

        protected virtual XImportResultInfo ImportOperate(DataTable excelTable)
        {
            XImportResultInfo resultInfo = new XImportResultInfo();
            IList<XOperateSingleResultInfo> resultInfos = new List<XOperateSingleResultInfo>();
            resultInfo.Results = resultInfos;

            this.proImport.Maximum = excelTable.Rows.Count;
            this.proImport.Value = 0;

            m_LoopNo = 0;

            foreach (DataRow excelRow in excelTable.Rows)
            {
                m_LoopNo += 1;

                XOperateSingleResultInfo singleResult = this.ImportSingleRow(excelRow);

                if (singleResult.IsSuccess == false)
                {
                    resultInfo.FailureCount += 1;
                    resultInfos.Add(singleResult);
                    string errorMsg = "关键字：[{0}]导入失败，失败原因：\r\n{1},\r\n是否继续？";
                    errorMsg = string.Format(errorMsg, singleResult.Key, singleResult.ErrorInfo);
                    if (XMessageBox.ShowQuestion(errorMsg) == System.Windows.Forms.DialogResult.No)
                    {
                        this.proImport.Value = this.proImport.Maximum;
                        break;
                    }
                }
                else
                {
                    resultInfo.SuccessCount += 1;
                }
                this.proImport.Value += 1;
                Application.DoEvents();
            }

            return resultInfo;
        }

        protected virtual XOperateSingleResultInfo ImportSingleRow(DataRow excelRow)
        {
            XOperateSingleResultInfo singleResult = new XOperateSingleResultInfo();
            XModelBase model = null;

            try
            {
                singleResult.Key = this.GetRowKey(excelRow);

                string validateResult = this.ValidateSingleRow(excelRow);

                if (validateResult != string.Empty)
                {
                    //如果校验未通过
                    singleResult.IsSuccess = false;
                    singleResult.ErrorInfo = validateResult;
                }
                else
                {
                    model = this.DataRow2Model(excelRow);
                    if (model == null)
                    {
                        singleResult.IsSuccess = false;
                        singleResult.ErrorInfo = "导入数据的模板可能不正确！";
                    }
                    else
                    {
                        //singleResult.IsSuccess = this.m_Business.Insert(model);
                        singleResult.IsSuccess = this.ImportSingleOperate(model);
                    }
                }
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
                singleResult.ErrorInfo = "发生异常，导入模板或数据列格式可能不正确，具体错误信息为" + ex.Message;
                //if (XMessageBox.ShowQuestion("发生异常，导入模板或数据列格式可能不正确，具体错误信息为：\r\n" +
                //    ex.Message + ",\r\n是否继续？") == System.Windows.Forms.DialogResult.No)
                //{
                //    break;
                //}
            }

            return singleResult;
        }

        protected virtual bool ImportSingleOperate(XModelBase model)
        {
            return this.m_Business.Insert(model);
        }

        protected virtual XModelBase DataRow2Model(DataRow excelRow)
        {
            return null;
        }

        /// <summary>
        /// 获得导入行的关键字
        /// </summary>
        /// <param name="excelRow"></param>
        /// <returns></returns>
        protected virtual string GetRowKey(DataRow excelRow)
        {
            return string.Empty;
        }

        /// <summary>
        /// 校验导入的单条记录
        /// </summary>
        /// <param name="excelRow"></param>
        /// <returns></returns>
        protected virtual string ValidateSingleRow(DataRow excelRow)
        {
            return string.Empty;
        }

        protected virtual bool ValidateImport()
        {
            return this.ValidateImportCommon() && this.ValidateImportCustom();
        }

        protected virtual bool ValidateImportCommon()
        {
            if (this.grdData.RowCount == 0)
            {
                XMessageBox.ShowError("没有要导入的记录！");
                return false;
            }

            return true;
        }

        protected virtual bool ValidateImportCustom()
        {
            return true;
        }

        private void txtFileName_DoubleClick(object sender, EventArgs e)
        {
            ebFileName_ButtonClick(null, null);
        }
    }
}
