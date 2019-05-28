using MMIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.DAL
{
    public partial class XUseUserDeptProvider
    {
        /// <summary>
        /// 获取用户部门集合
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetUserDepts(string userId)
        {
            string sql = "SELECT * FROM " + this.TableName + " WHERE UserId='{0}'";
            sql = string.Format(sql, userId);
            return this.GetListBySql(sql);
        }

        /// <summary>
        /// 保存用户部门
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="deptInfos"></param>
        /// <returns></returns>
        public bool SaveUserDepts(string userId, IList<XUseDeptInfo> deptInfos, string operateUserId)
        {
            IList<string> sqlList = new List<string>();

            string sqlDelete = "DELETE FROM UseUserDept WHERE UserId='{0}'";
            sqlDelete = string.Format(sqlDelete, userId);
            sqlList.Add(sqlDelete);

            foreach (XUseDeptInfo deptInfo in deptInfos)
            {
                string sqlInsert = "INSERT INTO UseUserDept(RID,UserId,DeptId,InputUserId,InputTime,UpdateUserId,UpdateTime)" +
                    "values(newid(),'{0}','{1}','{2}',getdate(),'{2}',getdate())";
                sqlInsert = string.Format(sqlInsert, userId, deptInfo.ID, operateUserId);
                sqlList.Add(sqlInsert);
            }

            return this.m_DataAccess.ExecuteNonQuery(sqlList);
        }
    }
}
