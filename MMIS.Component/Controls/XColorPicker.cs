using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.Component
{
    public partial class XColorPicker : Janus.Windows.EditControls.UIColorPicker
    {
        public XColorPicker()
        {
            this.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
        }
    }
}
