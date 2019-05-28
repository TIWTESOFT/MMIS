using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.UI.Common;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.UI
{
    public partial class frmEquipmentReceiveList : frmListBase
    {
        public frmEquipmentReceiveList()
        {
            InitializeComponent();
            this.IsAddRefresh = true;
        }

        protected override XBusinessBase InitBusiness()
        {
            return new XEquipmentReceiveBusiness();
            //return null;
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmEquipmentReceiveEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmEquipmentReceiveEdit(this.m_CurrentModel);
        }

        protected override bool IsQueryDataFromView
        {
            get
            {
                return true;
            }
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            this.dtStart.Value = this.dtEnd.Value.AddMonths(-1);
            this.cboStatus.Text = this.CurrentQueryStatus;

            base.FormLoadFunction(sender, e);
        }

        protected override bool ValidateEditCustom()
        {
            XEquipmentReceiveBusiness business = this.m_Business as XEquipmentReceiveBusiness;

            string status = business.GetStatus(this.m_CurrentModel.ID);
            if (status != this.CurrentFormStatus)
            {
                XMessageBox.ShowError("当前状态为：[" + status + "]，不能修改！");
                return false;
            }

            return true;
        }

        protected override bool ValidateDeleteCustom()
        {
            foreach (XModelBase model in this.m_SelectedModels)
            {
                string key = this.GetModelKey(model);

                XEquipmentReceiveBusiness business = this.m_Business as XEquipmentReceiveBusiness;

                string status = business.GetStatus(model.ID);

                if (status != "接收")
                {
                    if (XCommon.LoginUsersInfo.Remark.IndexOf("强制删除") >= 0)
                    {
                        string invoiceno = business.GetScalar(model.ID, "InvoiceNo");
                        if (invoiceno != "")
                        {
                            XMessageBox.ShowError("选择的记录中包含已开接收单的记录"+ Environment.NewLine +"请先在【接收单打印】中删除接收单！");
                            return false;
                        }
                        else
                        {
                            if (XMessageBox.ShowQuestion("选择的记录中包含非接收状态的记录，是否强制删除！", "警告！", false) == System.Windows.Forms.DialogResult.No)
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        XMessageBox.ShowError("选择的记录中包含非接收状态的记录，不能删除！");
                        return false;
                    }
                }
            }

            return true;
        }

        protected virtual string CurrentQueryStatus
        {
            get { return this.CurrentFormStatus; }
        }

        /// <summary>
        /// 当前窗体的状态
        /// </summary>
        protected virtual string CurrentFormStatus
        {
            get { return "接收"; }
        }

        protected override bool IsAutoRefresh
        {
            get
            {
                return true;
            }
        }

        protected override void SetRefreshParameter()
        {
            int refreshMinutes = XUICommon.SystemConfigInfo.RefreshMinutes;

            this.tmRefresh.Interval = refreshMinutes * 60 * 1000;
            this.tmRefresh.Enabled = true;
            this.tmRefresh.Start();
        }
    }
}