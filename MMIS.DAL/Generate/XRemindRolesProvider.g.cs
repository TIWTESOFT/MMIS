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
    public partial class XRemindRolesProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "RemindRoles";
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
            return new XRemindRolesInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XRemindRolesInfo info = modelInfo as XRemindRolesInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.ConfigId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ConfigId"));//
            info.RoleId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RoleId"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XRemindRolesInfo info = modelInfo as XRemindRolesInfo;
            string sql="Insert Into " + this.TableName + "(RID,ConfigId,RoleId)Values('{0}','{1}','{2}')";
            sql=String.Format(sql,info.RID,info.ConfigId,info.RoleId);
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
            
            XRemindRolesInfo info = modelInfo as XRemindRolesInfo;
            sql="Update " + this.TableName + " Set ConfigId='{0}',RoleId='{1}' Where RID='{2}'";
            sql=string.Format(sql,info.ConfigId,info.RoleId,info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XRemindRolesInfo info = modelInfo as XRemindRolesInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,ConfigId,RoleId,OperateUserId,Operate,OperateTime,NewID) SELECT RID,ConfigId,RoleId,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XRemindRolesInfo info = modelInfo as XRemindRolesInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,ConfigId,RoleId,OperateUserId,Operate,OperateTime,NewID) SELECT RID,ConfigId,RoleId,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}