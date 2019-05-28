using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.DAL
{
    public partial class XStandFilesCheckRecordProvider
    {
        protected override XModelBase InitViewModel()
        {
            return new XVStandFilesCheckRecordInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVStandFilesCheckRecordInfo info = model as XVStandFilesCheckRecordInfo;

            info.StandId = XHelper.GetString(modelRow["StandId"]);
            info.StandName = XHelper.GetString(modelRow["StandName"]);
            info.FileName = XHelper.GetString(modelRow["FileName"]);
        }

        protected override string GetInsertAfterSql(XModelBase modelInfo)
        {
            XStandFilesCheckRecordInfo recordInfo = modelInfo as XStandFilesCheckRecordInfo;

            string sql = "UPDATE StandFiles SET NextCheckDate='" + recordInfo.NextCheckDate +
                "' WHERE RID='" + recordInfo.StandFileId + "';";

            return sql;
        }

        protected override string GetUpdateAfterSql(XModelBase modelInfo)
        {
            return this.GetInsertAfterSql(modelInfo);
        }
    }
}
