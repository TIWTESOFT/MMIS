using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 设备接收
    /// </summary>
    public partial class XEquipmentReceiveProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "EquipmentReceive";
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
            return new XEquipmentReceiveInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XEquipmentReceiveInfo info = modelInfo as XEquipmentReceiveInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.EquipmentCheckId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "EquipmentCheckId"));//接收设备
            info.CheckUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CheckUserId"));//检定员
            info.Remark=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Remark"));//备注信息
            info.InputUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputUserId"));//录入人
            info.InputTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputTime"));//录入时间
            info.UpdateUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateUserId"));//修改人
            info.UpdateTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateTime"));//修改时间
            info.ReceiveUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ReceiveUserId"));//
            info.ReceiveDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ReceiveDate"));//
            info.ReceiveDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ReceiveDesc"));//
            info.CurrentStatus=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CurrentStatus"));//
            info.FlowStatus=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FlowStatus"));//
            info.FlowUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FlowUserId"));//
            info.CheckedUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CheckedUserId"));//
            info.CheckedDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CheckedDate"));//
            info.CheckedDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CheckedDesc"));//
            info.VerifyUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "VerifyUserId"));//
            info.CheckedReport=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CheckedReport"));//
            info.VerifyedUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "VerifyedUserId"));//
            info.VerifyedDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "VerifyedDate"));//
            info.VerifyedDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "VerifyedDesc"));//
            info.SignUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "SignUserId"));//
            info.SignedUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "SignedUserId"));//
            info.SignedDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "SignedDate"));//
            info.SignedDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "SignedDesc"));//
            info.DispatchUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "DispatchUserId"));//
            info.IsBack=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "IsBack"))=="True";//
            info.BackDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "BackDate"));//
            info.BackReason=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "BackReason"));//
            info.BackStatus=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "BackStatus"));//
            info.BackUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "BackUserId"));//
            info.Quanlity=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "Quanlity"));//
            info.StandId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "StandId"));//
            info.PdfReportFileName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "PdfReportFileName"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XEquipmentReceiveInfo info = modelInfo as XEquipmentReceiveInfo;
            string sql="Insert Into " + this.TableName + "(RID,EquipmentCheckId,CheckUserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,ReceiveUserId,ReceiveDate,ReceiveDesc,CurrentStatus,FlowStatus,FlowUserId,CheckedUserId,CheckedDate,CheckedDesc,VerifyUserId,CheckedReport,VerifyedUserId,VerifyedDate,VerifyedDesc,SignUserId,SignedUserId,SignedDate,SignedDesc,DispatchUserId,IsBack,BackDate,BackReason,BackStatus,BackUserId,Quanlity,StandId,PdfReportFileName)Values('{0}','{1}','{2}','{3}','{4}',{5},'{6}',{7},'{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}','{31}',{32},'{33}','{34}')";
            sql=String.Format(sql,info.RID,info.EquipmentCheckId,info.CheckUserId,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion(),info.ReceiveUserId,info.ReceiveDate,info.ReceiveDesc,info.CurrentStatus,info.FlowStatus,info.FlowUserId,info.CheckedUserId,info.CheckedDate,info.CheckedDesc,info.VerifyUserId,info.CheckedReport,info.VerifyedUserId,info.VerifyedDate,info.VerifyedDesc,info.SignUserId,info.SignedUserId,info.SignedDate,info.SignedDesc,info.DispatchUserId,info.IsBack==true?"1":"0",info.BackDate,info.BackReason,info.BackStatus,info.BackUserId,info.Quanlity,info.StandId,info.PdfReportFileName);
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
            
            XEquipmentReceiveInfo info = modelInfo as XEquipmentReceiveInfo;
            sql="Update " + this.TableName + " Set EquipmentCheckId='{0}',CheckUserId='{1}',Remark='{2}',UpdateUserId='{3}',UpdateTime={4},ReceiveUserId='{5}',ReceiveDate='{6}',ReceiveDesc='{7}',CurrentStatus='{8}',FlowStatus='{9}',FlowUserId='{10}',CheckedUserId='{11}',CheckedDate='{12}',CheckedDesc='{13}',VerifyUserId='{14}',CheckedReport='{15}',VerifyedUserId='{16}',VerifyedDate='{17}',VerifyedDesc='{18}',SignUserId='{19}',SignedUserId='{20}',SignedDate='{21}',SignedDesc='{22}',DispatchUserId='{23}',IsBack='{24}',BackDate='{25}',BackReason='{26}',BackStatus='{27}',BackUserId='{28}',Quanlity={29},StandId='{30}',PdfReportFileName='{31}' Where RID='{32}'";
            sql=string.Format(sql,info.EquipmentCheckId,info.CheckUserId,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.ReceiveUserId,info.ReceiveDate,info.ReceiveDesc,info.CurrentStatus,info.FlowStatus,info.FlowUserId,info.CheckedUserId,info.CheckedDate,info.CheckedDesc,info.VerifyUserId,info.CheckedReport,info.VerifyedUserId,info.VerifyedDate,info.VerifyedDesc,info.SignUserId,info.SignedUserId,info.SignedDate,info.SignedDesc,info.DispatchUserId,info.IsBack==true?"1":"0",info.BackDate,info.BackReason,info.BackStatus,info.BackUserId,info.Quanlity,info.StandId,info.PdfReportFileName,info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XEquipmentReceiveInfo info = modelInfo as XEquipmentReceiveInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,EquipmentCheckId,CheckUserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,ReceiveUserId,ReceiveDate,ReceiveDesc,CurrentStatus,FlowStatus,FlowUserId,CheckedUserId,CheckedDate,CheckedDesc,VerifyUserId,CheckedReport,VerifyedUserId,VerifyedDate,VerifyedDesc,SignUserId,SignedUserId,SignedDate,SignedDesc,DispatchUserId,IsBack,BackDate,BackReason,BackStatus,BackUserId,Quanlity,StandId,PdfReportFileName,OperateUserId,Operate,OperateTime,NewID) SELECT RID,EquipmentCheckId,CheckUserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,ReceiveUserId,ReceiveDate,ReceiveDesc,CurrentStatus,FlowStatus,FlowUserId,CheckedUserId,CheckedDate,CheckedDesc,VerifyUserId,CheckedReport,VerifyedUserId,VerifyedDate,VerifyedDesc,SignUserId,SignedUserId,SignedDate,SignedDesc,DispatchUserId,IsBack,BackDate,BackReason,BackStatus,BackUserId,Quanlity,StandId,PdfReportFileName,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XEquipmentReceiveInfo info = modelInfo as XEquipmentReceiveInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,EquipmentCheckId,CheckUserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,ReceiveUserId,ReceiveDate,ReceiveDesc,CurrentStatus,FlowStatus,FlowUserId,CheckedUserId,CheckedDate,CheckedDesc,VerifyUserId,CheckedReport,VerifyedUserId,VerifyedDate,VerifyedDesc,SignUserId,SignedUserId,SignedDate,SignedDesc,DispatchUserId,IsBack,BackDate,BackReason,BackStatus,BackUserId,Quanlity,StandId,PdfReportFileName,OperateUserId,Operate,OperateTime,NewID) SELECT RID,EquipmentCheckId,CheckUserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,ReceiveUserId,ReceiveDate,ReceiveDesc,CurrentStatus,FlowStatus,FlowUserId,CheckedUserId,CheckedDate,CheckedDesc,VerifyUserId,CheckedReport,VerifyedUserId,VerifyedDate,VerifyedDesc,SignUserId,SignedUserId,SignedDate,SignedDesc,DispatchUserId,IsBack,BackDate,BackReason,BackStatus,BackUserId,Quanlity,StandId,PdfReportFileName,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}