using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Model;
using MMIS.FolderModel;

namespace MMIS.DAL
{
    public partial class XMenuProvider
    {

        /// <summary>
        /// 获取分组下的菜单集合
        /// </summary>
        /// <param name="groupInfo"></param>
        /// <returns></returns>
        public IList<XModelBase> GetMenuInfos(XMenuGroupInfo groupInfo)
        {
            string sql = "SELECT * FROM Menu WHERE GroupId='{0}' Order By OrderIndex";
            sql = string.Format(sql, groupInfo.ID);
            return this.GetListBySql(sql);
        }

        /// <summary>
        /// 获取用户的菜单
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetUserMenus(string userId, string groupId)
        {
            string sql = "SELECT * FROM " + this.TableName + " WHERE RID IN (SELECT DISTINCT MenuId FROM V_RoleMenus WHERE RoleId IN (SELECT RoleId FROM UsersRole WHERE UserId='{0}') AND GroupId='{1}')";
            sql += " order by orderIndex asc ";
            sql = string.Format(sql, userId, groupId);

            return this.GetListBySql(sql);
        }
    }
}
