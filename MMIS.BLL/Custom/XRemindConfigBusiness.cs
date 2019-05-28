using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.DAL;
using MMIS.Model;

namespace MMIS.BLL
{
    public partial class XRemindConfigBusiness
    {
        public bool SaveRemindConfig(XRemindConfigInfo remindConfigInfo,
             IList<XUsersInfo> usersInfo, IList<XRoleInfo> roleInfos)
        {
            XRemindConfigProvider provider = this.m_Provider as XRemindConfigProvider;

            return provider.SaveRemindConfig(remindConfigInfo, usersInfo, roleInfos);
        }
    }
}
