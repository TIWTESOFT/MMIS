using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 工程资料类别
    /// </summary>
    public partial class XCodeProjectTypeProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "CodeProjectType";
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
            return new XCodeProjectTypeInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XCodeProjectTypeInfo info = modelInfo as XCodeProjectTypeInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.NameEN=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "NameEN"));//英文名称
            info.NameCN=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "NameCN"));//中文名称
            info.NameBig5=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "NameBig5"));//繁体名称
            info.Code=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Code"));//代码
            info.CodeNum=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "CodeNum"));//数字代码
            info.CodeEN=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "CodeEN"));//字母代码
            info.Spell=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Spell"));//拼音
            info.SpellHeader=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "SpellHeader"));//拼音缩写
            info.ProirNum=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "ProirNum"));//顺序号
            info.DeptId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "DeptId"));//部门名称
            info.IsUsed=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "IsUsed"))=="True";//是否可用
            info.ParentID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ParentID"));//上级节点
            info.UserID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UserID"));//用户ID
            info.Remark=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Remark"));//备注
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
            XCodeProjectTypeInfo info = modelInfo as XCodeProjectTypeInfo;
            string sql="Insert Into " + this.TableName + "(RID,NameEN,NameCN,NameBig5,Code,CodeNum,CodeEN,Spell,SpellHeader,ProirNum,DeptId,IsUsed,ParentID,UserID,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime)Values('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}',{9},'{10}','{11}','{12}','{13}','{14}','{15}',{16},'{17}',{18})";
            sql=String.Format(sql,info.RID,info.NameEN,info.NameCN,info.NameBig5,info.Code,info.CodeNum,info.CodeEN,info.Spell,info.SpellHeader,info.ProirNum,info.DeptId,info.IsUsed==true?"1":"0",info.ParentID,info.UserID,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion());
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
            
            XCodeProjectTypeInfo info = modelInfo as XCodeProjectTypeInfo;
            sql="Update " + this.TableName + " Set NameEN='{0}',NameCN='{1}',NameBig5='{2}',Code='{3}',CodeNum={4},CodeEN='{5}',Spell='{6}',SpellHeader='{7}',ProirNum={8},DeptId='{9}',IsUsed='{10}',ParentID='{11}',UserID='{12}',Remark='{13}',UpdateUserId='{14}',UpdateTime={15} Where RID='{16}'";
            sql=string.Format(sql,info.NameEN,info.NameCN,info.NameBig5,info.Code,info.CodeNum,info.CodeEN,info.Spell,info.SpellHeader,info.ProirNum,info.DeptId,info.IsUsed==true?"1":"0",info.ParentID,info.UserID,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XCodeProjectTypeInfo info = modelInfo as XCodeProjectTypeInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,NameEN,NameCN,NameBig5,Code,CodeNum,CodeEN,Spell,SpellHeader,ProirNum,DeptId,IsUsed,ParentID,UserID,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,NameEN,NameCN,NameBig5,Code,CodeNum,CodeEN,Spell,SpellHeader,ProirNum,DeptId,IsUsed,ParentID,UserID,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XCodeProjectTypeInfo info = modelInfo as XCodeProjectTypeInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,NameEN,NameCN,NameBig5,Code,CodeNum,CodeEN,Spell,SpellHeader,ProirNum,DeptId,IsUsed,ParentID,UserID,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,NameEN,NameCN,NameBig5,Code,CodeNum,CodeEN,Spell,SpellHeader,ProirNum,DeptId,IsUsed,ParentID,UserID,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}