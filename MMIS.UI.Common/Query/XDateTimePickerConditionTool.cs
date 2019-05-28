using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Component;

namespace MMIS.UI.Common
{
    public class XDateTimePickerConditionTool : XQueryControlConditionTool
    {
        public XDateTimePickerConditionTool(IXQueryControl queryControl)
            : base(queryControl)
        {
        }

        protected override string GetFirstValue()
        {
            XQueryDateTimePicker dateTimePicker = m_QueryControl as XQueryDateTimePicker;
            return dateTimePicker.Value.ToString("yyyy-MM-dd HH:mm:ss");
        }

        protected override bool IsString()
        {
            return false;
        }
    }
}
