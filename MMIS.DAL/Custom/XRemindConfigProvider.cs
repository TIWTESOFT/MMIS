using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;

namespace MMIS.DAL
{
    public partial class XRemindConfigProvider
    {
        public bool SaveRemindConfig(XRemindConfigInfo remindConfigInfo,
            IList<XUsersInfo> usersInfo, IList<XRoleInfo> roleInfos)
        {
            string sql = string.Empty;
            sql += "DELETE FROM RemindRoles WHERE ConfigId='" + remindConfigInfo.RID + "';";
            sql += "DELETE FROM RemindUsers WHERE ConfigId='" + remindConfigInfo.RID + "';";

            foreach (XUsersInfo userInfo in usersInfo)
            {
                sql += "INSERT INTO RemindUsers(RID,ConfigId,UserId)VALUES(NEWID(),'" +
                    remindConfigInfo.RID + "','" + userInfo.RID + "');";
            }

            foreach (XRoleInfo roleInfo in roleInfos)
            {
                sql += "INSERT INTO RemindRoles(RID,ConfigId,RoleId)VALUES(NEWID(),'" +
                    remindConfigInfo.RID + "','" + roleInfo.RID + "');";
            }

            return this.m_DataAccess.ExecuteNonQueryByTrans(sql) > 0;
        }
    }
}
