using MMIS.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.UI.Common
{
    public partial class XComboboxConditionTool : XQueryControlConditionTool
    {
        public XComboboxConditionTool(IXQueryControl queryControl)
            : base(queryControl)
        {

        }

        protected override bool IsString()
        {
            return true;
        }

        protected override string GetFirstValue()
        {
            XQueryCombobox combobox = this.m_QueryControl as XQueryCombobox;
            if (combobox.QueryValue == null)
            {
                return string.Empty;
            }
            return combobox.QueryValue.Trim();
        }
    }
}
