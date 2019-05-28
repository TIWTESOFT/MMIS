using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Configuration;
using HRMS.Helper;

namespace HRMS.DAL
{
    public class XDataAccessBase
    {
        public XDataAccessBase()
        {
            this.m_ConnectString = this.GetConnectString();
            this.m_Connection = this.GetDbConnection();
            this.m_Connection.ConnectionString = this.m_ConnectString;
        }

        protected string m_ConnectString;

        /// <summary>
        /// 获取数据库连接串
        /// </summary>
        /// <returns></returns>
        protected virtual string GetConnectString()
        {
            return this.GetConfigString();
        }

        /// <summary>
        /// 获取配置文件连接串
        /// </summary>
        /// <returns></returns>
        protected virtual string GetConfigString()
        {
            //return "data source=.;user id=sa;password=zhimakaimen;initial catalog=HRMS; Connect Timeout=30;Persist Security Info=True ;Current Language=Simplified Chinese;";
            return ConfigurationManager.ConnectionStrings["DataAccess"].ToString();
            //return null;
        }

        /// <summary>
        /// 数据库连接串
        /// </summary>
        public string ConnectString
        {
            get { return this.m_ConnectString; }
            set { this.m_ConnectString = value; }
        }

        private DbConnection m_Connection;

        /// <summary>
        /// 数据库连接对象
        /// </summary>
        public DbConnection Connection
        {
            get { return this.m_Connection; }
            set { this.m_Connection = value; }
        }

        /// <summary>
        /// 初始化数据库连接
        /// </summary>
        public virtual DbConnection GetDbConnection()
        {
            return null;
        }

        /// <summary>
        /// 获取查询表
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public virtual DataTable GetDataTable(string sql)
        {
            if (sql.Trim() == string.Empty)
            {
                return null;
            }
            else
            {
                try
                {
                    if (this.m_Connection.State == ConnectionState.Closed)
                    {
                        this.m_Connection.Open();
                    }
                    DbDataAdapter adp = this.GetDbDataAdapter(this.m_Connection, sql);
                    DataTable queryTable = new DataTable();
                    adp.Fill(queryTable);
                    return queryTable;
                }
                catch (Exception ex)
                {
                    XErrorLogTool.WriteLog(ex.ToString());
                    return null;
                }
            }
        }

        /// <summary>
        /// 获取数据适配器
        /// </summary>
        /// <returns></returns>
        public virtual DbDataAdapter GetDbDataAdapter(DbConnection conn, string sql)
        {
            return null;
        }

        /// <summary>
        /// 执行Sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>执行失败则返回0或者-1</returns>
        public virtual int ExecuteNonQuery(string sql)
        {
            DbCommand cmd = this.GetDbCommand();
            if (cmd == null || this.m_Connection == null)
            {
                return -1;
            }
            try
            {
                if (this.m_Connection.State == ConnectionState.Closed)
                {
                    this.m_Connection.Open();
                }
                cmd.Connection = this.m_Connection;
                cmd.CommandText = sql;
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
                return -1;
            }
        }

        /// <summary>
        /// 执行Sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>执行失败则返回0或者-1</returns>
        public virtual int ExecuteNonQueryNotCatchException(string sql)
        {
            DbCommand cmd = this.GetDbCommand();
            if (cmd == null || this.m_Connection == null)
            {
                return -1;
            }
            if (this.m_Connection.State == ConnectionState.Closed)
            {
                this.m_Connection.Open();
            }
            cmd.Connection = this.m_Connection;
            cmd.CommandText = sql;
            return cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// 执行Sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>执行失败则返回0或者-1</returns>
        public virtual int ExecuteNonQueryByTrans(string sql)
        {
            DbTransaction trans = null;
            try
            {
                if (this.m_Connection.State == ConnectionState.Closed)
                {
                    this.m_Connection.Open();
                }
                trans = this.m_Connection.BeginTransaction();
                DbCommand cmd = this.GetDbCommand();
                if (cmd == null || this.m_Connection == null)
                {
                    return -1;
                }
                cmd.Connection = this.m_Connection;
                cmd.CommandText = sql;
                cmd.Transaction = trans;
                int count = cmd.ExecuteNonQuery();

                trans.Commit();
                return count;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                XErrorLogTool.WriteLog(ex.ToString());
                return -1;
            }
            finally
            {
                if (trans != null)
                {
                    trans.Dispose();
                }
            }
        }

        /// <summary>
        /// 通过事务执行Sql语句
        /// </summary>
        /// <param name="sqlList">sql语句集合</param>
        /// <returns></returns>
        public virtual bool ExecuteNonQuery(IList<string> sqlList)
        {
            DbTransaction trans = null;
            try
            {
                if (this.m_Connection.State == ConnectionState.Closed)
                {
                    this.m_Connection.Open();
                }
                trans = this.m_Connection.BeginTransaction();
                DbCommand cmd = this.GetDbCommand();
                cmd.Connection = this.m_Connection;
                cmd.Transaction = trans;
                foreach (string sql in sqlList)
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (trans != null)
                {
                    trans.Rollback();
                }
                XErrorLogTool.WriteLog(ex.ToString());
                return false;
            }
            finally
            {
                if (trans != null)
                {
                    trans.Dispose();
                }
            }
        }

        /// <summary>
        /// 获得执行命令的对象
        /// </summary>
        /// <returns></returns>
        public virtual DbCommand GetDbCommand()
        {
            return null;
        }

        /// <summary>
        /// 获得Reader对象
        /// </summary>
        /// <returns></returns>
        public virtual DbDataReader GetDbDataReader(string sql)
        {
            DbCommand cmd = this.GetDbCommand();
            if (cmd == null || this.m_Connection == null)
            {
                return null;
            }
            try
            {
                if (this.m_Connection.State == ConnectionState.Closed)
                {
                    this.m_Connection.Open();
                }
                cmd.Connection = this.m_Connection;
                cmd.CommandText = sql;
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
                return null;
            }
        }


        /// <summary>
        /// 获得执行结果第一行第一列的值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public virtual object ExecuteScalar(string sql)
        {
            DbCommand cmd = this.GetDbCommand();
            if (cmd == null || this.m_Connection == null)
            {
                return null;
            }
            try
            {
                if (this.m_Connection.State == ConnectionState.Closed)
                {
                    this.m_Connection.Open();
                }
                cmd.Connection = this.m_Connection;
                cmd.CommandText = sql;
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
                return null;
            }
        }

        /// 获取系统时间函数
        /// </summary>
        /// <returns></returns>
        public virtual string GetServerTimeFuncion()
        {
            return string.Empty;
        }

        public virtual DbParameter GetParameter(string name, object value)
        {
            return null;
        }
    }
}
