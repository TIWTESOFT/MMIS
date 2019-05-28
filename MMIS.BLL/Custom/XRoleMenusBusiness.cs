using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Model;
using MMIS.FolderModel;
using MMIS.DAL;

namespace MMIS.BLL
{
    public partial class XRoleMenusBusiness
    {
          /// <summary>
        /// 获取角色菜单集合
        /// </summary>
        /// <param name="roleCode"></param>
        /// <returns></returns>
        public IList<XModelBase> GetRoleMenus(string roleCode)
        {
            XRoleMenusProvider provider = this.m_Provider as XRoleMenusProvider;
            return provider.GetRoleMenus(roleCode);
        }

        /// <summary>
        /// 保存角色菜单
        /// </summary>
        /// <param name="roleCode"></param>
        /// <param name="menuInfos"></param>
        /// <returns></returns>
        public bool SaveRoleMenus(string roleCode, IList<XMenuInfo> menuInfos, string operateUserId)
        {
            XRoleMenusProvider provider = this.m_Provider as XRoleMenusProvider;
            return provider.SaveRoleMenus(roleCode, menuInfos, operateUserId);
        }
    }
}
