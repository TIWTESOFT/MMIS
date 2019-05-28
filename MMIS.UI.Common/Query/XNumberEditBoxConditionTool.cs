using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Helper;
using MMIS.Component;

namespace MMIS.UI.Common
{
    public class XNumberEditBoxConditionTool : XQueryControlConditionTool
    {
        public XNumberEditBoxConditionTool(IXQueryControl queryControl)
            : base(queryControl)
        {
        }


        protected override bool IsString()
        {
            return false;
        }

        protected override string GetFirstValue()
        {
            XQueryNumberEditBox numberEditBox = m_QueryControl as XQueryNumberEditBox;
            return XHelper.GetDouble(numberEditBox.Value).ToString();
        }
    }
}
