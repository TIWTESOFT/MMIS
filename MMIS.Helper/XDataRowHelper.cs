using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Helper
{
    public class XDataRowHelper
    {
        /// <summary>
        /// 获得裂的字段值
        /// </summary>
        /// <param name="row"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        public static object GetFieldValue(DataRow row, string fieldName)
        {
            if (row.Table.Columns.Contains(fieldName))
            {
                return row[fieldName];
            }
            else
            {
                return null;
            }
        }
    }
}
