using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.BLL;
using MMIS.Model;
using MMIS.Helper;
using System.IO;

namespace MMIS.UI.Common
{
    public class XFilePreviewTool
    {
        private static XFileAttachmentBusiness m_FileAttachBusiness = new XFileAttachmentBusiness();

        public static bool Preview(string fileId)
        {
            string where = " and FileId='" + fileId + "'";

            IList<XModelBase> fileAttachInfos = m_FileAttachBusiness.QueryByWhere(where);

            if (fileAttachInfos.Count == 0)
            {
                XMessageBox.ShowError("未找到附件，无法预览！");
                return false;
            }

            XFileAttachmentInfo fileInfo = fileAttachInfos[0] as XFileAttachmentInfo;

            string[] imageTypes = new string[] { ".png", ".jpg", ".jpeg" };
            string[] officeTypes = new string[] { ".doc", ".docx", ".xls", ".xlsx" };

            if (!imageTypes.Contains(fileInfo.AtchType) &&
                !officeTypes.Contains(fileInfo.AtchType))
            {
                XMessageBox.ShowError("不支持预览格式为[" + fileInfo.AtchType + "]的文件！");
                return false;
            }

            string path = XCommon.TempPath;
            string fileName = Guid.NewGuid().ToString();
            fileName = m_FileAttachBusiness.DownLoadFile(fileId, path, fileName);

            if (imageTypes.Contains(fileInfo.AtchType))
            {
                //如果是图片
                frmImagePreview frm = new frmImagePreview(fileName);
                frm.ShowDialog();
            }
            else
            {
                frmOfficeFilePreview frm = new frmOfficeFilePreview(fileName);
                frm.ShowDialog();
            }

            if (File.Exists(fileName))
            {
                try
                {
                    File.Delete(fileName);
                }
                catch (Exception ex)
                {
                    XErrorLogTool.WriteLog(ex.ToString());
                }
            }

            return true;
        }
    }
}
