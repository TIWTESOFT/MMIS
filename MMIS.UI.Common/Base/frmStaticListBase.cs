using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.Helper;
using MMIS.BLL;

namespace MMIS.UI.Common
{
    public partial class frmStaticListBase : frmBase
    {
        protected XBusinessBase m_Business;

        public frmStaticListBase()
        {
            InitializeComponent();
            this.m_Business = this.InitBusiness();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            base.FormLoadFunction(sender, e);
            this.grpQuery.Width = this.Width - 27;
            this.InitLoadData();
        }

        protected virtual void InitLoadData()
        {
            this.Query();
            //this.grdData.DataSource = this.GetInitTable();
            //this.grdData.RetrieveStructure();
            //this.grdData.AutoSizeColumns();
        }

        protected virtual DataTable GetInitTable()
        {
            string where = " and 1<>1 ";
            return this.m_Business.GetViewByWhere(where);
        }

        /// <summary>
        /// 初始化业务对象
        /// </summary>
        /// <returns></returns>
        protected virtual XBusinessBase InitBusiness()
        {
            return new XBusinessBase();
        }

        private void grdData_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.cmRight.Show(this.grdData);
            }
        }

        void cmdExit_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Close();
        }

        void cmdRefresh_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Query();
        }

        void cmdExport_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Export();
        }

        void cmdPrint_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.PrintList();
        }

        private string m_WhereCondition = string.Empty;

        protected virtual void Query()
        {
            if (this.ValidateQuery())
            {
                this.m_WhereCondition = string.Empty;
                this.m_WhereCondition += this.GetQueryConditon();
                this.m_WhereCondition += this.GetOtherCondition();
                this.QueryOperation();
            }
        }

        protected virtual bool ValidateQuery()
        {
            return this.ValidateQueryCommon() && this.ValidateQueryCustom();
        }

        protected virtual bool ValidateQueryCommon()
        {
            return true;
        }

        protected virtual bool ValidateQueryCustom()
        {
            return true;
        }

        /// <summary>
        /// 获取其他的查询条件
        /// </summary>
        /// <returns></returns>
        protected virtual string GetOtherCondition()
        {
            return string.Empty;
        }

        /// <summary>
        /// 查询操作
        /// </summary>
        protected virtual void QueryOperation()
        {
            if (this.m_Business != null)
            {
                this.grdData.DataSource = this.GetQueryTable(this.m_WhereCondition);
                if (IsRetrieveStructure)
                {
                    this.grdData.RetrieveStructure();
                }
                this.grdData.AutoSizeColumns();

                this.grdData.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
                this.grdData.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            }
        }

        protected virtual bool IsRetrieveStructure
        {
            get { return true; }
        }

        /// <summary>
        /// 获取查询结果
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected virtual DataTable GetQueryTable(string where)
        {
            return this.m_Business.GetViewByWhere(where);
        }


        /// <summary>
        /// 获取查询条件
        /// </summary>
        /// <returns></returns>
        protected virtual string GetQueryConditon()
        {
            return XQueryTool.GetQueryCondition(this.grpQuery);
        }

        /// <summary>
        /// 导出
        /// </summary>
        protected virtual void Export()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel文件(*.xls)|*.xls";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.grdExporter.SheetName = this.Text;
                    //this.grdData.RootTable.Columns["select"].Visible = false;
                    System.IO.Stream stream = new System.IO.FileStream(sfd.FileName, System.IO.FileMode.CreateNew);
                    this.grdExporter.Export(stream);
                    stream.Close();
                    //this.grdData.RootTable.Columns["select"].Visible = true;
                    XMessageBox.ShowRemindMessage("导出完成!");
                }
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
                XMessageBox.ShowError("导出失败!");
            }
            finally
            {
                //this.grdData.RootTable.Columns["select"].Visible = true;
            }
        }

        /// <summary>
        /// 列表打印
        /// </summary>
        protected virtual void PrintList()
        {
            this.grdPrinter.DocumentName = this.Text;
            this.grdPrinter.PageHeaderCenter = this.Text;
            //this.grdData.RootTable.Columns["select"].Visible = false;
            if (this.IsPrintPreview())
            {
                PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                previewDialog.Document = this.grdPrinter;
                previewDialog.Width = this.Width;
                previewDialog.Height = this.Height;
                previewDialog.ShowDialog();
            }
            else
            {
                this.grdPrinter.Print();
            }
            //this.grdData.RootTable.Columns["select"].Visible = true;
        }

        protected virtual bool IsPrintPreview()
        {
            return true;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.Query();
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
                    //this.grdData.RootTable.Columns["select"].Visible = false;
                    System.IO.Stream stream = new System.IO.FileStream(sfd.FileName, System.IO.FileMode.CreateNew);
                    this.grdExporter.Export(stream);
                    stream.Close();
                    //this.grdData.RootTable.Columns["select"].Visible = true;
                    XMessageBox.ShowRemindMessage("导出完成!");
                }
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
                XMessageBox.ShowError("导出失败!");
            }
            finally
            {
                //this.grdData.RootTable.Columns["select"].Visible = true;
            }
        }
    }
}
