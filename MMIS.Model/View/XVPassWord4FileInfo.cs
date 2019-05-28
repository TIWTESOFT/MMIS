using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVPassWord4FileInfo : XPassWord4FileInfo
    {
        private string m_UserName = string.Empty;

        public string UserName
        {
            get { return this.m_UserName; }
            set { this.m_UserName = value; }
        }

        private string m_RealName = string.Empty;

        public string RealName
        {
            get { return this.m_RealName; }
            set { this.m_RealName = value; }
        }

        private string m_PassDesc = string.Empty;

        public string PassDesc
        {
            get { return this.m_PassDesc; }
            set { this.m_PassDesc = value; }
        }

        private string m_FileName = string.Empty;

        public string FileName
        {
            get { return this.m_FileName; }
            set { this.m_FileName = value; }
        }
    }
}
