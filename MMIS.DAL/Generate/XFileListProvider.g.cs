using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 文档信息
    /// </summary>
    public partial class XFileListProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "FileList";
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
            return new XFileListInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XFileListInfo info = modelInfo as XFileListInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.FileNo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FileNo"));//文档编号
            info.FileName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FileName"));//文档名称
            info.FileDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FileDesc"));//文档描述
            info.FolderTypeId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FolderTypeId"));//文件夹类型
            info.FileTypeId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FileTypeId"));//文档类型
            info.FileLevelId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FileLevelId"));//文档级别
            info.FileStateId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FileStateId"));//文档状态
            info.PageNum=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "PageNum"));//文档页数
            info.UserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UserId"));//用户ID
            info.DeptId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "DeptId"));//部门ID
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
            XFileListInfo info = modelInfo as XFileListInfo;
            string sql="Insert Into " + this.TableName + "(RID,FileNo,FileName,FileDesc,FolderTypeId,FileTypeId,FileLevelId,FileStateId,PageNum,UserId,DeptId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'{9}','{10}','{11}','{12}',{13},'{14}',{15})";
            sql=String.Format(sql,info.RID,info.FileNo,info.FileName,info.FileDesc,info.FolderTypeId,info.FileTypeId,info.FileLevelId,info.FileStateId,info.PageNum,info.UserId,info.DeptId,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion());
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
            
            XFileListInfo info = modelInfo as XFileListInfo;
            sql="Update " + this.TableName + " Set FileNo='{0}',FileName='{1}',FileDesc='{2}',FolderTypeId='{3}',FileTypeId='{4}',FileLevelId='{5}',FileStateId='{6}',PageNum={7},UserId='{8}',DeptId='{9}',Remark='{10}',UpdateUserId='{11}',UpdateTime={12} Where RID='{13}'";
            sql=string.Format(sql,info.FileNo,info.FileName,info.FileDesc,info.FolderTypeId,info.FileTypeId,info.FileLevelId,info.FileStateId,info.PageNum,info.UserId,info.DeptId,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XFileListInfo info = modelInfo as XFileListInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,FileNo,FileName,FileDesc,FolderTypeId,FileTypeId,FileLevelId,FileStateId,PageNum,UserId,DeptId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,FileNo,FileName,FileDesc,FolderTypeId,FileTypeId,FileLevelId,FileStateId,PageNum,UserId,DeptId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XFileListInfo info = modelInfo as XFileListInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,FileNo,FileName,FileDesc,FolderTypeId,FileTypeId,FileLevelId,FileStateId,PageNum,UserId,DeptId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,FileNo,FileName,FileDesc,FolderTypeId,FileTypeId,FileLevelId,FileStateId,PageNum,UserId,DeptId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}