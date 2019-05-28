using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 任务管理
    /// </summary>
    public partial class XTaskProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "Task";
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
            return new XTaskInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XTaskInfo info = modelInfo as XTaskInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.TaskTypeId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TaskTypeId"));//任务类型ID
            info.TaskName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TaskName"));//任务名称
            info.TaskNo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TaskNo"));//任务编号
            info.StartPeople=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "StartPeople"));//发起人
            info.DispatchDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "DispatchDate"));//发派日期
            info.AssignPeople=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AssignPeople"));//负责人
            info.StartDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "StartDate"));//起始日期
            info.PreEndDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "PreEndDate"));//预计完成日期
            info.ShortDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ShortDesc"));//任务简介
            info.Require=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Require"));//任务要求
            info.Content=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Content"));//工作内容
            info.Remark=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Remark"));//备注信息
            info.InputUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputUserId"));//录入人
            info.InputTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputTime"));//录入时间
            info.UpdateUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateUserId"));//修改人
            info.UpdateTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateTime"));//修改时间
            info.ParentId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ParentId"));//
            info.TaskStatus=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TaskStatus"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XTaskInfo info = modelInfo as XTaskInfo;
            string sql="Insert Into " + this.TableName + "(RID,TaskTypeId,TaskName,TaskNo,StartPeople,DispatchDate,AssignPeople,StartDate,PreEndDate,ShortDesc,Require,Content,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,ParentId,TaskStatus)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}',{14},'{15}',{16},'{17}','{18}')";
            sql=String.Format(sql,info.RID,info.TaskTypeId,info.TaskName,info.TaskNo,info.StartPeople,info.DispatchDate,info.AssignPeople,info.StartDate,info.PreEndDate,info.ShortDesc,info.Require,info.Content,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion(),info.ParentId,info.TaskStatus);
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
            
            XTaskInfo info = modelInfo as XTaskInfo;
            sql="Update " + this.TableName + " Set TaskTypeId='{0}',TaskName='{1}',TaskNo='{2}',StartPeople='{3}',DispatchDate='{4}',AssignPeople='{5}',StartDate='{6}',PreEndDate='{7}',ShortDesc='{8}',Require='{9}',Content='{10}',Remark='{11}',UpdateUserId='{12}',UpdateTime={13},ParentId='{14}',TaskStatus='{15}' Where RID='{16}'";
            sql=string.Format(sql,info.TaskTypeId,info.TaskName,info.TaskNo,info.StartPeople,info.DispatchDate,info.AssignPeople,info.StartDate,info.PreEndDate,info.ShortDesc,info.Require,info.Content,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.ParentId,info.TaskStatus,info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XTaskInfo info = modelInfo as XTaskInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,TaskTypeId,TaskName,TaskNo,StartPeople,DispatchDate,AssignPeople,StartDate,PreEndDate,ShortDesc,Require,Content,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,ParentId,TaskStatus,OperateUserId,Operate,OperateTime,NewID) SELECT RID,TaskTypeId,TaskName,TaskNo,StartPeople,DispatchDate,AssignPeople,StartDate,PreEndDate,ShortDesc,Require,Content,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,ParentId,TaskStatus,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XTaskInfo info = modelInfo as XTaskInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,TaskTypeId,TaskName,TaskNo,StartPeople,DispatchDate,AssignPeople,StartDate,PreEndDate,ShortDesc,Require,Content,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,ParentId,TaskStatus,OperateUserId,Operate,OperateTime,NewID) SELECT RID,TaskTypeId,TaskName,TaskNo,StartPeople,DispatchDate,AssignPeople,StartDate,PreEndDate,ShortDesc,Require,Content,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,ParentId,TaskStatus,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}