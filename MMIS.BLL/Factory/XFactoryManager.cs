using System;
using System.Collections.Generic;
using System.Text;
using MMIS.DAL;

namespace MMIS.BLL
{
    public partial class XFactoryManager
    {
        public static XFactory CreateFactory()
        {
            //TODO：发布前需要更改
            //return Lizard.DAL.XFactoryManager.CreateFactory();
            return new MMIS.DAL.SqlServer.XSqlServerFactory();
        }
    }
}
