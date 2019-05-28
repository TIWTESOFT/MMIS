using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVStandCheckRecordInfo : XStandCheckRecordInfo
    {
        private string m_StandNo = string.Empty;

        public string StandNo
        {
            get { return this.m_StandNo; }
            set { this.m_StandNo = value; }
        }

        private string m_StandName = string.Empty;

        public string StandName
        {
            get { return this.m_StandName; }
            set { this.m_StandName = value; }
        }
    }
}
