using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.DAL
{
    public partial class XUseDeptProvider
    {
        protected override bool IsGetAllOrderBy()
        {
            return false;
        }

        protected override Model.XModelBase InitViewModel()
        {
            return new XVUseDeptInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVUseDeptInfo useDeptInfo = model as XVUseDeptInfo;

            useDeptInfo.ParentName = XHelper.GetString(modelRow["ParentName"]);
        }
    }
}
