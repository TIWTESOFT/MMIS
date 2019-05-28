using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using System.Configuration;
using MMIS.Helper;

namespace MMIS.DAL
{
    public partial class XDataAccessBase
    {
        public XDataAccessBase()
        {
            this.m_ConnectString = this.GetConnectString();
            this.m_Connection = this.GetDbConnection();
            this.m_Connection.ConnectionString = this.m_ConnectString;
            this.Init();
        }

        protected string a;
        protected string b;

        protected XDesEncodeDecode m_EncodeAndDecodeTool;

        protected virtual void Init()
        {
            this.m_EncodeAndDecodeTool = new XDesEncodeDecode();
            a = m_EncodeAndDecodeTool.Encode("wsslmm123");
            b = m_EncodeAndDecodeTool.Encode("lmmwss321");
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
            //TODO:发布前修改
            //return "data source=172.16.11.28,1745;user id=sa;password=yqswa1013;initial catalog=MMIS; Connect Timeout=30;Persist Security Info=True ;Current Language=Simplified Chinese;";
          //  return "data source=WIN764;user id=sa;password=wa1013;initial catalog=MMIS; Connect Timeout=30;Persist Security Info=True ;Current Language=Simplified Chinese;";

            return ConfigurationManager.ConnectionStrings["DataAccess"].ConnectionString;
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
            try
            {
                DataTable dt = new DataTable();
                DbDataAdapter adapter = this.GetDbDataAdapter(this.m_Connection, sql);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.Message);
                XErrorLogTool.WriteLog(ex.ToString());
                return null;
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
            try
            {
                if (this.m_Connection.State == ConnectionState.Closed)
                {
                    this.m_Connection.Open();
                }
                DbCommand command = this.GetDbCommand();
                command.Connection = this.m_Connection;
                command.CommandText = sql;
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.Message);
                XErrorLogTool.WriteLog(ex.ToString());
                return -1;
            }
            finally
            {
                if (this.m_Connection != null && this.m_Connection.State == ConnectionState.Open)
                {
                    this.m_Connection.Close();
                }
            }
        }

        /// <summary>
        /// 执行Sql语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>执行失败则返回0或者-1</returns>
        public virtual int ExecuteNonQueryNotCatchException(string sql)
        {
            if (this.m_Connection.State == ConnectionState.Closed)
            {
                this.m_Connection.Open();
            }
            DbCommand command = this.GetDbCommand();
            command.Connection = this.m_Connection;
            command.CommandText = sql;
            this.m_Connection.Close();
            return command.ExecuteNonQuery();
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
                DbCommand command = this.GetDbCommand();
                command.Transaction = trans;
                command.CommandText = sql;
                command.Connection = this.m_Connection;
                int result = command.ExecuteNonQuery();
                trans.Commit();
                return result;
            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.ToString());
                XErrorLogTool.WriteLog(ex.ToString());
                trans.Rollback();
                return -1;
            }
            finally
            {
                if (this.m_Connection.State == ConnectionState.Open)
                {
                    this.m_Connection.Close();
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
            string sqls = string.Empty;

            foreach (string sql in sqlList)
            {
                sqls += sql + ";";
            }
            try
            {
                return this.ExecuteNonQueryByTrans(sqls) > 0;
            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.Message);
                XErrorLogTool.WriteLog(ex.ToString());
                return false;
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
        /// 获得执行结果第一行第一列的值
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public virtual object ExecuteScalar(string sql)
        {
            try
            {
                if (this.m_Connection.State == ConnectionState.Closed)
                {
                    this.m_Connection.Open();
                }
                DbCommand command = this.GetDbCommand();
                command.Connection = this.m_Connection;
                command.CommandText = sql;
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.Message);
                XErrorLogTool.WriteLog(ex.ToString());
                return null;
            }
            finally
            {
                if (this.m_Connection != null && this.m_Connection.State == ConnectionState.Closed)
                {
                    this.m_Connection.Close();
                }
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
