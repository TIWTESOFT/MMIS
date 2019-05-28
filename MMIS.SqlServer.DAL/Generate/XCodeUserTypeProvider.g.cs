using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;

namespace MMIS.DAL
{
    public partial class XSqlServerCodeUserTypeProvider : MMIS.DAL.XCodeUserTypeProvider
    {
        public override XDataAccessBase GetDataAccess()
        {
            return new XSqlServerDataAccess();
        }
    }
}