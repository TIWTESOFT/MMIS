using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.DAL
{
    public partial class XFactory
    {
        public virtual XVoucherRemindProvider GetVoucherRemindProvider()
        {
            return new XVoucherRemindProvider();
        }
    }
}
