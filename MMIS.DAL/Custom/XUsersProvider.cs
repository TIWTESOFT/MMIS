using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.DAL
{
    public partial class XUsersProvider : XProviderBase
    {
        protected override XModelBase InitViewModel()
        {
            return new XVUsersInfo();
        }

        protected override void FillRowViewInfos(Model.XModelBase model, System.Data.DataRow modelRow)
        {
            XVUsersInfo info = model as XVUsersInfo;
            info.UserTypeName = XHelper.GetString(modelRow["UserTypeName"]);
        }

        public DateTime GetServerTime()
        {
            string sql = "SELECT GETDATE() ";
            DataTable queryTable = this.m_DataAccess.GetDataTable(sql);
            if (queryTable.Rows.Count > 0)
            {
                return XHelper.GetDateTime(queryTable.Rows[0][0]);
            }
            else
            {
                return new DateTime(2000, 1, 1);
            }
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool UpdatePassword(string userId, string password)
        {
            string sql = "UPDATE "+this.TableName+" SET Password='{0}' WHERE RID='{1}'";
            sql = string.Format(sql, password, userId);
            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }

        /// <summary>
        /// 批量修改密码
        /// </summary>
        /// <param name="userIds"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool UpdatePasswordMulti(string userIds, string password)
        {
            string sql = "UPDATE " + this.TableName + " SET Password='{0}' WHERE RID IN ({1})";
            sql = string.Format(sql, password, userIds);
            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }

        protected override string ExistFieldName
        {
            get
            {
                return "UserName";
            }
        }

        public bool IsRealNameExist(string realName)
        {
            string sql = "SELECT COUNT(*) FROM "+this.TableName+" WHERE RealName='" + realName + "'";
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }
    }
}
