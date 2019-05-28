using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Component;

namespace MMIS.UI.Common
{
    public class XQueryControlConditionTool
    {
        protected IXQueryControl m_QueryControl = null;

        public XQueryControlConditionTool(IXQueryControl queryContorl)
        {
            this.m_QueryControl = queryContorl;
        }

        /// <summary>
        /// 获取查询控件的查询条件
        /// </summary>
        /// <param name="queryControl"></param>
        /// <returns></returns>
        public string GetControlWhereCondition()
        {
            XCheckBox isQueryCheckBox = m_QueryControl.QueryCheckBox;
            if (isQueryCheckBox != null && isQueryCheckBox.Checked == false
                && isQueryCheckBox.Visible == true)
            {
                //如果是否查询复选框不为null，并且没有选择复选框，并且复选框不可见，则查询全部
                return string.Empty;
            }

            string firstValue = this.GetFirstValue();
            string secondValue = this.GetSecondValue();

            string where = string.Empty;

            switch (m_QueryControl.QueryOperateType)
            {
                case XQueryOperateType.Equal:
                    return where += this.GetEqualCondition(firstValue);
                case XQueryOperateType.IsEmpty:
                    where = string.Empty;
                    return where += this.GetEmptyCondition();
                case XQueryOperateType.LessThan:
                    return where += this.GetLessThanCondition(firstValue);
                case XQueryOperateType.LessThanOrEqual:
                    return where += this.GetLessThanOrEqualCondition(firstValue);
                case XQueryOperateType.MoreThan:
                    return where += this.GetMoreThanCondition(firstValue);
                case XQueryOperateType.MoreThanOrEqual:
                    return where += this.GetMoreThanOrEqualCondition(firstValue);
                case XQueryOperateType.NotEqual:
                    return where += this.GetNotEqualCondition(firstValue);
                case XQueryOperateType.NotIsEmpty:
                    return where += this.GetNotEmptyCondition();
                case XQueryOperateType.Contain:
                    if (m_QueryControl.GetType().Name == "XSelectCustomerEditBox")
                    {
                        return where += this.GetEqualCondition(firstValue);
                    }
                    else
                    {
                        return where += this.GetContainCondition(firstValue);
                    }
                case XQueryOperateType.EndWith:
                    return where += this.GetEndWithCondtion(firstValue);
                case XQueryOperateType.StartWith:
                    return where += this.GetStartWithCondition(firstValue);
                case XQueryOperateType.ContainText:
                    return where += this.GetContainCondition(secondValue);
                default:
                    return string.Empty;
            }
        }

        /// <summary>
        /// 获取开头包含条件
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        protected virtual string GetStartWithCondition(string firstValue)
        {
            return " and " + this.m_QueryControl.QueryFieldName + " like '" + firstValue + "%'";
        }

        /// <summary>
        /// 获取结尾包含条件
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        protected virtual string GetEndWithCondtion(string firstValue)
        {
            return " and " + this.m_QueryControl.QueryFieldName + " like '%" + firstValue + "'";
        }

        /// <summary>
        /// 获取包含的查询条件
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        protected virtual string GetContainCondition(string firstValue)
        {
            return " and " + this.m_QueryControl.QueryFieldName + " like '%" + firstValue + "%'";
        }

        /// <summary>
        /// 获取小于等于的查询条件
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        protected virtual string GetLessThanOrEqualCondition(string firstValue)
        {
            if (this.IsString())
            {
                return " and " + this.m_QueryControl.QueryFieldName + "<='" + firstValue + "'";
            }
            else
            {
                if (this.m_QueryControl is XQueryDatePicker)
                {
                    XQueryDatePicker queryPicker = this.m_QueryControl as XQueryDatePicker;

                    bool isQuery = true;
                    if (queryPicker.ShowCheckBox == true)
                    {
                        if (queryPicker.Checked)
                        {
                            isQuery = true;
                        }
                        else
                        {
                            isQuery = false;
                        }
                    }
                    if (isQuery)
                    {
                        //如果是日期类型
                        return " and convert(VARCHAR(10)," + this.m_QueryControl.QueryFieldName + ",120)<='" + firstValue + "'";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else if (this.m_QueryControl is XQueryDateTimePicker)
                {
                    XQueryDateTimePicker queryPicker = this.m_QueryControl as XQueryDateTimePicker;
                    bool isQuery = true;
                    if (queryPicker.ShowCheckBox == true)
                    {
                        if (queryPicker.Checked)
                        {
                            isQuery = true;
                        }
                        else
                        {
                            isQuery = false;
                        }
                    }
                    if (isQuery)
                    {
                        //如果是时间类型
                        return " and convert(VARCHAR(19)," + this.m_QueryControl.QueryFieldName + ",120)<='" + firstValue + "'";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    return " and " + this.m_QueryControl.QueryFieldName + "<=" + firstValue + "";
                }
            }
        }

        /// <summary>
        /// 获取小于的查询条件
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        protected virtual string GetLessThanCondition(string firstValue)
        {
            if (this.IsString())
            {
                return " and " + this.m_QueryControl.QueryFieldName + "<'" + firstValue + "'";
            }
            else
            {
                if (this.m_QueryControl is XQueryDatePicker)
                {
                    //如果是日期类型
                    XQueryDatePicker queryPicker = this.m_QueryControl as XQueryDatePicker;

                    bool isQuery = true;
                    if (queryPicker.ShowCheckBox == true)
                    {
                        if (queryPicker.Checked)
                        {
                            isQuery = true;
                        }
                        else
                        {
                            isQuery = false;
                        }
                    }
                    if (isQuery)
                    {
                        //如果是日期类型
                        return " and convert(VARCHAR(10)," + this.m_QueryControl.QueryFieldName + ",120)<'" + firstValue + "'";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else if (this.m_QueryControl is XQueryDateTimePicker)
                {
                    //如果是时间类型
                    XQueryDateTimePicker queryPicker = this.m_QueryControl as XQueryDateTimePicker;
                    bool isQuery = true;
                    if (queryPicker.ShowCheckBox == true)
                    {
                        if (queryPicker.Checked)
                        {
                            isQuery = true;
                        }
                        else
                        {
                            isQuery = false;
                        }
                    }
                    if (isQuery)
                    {
                        //如果是时间类型
                        return " and convert(VARCHAR(19)," + this.m_QueryControl.QueryFieldName + ",120)<'" + firstValue + "'";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    return " and " + this.m_QueryControl.QueryFieldName + "<" + firstValue + "";
                }
            }
        }

        /// <summary>
        /// 获取大于的查询条件
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        protected virtual string GetMoreThanCondition(string firstValue)
        {
            if (this.IsString())
            {
                return " and " + this.m_QueryControl.QueryFieldName + ">'" + firstValue + "'";
            }
            else
            {
                if (this.m_QueryControl is XQueryDatePicker)
                {
                    //如果是日期类型
                    XQueryDatePicker queryPicker = this.m_QueryControl as XQueryDatePicker;

                    bool isQuery = true;
                    if (queryPicker.ShowCheckBox == true)
                    {
                        if (queryPicker.Checked)
                        {
                            isQuery = true;
                        }
                        else
                        {
                            isQuery = false;
                        }
                    }
                    if (isQuery)
                    {
                        //如果是日期类型
                        return " and convert(VARCHAR(10)," + this.m_QueryControl.QueryFieldName + ",120)>'" + firstValue + "'";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else if (this.m_QueryControl is XQueryDateTimePicker)
                {
                    //如果是时间类型
                    XQueryDateTimePicker queryPicker = this.m_QueryControl as XQueryDateTimePicker;
                    bool isQuery = true;
                    if (queryPicker.ShowCheckBox == true)
                    {
                        if (queryPicker.Checked)
                        {
                            isQuery = true;
                        }
                        else
                        {
                            isQuery = false;
                        }
                    }
                    if (isQuery)
                    {
                        //如果是时间类型
                        return " and convert(VARCHAR(19)," + this.m_QueryControl.QueryFieldName + ",120)>'" + firstValue + "'";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    return " and " + this.m_QueryControl.QueryFieldName + ">" + firstValue + "";
                }
            }
        }

        /// <summary>
        /// 获取大于等于的查询条件
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        protected virtual string GetMoreThanOrEqualCondition(string firstValue)
        {
            if (this.IsString())
            {
                return " and " + this.m_QueryControl.QueryFieldName + ">='" + firstValue + "'";
            }
            else
            {
                if (this.m_QueryControl is XQueryDatePicker)
                {
                    //如果是日期类型
                    XQueryDatePicker queryPicker = this.m_QueryControl as XQueryDatePicker;

                    bool isQuery = true;
                    if (queryPicker.ShowCheckBox == true)
                    {
                        if (queryPicker.Checked)
                        {
                            isQuery = true;
                        }
                        else
                        {
                            isQuery = false;
                        }
                    }
                    if (isQuery)
                    {
                        //如果是日期类型
                        return " and convert(VARCHAR(10)," + this.m_QueryControl.QueryFieldName + ",120)>='" + firstValue + "'";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else if (this.m_QueryControl is XQueryDateTimePicker)
                {
                    //如果是时间类型
                    XQueryDateTimePicker queryPicker = this.m_QueryControl as XQueryDateTimePicker;
                    bool isQuery = true;
                    if (queryPicker.ShowCheckBox == true)
                    {
                        if (queryPicker.Checked)
                        {
                            isQuery = true;
                        }
                        else
                        {
                            isQuery = false;
                        }
                    }
                    if (isQuery)
                    {
                        //如果是时间类型
                        return " and convert(VARCHAR(19)," + this.m_QueryControl.QueryFieldName + ",120)>='" + firstValue + "'";
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                else
                {
                    return " and " + this.m_QueryControl.QueryFieldName + ">=" + firstValue + "";
                }
            }
        }

        /// <summary>
        /// 获取为空的查询条件
        /// </summary>
        /// <param name="queryControl"></param>
        /// <returns></returns>
        protected virtual string GetEmptyCondition()
        {
            if (this.IsString())
            {
                return " and " + "(" + m_QueryControl.QueryFieldName + " is null or " +
                                      m_QueryControl.QueryFieldName + "=''" + ")";
            }
            else
            {
                return " and " + m_QueryControl.QueryFieldName + " is null ";
            }
        }


        /// <summary>
        /// 获取不为空的查询条件
        /// </summary>
        /// <param name="queryControl"></param>
        /// <returns></returns>
        protected virtual string GetNotEmptyCondition()
        {
            if (this.IsString())
            {
                return "(" + m_QueryControl.QueryFieldName + " is not null and " +
                                      m_QueryControl.QueryFieldName + "<>''" + ")";
            }
            else
            {
                return m_QueryControl.QueryFieldName + " is not null ";
            }
        }

        /// <summary>
        /// 获取=的查询条件
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        protected virtual string GetEqualCondition(string firstValue)
        {
            //if (firstValue == string.Empty)
            //{
            //    return string.Empty;
            //}
            if (this.IsString())
            {
                return " and " + this.m_QueryControl.QueryFieldName + "='" + firstValue + "'";
            }
            else
            {
                if (this.m_QueryControl is XQueryDatePicker)
                {
                    //如果是日期类型
                    return " and convert(VARCHAR(10)," + this.m_QueryControl.QueryFieldName + ",120)='" + firstValue + "'";
                }
                else if (this.m_QueryControl is XQueryDateTimePicker)
                {
                    //如果是时间类型
                    return " and convert(VARCHAR(19)," + this.m_QueryControl.QueryFieldName + ",120)='" + firstValue + "'";
                }
                else
                {
                    return " and " + this.m_QueryControl.QueryFieldName + "=" + firstValue + "";
                }
            }
        }

        /// <summary>
        /// 获取<>的查询条件
        /// </summary>
        /// <param name="firstValue"></param>
        /// <returns></returns>
        protected virtual string GetNotEqualCondition(string firstValue)
        {
            if (this.IsString())
            {
                return " and " + this.m_QueryControl.QueryFieldName + "<>'" + firstValue + "'";
            }
            else
            {
                return " and " + this.m_QueryControl.QueryFieldName + "<>" + firstValue + "";
            }
        }

        /// <summary>
        /// 查询条件是否是字符串，如果是字符串则需要引号
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsString()
        {
            return false;
        }

        /// <summary>
        /// 获取查询控件的第一个值
        /// </summary>
        /// <param name="queryControl"></param>
        /// <returns></returns>
        protected virtual string GetFirstValue()
        {
            return string.Empty;
        }

        /// <summary>
        /// 获取查询控件的第二个值
        /// </summary>
        /// <param name="queryControl"></param>
        /// <returns></returns>
        protected virtual string GetSecondValue()
        {
            return string.Empty;
        }

    }
}
