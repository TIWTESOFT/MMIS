﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MMIS.UI
{
    /// <summary>
    /// 数据库访问类 测试1.3bate版
    ///2009-08-18 XX 修改
    ///2009-09-08 增加事务的处理
    /// </summary>
    public static class SQLHelper
    {

        private static SqlConnection connection;
        public static SqlConnection Connection
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DataAccess"].ConnectionString;
                if (connection == null)
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
                return connection;
            }
        }

        /// <summary>
        /// 执行一个增删改存储过程(有参)
        /// </summary>
        /// <param name="procName">存储过程名字</param>
        /// <param name="values">参数列表</param>
        /// <returns>影响行数</returns>
        public static int ExecuteProc(string procName, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// 执行一个查询无参存储过程，要关闭
        /// </summary>
        /// <param name="procName">存储过程名字</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteProcSelect(string procName)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd.ExecuteReader();
        }
        /// <summary>
        /// 执行一个带参查询存储过程,注意要关闭
        /// </summary>
        /// <param name="procName">存储过程名字</param>
        /// <param name="values">参数列表</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteProcSelect(string procName, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteReader();
        }
        /// <summary>
        /// 执行一个无参增删改存储过程
        /// </summary>
        /// <param name="procName">存储过程名字</param>
        /// <returns>影响行数</returns>
        public static int ExecuteProc(string procName)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Connection;
            cmd.CommandText = procName;
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// 执行一个(无参)增删改语句
        /// </summary>
        /// <param name="safeSql">语句</param>
        /// <returns>影响行数</returns>
        public static int ExecuteCommand(string safeSql)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            int result = cmd.ExecuteNonQuery();
            return result;
        }
        /// <summary>
        /// 执行一个有参增删改操作
        /// </summary>
        /// <param name="sql">语句</param>
        /// <param name="values">参数</param>
        /// <returns>影响行数 </returns>
        public static int ExecuteCommand(string sql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 查询第一行第一列数据（无参）（返回的是什么类型就转换成什么类型）
        /// </summary>
        /// <param name="safeSql">语句</param>
        /// <returns>object</returns>
        public static object GetScalar(string safeSql)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            return cmd.ExecuteScalar();
        }

        /// <summary>
        /// 查询第一行第一列数据（有参）（返回的是什么类型就转换成什么类型）
        /// </summary>
        /// <param name="values">参数</param>
        /// <returns>object</returns>
        public static object GetScalar(string safeSql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteScalar();
        }

        /// <summary>
        /// 返回一个SqlDataReader（注意要关闭）
        /// </summary>
        /// <param name="safeSql">语句</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader GetReader(string safeSql)
        {
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        /// <summary>
        /// 返回int
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int GetScalarInt(string sql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        /// <summary>
        /// 返回string
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string GetScalarString(string sql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            return Convert.ToString(cmd.ExecuteScalar());
        }

        /// <summary>
        /// 返回一个有参SqlDataReader（注意要关闭）
        /// </summary>
        /// <param name="sql">语句</param>
        /// <param name="values">参数</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader GetReader(string sql, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        /// <summary>
        /// 返回一个Datatable（无参）
        /// </summary>
        /// <param name="safeSql">语句</param>
        /// <returns>DataTable</returns>
        public static DataTable GetDataSet(string safeSql)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(safeSql, Connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }
        /// <summary>
        /// 返回一个Datatable（有参）
        /// </summary>
        /// <param name="sql">语句</param>
        /// <param name="values">参数</param>
        /// <returns>DataTable</returns>
        public static DataTable GetDataSet(string sql, params SqlParameter[] values)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }
        ///// <summary>
        ///// 执行多条SQL语句，实现数据库事务。
        ///// </summary>
        ///// <param name="SQLStringList">多条SQL语句</param> 
        //public static void ExecuteSqlTran(ArrayList SQLStringList)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = Connection;
        //    SqlTransaction tx = Connection.BeginTransaction();
        //    cmd.Transaction = tx;
        //    try
        //    {
        //        for (int n = 0; n < SQLStringList.Count; n++)
        //        {
        //            string strsql = SQLStringList[n].ToString();
        //            if (strsql.Trim().Length > 1)
        //            {
        //                cmd.CommandText = strsql;
        //                cmd.ExecuteNonQuery();
        //            }
        //        }
        //        tx.Commit();
        //    }
        //    catch (System.Data.SqlClient.SqlException E)
        //    {
        //        tx.Rollback();
        //        throw new Exception(E.Message);
        //    }
        //}
    }
}
