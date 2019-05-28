using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MMIS.Component;
using MMIS.Helper;

namespace MMIS.UI.Common
{
    public class XQueryTool
    {
        public static string GetQueryCondition(Control queryParentControl)
        {
            string whereCondition = string.Empty;

            foreach (Control control in queryParentControl.Controls)
            {
                if (control.Text != string.Empty && control.Visible && control is IXQueryControl)
                {
                    whereCondition += GetControlWhereCondition(control as IXQueryControl);
                }
            }
            return whereCondition;
        }

        /// <summary>
        /// 获取控件的查询条件
        /// </summary>
        /// <param name="queryControl"></param>
        /// <returns></returns>
        private static string GetControlWhereCondition(IXQueryControl queryControl)
        {
            XQueryControlConditionTool conditionTool = XQueryControlConditionContext.GetConditionTool(queryControl);
            return conditionTool.GetControlWhereCondition();
        }

    }
}
