using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;
using System.Data.Common;
using System.Data;
using System.IO;

namespace MMIS.DAL
{
    public partial class XStandFilesProvider
    {
        protected override MMIS.Model.XModelBase InitViewModel()
        {
            return new XVStandFilesInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVStandFilesInfo standInfo = model as XVStandFilesInfo;

            standInfo.StandName = XHelper.GetString(modelRow["StandName"]);
        }

       

    }
}
