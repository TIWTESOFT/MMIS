using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Model;
using MMIS.DAL;

namespace MMIS.BLL
{
    public partial class XUsersRoleBusiness
    {
        /// <summary>
        /// 获取用户角色集合
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetUserRoles(string userId)
        {
            XUsersRoleProvider provider = this.m_Provider as XUsersRoleProvider;
            return provider.GetUserRoles(userId);
        }

        /// <summary>
        /// 保存用户角色
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roleInfos"></param>
        /// <returns></returns>
        public bool SaveUserRoles(string userId, IList<XRoleInfo> roleInfos, string operateUserId)
        {
            XUsersRoleProvider provider = this.m_Provider as XUsersRoleProvider;
            return provider.SaveUserRoles(userId, roleInfos, operateUserId);
        }
    }
}
