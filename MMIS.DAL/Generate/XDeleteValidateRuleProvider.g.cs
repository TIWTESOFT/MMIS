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
    public partial class XDeleteValidateRuleProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "DeleteValidateRule";
            }
        }
        
         /// <summary>
        /// 主键
        /// </summary>
        public override string PrimaryKey
        {
            get
            {
                return "RId";
            }
        }
        
        
        protected override XModelBase InitTableModel()
        {
            return new XDeleteValidateRuleInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XDeleteValidateRuleInfo info = modelInfo as XDeleteValidateRuleInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RId"));//
            info.RId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RId"));//
            info.ValidateTableName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ValidateTableName"));//
            info.UseTableName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UseTableName"));//
            info.UseTableFieldName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UseTableFieldName"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XDeleteValidateRuleInfo info = modelInfo as XDeleteValidateRuleInfo;
            string sql="Insert Into " + this.TableName + "(RId,ValidateTableName,UseTableName,UseTableFieldName)Values('{0}','{1}','{2}','{3}')";
            sql=String.Format(sql,info.RId,info.ValidateTableName,info.UseTableName,info.UseTableFieldName);
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
            
            XDeleteValidateRuleInfo info = modelInfo as XDeleteValidateRuleInfo;
            sql="Update " + this.TableName + " Set ValidateTableName='{0}',UseTableName='{1}',UseTableFieldName='{2}' Where RId='{3}'";
            sql=string.Format(sql,info.ValidateTableName,info.UseTableName,info.UseTableFieldName,info.RId);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XDeleteValidateRuleInfo info = modelInfo as XDeleteValidateRuleInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RId,ValidateTableName,UseTableName,UseTableFieldName,OperateUserId,Operate,OperateTime,NewID) SELECT RId,ValidateTableName,UseTableName,UseTableFieldName,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RId+"'";
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
            XDeleteValidateRuleInfo info = modelInfo as XDeleteValidateRuleInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RId,ValidateTableName,UseTableName,UseTableFieldName,OperateUserId,Operate,OperateTime,NewID) SELECT RId,ValidateTableName,UseTableName,UseTableFieldName,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RId+"'";
            return sql;
        }

    }
}