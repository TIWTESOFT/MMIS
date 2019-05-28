using MMIS.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;

namespace MMIS.DAL
{
    public partial class XFileAttachmentProvider
    {
        public new bool InsertFile(string id, string fileId, string fileName, string userId)
        {
            FileInfo fi = new FileInfo(fileName);
            if (fi.Exists == false)
            {
                return false;
                //直接返回失败
            }

            double fileSize = 0;
            fileSize = Math.Round(XHelper.GetDouble(fi.Length) / XHelper.GetDouble(1024), 2);

            string fileDesc = string.Empty;

            byte[] bData = null;
            using (FileStream fs = fi.OpenRead())
            {
                bData = new byte[fi.Length];
                fs.Read(bData, 0, Convert.ToInt32(fi.Length));
            }

            string sql = "DELETE FROM " + this.TableName + " WHERE FileId='" + fileId + "';";

            sql += "INSERT INTO " + this.TableName + "(RID,FileId,AtchName,AtchDesc,AtchType," +
               "AtchSize,AtchPath,AtchShotGifPath,AtchImag,InputUserId,InputTime)values" +
               "(@RId,@FileId,@AtchName,@AtchDesc,@AtchType,@AtchSize,@AtchPath,@AtchShotGifPath," +
               "@AtchImag,@UserId,getdate())";
            DbConnection conn = this.m_DataAccess.Connection;
            DbCommand cmd = this.m_DataAccess.GetDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;

            DbParameter parameterId = this.m_DataAccess.GetParameter("@RId", id);
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
            DbParameter parameterUser = this.m_DataAccess.GetParameter("@UserId", userId);
            cmd.Parameters.Add(parameterUser);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// 是否存在附件
        /// </summary>
        /// <param name="fileId"></param>
        /// <returns></returns>
        public bool IsFileExist(string fileId)
        {
            string sql = "SELECT COUNT(*) FROM " + this.TableName + " WHERE FileId='{0}'";
            sql = string.Format(sql, fileId);
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }

        public string DownLoadFile(string fileId, string filePath, string fileName)
        {
            string sql = "SELECT AtchImag,AtchName,AtchType FROM " + this.TableName + " WHERE FileId = '" + fileId + "'";
            DbConnection conn = this.m_DataAccess.Connection;
            DbDataAdapter adp = this.m_DataAccess.GetDbDataAdapter(conn, sql);
            DataTable dt = new DataTable();

            byte[] bData = null;
            string fName = fileName;
            try
            {
                //从服务器获取文件
                adp.Fill(dt);
                DataRow dr = null;
                if (dt.Rows.Count > 0)
                {
                    dr = dt.Rows[0];
                    if (((!object.ReferenceEquals(dr["AtchImag"], DBNull.Value))))
                    {
                        bData = (byte[])dr["AtchImag"];
                    }
                    if (fName == string.Empty)
                    {
                        fName = XHelper.GetString(dr["AtchName"]);
                    }
                    else
                    {
                        fName += XHelper.GetString(dr["AtchType"]);
                    }
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
                return string.Empty;
            }
            finally
            {
                adp.Dispose();
            }

            //存文件
            if (((bData != null)))
            {
                if (filePath == System.Windows.Forms.Application.StartupPath + "\\WssTemp")
                {
                    if (Directory.Exists(filePath))
                    {
                        string[] fileNames = Directory.GetFiles(filePath);
                        foreach (string deleteFileName in fileNames)
                        {
                            try
                            {
                                File.Delete(deleteFileName);
                            }
                            catch (Exception ex)
                            {
                                XErrorLogTool.WriteLog(ex.ToString());
                            }
                        }
                    }
                }

                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                fName = filePath + "\\" + fName;
                FileInfo fi = new FileInfo(fName);
                //不存在
                if (!fi.Exists)
                {
                    using (FileStream fs = fi.Create())
                    {
                        fs.Write(bData, 0, bData.Length);
                    }
                }
                else
                {
                    XMessageBox.ShowError("要下载的文件：[" + fi.Name + "]在目录：\r\n" + filePath + "已存在！");
                    return string.Empty;
                }
            }
            return fName;
        }

        public string DownloadFile(string fileId, string path)
        {
            string fileFullName = this.DownLoadFile(fileId, path, "");
            return fileFullName;
            //if (fileFullName == string.Empty)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }
    }
}
