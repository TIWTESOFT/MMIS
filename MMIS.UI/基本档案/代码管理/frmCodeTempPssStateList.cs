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
    public partial class frmCodeTempPssStateList : frmListBase
    {
        public frmCodeTempPssStateList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XCodeTempPssStateBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmCodeTempPssStateEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmCodeTempPssStateEdit(this.m_CurrentModel);
        }
    }
}