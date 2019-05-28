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
    public partial class frmEquipmentCustList : frmListBase
    {
        public frmEquipmentCustList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XEquipmentCustBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmEquipmentCustEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmEquipmentCustEdit(this.m_CurrentModel);
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