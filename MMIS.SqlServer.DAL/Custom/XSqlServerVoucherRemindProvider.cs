using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.DAL.SqlServer
{
    public partial class XSqlServerVoucherRemindProvider : MMIS.DAL.XVoucherRemindProvider
    {
        public override XDataAccessBase GetDataAccess()
        {
            return new XSqlServerDataAccess();
        }
    }
}
