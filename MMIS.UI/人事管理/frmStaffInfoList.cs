using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.UI.Common;

namespace MMIS.UI
{
    public partial class frmStaffInfoList : frmListBase
    {
        public frmStaffInfoList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XStaffInfoBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmStaffInfoEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmStaffInfoEdit(this.m_CurrentModel);
        }

        protected override bool IsQueryDataFromView
        {
            get
            {
                return true;
            }
        }

        protected override bool IsAllowPreview
        {
            get
            {
                return true;
            }
        }
    }
}