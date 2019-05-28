using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 人员资质证书
    /// </summary>
    public partial class XStaffCertificateProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "StaffCertificate";
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
            return new XStaffCertificateInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XStaffCertificateInfo info = modelInfo as XStaffCertificateInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.UserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UserId"));//人员主键
            info.CertName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CertName"));//证书名称
            info.CertNo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CertNo"));//证书编号
            info.CertGetTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CertGetTime"));//获得时间
            info.CertItem=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CertItem"));//检定项目描述
            info.Remark=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Remark"));//备注信息
            info.InputUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputUserId"));//录入人
            info.InputTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputTime"));//录入时间
            info.UpdateUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateUserId"));//修改人
            info.UpdateTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateTime"));//修改时间
            info.RegisterDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RegisterDate"));//
            info.NextRegisterDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "NextRegisterDate"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XStaffCertificateInfo info = modelInfo as XStaffCertificateInfo;
            string sql="Insert Into " + this.TableName + "(RID,UserId,CertName,CertNo,CertGetTime,CertItem,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,RegisterDate,NextRegisterDate)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'{9}',{10},'{11}','{12}')";
            sql=String.Format(sql,info.RID,info.UserId,info.CertName,info.CertNo,info.CertGetTime,info.CertItem,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion(),info.RegisterDate,info.NextRegisterDate);
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
            
            XStaffCertificateInfo info = modelInfo as XStaffCertificateInfo;
            sql="Update " + this.TableName + " Set UserId='{0}',CertName='{1}',CertNo='{2}',CertGetTime='{3}',CertItem='{4}',Remark='{5}',UpdateUserId='{6}',UpdateTime={7},RegisterDate='{8}',NextRegisterDate='{9}' Where RID='{10}'";
            sql=string.Format(sql,info.UserId,info.CertName,info.CertNo,info.CertGetTime,info.CertItem,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.RegisterDate,info.NextRegisterDate,info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XStaffCertificateInfo info = modelInfo as XStaffCertificateInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,UserId,CertName,CertNo,CertGetTime,CertItem,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,RegisterDate,NextRegisterDate,OperateUserId,Operate,OperateTime,NewID) SELECT RID,UserId,CertName,CertNo,CertGetTime,CertItem,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,RegisterDate,NextRegisterDate,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XStaffCertificateInfo info = modelInfo as XStaffCertificateInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,UserId,CertName,CertNo,CertGetTime,CertItem,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,RegisterDate,NextRegisterDate,OperateUserId,Operate,OperateTime,NewID) SELECT RID,UserId,CertName,CertNo,CertGetTime,CertItem,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,RegisterDate,NextRegisterDate,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}