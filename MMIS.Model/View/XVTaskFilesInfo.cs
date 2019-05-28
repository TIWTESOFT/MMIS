using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVTaskFilesInfo : XTaskFilesInfo
    {
        private string m_InputUserName = string.Empty;

        public string InputUserName
        {
            get { return this.m_InputUserName; }
            set { this.m_InputUserName = value; }
        }

        private string m_UpdateUserName = string.Empty;

        public string UpdateUserName
        {
            get { return this.m_UpdateUserName; }
            set { this.m_UpdateUserName = value; }
        }

        private string m_FileFullName = string.Empty;

        public string FileFullName
        {
            get { return this.m_FileFullName; }
            set { this.m_FileFullName = value; }
        }

        private string m_TaskName = string.Empty;

        public string TaskName
        {
            get { return this.m_TaskName; }
            set { this.m_TaskName = value; }
        }

        private string m_TaskNo = string.Empty;

        public string TaskNo
        {
            get { return this.m_TaskNo; }
            set { this.m_TaskNo = value; }
        }

        private string m_StartDate = string.Empty;

        public string StartDate
        {
            get { return this.m_StartDate; }
            set { this.m_StartDate = value; }
        }

        private string m_PreEndDate = string.Empty;

        public string PreEndDate
        {
            get { return this.m_PreEndDate; }
            set { this.m_PreEndDate = value; }
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
    }
}
