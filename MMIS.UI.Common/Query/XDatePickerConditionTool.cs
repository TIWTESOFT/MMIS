using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Component;

namespace MMIS.UI.Common
{
    public class XDatePickerConditionTool : XQueryControlConditionTool
    {
        public XDatePickerConditionTool(IXQueryControl queryControl)
            : base(queryControl)
        {
        }

        protected override string GetFirstValue()
        {
            XQueryDatePicker dateTimePicker = m_QueryControl as XQueryDatePicker;
            return dateTimePicker.Value.ToString("yyyy-MM-dd");
        }

        protected override bool IsString()
        {
            return false;
        }
    }
}
