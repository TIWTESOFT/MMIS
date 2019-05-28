using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.DAL
{
    public partial class XStandCodeEquipmentProvider
    {
        protected override XModelBase InitViewModel()
        {
            return new XVStandCodeEquipmentInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVStandCodeEquipmentInfo info = model as XVStandCodeEquipmentInfo;
            info.EquipStatus = XHelper.GetString(modelRow["EquipStatus"]);
        }
    }
}
