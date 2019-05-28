using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 文档附件
    /// </summary>
    public partial class XFileAttachmentProvider : XProviderBase
    {

        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "FileAttachment";
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
            return new XFileAttachmentInfo();
        }


        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo, DataRow modelRow)
        {
            XFileAttachmentInfo info = modelInfo as XFileAttachmentInfo;

            info.ID = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.FileId = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FileId"));//文档主键
            info.AtchName = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AtchName"));//附件名称
            info.AtchDesc = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AtchDesc"));//附件描述
            info.AtchType = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AtchType"));//附件类型
            info.AtchSize = XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "AtchSize"));//附件大小
            info.AtchPath = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AtchPath"));//附件路径
            info.AtchShotGifPath = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AtchShotGifPath"));//缩略图路径
            info.AtchImag = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AtchImag"));//流文件
            info.InputUserId = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputUserId"));//录入人
            info.InputTime = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputTime"));//录入时间

        }


        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XFileAttachmentInfo info = modelInfo as XFileAttachmentInfo;
            string sql = "Insert Into " + this.TableName + "(RID,FileId,AtchName,AtchDesc,AtchType,AtchSize,AtchPath,AtchShotGifPath,AtchImag,InputUserId,InputTime)Values('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}',{10})";
            sql = String.Format(sql, info.RID, info.FileId, info.AtchName, info.AtchDesc, info.AtchType, info.AtchSize, info.AtchPath, info.AtchShotGifPath, info.AtchImag, info.InputUserId, this.GetServerTimeFuncion());
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

            XFileAttachmentInfo info = modelInfo as XFileAttachmentInfo;
            sql = "Update " + this.TableName + " Set FileId='{0}',AtchName='{1}',AtchDesc='{2}',AtchType='{3}',AtchSize={4},AtchPath='{5}',AtchShotGifPath='{6}',AtchImag='{7}', Where RID='{8}'";
            sql = string.Format(sql, info.FileId, info.AtchName, info.AtchDesc, info.AtchType, info.AtchSize, info.AtchPath, info.AtchShotGifPath, info.AtchImag, info.RID);

            return sql;
        }

        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XFileAttachmentInfo info = modelInfo as XFileAttachmentInfo;
            string sql = "Insert Into " + this.HistoryTableName + "(RID,FileId,AtchName,AtchDesc,AtchType,AtchSize,AtchPath,AtchShotGifPath,AtchImag,InputUserId,InputTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,FileId,AtchName,AtchDesc,AtchType,AtchSize,AtchPath,AtchShotGifPath,AtchImag,InputUserId,InputTime,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM " + this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID + "'";
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
            XFileAttachmentInfo info = modelInfo as XFileAttachmentInfo;
            string sql = "Insert Into " + this.HistoryTableName + "(RID,FileId,AtchName,AtchDesc,AtchType,AtchSize,AtchPath,AtchShotGifPath,AtchImag,InputUserId,InputTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,FileId,AtchName,AtchDesc,AtchType,AtchSize,AtchPath,AtchShotGifPath,AtchImag,InputUserId,InputTime,'" + userId + "','删除',getdate(),newid() FROM " + this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID + "'";
            return sql;
        }

    }
}