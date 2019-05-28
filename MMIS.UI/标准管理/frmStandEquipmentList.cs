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
    public partial class frmStandEquipmentList : frmListBase
    {
        public frmStandEquipmentList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XStandEquipmentBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmStandEquipmentEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmStandEquipmentEdit(this.m_CurrentModel);
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