using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 
    /// </summary>
    public partial class XUsersRoleProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "UsersRole";
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
            return new XUsersRoleInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XUsersRoleInfo info = modelInfo as XUsersRoleInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.UserID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UserID"));//
            info.RoleID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RoleID"));//
            info.OrderIndex=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "OrderIndex"));//
            info.Remark=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Remark"));//
            info.InputUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputUserId"));//
            info.InputTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputTime"));//
            info.UpdateUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateUserId"));//
            info.UpdateTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateTime"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XUsersRoleInfo info = modelInfo as XUsersRoleInfo;
            string sql="Insert Into " + this.TableName + "(RID,UserID,RoleID,OrderIndex,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime)Values('{0}','{1}','{2}',{3},'{4}','{5}',{6},'{7}',{8})";
            sql=String.Format(sql,info.RID,info.UserID,info.RoleID,info.OrderIndex,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion());
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
            
            XUsersRoleInfo info = modelInfo as XUsersRoleInfo;
            sql="Update " + this.TableName + " Set UserID='{0}',RoleID='{1}',OrderIndex={2},Remark='{3}',UpdateUserId='{4}',UpdateTime={5} Where RID='{6}'";
            sql=string.Format(sql,info.UserID,info.RoleID,info.OrderIndex,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XUsersRoleInfo info = modelInfo as XUsersRoleInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,UserID,RoleID,OrderIndex,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,UserID,RoleID,OrderIndex,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XUsersRoleInfo info = modelInfo as XUsersRoleInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,UserID,RoleID,OrderIndex,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,UserID,RoleID,OrderIndex,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}