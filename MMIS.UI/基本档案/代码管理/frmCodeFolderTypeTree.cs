using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.Model;
using MMIS.BLL;

namespace MMIS.UI
{
    public partial class frmCodeFolderTypeTree : frmTreeBase
    {
        public frmCodeFolderTypeTree()
        {
            InitializeComponent();
        }

        protected override XBusinessBase InitTreeBusiness()
        {
            return new XCodeFolderTypeBusiness();
        }

        protected override bool IsShowTreeMenu()
        {
            return false;
        }

        protected override string GetModelText(Model.XModelBase model)
        {
            XCodeFolderTypeInfo folderTypeInfo = model as XCodeFolderTypeInfo;

            return folderTypeInfo.NameCN;
        }
    }
}
