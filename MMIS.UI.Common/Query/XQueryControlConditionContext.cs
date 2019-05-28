using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Component;

namespace MMIS.UI.Common
{
    /// <summary>
    /// 获取查询控件的查询条件工具类
    /// </summary>
    public class XQueryControlConditionContext
    {
        /// <summary>
        /// 获取查询控件查询条件工具类
        /// </summary>
        /// <param name="queryControl"></param>
        /// <returns></returns>
        public static XQueryControlConditionTool GetConditionTool(IXQueryControl queryControl)
        {
            if (queryControl is IXQueryCheckBox)
            {
                return new XCheckBoxConditionTool(queryControl);
            }
            else if (queryControl is XQueryEditBox)
            {
                return new XEditBoxConditionTool(queryControl);
            }
            else if (queryControl is XQueryNumberEditBox)
            {
                return new XNumberEditBoxConditionTool(queryControl);
            }
            else if (queryControl is XQueryDatePicker)
            {
                return new XDatePickerConditionTool(queryControl);
            }
            else if (queryControl is XQueryDateTimePicker)
            {
                return new XDateTimePickerConditionTool(queryControl);
            }
            else if (queryControl is XQueryCombobox)
            {
                return new XComboboxConditionTool(queryControl);
            }
            else
            {
                return new XQueryControlConditionTool(queryControl);
            }
        }
    }
}
