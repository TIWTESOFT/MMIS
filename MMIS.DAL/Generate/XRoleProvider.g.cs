using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 角色信息
    /// </summary>
    public partial class XRoleProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "Role";
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
            return new XRoleInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XRoleInfo info = modelInfo as XRoleInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RoleName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RoleName"));//角色名称
            info.NameNum=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "NameNum"));//数值代码
            info.Spell=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Spell"));//拼音
            info.SpellHeader=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "SpellHeader"));//拼音头
            info.OrderIndex=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "OrderIndex"));//排序
            info.IsUsed=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "IsUsed"))=="True";//是否可用
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
            XRoleInfo info = modelInfo as XRoleInfo;
            string sql="Insert Into " + this.TableName + "(RID,RoleName,NameNum,Spell,SpellHeader,OrderIndex,IsUsed,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime)Values('{0}','{1}',{2},'{3}','{4}',{5},'{6}','{7}','{8}',{9},'{10}',{11})";
            sql=String.Format(sql,info.RID,info.RoleName,info.NameNum,info.Spell,info.SpellHeader,info.OrderIndex,info.IsUsed==true?"1":"0",info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion());
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
            
            XRoleInfo info = modelInfo as XRoleInfo;
            sql="Update " + this.TableName + " Set RoleName='{0}',NameNum={1},Spell='{2}',SpellHeader='{3}',OrderIndex={4},IsUsed='{5}',Remark='{6}',UpdateUserId='{7}',UpdateTime={8} Where RID='{9}'";
            sql=string.Format(sql,info.RoleName,info.NameNum,info.Spell,info.SpellHeader,info.OrderIndex,info.IsUsed==true?"1":"0",info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XRoleInfo info = modelInfo as XRoleInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,RoleName,NameNum,Spell,SpellHeader,OrderIndex,IsUsed,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,RoleName,NameNum,Spell,SpellHeader,OrderIndex,IsUsed,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XRoleInfo info = modelInfo as XRoleInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,RoleName,NameNum,Spell,SpellHeader,OrderIndex,IsUsed,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,RoleName,NameNum,Spell,SpellHeader,OrderIndex,IsUsed,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}