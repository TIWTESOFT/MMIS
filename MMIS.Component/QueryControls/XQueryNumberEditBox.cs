using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace MMIS.Component
{
    public partial class XQueryNumberEditBox : XNumberEditBox, IXQueryControl
    {
        public XQueryNumberEditBox()
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
