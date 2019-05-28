using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.Component
{
    /// <summary>
    /// 数字校验接口
    /// </summary>
    public interface IXNumberValidateInterface
    {
        /// <summary>
        /// 是否允许为0
        /// </summary>
        bool IsAllowZero
        {
            get;
            set;
        }

        /// <summary>
        /// 是否允许小于0
        /// </summary>
        bool IsAllowLessThanZero
        {
            get;
            set;
        }

    }
}
