using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 提醒设置
    /// </summary>
    public partial class XRemindConfigProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "RemindConfig";
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
            return new XRemindConfigInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XRemindConfigInfo info = modelInfo as XRemindConfigInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.ConfigType=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ConfigType"));//提醒类型
            info.RemindDays=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "RemindDays"));//提醒天数
            info.RemindInfoTemplate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RemindInfoTemplate"));//提醒信息模版
            info.Remark=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Remark"));//备注信息
            info.InputUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputUserId"));//录入人
            info.InputTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputTime"));//录入时间
            info.UpdateUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateUserId"));//修改人
            info.UpdateTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateTime"));//修改时间
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XRemindConfigInfo info = modelInfo as XRemindConfigInfo;
            string sql="Insert Into " + this.TableName + "(RID,ConfigType,RemindDays,RemindInfoTemplate,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime)Values('{0}','{1}',{2},'{3}','{4}','{5}',{6},'{7}',{8})";
            sql=String.Format(sql,info.RID,info.ConfigType,info.RemindDays,info.RemindInfoTemplate,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion());
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
            
            XRemindConfigInfo info = modelInfo as XRemindConfigInfo;
            sql="Update " + this.TableName + " Set ConfigType='{0}',RemindDays={1},RemindInfoTemplate='{2}',Remark='{3}',UpdateUserId='{4}',UpdateTime={5} Where RID='{6}'";
            sql=string.Format(sql,info.ConfigType,info.RemindDays,info.RemindInfoTemplate,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XRemindConfigInfo info = modelInfo as XRemindConfigInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,ConfigType,RemindDays,RemindInfoTemplate,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,ConfigType,RemindDays,RemindInfoTemplate,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XRemindConfigInfo info = modelInfo as XRemindConfigInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,ConfigType,RemindDays,RemindInfoTemplate,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,ConfigType,RemindDays,RemindInfoTemplate,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}