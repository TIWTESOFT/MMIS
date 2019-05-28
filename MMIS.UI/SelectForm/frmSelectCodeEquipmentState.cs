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
    public partial class frmSelectCodeEquipmentState : frmCodeEquipmentStateList
    {
        public frmSelectCodeEquipmentState()
        {
            InitializeComponent();
        }

        protected override bool IsSelectForm
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
                return "选择设备状态";
            }
        }
    }
}
