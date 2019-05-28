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
    public partial class frmCodeFileLevelList : frmListBase
    {
        public frmCodeFileLevelList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XCodeFileLevelBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmCodeFileLevelEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmCodeFileLevelEdit(this.m_CurrentModel);
        }
    }
}