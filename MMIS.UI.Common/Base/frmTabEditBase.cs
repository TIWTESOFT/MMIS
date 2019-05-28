using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.Component;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.UI.Common
{
    public partial class frmTabEditBase : frmEditBase
    {
        /// <summary>
        /// 修改前的明细字典
        /// </summary>
        protected IDictionary<string, IList<XModelBase>> m_OldDetailDict = null;

        /// <summary>
        /// 要保存的明细字典
        /// </summary>
        protected IDictionary<string, IList<XModelBase>> m_DetailDict = null;

        /// <summary>
        /// 要删除的明细字典
        /// </summary>
        protected IDictionary<string, IList<XModelBase>> m_DeleteDict = null;

        /// <summary>
        /// 明细字典
        /// </summary>
        public IDictionary<string, IList<XModelBase>> DetailDict
        {
            get { return this.m_DetailDict; }
        }

        /// <summary>
        /// 填充修改前的字典
        /// </summary>
        protected virtual void FillOldDetailDict()
        {
            this.m_OldDetailDict = new Dictionary<string, IList<XModelBase>>();

            foreach (Janus.Windows.UI.Tab.UITabPage tagPage in this.tabDetail.TabPages)
            {
                foreach (Control control in tagPage.Controls)
                {
                    if (control is XGridEx)
                    {
                        XGridEx gridEx = control as XGridEx;
                        if (!m_OldDetailDict.ContainsKey(gridEx.Name))
                        {
                            m_OldDetailDict.Add(gridEx.Name,
                                GetOldGridList(gridEx.DataSource as IList<XModelBase>));
                        }
                        break;
                    }
                }
            }
        }

        private IList<XModelBase> GetOldGridList(IList<XModelBase> oldModelList)
        {
            IList<XModelBase> models = new List<XModelBase>();

            foreach (XModelBase model in oldModelList)
            {
                XModelBase oldModelCopy = model.Clone() as XModelBase;

                models.Add(oldModelCopy);
            }

            return models;
        }

        /// <summary>
        /// 填充要保存的字典
        /// </summary>
        protected virtual void FillSaveDetailDict()
        {
            this.m_DetailDict = new Dictionary<string, IList<XModelBase>>();

            foreach (Janus.Windows.UI.Tab.UITabPage tagPage in this.tabDetail.TabPages)
            {
                foreach (Control control in tagPage.Controls)
                {
                    if (control is XGridEx)
                    {
                        XGridEx gridEx = control as XGridEx;
                        if (m_DetailDict.ContainsKey(gridEx.Name))
                        {
                            m_DetailDict.Remove(gridEx.Name);
                        }
                        m_DetailDict.Add(gridEx.Name, gridEx.DataSource as IList<XModelBase>);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 填充删除的明细
        /// </summary>
        protected virtual void FillDeleteDict()
        {
            this.m_DeleteDict = new Dictionary<string, IList<XModelBase>>();

            //在修改前有的明细记录，在要保存的明细记录中不存在，则说明是要删除的明细
            foreach (KeyValuePair<string, IList<XModelBase>> keyValue in this.m_OldDetailDict)
            {
                string key = keyValue.Key;
                if (!this.m_DetailDict.ContainsKey(key))
                {
                    //如果在要保存的明细记录中不存在此Key，说明删除全部记录
                    m_DeleteDict.Add(key, keyValue.Value);
                }
                else
                {
                    IList<XModelBase> models = null;

                    if (!this.m_DeleteDict.ContainsKey(key))
                    {
                        models = new List<XModelBase>();
                        this.m_DeleteDict.Add(key, models);
                    }
                    else
                    {
                        models = this.m_DeleteDict[key];
                    }

                    foreach (XModelBase oldModel in keyValue.Value)
                    {
                        if (!IsDetailDictContainModel(key, oldModel))
                        {
                            //如果不包含，说明删除
                            models.Add(oldModel);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 在要保存的明细字典中是否包含指定的Model
        /// </summary>
        /// <param name="key"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        private bool IsDetailDictContainModel(string key, XModelBase model)
        {
            if (!this.m_DetailDict.ContainsKey(key))
            {
                return false;
            }
            else
            {
                IList<XModelBase> detailModels = this.m_DetailDict[key];

                foreach (XModelBase detailModel in detailModels)
                {
                    if (model.ID == detailModel.ID)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        protected override void FillModelInfo()
        {
            base.FillModelInfo();

            this.FillSaveDetailDict();//填充要保存的明细字典
            if (this.m_EditStatus == XEditStatus.Edit)
            {
                this.FillDeleteDict();//填充删除的明细字典
            }
        }

        public frmTabEditBase()
        {
            InitializeComponent();
        }

        protected virtual void InitButtonEvent()
        {
            foreach (Janus.Windows.UI.Tab.UITabPage tagPage in this.tabDetail.TabPages)
            {
                foreach (Control control in tagPage.Controls)
                {
                    if (control is XButton)
                    {
                        XButton btn = control as XButton;
                        if (control.Name.StartsWith("btnAddNew"))
                        {
                            btn.Click += new System.EventHandler(this.btnAddNewDetail_Click);
                        }
                        else if (control.Name.StartsWith("btnEdit"))
                        {
                            btn.Click += new System.EventHandler(this.btnEditDetail_Click);
                        }
                        else if (control.Name.StartsWith("btnDelete"))
                        {
                            btn.Click += new System.EventHandler(this.btnDeleteDetail_Click);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 添加明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnAddNewDetail_Click(object sender, EventArgs e)
        {
            this.AddNewDetail(sender);
        }

        protected virtual void AddNewDetail(object sender)
        {
            XButton btnAddNew = sender as XButton;
            XGridEx gridEx = this.FindDetailGridEx(btnAddNew.Parent as Janus.Windows.UI.Tab.UITabPage);

            IList<XModelBase> gridList = gridEx.DataSource as IList<XModelBase>;

            frmEditBase frm = this.GetAddNewDetailForm(gridList, btnAddNew);
            if (frm != null)
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    gridEx.DataSource = null;
                    gridEx.DataSource = frm.ModelList;
                    gridEx.Refresh();
                }
            }
            else
            {
                XMessageBox.ShowError("未实现新增窗体方法！");
            }
        }

        protected virtual frmEditBase GetAddNewDetailForm(IList<XModelBase> gridList, object sender)
        {
            return null;
        }

        /// <summary>
        /// 修改明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnEditDetail_Click(object sender, EventArgs e)
        {
            XButton btnEdit = sender as XButton;
            XGridEx gridEx = this.FindDetailGridEx(btnEdit.Parent as Janus.Windows.UI.Tab.UITabPage);

            XModelBase currentModel = this.GetCurrentModel(gridEx);
            if (currentModel == null)
            {
                XMessageBox.ShowError("请选择要修改的记录！");
                return;
            }

            frmEditBase frm = this.GetEditDetailForm(sender, currentModel);
            if (frm != null)
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    gridEx.Refresh();
                }
            }
            else
            {
                XMessageBox.ShowError("未实现修改窗体方法！");
            }
        }

        protected virtual frmEditBase GetEditDetailForm(object sender, XModelBase currentModel)
        {
            return null;
        }

        protected virtual XModelBase GetCurrentModel(XGridEx gridEx)
        {
            if (gridEx.CurrentRow == null ||
                gridEx.CurrentRow.RowType != Janus.Windows.GridEX.RowType.Record)
            {
                return null;
            }

            return gridEx.CurrentRow.DataRow as XModelBase;
        }

        /// <summary>
        /// 删除明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            XButton btnEdit = sender as XButton;
            XGridEx gridEx = this.FindDetailGridEx(btnEdit.Parent as Janus.Windows.UI.Tab.UITabPage);

            IList<XModelBase> selectedModels = this.GetSelectedModels(gridEx);
            if (selectedModels.Count == 0)
            {
                XMessageBox.ShowError("请选择要删除的记录！");
                return;
            }

            if (!this.ValidateDeleteDetail(sender))
            {
                return;
            }

            this.DeleteDetailRowsFromMemory(gridEx, selectedModels);
        }

        protected virtual bool ValidateDeleteDetail(object sender)
        {
            return this.ValidateDeleteDetailCommon(sender) && this.ValidateDeleteDetailCustom(sender);
        }

        protected virtual bool ValidateDeleteDetailCustom(object sender)
        {
            return true;
        }

        protected virtual bool ValidateDeleteDetailCommon(object sender)
        {
            if (XMessageBox.ShowQuestion("确定要删除选中的记录吗？") == System.Windows.Forms.DialogResult.No)
            {
                return false;
            }

            return true;
        }

        protected virtual IList<XModelBase> GetSelectedModels(XGridEx gridEx)
        {
            IList<XModelBase> selectedModels = new List<XModelBase>();

            foreach (Janus.Windows.GridEX.GridEXRow gridExRow in gridEx.GetCheckedRows())
            {
                XModelBase selectedModel = gridExRow.DataRow as XModelBase;
                selectedModels.Add(selectedModel);
            }

            return selectedModels;
        }

        protected virtual void DeleteDetailRowsFromMemory(XGridEx gridEx, IList<XModelBase> selectedModels)
        {
            IList<XModelBase> modelLists = gridEx.DataSource as IList<XModelBase>;

            foreach (XModelBase model in selectedModels)
            {
                Janus.Windows.GridEX.GridEXRow row = gridEx.GetRow(model);
                row.Delete();
                modelLists.Remove(model);
            }
        }

        /// <summary>
        /// 将每个Tab页签的Business存储在TapPage的Tag中
        /// </summary>
        protected virtual void InitDetailBusiness()
        {

        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            this.InitDetailBusiness();
            this.InitButtonEvent();
            base.FormLoadFunction(sender, e);
            this.InitDetailGrid();
            this.FillOldDetailDict();
        }

        protected virtual void InitDetailGrid()
        {
            string mainId = this.GetMainId();

            foreach (Janus.Windows.UI.Tab.UITabPage tagPage in this.tabDetail.TabPages)
            {
                XBusinessBase tabPageBusiness = tagPage.Tag as XBusinessBase;
                if (tabPageBusiness != null)
                {
                    XGridEx detailGridEx = this.FindDetailGridEx(tagPage);
                    detailGridEx.DataSource = this.GetTabPageDetailList(tabPageBusiness, mainId);
                    if (IsTabPageDetailAutoSizeColumns)
                    {
                        detailGridEx.AutoSizeColumns();
                    }
                }
            }
        }

        /// <summary>
        /// 明细表是否自动列宽
        /// </summary>
        protected virtual bool IsTabPageDetailAutoSizeColumns
        {
            get { return true; }
        }

        protected virtual IList<XModelBase> GetTabPageDetailList(XBusinessBase tabPageBusiness, string mainId)
        {
            return tabPageBusiness.GetByMainId(mainId, "");
        }

        protected virtual XGridEx FindDetailGridEx(Janus.Windows.UI.Tab.UITabPage tabPage)
        {
            foreach (Control control in tabPage.Controls)
            {
                if (control is XGridEx)
                {
                    return control as XGridEx;
                }
            }
            return null;
        }

        protected virtual string GetMainId()
        {
            if (this.m_CurrentModel != null)
            {
                return this.m_CurrentModel.ID;
            }
            else
            {
                return string.Empty;
            }
        }

        private void tabDetail_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabDetail_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            if (this.IsTabPageDetailAutoSizeColumns)
            {
                Janus.Windows.UI.Tab.UITabPage currentPage = e.Page;
                XGridEx gridEx = this.FindDetailGridEx(currentPage);
                gridEx.AutoSizeColumns();
            }
        }
    }
}
