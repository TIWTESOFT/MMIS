using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.DAL
{
    public partial class XStandCheckRecordProvider
    {
        protected override XModelBase InitViewModel()
        {
            return new XVStandCheckRecordInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVStandCheckRecordInfo info = model as XVStandCheckRecordInfo;

            info.StandNo = XHelper.GetString(modelRow["StandNo"]);
            info.StandName = XHelper.GetString(modelRow["StandName"]);
        }

        protected override string GetInsertAfterSql(XModelBase modelInfo)
        {
            XStandCheckRecordInfo recordInfo = modelInfo as XStandCheckRecordInfo;

            string sql = "UPDATE Standard SET NextCheckTime='" + recordInfo.NextCheckDate +  
                "',StandStatus='送检' WHERE RID='" + recordInfo.StandId + "';";

            return sql;
        }

        protected override string GetUpdateAfterSql(XModelBase modelInfo)
        {
            return this.GetInsertAfterSql(modelInfo);
        }
    }
}
