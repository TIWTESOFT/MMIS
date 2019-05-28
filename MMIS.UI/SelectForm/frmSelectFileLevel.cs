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
    public partial class frmSelectFileLevel : frmCodeFileLevelList
    {
        public frmSelectFileLevel()
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
                return "选择文件级别";
            }
        }
    }
}
