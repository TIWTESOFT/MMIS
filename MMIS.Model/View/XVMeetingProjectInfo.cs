using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVMeetingProjectInfo : XMeetingProjectInfo
    {
        private string m_DeptName = string.Empty;

        public string DeptName
        {
            get { return this.m_DeptName; }
            set { this.m_DeptName = value; }
        }

        private string m_ProjectType = string.Empty;

        public string ProjectType
        {
            get { return this.m_ProjectType; }
            set { this.m_ProjectType = value; }
        }
    }
}
