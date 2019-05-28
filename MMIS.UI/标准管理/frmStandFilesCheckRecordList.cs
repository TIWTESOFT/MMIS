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
    public partial class frmStandFilesCheckRecordList : frmListBase
    {
        public frmStandFilesCheckRecordList()
        {
            InitializeComponent();
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
        
        
        protected override XBusinessBase InitBusiness()
        {
            return new XStandFilesCheckRecordBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmStandFilesCheckRecordEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmStandFilesCheckRecordEdit(this.m_CurrentModel);
        }
    }
}