﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 标准送检
    /// </summary>
    public partial class XStandCheckRecordProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "StandCheckRecord";
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
            return new XStandCheckRecordInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XStandCheckRecordInfo info = modelInfo as XStandCheckRecordInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.StandId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "StandId"));//标准ID
            info.CheckUserName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CheckUserName"));//检定人
            info.CheckDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CheckDesc"));//检定描述
            info.CheckDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CheckDate"));//检定日期
            info.NextCheckDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "NextCheckDate"));//下次送检时间
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
            XStandCheckRecordInfo info = modelInfo as XStandCheckRecordInfo;
            string sql="Insert Into " + this.TableName + "(RID,StandId,CheckUserName,CheckDesc,CheckDate,NextCheckDate,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'{9}',{10})";
            sql=String.Format(sql,info.RID,info.StandId,info.CheckUserName,info.CheckDesc,info.CheckDate,info.NextCheckDate,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion());
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
            
            XStandCheckRecordInfo info = modelInfo as XStandCheckRecordInfo;
            sql="Update " + this.TableName + " Set StandId='{0}',CheckUserName='{1}',CheckDesc='{2}',CheckDate='{3}',NextCheckDate='{4}',Remark='{5}',UpdateUserId='{6}',UpdateTime={7} Where RID='{8}'";
            sql=string.Format(sql,info.StandId,info.CheckUserName,info.CheckDesc,info.CheckDate,info.NextCheckDate,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XStandCheckRecordInfo info = modelInfo as XStandCheckRecordInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,StandId,CheckUserName,CheckDesc,CheckDate,NextCheckDate,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,StandId,CheckUserName,CheckDesc,CheckDate,NextCheckDate,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XStandCheckRecordInfo info = modelInfo as XStandCheckRecordInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,StandId,CheckUserName,CheckDesc,CheckDate,NextCheckDate,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,StandId,CheckUserName,CheckDesc,CheckDate,NextCheckDate,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}