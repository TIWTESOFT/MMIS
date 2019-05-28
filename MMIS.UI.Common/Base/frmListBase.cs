using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Configuration;
using MMIS.Helper;
using MMIS.Model;
using MMIS.BLL;
using MMIS.Component;

namespace MMIS.UI.Common
{
    /// <summary>
    /// frmListBase 窗口
    /// 名称: 
    /// 功能: 
    /// 时间: 2011/9/4 8:54:04
    /// 作者: Administrator
    /// </summary>
    public partial class frmListBase : frmBase
    {
        protected XBusinessBase m_Business = null;

        protected virtual bool IsAllowPreview
        {
            get { return false; }
        }

        protected XFileAttachmentBusiness m_FileAttachBusiness = null;// new XFileAttachmentBusiness();

        #region 构造和析构

        public frmListBase()
        {
            //
            // Windows 窗体设计器支持所必需的
            //
            InitializeComponent();
            this.m_Business = this.InitBusiness();
            this.InitFileAttachBusiness();
            this.cmdViewWorkFlow.Click += cmdViewWorkFlow_Click;
            if (!this.DesignMode)
            {
                //TODO:发布前取消注释
                //this.InitFileAttachBusiness();
            }
        }

        #endregion // 构造和析构

        #region 公有方法
        #endregion // 公有方法

        #region 保护方法

        protected virtual void InitFileAttachBusiness()
        {
            this.m_FileAttachBusiness = new XFileAttachmentBusiness();
        }

        /// <summary>
        /// 初始化业务对象
        /// </summary>
        /// <returns></returns>
        protected virtual XBusinessBase InitBusiness()
        {
            return new XBusinessBase();
        }

        /// <summary>
        /// 初始化表格
        /// </summary>
        /// <returns></returns>
        protected virtual IList<XModelBase> InitGridList()
        {
            if (this.m_Business != null)
            {
                return this.GetFormLoadList();
            }
            else
            {
                return new List<XModelBase>();
            }
        }

        /// <summary>
        /// 是否从视图加载数据
        /// </summary>
        protected virtual bool IsQueryDataFromView
        {
            get { return false; }
        }

        /// <summary>
        /// 获取窗体加载时的数据集合
        /// </summary>
        /// <returns></returns>
        protected virtual IList<XModelBase> GetFormLoadList()
        {
            string where = this.GetQueryConditon();
            if (IsCheckOrBackCheck)
            {
                return this.GetToCheckLoadList(where);
            }
            else
            {
                return this.GetLoadList(where);
            }
        }

        /// <summary>
        /// 获取要审核的记录
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected virtual IList<XModelBase> GetToCheckLoadList(string where)
        {
            return this.m_Business.GetToCheckTableList(where);
            //return this.m_Business.GetToCheckViewList(JobCode, where);
        }



        protected virtual IList<XModelBase> GetLoadList(string where)
        {
            if (this.IsQueryDataFromView)
            {
                //return this.m_Business.QueryViewByWhere(where);
                return this.m_Business.QueryTop100ViewByWhere(where);
            }
            else
            {
                return this.m_Business.QueryTop100ByWhere(where);
                //return this.m_Business.QueryByWhere(where);
            }
        }

        /// <summary>
        /// 设置网格样式
        /// </summary>
        private void SetGridFormat()
        {
            this.HideNotAuthonColumns(this.grdData);
            this.SetGridColumnsSize();
            this.SetColumnsReadOnly();
        }

        /// <summary>
        /// 设置列只读
        /// </summary>
        protected virtual void SetColumnsReadOnly()
        {

        }

        /// <summary>
        /// 隐藏未授权列
        /// </summary>
        protected virtual void HideNotAuthonColumns(Janus.Windows.GridEX.GridEX gridEx)
        {

        }

        /// <summary>
        /// 查询
        /// </summary>
        protected virtual void Query()
        {
            if (!this.ValidateQuery())
            {
                return;
            }
            this.m_WhereCondition = string.Empty;
            this.GetAuthonWhereCondition();
            this.m_WhereCondition += this.GetQueryConditon();
            this.m_WhereCondition += this.GetOtherCondition();
            this.QueryOperation();
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
                this.m_CurrentList = this.GetQueryList(this.m_WhereCondition);
                this.grdData.DataSource = null;
                this.grdData.DataSource = this.m_CurrentList;
                this.grdData.AutoSizeColumns();
            }
        }

        /// <summary>
        /// 获取查询结果
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected virtual IList<XModelBase> GetQueryList(string where)
        {
            if (IsCheckOrBackCheck)
            {
                if (this.chkChecked.Checked)
                {
                    //查询已审核
                    return this.m_Business.GetCheckedTableList(where);
                    //return this.m_Business.GetCheckedViewList(UserId, where);
                }
                else
                {
                    //查询应审核
                    return this.GetToCheckList(where);
                }
            }
            else
            {
                if (this.IsQueryDataFromView)
                {
                    return this.m_Business.QueryViewByWhere(where);
                }
                else
                {
                    return this.m_Business.QueryByWhere(where);
                }
            }
        }

        protected virtual IList<XModelBase> GetToCheckList(string where)
        {
            return this.m_Business.GetToCheckTableList(where);
            //return this.m_Business.GetToCheckViewList(JobCode, where);
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
                    this.grdData.RootTable.Columns["select"].Visible = false;
                    System.IO.Stream stream = new System.IO.FileStream(sfd.FileName, System.IO.FileMode.CreateNew);
                    this.grdExporter.Export(stream);
                    stream.Close();
                    this.grdData.RootTable.Columns["select"].Visible = true;
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
                this.grdData.RootTable.Columns["select"].Visible = true;
            }
        }

        /// <summary>
        /// 校验导出
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateExport()
        {
            if (this.grdData.RowCount == 0)
            {
                XMessageBox.ShowError("没有要导出的记录！");
                return false;
            }

            return true;
        }


        /// <summary>
        /// 导出报告
        /// </summary>
        protected virtual void ExportToExcel(object o)
        {
            //m_ExportedFileFullName = "";
            //if (ValidateExport())
            //{
            //    XExportDataHelper exportDataHelper = new XExportDataHelper();
            //    exportDataHelper.ExportDataGridViewData(this.grdData, this.GetExportDataStartRowNo(), this.m_ExportFileDirectory, "", this.m_ExportFileName);
            //    m_ExportedFileFullName = exportDataHelper.ExportFileName;
            //}
            //((Action)o).Invoke();
        }


        /// <summary>
        /// 获得导出路径
        /// </summary>
        protected virtual void GetExportDirectory()
        {
            this.m_ExportFileDirectory = string.Empty;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            else
            {
                this.m_ExportFileDirectory = fbd.SelectedPath;
            }
        }

        /// <summary>
        /// 获得导出的数据开始行数
        /// </summary>
        /// <returns></returns>
        protected virtual int GetExportDataStartRowNo()
        {
            //默认从第三行开始导出
            return 3;
        }

        /// <summary>
        /// 添加
        /// </summary>
        protected virtual void AddNew()
        {
            this.m_EditStauts = XEditStatus.AddNew;
            this.GetGridTable();
            if (ValiedateAddNew())
            {
                frmEditBase frm = this.GetAddForm();
                if (frm == null)
                {
                    return;
                }
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.grdData.DataSource = null;
                    this.grdData.DataSource = frm.ModelList;
                    this.grdData.Refresh();
                    this.AddAfter(frm);
                }
                //this.AddNewOperate();
            }
        }

        /// <summary>
        /// 添加成功后执行的操作
        /// </summary>
        protected virtual void AddAfter(frmEditBase frm)
        {

        }

        /// <summary>
        /// 获取增加窗体
        /// </summary>
        /// <returns></returns>
        protected virtual frmEditBase GetAddForm()
        {
            return new frmEditBase(this.m_CurrentList);
        }

        /// <summary>
        /// 获取编辑窗体
        /// </summary>
        /// <returns></returns>
        protected virtual frmEditBase GetEditForm()
        {
            return new frmEditBase(this.m_CurrentModel);
        }

        /// <summary>
        /// 获得网格的表格
        /// </summary>
        protected virtual void GetGridTable()
        {
            if (this.grdData.DataSource == null)
            {
                this.m_CurrentList = this.grdData.DataSource as IList<XModelBase>;
            }
        }

        ///// <summary>
        ///// 添加操作
        ///// </summary>
        //protected virtual void AddNewOperate()
        //{

        //}

        /// <summary>
        /// 校验添加
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValiedateAddNew()
        {
            return this.ValidateAddNewCommon() && this.ValidateAddNewCustom();
        }

        protected virtual bool ValidateAddNewCommon()
        {
            return true;
        }

        protected virtual bool ValidateAddNewCustom()
        {
            return true;
        }

        /// <summary>
        /// 修改
        /// </summary>
        protected virtual void Edit()
        {
            if (!this.IsAllowOperateData)
            {
                return;
            }
            this.m_EditStauts = XEditStatus.Edit;
            if (IsSelectedRow() && ValidateEdit())
            {
                frmEditBase frm = this.GetEditForm();
                if (frm == null)
                {
                    return;
                }
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.grdData.Refresh();
                    this.EditAfter(frm);
                }
                //this.EditOperate();
            }
        }

        protected virtual void EditAfter(frmEditBase frm)
        {
            this.AddAfter(frm);
        }

        /// <summary>
        /// 校验修改
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateEdit()
        {
            return this.ValidateEditCommon() && this.ValidateEditCustom();
        }

        /// <summary>
        /// 校验修改通用
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateEditCommon()
        {
            if (this.IsNeedSend && this.IsSendAllowEdit == false)
            {
                //如果有发布的话，则判断是否发布
                if (this.m_Business.IsSend(this.m_CurrentModel))
                {
                    XMessageBox.ShowError("选择的记录已发布，不能修改！");
                    return false;
                }
            }

            //if (this.IsNeedCommitOrRollBack)
            //{
            //    if (this.m_Business.IsCommit(this.m_CurrentModel))
            //    {
            //        XMessageBox.ShowError("选择的记录已提交，不能修改！");
            //        return false;
            //    }
            //}

            //if (this.IsCheckOrBackCheck && this.m_Business.IsCheck(this.m_CurrentModel))
            //{
            //    XMessageBox.ShowError("选择的记录已审核，不能修改！");
            //    return false;
            //}

            return true;
        }


        /// <summary>
        /// 发布后是否允许修改
        /// </summary>
        protected virtual bool IsSendAllowEdit
        {
            get { return false; }
        }

        /// <summary>
        /// 校验修改自定义
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateEditCustom()
        {
            return true;
        }

        ///// <summary>
        ///// 修改操作
        ///// </summary>
        //protected virtual void EditOperate()
        //{

        //}

        /// <summary>
        /// 复制
        /// </summary>
        protected virtual void Copy()
        {
            this.m_EditStauts = XEditStatus.Copy;
            this.GetGridTable();
            if (IsSelectedRow() && ValidateCopy())
            {
                this.CopyOperate();
            }
        }

        /// <summary>
        /// 校验复制
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateCopy()
        {
            return true;
        }

        /// <summary>
        /// 复制操作
        /// </summary>
        protected virtual void CopyOperate()
        {

        }

        /// <summary>
        /// 删除
        /// </summary>
        protected virtual void Delete()
        {
            this.m_EditStauts = XEditStatus.Delete;

            if (this.IsSelectedRowByCheckBox())
            {
                if (this.ConfimDelete() == false)
                {
                    return;
                }

                if (this.ValidateDelete() == false)
                {
                    return;
                }

                bool isDeleteSuccess = false;
                try
                {
                    isDeleteSuccess = this.DeleteOperate();
                    this.m_ErrorInfo = string.Empty;
                }
                catch (Exception ex)
                {
                    this.m_ErrorInfo = ex.ToString();
                    XErrorLogTool.WriteLog(ex.ToString());
                }
                if (isDeleteSuccess)
                {
                    //删除成功
                    this.DeleteRowsFromMemory();
                    if (this.m_IsShowDeleteSuccessMessage)
                    {
                        this.ShowDeleteMessage(true);
                    }
                }
                else
                {
                    //删除失败
                    this.ShowDeleteMessage(false);
                }
            }
        }

        protected virtual void DeleteRowsFromMemory()
        {
            IList<XModelBase> modelLists = this.grdData.DataSource as IList<XModelBase>;

            foreach (XModelBase model in this.m_SelectedModels)
            {
                Janus.Windows.GridEX.GridEXRow row = this.grdData.GetRow(model);
                row.Delete();
                modelLists.Remove(model);
            }
        }

        protected virtual bool ConfimDelete()
        {
            if (XMessageBox.ShowQuestion(this.GetConfirmDeleteMessage()) == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected virtual string GetConfirmDeleteMessage()
        {
            if (this.m_SelectedModel != null)
            {
                return "确定要删除选中的" + this.m_SelectedModels.Count + "条记录吗？";
            }
            else
            {
                return "确定要删除选中的记录吗？";
            }
        }

        protected virtual void ShowDeleteMessage(bool isSuccess)
        {
            string showMessage = "";
            if (isSuccess)
            {
                showMessage = "删除成功！";
            }
            else
            {
                showMessage = "删除失败";
            }
            if (this.m_ErrorInfo.Trim() != string.Empty && isSuccess == false)
            {
                showMessage += this.m_ErrorInfo;
            }
            if (this.m_AppendDeleteMessage.Trim() != string.Empty)
            {
                showMessage += this.m_AppendDeleteMessage;
            }
            XMessageBox.ShowRemindMessage(showMessage);
        }

        protected virtual void GetAppendDeleteMessage(bool isSuccess)
        {

        }

        /// <summary>
        /// 校验删除操作
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateDelete()
        {
            return this.ValidateDeleteCommon() && this.ValidateDeleteCustom();
        }

        protected virtual bool ValidateDeleteCommon()
        {
            //if (this.IsNeedSend)
            //{
            //    foreach (XModelBase model in this.m_SelectedModels)
            //    {
            //        string key = this.GetModelKey(model);
            //        if (this.m_Business.IsSend(model))
            //        {
            //            XMessageBox.ShowError("关键字为[" + key + "]的记录已发布，不能删除！");
            //            return false;
            //        }
            //    }
            //}

            //if (this.IsNeedCommitOrRollBack)
            //{
            //    foreach (XModelBase model in this.m_SelectedModels)
            //    {
            //        string key = this.GetModelKey(model);
            //        if (this.m_Business.IsCommit(model))
            //        {
            //            XMessageBox.ShowError("关键字为[" + key + "]的记录已提交，不能删除！");
            //            return false;
            //        }
            //    }
            //}

            foreach (XModelBase model in this.m_SelectedModels)
            {
                string key = this.GetModelKey(model);

                if (this.m_Business.IsUsed(model.ID))
                {
                    return false;
                }
            }

            if (this.IsCheckOrBackCheck)
            {
                foreach (XModelBase model in this.m_SelectedModels)
                {
                    string key = this.GetModelKey(model);

                    if (this.m_Business.IsCheck(model))
                    {
                        XMessageBox.ShowError("关键字为[" + key + "]的记录已审核，不能删除！");
                        return false;
                    }
                }
            }

            return true;
        }

        protected virtual bool ValidateDeleteCustom()
        {
            return true;
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        protected virtual bool DeleteOperate()
        {
            return this.m_Business.Delete(this.m_SelectedModels, this.UserId);
        }

        /// <summary>
        /// 刷新
        /// </summary>
        protected virtual void RefreshData()
        {
            //this.QueryOperation();
            this.Query();
        }

        /// <summary>
        /// 关闭
        /// </summary>
        protected virtual void CloseForm()
        {
            this.Close();
        }

        /// <summary>
        /// 校验是否选中记录
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsSelectedRow()
        {
            if (this.grdData.CurrentRow == null || this.grdData.CurrentRow.RowType != Janus.Windows.GridEX.RowType.Record)
            {
                string showMessage = this.GetShowNotSelectRowMessage();
                XMessageBox.ShowRemindMessage(showMessage);
                return false;
            }
            this.m_CurrentModel = this.grdData.CurrentRow.DataRow as XModelBase;

            return true;
        }

        /// <summary>
        /// 检查是否有复选框选中的记录
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsSelectedRowByCheckBox()
        {
            int selectedRowsCount = 0;

            m_SelectedDeleteIds = "";
            m_SelectedModels = new List<XModelBase>();



            foreach (Janus.Windows.GridEX.GridEXRow gridRow in this.grdData.GetRows())
            {
                if (gridRow.IsChecked)
                {
                    selectedRowsCount += 1;
                    XModelBase currentModel = gridRow.DataRow as XModelBase;
                    m_SelectedModels.Add(currentModel);
                    string id = currentModel.ID;
                    m_SelectedDeleteIds += "'" + id + "',";
                }
            }
            m_SelectedDeleteIds = m_SelectedDeleteIds.TrimEnd(',');
            if (selectedRowsCount > 0)
            {
                return true;
            }
            else
            {
                string showMessage = this.GetShowNotSelectRowMessage();
                XMessageBox.ShowRemindMessage(showMessage);
                return false;
            }
        }

        /// <summary>
        /// 获得没有选中记录时显示的信息
        /// </summary>
        /// <returns></returns>
        protected virtual string GetShowNotSelectRowMessage()
        {
            string showMessage = "";
            switch (this.m_EditStauts)
            {
                case XEditStatus.Edit:
                    showMessage = "请选择要编辑的记录！";
                    break;
                case XEditStatus.Delete:
                    showMessage = "请选择要删除的记录";
                    break;
                case XEditStatus.Copy:
                    showMessage = "请选择要复制的记录";
                    break;
                case XEditStatus.Commit:
                    showMessage = "请选择要提交的记录";
                    break;
                case XEditStatus.Rollback:
                    showMessage = "请选择要收回的记录";
                    break;
                case XEditStatus.Check:
                    showMessage = "请选择要审核的记录";
                    break;
                case XEditStatus.BackCheck:
                    showMessage = "请选择要弃审的记录";
                    break;
                case XEditStatus.Send:
                    showMessage = "请选择要发布的记录";
                    break;
                case XEditStatus.BackSend:
                    showMessage = "请选择要撤销的记录";
                    break;
                case XEditStatus.Feedback:
                    showMessage = "请选择要反馈的记录";
                    break;
                case XEditStatus.BackFeedback:
                    showMessage = "请选择要撤回的记录";
                    break;
                default:
                    showMessage = "请选择要操作的记录";
                    break;
            }
            return showMessage;
        }

        protected virtual void SetExportInfo()
        {
            this.SetExportTemplateName();
            this.SetExportFileName();
        }

        /// <summary>
        /// 设置导出文件的模版名称
        /// </summary>
        protected virtual void SetExportTemplateName()
        {

        }

        /// <summary>
        /// 设置导出的文件名称前缀
        /// </summary>
        protected virtual void SetExportFileName()
        {

        }

        protected virtual void SetGridColumnsSize()
        {
            this.grdData.AutoSizeColumns();
        }

        protected virtual void AfterThreadOver()
        {
            this.m_ThreadCompletedCount += 1;
            if (this.m_ThreadCompletedCount == this.m_ThreadTotalCount)
            {
                //如果所有线程执行结束
                CloseWaitFormHandler handler = new CloseWaitFormHandler(CloseWaitForm);
                this.Invoke(handler);
                this.m_ThreadCompletedCount = 0;
            }
        }

        protected virtual void AfterExportDataThreadOver()
        {
            CloseExportWaitFormHanlder handler = new CloseExportWaitFormHanlder(CloseExportWaitForm);
            this.Invoke(handler);
            if (this.m_ExportedFileFullName != string.Empty)
            {
                XMessageBox.ShowRemindMessage("导出文件到：" + m_ExportedFileFullName + "！");
            }
        }

        protected delegate void CloseExportWaitFormHanlder();

        private void CloseExportWaitForm()
        {

        }

        private void CloseWaitForm()
        {

        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        protected virtual void InitGridData(object o)
        {
            this.GetAuthonWhereCondition();
            this.InitGridDataByThread();
            if (this.IsNeedFillDetail())
            {
                this.FillDetailGrid();
            }
        }

        /// <summary>
        /// 填充明细信息
        /// </summary>
        protected virtual void FillDetailGrid()
        {

        }

        /// <summary>
        /// 是否需要填充明细
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsNeedFillDetail()
        {
            return false;
        }

        /// <summary>
        /// 绑定查询下拉列表
        /// </summary>
        protected virtual void BindQueryCombobox(object o)
        {
            BindQueryComboBoxOperate();
        }

        protected virtual void BindQueryComboBoxOperate()
        {

        }

        /// <summary>
        /// 获取grid控件的查询条件
        /// </summary>
        protected virtual void GetAuthonWhereCondition()
        {

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
        /// 通过线程初始化数据
        /// </summary>
        protected virtual void InitGridDataByThread()
        {

        }

        /// <summary>
        /// 网格双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void GridDataDoubleClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 鼠标抬起事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void GridMouseUp(object sender, MouseEventArgs e)
        {
            if (this.IsShowRightMenu())
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    this.cmRight.Show(this.grdData);
                }
            }
        }

        protected virtual bool IsShowRightMenu()
        {
            return true;
        }

        protected virtual void Print()
        {
            if (this.ValidatePrint())
            {
                if (IsTemplatePrint)
                {
                    this.PrintTemplate();
                }
                else
                {
                    this.PrintList();
                }
            }
        }

        /// <summary>
        /// 模板打印
        /// </summary>
        protected virtual void PrintTemplate()
        {
            if (this.TemplateFileName == string.Empty)
            {
                XMessageBox.ShowError("模板名称为空！");
                return;
            }

            string templateFileFullName = Application.StartupPath + "\\PrintTemplates\\" + TemplateFileName;
            if (!File.Exists(templateFileFullName))
            {
                XMessageBox.ShowError("模板文件：\r\n" + templateFileFullName + "\r\n不存在！");
                return;
            }

            string tempFilePath = Application.StartupPath + "\\TempFiles";
            if (!Directory.Exists(tempFilePath))
            {
                Directory.CreateDirectory(tempFilePath);
            }


            string[] tempFiles = Directory.GetFiles(tempFilePath);
            foreach (string tempFile in tempFiles)
            {
                try
                {
                    //删除临时文件
                    File.Delete(tempFile);
                }
                catch (Exception ex)
                {
                    XErrorLogTool.WriteLog(ex.ToString());
                }
            }


            string tempFileName = tempFilePath + "\\" + DateTime.Now.ToString("yyyyMMddHHmmssfffff") + ".dot";
            File.Copy(templateFileFullName, tempFileName);

            XModelBase model = this.grdData.CurrentRow.DataRow as XModelBase;
            string id = this.GetModelPKValue(model);

            XModelBase viewModel = this.m_Business.GetViewById(id);

            if (!XTemplatePrintTool.Print(tempFileName, viewModel))
            {
                XMessageBox.ShowError("打印出错！");
            }
        }

        protected virtual string TemplateFileName
        {
            get { return ""; }
        }

        /// <summary>
        /// 列表打印
        /// </summary>
        protected virtual void PrintList()
        {
            this.grdPrinter.DocumentName = this.Text;
            this.grdPrinter.PageHeaderCenter = this.Text;
            this.grdData.RootTable.Columns["select"].Visible = false;
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
            this.grdData.RootTable.Columns["select"].Visible = true;
        }

        protected virtual bool IsTemplatePrint
        {
            get { return false; }
        }

        /// <summary>
        /// 是否打印预览
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsPrintPreview()
        {
            return true;
        }

        protected virtual bool ValidatePrint()
        {
            return this.ValidatePrintCommon() && this.ValidatePrintCustom();
        }

        protected virtual bool ValidatePrintCommon()
        {
            if (this.grdData.RowCount == 0)
            {
                XMessageBox.ShowError("没有要打印的记录！");
                return false;
            }

            XModelBase printModel = this.grdData.CurrentRow.DataRow as XModelBase;

            if (IsTemplatePrint)
            {
                if (printModel == null)
                {
                    XMessageBox.ShowError("请选择要打印的记录！");
                    return false;
                }
            }

            if (IsCheckOrBackCheck || IsNeedCommitOrRollBack)
            {
                ////如果有审批流或者提交，则需要终审后才能打印
                //if (!this.m_Business.IsLastCheck(printModel))
                //{
                //    XMessageBox.ShowError("选中的记录尚未终审，不能打印！");
                //    return false;
                //}
            }
            return true;
        }

        protected virtual bool ValidatePrintCustom()
        {
            return true;
        }

        /// <summary>
        /// 网格单击事件函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void GridDataCellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected virtual void GridDoubleClick(object sender, EventArgs e)
        {
            if (this.IsSelectForm)
            {
                this.Select();
            }
            else
            {
                if (this.IsAllowDoubleEdit)
                {
                    this.Edit();
                }
            }
        }

        protected virtual void Select()
        {
            this.m_SelectedModel = this.grdData.CurrentRow.DataRow as XModelBase;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        #endregion // 保护方法

        #region 私有方法

        private void frmListBase_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                grpQuery.Width = this.grpQuery.Parent.Width - 12;
                this.FormLoadFunction();
            }
        }


        private void btnQuery_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.Query();
            this.Cursor = Cursors.Default;
        }

        protected virtual bool ValidateQuery()
        {
            return true;
        }

        /// <summary>
        /// 导出按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.Export();
            this.Cursor = Cursors.Default;
        }


        /// <summary>
        /// 是否允许反馈
        /// </summary>
        protected virtual bool IsAllowFeedback
        {
            get { return false; }
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        protected virtual void FormLoadFunction()
        {
            if (!this.IsAllowOperateData)
            {
                this.InitNotAllowEditRightCommands();
            }

            if (this.IsCheckOrBackCheck)
            {
                this.cmdCheck.Enabled = Janus.Windows.UI.InheritableBoolean.True;
                this.cmdBackCheck.Enabled = Janus.Windows.UI.InheritableBoolean.True;
            }

            if (!IsHaveFiles)
            {
                this.cmdFile.Visible = Janus.Windows.UI.InheritableBoolean.False;
            }

            if (!IsAllowDownLoad)
            {
                this.cmdDownload.Visible = Janus.Windows.UI.InheritableBoolean.False;
            }

            if (!this.IsAllowFeedback)
            {
                this.cmdFeedback.Visible = Janus.Windows.UI.InheritableBoolean.False;
                this.cmdBackFeedback.Visible = Janus.Windows.UI.InheritableBoolean.False;
            }

            if (this.IsSelectForm)
            {
                this.Text = this.SelectFormTitle;
            }

            this.m_CurrentList = this.InitGridList();
            this.SetExportInfo();
            this.FillGridBefore();
            if (this.grdData.Enabled)
            {
                this.InitGridData(null);
                this.grdData.DataSource = this.m_CurrentList;
                this.SetGridFormat();
            }
            this.BindQueryCombobox(null);
            this.InitGridColumnFormat();
            this.InitEvents();

            this.InitCommandStatus();

            this.InitButtonPosition();

            if (IsAutoRefresh)
            {
                //自动刷新
                this.SetRefreshParameter();
            }
        }

        /// <summary>
        /// 设置刷新参数
        /// </summary>
        protected virtual void SetRefreshParameter()
        {
            
        }

        protected virtual bool IsAutoRefresh
        {
            get { return false; }
        }

        protected virtual void FillGridBefore()
        {

        }

        private void InitButtonPosition()
        {
            this.btnQuery.Location = new Point(this.grpQuery.Width - this.btnQuery.Width - 10, this.btnQuery.Location.Y);
            this.chkChecked.Location = new Point(this.btnQuery.Location.X - this.chkChecked.Width - 10, this.chkChecked.Location.Y);
        }

        private void InitNotAllowEditRightCommands()
        {
            this.cdAddNew.Enabled = Janus.Windows.UI.InheritableBoolean.False;
            this.cmEdit.Enabled = Janus.Windows.UI.InheritableBoolean.False;
            this.cmDelete.Enabled = Janus.Windows.UI.InheritableBoolean.False;
            this.cmdExport.Enabled = Janus.Windows.UI.InheritableBoolean.False;
            if (!this.IsAllowImport)
            {
                this.cmdImport.Visible = Janus.Windows.UI.InheritableBoolean.False;
                this.cmdImport.Enabled = Janus.Windows.UI.InheritableBoolean.False;
            }
            this.cmdExport.Visible = Janus.Windows.UI.InheritableBoolean.False;
            //for (int i = 0; i < this.xCommandManager1.CommandBars.Count; i++)
            //{
            //    //this.xCommandManager1.CommandBars[i].Visible = false;
            //    this.xCommandManager1.CommandBars[i].Enabled = false;
            //}
            //for (int i = 0; i < this.xCommandManager1.ContextMenus.Count; i++)
            //{
            //    for (int j = 0; j < this.xCommandManager1.ContextMenus[i].Commands.Count; j++)
            //    {
            //        //this.xCommandManager1.ContextMenus[i].Commands[j].Visible = Janus.Windows.UI.InheritableBoolean.False;
            //        this.xCommandManager1.ContextMenus[i].Commands[j].Enabled = Janus.Windows.UI.InheritableBoolean.False;
            //    }
            //}
        }

        /// <summary>
        /// 在IsAllowOperateData=false的情况下，如果IsAllowDelete=true,则允许删除
        /// </summary>
        protected virtual bool IsAllowDelete
        {
            get { return false; }
        }

        protected virtual void InitCommandStatus()
        {
            //发布
            if (this.IsNeedSend)
            {
                this.cmdSend.Visible = Janus.Windows.UI.InheritableBoolean.True;
                this.cmdBackSend.Visible = Janus.Windows.UI.InheritableBoolean.True;
            }
            else
            {
                this.cmdSend.Visible = Janus.Windows.UI.InheritableBoolean.False;
                this.cmdBackSend.Visible = Janus.Windows.UI.InheritableBoolean.False;
            }

            //提交与收回
            if (this.IsNeedCommitOrRollBack)
            {
                this.cmdCommit.Visible = Janus.Windows.UI.InheritableBoolean.True;
                this.cmdRollback.Visible = Janus.Windows.UI.InheritableBoolean.True;
                this.cmdViewWorkFlow.Visible = Janus.Windows.UI.InheritableBoolean.True;
            }
            else
            {
                this.cmdCommit.Visible = Janus.Windows.UI.InheritableBoolean.False;
                this.cmdRollback.Visible = Janus.Windows.UI.InheritableBoolean.False;
                this.cmdViewWorkFlow.Visible = Janus.Windows.UI.InheritableBoolean.False;
            }

            //导入与导出
            if (this.IsAllowExport)
            {
                this.cmdExport.Visible = Janus.Windows.UI.InheritableBoolean.True;
            }
            else
            {
                this.cmdExport.Visible = Janus.Windows.UI.InheritableBoolean.False;
            }

            if (this.IsAllowImport)
            {
                this.cmdImport.Visible = Janus.Windows.UI.InheritableBoolean.True;
            }
            else
            {
                this.cmdImport.Visible = Janus.Windows.UI.InheritableBoolean.False;
            }

            if (this.IsAllowOperateData == false && this.IsAllowDelete)
            {
                //this.cmDelete.Enabled = Janus.Windows.UI.InheritableBoolean.True;
                this.cmDelete.Visible = Janus.Windows.UI.InheritableBoolean.True;
            }

            if (IsAllowAddNew)
            {
                //this.cdAddNew.Enabled = Janus.Windows.UI.InheritableBoolean.True;
                this.cdAddNew.Visible = Janus.Windows.UI.InheritableBoolean.True;
            }
            else
            {
                //this.cdAddNew.Enabled = Janus.Windows.UI.InheritableBoolean.False;
                this.cdAddNew.Visible = Janus.Windows.UI.InheritableBoolean.False;
            }

            if (IsAllowEdit)
            {
                //this.cmEdit.Enabled = Janus.Windows.UI.InheritableBoolean.True;
                this.cmEdit.Visible = Janus.Windows.UI.InheritableBoolean.True;
            }
            else
            {
                //this.cmEdit.Enabled = Janus.Windows.UI.InheritableBoolean.False;
                this.cmEdit.Visible = Janus.Windows.UI.InheritableBoolean.False;
            }

            if (IsAllowPreview)
            {
                this.cmdPreview.Visible = Janus.Windows.UI.InheritableBoolean.True;
            }
            else
            {
                this.cmdPreview.Visible = Janus.Windows.UI.InheritableBoolean.False;
            }
        }

        /// <summary>
        /// 是否允许添加
        /// </summary>
        protected virtual bool IsAllowAddNew
        {
            get { return true; }
        }

        /// <summary>
        /// 是否允许修改
        /// </summary>
        protected virtual bool IsAllowEdit
        {
            get { return true; }
        }

        private void InitEvents()
        {
            this.cmdViewFile.Click += cmdViewFile_Click;
            this.cmdUploadFile.Click += cmdUploadFile_Click;
            this.cmdDownload.Click += cmdDownload_Click;
            this.cmdPreview.Click += cmdPreview_Click;
        }

        void cmdPreview_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (this.grdData.CurrentRow != null && this.grdData.CurrentRow.RowType ==
                Janus.Windows.GridEX.RowType.Record)
            {
                XModelBase currentModel = this.grdData.CurrentRow.DataRow as XModelBase;

                string id = this.GetModelPKValue(currentModel);
                this.Preview(id);
            }
        }

        protected virtual void Preview(string id)
        {
            XFilePreviewTool.Preview(id);
        }

        private void InitGridColumnFormat()
        {
            Janus.Windows.GridEX.GridEXTable rootTable = this.grdData.RootTable;
            foreach (Janus.Windows.GridEX.GridEXColumn column in rootTable.Columns)
            {

            }
        }

        protected virtual string SelectFormTitle
        {
            get { return string.Empty; }
        }

        private void AfterBindCombboxThreadOver()
        {
            this.m_ThreadCompletedCount += 1;
            if (this.m_ThreadTotalCount == this.m_ThreadCompletedCount)
            {
                CloseWaitFormHandler handler = new CloseWaitFormHandler(CloseWaitForm);
                this.Invoke(handler);
                this.m_ThreadCompletedCount = 0;
            }
        }

        #endregion // 私有方法

        #region 属性及其私有变量

        /// <summary>
        /// 是否允许操作数据：
        /// </summary>
        protected virtual bool IsAllowOperateData
        {
            get { return true; }
        }

        /// <summary>
        /// 编辑状态
        /// </summary>
        protected XEditStatus m_EditStauts;

        /// <summary>
        /// 是否显示删除成功提示
        /// </summary>
        protected bool m_IsShowDeleteSuccessMessage = false;

        /// <summary>
        /// 追加的删除消息
        /// </summary>
        protected string m_AppendDeleteMessage = "";

        /// <summary>
        /// 当前操作的记录
        /// </summary>
        protected XModelBase m_CurrentModel;

        /// <summary>
        /// 当前操作的实体集
        /// </summary>
        protected IList<XModelBase> m_CurrentList;

        ///// <summary>
        ///// 初始化数据时的窗体
        ///// </summary>
        //protected CSharpClassLibrary.WaitDialogForm m_InitDataWaitForm;

        protected delegate void CloseWaitFormHandler();

        /// <summary>
        /// where查询条件
        /// </summary>
        protected string m_WhereCondition = "";

        /// <summary>
        /// 导出目录
        /// </summary>
        protected string m_ExportFileDirectory = "";


        /// <summary>
        /// 导出的文件名称前缀
        /// </summary>
        protected string m_ExportFileName = "";

        /// <summary>
        /// 已经导出的文件全路径
        /// </summary>
        protected string m_ExportedFileFullName = "";

        protected int m_ThreadTotalCount = 2;

        protected int m_ThreadCompletedCount = 0;

        protected delegate void BindQueryComboboxHanler(DataTable bindTable, string displayMember, string valueMember);

        protected string m_SelectedDeleteIds = "";

        protected IList<XModelBase> m_SelectedModels;

        #endregion // 属性及其私有变量

        bool m_IsAddRefresh=false;
        public virtual bool IsAddRefresh
        {
            get { return m_IsAddRefresh; }
            set { m_IsAddRefresh=value; }
        }


        void cmdQuery_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.QueryAdvanced();
        }

        /// <summary>
        /// 高级查询
        /// </summary>
        protected virtual void QueryAdvanced()
        {
            frmQueryBase frm = this.GetQueryForm();
            if (frm != null)
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.m_WhereCondition = frm.WhereCondition;
                    this.QueryOperation();
                }
            }
        }

        //<summary>
        //获取查询窗体
        //</summary>
        //<returns></returns>
        protected virtual frmQueryBase GetQueryForm()
        {
            return new frmQueryBase();
        }

        void cdAddNew_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.AddNew();
            if (m_IsAddRefresh)
            {
                this.Query();
            }
        }

        void cmEdit_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Edit();
        }

        void cmdExit_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cmdPrint_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Print();
        }

        void cmdImport_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Import();
        }

        protected virtual void Import()
        {
            frmImportListBase frm = this.GetImportForm();
            if (frm != null)
            {
                frm.ShowDialog();
            }
        }

        protected virtual frmImportListBase GetImportForm()
        {
            return null;
        }

        void cmdExport_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Export();
        }

        void cmdRefresh_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.RefreshData();
        }

        void cmDelete_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Delete();
        }

        private void grdData_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.IsShowRightMenu())
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    if (this.IsCheckOrBackCheck)
                    {
                        this.cmCheck.Show(this.grdData);
                    }
                    else
                    {
                        this.cmRight.Show(this.grdData);
                    }
                }
            }
        }

        /// <summary>
        /// 是否是审核或弃审
        /// </summary>
        protected virtual bool IsCheckOrBackCheck
        {
            get { return false; }
        }

        private void grdData_DoubleClick(object sender, EventArgs e)
        {
            GridDoubleClick(sender, e);
        }

        /// <summary>
        /// 是否允许双击修改
        /// </summary>
        protected virtual bool IsAllowDoubleEdit
        {
            get { return true; }
        }

        /// <summary>
        /// 是否是选择窗体，如果是，则双击选择
        /// </summary>
        protected virtual bool IsSelectForm
        {
            get { return false; }
        }

        private void frmListBase_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        protected virtual void grdData_Click(object sender, EventArgs e)
        {

        }

        private XModelBase m_SelectedModel = null;

        /// <summary>
        /// 当前选中的实体模型
        /// </summary>
        public XModelBase SelectedModel
        {
            get { return this.m_SelectedModel; }
        }

        #region 发布与撤销

        /// <summary>
        /// 是否需要发布
        /// </summary>
        protected virtual bool IsNeedSend
        {
            get { return false; }
        }

        void cmdSend_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Send();
        }

        void cmdFeedback_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Feedback();
        }

        private XSendMessageInfo m_SendMessageInfo = null;

        protected virtual void Feedback()
        {
            this.m_EditStauts = XEditStatus.Feedback;

            if (!this.IsSelectedRowByCheckBox())
            {
                return;
            }

            IList<XOperateSingleResultInfo> results = new List<XOperateSingleResultInfo>();

            int successCount = 0;

            foreach (XModelBase model in this.m_SelectedModels)
            {
                string key = this.GetModelKey(model);

                XOperateSingleResultInfo resultInfo = new XOperateSingleResultInfo();
                resultInfo.Key = key;

                string validateCommom = this.ValidateFeedbackCommon(model);

                if (validateCommom != string.Empty)
                {
                    resultInfo.ErrorInfo = validateCommom;
                    results.Add(resultInfo);
                    continue;
                }

                string validateCustom = this.ValidateFeedbackCustom(model);

                if (validateCustom != string.Empty)
                {
                    resultInfo.ErrorInfo = validateCustom;
                    results.Add(resultInfo);
                    continue;
                }

                bool isSuccess = this.FeedbackOperate(model);
                if (!isSuccess)
                {
                    resultInfo.ErrorInfo = string.Empty;
                    results.Add(resultInfo);
                }
                else
                {
                    successCount += 1;
                }
            }

            if (results.Count > 0)
            {
                XMessageBox.ShowError("成功反馈" + successCount + "条记录，失败" +
                    (m_SelectedModels.Count - successCount).ToString() + "条！");
                frmOperateResult frm = new frmOperateResult(results);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowRemindMessage("成功反馈" + successCount + "条记录！");
            }
        }

        /// <summary>
        /// 反馈消息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual bool FeedbackOperate(XModelBase model)
        {
            XSendMessageInfo sendMessageInfo = this.GetFeedbackMessageInfo(model);
            //string sendUserId = this.GetSendUserId(model);
            return this.m_Business.Feedback(model, sendMessageInfo, XCommon.LoginUsersInfo.ID);
        }

        /// <summary>
        /// 获取发布消息的人
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual string GetSendUserId(XModelBase model)
        {
            return string.Empty;
        }

        /// <summary>
        /// 要反馈的消息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual XSendMessageInfo GetFeedbackMessageInfo(XModelBase model)
        {
            XSendMessageInfo sendMessageInfo = new XSendMessageInfo();
            sendMessageInfo.ID = Guid.NewGuid().ToString();
            sendMessageInfo.RemindType = FeedbackRemindType;
            sendMessageInfo.SendUserId = UserId;
            sendMessageInfo.VoucherId = this.GetModelPKValue(model);
            sendMessageInfo.VoucherTypeCode = this.FeedbackVoucherTypeCode;
            sendMessageInfo.Message = this.GetFeedbackMessage(model);
            return sendMessageInfo;
        }

        /// <summary>
        /// 获取要反馈的消息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual string GetFeedbackMessage(XModelBase model)
        {
            return this.GetModelKey(model);
        }

        protected virtual string FeedbackVoucherTypeCode
        {
            get { return string.Empty; }
        }

        private void Send()
        {
            this.m_EditStauts = XEditStatus.Send;
            if (!this.IsSelectedRowByCheckBox())
            {
                return;
            }

            IList<XOperateSingleResultInfo> results = new List<XOperateSingleResultInfo>();

            int successCount = 0;

            foreach (XModelBase model in this.m_SelectedModels)
            {
                string key = this.GetModelKey(model);

                XOperateSingleResultInfo resultInfo = new XOperateSingleResultInfo();
                resultInfo.Key = key;

                string validateCommom = this.ValidateSendCommon(model);

                if (validateCommom != string.Empty)
                {
                    resultInfo.ErrorInfo = validateCommom;
                    results.Add(resultInfo);
                    continue;
                }

                string validateCustom = this.ValidateSendCustom(model);

                if (validateCustom != string.Empty)
                {
                    resultInfo.ErrorInfo = validateCustom;
                    results.Add(resultInfo);
                    continue;
                }

                bool isSuccess = this.SendOperate(model);
                if (!isSuccess)
                {
                    resultInfo.ErrorInfo = string.Empty;
                    results.Add(resultInfo);
                }
                else
                {
                    successCount += 1;
                }
            }

            if (results.Count > 0)
            {
                XMessageBox.ShowError("成功发布" + successCount + "条记录，失败" +
                    (m_SelectedModels.Count - successCount).ToString() + "条！");
                frmOperateResult frm = new frmOperateResult(results);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowRemindMessage("成功发布" + successCount + "条记录！");
            }

        }

        /// <summary>
        /// 发布消息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual bool SendOperate(XModelBase model)
        {
            XSendMessageInfo sendMessageInfo = this.GetSendMessageInfo(model);
            return this.m_Business.Send(model, sendMessageInfo);
        }

        /// <summary>
        /// 获取发送的消息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual XSendMessageInfo GetSendMessageInfo(XModelBase model)
        {
            XSendMessageInfo sendMessageInfo = new XSendMessageInfo();
            sendMessageInfo.ID = Guid.NewGuid().ToString();
            sendMessageInfo.RemindType = RemindType;
            sendMessageInfo.SendUserId = UserId;
            sendMessageInfo.VoucherId = this.GetModelPKValue(model);
            sendMessageInfo.VoucherTypeCode = GetVoucherType(model);
            sendMessageInfo.Message = this.GetSendMessage(model);
            return sendMessageInfo;
        }

        /// <summary>
        /// 获取要发布的消息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual string GetSendMessage(XModelBase model)
        {
            return this.GetModelKey(model);
        }

        protected virtual string FeedbackRemindType
        {
            get { return "反馈信息"; }
        }

        protected virtual string RemindType
        {
            get { return "发布消息"; }
        }

        protected virtual string ValidateFeedbackCustom(XModelBase model)
        {
            return string.Empty;
        }

        protected virtual string ValidateSendCustom(XModelBase model)
        {
            return string.Empty;
        }

        protected virtual string ValidateFeedbackCommon(XModelBase model)
        {
            string validateInfo = string.Empty;

            if (!this.m_Business.IsSend(model))
            {
                validateInfo = "选中的记录尚未发布，不能反馈！";
                return validateInfo;
            }

            return validateInfo;
        }

        protected virtual string ValidateSendCommon(XModelBase model)
        {
            string validateInfo = string.Empty;

            string voucherTypeCode = this.GetVoucherType(model);

            if (voucherTypeCode == string.Empty)
            {
                validateInfo = "选中的记录没有定义单据类型！";
                return validateInfo;
            }

            if (!this.m_Business.IsHaveSendMessageDef(voucherTypeCode))
            {
                validateInfo = "选中的记录没有定义发布信息，不能发布！";
                return validateInfo;
            }

            if (this.m_Business.IsSend(model))
            {
                validateInfo = "选中的记录已发布，不能重复发布！";
                return validateInfo;
            }

            return validateInfo;
        }

        /// <summary>
        /// 撤销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cmdBackSend_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.BackSend();
        }

        protected virtual void BackSend()
        {
            this.m_EditStauts = XEditStatus.BackSend;
            if (!this.IsSelectedRowByCheckBox())
            {
                return;
            }

            IList<XOperateSingleResultInfo> results = new List<XOperateSingleResultInfo>();

            int successCount = 0;

            foreach (XModelBase model in this.m_SelectedModels)
            {
                string key = this.GetModelKey(model);

                XOperateSingleResultInfo resultInfo = new XOperateSingleResultInfo();
                resultInfo.Key = key;

                string validateCommom = this.ValidateBackSendCommon(model);

                if (validateCommom != string.Empty)
                {
                    resultInfo.ErrorInfo = validateCommom;
                    results.Add(resultInfo);
                    continue;
                }

                string validateCustom = this.ValidateBackSendCustom(model);

                if (validateCustom != string.Empty)
                {
                    resultInfo.ErrorInfo = validateCustom;
                    results.Add(resultInfo);
                    continue;
                }

                bool isSuccess = this.BackSendOperate(model);
                if (!isSuccess)
                {
                    resultInfo.ErrorInfo = string.Empty;
                    results.Add(resultInfo);
                }
                else
                {
                    successCount += 1;
                }
            }

            if (results.Count > 0)
            {
                XMessageBox.ShowError("成功撤销发布" + successCount + "条记录，失败" +
                    (m_SelectedModels.Count - successCount).ToString() + "条！");
                frmOperateResult frm = new frmOperateResult(results);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowRemindMessage("成功撤销发布" + successCount + "条记录！");
            }
        }

        /// <summary>
        /// 撤销发布
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual bool BackSendOperate(XModelBase model)
        {
            return this.m_Business.BackSend(model, UserId);
        }

        protected virtual string ValidateBackSendCommon(XModelBase model)
        {
            string validateInfo = string.Empty;

            string voucherTypeCode = this.GetVoucherType(model);

            if (voucherTypeCode == string.Empty)
            {
                validateInfo = "选中的记录没有定义单据类型！";
                return validateInfo;
            }

            if (!this.m_Business.IsSend(model))
            {
                validateInfo = "选中的记录尚未发布，不能撤销发布！";
                return validateInfo;
            }

            string voucherId = this.GetModelPKValue(model);
            string key = this.GetModelKey(model);

            if (this.m_Business.IsSendMessageReaded(voucherId))
            {
                if (XMessageBox.ShowQuestion("关键字为[" + key + "]发布的消息已被阅读，是否继续撤回？")
                    == System.Windows.Forms.DialogResult.No)
                {
                    validateInfo = "选中的记录已被阅读！";
                    return validateInfo;
                }
            }

            return validateInfo;
        }

        protected virtual string ValidateBackSendCustom(XModelBase model)
        {
            return string.Empty;
        }

        protected virtual void FillSendInfo()
        {

        }

        #endregion

        protected virtual void UploadFile()
        {
            if (this.grdData.CurrentRow != null)
            {
                XModelBase model = this.grdData.CurrentRow.DataRow as XModelBase;
                OpenFileDialog ofd = new OpenFileDialog();
                if (this.UploadFilter != string.Empty)
                {
                    ofd.Filter = this.UploadFilter;
                }
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (this.m_Business.InsertFile(Guid.NewGuid().ToString(), this.GetModelPKValue(model),
                        ofd.FileName, this.UserId))
                    {
                        XMessageBox.ShowRemindMessage("上传成功！");
                    }
                    else
                    {
                        XMessageBox.ShowError("上传失败！");
                    }
                }
            }
            else
            {
                XMessageBox.ShowError("请选择要上传附件的记录！");
            }
        }

        /// <summary>
        /// 上传文件过滤
        /// </summary>
        protected virtual string UploadFilter
        {
            get { return "Word或Excel文件|*.doc;*.docx;*.xls;*.xlsx"; }
        }

        void cmdUploadFile_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.UploadFile();
        }

        protected virtual string GetModelPKValue(XModelBase model)
        {
            return model.ID;
        }


        void cmdDownload_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (this.ValidateDownload())
            {
                this.Download();
            }
        }


        protected virtual bool ValidateDownload()
        {
            return this.ValidateDownloadCommon() && this.ValidateDownLoadCustom();
        }

        protected virtual bool ValidateDownloadCommon()
        {
            return true;
        }

        protected virtual bool ValidateDownLoadCustom()
        {
            return true;
        }

        protected virtual void Download()
        {
            if (this.grdData.CurrentRow != null && this.grdData.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
            {
                XModelBase model = this.grdData.CurrentRow.DataRow as XModelBase;

                this.m_CurrentModel = model;

                string mainId = this.GetModelPKValue(model);

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
                        this.DownloadAfter(fileName, model);
                        XMessageBox.ShowRemindMessage("下载完成，文件下载路径为：\r\n" + fileName + "");
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

        protected virtual void DownloadAfter(string fileName, XModelBase model)
        {

        }

        void cmdViewFile_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.ViewFile();
        }

        protected virtual void ViewFile()
        {
            if (this.grdData.CurrentRow != null && this.grdData.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
            {
                XModelBase model = this.grdData.CurrentRow.DataRow as XModelBase;
                string mainId = this.GetModelPKValue(model);
                frmFileInfoList frm = new frmFileInfoList(this.m_Business, mainId);
                frm.ShowDialog();
            }
        }

        /// <summary>
        /// 是否有附件
        /// </summary>
        protected virtual bool IsHaveFiles
        {
            get { return false; }
        }

        protected virtual bool IsAllowDownLoad
        {
            get { return false; }
        }

        #region 提交与收回

        protected virtual bool IsNeedCommitOrRollBack
        {
            get { return false; }
        }

        /// <summary>
        /// 收回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void cmdRollback_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.RollBack();
        }

        protected virtual void RollBack()
        {
            this.m_EditStauts = XEditStatus.Rollback;
            if (!this.IsSelectedRowByCheckBox())
            {
                return;
            }

            IList<XOperateSingleResultInfo> results = new List<XOperateSingleResultInfo>();

            int successCount = 0;

            foreach (XModelBase model in this.m_SelectedModels)
            {
                string key = this.GetModelKey(model);

                XOperateSingleResultInfo resultInfo = new XOperateSingleResultInfo();
                resultInfo.Key = key;

                string validateCommom = this.ValidateRollBackCommom(model);

                if (validateCommom != string.Empty)
                {
                    resultInfo.ErrorInfo = validateCommom;
                    results.Add(resultInfo);
                    continue;
                }

                string validateCustom = this.ValidateRollBackCustom(model);

                if (validateCustom != string.Empty)
                {
                    resultInfo.ErrorInfo = validateCustom;
                    results.Add(resultInfo);
                    continue;
                }

                bool isSuccess = this.RollBackOperate(model);
                if (!isSuccess)
                {
                    resultInfo.ErrorInfo = string.Empty;
                    results.Add(resultInfo);
                }
                else
                {
                    successCount += 1;
                }
            }

            if (results.Count > 0)
            {
                XMessageBox.ShowError("成功收回" + successCount + "条记录，失败" +
                    (m_SelectedModels.Count - successCount).ToString() + "条！");
                frmOperateResult frm = new frmOperateResult(results);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowRemindMessage("成功收回" + successCount + "条记录！");
            }
        }

        /// <summary>
        /// 获取模型关键字
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual string GetModelKey(XModelBase model)
        {
            return string.Empty;
        }

        protected virtual bool RollBackOperate(XModelBase model)
        {
            return this.m_Business.Rollback(model);
        }

        protected virtual string ValidateRollBackCommom(XModelBase model)
        {
            string validateInfo = string.Empty;

            if (!this.m_Business.IsCommit(model))
            {
                validateInfo = "选中的记录尚未提交，不能收回！";
                return validateInfo;
            }

            if (this.m_Business.IsCheck(model))
            {
                validateInfo = "选中的记录已审核，不能收回！";
                return validateInfo;
            }

            return validateInfo;
        }

        protected virtual string ValidateRollBackCustom(XModelBase model)
        {
            return string.Empty;
        }

        void cmdCommit_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Commit();
        }

        protected virtual void Commit()
        {
            this.m_EditStauts = XEditStatus.Commit;
            if (!this.IsSelectedRowByCheckBox())
            {
                return;
            }

            IList<XOperateSingleResultInfo> results = new List<XOperateSingleResultInfo>();

            int successCount = 0;


            foreach (XModelBase model in this.m_SelectedModels)
            {
                string key = this.GetModelKey(model);

                XOperateSingleResultInfo resultInfo = new XOperateSingleResultInfo();
                resultInfo.Key = key;

                string validateCommom = this.ValidateCommitCommom(model);

                if (validateCommom != string.Empty)
                {
                    resultInfo.ErrorInfo = validateCommom;
                    results.Add(resultInfo);
                    continue;
                }

                string validateCustom = this.ValidateCommitCustom(model);

                if (validateCustom != string.Empty)
                {
                    resultInfo.ErrorInfo = validateCustom;
                    results.Add(resultInfo);
                    continue;
                }

                bool isSuccess = this.CommitOperate(model);
                if (!isSuccess)
                {
                    resultInfo.ErrorInfo = string.Empty;
                    results.Add(resultInfo);
                }
                else
                {
                    successCount += 1;
                }
            }

            if (results.Count > 0)
            {
                XMessageBox.ShowError("成功提交" + successCount + "条记录，失败" +
                    (m_SelectedModels.Count - successCount).ToString() + "条！");
                frmOperateResult frm = new frmOperateResult(results);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowRemindMessage("成功提交" + successCount + "条记录！");
            }
        }

        protected virtual bool CommitOperate(XModelBase model)
        {
            return this.m_Business.Commit(model);
        }

        protected virtual string ValidateCommitCommom(XModelBase model)
        {
            string validateInfo = string.Empty;

            if (this.m_Business.IsCommit(model))
            {
                validateInfo = "选中的记录已提交，不能重复提交！";
                return validateInfo;
            }

            string voucherTypeCode = this.GetVoucherType(model);

            if (!this.m_Business.IsHaveWorkFlow(voucherTypeCode))
            {
                validateInfo = "选中的没有定义工作流，不能提交！";
                return validateInfo;
            }

            return validateInfo;
        }

        /// <summary>
        /// 获取单据类型
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual string GetVoucherType(XModelBase model)
        {
            return string.Empty;
        }

        protected virtual string ValidateCommitCustom(XModelBase model)
        {
            string validateInfo = string.Empty;



            return validateInfo;
        }

        #endregion

        #region 审核与弃审

        void cmdBackCheck_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.BackCheck();
        }

        protected XCheckLevelInfo m_BackCheckLevelInfo = null;

        protected virtual string ValidateBackCheckCommon(XModelBase model)
        {
            string validateInfo = string.Empty;

            if (!this.m_Business.IsCheck(model))
            {
                validateInfo = "选中的记录尚未审核，不能弃审！";
                return validateInfo;
            }

            //XModelBase backCheckModelInfo = this.m_Business.GetBackToCheckInfo(model);
            //if (backCheckModelInfo == null)
            //{
            //    validateInfo = "选中的记录未找到工作流审批级次信息！";
            //    return validateInfo;
            //}

            //m_BackCheckLevelInfo = this.GetBackCheckLevelInfo(backCheckModelInfo);
            //m_BackCheckLevelInfo.CheckUserId = this.UserId;

            //if (m_BackCheckLevelInfo.JobCode != this.JobCode)
            //{
            //    validateInfo = "选中的记录的弃审级次不正确，弃审岗位应该为：[" + this.m_BackCheckLevelInfo.JobName + "]！";
            //    return validateInfo;
            //}

            return validateInfo;
        }

        protected virtual string ValidateBackCheckCustom(XModelBase model)
        {
            return string.Empty;
        }

        private void BackCheck()
        {
            this.m_EditStauts = XEditStatus.BackCheck;
            if (!this.IsSelectedRowByCheckBox())
            {
                return;
            }

            IList<XOperateSingleResultInfo> results = new List<XOperateSingleResultInfo>();

            int successCount = 0;

            foreach (XModelBase model in this.m_SelectedModels)
            {
                string key = this.GetModelKey(model);

                XOperateSingleResultInfo resultInfo = new XOperateSingleResultInfo();
                resultInfo.Key = key;

                string validateCommom = this.ValidateBackCheckCommon(model);

                if (validateCommom != string.Empty)
                {
                    resultInfo.ErrorInfo = validateCommom;
                    results.Add(resultInfo);
                    continue;
                }

                string validateCustom = this.ValidateBackCheckCustom(model);

                if (validateCustom != string.Empty)
                {
                    resultInfo.ErrorInfo = validateCustom;
                    results.Add(resultInfo);
                    continue;
                }

                bool isSuccess = this.BackCheckOperate(model);
                if (!isSuccess)
                {
                    resultInfo.ErrorInfo = string.Empty;
                    results.Add(resultInfo);
                }
                else
                {
                    successCount += 1;
                }
            }

            if (results.Count > 0)
            {
                XMessageBox.ShowError("成功弃审" + successCount + "条记录，失败" +
                    (m_SelectedModels.Count - successCount).ToString() + "条！");
                frmOperateResult frm = new frmOperateResult(results);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowRemindMessage("成功弃审" + successCount + "条记录！");
            }
        }

        protected virtual bool BackCheckOperate(XModelBase model)
        {
            return this.m_Business.BackCheck(model, XCommon.LoginUsersInfo.RID);
            //return this.m_Business.BackCheck(model, this.m_BackCheckLevelInfo);
        }

        void cmdCheck_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.Check();
        }

        protected virtual void Check()
        {
            this.m_EditStauts = XEditStatus.Check;
            if (!this.IsSelectedRowByCheckBox())
            {
                return;
            }

            IList<XOperateSingleResultInfo> results = new List<XOperateSingleResultInfo>();

            int successCount = 0;


            foreach (XModelBase model in this.m_SelectedModels)
            {
                string key = this.GetModelKey(model);

                XOperateSingleResultInfo resultInfo = new XOperateSingleResultInfo();
                resultInfo.Key = key;

                string validateCommom = this.ValidateCheckCommon(model);

                if (validateCommom != string.Empty)
                {
                    resultInfo.ErrorInfo = validateCommom;
                    results.Add(resultInfo);
                    continue;
                }

                string validateCustom = this.ValidateCheckCustom(model);

                if (validateCustom != string.Empty)
                {
                    resultInfo.ErrorInfo = validateCustom;
                    results.Add(resultInfo);
                    continue;
                }

                bool isSuccess = this.CheckOperate(model);
                if (!isSuccess)
                {
                    resultInfo.ErrorInfo = string.Empty;
                    results.Add(resultInfo);
                }
                else
                {
                    successCount += 1;
                }
            }

            if (results.Count > 0)
            {
                XMessageBox.ShowError("成功审核" + successCount + "条记录，失败" +
                    (m_SelectedModels.Count - successCount).ToString() + "条！");
                frmOperateResult frm = new frmOperateResult(results);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowRemindMessage("成功审核" + successCount + "条记录！");
            }
        }

        private XCheckLevelInfo m_CheckLevelInfo = null;

        protected virtual string ValidateCheckCommon(XModelBase model)
        {
            string validateInfo = string.Empty;

            //if (!this.m_Business.IsCommit(model))
            //{
            //    validateInfo = "选中的记录尚未提交，不能审核！";
            //    return validateInfo;
            //}

            //XModelBase checkModelInfo = this.m_Business.GetToCheckInfo(model);
            //if (checkModelInfo == null)
            //{
            //    validateInfo = "选中的记录未找到工作流审批级次信息！";
            //    return validateInfo;
            //}

            //m_CheckLevelInfo = this.GetCheckLevelInfo(checkModelInfo);
            //m_CheckLevelInfo.CheckUserId = this.UserId;

            //if (m_CheckLevelInfo.JobCode != this.JobCode)
            //{
            //    validateInfo = "选中的记录的审批级次不正确，审批岗位应该为：[" + m_CheckLevelInfo.JobName + "]！";
            //    return validateInfo;
            //}

            if (this.m_Business.IsCheck(model))
            {
                validateInfo = "选中的记录已审核，不能重复审核！";
                return validateInfo;
            }

            return validateInfo;
        }

        protected virtual XCheckLevelInfo GetCheckLevelInfo(XModelBase checkModelInfo)
        {
            return null;
        }

        protected virtual XCheckLevelInfo GetBackCheckLevelInfo(XModelBase checkModelInfo)
        {
            return this.GetCheckLevelInfo(checkModelInfo);
        }

        protected virtual string ValidateCheckCustom(XModelBase model)
        {
            return string.Empty;
        }

        protected virtual bool CheckOperate(XModelBase model)
        {
            //return this.m_Business.Check(model, this.m_CheckLevelInfo);
            return this.m_Business.Check(model, XCommon.LoginUsersInfo.RID);
        }

        void cmdViewWorkFlow_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (this.grdData.CurrentRow != null)
            {
                XModelBase model = this.grdData.CurrentRow.DataRow as XModelBase;
                string mainId = this.GetModelPKValue(model);
                frmWorkFlowView frm = new frmWorkFlowView(this.m_Business, mainId);
                frm.ShowDialog();
            }
        }


        #endregion

        #region 导入与导出

        /// <summary>
        /// 是否允许导出
        /// </summary>
        protected virtual bool IsAllowExport
        {
            get { return true; }
        }

        /// <summary>
        /// 是否允许导入
        /// </summary>
        protected virtual bool IsAllowImport
        {
            get { return false; }
        }

        #endregion

        private void tmRefresh_Tick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.Query();
            this.Cursor = Cursors.Default;
        }

    }
}

