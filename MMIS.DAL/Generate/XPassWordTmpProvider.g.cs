using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 临时密码
    /// </summary>
    public partial class XPassWordTmpProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "PassWordTmp";
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
            return new XPassWordTmpInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XPassWordTmpInfo info = modelInfo as XPassWordTmpInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.PassDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "PassDesc"));//密码描述
            info.UserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UserId"));//用户ID
            info.UserName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UserName"));//用户名称
            info.PassStateId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "PassStateId"));//密码状态
            info.UseIP=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UseIP"));//使用IP
            info.UseStartTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UseStartTime"));//使用开始时间
            info.UseEndTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UseEndTime"));//使用结束时间
            info.UseLimit=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "UseLimit"));//使用期限
            info.IsTelAudit=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "IsTelAudit"))=="True";//是否手机审批
            info.Remark=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Remark"));//备注信息
            info.InputUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputUserId"));//录入人
            info.InputTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputTime"));//录入时间
            info.UpdateUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateUserId"));//修改人
            info.UpdateTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateTime"));//修改时间
            info.IsCheck=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "IsCheck"))=="True";//
            info.Auditor=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Auditor"));//
            info.AuditTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AuditTime"));//
            info.Password=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Password"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XPassWordTmpInfo info = modelInfo as XPassWordTmpInfo;
            string sql="Insert Into " + this.TableName + "(RID,PassDesc,UserId,UserName,PassStateId,UseIP,UseStartTime,UseEndTime,UseLimit,IsTelAudit,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,IsCheck,Auditor,AuditTime,Password)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'{9}','{10}','{11}',{12},'{13}',{14},'{15}','{16}','{17}','{18}')";
            sql=String.Format(sql,info.RID,info.PassDesc,info.UserId,info.UserName,info.PassStateId,info.UseIP,info.UseStartTime,info.UseEndTime,info.UseLimit,info.IsTelAudit==true?"1":"0",info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion(),info.IsCheck==true?"1":"0",info.Auditor,info.AuditTime,info.Password);
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
            
            XPassWordTmpInfo info = modelInfo as XPassWordTmpInfo;
            sql="Update " + this.TableName + " Set PassDesc='{0}',UserId='{1}',UserName='{2}',PassStateId='{3}',UseIP='{4}',UseStartTime='{5}',UseEndTime='{6}',UseLimit={7},IsTelAudit='{8}',Remark='{9}',UpdateUserId='{10}',UpdateTime={11},IsCheck='{12}',Auditor='{13}',AuditTime='{14}',Password='{15}' Where RID='{16}'";
            sql=string.Format(sql,info.PassDesc,info.UserId,info.UserName,info.PassStateId,info.UseIP,info.UseStartTime,info.UseEndTime,info.UseLimit,info.IsTelAudit==true?"1":"0",info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.IsCheck==true?"1":"0",info.Auditor,info.AuditTime,info.Password,info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XPassWordTmpInfo info = modelInfo as XPassWordTmpInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,PassDesc,UserId,UserName,PassStateId,UseIP,UseStartTime,UseEndTime,UseLimit,IsTelAudit,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,IsCheck,Auditor,AuditTime,Password,OperateUserId,Operate,OperateTime,NewID) SELECT RID,PassDesc,UserId,UserName,PassStateId,UseIP,UseStartTime,UseEndTime,UseLimit,IsTelAudit,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,IsCheck,Auditor,AuditTime,Password,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XPassWordTmpInfo info = modelInfo as XPassWordTmpInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,PassDesc,UserId,UserName,PassStateId,UseIP,UseStartTime,UseEndTime,UseLimit,IsTelAudit,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,IsCheck,Auditor,AuditTime,Password,OperateUserId,Operate,OperateTime,NewID) SELECT RID,PassDesc,UserId,UserName,PassStateId,UseIP,UseStartTime,UseEndTime,UseLimit,IsTelAudit,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,IsCheck,Auditor,AuditTime,Password,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}