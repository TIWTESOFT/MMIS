using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.Model
{
    public class XFileInfo : XModelBase
    {
        private string m_FileName = string.Empty;

        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName
        {
            get { return this.m_FileName; }
            set { this.m_FileName = value; }
        }

        private string m_UploadTime = string.Empty;

        /// <summary>
        /// 上传时间
        /// </summary>
        public string UploadTime
        {
            get { return this.m_UploadTime; }
            set { this.m_UploadTime = value; }
        }
    }
}
