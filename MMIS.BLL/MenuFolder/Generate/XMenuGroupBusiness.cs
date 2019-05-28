using System;
using System.Collections.Generic;
using System.Text;
using MMIS.DAL;
using System.Data;
using MMIS.Model;

namespace MMIS.BLL
{
    /// <summary>
    /// 
    /// </summary>
    public partial class XMenuGroupBusiness : XBusinessBase
    {
        private XMenuGroupProvider m_MenuGroupProvider;

        public XMenuGroupBusiness()
        {
            this.m_Provider = XFactoryManager.CreateFactory().GetMenuGroupProvider();
            this.m_MenuGroupProvider = this.m_Provider as XMenuGroupProvider;
        }
    }
}