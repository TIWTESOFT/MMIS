using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 送检设备
    /// </summary>
    public partial class XStandEquipmentProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "StandEquipment";
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
            return new XStandEquipmentInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XStandEquipmentInfo info = modelInfo as XStandEquipmentInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.MainId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "MainId"));//检验标准主键
            info.EquipmentType=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "EquipmentType"));//设备类型
            info.EquipmentCustId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "EquipmentCustId"));//送检单位
            info.EquipmentNo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "EquipmentNo"));//设备编号
            info.EquipmentName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "EquipmentName"));//设备名称
            info.FactoryNo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FactoryNo"));//出厂编号
            info.Spec=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Spec"));//规格
            info.Model=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Model"));//型号
            info.FactoryName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FactoryName"));//制造单位
            info.SourceTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "SourceTime"));//溯源时间
            info.UseTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UseTime"));//使用时间
            info.SourceCustId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "SourceCustId"));//溯源单位
            info.SourceTypeId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "SourceTypeId"));//溯源方式
            info.EquipmentStatusId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "EquipmentStatusId"));//设备状态
            info.SignStatus=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "SignStatus"));//标识状态
            info.Quanlity=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "Quanlity"));//数量
            info.LinkMan=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "LinkMan"));//联系人
            info.Tel=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Tel"));//电话
            info.Email=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Email"));//电子邮件
            info.CheckAccord=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CheckAccord"));//坚定依据
            info.LastCheckDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "LastCheckDate"));//最后检定日期
            info.CheckResult=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CheckResult"));//坚定结论
            info.ValidDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ValidDate"));//有效日期
            info.CertNo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CertNo"));//检定证书编号
            info.EquipmentDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "EquipmentDesc"));//设备描述
            info.Remark=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Remark"));//备注信息
            info.InputUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputUserId"));//录入人
            info.InputTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputTime"));//录入时间
            info.UpdateUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateUserId"));//修改人
            info.UpdateTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateTime"));//修改时间
            info.NextCheckDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "NextCheckDate"));//
            info.IsNeedCheck=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "IsNeedCheck"))=="True";//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XStandEquipmentInfo info = modelInfo as XStandEquipmentInfo;
            string sql="Insert Into " + this.TableName + "(RID,MainId,EquipmentType,EquipmentCustId,EquipmentNo,EquipmentName,FactoryNo,Spec,Model,FactoryName,SourceTime,UseTime,SourceCustId,SourceTypeId,EquipmentStatusId,SignStatus,Quanlity,LinkMan,Tel,Email,CheckAccord,LastCheckDate,CheckResult,ValidDate,CertNo,EquipmentDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,NextCheckDate,IsNeedCheck)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}',{16},'{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}',{28},'{29}',{30},'{31}','{32}')";
            sql=String.Format(sql,info.RID,info.MainId,info.EquipmentType,info.EquipmentCustId,info.EquipmentNo,info.EquipmentName,info.FactoryNo,info.Spec,info.Model,info.FactoryName,info.SourceTime,info.UseTime,info.SourceCustId,info.SourceTypeId,info.EquipmentStatusId,info.SignStatus,info.Quanlity,info.LinkMan,info.Tel,info.Email,info.CheckAccord,info.LastCheckDate,info.CheckResult,info.ValidDate,info.CertNo,info.EquipmentDesc,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion(),info.NextCheckDate,info.IsNeedCheck==true?"1":"0");
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
            
            XStandEquipmentInfo info = modelInfo as XStandEquipmentInfo;
            sql="Update " + this.TableName + " Set MainId='{0}',EquipmentType='{1}',EquipmentCustId='{2}',EquipmentNo='{3}',EquipmentName='{4}',FactoryNo='{5}',Spec='{6}',Model='{7}',FactoryName='{8}',SourceTime='{9}',UseTime='{10}',SourceCustId='{11}',SourceTypeId='{12}',EquipmentStatusId='{13}',SignStatus='{14}',Quanlity={15},LinkMan='{16}',Tel='{17}',Email='{18}',CheckAccord='{19}',LastCheckDate='{20}',CheckResult='{21}',ValidDate='{22}',CertNo='{23}',EquipmentDesc='{24}',Remark='{25}',UpdateUserId='{26}',UpdateTime={27},NextCheckDate='{28}',IsNeedCheck='{29}' Where RID='{30}'";
            sql=string.Format(sql,info.MainId,info.EquipmentType,info.EquipmentCustId,info.EquipmentNo,info.EquipmentName,info.FactoryNo,info.Spec,info.Model,info.FactoryName,info.SourceTime,info.UseTime,info.SourceCustId,info.SourceTypeId,info.EquipmentStatusId,info.SignStatus,info.Quanlity,info.LinkMan,info.Tel,info.Email,info.CheckAccord,info.LastCheckDate,info.CheckResult,info.ValidDate,info.CertNo,info.EquipmentDesc,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.NextCheckDate,info.IsNeedCheck==true?"1":"0",info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XStandEquipmentInfo info = modelInfo as XStandEquipmentInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,MainId,EquipmentType,EquipmentCustId,EquipmentNo,EquipmentName,FactoryNo,Spec,Model,FactoryName,SourceTime,UseTime,SourceCustId,SourceTypeId,EquipmentStatusId,SignStatus,Quanlity,LinkMan,Tel,Email,CheckAccord,LastCheckDate,CheckResult,ValidDate,CertNo,EquipmentDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,NextCheckDate,IsNeedCheck,OperateUserId,Operate,OperateTime,NewID) SELECT RID,MainId,EquipmentType,EquipmentCustId,EquipmentNo,EquipmentName,FactoryNo,Spec,Model,FactoryName,SourceTime,UseTime,SourceCustId,SourceTypeId,EquipmentStatusId,SignStatus,Quanlity,LinkMan,Tel,Email,CheckAccord,LastCheckDate,CheckResult,ValidDate,CertNo,EquipmentDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,NextCheckDate,IsNeedCheck,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XStandEquipmentInfo info = modelInfo as XStandEquipmentInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,MainId,EquipmentType,EquipmentCustId,EquipmentNo,EquipmentName,FactoryNo,Spec,Model,FactoryName,SourceTime,UseTime,SourceCustId,SourceTypeId,EquipmentStatusId,SignStatus,Quanlity,LinkMan,Tel,Email,CheckAccord,LastCheckDate,CheckResult,ValidDate,CertNo,EquipmentDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,NextCheckDate,IsNeedCheck,OperateUserId,Operate,OperateTime,NewID) SELECT RID,MainId,EquipmentType,EquipmentCustId,EquipmentNo,EquipmentName,FactoryNo,Spec,Model,FactoryName,SourceTime,UseTime,SourceCustId,SourceTypeId,EquipmentStatusId,SignStatus,Quanlity,LinkMan,Tel,Email,CheckAccord,LastCheckDate,CheckResult,ValidDate,CertNo,EquipmentDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,NextCheckDate,IsNeedCheck,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}