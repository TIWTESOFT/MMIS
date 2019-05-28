using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.DAL
{
    public partial class XStaffCertificateProvider
    {
        protected override bool IsGetAllOrderBy()
        {
            return false;
        }

        protected override Model.XModelBase InitViewModel()
        {
            return new XVStaffCertificateInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVStaffCertificateInfo info = model as XVStaffCertificateInfo;

            info.UserName = XHelper.GetString(modelRow["UserName"]);
        }
    }
}
