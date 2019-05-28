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
    public partial class frmPassWord4FileList : frmListBase
    {
        public frmPassWord4FileList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XPassWord4FileBusiness();
        }

        protected override bool IsAllowAddNew
        {
            get
            {
                return false;
            }
        }

        protected override bool IsAllowDelete
        {
            get
            {
                return false;
            }
        }

        protected override bool IsAllowEdit
        {
            get
            {
                return false;
            }
        }

        protected override void FormLoadFunction()
        {
            this.dtEnd.Value = DateTime.Now.Date.AddDays(1).AddSeconds(-1);
            this.dtStart.Value = DateTime.Now.Date.AddSeconds(1);

            base.FormLoadFunction();
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