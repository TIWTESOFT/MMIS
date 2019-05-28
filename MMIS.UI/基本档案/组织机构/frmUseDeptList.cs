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
    public partial class frmUseDeptList : frmListBase
    {
        public frmUseDeptList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XUseDeptBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmUseDeptEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmUseDeptEdit(this.m_CurrentModel);
        }

        protected override bool IsQueryDataFromView
        {
            get
            {
                return true;
            }
        }
    }
}