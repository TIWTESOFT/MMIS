using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.DAL
{
    public partial class XStandEquipmentCheckRecordProvider
    {
        protected override XModelBase InitViewModel()
        {
            return new XVStandEquipmentCheckRecordInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVStandEquipmentCheckRecordInfo info = model as XVStandEquipmentCheckRecordInfo;

            info.EquipmentName=XHelper.GetString(modelRow["EquipmentName"]);
            info.StandName = XHelper.GetString(modelRow["StandName"]);
            info.StandId = XHelper.GetString(modelRow["StandId"]);
        }

        protected override string GetInsertAfterSql(XModelBase modelInfo)
        {
            XStandEquipmentCheckRecordInfo recordInfo = modelInfo as XStandEquipmentCheckRecordInfo;

            string sql = "UPDATE StandEquipment SET NextCheckDate='" + recordInfo.NextCheckDate +
                "',EquipmentStatusId='送检' WHERE RID='" + recordInfo.StandEqupimentId + "';";

            return sql;
        }

        protected override string GetUpdateAfterSql(XModelBase modelInfo)
        {
            return this.GetInsertAfterSql(modelInfo);
        }
    }
}
