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
    public partial class XRoleMenusProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "RoleMenus";
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
            return new XRoleMenusInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XRoleMenusInfo info = modelInfo as XRoleMenusInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.RoleId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RoleId"));//
            info.MenuId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "MenuId"));//
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
            XRoleMenusInfo info = modelInfo as XRoleMenusInfo;
            string sql="Insert Into " + this.TableName + "(RID,RoleId,MenuId,OrderIndex,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime)Values('{0}','{1}','{2}',{3},'{4}','{5}',{6},'{7}',{8})";
            sql=String.Format(sql,info.RID,info.RoleId,info.MenuId,info.OrderIndex,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion());
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
            
            XRoleMenusInfo info = modelInfo as XRoleMenusInfo;
            sql="Update " + this.TableName + " Set RoleId='{0}',MenuId='{1}',OrderIndex={2},Remark='{3}',UpdateUserId='{4}',UpdateTime={5} Where RID='{6}'";
            sql=string.Format(sql,info.RoleId,info.MenuId,info.OrderIndex,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XRoleMenusInfo info = modelInfo as XRoleMenusInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,RoleId,MenuId,OrderIndex,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,RoleId,MenuId,OrderIndex,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XRoleMenusInfo info = modelInfo as XRoleMenusInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,RoleId,MenuId,OrderIndex,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,RoleId,MenuId,OrderIndex,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}