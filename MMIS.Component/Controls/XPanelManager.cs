using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace MMIS.Component
{
    public partial class XPanelManager : Janus.Windows.UI.Dock.UIPanelManager
    {
        public XPanelManager()
        {
            this.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
        }
    }
}
