using MMIS.Helper;
using MMIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.DAL
{
    public partial class XEquipmentDetectProvider
    {
        protected override XModelBase InitViewModel()
        {
            return new XVEquipmentDetectInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVEquipmentDetectInfo info = model as XVEquipmentDetectInfo;

            info.EquipmentType = XHelper.GetString(modelRow["EquipmentType"]);
            info.EquipmentCustId = XHelper.GetString(modelRow["EquipmentCustId"]);
            info.EquipmentName = XHelper.GetString(modelRow["EquipmentName"]);
            info.FactoryNo = XHelper.GetString(modelRow["FactoryNo"]);
            info.Spec = XHelper.GetString(modelRow["Spec"]);
            info.Model = XHelper.GetString(modelRow["Model"]);
            info.FactoryName = XHelper.GetString(modelRow["FactoryName"]);
            info.SourceTime = XHelper.GetString(modelRow["SourceTime"]);
            info.UseTime = XHelper.GetString(modelRow["UseTime"]);
            info.SourceCustId = XHelper.GetString(modelRow["SourceCustId"]);
            info.SourceTypeId = XHelper.GetString(modelRow["SourceTypeId"]);
            info.EquipmentStatusId = XHelper.GetString(modelRow["EquipmentStatusId"]);
            info.EquipmentNo = XHelper.GetString(modelRow["EquipmentNo"]);
            info.CustName = XHelper.GetString(modelRow["CustName"]);
            info.Quanlity = XHelper.GetDouble(modelRow["Quanlity"]);
            info.LastCheckDate = XHelper.GetString(modelRow["LastCheckDate"]);
            info.EquipmentDesc = XHelper.GetString(modelRow["EquipmentDesc"]);
            info.DetectUserName = XHelper.GetString(modelRow["DetectUserName"]);
        }
    }
}
