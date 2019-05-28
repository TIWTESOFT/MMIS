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
    public partial class XMenuFolderBusiness : XBusinessBase
    {


        /// <summary>
        /// 自定义删除校验
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetValidateDeleteCustom(XModelBase modelInfo)
        {
            string validateInfo = string.Empty;
            XMenuFolderInfo menufolder = modelInfo as XMenuFolderInfo;
            if (menufolder == null)
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
            XMenuFolderInfo menufolder = modelInfo as XMenuFolderInfo;
            if (menufolder == null)
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
            XMenuFolderInfo menufolder = modelInfo as XMenuFolderInfo;
            if (menufolder == null)
            {
                return this.GetNotRightType();
            }
            return string.Empty;
        }

        /// <summary>
        /// 获取用户的菜单Folder集合
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetUserMenuFolders(string userId)
        {
            XMenuFolderProvider provider = this.m_Provider as XMenuFolderProvider;
            return provider.GetUserMenuFolders(userId);
        }
    }
}