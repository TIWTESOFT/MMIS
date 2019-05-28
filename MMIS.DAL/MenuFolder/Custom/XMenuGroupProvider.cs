using System;
using System.Collections.Generic;
using System.Text;
using MMIS.FolderModel;
using MMIS.Model;

namespace MMIS.DAL
{
    public partial class XMenuGroupProvider
    {
        /// <summary>
        /// 获取Folder下的菜单分组
        /// </summary>
        /// <param name="folderInfo">folderInfo</param>
        /// <returns></returns>
        public IList<XModelBase> GetGroupInfos(XMenuFolderInfo folderInfo)
        {
            string sql = "SELECT * FROM MenuGroup WHERE FolderId='{0}' Order By OrderIndex ";
            sql = string.Format(sql, folderInfo.ID);
            return this.GetListBySql(sql);
        }

        /// <summary>
        /// 获取用户的菜单Group集合
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetUserMenuGroups(string userId,string folderId)
        {
            string sql = "SELECT * FROM " + this.TableName + " WHERE RID IN (SELECT Distinct GroupId FROM V_RoleMenus WHERE RoleId IN (SELECT RoleId FROM UsersRole WHERE UserId='{0}') AND FolderId='{1}')";
            sql += " order by OrderIndex asc ";
            sql = string.Format(sql, userId, folderId);
            return this.GetListBySql(sql);
        }
    }
}
