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
    public partial class XEquipmentPDFReportProvider
    {
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
                fName = filePath + "\\" + fName;

                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

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
                    XMessageBox.ShowError("要下载的文件[" + fi.Name + "]在目录：\r\n" + filePath + "已存在！");
                    return string.Empty;
                }
            }
            return fName;
        }

    }
}
