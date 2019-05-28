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
    public partial class XMenuGroupBusiness : XBusinessBase
    {
        /// <summary>
        /// 获取Folder下的菜单分组
        /// </summary>
        /// <param name="folderInfo">folderInfo</param>
        /// <returns></returns>
        public IList<XModelBase> GetGroupInfos(XMenuFolderInfo folderInfo)
        {
            return this.m_MenuGroupProvider.GetGroupInfos(folderInfo);
        }

        /// <summary>
        /// 自定义删除校验
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetValidateDeleteCustom(XModelBase modelInfo)
        {
            string validateInfo = string.Empty;
            XMenuGroupInfo menugroup = modelInfo as XMenuGroupInfo;
            if (menugroup == null)
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
            XMenuGroupInfo menugroup = modelInfo as XMenuGroupInfo;
            if (menugroup == null)
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
            XMenuGroupInfo menugroup = modelInfo as XMenuGroupInfo;
            if (menugroup == null)
            {
                return this.GetNotRightType();
            }
            return string.Empty;
        }

        /// <summary>
        /// 获取用户的菜单Group集合
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetUserMenuGroups(string userId, string folderId)
        {
            XMenuGroupProvider menuGroupProvider = this.m_Provider as XMenuGroupProvider;
            return menuGroupProvider.GetUserMenuGroups(userId, folderId);
        }
    }
}