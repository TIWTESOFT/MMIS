using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.Model
{
    public class XOperateSingleResultInfo
    {
        private string m_Key = string.Empty;

        public string Key
        {
            get { return this.m_Key; }
            set { this.m_Key = value; }
        }

        private bool m_IsSuccess = false;

        public bool IsSuccess
        {
            get { return this.m_IsSuccess; }
            set { this.m_IsSuccess = value; }
        }

        private string m_ErrorInfo = string.Empty;

        public string ErrorInfo
        {
            get { return this.m_ErrorInfo; }
            set { this.m_ErrorInfo = value; }
        }

        private string m_Key1 = string.Empty;

        public string Key1
        {
            get { return this.m_Key1; }
            set { this.m_Key1 = value; }
        }

        private string m_Key2 = string.Empty;

        public string Key2
        {
            get { return this.m_Key2; }
            set { this.m_Key2 = value; }
        }

        private string m_Key3 = string.Empty;

        public string Key3
        {
            get { return this.m_Key3; }
            set { this.m_Key3 = value; }
        }

        private string m_Key4 = string.Empty;

        public string Key4
        {
            get { return this.m_Key4; }
            set { this.m_Key4 = value; }
        }

        private string m_Key5 = string.Empty;

        public string Key5
        {
            get { return this.m_Key5; }
            set { this.m_Key5 = value; }
        }
    }
}
