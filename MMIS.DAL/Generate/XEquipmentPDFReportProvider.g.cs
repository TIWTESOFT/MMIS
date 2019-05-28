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
    public partial class XEquipmentPDFReportProvider : XProviderBase
    {

        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "EquipmentPDFReport";
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
            return new XEquipmentPDFReportInfo();
        }


        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo, DataRow modelRow)
        {
            XEquipmentPDFReportInfo info = modelInfo as XEquipmentPDFReportInfo;

            info.ID = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.RID = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.FileId = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FileId"));//
            info.AtchName = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AtchName"));//
            info.AtchDesc = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AtchDesc"));//
            info.AtchType = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AtchType"));//
            info.AtchSize = XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "AtchSize"));//
            info.AtchPath = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AtchPath"));//
            info.AtchShotGifPath = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AtchShotGifPath"));//
            info.AtchImag = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AtchImag"));//
            info.InputUserId = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputUserId"));//
            info.InputTime = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputTime"));//

        }


        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XEquipmentPDFReportInfo info = modelInfo as XEquipmentPDFReportInfo;
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

            XEquipmentPDFReportInfo info = modelInfo as XEquipmentPDFReportInfo;
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
            XEquipmentPDFReportInfo info = modelInfo as XEquipmentPDFReportInfo;
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
            XEquipmentPDFReportInfo info = modelInfo as XEquipmentPDFReportInfo;
            string sql = "Insert Into " + this.HistoryTableName + "(RID,FileId,AtchName,AtchDesc,AtchType,AtchSize,AtchPath,AtchShotGifPath,AtchImag,InputUserId,InputTime,OperateUserId,Operate,OperateTime,NewID) SELECT RID,FileId,AtchName,AtchDesc,AtchType,AtchSize,AtchPath,AtchShotGifPath,AtchImag,InputUserId,InputTime,'" + userId + "','删除',getdate(),newid() FROM " + this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID + "'";
            return sql;
        }

    }
}