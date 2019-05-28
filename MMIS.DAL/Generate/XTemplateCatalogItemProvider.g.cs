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
    public partial class XTemplateCatalogItemProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "TemplateCatalogItem";
            }
        }
        
         /// <summary>
        /// 主键
        /// </summary>
        public override string PrimaryKey
        {
            get
            {
                return "ItemID";
            }
        }
        
        
        protected override XModelBase InitTableModel()
        {
            return new XTemplateCatalogItemInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XTemplateCatalogItemInfo info = modelInfo as XTemplateCatalogItemInfo;
            
            info.CatalogID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CatalogID"));//
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ItemID"));//
            info.ItemID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ItemID"));//
            info.ItemName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ItemName"));//
            info.ItemMean=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ItemMean"));//
            info.Memo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Memo"));//
            info.StampTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "StampTime"));//
            info.BranchID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "BranchID"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XTemplateCatalogItemInfo info = modelInfo as XTemplateCatalogItemInfo;
            string sql="Insert Into " + this.TableName + "(CatalogID,ItemID,ItemName,ItemMean,Memo,StampTime,BranchID)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
            sql=String.Format(sql,info.CatalogID,info.ItemID,info.ItemName,info.ItemMean,info.Memo,info.StampTime,info.BranchID);
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
            
            XTemplateCatalogItemInfo info = modelInfo as XTemplateCatalogItemInfo;
            sql="Update " + this.TableName + " Set CatalogID='{0}',ItemName='{1}',ItemMean='{2}',Memo='{3}',StampTime='{4}',BranchID='{5}' Where ItemID='{6}'";
            sql=string.Format(sql,info.CatalogID,info.ItemName,info.ItemMean,info.Memo,info.StampTime,info.BranchID,info.ItemID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XTemplateCatalogItemInfo info = modelInfo as XTemplateCatalogItemInfo;
            string sql="Insert Into " + this.HistoryTableName + "(CatalogID,ItemID,ItemName,ItemMean,Memo,StampTime,BranchID,OperateUserId,Operate,OperateTime,NewID) SELECT CatalogID,ItemID,ItemName,ItemMean,Memo,StampTime,BranchID,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.ItemID+"'";
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
            XTemplateCatalogItemInfo info = modelInfo as XTemplateCatalogItemInfo;
            string sql="Insert Into " + this.HistoryTableName + "(CatalogID,ItemID,ItemName,ItemMean,Memo,StampTime,BranchID,OperateUserId,Operate,OperateTime,NewID) SELECT CatalogID,ItemID,ItemName,ItemMean,Memo,StampTime,BranchID,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.ItemID+"'";
            return sql;
        }

    }
}