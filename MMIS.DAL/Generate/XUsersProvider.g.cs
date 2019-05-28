using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// Users
    /// </summary>
    public partial class XUsersProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "Users";
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
            return new XUsersInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XUsersInfo info = modelInfo as XUsersInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.UserType=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UserType"));//用户类型
            info.UserName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UserName"));//用户名
            info.RealName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RealName"));//真实姓名
            info.NameNum=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "NameNum"));//数值代码
            info.PassWord=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "PassWord"));//密码
            info.UserState=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UserState"));//用户状态
            info.IsAdmin=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "IsAdmin"))=="True";//是否管理员
            info.IsUsed=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "IsUsed"))=="True";//是否可用
            info.AuditTel=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AuditTel"));//审核临时密码手机号
            info.IsDownPower=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "IsDownPower"))=="True";//是否超权限下载
            info.OrderIndex=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "OrderIndex"));//排序
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
            XUsersInfo info = modelInfo as XUsersInfo;
            string sql="Insert Into " + this.TableName + "(RID,UserType,UserName,RealName,NameNum,PassWord,UserState,IsAdmin,IsUsed,AuditTel,IsDownPower,OrderIndex,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime)Values('{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}','{8}','{9}','{10}',{11},'{12}','{13}',{14},'{15}',{16})";
            sql=String.Format(sql,info.RID,info.UserType,info.UserName,info.RealName,info.NameNum,info.PassWord,info.UserState,info.IsAdmin==true?"1":"0",info.IsUsed==true?"1":"0",info.AuditTel,info.IsDownPower==true?"1":"0",info.OrderIndex,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion());
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
            
            XUsersInfo info = modelInfo as XUsersInfo;
            sql="Update " + this.TableName + " Set UserType='{0}',UserName='{1}',RealName='{2}',NameNum={3},PassWord='{4}',UserState='{5}',IsAdmin='{6}',IsUsed='{7}',AuditTel='{8}',IsDownPower='{9}',OrderIndex={10},Remark='{11}',UpdateUserId='{12}',UpdateTime={13} Where RID='{14}'";
            sql=string.Format(sql,info.UserType,info.UserName,info.RealName,info.NameNum,info.PassWord,info.UserState,info.IsAdmin==true?"1":"0",info.IsUsed==true?"1":"0",info.AuditTel,info.IsDownPower==true?"1":"0",info.OrderIndex,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XUsersInfo info = modelInfo as XUsersInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,UserType,UserName,RealName,NameNum,PassWord,UserState,IsAdmin,IsUsed,AuditTel,IsDownPower,OrderIndex,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,UserType,UserName,RealName,NameNum,PassWord,UserState,IsAdmin,IsUsed,AuditTel,IsDownPower,OrderIndex,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XUsersInfo info = modelInfo as XUsersInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,UserType,UserName,RealName,NameNum,PassWord,UserState,IsAdmin,IsUsed,AuditTel,IsDownPower,OrderIndex,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,UserType,UserName,RealName,NameNum,PassWord,UserState,IsAdmin,IsUsed,AuditTel,IsDownPower,OrderIndex,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}