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
    public partial class XUseErroLogProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "UseErroLog";
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
            return new XUseErroLogInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XUseErroLogInfo info = modelInfo as XUseErroLogInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.TargetSite=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TargetSite"));//
            info.Url=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Url"));//
            info.Source=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Source"));//
            info.StackTrace=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "StackTrace"));//
            info.HelpLink=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "HelpLink"));//
            info.Message=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Message"));//
            info.UserName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UserName"));//
            info.LogTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "LogTime"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XUseErroLogInfo info = modelInfo as XUseErroLogInfo;
            string sql="Insert Into " + this.TableName + "(RID,TargetSite,Url,Source,StackTrace,HelpLink,Message,UserName,LogTime)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";
            sql=String.Format(sql,info.RID,info.TargetSite,info.Url,info.Source,info.StackTrace,info.HelpLink,info.Message,info.UserName,info.LogTime);
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
            
            XUseErroLogInfo info = modelInfo as XUseErroLogInfo;
            sql="Update " + this.TableName + " Set TargetSite='{0}',Url='{1}',Source='{2}',StackTrace='{3}',HelpLink='{4}',Message='{5}',UserName='{6}',LogTime='{7}' Where RID='{8}'";
            sql=string.Format(sql,info.TargetSite,info.Url,info.Source,info.StackTrace,info.HelpLink,info.Message,info.UserName,info.LogTime,info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XUseErroLogInfo info = modelInfo as XUseErroLogInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,TargetSite,Url,Source,StackTrace,HelpLink,Message,UserName,LogTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,TargetSite,Url,Source,StackTrace,HelpLink,Message,UserName,LogTime,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XUseErroLogInfo info = modelInfo as XUseErroLogInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,TargetSite,Url,Source,StackTrace,HelpLink,Message,UserName,LogTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,TargetSite,Url,Source,StackTrace,HelpLink,Message,UserName,LogTime,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}