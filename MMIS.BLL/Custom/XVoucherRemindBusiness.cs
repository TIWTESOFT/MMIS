using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MMIS.DAL;

namespace MMIS.BLL
{
    public partial class XVoucherRemindBusiness : XBusinessBase
    {
        public XVoucherRemindBusiness()
        {
            this.m_Provider = XFactoryManager.CreateFactory().GetVoucherRemindProvider();
        }

        /// <summary>
        /// 获取单据提醒信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataTable GetVoucherRemind(string userId)
        {
            XVoucherRemindProvider provider = this.m_Provider as XVoucherRemindProvider;
            return provider.GetVoucherRemind(userId);
        }
    }
}
