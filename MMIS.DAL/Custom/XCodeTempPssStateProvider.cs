using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.DAL
{
    public partial class XCodeTempPssStateProvider
    {
        protected override string GetGetAllOrderByString()
        {
            return " Order By ProirNum asc ";
        } 
    }
}
