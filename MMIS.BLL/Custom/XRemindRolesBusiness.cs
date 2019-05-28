using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.DAL;
using MMIS.Model;

namespace MMIS.BLL
{
    public partial class XRemindRolesBusiness
    {
        /// <summary>
        /// 获取提醒角色集合
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetRemindRoles(string userId)
        {
            XRemindRolesProvider provider = this.m_Provider as XRemindRolesProvider;
            return provider.GetRemindRoles(userId);
        }
    }
}
