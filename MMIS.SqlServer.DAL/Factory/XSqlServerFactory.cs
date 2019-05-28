using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.DAL.SqlServer
{
    public partial class XSqlServerFactory
    {
        public override string GetServerTimeFuncion()
        {
            return "GetDate()";
        }

        public override XVoucherRemindProvider GetVoucherRemindProvider()
        {
            return new XSqlServerVoucherRemindProvider();
        }
    }
}
