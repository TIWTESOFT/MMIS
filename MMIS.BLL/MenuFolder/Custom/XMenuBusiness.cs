using System;
using System.Collections.Generic;
using System.Text;
using MMIS.DAL;
using System.Data;
using MMIS.Model;
using MMIS.FolderModel;

namespace MMIS.BLL
{
    /// <summary>
    /// 
    /// </summary>
    public partial class XMenuBusiness : XBusinessBase
    {

        /// <summary>
        /// 获取分组下的菜单集合
        /// </summary>
        /// <param name="groupInfo"></param>
        /// <returns></returns>
        public IList<XModelBase> GetMenuInfos(XMenuGroupInfo groupInfo)
        {
            return this.m_MenuProvider.GetMenuInfos(groupInfo);
        }


        /// <summary>
        /// 自定义删除校验
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetValidateDeleteCustom(XModelBase modelInfo)
        {
            string validateInfo = string.Empty;
            XMenuInfo menu = modelInfo as XMenuInfo;
            if (menu == null)
            {
                return this.GetNotRightType();
            }
            return string.Empty;
        }

        /// <summary>
        /// 自定义新增校验
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetValidateInsertCustom(XModelBase modelInfo)
        {
            string validateInfo = string.Empty;
            XMenuInfo menu = modelInfo as XMenuInfo;
            if (menu == null)
            {
                return this.GetNotRightType();
            }
            return string.Empty;
        }

        /// <summary>
        /// 自定义修改校验
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetValidateUpdateCustom(XModelBase modelInfo)
        {
            string validateInfo = string.Empty;
            XMenuInfo menu = modelInfo as XMenuInfo;
            if (menu == null)
            {
                return this.GetNotRightType();
            }
            return string.Empty;
        }

        /// <summary>
        /// 获取用户的菜单
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetUserMenus(string userId, string groupId)
        {
            XMenuProvider provider = this.m_Provider as XMenuProvider;
            return provider.GetUserMenus(userId, groupId);
        }
    }
}