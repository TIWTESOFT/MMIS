using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.Component
{
    /// <summary>
    /// 查询操作符
    /// </summary>
    public enum XQueryOperateType
    {
        Equal = 0,
        NotEqual = 1,
        MoreThan = 2,
        MoreThanOrEqual = 3,
        LessThan = 4,
        LessThanOrEqual = 5,
        Contain = 6,
        NotContain = 7,
        StartWith = 8,
        EndWith = 9,
        IsEmpty = 10,
        NotIsEmpty = 11,
        ContainText=12
    }
}
