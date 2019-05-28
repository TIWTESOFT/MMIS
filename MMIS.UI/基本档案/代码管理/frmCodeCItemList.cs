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
    public partial class frmCodeCItemList : frmListBase
    {
        public frmCodeCItemList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XCodeCItemBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmCodeCItemEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmCodeCItemEdit(this.m_CurrentModel);
        }
    }
}