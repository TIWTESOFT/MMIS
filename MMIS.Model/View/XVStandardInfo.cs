using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVStandardInfo : XStandardInfo
    {
        private string m_StandStatusName = string.Empty;

        public string StandStatusName
        {
            get { return this.m_StandStatusName; }
            set { this.m_StandStatusName = value; }
        }
    }
}
