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
    public partial class frmCodeUserStateList : frmListBase
    {
        public frmCodeUserStateList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XCodeUserStateBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmCodeUserStateEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmCodeUserStateEdit(this.m_CurrentModel);
        }
    }
}