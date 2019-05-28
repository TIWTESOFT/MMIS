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
using MMIS.Model;

namespace MMIS.UI
{
    public partial class frmSelectCodeFolderType : frmCodeFolderTypeTree
    {
        public frmSelectCodeFolderType()
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
                return "选择文件夹类型";
            }
        }
    }
}
