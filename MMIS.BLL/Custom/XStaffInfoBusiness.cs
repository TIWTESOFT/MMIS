using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.DAL;

namespace MMIS.BLL
{
    public partial class XStaffInfoBusiness
    {
        /// <summary>
        /// 用户是否已关联其他人员信息
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public bool IsUserIdHaveStaff(string userid)
        {
            XStaffInfoProvider provider = this.m_Provider as XStaffInfoProvider;
            return provider.IsUserIdHaveStaff(userid);
        }

        /// <summary>
        /// 根据用户ID获取人员ID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string GetStaffIdByUserId(string userId)
        {
            XStaffInfoProvider provider = this.m_Provider as XStaffInfoProvider;
            return provider.GetStaffIdByUserId(userId);
        }
    }
}
