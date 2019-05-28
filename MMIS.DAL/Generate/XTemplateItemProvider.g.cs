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
    public partial class XTemplateItemProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "TemplateItem";
            }
        }
        
         /// <summary>
        /// 主键
        /// </summary>
        public override string PrimaryKey
        {
            get
            {
                return "TemplateItemID";
            }
        }
        
        
        protected override XModelBase InitTableModel()
        {
            return new XTemplateItemInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XTemplateItemInfo info = modelInfo as XTemplateItemInfo;
            
            info.TemplateID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TemplateID"));//
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TemplateItemID"));//
            info.TemplateItemID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TemplateItemID"));//
            info.ItemID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ItemID"));//
            info.X=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "X"));//
            info.Y=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "Y"));//
            info.Width=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "Width"));//
            info.Height=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "Height"));//
            info.FontSize=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "FontSize"));//
            info.FontName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FontName"));//
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
            XTemplateItemInfo info = modelInfo as XTemplateItemInfo;
            string sql="Insert Into " + this.TableName + "(TemplateID,TemplateItemID,ItemID,X,Y,Width,Height,FontSize,FontName,StampTime,BranchID)Values('{0}','{1}','{2}',{3},{4},{5},{6},{7},'{8}','{9}','{10}')";
            sql=String.Format(sql,info.TemplateID,info.TemplateItemID,info.ItemID,info.X,info.Y,info.Width,info.Height,info.FontSize,info.FontName,info.StampTime,info.BranchID);
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
            
            XTemplateItemInfo info = modelInfo as XTemplateItemInfo;
            sql="Update " + this.TableName + " Set TemplateID='{0}',ItemID='{1}',X={2},Y={3},Width={4},Height={5},FontSize={6},FontName='{7}',StampTime='{8}',BranchID='{9}' Where TemplateItemID='{10}'";
            sql=string.Format(sql,info.TemplateID,info.ItemID,info.X,info.Y,info.Width,info.Height,info.FontSize,info.FontName,info.StampTime,info.BranchID,info.TemplateItemID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XTemplateItemInfo info = modelInfo as XTemplateItemInfo;
            string sql="Insert Into " + this.HistoryTableName + "(TemplateID,TemplateItemID,ItemID,X,Y,Width,Height,FontSize,FontName,StampTime,BranchID,OperateUserId,Operate,OperateTime,NewID) SELECT TemplateID,TemplateItemID,ItemID,X,Y,Width,Height,FontSize,FontName,StampTime,BranchID,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.TemplateItemID+"'";
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
            XTemplateItemInfo info = modelInfo as XTemplateItemInfo;
            string sql="Insert Into " + this.HistoryTableName + "(TemplateID,TemplateItemID,ItemID,X,Y,Width,Height,FontSize,FontName,StampTime,BranchID,OperateUserId,Operate,OperateTime,NewID) SELECT TemplateID,TemplateItemID,ItemID,X,Y,Width,Height,FontSize,FontName,StampTime,BranchID,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.TemplateItemID+"'";
            return sql;
        }

    }
}