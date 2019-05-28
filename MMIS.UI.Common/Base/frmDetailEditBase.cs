using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MMIS.Helper;
using MMIS.Model;
using MMIS.BLL;

namespace MMIS.UI.Common
{
    public partial class frmDetailEditBase : frmEditBase
    {
        protected XModelBase m_CurrentDetailModel = null;

        protected IList<XModelBase> m_DetailLists = null;

        protected XBusinessBase m_DetailBusiness;

        protected IList<XModelBase> m_OldDetailLists;

        public IList<XModelBase> DetailLists
        {
            get { return this.m_DetailLists; }
        }

        protected IList<XModelBase> m_SelectedModels = new List<XModelBase>();

        /// <summary>
        /// 当前删除的ID集合
        /// </summary>
        protected string m_DeletedDetailIds = string.Empty;

        public frmDetailEditBase()
        {
            InitializeComponent();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            this.m_DetailBusiness = this.InitDetailBusiness();
            base.FormLoadFunction(sender, e);
            this.InitDetailList();
            this.FillDetailGrid();
        }

        protected virtual XBusinessBase InitDetailBusiness()
        {
            return null;
        }

        /// <summary>
        /// 初始化明细集合
        /// </summary>
        /// <returns></returns>
        protected virtual void InitDetailList()
        {
            string mainId = this.GetMainId();
            this.m_DetailLists = this.GetDetailListByMainId(mainId);
        }

        /// <summary>
        /// 填充明细
        /// </summary>
        protected virtual void FillDetailGrid()
        {
            if (this.m_CurrentModel != null)
            {
                if (this.xGroupBox1.Visible)
                {
                    this.grdDetail.DataSource = m_DetailLists;
                    this.grdDetail.AutoSizeColumns();
                }
            }
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

        /// <summary>
        /// 获得主表的主键字段
        /// </summary>
        protected virtual string GetMainTablePkField()
        {
            return "ID";
        }

        /// <summary>
        /// 获取明细表
        /// </summary>
        /// <param name="mainId"></param>
        /// <returns></returns>
        protected virtual IList<XModelBase> GetDetailListByMainId(string mainId)
        {
            if (this.m_DetailBusiness != null)
            {
                return this.m_DetailBusiness.GetByMainId(mainId, "");
            }
            else
            {
                return new List<XModelBase>();
            }
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            if (this.ValidateDelete() && this.ValidateDeleteCustom())
            {
                foreach (XModelBase model in this.m_SelectedModels)
                {
                    if (model.ModelStatus != XModelStatus.Add)
                    {
                        //如果不是新增的记录
                        string id = model.ID;
                        m_DeletedDetailIds += "'" + id + "',";
                    }
                    Janus.Windows.GridEX.GridEXRow gridRow = this.grdDetail.GetRow(model);
                    gridRow.Delete();
                    this.grdDetail.Refresh();
                    //deleteRow.Delete();
                }
                m_DeletedDetailIds = m_DeletedDetailIds.TrimEnd(',');
            }
        }

        /// <summary>
        /// 自定义的数据校验，子类有特殊的校验可以重写此方法
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateDeleteCustom()
        {
            return true;
        }

        /// <summary>
        /// 校验删除记录
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateDelete()
        {
            int selectedCount = 0;
            this.m_SelectedModels.Clear();
            foreach (GridEXRow gridRow in this.grdDetail.GetRows())
            {
                if (gridRow.IsChecked)
                {
                    selectedCount += 1;
                    XModelBase currentModel = gridRow.DataRow as XModelBase;
                    this.m_SelectedModels.Add(currentModel);
                }
            }
            if (selectedCount == 0)
            {
                XMessageBox.ShowError("请选择要删除的记录！");
                return false;
            }
            if (XMessageBox.ShowQuestion("确定要删除选中的记录吗？") == System.Windows.Forms.DialogResult.No)
            {
                return false;
            }
            return true;
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            if (this.grdDetail.DataSource == null || (this.grdDetail.DataSource as DataTable).Columns.Count == 0)
            {
                this.m_DetailLists = this.GetDetailListByMainId("");
                this.grdDetail.DataSource = this.m_DetailLists;
            }
            if (this.ValidateAddDetailCustom())
            {
                this.AddNewDetail();
            }
        }

        /// <summary>
        /// 校验添加明细
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateAddDetailCustom()
        {
            return true;
        }


        /// <summary>
        /// 添加操作
        /// </summary>
        protected virtual void AddNewDetail()
        {

        }

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            if (this.ValidateEditDetail() && ValidateEditCustom())
            {
                this.EditDetail();
            }
        }

        /// <summary>
        /// 修改操作
        /// </summary>
        protected virtual void EditDetail()
        {

        }

        protected virtual bool ValidateEditCustom()
        {
            return true;
        }

        protected virtual bool ValidateEditDetail()
        {
            if (this.grdDetail.CurrentRow != null && this.grdDetail.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
            {
                this.m_CurrentDetailModel = this.grdDetail.CurrentRow.DataRow as XModelBase;
            }
            if (this.m_CurrentDetailModel == null)
            {
                XMessageBox.ShowError("请选择要修改的记录！");
                return false;
            }
            return true;
        }

        protected override bool SaveAdd()
        {
            return this.m_Business.Insert(this.m_CurrentModel, this.m_DetailLists);
        }

        protected override bool SaveEdit()
        {
            return this.m_Business.Update(this.m_CurrentModel, this.m_DetailLists);
        }
    }
}
