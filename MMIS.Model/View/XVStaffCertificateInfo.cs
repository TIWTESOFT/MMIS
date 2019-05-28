using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVStaffCertificateInfo : XStaffCertificateInfo
    {
        private string m_UserName = string.Empty;

        public string UserName
        {
            get { return this.m_UserName; }
            set { this.m_UserName = value; }
        }
    }
}
