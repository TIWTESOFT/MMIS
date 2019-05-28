using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.Component
{
    public partial class XQueryCombobox : XCombobox, IXQueryControl
    {
        public XQueryCombobox()
            : base()
        {

        }

        /// <summary>
        /// 查询值
        /// </summary>
        public virtual string QueryValue
        {
            get { return this.Text; }
        }

        private string m_QueryFieldName;

        /// <summary>
        /// 查询字段名称
        /// </summary>
        public string QueryFieldName
        {
            get
            {
                return this.m_QueryFieldName;
            }
            set
            {
                this.m_QueryFieldName = value;
            }
        }

        /// <summary>
        /// 操作符
        /// </summary>
        public XQueryOperateType QueryOperateType
        {
            get;
            set;
        }


        /// <summary>
        /// 查询时决定是否查询的复选框
        /// </summary>
        public XCheckBox QueryCheckBox
        {
            get;
            set;
        }
    }
}
