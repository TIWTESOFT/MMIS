using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.DAL;

namespace MMIS.BLL
{
    public partial class XLoginLogBusiness : XBusinessBase
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool Login(string id, string userId)
        {
            XLoginLogProvider provider = this.m_Provider as XLoginLogProvider;
            return provider.Login(id, userId);
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Exit(string id)
        {
            XLoginLogProvider provider = this.m_Provider as XLoginLogProvider;
            return provider.Exit(id);
        }
    }
}
