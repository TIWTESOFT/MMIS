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
    public partial class frmCodeTaskTypeList : frmListBase
    {
        public frmCodeTaskTypeList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XCodeTaskTypeBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmCodeTaskTypeEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmCodeTaskTypeEdit(this.m_CurrentModel);
        }
    }
}