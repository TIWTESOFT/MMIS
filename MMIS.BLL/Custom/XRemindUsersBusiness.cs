using MMIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.DAL;

namespace MMIS.BLL
{
    public partial class XRemindUsersBusiness
    {
        /// <summary>
        /// 获取提醒用户集合
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetRemindUsers(string userId)
        {
            XRemindUsersProvider provider = this.m_Provider as XRemindUsersProvider;
            return provider.GetRemindUsers(userId);
        }
    }
}
