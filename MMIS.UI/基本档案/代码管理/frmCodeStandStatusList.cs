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
    public partial class frmCodeStandStatusList : frmListBase
    {
        public frmCodeStandStatusList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XCodeStandStatusBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmCodeStandStatusEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmCodeStandStatusEdit(this.m_CurrentModel);
        }
    }
}