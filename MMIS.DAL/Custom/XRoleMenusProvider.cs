using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Model;
using MMIS.FolderModel;

namespace MMIS.DAL
{
    public partial class XRoleMenusProvider
    {
        /// <summary>
        /// 获取角色菜单集合
        /// </summary>
        /// <param name="roleCode"></param>
        /// <returns></returns>
        public IList<XModelBase> GetRoleMenus(string roleCode)
        {
            string sql = "SELECT * FROM " + this.TableName + " WHERE RoleId='{0}'";
            sql = string.Format(sql, roleCode);
            return this.GetListBySql(sql);
        }

        /// <summary>
        /// 保存角色菜单
        /// </summary>
        /// <param name="roleCode"></param>
        /// <param name="menuInfos"></param>
        /// <returns></returns>
        public bool SaveRoleMenus(string roleCode, IList<XMenuInfo> menuInfos, string operateUserId)
        {
            IList<string> sqlList = new List<string>();

            string sqlDelete = "DELETE FROM RoleMenus WHERE RoleId='{0}'";
            sqlDelete = string.Format(sqlDelete, roleCode);
            sqlList.Add(sqlDelete);

            foreach (XMenuInfo menuInfo in menuInfos)
            {
                string sqlInsert = "INSERT INTO RoleMenus(RID,RoleId,MenuId,InputUserId,InputTime,UpdateUserId,UpdateTime)" +
                    "values(newid(),'{0}','{1}','{2}',getdate(),'{2}',getdate())";
                sqlInsert = string.Format(sqlInsert, roleCode, menuInfo.ID, operateUserId);
                sqlList.Add(sqlInsert);
            }

            return this.m_DataAccess.ExecuteNonQuery(sqlList);
        }
    }
}
