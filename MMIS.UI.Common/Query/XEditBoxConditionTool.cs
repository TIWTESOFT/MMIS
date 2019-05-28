using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Component;

namespace MMIS.UI.Common
{
    public class XEditBoxConditionTool : XQueryControlConditionTool
    {
        public XEditBoxConditionTool(IXQueryControl queryControl)
            : base(queryControl)
        {
        }

        protected override bool IsString()
        {
            return true;
        }

        protected override string GetFirstValue()
        {
            XQueryEditBox editBox = this.m_QueryControl as XQueryEditBox;
            if (editBox.QueryValue == null)
            {
                return string.Empty;
            }
            return editBox.QueryValue.Trim();
        }
        protected override string GetSecondValue()
        {
            XQueryEditBox editBox = this.m_QueryControl as XQueryEditBox;
            if (editBox.Text == null)
            {
                return string.Empty;
            }
            return editBox.Text.Trim();
        }

    }
}
