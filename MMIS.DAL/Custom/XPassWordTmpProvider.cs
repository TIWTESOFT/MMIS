using MMIS.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;

namespace MMIS.DAL
{
    public partial class XPassWordTmpProvider
    {
        /// <summary>
        /// 临时密码是否有效
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool IsTempPasswordCanUse(string userId, string password)
        {
            string sql = "SELECT COUNT(*) FROM PassWordTmp WHERE getdate() " +
                "BETWEEN UseStartTime and UseEndTime AND UserId='{0}' AND Password='{1}' AND IsCheck=1";
            sql = string.Format(sql, userId, password);
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }

        public XModelBase GetTempPasswordInfo(string userId, string password)
        {
            string sql = "SELECT TOP 1 * FROM PassWordTmp WHERE getdate() " +
                          "BETWEEN UseStartTime and UseEndTime AND UserId='{0}' AND Password='{1}' AND IsCheck=1";
            sql = string.Format(sql, userId, password);
            IList<XModelBase> models = this.GetListBySql(sql);
            if (models.Count > 0)
            {
                return models[0];
            }
            else
            {
                return null;
            }
        }

        public XModelBase GetValidTempPasswordInfo(string userId)
        {
            string sql = "SELECT TOP 1 * FROM PassWordTmp WHERE getdate() " +
                          "BETWEEN UseStartTime and UseEndTime AND UserId='{0}' AND IsCheck=1";
            sql = string.Format(sql, userId);
            IList<XModelBase> models = this.GetListBySql(sql);
            if (models.Count > 0)
            {
                return models[0];
            }
            else
            {
                return null;
            }
        }

        public XModelBase GetTempPasswordInfo(string userId)
        {
            string sql = "SELECT TOP 1 * FROM PassWordTmp WHERE getdate() " +
                          "BETWEEN UseStartTime and UseEndTime AND UserId='{0}' ";
            sql = string.Format(sql, userId);
            IList<XModelBase> models = this.GetListBySql(sql);
            if (models.Count > 0)
            {
                return models[0];
            }
            else
            {
                return null;
            }
        }
    }
}
