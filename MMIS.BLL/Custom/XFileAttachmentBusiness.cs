using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.DAL;

namespace MMIS.BLL
{
    public partial class XFileAttachmentBusiness
    {
        public bool InsertFile(string id, string fileId, string fileName, string userId)
        {
            XFileAttachmentProvider provider = this.m_Provider as XFileAttachmentProvider;
            return provider.InsertFile(id, fileId, fileName, userId);
        }

        /// <summary>
        /// 是否存在附件
        /// </summary>
        /// <param name="fileId"></param>
        /// <returns></returns>
        public bool IsFileExist(string fileId)
        {
            XFileAttachmentProvider provider = this.m_Provider as XFileAttachmentProvider;
            return provider.IsFileExist(fileId);
        }

        public string DownloadFile(string fileId, string path)
        {
            XFileAttachmentProvider provider = this.m_Provider as XFileAttachmentProvider;
            return provider.DownloadFile(fileId, path);
        }

        public string DownLoadFile(string fileId, string filePath, string fileName)
        {
            XFileAttachmentProvider provider = this.m_Provider as XFileAttachmentProvider;
            return provider.DownLoadFile(fileId, filePath, fileName);
        }
    }
}
