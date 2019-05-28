using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.DAL
{
    public partial class XFactory
    {
        public virtual XMenuProvider GetMenuProvider()
        {
            return new XMenuProvider();
        }

        public virtual XMenuGroupProvider GetMenuGroupProvider()
        {
            return new XMenuGroupProvider();
        }

        public virtual XMenuFolderProvider GetMenuFolderProvider()
        {
            return new XMenuFolderProvider();
        }
    }
}
