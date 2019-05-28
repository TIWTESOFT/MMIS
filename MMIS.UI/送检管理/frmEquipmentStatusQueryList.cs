using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;

namespace MMIS.UI
{
    public partial class frmEquipmentStatusQueryList : frmListBase
    {
        public frmEquipmentStatusQueryList()
        {
            InitializeComponent();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            this.dtBegin.Value = this.dtEnd.Value.AddMonths(-1);
            base.FormLoadFunction(sender, e);
            this.cmDelete.Visible = Janus.Windows.UI.InheritableBoolean.False;
        }

        protected override BLL.XBusinessBase InitBusiness()
        {
            return new XEquipmentReceiveBusiness();
        }

        protected override bool IsAllowAddNew
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

        protected override bool IsAllowDelete
        {
            get
            {
                return false;
            }
        }

        protected override bool IsAllowDoubleEdit
        {
            get
            {
                return false;
            }
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
