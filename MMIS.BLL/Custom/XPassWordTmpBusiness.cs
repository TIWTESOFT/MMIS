using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.DAL;
using MMIS.Model;

namespace MMIS.BLL
{
    public partial class XPassWordTmpBusiness
    {
        /// <summary>
        /// 临时密码是否有效
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool IsTempPasswordCanUse(string userId, string password)
        {
            XPassWordTmpProvider provider = this.m_Provider as XPassWordTmpProvider;
            return provider.IsTempPasswordCanUse(userId, password);
        }

        public XModelBase GetTempPasswordInfo(string userId, string password)
        {
            XPassWordTmpProvider provider = this.m_Provider as XPassWordTmpProvider;
            return provider.GetTempPasswordInfo(userId, password);
        }

        public XModelBase GetValidTempPasswordInfo(string userId)
        {
            XPassWordTmpProvider provider = this.m_Provider as XPassWordTmpProvider;
            return provider.GetValidTempPasswordInfo(userId);
        }

        public XModelBase GetTempPasswordInfo(string userId)
        {
            XPassWordTmpProvider provider = this.m_Provider as XPassWordTmpProvider;
            return provider.GetTempPasswordInfo(userId);
        }
    }
}
