using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 标准信息
    /// </summary>
    public partial class XStandardProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "Standard";
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
            return new XStandardInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XStandardInfo info = modelInfo as XStandardInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.StandNo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "StandNo"));//标准编号
            info.StandName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "StandName"));//标准名称
            info.CreateTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CreateTime"));//创建时间
            info.NextCheckTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "NextCheckTime"));//下次考核时间
            info.CheckTimes=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "CheckTimes"));//已考核次数
            info.ChargeUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ChargeUserId"));//负责人
            info.Remark=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Remark"));//备注信息
            info.InputUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputUserId"));//录入人
            info.InputTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputTime"));//录入时间
            info.UpdateUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateUserId"));//修改人
            info.UpdateTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateTime"));//修改时间
            info.StandStatus=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "StandStatus"));//
            info.StandDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "StandDesc"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XStandardInfo info = modelInfo as XStandardInfo;
            string sql="Insert Into " + this.TableName + "(RID,StandNo,StandName,CreateTime,NextCheckTime,CheckTimes,ChargeUserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,StandStatus,StandDesc)Values('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}',{9},'{10}',{11},'{12}','{13}')";
            sql=String.Format(sql,info.RID,info.StandNo,info.StandName,info.CreateTime,info.NextCheckTime,info.CheckTimes,info.ChargeUserId,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion(),info.StandStatus,info.StandDesc);
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
            
            XStandardInfo info = modelInfo as XStandardInfo;
            sql="Update " + this.TableName + " Set StandNo='{0}',StandName='{1}',CreateTime='{2}',NextCheckTime='{3}',CheckTimes={4},ChargeUserId='{5}',Remark='{6}',UpdateUserId='{7}',UpdateTime={8},StandStatus='{9}',StandDesc='{10}' Where RID='{11}'";
            sql=string.Format(sql,info.StandNo,info.StandName,info.CreateTime,info.NextCheckTime,info.CheckTimes,info.ChargeUserId,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.StandStatus,info.StandDesc,info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XStandardInfo info = modelInfo as XStandardInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,StandNo,StandName,CreateTime,NextCheckTime,CheckTimes,ChargeUserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,StandStatus,StandDesc,OperateUserId,Operate,OperateTime,NewID) SELECT RID,StandNo,StandName,CreateTime,NextCheckTime,CheckTimes,ChargeUserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,StandStatus,StandDesc,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XStandardInfo info = modelInfo as XStandardInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,StandNo,StandName,CreateTime,NextCheckTime,CheckTimes,ChargeUserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,StandStatus,StandDesc,OperateUserId,Operate,OperateTime,NewID) SELECT RID,StandNo,StandName,CreateTime,NextCheckTime,CheckTimes,ChargeUserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,StandStatus,StandDesc,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}