using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace MMIS.Helper
{
    public class XImportExcelTool
    {
        public static System.Data.DataTable GetDataFormExcel(string fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            string strConn = string.Empty;
            //if (fileInfo.Extension.ToUpper() == ".XLS")
            //{
            //    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + fileName + ";" + "Extended Properties=Excel 8.0;";
            //}
            //else
            //{
            //    strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + fileName + ";Extended Properties='Excel 12.0; HDR=YES; IMEX=1'"; //此连接可以操作.xls与.xlsx文件
            //}
            strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + fileName + ";Extended Properties='Excel 12.0; HDR=YES; IMEX=1'"; //此连接可以操作.xls与.xlsx文件


            OleDbConnection conn = null;
            System.Data.DataTable dtExcel = new System.Data.DataTable();
            try
            {
                conn = new OleDbConnection(strConn);
                conn.Open();
                //取得表名
                System.Data.DataTable schemaTable = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
                string tableName = schemaTable.Rows[0][2].ToString().Trim();
                if (tableName == "_xlnm#_FilterDatabase" && schemaTable.Rows.Count > 1)
                {
                    tableName = schemaTable.Rows[1][2].ToString().Trim();
                }
                //第三行为表数据   
                string sql = " select * from [" + tableName + "] where 1=1 ";
                OleDbCommand oleCommand = new OleDbCommand(sql, conn);
                OleDbDataAdapter oleAdapter = new OleDbDataAdapter(oleCommand);
                DataSet myDataSet = new DataSet();
                // 将 Excel 的[Sheet1]表内容填充到 DataSet 对象  
                oleAdapter.Fill(myDataSet, tableName);
                System.Data.DataTable dt = myDataSet.Tables[0];
                return dt;
            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.Message);
                return null;
            }
            finally
            {
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }
    }
}
