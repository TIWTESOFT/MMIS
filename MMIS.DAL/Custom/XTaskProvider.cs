using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;
using System.Data;
using System.Data.Common;
using System.IO;

namespace MMIS.DAL
{
    public partial class XTaskProvider
    {
        protected override XModelBase InitViewModel()
        {
            return new XVTaskInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVTaskInfo taskInfo = model as XVTaskInfo;
            taskInfo.TaskType = XHelper.GetString(modelRow["TaskType"]);

            taskInfo.ParentTaskName = XHelper.GetString(modelRow["ParentTaskName"]);
            taskInfo.ParentTaskNo = XHelper.GetString(modelRow["ParentTaskNo"]);
            taskInfo.ParentStartDate = XHelper.GetString(modelRow["ParentStartDate"]);
            taskInfo.ParentPreEndDate = XHelper.GetString(modelRow["ParentPreEndDate"]);
            taskInfo.AssignPeopleName = XHelper.GetString(modelRow["AssignPeopleName"]);
        }

        /// <summary>
        /// 更新任务状态
        /// </summary>
        /// <param name="status"></param>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public bool UpdateTaskStatus(string status, string taskId)
        {
            string sql = "UPDATE " + this.TableName + " SET TaskStatus='" +
                status + "' WHERE RID='" + taskId + "'";
            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }

        /// <summary>
        /// 获取任务状态
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public string GetTaskStatus(string taskId)
        {
            string sql = "SELECT TaskStatus FROM " + this.TableName + " WHERE RID='" + taskId + "'";
            return XHelper.GetString(this.m_DataAccess.ExecuteScalar(sql));
        }

        public override IList<XModelBase> GetRootViewModelList(string where)
        {
            string sql = "SELECT * FROM " + this.ViewName +
              " WHERE RID IN (" +
              "SELECT ParentId FROM Task WHERE ParentId IS NOT NULL " + where +
              "UNION " +
              "SELECT RId FROM Task WHERE ParentId IS NULL" + where +
              " OR ParentId='' )";
            sql += OrderBy;
            return this.GetViewListBySql(sql);
        }

        /// <summary>
        /// 获取要填报任务的根任务列表
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public IList<XModelBase> GetTaskFileRootViewModelList(string where)
        {
            string sql = "SELECT * FROM " + this.ViewName +
              " WHERE RID IN (" +
              "SELECT ParentId FROM Task WHERE ParentId IS NOT NULL " + where +
              "UNION " +
              "SELECT RId FROM Task WHERE ParentId IS NULL" + where + " )";
            sql += OrderBy;
            return this.GetViewListBySql(sql);
        }

        /// <summary>
        /// 是否已有提交的文件
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsHaveFile(string id)
        {
            string sql = "SELECT COUNT(*) FROM TaskFiles WHERE MainId='" + id + "'";
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// 是否有待办任务
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool IsHaveTaskToDo(string userId)
        {
            string sql = "SELECT COUNT(*) FROM V_TaskToDo WHERE AssignPeople='" + userId + "'";
            return XHelper.GetInt(this.m_DataAccess.ExecuteNonQuery(sql)) > 0;
        }

        /// <summary>
        /// 获取待办任务
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataTable GetTaskToDo(string userId)
        {
            string sql = "SELECT * FROM V_TaskToDo WHERE AssignPeople='" + userId + "'";
            return this.m_DataAccess.GetDataTable(sql);
        }

        public override bool Insert(XModelBase modelInfo, IDictionary<string, IList<XModelBase>> detailDict)
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

                //插入主表
                string sqlMain = this.GetInsertSql(modelInfo);
                sql += sqlMain;

                //插入子表
                foreach (KeyValuePair<string, IList<XModelBase>> keyValue in detailDict)
                {
                    string key = keyValue.Key;
                    IList<XModelBase> detailModels = keyValue.Value;

                    foreach (XModelBase detailInfo in detailModels)
                    {
                        //填充子表
                        this.FillDetailMainId(key, detailInfo, modelInfo);
                        sql += this.GetDetailInsertSql(key, detailInfo) + ";";
                        if (key == "grdFiles")
                        {
                            //如果是文件集，则需要存储附件
                            XVTaskAttachmentInfo fileInfo = detailInfo as XVTaskAttachmentInfo;
                            if (fileInfo.FileFullName != string.Empty)
                            {
                                DbCommand fileCommand = this.GetFileCommand(fileInfo);
                                fileCommand.Connection = sqlConn;
                                fileCommand.Transaction = trans;
                                DbDataReader reader = fileCommand.ExecuteReader();
                                reader.Close();
                            }
                        }
                    }
                }

                //插入语句后执行
                sql += this.GetInsertAfterSql(modelInfo);

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

        private new string GetDetailInsertSql(string key, XModelBase detailInfo)
        {
            XProviderBase provider = null;

            switch (key)
            {
                case "grdFiles":
                    provider = XFactoryManager.CreateFactory().GetTaskAttachmentProvider();
                    break;
            }
            return provider.GetInsertSql(detailInfo);
        }

        public override void FillDetailMainId(string key, XModelBase detailInfo, XModelBase mainInfo)
        {
            switch (key)
            {
                case "grdFiles":
                    //文件集
                    XVTaskAttachmentInfo taskAttachInfo = detailInfo as XVTaskAttachmentInfo;
                    taskAttachInfo.MainId = mainInfo.ID;
                    break;
            }
        }

        private DbCommand GetFileCommand(XVTaskAttachmentInfo taskAcctachmentInfo)
        {
            string fileDesc = string.Empty;

            string fileName = taskAcctachmentInfo.FileFullName;

            FileInfo fi = new FileInfo(fileName);

            double fileSize = 0;
            fileSize = Math.Round(XHelper.GetDouble(fi.Length) / XHelper.GetDouble(1024), 2);

            byte[] bData = XHelper.GetFileBytes(fileName);

            string fileId = taskAcctachmentInfo.RID;

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
            DbParameter parameterUser = this.m_DataAccess.GetParameter("@UserId", taskAcctachmentInfo.UpdateUserId);
            cmd.Parameters.Add(parameterUser);

            return cmd;
        }

        public override bool Update(XModelBase modelInfo, IDictionary<string, IList<XModelBase>> detailDict, IDictionary<string, IList<XModelBase>> deleteDict)
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

                //更新语句
                sql += this.GetUpdateSql(modelInfo) + ";";

                //获取删除语句
                foreach (KeyValuePair<string, IList<XModelBase>> keyValue in deleteDict)
                {
                    string key = keyValue.Key;
                    IList<XModelBase> detailModels = keyValue.Value;
                    foreach (XModelBase detailInfo in detailModels)
                    {
                        sql += this.GetDetailDeleteSql(key, detailInfo);
                    }
                }

                //获取新增和修改明细
                foreach (KeyValuePair<string, IList<XModelBase>> keyValue in detailDict)
                {
                    string key = keyValue.Key;
                    IList<XModelBase> detailModels = keyValue.Value;
                    foreach (XModelBase detailInfo in detailModels)
                    {
                        if (detailInfo.ModelStatus == XModelStatus.Add)
                        {
                            //新增
                            this.FillDetailMainId(key, detailInfo, modelInfo);
                            sql += this.GetDetailInsertSql(key, detailInfo);
                            if (key == "grdFiles")
                            {
                                //如果是文件集，则需要存储附件
                                XVTaskAttachmentInfo fileInfo = detailInfo as XVTaskAttachmentInfo;
                                if (fileInfo.FileFullName != string.Empty)
                                {
                                    DbCommand fileCommand = this.GetFileCommand(fileInfo);
                                    fileCommand.Connection = sqlConn;
                                    fileCommand.Transaction = trans;
                                    DbDataReader reader = fileCommand.ExecuteReader();
                                    reader.Close();
                                }
                            }
                        }
                        else if (detailInfo.ModelStatus == XModelStatus.Modify)
                        {
                            //修改
                            sql += this.GetDetailUpdateSql(key, detailInfo);
                            if (key == "grdFiles")
                            {
                                //修改的时候有可能修改文件如果是文件集，则需要存储附件
                                XVTaskAttachmentInfo fileInfo = detailInfo as XVTaskAttachmentInfo;
                                if (fileInfo.FileFullName != string.Empty)
                                {
                                    DbCommand fileCommand = this.GetFileCommand(fileInfo);
                                    fileCommand.Connection = sqlConn;
                                    fileCommand.Transaction = trans;
                                    DbDataReader reader = fileCommand.ExecuteReader();
                                    reader.Close();
                                }
                            }
                        }
                    }
                }

                DbCommand cmd = this.m_DataAccess.GetDbCommand();
                cmd.Connection = sqlConn;
                cmd.Transaction = trans;
                cmd.CommandText = sql;
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

        public override string GetDetailUpdateSql(string key, XModelBase detailModel)
        {
            XProviderBase provider = null;

            switch (key)
            {
                case "grdFiles":
                    provider = XFactoryManager.CreateFactory().GetTaskAttachmentProvider();
                    break;
            }
            return provider.GetUpdateSql(detailModel);
        }

        protected override string GetDetailDeleteSql(string key, XModelBase detailInfo)
        {
            string sqlDelteDetail = string.Empty;

            switch (key)
            {
                case "grdFiles":
                    XTaskAttachmentInfo attachInfo = detailInfo as XTaskAttachmentInfo;
                    sqlDelteDetail += "DELETE FROM TaskAttachment WHERE RID='" + attachInfo.ID + "';";
                    sqlDelteDetail += "DELETE FROM FileAttachment WHERE FileId='" + attachInfo.ID + "';";
                    break;
            }

            return sqlDelteDetail;
        }

        protected override string GetDeleteAfterSql(IList<XModelBase> modelInfos)
        {
            string selectedIds = this.GetModelIds(modelInfos);

            string deleteSql = string.Empty;

            //删除文件附件
            deleteSql += "DELETE FROM FileAttachment WHERE FileId IN " +
                "(SELECT RID FROM TaskAttachment WHERE MainId IN (" + selectedIds + "))";
            //删除文件子表
            deleteSql += "DELETE FROM TaskAttachment WHERE MainId IN (" + selectedIds + ")";

            return deleteSql;
        }

        protected override bool IsOrderBy
        {
            get
            {
                return true;
            }
        }

        protected override string OrderBy
        {
            get
            {
                return " Order By TaskName asc ";
            }
        }
    }
}
