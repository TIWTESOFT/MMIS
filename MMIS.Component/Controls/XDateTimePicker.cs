using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using MMIS.Helper;

namespace MMIS.Component
{
    public partial class XDateTimePicker : Janus.Windows.CalendarCombo.CalendarCombo
    {
        public XDateTimePicker()
        {
            this.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(XDateTimePicker_KeyDown);
        }

        void XDateTimePicker_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                XHelper.SendTab();
            }
        }
    }
}
