using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace MMIS.Component
{
    public partial class XCheckTreeView : XTreeView
    {
        public XCheckTreeView()
        {
            this.CheckBoxes = true;
            this.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(XCheckTreeView_AfterCheck);
        }

        void XCheckTreeView_AfterCheck(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            XTreeViewCheckTool.CheckControl(e);
        }

    }
}
