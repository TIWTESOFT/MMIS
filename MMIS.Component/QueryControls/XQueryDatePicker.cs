using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace MMIS.Component
{
    public partial class XQueryDatePicker : XDateTimePicker, IXQueryControl
    {
        public XQueryDatePicker()
            : base()
        {

        }

        public string QueryFieldName
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
        /// 查询时决定是否查询的复选框
        /// </summary>
        public XCheckBox QueryCheckBox
        {
            get;
            set;
        }
    }
}
