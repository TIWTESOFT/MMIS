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
    public partial class XUseOperateLogProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "UseOperateLog";
            }
        }
        
         /// <summary>
        /// 主键
        /// </summary>
        public override string PrimaryKey
        {
            get
            {
                return "RID";
            }
        }
        
        
        protected override XModelBase InitTableModel()
        {
            return new XUseOperateLogInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XUseOperateLogInfo info = modelInfo as XUseOperateLogInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.LogName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "LogName"));//
            info.LogDescription=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "LogDescription"));//
            info.LogTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "LogTime"));//
            info.UserName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UserName"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XUseOperateLogInfo info = modelInfo as XUseOperateLogInfo;
            string sql="Insert Into " + this.TableName + "(RID,LogName,LogDescription,LogTime,UserName)Values('{0}','{1}','{2}','{3}','{4}')";
            sql=String.Format(sql,info.RID,info.LogName,info.LogDescription,info.LogTime,info.UserName);
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
            
            XUseOperateLogInfo info = modelInfo as XUseOperateLogInfo;
            sql="Update " + this.TableName + " Set LogName='{0}',LogDescription='{1}',LogTime='{2}',UserName='{3}' Where RID='{4}'";
            sql=string.Format(sql,info.LogName,info.LogDescription,info.LogTime,info.UserName,info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XUseOperateLogInfo info = modelInfo as XUseOperateLogInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,LogName,LogDescription,LogTime,UserName,OperateUserId,Operate,OperateTime,NewID) SELECT RID,LogName,LogDescription,LogTime,UserName,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XUseOperateLogInfo info = modelInfo as XUseOperateLogInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,LogName,LogDescription,LogTime,UserName,OperateUserId,Operate,OperateTime,NewID) SELECT RID,LogName,LogDescription,LogTime,UserName,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}