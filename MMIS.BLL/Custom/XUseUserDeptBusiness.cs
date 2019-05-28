using MMIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.DAL;

namespace MMIS.BLL
{
    public partial class XUseUserDeptBusiness
    {
        /// <summary>
        /// 获取用户部门集合
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetUserDepts(string userId)
        {
            XUseUserDeptProvider provider = this.m_Provider as XUseUserDeptProvider;
            return provider.GetUserDepts(userId);
        }

        /// <summary>
        /// 保存用户部门
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="deptInfos"></param>
        /// <returns></returns>
        public bool SaveUserDepts(string userId, IList<XUseDeptInfo> deptInfos, string operateUserId)
        {
            XUseUserDeptProvider provider = this.m_Provider as XUseUserDeptProvider;
            return provider.SaveUserDepts(userId, deptInfos, operateUserId);
        }
    }
}
