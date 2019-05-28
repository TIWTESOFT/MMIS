using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMIS.UI
{
    public partial class frmSelectStandCodeEquipment : frmStandCodeEquipmentList
    {
        public frmSelectStandCodeEquipment()
        {
            InitializeComponent();
        }

        protected override bool IsQueryDataFromView
        {
            get
            {
                return true;
            }
        }

        protected override string SelectFormTitle
        {
            get
            {
                return "选择设备";
            }
        }
    }
}
