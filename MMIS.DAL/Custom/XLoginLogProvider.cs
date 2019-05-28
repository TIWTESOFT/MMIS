using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.DAL
{
    public partial class XLoginLogProvider
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool Login(string id, string userId)
        {
            string sql = "INSERT INTO " + this.TableName + "(ID,LoginUserId,LoginTime)values('{0}','{1}',getdate())";
            sql = string.Format(sql, id, userId);
            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Exit(string id)
        {
            string sql = "UPDATE " + this.TableName + " SET ExitTime=getdate() WHERE ID='{0}'";
            sql = string.Format(sql, id);
            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }
    }
}
