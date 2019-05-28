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
    public partial class frmCodeFileStateList : frmListBase
    {
        public frmCodeFileStateList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XCodeFileStateBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmCodeFileStateEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmCodeFileStateEdit(this.m_CurrentModel);
        }
    }
}