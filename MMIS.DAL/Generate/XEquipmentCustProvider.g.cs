using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 送检单位
    /// </summary>
    public partial class XEquipmentCustProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "EquipmentCust";
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
            return new XEquipmentCustInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XEquipmentCustInfo info = modelInfo as XEquipmentCustInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.CustTypeId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CustTypeId"));//单位类型
            info.CustName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CustName"));//单位名称
            info.CustNo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CustNo"));//单位编号
            info.CustAddress=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CustAddress"));//单位地址
            info.LinkPeople=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "LinkPeople"));//联系人
            info.MobileNo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "MobileNo"));//手机
            info.WorkTel=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "WorkTel"));//单位电话
            info.Email=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Email"));//邮箱
            info.WebSite=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "WebSite"));//网址
            info.CustDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CustDesc"));//单位描述
            info.Remark=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Remark"));//备注信息
            info.InputUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputUserId"));//录入人
            info.InputTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputTime"));//录入时间
            info.UpdateUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateUserId"));//修改人
            info.UpdateTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateTime"));//修改时间
            info.InvoiceTitle=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InvoiceTitle"));//
            info.TaxNo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TaxNo"));//
            info.BankName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "BankName"));//
            info.BankAccountNo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "BankAccountNo"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XEquipmentCustInfo info = modelInfo as XEquipmentCustInfo;
            string sql="Insert Into " + this.TableName + "(RID,CustTypeId,CustName,CustNo,CustAddress,LinkPeople,MobileNo,WorkTel,Email,WebSite,CustDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,InvoiceTitle,TaxNo,BankName,BankAccountNo)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}',{13},'{14}',{15},'{16}','{17}','{18}','{19}')";
            sql=String.Format(sql,info.RID,info.CustTypeId,info.CustName,info.CustNo,info.CustAddress,info.LinkPeople,info.MobileNo,info.WorkTel,info.Email,info.WebSite,info.CustDesc,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion(),info.InvoiceTitle,info.TaxNo,info.BankName,info.BankAccountNo);
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
            
            XEquipmentCustInfo info = modelInfo as XEquipmentCustInfo;
            sql="Update " + this.TableName + " Set CustTypeId='{0}',CustName='{1}',CustNo='{2}',CustAddress='{3}',LinkPeople='{4}',MobileNo='{5}',WorkTel='{6}',Email='{7}',WebSite='{8}',CustDesc='{9}',Remark='{10}',UpdateUserId='{11}',UpdateTime={12},InvoiceTitle='{13}',TaxNo='{14}',BankName='{15}',BankAccountNo='{16}' Where RID='{17}'";
            sql=string.Format(sql,info.CustTypeId,info.CustName,info.CustNo,info.CustAddress,info.LinkPeople,info.MobileNo,info.WorkTel,info.Email,info.WebSite,info.CustDesc,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.InvoiceTitle,info.TaxNo,info.BankName,info.BankAccountNo,info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XEquipmentCustInfo info = modelInfo as XEquipmentCustInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,CustTypeId,CustName,CustNo,CustAddress,LinkPeople,MobileNo,WorkTel,Email,WebSite,CustDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,InvoiceTitle,TaxNo,BankName,BankAccountNo,OperateUserId,Operate,OperateTime,NewID) SELECT RID,CustTypeId,CustName,CustNo,CustAddress,LinkPeople,MobileNo,WorkTel,Email,WebSite,CustDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,InvoiceTitle,TaxNo,BankName,BankAccountNo,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XEquipmentCustInfo info = modelInfo as XEquipmentCustInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,CustTypeId,CustName,CustNo,CustAddress,LinkPeople,MobileNo,WorkTel,Email,WebSite,CustDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,InvoiceTitle,TaxNo,BankName,BankAccountNo,OperateUserId,Operate,OperateTime,NewID) SELECT RID,CustTypeId,CustName,CustNo,CustAddress,LinkPeople,MobileNo,WorkTel,Email,WebSite,CustDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,InvoiceTitle,TaxNo,BankName,BankAccountNo,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}