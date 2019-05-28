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
    public partial class frmCodeEquipmentTypeList : frmListBase
    {
        public frmCodeEquipmentTypeList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XCodeEquipmentTypeBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmCodeEquipmentTypeEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmCodeEquipmentTypeEdit(this.m_CurrentModel);
        }
    }
}