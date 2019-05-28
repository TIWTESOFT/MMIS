using System;
using System.Collections.Generic;
using MMIS.Component;

namespace MMIS.UI.Common
{
    public class XCheckBoxConditionTool : XQueryControlConditionTool
    {
        public XCheckBoxConditionTool(IXQueryControl queryControl)
            : base(queryControl)
        {
        }

        protected override string GetFirstValue()
        {
            IXQueryCheckBox checkBox = m_QueryControl as IXQueryCheckBox;

            return checkBox.IsQueryChecked ? checkBox.QueryCheckedValue.ToString().ToLower() :
                this.GetSecondValue();
        }

        protected override string GetSecondValue()
        {
            IXQueryCheckBox checkBox = m_QueryControl as IXQueryCheckBox;

            return checkBox.QueryNotCheckedValue.ToString().ToLower();
        }

        protected override string GetEqualCondition(string firstValue)
        {
            IXQueryCheckBox checkBox = m_QueryControl as IXQueryCheckBox;
            if (this.IsString())
            {
                if (checkBox.IsQueryChecked == false && checkBox.QueryIsNotCheckedIsAll == true)
                {
                    return string.Empty;
                }
                else
                {
                    return " and " + this.m_QueryControl.QueryFieldName + "='" + GetFirstValue() + "'";
                }
            }
            else
            {
                if (checkBox.IsQueryChecked == false && checkBox.QueryIsNotCheckedIsAll == true)
                {
                    return string.Empty;
                }
                else
                {
                    return " and " + this.m_QueryControl.QueryFieldName + "=" + firstValue + "";
                }
            }
        }

        protected override bool IsString()
        {
            IXQueryCheckBox checkBox = this.m_QueryControl as IXQueryCheckBox;
            if (checkBox.IsBoolValue)
            {
                return false;
            }
            else
            {
                return checkBox.IsStringValue;
            }
        }
    }
}
