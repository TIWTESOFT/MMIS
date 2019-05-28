using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public class XSendMessageInfo
    {
        private string m_SendUserId = string.Empty;

        public string SendUserId
        {
            get { return this.m_SendUserId; }
            set { this.m_SendUserId = value; }
        }

        private string m_VoucherTypeCode = string.Empty;

        public string VoucherTypeCode
        {
            get { return this.m_VoucherTypeCode; }
            set { this.m_VoucherTypeCode = value; }
        }

        private string m_RemindType = string.Empty;

        public string RemindType
        {
            get { return this.m_RemindType; }
            set { this.m_RemindType = value; }
        }

        private string m_Message = string.Empty;

        /// <summary>
        /// 消息
        /// </summary>
        public string Message
        {
            get { return this.m_Message; }
            set { this.m_Message = value; }
        }

        private string m_ID = string.Empty;

        public string ID
        {
            get { return this.m_ID; }
            set { this.m_ID = value; }
        }

        private string m_VoucherId = string.Empty;

        public string VoucherId
        {
            get { return this.m_VoucherId; }
            set { this.m_VoucherId = value; }
        }
    }
}
