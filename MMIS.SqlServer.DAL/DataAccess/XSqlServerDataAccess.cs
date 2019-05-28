using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;

namespace MMIS.DAL
{
    public class XSqlServerDataAccess : XDataAccessBase
    {
        public override DbConnection GetDbConnection()
        {
            return new SqlConnection();
        }

        public override DbCommand GetDbCommand()
        {
            return new SqlCommand();
        }

        public override DbDataAdapter GetDbDataAdapter(DbConnection conn, string sql)
        {
            return new SqlDataAdapter(sql, conn as SqlConnection);
        }

        public override DbParameter GetParameter(string name, object value)
        {
            return new SqlParameter(name, value);
        }
    }
}
