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
    public partial class frmStandEquipmentCheckRecordList : frmListBase
    {
        public frmStandEquipmentCheckRecordList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XStandEquipmentCheckRecordBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmStandEquipmentCheckRecordEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmStandEquipmentCheckRecordEdit(this.m_CurrentModel);
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            this.dtBegin.Value = this.dtEnd.Value.AddMonths(-1);
            base.FormLoadFunction(sender, e);
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