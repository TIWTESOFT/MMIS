using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.Component;
using MMIS.Helper;
using MMIS.Model;
using MMIS.BLL;

namespace MMIS.UI.Common
{
    public partial class frmDetailListBase : frmListBase
    {
        protected XBusinessBase m_DetailBusienss = null;

        public frmDetailListBase()
        {
            InitializeComponent();
            this.m_DetailBusienss = this.InitDetailBusiness();
            this.InitEvent();
        }


        protected virtual void InitEvent()
        {
            this.cmdAddDetail.Click += cmdAddDetail_Click;
            this.cmdEditDetail.Click += cmdEditDetail_Click;
            this.cmdDeleteDetail.Click += cmdDeleteDetail_Click;
        }

        #region 明细操作

        void cmdDeleteDetail_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.DeleteDetail();
        }

        protected virtual void DeleteDetail()
        {
            if (this.IsDetailSelectedRowByCheckBox() && this.ValidateDeleteDetail())
            {
                if (this.ConfimDelete() == false)
                {
                    return;
                }
                bool isDeleteSuccess = false;
                try
                {
                    isDeleteSuccess = this.DeleteDetailOperate();
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
                    this.DeleteDetailRowsFromMemory();
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

        protected void DeleteDetailRowsFromMemory()
        {
            IList<XModelBase> modelLists = this.grdDetail.DataSource as IList<XModelBase>;

            foreach (XModelBase model in this.m_SelectedDetailModels)
            {
                Janus.Windows.GridEX.GridEXRow row = this.grdDetail.GetRow(model);
                row.Delete();
                modelLists.Remove(model);
            }
        }

        protected virtual bool DeleteDetailOperate()
        {
            return this.m_DetailBusienss.Delete(this.m_SelectedDetailModels, this.UserId);
        }

        protected string m_SelectedDeleteDetailIds;
        protected IList<XModelBase> m_SelectedDetailModels;


        /// <summary>
        /// 检查是否有复选框选中的记录
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsDetailSelectedRowByCheckBox()
        {
            int selectedRowsCount = 0;

            m_SelectedDeleteDetailIds = "";
            m_SelectedDetailModels = new List<XModelBase>();

            foreach (Janus.Windows.GridEX.GridEXRow gridRow in this.grdDetail.GetRows())
            {
                if (gridRow.IsChecked)
                {
                    selectedRowsCount += 1;
                    XModelBase currentModel = gridRow.DataRow as XModelBase;
                    m_SelectedDetailModels.Add(currentModel);
                    string id = currentModel.ID;
                    m_SelectedDeleteDetailIds += "'" + id + "',";
                }
            }
            m_SelectedDeleteDetailIds = m_SelectedDeleteDetailIds.TrimEnd(',');
            if (selectedRowsCount > 0)
            {
                return true;
            }
            else
            {
                string showMessage = "请选择要删除的明细记录！";
                XMessageBox.ShowRemindMessage(showMessage);
                return false;
            }
        }

        /// <summary>
        /// 校验删除操作
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateDeleteDetail()
        {
            return true;
        }


        void cmdEditDetail_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.EditDetail();
        }

        protected virtual void EditDetail()
        {
            if (this.ValidateEditDetail())
            {
                frmSingleDetailEditBase frm = this.GetEditDetailForm();
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.grdDetail.Refresh();
                }
            }
        }

        protected virtual frmSingleDetailEditBase GetEditDetailForm()
        {
            return new frmSingleDetailEditBase(m_CurrentDetailModel);
        }

        protected virtual bool ValidateEditDetail()
        {
            return this.ValidateEditDetailCommon() && this.ValidateEditDetailCustom();
        }

        protected XModelBase m_CurrentDetailModel;

        protected virtual bool ValidateEditDetailCommon()
        {
            if (this.grdDetail.CurrentRow == null || this.grdDetail.CurrentRow.RowType != Janus.Windows.GridEX.RowType.Record)
            {
                XMessageBox.ShowError("请选择要修改的明细记录！");
                return false;
            }

            m_CurrentDetailModel = this.grdDetail.CurrentRow.DataRow as XModelBase;

            return true;
        }

        protected virtual bool ValidateEditDetailCustom()
        {
            return true;
        }

        #region 添加明细

        void cmdAddDetail_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            this.AddDetail();
        }

        protected virtual void AddDetail()
        {
            if (!this.ValidateAddDetail())
            {
                return;
            }

            XModelBase model = this.grdData.CurrentRow.DataRow as XModelBase;
            IList<XModelBase> detailList = this.grdDetail.DataSource as IList<XModelBase>;
            frmSingleDetailEditBase frm = this.GetAddDetailForm(model, detailList);
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.grdDetail.DataSource = null;
                this.grdDetail.DataSource = frm.ModelList;
                this.grdDetail.Refresh();
            }
        }

        protected virtual frmSingleDetailEditBase GetAddDetailForm(XModelBase model, IList<XModelBase> detailList)
        {
            return new frmSingleDetailEditBase(model, detailList);
        }

        protected virtual bool ValidateAddDetail()
        {
            return this.ValidateAddCommon() && this.ValidateAddCustom();
        }

        protected virtual bool ValidateAddCommon()
        {
            if (this.grdData.CurrentRow == null || this.grdData.CurrentRow.RowType != Janus.Windows.GridEX.RowType.Record)
            {
                XMessageBox.ShowError("请选择要添加明细的主表记录！");
                return false;
            }
            return true;
        }

        protected virtual bool ValidateAddCustom()
        {
            return true;
        }

        #endregion

        #endregion

        protected virtual XBusinessBase InitDetailBusiness()
        {
            return null;
        }

        /// <summary>
        /// 是否需要填充明细表
        /// </summary>
        /// <returns></returns>
        protected override bool IsNeedFillDetail()
        {
            return true;
        }

        protected override void FillDetailGrid()
        {
            if (this.m_CurrentList != null && this.m_CurrentList.Count > 0)
            {
                XModelBase firstModel = this.m_CurrentList[0];
                string mainId = firstModel.ID;
                IList<XModelBase> detailList = this.GetDetailListByMainId(mainId);
                this.grdDetail.DataSource = detailList;
                this.grdDetail.AutoSizeColumns();
            }
        }

        /// <summary>
        /// 通过主表ID获得明细表
        /// </summary>
        /// <param name="mainId"></param>
        /// <returns></returns>
        protected virtual IList<XModelBase> GetDetailListByMainId(string mainId)
        {
            if (this.m_DetailBusienss != null)
            {
                if (IsQueryDetailByView)
                {
                    return this.m_DetailBusienss.GetViewByMainId(mainId, "");
                }
                else
                {
                    return this.m_DetailBusienss.GetByMainId(mainId, "");
                }
            }
            else
            {
                return new List<XModelBase>();
            }
        }


        /// <summary>
        /// 是否从视图读取明细
        /// </summary>
        protected virtual bool IsQueryDetailByView
        {
            get { return false; }
        }

        protected override void grdData_Click(object sender, EventArgs e)
        {
            if (this.grdData.CurrentRow != null && this.grdData.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
            {
                XModelBase modelBase = this.grdData.CurrentRow.DataRow as XModelBase;
                if (modelBase != null)
                {
                    string mainId = this.GetModelPKValue(modelBase);// modelBase.ID;
                    IList<XModelBase> detailList = this.GetDetailListByMainId(mainId);
                    this.grdDetail.DataSource = detailList;
                    this.grdDetail.AutoSizeColumns();
                }
            }
        }

        protected override void AddAfter(frmEditBase frm)
        {
            if (frm is frmDetailEditBase)
            {
                frmDetailEditBase frmDetail = frm as frmDetailEditBase;
                this.grdDetail.DataSource = null;
                this.grdDetail.DataSource = frmDetail.DetailLists;
                this.grdDetail.Refresh();
            }
        }

        protected override bool DeleteOperate()
        {
            return this.m_Business.DeleteWithDetails(this.m_SelectedModels);
        }

        protected override void DeleteRowsFromMemory()
        {
            base.DeleteRowsFromMemory();
            this.FillDetailGrid();
        }

        /// <summary>
        /// 是否显示明细右键菜单
        /// </summary>
        protected virtual bool IsShowDetailRightMenu
        {
            get
            {
                return false;
            }
        }

        private void grdDetail_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && IsShowDetailRightMenu)
            {
                this.cmDetailRight.Show(this.grdDetail);
            }
        }

        private void grdDetail_DoubleClick(object sender, EventArgs e)
        {
            if (IsDoubleClickEditDetail)
            {
                this.EditDetail();
            }
        }

        protected virtual bool IsDoubleClickEditDetail
        {
            get { return false; }
        }
    }
}
