using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVUsersInfo : XUsersInfo
    {
        private string m_JobName = string.Empty;

        public string JobName
        {
            get { return this.m_JobName; }
            set { this.m_JobName = value; }
        }

        private string m_UserTypeName = string.Empty;

        public string UserTypeName
        {
            get { return this.m_UserTypeName; }
            set { this.m_UserTypeName = value; }
        }
    }
}
