using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace MMIS.Component
{
    public partial class XQueryRadioButton : XRadioButton, IXQueryCheckBox
    {
        public XQueryRadioButton()
            : base()
        {

        }

        /// <summary>
        /// 查询字段名
        /// </summary>
        public string QueryFieldName
        {
            get;
            set;
        }

        /// <summary>
        /// 查询操作符
        /// </summary>
        public XQueryOperateType QueryOperateType
        {
            get;
            set;
        }

        public string QueryCheckedValue
        {
            get;
            set;
        }

        public string QueryNotCheckedValue
        {
            get;
            set;
        }

        public bool IsBoolValue
        {
            get;
            set;
        }

        /// <summary>
        /// 是否是字符串
        /// </summary>
        public bool IsStringValue
        {
            get;
            set;
        }

        /// <summary>
        /// 是否选中
        /// </summary>
        public bool IsQueryChecked
        {
            get
            {
                return this.Checked;
            }
        }

        /// <summary>
        /// 查询时决定是否查询的复选框
        /// </summary>
        public XCheckBox QueryCheckBox
        {
            get;
            set;
        }

        private bool m_QueryIsNotCheckedIsAll = false;

        /// <summary>
        /// 是否不选择就是查询全部
        /// </summary>
        public bool QueryIsNotCheckedIsAll
        {
            get { return this.m_QueryIsNotCheckedIsAll; }
            set { this.m_QueryIsNotCheckedIsAll = value; }
        }
    }
}
