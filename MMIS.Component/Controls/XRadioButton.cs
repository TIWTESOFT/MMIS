using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using MMIS.Helper;

namespace MMIS.Component
{
    public partial class XRadioButton : Janus.Windows.EditControls.UIRadioButton
    {
        public XRadioButton()
        {
            this.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(XRadioButton_KeyDown);
        }

        void XRadioButton_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                XHelper.SendTab();
            }
        }

      
    }
}
