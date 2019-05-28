using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVStaffCItemInfo : XStaffCItemInfo
    {
        private string m_NameCN = string.Empty;

        public string NameCN
        {
            get { return this.m_NameCN; }
            set { this.m_NameCN = value; }
        }
    }
}
