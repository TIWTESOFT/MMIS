using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.Helper
{
    public partial class XAppSettingInfo
    {
        private string m_Key = string.Empty;

        public string Key
        {
            get { return this.m_Key; }
            set { this.m_Key = value; }
        }

        private string m_Value = string.Empty;

        public string Value
        {
            get { return this.m_Value; }
            set { this.m_Value = value; }
        }
    }
}
