using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 
    /// </summary>
    public partial class XLoginLogProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "LoginLog";
            }
        }
        
         /// <summary>
        /// 主键
        /// </summary>
        public override string PrimaryKey
        {
            get
            {
                return "ID";
            }
        }
        
        
        protected override XModelBase InitTableModel()
        {
            return new XLoginLogInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XLoginLogInfo info = modelInfo as XLoginLogInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ID"));//
            info.LoginUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "LoginUserId"));//
            info.LoginTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "LoginTime"));//
            info.ExitTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ExitTime"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XLoginLogInfo info = modelInfo as XLoginLogInfo;
            string sql="Insert Into " + this.TableName + "(ID,LoginUserId,LoginTime,ExitTime)Values('{0}','{1}','{2}','{3}')";
            sql=String.Format(sql,info.ID,info.LoginUserId,info.LoginTime,info.ExitTime);
            return sql;
        }

        
        /// <summary>
        /// 获取更新Sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetUpdateSql(XModelBase modelInfo)
        {
            string sql = String.Empty;
            
            XLoginLogInfo info = modelInfo as XLoginLogInfo;
            sql="Update " + this.TableName + " Set LoginUserId='{0}',LoginTime='{1}',ExitTime='{2}' Where ID='{3}'";
            sql=string.Format(sql,info.LoginUserId,info.LoginTime,info.ExitTime,info.ID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XLoginLogInfo info = modelInfo as XLoginLogInfo;
            string sql="Insert Into " + this.HistoryTableName + "(ID,LoginUserId,LoginTime,ExitTime,OperateUserId,Operate,OperateTime,NewID) SELECT ID,LoginUserId,LoginTime,ExitTime,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.ID+"'";
            return sql;
        }
        
        /// <summary>
        /// 获取删除时插入日志表sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        protected override string GetInsertDeleteHistory(XModelBase modelInfo, string userId)
        {
            XLoginLogInfo info = modelInfo as XLoginLogInfo;
            string sql="Insert Into " + this.HistoryTableName + "(ID,LoginUserId,LoginTime,ExitTime,OperateUserId,Operate,OperateTime,NewID) SELECT ID,LoginUserId,LoginTime,ExitTime,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.ID+"'";
            return sql;
        }

    }
}