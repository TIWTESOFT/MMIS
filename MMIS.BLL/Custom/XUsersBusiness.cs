using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.DAL;

namespace MMIS.BLL
{
    public partial class XUsersBusiness
    {
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool UpdatePassword(string userId, string password)
        {
            XUsersProvider provider = this.m_Provider as XUsersProvider;
            return provider.UpdatePassword(userId, password);
        }


        public DateTime GetServerTime()
        {
            XUsersProvider provider = this.m_Provider as XUsersProvider;
            return provider.GetServerTime();
        }

        /// <summary>
        /// 批量修改密码
        /// </summary>
        /// <param name="userIds"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool UpdatePasswordMulti(string userIds, string password)
        {
            XUsersProvider provider = this.m_Provider as XUsersProvider;
            return provider.UpdatePasswordMulti(userIds, password);
        }

        public bool IsRealNameExist(string realName)
        {
            XUsersProvider provider = this.m_Provider as XUsersProvider;
            return provider.IsRealNameExist(realName);
        }
    }
}
