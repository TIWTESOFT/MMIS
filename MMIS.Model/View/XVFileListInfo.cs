using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVFileListInfo : XFileListInfo
    {
        private string m_FileType = string.Empty;

        /// <summary>
        /// 文件类型
        /// </summary>
        public string FileType
        {
            get { return this.m_FileType; }
            set { this.m_FileType = value; }
        }

        private string m_FileState = string.Empty;

        /// <summary>
        /// 文件状态
        /// </summary>
        public string FileState
        {
            get { return this.m_FileState; }
            set { this.m_FileState = value; }
        }

        private string m_FileLevel = string.Empty;

        /// <summary>
        /// 文件级别
        /// </summary>
        public string FileLevel
        {
            get { return this.m_FileLevel; }
            set { this.m_FileLevel = value; }
        }

        private string m_FolderType = string.Empty;

        /// <summary>
        /// 文件夹类型
        /// </summary>
        public string FolderType
        {
            get { return this.m_FolderType; }
            set { this.m_FolderType = value; }
        }

        private double m_AtchSize = 0;

        /// <summary>
        /// 文件大小
        /// </summary>
        public double AtchSize
        {
            get { return this.m_AtchSize; }
            set { this.m_AtchSize = value; }
        }

        private string m_FilePath = string.Empty;

        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath
        {
            get { return this.m_FilePath; }
            set { this.m_FilePath = value; }
        }

        private string m_UploadTime = string.Empty;

        /// <summary>
        /// 文件上传时间
        /// </summary>
        public string UploadTime
        {
            get { return this.m_UploadTime; }
            set { this.m_UploadTime = value; }
        }
    }
}
