using MMIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.DAL
{
    public partial class XRemindRolesProvider
    {
        /// <summary>
        /// 获取提醒角色集合
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetRemindRoles(string userId)
        {
            string sql = "SELECT * FROM " + this.TableName + " WHERE ConfigId='{0}'";
            sql = string.Format(sql, userId);
            return this.GetListBySql(sql);
        }
    }
}
