using MMIS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.BLL
{
    public partial class XStandardBusiness
    {
        /// <summary>
        /// 是否送检
        /// </summary>
        /// <param name="standId"></param>
        /// <returns></returns>
        public bool IsToCheck(string standId)
        {
            XStandardProvider provider = this.m_Provider as XStandardProvider;
            return provider.IsToCheck(standId);
        }
    }
}
