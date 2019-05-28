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
            //    strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + fileName + ";Extended Properties='Excel 12.0; HDR=YES; IMEX=1'"; //�����ӿ��Բ���.xls��.xlsx�ļ�
            //}
            strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + fileName + ";Extended Properties='Excel 12.0; HDR=YES; IMEX=1'"; //�����ӿ��Բ���.xls��.xlsx�ļ�


            OleDbConnection conn = null;
            System.Data.DataTable dtExcel = new System.Data.DataTable();
            try
            {
                conn = new OleDbConnection(strConn);
                conn.Open();
                //ȡ�ñ���
                System.Data.DataTable schemaTable = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
                string tableName = schemaTable.Rows[0][2].ToString().Trim();
                if (tableName == "_xlnm#_FilterDatabase" && schemaTable.Rows.Count > 1)
                {
                    tableName = schemaTable.Rows[1][2].ToString().Trim();
                }
                //������Ϊ������   
                string sql = " select * from [" + tableName + "] where 1=1 ";
                OleDbCommand oleCommand = new OleDbCommand(sql, conn);
                OleDbDataAdapter oleAdapter = new OleDbDataAdapter(oleCommand);
                DataSet myDataSet = new DataSet();
                // �� Excel ��[Sheet1]��������䵽 DataSet ����  
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
