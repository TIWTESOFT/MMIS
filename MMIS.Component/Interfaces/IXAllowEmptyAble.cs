using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.Component
{
    /// <summary>
    /// 是否允许为空接口
    /// </summary>
    public interface IXAllowEmptyAble
    {
        /// <summary>
        /// 是否允许为空
        /// </summary>
        bool IsAllowEmpty
        {
            get;
            set;
        }
    }
}
