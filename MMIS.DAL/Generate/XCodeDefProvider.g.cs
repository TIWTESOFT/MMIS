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
    public partial class XCodeDefProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "CodeDef";
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
            return new XCodeDefInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XCodeDefInfo info = modelInfo as XCodeDefInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.NameEN=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "NameEN"));//
            info.NameCN=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "NameCN"));//
            info.RuleCode=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RuleCode"));//
            info.NameBig5=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "NameBig5"));//
            info.Code=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Code"));//
            info.CodeNum=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "CodeNum"));//
            info.CodeEN=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CodeEN"));//
            info.Spell=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Spell"));//
            info.SpellHeader=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "SpellHeader"));//
            info.ProirNum=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "ProirNum"));//
            info.DeptId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "DeptId"));//
            info.IsUsed=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "IsUsed"))=="True";//
            info.ParentID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ParentID"));//
            info.UserID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UserID"));//
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
            XCodeDefInfo info = modelInfo as XCodeDefInfo;
            string sql="Insert Into " + this.TableName + "(RID,NameEN,NameCN,RuleCode,NameBig5,Code,CodeNum,CodeEN,Spell,SpellHeader,ProirNum,DeptId,IsUsed,ParentID,UserID,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime)Values('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}',{10},'{11}','{12}','{13}','{14}','{15}','{16}',{17},'{18}',{19})";
            sql=String.Format(sql,info.RID,info.NameEN,info.NameCN,info.RuleCode,info.NameBig5,info.Code,info.CodeNum,info.CodeEN,info.Spell,info.SpellHeader,info.ProirNum,info.DeptId,info.IsUsed==true?"1":"0",info.ParentID,info.UserID,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion());
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
            
            XCodeDefInfo info = modelInfo as XCodeDefInfo;
            sql="Update " + this.TableName + " Set NameEN='{0}',NameCN='{1}',RuleCode='{2}',NameBig5='{3}',Code='{4}',CodeNum={5},CodeEN='{6}',Spell='{7}',SpellHeader='{8}',ProirNum={9},DeptId='{10}',IsUsed='{11}',ParentID='{12}',UserID='{13}',Remark='{14}',UpdateUserId='{15}',UpdateTime={16} Where RID='{17}'";
            sql=string.Format(sql,info.NameEN,info.NameCN,info.RuleCode,info.NameBig5,info.Code,info.CodeNum,info.CodeEN,info.Spell,info.SpellHeader,info.ProirNum,info.DeptId,info.IsUsed==true?"1":"0",info.ParentID,info.UserID,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XCodeDefInfo info = modelInfo as XCodeDefInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,NameEN,NameCN,RuleCode,NameBig5,Code,CodeNum,CodeEN,Spell,SpellHeader,ProirNum,DeptId,IsUsed,ParentID,UserID,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,NameEN,NameCN,RuleCode,NameBig5,Code,CodeNum,CodeEN,Spell,SpellHeader,ProirNum,DeptId,IsUsed,ParentID,UserID,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XCodeDefInfo info = modelInfo as XCodeDefInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,NameEN,NameCN,RuleCode,NameBig5,Code,CodeNum,CodeEN,Spell,SpellHeader,ProirNum,DeptId,IsUsed,ParentID,UserID,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,NameEN,NameCN,RuleCode,NameBig5,Code,CodeNum,CodeEN,Spell,SpellHeader,ProirNum,DeptId,IsUsed,ParentID,UserID,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}