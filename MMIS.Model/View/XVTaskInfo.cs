using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVTaskInfo : XTaskInfo
    {
        private string m_TaskType = string.Empty;

        /// <summary>
        /// 任务类型
        /// </summary>
        public string TaskType
        {
            get { return this.m_TaskType; }
            set { this.m_TaskType = value; }
        }

        private string m_ParentTaskName = string.Empty;

        public string ParentTaskName
        {
            get { return this.m_ParentTaskName; }
            set { this.m_ParentTaskName = value; }
        }

        private string m_ParentTaskNo = string.Empty;

        public string ParentTaskNo
        {
            get { return this.m_ParentTaskNo; }
            set { this.m_ParentTaskNo = value; }
        }

        private string m_ParentStartDate = string.Empty;

        public string ParentStartDate
        {
            get { return this.m_ParentStartDate; }
            set { this.m_ParentStartDate = value; }
        }

        private string m_ParentPreEndDate = string.Empty;

        public string ParentPreEndDate
        {
            get { return this.m_ParentPreEndDate; }
            set { this.m_ParentPreEndDate = value; }
        }

        private string m_AssignPeopleName = string.Empty;

        /// <summary>
        /// 负责人
        /// </summary>
        public string AssignPeopleName
        {
            get { return this.m_AssignPeopleName; }
            set { this.m_AssignPeopleName = value; }
        }
    }
}
