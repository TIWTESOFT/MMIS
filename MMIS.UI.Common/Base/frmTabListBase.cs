using MMIS.BLL;
using MMIS.Component;
using MMIS.Helper;
using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMIS.UI.Common
{
    public partial class frmTabListBase : frmListBase
    {
        public frmTabListBase()
        {
            InitializeComponent();
        }

        protected override void FormLoadFunction()
        {
            base.FormLoadFunction();
            this.InitDetailBusiness();

            string mainId = string.Empty;
            if (this.grdData.RowCount > 0)
            {
                IList<XModelBase> models = this.grdData.DataSource as IList<XModelBase>;
                mainId = models[0].ID;
            }

            this.InitDetailGrid(mainId);
        }

        protected virtual string GetMainId(XModelBase model)
        {
            return model.ID;
        }

        /// <summary>
        /// 将每个Tab页签的Business存储在TapPage的Tag中
        /// </summary>
        protected virtual void InitDetailBusiness()
        {

        }

        protected virtual void InitDetailGrid(string mainId)
        {
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

        private void tabDetail_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            if (this.IsTabPageDetailAutoSizeColumns)
            {
                Janus.Windows.UI.Tab.UITabPage currentPage = e.Page;
                XGridEx gridEx = this.FindDetailGridEx(currentPage);
                if (gridEx != null)
                {
                    gridEx.AutoSizeColumns();
                }
            }
        }

        protected override void grdData_Click(object sender, EventArgs e)
        {
            string mainId = string.Empty;

            if (this.grdData.CurrentRow != null && this.grdData.CurrentRow.RowType ==
                Janus.Windows.GridEX.RowType.Record)
            {
                XModelBase currentRow = this.grdData.CurrentRow.DataRow as XModelBase;
                mainId = this.GetModelPKValue(currentRow);
            }

            this.InitDetailGrid(mainId);
        }

        protected override void AddAfter(frmEditBase frm)
        {
            this.FillGridByEditForm(frm);
        }

        private void FillGridByEditForm(frmEditBase frm)
        {
            frmTabEditBase frmTabEdit = frm as frmTabEditBase;
            if (frmTabEdit != null)
            {
                IDictionary<string, IList<XModelBase>> dict = frmTabEdit.DetailDict;
                if (dict != null)
                {
                    foreach (Janus.Windows.UI.Tab.UITabPage tabPage in this.tabDetail.TabPages)
                    {
                        XGridEx gridEx = this.FindDetailGridEx(tabPage);
                        if (dict.ContainsKey(gridEx.Name))
                        {
                            if (gridEx != null)
                            {
                                gridEx.DataSource = dict[gridEx.Name];
                                this.grdData.Refresh();
                            }
                        }
                    }
                }
            }
        }

        protected override void EditAfter(frmEditBase frm)
        {
            this.FillGridByEditForm(frm);
        }
    }
}
