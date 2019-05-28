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
    public partial class XTableDictProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "TableDict";
            }
        }
        
         /// <summary>
        /// 主键
        /// </summary>
        public override string PrimaryKey
        {
            get
            {
                return "TableName";
            }
        }
        
        
        protected override XModelBase InitTableModel()
        {
            return new XTableDictInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XTableDictInfo info = modelInfo as XTableDictInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TableName"));//
            info.TableName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TableName"));//
            info.TableDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TableDesc"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XTableDictInfo info = modelInfo as XTableDictInfo;
            string sql="Insert Into " + this.TableName + "(TableName,TableDesc)Values('{0}','{1}')";
            sql=String.Format(sql,info.TableName,info.TableDesc);
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
            
            XTableDictInfo info = modelInfo as XTableDictInfo;
            sql="Update " + this.TableName + " Set TableDesc='{0}' Where TableName='{1}'";
            sql=string.Format(sql,info.TableDesc,info.TableName);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XTableDictInfo info = modelInfo as XTableDictInfo;
            string sql="Insert Into " + this.HistoryTableName + "(TableName,TableDesc,OperateUserId,Operate,OperateTime,NewID) SELECT TableName,TableDesc,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.TableName+"'";
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
            XTableDictInfo info = modelInfo as XTableDictInfo;
            string sql="Insert Into " + this.HistoryTableName + "(TableName,TableDesc,OperateUserId,Operate,OperateTime,NewID) SELECT TableName,TableDesc,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.TableName+"'";
            return sql;
        }

    }
}