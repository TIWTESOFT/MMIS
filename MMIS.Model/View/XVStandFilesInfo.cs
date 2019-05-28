using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVStandFilesInfo : XStandFilesInfo
    {
        private string m_StandName = string.Empty;

        /// <summary>
        /// 标准名称
        /// </summary>
        public string StandName
        {
            get { return this.m_StandName; }
            set { this.m_StandName = value; }
        }

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
