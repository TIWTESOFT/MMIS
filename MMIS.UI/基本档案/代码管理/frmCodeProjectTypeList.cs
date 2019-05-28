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
    public partial class frmCodeProjectTypeList : frmListBase
    {
        public frmCodeProjectTypeList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XCodeProjectTypeBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmCodeProjectTypeEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmCodeProjectTypeEdit(this.m_CurrentModel);
        }
    }
}