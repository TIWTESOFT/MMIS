using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public class XCheckLevelInfo
    {
        private string m_JobCode = string.Empty;

        public string JobCode
        {
            get { return this.m_JobCode; }
            set { this.m_JobCode = value; }
        }

        private string m_JobName = string.Empty;

        public string JobName
        {
            get { return this.m_JobName; }
            set { this.m_JobName = value; }
        }

        private int m_CheckLevel = 0;

        public int CheckLevel
        {
            get { return this.m_CheckLevel; }
            set { this.m_CheckLevel = value; }
        }

        private string m_CheckUserId = string.Empty;

        public string CheckUserId
        {
            get { return this.m_CheckUserId; }
            set { this.m_CheckUserId = value; }
        }
    }
}
