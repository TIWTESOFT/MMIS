using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.DAL
{
    public partial class XStaffCItemProvider
    {
        protected override Model.XModelBase InitViewModel()
        {
            return new XVStaffCItemInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVStaffCItemInfo info = model as XVStaffCItemInfo;

            info.NameCN = XHelper.GetString(modelRow["NameCN"]);
        }

        protected override string MainIdFieldName
        {
            get
            {
                return "UserId";
            }
        }
    }
}
