using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public class XVUseDeptInfo : XUseDeptInfo
    {
        private string m_ParentName = string.Empty;

        public string ParentName
        {
            get { return this.m_ParentName; }
            set { this.m_ParentName = value; }
        }
    }
}
