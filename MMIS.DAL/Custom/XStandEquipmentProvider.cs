using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.DAL
{
    public partial class XStandEquipmentProvider
    {
        protected override XModelBase InitViewModel()
        {
            return new XVStandEquipmentInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVStandEquipmentInfo info = model as XVStandEquipmentInfo;

            info.EquipmentStatus = XHelper.GetString(modelRow["EquipmentStatus"]);
            info.StandName = XHelper.GetString(modelRow["StandName"]);
        }
    }
}
