using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.DAL;

namespace MMIS.BLL
{
    public partial class XEquipmentPDFReportBusiness
    {
        /// <summary>
        /// 是否存在附件
        /// </summary>
        /// <param name="fileId"></param>
        /// <returns></returns>
        public bool IsFileExist(string fileId)
        {
            XEquipmentPDFReportProvider provider = this.m_Provider as XEquipmentPDFReportProvider;
            return provider.IsFileExist(fileId);
        }

        public string DownLoadFile(string fileId, string filePath, string fileName)
        {
            XEquipmentPDFReportProvider provider = this.m_Provider as XEquipmentPDFReportProvider;
            return provider.DownLoadFile(fileId, filePath, fileName);
        }
    }
}
