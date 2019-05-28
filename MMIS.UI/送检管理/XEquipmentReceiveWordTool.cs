using MMIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using MMIS.BLL;
using MMIS.UI.Common;
using MMIS.Helper;
using System.Configuration;

namespace MMIS.UI
{
    public partial class XEquipmentReceiveWordTool
    {
        private static XStaffInfoBusiness m_StaffBusienss = new XStaffInfoBusiness();
        private static XFileAttachmentBusiness m_AttachBusiness = new XFileAttachmentBusiness();

        public static void FillWordValue(string fileFullName, XVEquipmentReceiveInfo receiveInfo)
        {
            Word.Application app = new Word.Application();
            app.Visible = false;

            Word.Document document = app.Documents.Open(fileFullName);

            for (int i = 1; i <= document.Bookmarks.Count; i++)
            {
                Word.Bookmark bookMark = document.Bookmarks[i];
                FillRange(document, bookMark, receiveInfo);
            }

            document.Save();
            document.Close();
            app.Quit(null, null, null);
        }

        private static void FillRange(Word.Document dct, Word.Bookmark bookMark,
            XVEquipmentReceiveInfo receiveInfo)
        {
            string userId = string.Empty;
            string userName = string.Empty;

            switch (bookMark.Name)
            {
                case "检定员":
                    userId = receiveInfo.CheckedUserId;
                    userName = receiveInfo.CheckedUserName;
                    // bookMark.Range.Text = receiveInfo.CheckedUserName;
                    break;
                case "核验员":
                    userId = receiveInfo.VerifyedUserId;
                    userName = receiveInfo.VerifyedUserName;
                    //bookMark.Range.Text = receiveInfo.VerifyedUserName;
                    break;
                case "签发员":
                    userId = receiveInfo.SignedUserId;
                    userName = receiveInfo.SignedUserName;
                    //bookMark.Range.Text = receiveInfo.SignedUserName;
                    break;
                case "收发员":
                    userId = receiveInfo.DispatchUserId;
                    userName = receiveInfo.DispatchUserName;
                    //bookMark.Range.Text = receiveInfo.DispatchUserName;
                    break;
            }

            FillRangeByReceiveInfo(dct, bookMark, userId, userName);
        }

        private static void FillRangeByReceiveInfo(Word.Document dct, Word.Bookmark bookMark,
            string userId, string userName)
        {
            if (userId == string.Empty)
            {
                return;
            }

            string signFileName = GetStaffSignFileName(userId);
            if (signFileName == string.Empty)
            {
                //如果没有下载到签名文件，则填写姓名
                bookMark.Range.Text = userName;
            }
            else
            {
                object range = bookMark.Range;

                Word.InlineShape shape = dct.InlineShapes.AddPicture(signFileName,
                    false, true, ref range);
                shape.Width = XUICommon.SystemConfigInfo.SignWidht;
                shape.Height = XUICommon.SystemConfigInfo.SignHeight;

            }
        }

        private static string GetStaffSignFileName(string userId)
        {
            string staffId = m_StaffBusienss.GetStaffIdByUserId(userId);
            if (staffId == string.Empty)
            {
                //如果为找到匹配的人员信息
                return string.Empty;
            }
            else
            {
                string fileName = Guid.NewGuid().ToString();

                string path = XCommon.TempPath;

                fileName = m_AttachBusiness.DownLoadFile(staffId,
                  path, fileName);

                return fileName;
            }
        }
    }
}
