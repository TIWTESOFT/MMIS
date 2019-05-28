using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.DAL
{
    public partial class XMeetingProjectProvider
    {
        protected override XModelBase InitViewModel()
        {
            return new XVMeetingProjectInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVMeetingProjectInfo info = model as XVMeetingProjectInfo;

            info.DeptName = XHelper.GetString(modelRow["DeptName"]);
            info.ProjectType = XHelper.GetString(modelRow["ProjectType"]);
        }
    }
}
