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
    /// frmListBase ����
    /// ����: 
    /// ����: 
    /// ʱ��: 2011/9/4 8:54:04
    /// ����: Administrator
    /// </summary>
    public partial class frmListBase : frmBase
    {
        protected XBusinessBase m_Business = null;

        protected virtual bool IsAllowPreview
        {
            get { return false; }
        }

        protected XFileAttachmentBusiness m_FileAttachBusiness = null;// new XFileAttachmentBusiness();

        #region ���������

        public frmListBase()
        {
            //
            // Windows ���������֧���������
            //
            InitializeComponent();
            this.m_Business = this.InitBusiness();
            this.InitFileAttachBusiness();
            this.cmdViewWorkFlow.Click += cmdViewWorkFlow_Click;
            if (!this.DesignMode)
            {
                //TODO:����ǰȡ��ע��
                //this.InitFileAttachBusiness();
            }
        }

        #endregion // ���������

        #region ���з���
        #endregion // ���з���

        #region ��������

        protected virtual void InitFileAttachBusiness()
        {
            this.m_FileAttachBusiness = new XFileAttachmentBusiness();
        }

        /// <summary>
        /// ��ʼ��ҵ�����
        /// </summary>
        /// <returns></returns>
        protected virtual XBusinessBase InitBusiness()
        {
            return new XBusinessBase();
        }

        /// <summary>
        /// ��ʼ�����
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
        /// �Ƿ����ͼ��������
        /// </summary>
        protected virtual bool IsQueryDataFromView
        {
            get { return false; }
        }

        /// <summary>
        /// ��ȡ�������ʱ�����ݼ���
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
        /// ��ȡҪ��˵ļ�¼
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
        /// ����������ʽ
        /// </summary>
        private void SetGridFormat()
        {
            this.HideNotAuthonColumns(this.grdData);
            this.SetGridColumnsSize();
            this.SetColumnsReadOnly();
        }

        /// <summary>
        /// ������ֻ��
        /// </summary>
        protected virtual void SetColumnsReadOnly()
        {

        }

        /// <summary>
        /// ����δ��Ȩ��
        /// </summary>
        protected virtual void HideNotAuthonColumns(Janus.Windows.GridEX.GridEX gridEx)
        {

        }

        /// <summary>
        /// ��ѯ
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
        /// ��ȡ�����Ĳ�ѯ����
        /// </summary>
        /// <returns></returns>
        protected virtual string GetOtherCondition()
        {
            return string.Empty;
        }

        /// <summary>
        /// ��ѯ����
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
        /// ��ȡ��ѯ���
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        protected virtual IList<XModelBase> GetQueryList(string where)
        {
            if (IsCheckOrBackCheck)
            {
                if (this.chkChecked.Checked)
                {
                    //��ѯ�����
                    return this.m_Business.GetCheckedTableList(where);
                    //return this.m_Business.GetCheckedViewList(UserId, where);
                }
                else
                {
                    //��ѯӦ���
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
        /// ����
        /// </summary>
        protected virtual void Export()
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel�ļ�(*.xls)|*.xls";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.grdExporter.SheetName = this.Text;
                    this.grdData.RootTable.Columns["select"].Visible = false;
                    System.IO.Stream stream = new System.IO.FileStream(sfd.FileName, System.IO.FileMode.CreateNew);
                    this.grdExporter.Export(stream);
                    stream.Close();
                    this.grdData.RootTable.Columns["select"].Visible = true;
                    XMessageBox.ShowRemindMessage("�������!");
                }
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
                XMessageBox.ShowError("����ʧ��!");
            }
            finally
            {
                this.grdData.RootTable.Columns["select"].Visible = true;
            }
        }

        /// <summary>
        /// У�鵼��
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateExport()
        {
            if (this.grdData.RowCount == 0)
            {
                XMessageBox.ShowError("û��Ҫ�����ļ�¼��");
                return false;
            }

            return true;
        }


        /// <summary>
        /// ��������
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
        /// ��õ���·��
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
        /// ��õ��������ݿ�ʼ����
        /// </summary>
        /// <returns></returns>
        protected virtual int GetExportDataStartRowNo()
        {
            //Ĭ�ϴӵ����п�ʼ����
            return 3;
        }

        /// <summary>
        /// ���
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
        /// ��ӳɹ���ִ�еĲ���
        /// </summary>
        protected virtual void AddAfter(frmEditBase frm)
        {

        }

        /// <summary>
        /// ��ȡ���Ӵ���
        /// </summary>
        /// <returns></returns>
        protected virtual frmEditBase GetAddForm()
        {
            return new frmEditBase(this.m_CurrentList);
        }

        /// <summary>
        /// ��ȡ�༭����
        /// </summary>
        /// <returns></returns>
        protected virtual frmEditBase GetEditForm()
        {
            return new frmEditBase(this.m_CurrentModel);
        }

        /// <summary>
        /// �������ı��
        /// </summary>
        protected virtual void GetGridTable()
        {
            if (this.grdData.DataSource == null)
            {
                this.m_CurrentList = this.grdData.DataSource as IList<XModelBase>;
            }
        }

        ///// <summary>
        ///// ��Ӳ���
        ///// </summary>
        //protected virtual void AddNewOperate()
        //{

        //}

        /// <summary>
        /// У�����
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
        /// �޸�
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
        /// У���޸�
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateEdit()
        {
            return this.ValidateEditCommon() && this.ValidateEditCustom();
        }

        /// <summary>
        /// У���޸�ͨ��
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateEditCommon()
        {
            if (this.IsNeedSend && this.IsSendAllowEdit == false)
            {
                //����з����Ļ������ж��Ƿ񷢲�
                if (this.m_Business.IsSend(this.m_CurrentModel))
                {
                    XMessageBox.ShowError("ѡ��ļ�¼�ѷ����������޸ģ�");
                    return false;
                }
            }

            //if (this.IsNeedCommitOrRollBack)
            //{
            //    if (this.m_Business.IsCommit(this.m_CurrentModel))
            //    {
            //        XMessageBox.ShowError("ѡ��ļ�¼���ύ�������޸ģ�");
            //        return false;
            //    }
            //}

            //if (this.IsCheckOrBackCheck && this.m_Business.IsCheck(this.m_CurrentModel))
            //{
            //    XMessageBox.ShowError("ѡ��ļ�¼����ˣ������޸ģ�");
            //    return false;
            //}

            return true;
        }


        /// <summary>
        /// �������Ƿ������޸�
        /// </summary>
        protected virtual bool IsSendAllowEdit
        {
            get { return false; }
        }

        /// <summary>
        /// У���޸��Զ���
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateEditCustom()
        {
            return true;
        }

        ///// <summary>
        ///// �޸Ĳ���
        ///// </summary>
        //protected virtual void EditOperate()
        //{

        //}

        /// <summary>
        /// ����
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
        /// У�鸴��
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateCopy()
        {
            return true;
        }

        /// <summary>
        /// ���Ʋ���
        /// </summary>
        protected virtual void CopyOperate()
        {

        }

        /// <summary>
        /// ɾ��
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
                    //ɾ���ɹ�
                    this.DeleteRowsFromMemory();
                    if (this.m_IsShowDeleteSuccessMessage)
                    {
                        this.ShowDeleteMessage(true);
                    }
                }
                else
                {
                    //ɾ��ʧ��
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
                return "ȷ��Ҫɾ��ѡ�е�" + this.m_SelectedModels.Count + "����¼��";
            }
            else
            {
                return "ȷ��Ҫɾ��ѡ�еļ�¼��";
            }
        }

        protected virtual void ShowDeleteMessage(bool isSuccess)
        {
            string showMessage = "";
            if (isSuccess)
            {
                showMessage = "ɾ���ɹ���";
            }
            else
            {
                showMessage = "ɾ��ʧ��";
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
        /// У��ɾ������
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
            //            XMessageBox.ShowError("�ؼ���Ϊ[" + key + "]�ļ�¼�ѷ���������ɾ����");
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
            //            XMessageBox.ShowError("�ؼ���Ϊ[" + key + "]�ļ�¼���ύ������ɾ����");
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
                        XMessageBox.ShowError("�ؼ���Ϊ[" + key + "]�ļ�¼����ˣ�����ɾ����");
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
        /// ɾ������
        /// </summary>
        protected virtual bool DeleteOperate()
        {
            return this.m_Business.Delete(this.m_SelectedModels, this.UserId);
        }

        /// <summary>
        /// ˢ��
        /// </summary>
        protected virtual void RefreshData()
        {
            //this.QueryOperation();
            this.Query();
        }

        /// <summary>
        /// �ر�
        /// </summary>
        protected virtual void CloseForm()
        {
            this.Close();
        }

        /// <summary>
        /// У���Ƿ�ѡ�м�¼
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
        /// ����Ƿ��и�ѡ��ѡ�еļ�¼
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
        /// ���û��ѡ�м�¼ʱ��ʾ����Ϣ
        /// </summary>
        /// <returns></returns>
        protected virtual string GetShowNotSelectRowMessage()
        {
            string showMessage = "";
            switch (this.m_EditStauts)
            {
                case XEditStatus.Edit:
                    showMessage = "��ѡ��Ҫ�༭�ļ�¼��";
                    break;
                case XEditStatus.Delete:
                    showMessage = "��ѡ��Ҫɾ���ļ�¼";
                    break;
                case XEditStatus.Copy:
                    showMessage = "��ѡ��Ҫ���Ƶļ�¼";
                    break;
                case XEditStatus.Commit:
                    showMessage = "��ѡ��Ҫ�ύ�ļ�¼";
                    break;
                case XEditStatus.Rollback:
                    showMessage = "��ѡ��Ҫ�ջصļ�¼";
                    break;
                case XEditStatus.Check:
                    showMessage = "��ѡ��Ҫ��˵ļ�¼";
                    break;
                case XEditStatus.BackCheck:
                    showMessage = "��ѡ��Ҫ����ļ�¼";
                    break;
                case XEditStatus.Send:
                    showMessage = "��ѡ��Ҫ�����ļ�¼";
                    break;
                case XEditStatus.BackSend:
                    showMessage = "��ѡ��Ҫ�����ļ�¼";
                    break;
                case XEditStatus.Feedback:
                    showMessage = "��ѡ��Ҫ�����ļ�¼";
                    break;
                case XEditStatus.BackFeedback:
                    showMessage = "��ѡ��Ҫ���صļ�¼";
                    break;
                default:
                    showMessage = "��ѡ��Ҫ�����ļ�¼";
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
        /// ���õ����ļ���ģ������
        /// </summary>
        protected virtual void SetExportTemplateName()
        {

        }

        /// <summary>
        /// ���õ������ļ�����ǰ׺
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
                //��������߳�ִ�н���
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
                XMessageBox.ShowRemindMessage("�����ļ�����" + m_ExportedFileFullName + "��");
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
        /// ��ʼ������
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
        /// �����ϸ��Ϣ
        /// </summary>
        protected virtual void FillDetailGrid()
        {

        }

        /// <summary>
        /// �Ƿ���Ҫ�����ϸ
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsNeedFillDetail()
        {
            return false;
        }

        /// <summary>
        /// �󶨲�ѯ�����б�
        /// </summary>
        protected virtual void BindQueryCombobox(object o)
        {
            BindQueryComboBoxOperate();
        }

        protected virtual void BindQueryComboBoxOperate()
        {

        }

        /// <summary>
        /// ��ȡgrid�ؼ��Ĳ�ѯ����
        /// </summary>
        protected virtual void GetAuthonWhereCondition()
        {

        }

        /// <summary>
        /// ��ȡ��ѯ����
        /// </summary>
        /// <returns></returns>
        protected virtual string GetQueryConditon()
        {
            return XQueryTool.GetQueryCondition(this.grpQuery);
        }

        /// <summary>
        /// ͨ���̳߳�ʼ������
        /// </summary>
        protected virtual void InitGridDataByThread()
        {

        }

        /// <summary>
        /// ����˫���¼�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void GridDataDoubleClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// ���̧���¼�
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
        /// ģ���ӡ
        /// </summary>
        protected virtual void PrintTemplate()
        {
            if (this.TemplateFileName == string.Empty)
            {
                XMessageBox.ShowError("ģ������Ϊ�գ�");
                return;
            }

            string templateFileFullName = Application.StartupPath + "\\PrintTemplates\\" + TemplateFileName;
            if (!File.Exists(templateFileFullName))
            {
                XMessageBox.ShowError("ģ���ļ���\r\n" + templateFileFullName + "\r\n�����ڣ�");
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
                    //ɾ����ʱ�ļ�
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
                XMessageBox.ShowError("��ӡ����");
            }
        }

        protected virtual string TemplateFileName
        {
            get { return ""; }
        }

        /// <summary>
        /// �б��ӡ
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
        /// �Ƿ��ӡԤ��
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
                XMessageBox.ShowError("û��Ҫ��ӡ�ļ�¼��");
                return false;
            }

            XModelBase printModel = this.grdData.CurrentRow.DataRow as XModelBase;

            if (IsTemplatePrint)
            {
                if (printModel == null)
                {
                    XMessageBox.ShowError("��ѡ��Ҫ��ӡ�ļ�¼��");
                    return false;
                }
            }

            if (IsCheckOrBackCheck || IsNeedCommitOrRollBack)
            {
                ////����������������ύ������Ҫ�������ܴ�ӡ
                //if (!this.m_Business.IsLastCheck(printModel))
                //{
                //    XMessageBox.ShowError("ѡ�еļ�¼��δ���󣬲��ܴ�ӡ��");
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
        /// ���񵥻��¼�����
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

        #endregion // ��������

        #region ˽�з���

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
        /// ������ť�¼�
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
        /// �Ƿ�������
        /// </summary>
        protected virtual bool IsAllowFeedback
        {
            get { return false; }
        }

        /// <summary>
        /// ��������¼�
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
                //�Զ�ˢ��
                this.SetRefreshParameter();
            }
        }

        /// <summary>
        /// ����ˢ�²���
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
        /// ��IsAllowOperateData=false������£����IsAllowDelete=true,������ɾ��
        /// </summary>
        protected virtual bool IsAllowDelete
        {
            get { return false; }
        }

        protected virtual void InitCommandStatus()
        {
            //����
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

            //�ύ���ջ�
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

            //�����뵼��
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
        /// �Ƿ��������
        /// </summary>
        protected virtual bool IsAllowAddNew
        {
            get { return true; }
        }

        /// <summary>
        /// �Ƿ������޸�
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

        #endregion // ˽�з���

        #region ���Լ���˽�б���

        /// <summary>
        /// �Ƿ�����������ݣ�
        /// </summary>
        protected virtual bool IsAllowOperateData
        {
            get { return true; }
        }

        /// <summary>
        /// �༭״̬
        /// </summary>
        protected XEditStatus m_EditStauts;

        /// <summary>
        /// �Ƿ���ʾɾ���ɹ���ʾ
        /// </summary>
        protected bool m_IsShowDeleteSuccessMessage = false;

        /// <summary>
        /// ׷�ӵ�ɾ����Ϣ
        /// </summary>
        protected string m_AppendDeleteMessage = "";

        /// <summary>
        /// ��ǰ�����ļ�¼
        /// </summary>
        protected XModelBase m_CurrentModel;

        /// <summary>
        /// ��ǰ������ʵ�弯
        /// </summary>
        protected IList<XModelBase> m_CurrentList;

        ///// <summary>
        ///// ��ʼ������ʱ�Ĵ���
        ///// </summary>
        //protected CSharpClassLibrary.WaitDialogForm m_InitDataWaitForm;

        protected delegate void CloseWaitFormHandler();

        /// <summary>
        /// where��ѯ����
        /// </summary>
        protected string m_WhereCondition = "";

        /// <summary>
        /// ����Ŀ¼
        /// </summary>
        protected string m_ExportFileDirectory = "";


        /// <summary>
        /// �������ļ�����ǰ׺
        /// </summary>
        protected string m_ExportFileName = "";

        /// <summary>
        /// �Ѿ��������ļ�ȫ·��
        /// </summary>
        protected string m_ExportedFileFullName = "";

        protected int m_ThreadTotalCount = 2;

        protected int m_ThreadCompletedCount = 0;

        protected delegate void BindQueryComboboxHanler(DataTable bindTable, string displayMember, string valueMember);

        protected string m_SelectedDeleteIds = "";

        protected IList<XModelBase> m_SelectedModels;

        #endregion // ���Լ���˽�б���

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
        /// �߼���ѯ
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
        //��ȡ��ѯ����
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
        /// ��ӡ
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
        /// �Ƿ�����˻�����
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
        /// �Ƿ�����˫���޸�
        /// </summary>
        protected virtual bool IsAllowDoubleEdit
        {
            get { return true; }
        }

        /// <summary>
        /// �Ƿ���ѡ���壬����ǣ���˫��ѡ��
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
        /// ��ǰѡ�е�ʵ��ģ��
        /// </summary>
        public XModelBase SelectedModel
        {
            get { return this.m_SelectedModel; }
        }

        #region �����볷��

        /// <summary>
        /// �Ƿ���Ҫ����
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
                XMessageBox.ShowError("�ɹ�����" + successCount + "����¼��ʧ��" +
                    (m_SelectedModels.Count - successCount).ToString() + "����");
                frmOperateResult frm = new frmOperateResult(results);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowRemindMessage("�ɹ�����" + successCount + "����¼��");
            }
        }

        /// <summary>
        /// ������Ϣ
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
        /// ��ȡ������Ϣ����
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual string GetSendUserId(XModelBase model)
        {
            return string.Empty;
        }

        /// <summary>
        /// Ҫ��������Ϣ
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
        /// ��ȡҪ��������Ϣ
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
                XMessageBox.ShowError("�ɹ�����" + successCount + "����¼��ʧ��" +
                    (m_SelectedModels.Count - successCount).ToString() + "����");
                frmOperateResult frm = new frmOperateResult(results);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowRemindMessage("�ɹ�����" + successCount + "����¼��");
            }

        }

        /// <summary>
        /// ������Ϣ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual bool SendOperate(XModelBase model)
        {
            XSendMessageInfo sendMessageInfo = this.GetSendMessageInfo(model);
            return this.m_Business.Send(model, sendMessageInfo);
        }

        /// <summary>
        /// ��ȡ���͵���Ϣ
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
        /// ��ȡҪ��������Ϣ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual string GetSendMessage(XModelBase model)
        {
            return this.GetModelKey(model);
        }

        protected virtual string FeedbackRemindType
        {
            get { return "������Ϣ"; }
        }

        protected virtual string RemindType
        {
            get { return "������Ϣ"; }
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
                validateInfo = "ѡ�еļ�¼��δ���������ܷ�����";
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
                validateInfo = "ѡ�еļ�¼û�ж��嵥�����ͣ�";
                return validateInfo;
            }

            if (!this.m_Business.IsHaveSendMessageDef(voucherTypeCode))
            {
                validateInfo = "ѡ�еļ�¼û�ж��巢����Ϣ�����ܷ�����";
                return validateInfo;
            }

            if (this.m_Business.IsSend(model))
            {
                validateInfo = "ѡ�еļ�¼�ѷ����������ظ�������";
                return validateInfo;
            }

            return validateInfo;
        }

        /// <summary>
        /// ����
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
                XMessageBox.ShowError("�ɹ���������" + successCount + "����¼��ʧ��" +
                    (m_SelectedModels.Count - successCount).ToString() + "����");
                frmOperateResult frm = new frmOperateResult(results);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowRemindMessage("�ɹ���������" + successCount + "����¼��");
            }
        }

        /// <summary>
        /// ��������
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
                validateInfo = "ѡ�еļ�¼û�ж��嵥�����ͣ�";
                return validateInfo;
            }

            if (!this.m_Business.IsSend(model))
            {
                validateInfo = "ѡ�еļ�¼��δ���������ܳ���������";
                return validateInfo;
            }

            string voucherId = this.GetModelPKValue(model);
            string key = this.GetModelKey(model);

            if (this.m_Business.IsSendMessageReaded(voucherId))
            {
                if (XMessageBox.ShowQuestion("�ؼ���Ϊ[" + key + "]��������Ϣ�ѱ��Ķ����Ƿ�������أ�")
                    == System.Windows.Forms.DialogResult.No)
                {
                    validateInfo = "ѡ�еļ�¼�ѱ��Ķ���";
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
                        XMessageBox.ShowRemindMessage("�ϴ��ɹ���");
                    }
                    else
                    {
                        XMessageBox.ShowError("�ϴ�ʧ�ܣ�");
                    }
                }
            }
            else
            {
                XMessageBox.ShowError("��ѡ��Ҫ�ϴ������ļ�¼��");
            }
        }

        /// <summary>
        /// �ϴ��ļ�����
        /// </summary>
        protected virtual string UploadFilter
        {
            get { return "Word��Excel�ļ�|*.doc;*.docx;*.xls;*.xlsx"; }
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
                    XMessageBox.ShowError("δ�ҵ�������");
                    return;
                }

                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileName = this.m_FileAttachBusiness.DownloadFile(mainId, fbd.SelectedPath);

                    if (fileName != string.Empty)
                    {
                        this.DownloadAfter(fileName, model);
                        XMessageBox.ShowRemindMessage("������ɣ��ļ�����·��Ϊ��\r\n" + fileName + "");
                    }
                    else
                    {
                        XMessageBox.ShowError("����ʧ�ܣ�");
                    }
                }
            }
            else
            {
                XMessageBox.ShowError("��ѡ��Ҫ���ظ����ļ�¼��");
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
        /// �Ƿ��и���
        /// </summary>
        protected virtual bool IsHaveFiles
        {
            get { return false; }
        }

        protected virtual bool IsAllowDownLoad
        {
            get { return false; }
        }

        #region �ύ���ջ�

        protected virtual bool IsNeedCommitOrRollBack
        {
            get { return false; }
        }

        /// <summary>
        /// �ջ�
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
                XMessageBox.ShowError("�ɹ��ջ�" + successCount + "����¼��ʧ��" +
                    (m_SelectedModels.Count - successCount).ToString() + "����");
                frmOperateResult frm = new frmOperateResult(results);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowRemindMessage("�ɹ��ջ�" + successCount + "����¼��");
            }
        }

        /// <summary>
        /// ��ȡģ�͹ؼ���
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
                validateInfo = "ѡ�еļ�¼��δ�ύ�������ջأ�";
                return validateInfo;
            }

            if (this.m_Business.IsCheck(model))
            {
                validateInfo = "ѡ�еļ�¼����ˣ������ջأ�";
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
                XMessageBox.ShowError("�ɹ��ύ" + successCount + "����¼��ʧ��" +
                    (m_SelectedModels.Count - successCount).ToString() + "����");
                frmOperateResult frm = new frmOperateResult(results);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowRemindMessage("�ɹ��ύ" + successCount + "����¼��");
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
                validateInfo = "ѡ�еļ�¼���ύ�������ظ��ύ��";
                return validateInfo;
            }

            string voucherTypeCode = this.GetVoucherType(model);

            if (!this.m_Business.IsHaveWorkFlow(voucherTypeCode))
            {
                validateInfo = "ѡ�е�û�ж��幤�����������ύ��";
                return validateInfo;
            }

            return validateInfo;
        }

        /// <summary>
        /// ��ȡ��������
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

        #region ���������

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
                validateInfo = "ѡ�еļ�¼��δ��ˣ���������";
                return validateInfo;
            }

            //XModelBase backCheckModelInfo = this.m_Business.GetBackToCheckInfo(model);
            //if (backCheckModelInfo == null)
            //{
            //    validateInfo = "ѡ�еļ�¼δ�ҵ�����������������Ϣ��";
            //    return validateInfo;
            //}

            //m_BackCheckLevelInfo = this.GetBackCheckLevelInfo(backCheckModelInfo);
            //m_BackCheckLevelInfo.CheckUserId = this.UserId;

            //if (m_BackCheckLevelInfo.JobCode != this.JobCode)
            //{
            //    validateInfo = "ѡ�еļ�¼�����󼶴β���ȷ�������λӦ��Ϊ��[" + this.m_BackCheckLevelInfo.JobName + "]��";
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
                XMessageBox.ShowError("�ɹ�����" + successCount + "����¼��ʧ��" +
                    (m_SelectedModels.Count - successCount).ToString() + "����");
                frmOperateResult frm = new frmOperateResult(results);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowRemindMessage("�ɹ�����" + successCount + "����¼��");
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
                XMessageBox.ShowError("�ɹ����" + successCount + "����¼��ʧ��" +
                    (m_SelectedModels.Count - successCount).ToString() + "����");
                frmOperateResult frm = new frmOperateResult(results);
                frm.ShowDialog();
            }
            else
            {
                XMessageBox.ShowRemindMessage("�ɹ����" + successCount + "����¼��");
            }
        }

        private XCheckLevelInfo m_CheckLevelInfo = null;

        protected virtual string ValidateCheckCommon(XModelBase model)
        {
            string validateInfo = string.Empty;

            //if (!this.m_Business.IsCommit(model))
            //{
            //    validateInfo = "ѡ�еļ�¼��δ�ύ��������ˣ�";
            //    return validateInfo;
            //}

            //XModelBase checkModelInfo = this.m_Business.GetToCheckInfo(model);
            //if (checkModelInfo == null)
            //{
            //    validateInfo = "ѡ�еļ�¼δ�ҵ�����������������Ϣ��";
            //    return validateInfo;
            //}

            //m_CheckLevelInfo = this.GetCheckLevelInfo(checkModelInfo);
            //m_CheckLevelInfo.CheckUserId = this.UserId;

            //if (m_CheckLevelInfo.JobCode != this.JobCode)
            //{
            //    validateInfo = "ѡ�еļ�¼���������β���ȷ��������λӦ��Ϊ��[" + m_CheckLevelInfo.JobName + "]��";
            //    return validateInfo;
            //}

            if (this.m_Business.IsCheck(model))
            {
                validateInfo = "ѡ�еļ�¼����ˣ������ظ���ˣ�";
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

        #region �����뵼��

        /// <summary>
        /// �Ƿ�������
        /// </summary>
        protected virtual bool IsAllowExport
        {
            get { return true; }
        }

        /// <summary>
        /// �Ƿ�������
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

