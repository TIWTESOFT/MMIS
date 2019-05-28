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
    public partial class frmCodeEquipmentCustTypeList : frmListBase
    {
        public frmCodeEquipmentCustTypeList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XCodeEquipmentCustTypeBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmCodeEquipmentCustTypeEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmCodeEquipmentCustTypeEdit(this.m_CurrentModel);
        }
    }
}