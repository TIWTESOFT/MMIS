using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.DAL
{
    public partial class XCodeFolderTypeProvider
    {
        protected override bool IsOrderBy
        {
            get
            {
                return true;
            }
        }

        protected override string OrderBy
        {
            get
            {
                return " ORDER BY NameCN ASC ";
            }
        }
    }
}
