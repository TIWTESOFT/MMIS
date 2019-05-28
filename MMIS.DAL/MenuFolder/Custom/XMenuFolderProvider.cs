using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Model;

namespace MMIS.DAL
{
    public partial class XMenuFolderProvider
    {
        /// <summary>
        /// 获取用户的菜单Folder集合
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetUserMenuFolders(string userId)
        {
            string sql = "SELECT * FROM " + this.TableName + 
                " WHERE RID IN (SELECT Distinct FolderId FROM V_RoleMenus WHERE "+
                "RoleId IN (SELECT RoleId FROM UsersRole WHERE UserId='{0}'))";
            sql += " Order By OrderIndex asc ";
            sql = string.Format(sql, userId);
            return this.GetListBySql(sql);
        }
    }
}
