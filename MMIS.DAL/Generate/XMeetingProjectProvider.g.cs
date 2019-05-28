using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 工程信息
    /// </summary>
    public partial class XMeetingProjectProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "MeetingProject";
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
            return new XMeetingProjectInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XMeetingProjectInfo info = modelInfo as XMeetingProjectInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.ProjectName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ProjectName"));//工程名称
            info.ProjectDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ProjectDesc"));//工程描述
            info.StartTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "StartTime"));//预计开始时间
            info.EndTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "EndTime"));//预计结束时间
            info.Purveyor=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Purveyor"));//承办商
            info.Linkman=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Linkman"));//联系人
            info.Tel=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Tel"));//联系电话
            info.ProjectTypeId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ProjectTypeId"));//工程资料类别
            info.DeptId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "DeptId"));//部门名称
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
            XMeetingProjectInfo info = modelInfo as XMeetingProjectInfo;
            string sql="Insert Into " + this.TableName + "(RID,ProjectName,ProjectDesc,StartTime,EndTime,Purveyor,Linkman,Tel,ProjectTypeId,DeptId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}',{12},'{13}',{14})";
            sql=String.Format(sql,info.RID,info.ProjectName,info.ProjectDesc,info.StartTime,info.EndTime,info.Purveyor,info.Linkman,info.Tel,info.ProjectTypeId,info.DeptId,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion());
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
            
            XMeetingProjectInfo info = modelInfo as XMeetingProjectInfo;
            sql="Update " + this.TableName + " Set ProjectName='{0}',ProjectDesc='{1}',StartTime='{2}',EndTime='{3}',Purveyor='{4}',Linkman='{5}',Tel='{6}',ProjectTypeId='{7}',DeptId='{8}',Remark='{9}',UpdateUserId='{10}',UpdateTime={11} Where RID='{12}'";
            sql=string.Format(sql,info.ProjectName,info.ProjectDesc,info.StartTime,info.EndTime,info.Purveyor,info.Linkman,info.Tel,info.ProjectTypeId,info.DeptId,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XMeetingProjectInfo info = modelInfo as XMeetingProjectInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,ProjectName,ProjectDesc,StartTime,EndTime,Purveyor,Linkman,Tel,ProjectTypeId,DeptId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,ProjectName,ProjectDesc,StartTime,EndTime,Purveyor,Linkman,Tel,ProjectTypeId,DeptId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XMeetingProjectInfo info = modelInfo as XMeetingProjectInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,ProjectName,ProjectDesc,StartTime,EndTime,Purveyor,Linkman,Tel,ProjectTypeId,DeptId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,ProjectName,ProjectDesc,StartTime,EndTime,Purveyor,Linkman,Tel,ProjectTypeId,DeptId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}