using MMIS.Helper;
using MMIS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.DAL
{
    public partial class XPassWord4FileProvider
    {

        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected string GetInsertCustomSql(XModelBase modelInfo)
        {
            XPassWord4FileInfo info = modelInfo as XPassWord4FileInfo;
            string sql = "Insert Into " + this.TableName + "(RID,PassWordTmpId,PassWord,DownLoadUserId,FileID,DownTime,Remark)Values('{0}','{1}','{2}','{3}','{4}',{5},'{6}')";
            sql = String.Format(sql, info.RID, info.PassWordTmpId, info.PassWord, info.DownLoadUserId, info.FileID, "getdate()", info.Remark);
            return sql;
        }

        public override bool Insert(XModelBase modelInfo)
        {
            string sqlInsert = this.GetInsertCustomSql(modelInfo);

            return this.m_DataAccess.ExecuteNonQuery(sqlInsert) > 0;
        }

        protected override XModelBase InitViewModel()
        {
            return new XVPassWord4FileInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVPassWord4FileInfo info = model as XVPassWord4FileInfo;

            info.UserName = XHelper.GetString(modelRow["UserName"]);
            info.RealName = XHelper.GetString(modelRow["RealName"]);
            info.PassDesc = XHelper.GetString(modelRow["PassDesc"]);
            info.FileName = XHelper.GetString(modelRow["FileName"]);
        }
    }
}
