using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 标准文件集
    /// </summary>
    public partial class XStandFilesProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "StandFiles";
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
            return new XStandFilesInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XStandFilesInfo info = modelInfo as XStandFilesInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.MainId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "MainId"));//标准ID
            info.FileName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FileName"));//文件名称
            info.FileNo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FileNo"));//文件编号
            info.FileDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FileDesc"));//文件描述
            info.Remark=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Remark"));//备注信息
            info.InputUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputUserId"));//录入人
            info.InputTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputTime"));//录入时间
            info.UpdateUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateUserId"));//修改人
            info.UpdateTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateTime"));//修改时间
            info.IsMaxVersion=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "IsMaxVersion"))=="True";//
            info.NextCheckDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "NextCheckDate"));//
            info.IsNeedCheck=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "IsNeedCheck"))=="True";//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XStandFilesInfo info = modelInfo as XStandFilesInfo;
            string sql="Insert Into " + this.TableName + "(RID,MainId,FileName,FileNo,FileDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,IsMaxVersion,NextCheckDate,IsNeedCheck)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},'{8}',{9},'{10}','{11}','{12}')";
            sql=String.Format(sql,info.RID,info.MainId,info.FileName,info.FileNo,info.FileDesc,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion(),info.IsMaxVersion==true?"1":"0",info.NextCheckDate,info.IsNeedCheck==true?"1":"0");
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
            
            XStandFilesInfo info = modelInfo as XStandFilesInfo;
            sql="Update " + this.TableName + " Set MainId='{0}',FileName='{1}',FileNo='{2}',FileDesc='{3}',Remark='{4}',UpdateUserId='{5}',UpdateTime={6},IsMaxVersion='{7}',NextCheckDate='{8}',IsNeedCheck='{9}' Where RID='{10}'";
            sql=string.Format(sql,info.MainId,info.FileName,info.FileNo,info.FileDesc,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.IsMaxVersion==true?"1":"0",info.NextCheckDate,info.IsNeedCheck==true?"1":"0",info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XStandFilesInfo info = modelInfo as XStandFilesInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,MainId,FileName,FileNo,FileDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,IsMaxVersion,NextCheckDate,IsNeedCheck,OperateUserId,Operate,OperateTime,NewID) SELECT RID,MainId,FileName,FileNo,FileDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,IsMaxVersion,NextCheckDate,IsNeedCheck,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XStandFilesInfo info = modelInfo as XStandFilesInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,MainId,FileName,FileNo,FileDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,IsMaxVersion,NextCheckDate,IsNeedCheck,OperateUserId,Operate,OperateTime,NewID) SELECT RID,MainId,FileName,FileNo,FileDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,IsMaxVersion,NextCheckDate,IsNeedCheck,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}