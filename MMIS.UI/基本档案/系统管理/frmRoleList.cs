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
    public partial class frmRoleList : frmListBase
    {
        public frmRoleList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XRoleBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmRoleEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmRoleEdit(this.m_CurrentModel);
        }
    }
}