using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 临时密码下载文档
    /// </summary>
    public partial class XPassWord4FileProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "PassWord4File";
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
            return new XPassWord4FileInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XPassWord4FileInfo info = modelInfo as XPassWord4FileInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.PassWordTmpId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "PassWordTmpId"));//临时密码ID
            info.PassWord=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "PassWord"));//下载密码
            info.DownLoadUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "DownLoadUserId"));//下载用户ID
            info.FileID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FileID"));//下载文件ID
            info.DownTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "DownTime"));//下载时间
            info.Remark=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Remark"));//备注
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XPassWord4FileInfo info = modelInfo as XPassWord4FileInfo;
            string sql="Insert Into " + this.TableName + "(RID,PassWordTmpId,PassWord,DownLoadUserId,FileID,DownTime,Remark)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
            sql=String.Format(sql,info.RID,info.PassWordTmpId,info.PassWord,info.DownLoadUserId,info.FileID,info.DownTime,info.Remark);
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
            
            XPassWord4FileInfo info = modelInfo as XPassWord4FileInfo;
            sql="Update " + this.TableName + " Set PassWordTmpId='{0}',PassWord='{1}',DownLoadUserId='{2}',FileID='{3}',DownTime='{4}',Remark='{5}' Where RID='{6}'";
            sql=string.Format(sql,info.PassWordTmpId,info.PassWord,info.DownLoadUserId,info.FileID,info.DownTime,info.Remark,info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XPassWord4FileInfo info = modelInfo as XPassWord4FileInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,PassWordTmpId,PassWord,DownLoadUserId,FileID,DownTime,Remark,OperateUserId,Operate,OperateTime,NewID) SELECT RID,PassWordTmpId,PassWord,DownLoadUserId,FileID,DownTime,Remark,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XPassWord4FileInfo info = modelInfo as XPassWord4FileInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,PassWordTmpId,PassWord,DownLoadUserId,FileID,DownTime,Remark,OperateUserId,Operate,OperateTime,NewID) SELECT RID,PassWordTmpId,PassWord,DownLoadUserId,FileID,DownTime,Remark,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}