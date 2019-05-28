using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Helper;
using MMIS.Model;
using System.Data.Common;
using System.IO;
using System.Data;

namespace MMIS.DAL
{
    public partial class XTaskFilesProvider
    {
        protected override XModelBase InitViewModel()
        {
            return new XVTaskFilesInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVTaskFilesInfo info = model as XVTaskFilesInfo;

            info.InputUserName = XHelper.GetString(modelRow["InputUserName"]);
            info.UpdateUserName = XHelper.GetString(modelRow["UpdateUserName"]);

            info.TaskName = XHelper.GetString(modelRow["TaskName"]);
            info.TaskNo = XHelper.GetString(modelRow["TaskNo"]);
            info.StartDate = XHelper.GetString(modelRow["StartDate"]);
            info.PreEndDate = XHelper.GetString(modelRow["PreEndDate"]);
            info.ParentTaskName = XHelper.GetString(modelRow["ParentTaskName"]);
            info.ParentTaskNo = XHelper.GetString(modelRow["ParentTaskNo"]);
            info.ParentStartDate = XHelper.GetString(modelRow["ParentStartDate"]);
            info.ParentPreEndDate = XHelper.GetString(modelRow["ParentPreEndDate"]);
        }

        public bool UpdateCustom(XModelBase model)
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

                string sql = this.GetUpdateSql(model);

                XVTaskFilesInfo taskFilesInfo = model as XVTaskFilesInfo;

                if (taskFilesInfo.FileFullName != string.Empty)
                {
                    //上传附件
                    DbCommand fileCommand = this.GetFileCommand(taskFilesInfo);
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

        public bool InsertCustom(XModelBase model)
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

                string sql = this.GetInsertSql(model) + ";";

                XVTaskFilesInfo taskFilesInfo = model as XVTaskFilesInfo;

                //更新任务状态为结束
                sql += "UPDATE Task SET TaskStatus='结束' WHERE RID='" + taskFilesInfo.MainId + "';";

                if (taskFilesInfo.FileFullName != string.Empty)
                {
                    //上传附件
                    DbCommand fileCommand = this.GetFileCommand(taskFilesInfo);
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

        private DbCommand GetFileCommand(XVTaskFilesInfo taskFileInfo)
        {
            string fileDesc = string.Empty;

            string fileName = taskFileInfo.FileFullName;

            FileInfo fi = new FileInfo(fileName);

            double fileSize = 0;
            fileSize = Math.Round(XHelper.GetDouble(fi.Length) / XHelper.GetDouble(1024), 2);

            byte[] bData = XHelper.GetFileBytes(fileName);

            string fileId = taskFileInfo.RID;

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
            DbParameter parameterUser = this.m_DataAccess.GetParameter("@UserId", taskFileInfo.UpdateUserId);
            cmd.Parameters.Add(parameterUser);

            return cmd;
        }

        protected override string GetDeleteAfterSql(IList<XModelBase> modelInfos)
        {
            string deleteIds = this.GetModelIds(modelInfos);
            string sql = "DELETE FROM FileAttachment WHERE FileId IN (" + deleteIds + ");";

            //更新任务状态，如果当前任务下没有除本次任务外的其他任务，则将状态更新为开始
            sql += " DECLARE @TaskFilesCount INT ";
            foreach (XModelBase model in modelInfos)
            {
                XTaskFilesInfo taskFileInfo = model as XTaskFilesInfo;
                sql += "SELECT @TaskFilesCount=COUNT(*) FROM TaskFiles WHERE MainId='" + taskFileInfo.MainId +
                    "' AND RID<>'" + taskFileInfo.RID + "' ";
                sql += "IF @TaskFilesCount=0 ";
                sql += "BEGIN ";
                sql += "UPDATE Task SET TaskStatus='开始' WHERE RID='" + taskFileInfo.MainId + "' ";
                sql += "END ";
            }

            return sql;
        }

        /// <summary>
        /// 根据根级任务获取文件
        /// </summary>
        /// <param name="rootTaskId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetViewListByRootTaskId(string rootTaskId)
        {
            string sql = "with Task1 as ";
            sql += "(select RID,ParentId from Task where RID='" + rootTaskId + "'";
            sql += "union all ";
            sql += "select A.RID,A.ParentId from Task A,Task1 B where A.ParentId=B.RID) ";
            sql += "SELECT * FROM " + this.ViewName + " WHERE MainId IN (SELECT RID FROM Task1)";
            return this.GetViewListBySql(sql);
        }
    }
}
