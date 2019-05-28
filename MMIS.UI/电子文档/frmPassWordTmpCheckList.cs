using MMIS.Model;
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
    public partial class frmPassWordTmpCheckList : frmPassWordTmpList
    {
        public frmPassWordTmpCheckList()
        {
            InitializeComponent();
        }

        protected override bool IsCheckOrBackCheck
        {
            get
            {
                return true;
            }
        }

        protected override bool IsAllowOperateData
        {
            get
            {
                return false;
            }
        }

        
    }
}
