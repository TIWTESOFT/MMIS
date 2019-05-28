using System;
using System.Collections.Generic;
using System.Text;
using MMIS.DAL;

namespace MMIS.DAL.SqlServer
{
    public partial class XSqlServerFactory : XFactory
    {
        public override XMenuProvider GetMenuProvider()
        {
            return new XSqlServerMenuProvider();
        }

        public override XMenuFolderProvider GetMenuFolderProvider()
        {
            return new XSqlServerMenuFolderProvider();
        }

        public override XMenuGroupProvider GetMenuGroupProvider()
        {
            return new XSqlServerMenuGroupProvider();
        }
    }
}