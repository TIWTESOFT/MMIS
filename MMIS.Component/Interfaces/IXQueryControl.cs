using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.Component
{
    public interface IXQueryControl
    {
        /// <summary>
        /// 查询字段名称
        /// </summary>
        string QueryFieldName
        {
            get;
            set;
        }

        /// <summary>
        /// 查询操作符
        /// </summary>
        XQueryOperateType QueryOperateType
        {
            get;
            set;
        }

        /// <summary>
        /// 查询时决定是否查询的复选框
        /// </summary>
        XCheckBox QueryCheckBox
        {
            get;
            set;
        }
    }
}
