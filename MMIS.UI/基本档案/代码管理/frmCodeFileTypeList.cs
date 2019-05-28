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
    public partial class frmCodeFileTypeList : frmListBase
    {
        public frmCodeFileTypeList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XCodeFileTypeBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmCodeFileTypeEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmCodeFileTypeEdit(this.m_CurrentModel);
        }
    }
}