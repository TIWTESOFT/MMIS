using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.Component
{
    public interface IXQueryCheckBox : IXQueryControl
    {

        /// <summary>
        /// 选择是值
        /// </summary>
        string QueryCheckedValue
        {
            get;
            set;
        }

        /// <summary>
        /// 不选择值
        /// </summary>
        string QueryNotCheckedValue
        {
            get;
            set;
        }

        /// <summary>
        /// 是否bool型
        /// </summary>
        bool IsBoolValue
        {
            get;
            set;
        }

        /// <summary>
        /// 是否是字符串
        /// </summary>
        bool IsStringValue
        {
            get;
            set;
        }

        /// <summary>
        /// 是否选中
        /// </summary>
        bool IsQueryChecked
        {
            get;
        }

        /// <summary>
        /// 是否不选择就是查询全部
        /// </summary>
        bool QueryIsNotCheckedIsAll
        {
            get;
            set;
        }
    }
}
