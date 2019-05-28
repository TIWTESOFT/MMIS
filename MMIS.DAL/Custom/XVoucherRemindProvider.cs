using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace MMIS.DAL
{
    public partial class XVoucherRemindProvider : XProviderBase
    {
        public override string ViewName
        {
            get
            {
                return "V_VoucherRemind";
            }
        }

        /// <summary>
        /// 获取单据提醒信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataTable GetVoucherRemind(string userId)
        {
            string sql = "SELECT * FROM " + this.ViewName + " WHERE RemindType IN (";
            sql += "SELECT ConfigType FROM V_RemindUsers WHERE UserId='{0}' ";
            sql += "UNION ";
            sql += "SELECT ConfigType FROM V_RemindRoles WHERE RoleId IN (SELECT RoleID FROM UsersRole WHERE UserID='{0}' ))";
            sql = string.Format(sql, userId);
            return this.m_DataAccess.GetDataTable(sql);
        }
    }
}
