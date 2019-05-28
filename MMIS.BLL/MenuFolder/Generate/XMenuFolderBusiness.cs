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
    public partial class XMenuFolderBusiness : XBusinessBase
    {
        private XMenuFolderProvider m_MenuFolderProvider;

        public XMenuFolderBusiness()
        {
            this.m_Provider = XFactoryManager.CreateFactory().GetMenuFolderProvider();
            this.m_MenuFolderProvider = this.m_Provider as XMenuFolderProvider;
        }
    }
}