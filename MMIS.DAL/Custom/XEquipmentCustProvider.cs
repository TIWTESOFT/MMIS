using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.DAL
{
    public partial class XEquipmentCustProvider
    {
        protected override Model.XModelBase InitViewModel()
        {
            return new XVEquipmentCustInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVEquipmentCustInfo info = model as XVEquipmentCustInfo;
            info.CustTypeNameCN = XHelper.GetString(modelRow["CustTypeNameCN"]);
        }




    }
}
