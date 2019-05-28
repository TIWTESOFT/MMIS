using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVTaskAttachmentInfo : XTaskAttachmentInfo
    {
        private string m_FileFullName = string.Empty;

        /// <summary>
        /// 文件全路径
        /// </summary>
        public string FileFullName
        {
            get { return this.m_FileFullName; }
            set { this.m_FileFullName = value; }
        }
    }
}
