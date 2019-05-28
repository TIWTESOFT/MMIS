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
    public partial class XTemplateProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "Template";
            }
        }
        
         /// <summary>
        /// 主键
        /// </summary>
        public override string PrimaryKey
        {
            get
            {
                return "TemplateID";
            }
        }
        
        
        protected override XModelBase InitTableModel()
        {
            return new XTemplateInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XTemplateInfo info = modelInfo as XTemplateInfo;
            
            info.CatalogID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CatalogID"));//
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TemplateID"));//
            info.TemplateID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TemplateID"));//
            info.TemplateName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TemplateName"));//
            info.PageSize=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "PageSize"));//
            info.Height=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "Height"));//
            info.Width=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "Width"));//
            info.FontName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FontName"));//
            info.FontSize=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "FontSize"));//
            info.TemplateBlob=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TemplateBlob"));//
            info.TemplateType=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TemplateType"));//
            info.Spell=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Spell"));//
            info.Memo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Memo"));//
            info.IsUsed=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "IsUsed"));//
            info.BranchID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "BranchID"));//
            info.StampTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "StampTime"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XTemplateInfo info = modelInfo as XTemplateInfo;
            string sql="Insert Into " + this.TableName + "(CatalogID,TemplateID,TemplateName,PageSize,Height,Width,FontName,FontSize,TemplateBlob,TemplateType,Spell,Memo,IsUsed,BranchID,StampTime)Values('{0}','{1}','{2}','{3}',{4},{5},'{6}',{7},'{8}','{9}','{10}','{11}','{12}','{13}','{14}')";
            sql=String.Format(sql,info.CatalogID,info.TemplateID,info.TemplateName,info.PageSize,info.Height,info.Width,info.FontName,info.FontSize,info.TemplateBlob,info.TemplateType,info.Spell,info.Memo,info.IsUsed,info.BranchID,info.StampTime);
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
            
            XTemplateInfo info = modelInfo as XTemplateInfo;
            sql="Update " + this.TableName + " Set CatalogID='{0}',TemplateName='{1}',PageSize='{2}',Height={3},Width={4},FontName='{5}',FontSize={6},TemplateBlob='{7}',TemplateType='{8}',Spell='{9}',Memo='{10}',IsUsed='{11}',BranchID='{12}',StampTime='{13}' Where TemplateID='{14}'";
            sql=string.Format(sql,info.CatalogID,info.TemplateName,info.PageSize,info.Height,info.Width,info.FontName,info.FontSize,info.TemplateBlob,info.TemplateType,info.Spell,info.Memo,info.IsUsed,info.BranchID,info.StampTime,info.TemplateID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XTemplateInfo info = modelInfo as XTemplateInfo;
            string sql="Insert Into " + this.HistoryTableName + "(CatalogID,TemplateID,TemplateName,PageSize,Height,Width,FontName,FontSize,TemplateBlob,TemplateType,Spell,Memo,IsUsed,BranchID,StampTime,OperateUserId,Operate,OperateTime,NewID) SELECT CatalogID,TemplateID,TemplateName,PageSize,Height,Width,FontName,FontSize,TemplateBlob,TemplateType,Spell,Memo,IsUsed,BranchID,StampTime,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.TemplateID+"'";
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
            XTemplateInfo info = modelInfo as XTemplateInfo;
            string sql="Insert Into " + this.HistoryTableName + "(CatalogID,TemplateID,TemplateName,PageSize,Height,Width,FontName,FontSize,TemplateBlob,TemplateType,Spell,Memo,IsUsed,BranchID,StampTime,OperateUserId,Operate,OperateTime,NewID) SELECT CatalogID,TemplateID,TemplateName,PageSize,Height,Width,FontName,FontSize,TemplateBlob,TemplateType,Spell,Memo,IsUsed,BranchID,StampTime,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.TemplateID+"'";
            return sql;
        }

    }
}