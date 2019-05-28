using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVStaffInfoInfo : XStaffInfoInfo
    {
        private string m_LoginUserName = string.Empty;

        public string LoginUserName
        {
            get { return this.m_LoginUserName; }
            set { this.m_LoginUserName = value; }
        }

        private string m_DeptName = string.Empty;

        public string DeptName
        {
            get { return this.m_DeptName; }
            set { this.m_DeptName = value; }
        }
    }
}
