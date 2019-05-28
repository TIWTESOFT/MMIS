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
    public partial class XMenuBusiness : XBusinessBase
    {
        private XMenuProvider m_MenuProvider;

        public XMenuBusiness()
        {
            this.m_Provider = XFactoryManager.CreateFactory().GetMenuProvider();
            this.m_MenuProvider = this.m_Provider as XMenuProvider;
        }
    }
}