using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace MMIS.Component
{
    public partial class XCombobox : Janus.Windows.EditControls.UIComboBox, IXAllowEmptyAble
    {
        private bool m_IsAllowEmpty = false;

        public XCombobox()
        {
            this.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
        }

        public bool IsAllowEmpty
        {
            get
            {
                return this.m_IsAllowEmpty;
            }
            set
            {
                this.m_IsAllowEmpty = value;
            }
        }
    }
}
