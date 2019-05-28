using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.DAL
{
    public partial class XFileListProvider
    {
        protected override XModelBase InitViewModel()
        {
            return new XVFileListInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVFileListInfo fileListInfo = model as XVFileListInfo;

            fileListInfo.FileType = XHelper.GetString(modelRow["FileType"]);
            fileListInfo.FileLevel = XHelper.GetString(modelRow["FileLevel"]);
            fileListInfo.FileState = XHelper.GetString(modelRow["FileState"]);
            fileListInfo.FolderType = XHelper.GetString(modelRow["FolderType"]);
            fileListInfo.AtchSize = XHelper.GetDouble(modelRow["AtchSize"]);
            fileListInfo.UploadTime = XHelper.GetString(modelRow["UploadTime"]);
        }

        protected override string GetDeleteAfterSql(XModelBase modelInfo)
        {
            string sql = "DELETE FROM FileAttachment WHERE FileId='{0}'";
            sql = string.Format(sql, modelInfo.ID);
            return sql;
        }

        protected override string GetDeleteAfterSql(IList<XModelBase> modelInfos)
        {
            string ids = this.GetModelIds(modelInfos);
            string sql = "DELETE FROM FileAttachment WHERE FileId IN ({0})";
            sql = string.Format(sql, ids);
            return sql;
        }
    }
}
