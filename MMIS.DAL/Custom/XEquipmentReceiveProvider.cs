using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;
using System.Data.Common;
using System.Data;
using System.IO;

namespace MMIS.DAL
{
    public partial class XEquipmentReceiveProvider
    {
        protected override XModelBase InitViewModel()
        {
            return new XVEquipmentReceiveInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVEquipmentReceiveInfo info = model as XVEquipmentReceiveInfo;

            info.EquipmentType = XHelper.GetString(modelRow["EquipmentType"]);
            info.EquipmentCustId = XHelper.GetString(modelRow["EquipmentCustId"]);
            info.EquipmentName = XHelper.GetString(modelRow["EquipmentName"]);
            info.FactoryNo = XHelper.GetString(modelRow["FactoryNo"]);
            info.Spec = XHelper.GetString(modelRow["Spec"]);
            info.Model = XHelper.GetString(modelRow["Model"]);
            info.FactoryName = XHelper.GetString(modelRow["FactoryName"]);
            info.SourceTime = XHelper.GetString(modelRow["SourceTime"]);
            info.UseTime = XHelper.GetString(modelRow["UseTime"]);
            info.SourceCustId = XHelper.GetString(modelRow["SourceCustId"]);
            info.SourceTypeId = XHelper.GetString(modelRow["SourceTypeId"]);
            info.EquipmentStatusId = XHelper.GetString(modelRow["EquipmentStatusId"]);
            info.EquipmentNo = XHelper.GetString(modelRow["EquipmentNo"]);
            info.CustName = XHelper.GetString(modelRow["CustName"]);
            info.Quanlity = XHelper.GetInt(modelRow["Quanlity"]);
            info.LastCheckDate = XHelper.GetString(modelRow["LastCheckDate"]);
            info.EquipmentDesc = XHelper.GetString(modelRow["EquipmentDesc"]);
            info.CheckUserName = XHelper.GetString(modelRow["CheckUserName"]);

            info.ReceiveUserName = XHelper.GetString(modelRow["ReceiveUserName"]);
            info.VerifyUserName = XHelper.GetString(modelRow["VerifyUserName"]);
            info.SignUserName = XHelper.GetString(modelRow["SignUserName"]);
            info.VerifyedUserName = XHelper.GetString(modelRow["VerifyedUserName"]);
            info.CheckedUserName = XHelper.GetString(modelRow["CheckedUserName"]);
            info.DispatchUserName = XHelper.GetString(modelRow["DispatchUserName"]);
            info.SignedUserName = XHelper.GetString(modelRow["SignedUserName"]);
            info.BackUserName = XHelper.GetString(modelRow["BackUserName"]);
            info.StandName = XHelper.GetString(modelRow["StandName"]);
            info.CheckAccord = XHelper.GetString(modelRow["CheckAccord"]);
            info.EquipmentTypeName = XHelper.GetString(modelRow["EquipmentTypeName"]);
            //2014-12-19,mxj,add
            info.InvoiceNo = XHelper.GetString(modelRow["InvoiceNo"]);
            info.InvoiceFlag = XHelper.GetString(modelRow["InvoiceFlag"]);
        }

        public string GetStatus(string id)
        {
            string sql = "SELECT CurrentStatus FROM " + this.TableName + " WHERE RID='{0}'";
            sql = string.Format(sql, id);
            return XHelper.GetString(this.m_DataAccess.ExecuteScalar(sql));
        }

        public string GetScalar(string id,string col)
        {
            string sql = "SELECT " + col + " FROM " + this.TableName + " WHERE RID='{0}'";
            sql = string.Format(sql, id);
            return XHelper.GetString(this.m_DataAccess.ExecuteScalar(sql));
        }

        /// <summary>
        /// 检定
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Checked(XModelBase model, string userId)
        {
            DbConnection sqlConn = this.m_DataAccess.Connection;
            DbTransaction trans = null;
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                }

                trans = sqlConn.BeginTransaction();

                string sql = string.Empty;

                XVEquipmentReceiveInfo receiveInfo = model as XVEquipmentReceiveInfo;

                //更新检定信息
                sql = "UPDATE " + this.TableName + " SET VerifyUserId='" + receiveInfo.VerifyUserId +
                    "',CheckedReport='" + receiveInfo.CheckedReport + "',CheckedUserId='" + userId + "'," +
                    "CheckedDate='" + receiveInfo.CheckedDate + "',CheckedDesc='" + receiveInfo.CheckedDesc + "', " +
                    "CurrentStatus='" + receiveInfo.CurrentStatus + "',FlowStatus='" + receiveInfo.FlowStatus + "', " +
                    "FlowUserId='" + receiveInfo.VerifyUserId + "', " +
                    "IsBack=0,BackUserId=NULL,BackDate=null,BackReason=NULL,StandId='" + receiveInfo.StandId + "' " +
                    "WHERE RID='" + receiveInfo.RID + "';";

                if (receiveInfo.ReportFileFullName != string.Empty)
                {
                    //上传附件
                    DbCommand fileCommand = this.GetFileCommand(receiveInfo);
                    fileCommand.Connection = sqlConn;
                    fileCommand.Transaction = trans;
                    DbDataReader reader = fileCommand.ExecuteReader();
                    reader.Close();
                }

                DbCommand cmd = this.m_DataAccess.GetDbCommand();
                cmd.Connection = sqlConn;
                cmd.CommandText = sql;
                cmd.Transaction = trans;
                bool isSuccess = cmd.ExecuteNonQuery() > 0;
                trans.Commit();

                return isSuccess;

            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.Message);
                XErrorLogTool.WriteLog(ex.ToString());
                trans.Rollback();
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }

            return false;
        }

        private DbCommand GetFileCommand(XVEquipmentReceiveInfo receiveInfo)
        {
            string fileDesc = string.Empty;

            string fileName = receiveInfo.ReportFileFullName;

            FileInfo fi = new FileInfo(fileName);

            double fileSize = 0;
            fileSize = Math.Round(XHelper.GetDouble(fi.Length) / XHelper.GetDouble(1024), 2);

            byte[] bData = XHelper.GetFileBytes(fileName);

            string fileId = receiveInfo.RID;

            string sql = "DELETE FROM FileAttachment WHERE FileId='" + fileId + "';";

            sql += "INSERT INTO FileAttachment (RID,FileId,AtchName,AtchDesc,AtchType," +
               "AtchSize,AtchPath,AtchShotGifPath,AtchImag,InputUserId,InputTime)values" +
               "(@RId,@FileId,@AtchName,@AtchDesc,@AtchType,@AtchSize,@AtchPath,@AtchShotGifPath," +
               "@AtchImag,@UserId,getdate())";
            DbConnection conn = this.m_DataAccess.Connection;
            DbCommand cmd = this.m_DataAccess.GetDbCommand();
            cmd.CommandText = sql;

            DbParameter parameterId = this.m_DataAccess.GetParameter("@RId", Guid.NewGuid().ToString());
            cmd.Parameters.Add(parameterId);
            DbParameter parameterMainId = this.m_DataAccess.GetParameter("@FileId", fileId);
            cmd.Parameters.Add(parameterMainId);
            DbParameter parameterFileName = this.m_DataAccess.GetParameter("@AtchName", fi.Name);
            cmd.Parameters.Add(parameterFileName);
            DbParameter parameterAtchDesc = this.m_DataAccess.GetParameter("@AtchDesc", fileDesc);
            cmd.Parameters.Add(parameterAtchDesc);
            DbParameter parameterAtchType = this.m_DataAccess.GetParameter("@AtchType", fi.Extension);
            cmd.Parameters.Add(parameterAtchType);
            DbParameter parameterAtchSize = this.m_DataAccess.GetParameter("@AtchSize", fileSize);
            cmd.Parameters.Add(parameterAtchSize);
            DbParameter parameterAtchPath = this.m_DataAccess.GetParameter("@AtchPath", fi.FullName);
            cmd.Parameters.Add(parameterAtchPath);
            DbParameter parameterAtchShotGifPath = this.m_DataAccess.GetParameter("@AtchShotGifPath", "");
            cmd.Parameters.Add(parameterAtchShotGifPath);
            DbParameter parameterFile = this.m_DataAccess.GetParameter("@AtchImag", bData);
            cmd.Parameters.Add(parameterFile);
            DbParameter parameterUser = this.m_DataAccess.GetParameter("@UserId", receiveInfo.UpdateUserId);
            cmd.Parameters.Add(parameterUser);

            return cmd;
        }

        public bool Verify(XModelBase model, string userId)
        {
            XVEquipmentReceiveInfo receiveInfo = model as XVEquipmentReceiveInfo;
            string sql = "UPDATE " + this.TableName + " SET VerifyedUserId='" + userId +
                "',VerifyedDate='" + receiveInfo.VerifyedDate + "',VerifyedDesc='" + receiveInfo.VerifyedDesc + "'," +
                "CurrentStatus='" + receiveInfo.CurrentStatus + "',FlowStatus='" + receiveInfo.FlowStatus + "'," +
                "FlowUserId='" + receiveInfo.VerifyUserId + "',SignUserId='" + receiveInfo.SignUserId + "'" +
                " WHERE RID='" + model.ID + "'";
            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }

        public bool Sign(XModelBase model, string userId)
        {
            DbConnection sqlConn = this.m_DataAccess.Connection;
            DbTransaction trans = null;
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                }

                trans = sqlConn.BeginTransaction();

                string sql = string.Empty;

                XVEquipmentReceiveInfo receiveInfo = model as XVEquipmentReceiveInfo;

                //更新签收信息
                sql = "UPDATE " + this.TableName + " SET SignedUserId='" + userId +
                   "',SignedDate='" + receiveInfo.SignedDate + "',SignedDesc='" + receiveInfo.SignedDesc + "'," +
                   "CurrentStatus='" + receiveInfo.CurrentStatus + "',FlowStatus='" + receiveInfo.FlowStatus + "'," +
                   "FlowUserId='" + receiveInfo.VerifyUserId + "',DispatchUserId='" + receiveInfo.DispatchUserId + "'" +
                   " WHERE RID='" + model.ID + "'";

                if (receiveInfo.PdfReportFileFullName != string.Empty)
                {
                    //上传附件
                    DbCommand fileCommand = this.GetPdfFileCommand(receiveInfo);
                    fileCommand.Connection = sqlConn;
                    fileCommand.Transaction = trans;
                    DbDataReader reader = fileCommand.ExecuteReader();
                    reader.Close();
                }

                DbCommand cmd = this.m_DataAccess.GetDbCommand();
                cmd.Connection = sqlConn;
                cmd.CommandText = sql;
                cmd.Transaction = trans;
                bool isSuccess = cmd.ExecuteNonQuery() > 0;
                trans.Commit();

                return isSuccess;

            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.Message);
                XErrorLogTool.WriteLog(ex.ToString());
                trans.Rollback();
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }

            return false;



            //XVEquipmentReceiveInfo receiveInfo = model as XVEquipmentReceiveInfo;
            //string sql = "UPDATE " + this.TableName + " SET SignedUserId='" + userId +
            //    "',SignedDate='" + receiveInfo.SignedDate + "',SignedDesc='" + receiveInfo.SignedDesc + "'," +
            //    "CurrentStatus='" + receiveInfo.CurrentStatus + "',FlowStatus='" + receiveInfo.FlowStatus + "'," +
            //    "FlowUserId='" + receiveInfo.VerifyUserId + "',DispatchUserId='" + receiveInfo.DispatchUserId + "'" +
            //    " WHERE RID='" + model.ID + "'";
            //return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }

        private DbCommand GetPdfFileCommand(XVEquipmentReceiveInfo receiveInfo)
        {
            string fileDesc = string.Empty;

            string fileName = receiveInfo.PdfReportFileFullName;

            FileInfo fi = new FileInfo(fileName);

            double fileSize = 0;
            fileSize = Math.Round(XHelper.GetDouble(fi.Length) / XHelper.GetDouble(1024), 2);

            byte[] bData = XHelper.GetFileBytes(fileName);

            string fileId = receiveInfo.RID;

            string sql = "DELETE FROM EquipmentPDFReport WHERE FileId='" + fileId + "';";

            sql += "INSERT INTO EquipmentPDFReport (RID,FileId,AtchName,AtchDesc,AtchType," +
               "AtchSize,AtchPath,AtchShotGifPath,AtchImag,InputUserId,InputTime)values" +
               "(@RId,@FileId,@AtchName,@AtchDesc,@AtchType,@AtchSize,@AtchPath,@AtchShotGifPath," +
               "@AtchImag,@UserId,getdate())";
            DbConnection conn = this.m_DataAccess.Connection;
            DbCommand cmd = this.m_DataAccess.GetDbCommand();
            cmd.CommandText = sql;

            DbParameter parameterId = this.m_DataAccess.GetParameter("@RId", Guid.NewGuid().ToString());
            cmd.Parameters.Add(parameterId);
            DbParameter parameterMainId = this.m_DataAccess.GetParameter("@FileId", fileId);
            cmd.Parameters.Add(parameterMainId);
            DbParameter parameterFileName = this.m_DataAccess.GetParameter("@AtchName", fi.Name);
            cmd.Parameters.Add(parameterFileName);
            DbParameter parameterAtchDesc = this.m_DataAccess.GetParameter("@AtchDesc", fileDesc);
            cmd.Parameters.Add(parameterAtchDesc);
            DbParameter parameterAtchType = this.m_DataAccess.GetParameter("@AtchType", fi.Extension);
            cmd.Parameters.Add(parameterAtchType);
            DbParameter parameterAtchSize = this.m_DataAccess.GetParameter("@AtchSize", fileSize);
            cmd.Parameters.Add(parameterAtchSize);
            DbParameter parameterAtchPath = this.m_DataAccess.GetParameter("@AtchPath", fi.FullName);
            cmd.Parameters.Add(parameterAtchPath);
            DbParameter parameterAtchShotGifPath = this.m_DataAccess.GetParameter("@AtchShotGifPath", "");
            cmd.Parameters.Add(parameterAtchShotGifPath);
            DbParameter parameterFile = this.m_DataAccess.GetParameter("@AtchImag", bData);
            cmd.Parameters.Add(parameterFile);
            DbParameter parameterUser = this.m_DataAccess.GetParameter("@UserId", receiveInfo.UpdateUserId);
            cmd.Parameters.Add(parameterUser);

            return cmd;
        }

        /// <summary>
        /// 退回重新检定
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Back(XModelBase model)
        {
            XVEquipmentReceiveInfo receiveInfo = model as XVEquipmentReceiveInfo;
            string sql = "UPDATE " + this.TableName + " SET IsBack=1,BackDate=getdate()," +
                "BackReason='" + receiveInfo.BackReason + "'," +
               "BackStatus='" + receiveInfo.BackStatus + "',BackUserId='" + receiveInfo.BackUserId + "', " +
               "CurrentStatus='接收',FlowStatus='检定'," +
               "FlowUserId=CheckUserId " +
               " WHERE RID='" + model.ID + "'";
            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }

        /// <summary>
        /// 制证
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool PrintBill(XModelBase model)
        {
            XVEquipmentReceiveInfo receiveInfo = model as XVEquipmentReceiveInfo;
            string sql = "UPDATE " + this.TableName + " SET UpdateTime=getdate(),UpdateUserId='" + receiveInfo.UpdateUserId + "', "+
               "CurrentStatus='制证',FlowStatus='制证'," +
               "FlowUserId='" + receiveInfo.UpdateUserId + "' " +
               " WHERE RID='" + model.ID + "'";
            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }
        /// <summary>
        /// 获取提醒信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetRemind(string userId)
        {
            string sql = "SELECT * FROM " + this.ViewName + " WHERE FlowUserId='" + userId + "'";
            return this.GetViewListBySql(sql);
        }

        /// <summary>
        /// 获取5次溯源时间
        /// </summary>
        /// <param name="equipmentCheckId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetTop5Checked(string equipmentCheckId)
        {
            string sql = "SELECT TOP 5 * FROM V_EquipmentReceive WHERE EquipmentCheckId='" + equipmentCheckId + 
                "' ORDER BY CheckedDate DESC ";
            return this.GetViewListBySql(sql);
        }
    }
}
