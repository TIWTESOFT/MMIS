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
    public partial class XTemplateCatalogProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "TemplateCatalog";
            }
        }
        
         /// <summary>
        /// 主键
        /// </summary>
        public override string PrimaryKey
        {
            get
            {
                return "CatalogID";
            }
        }
        
        
        protected override XModelBase InitTableModel()
        {
            return new XTemplateCatalogInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XTemplateCatalogInfo info = modelInfo as XTemplateCatalogInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CatalogID"));//
            info.CatalogID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CatalogID"));//
            info.Source=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Source"));//
            info.CatalogDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CatalogDesc"));//
            info.BranchID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "BranchID"));//
            info.Memo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Memo"));//
            info.StampTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "StampTime"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XTemplateCatalogInfo info = modelInfo as XTemplateCatalogInfo;
            string sql="Insert Into " + this.TableName + "(CatalogID,Source,CatalogDesc,BranchID,Memo,StampTime)Values('{0}','{1}','{2}','{3}','{4}','{5}')";
            sql=String.Format(sql,info.CatalogID,info.Source,info.CatalogDesc,info.BranchID,info.Memo,info.StampTime);
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
            
            XTemplateCatalogInfo info = modelInfo as XTemplateCatalogInfo;
            sql="Update " + this.TableName + " Set Source='{0}',CatalogDesc='{1}',BranchID='{2}',Memo='{3}',StampTime='{4}' Where CatalogID='{5}'";
            sql=string.Format(sql,info.Source,info.CatalogDesc,info.BranchID,info.Memo,info.StampTime,info.CatalogID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XTemplateCatalogInfo info = modelInfo as XTemplateCatalogInfo;
            string sql="Insert Into " + this.HistoryTableName + "(CatalogID,Source,CatalogDesc,BranchID,Memo,StampTime,OperateUserId,Operate,OperateTime,NewID) SELECT CatalogID,Source,CatalogDesc,BranchID,Memo,StampTime,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.CatalogID+"'";
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
            XTemplateCatalogInfo info = modelInfo as XTemplateCatalogInfo;
            string sql="Insert Into " + this.HistoryTableName + "(CatalogID,Source,CatalogDesc,BranchID,Memo,StampTime,OperateUserId,Operate,OperateTime,NewID) SELECT CatalogID,Source,CatalogDesc,BranchID,Memo,StampTime,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.CatalogID+"'";
            return sql;
        }

    }
}