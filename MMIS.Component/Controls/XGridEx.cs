using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace MMIS.Component
{
    public partial class XGridEx : Janus.Windows.GridEX.GridEX
    {
        public XGridEx()
        {
            this.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.AlternatingColors = true;
            this.AllowAddNew= Janus.Windows.GridEX.InheritableBoolean.False;
            this.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.False;
        }
    }
}
