using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.UI.Common;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.UI
{
    public partial class frmPassWordTmpList : frmListBase
    {
        public frmPassWordTmpList()
        {
            InitializeComponent();
        }

        protected override XBusinessBase InitBusiness()
        {
            return new XPassWordTmpBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmPassWordTmpEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmPassWordTmpEdit(this.m_CurrentModel);
        }

        protected override string GetModelKey(XModelBase model)
        {
            XPassWordTmpInfo info = model as XPassWordTmpInfo;
            return info.UserName + "-" + info.PassDesc;
        }

        protected override bool ValidateEditCustom()
        {
            if (this.m_Business.IsCheck(this.m_CurrentModel))
            {
                XMessageBox.ShowError("要修改的记录已审核，不能修改！");
                return false;
            }

            return true;
        }
    }
}