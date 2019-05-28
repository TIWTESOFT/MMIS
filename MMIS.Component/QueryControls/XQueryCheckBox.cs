using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace MMIS.Component
{
    public partial class XQueryCheckBox : XCheckBox, IXQueryCheckBox
    {
        public XQueryCheckBox()
            : base()
        {

        }

        /// <summary>
        /// 查询选中时的值
        /// </summary>
        public string QueryCheckedValue
        {
            get;
            set;
        }

        /// <summary>
        /// 查询时非选中时的值
        /// </summary>
        public string QueryNotCheckedValue
        {
            get;
            set;
        }

        /// <summary>
        /// 是否是bool型的值
        /// </summary>
        public bool IsBoolValue
        {
            get;
            set;
        }


        public XQueryOperateType QueryOperateType
        {
            get;
            set;
        }

        /// <summary>
        /// 是否字符串
        /// </summary>
        public bool IsStringValue
        {
            get;
            set;
        }


        public bool IsQueryChecked
        {
            get { return this.Checked; }
        }


        /// <summary>
        /// 查询时决定是否查询的复选框
        /// </summary>
        public XCheckBox QueryCheckBox
        {
            get;
            set;
        }

        private bool m_QueryIsNotCheckedIsAll = true;

        /// <summary>
        /// 是否不选择就是查询全部
        /// </summary>
        public bool QueryIsNotCheckedIsAll
        {
            get { return this.m_QueryIsNotCheckedIsAll; }
            set { this.m_QueryIsNotCheckedIsAll = value; }
        }

        public string QueryFieldName
        {
            get;
            set;
        }
    }
}
