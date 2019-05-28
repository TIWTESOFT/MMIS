using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace MMIS.Component
{
    public partial class XCommandManager : Janus.Windows.UI.CommandBars.UICommandManager
    {
        public XCommandManager()
        {
            this.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
        }
    }
}
