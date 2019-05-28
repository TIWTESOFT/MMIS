using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Model;

namespace MMIS.DAL
{
    public partial class XUsersRoleProvider
    {

        /// <summary>
        /// 获取用户角色集合
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetUserRoles(string userId)
        {
            string sql = "SELECT * FROM " + this.TableName + " WHERE UserId='{0}'";
            sql = string.Format(sql, userId);
            return this.GetListBySql(sql);
        }

        /// <summary>
        /// 保存用户角色
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="roleInfos"></param>
        /// <returns></returns>
        public bool SaveUserRoles(string userId, IList<XRoleInfo> roleInfos, string operateUserId)
        {
            IList<string> sqlList = new List<string>();

            string sqlDelete = "DELETE FROM UsersRole WHERE UserId='{0}'";
            sqlDelete = string.Format(sqlDelete, userId);
            sqlList.Add(sqlDelete);

            foreach (XRoleInfo roleInfo in roleInfos)
            {
                string sqlInsert = "INSERT INTO UsersRole(RID,UserId,RoleId,InputUserId,InputTime,UpdateUserId,UpdateTime)"+
                    "values(newid(),'{0}','{1}','{2}',getdate(),'{2}',getdate())";
                sqlInsert = string.Format(sqlInsert, userId, roleInfo.ID, operateUserId);
                sqlList.Add(sqlInsert);
            }

            return this.m_DataAccess.ExecuteNonQuery(sqlList);
        }
    }
}
