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
    public partial class frmCodeUserTypeList : frmListBase
    {
        public frmCodeUserTypeList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XCodeUserTypeBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmCodeUserTypeEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmCodeUserTypeEdit(this.m_CurrentModel);
        }
    }
}