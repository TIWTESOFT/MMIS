using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data;

namespace MMIS.Helper
{
    /// <summary>
    /// XDataTableHelper 类
    /// 名称: 
    /// 功能: 
    /// 时间: 9/6/2011 9:33:28 AM
    /// 作者: wss
    /// </summary>
    public class XDataTableHelper
    {
        #region 构造和析构

        /// <summary>
        /// 构造
        /// </summary>
        public XDataTableHelper()
        {
           
        }

        #endregion // 构造和析构

        #region 公有方法

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="columnName"></param>
        /// <param name="sort"></param>
        /// <returns></returns>
        public static DataTable DataTableSort(DataTable dt, string columnName, string sort) //按字符串的ascii码值给DataTable排序
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int m = i;     //保存的是每一轮比较中最小值或最小值的索引
                for (int j = i + 1; j < dt.Rows.Count; j++)
                {
                    if (sort.ToUpper() == "ASC")  //升序排列
                    {
                        if (dt.Rows[m][columnName].ToString().CompareTo(dt.Rows[j][columnName].ToString()) > 0)
                        {
                            m = j;
                        }
                    }
                    else if (sort.ToUpper() == "DESC")  //降序排列
                    {
                        if (dt.Rows[m][columnName].ToString().CompareTo(dt.Rows[j][columnName].ToString()) < 0)
                        {
                            m = j;
                        }
                    }
                }
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    string temp = null;
                    temp = dt.Rows[i][c].ToString();
                    dt.Rows[i][c] = dt.Rows[m][c];
                    dt.Rows[m][c] = temp;
                }
            }
            return dt;
        }

        public static void CopyDataRow(DataRow srcRow, DataRow descRow)
        {
            if (srcRow == null || descRow == null)
            {
                return;
            }
            foreach (DataColumn srcColumn in srcRow.Table.Columns)
            {
                if (descRow.Table.Columns.Contains(srcColumn.ColumnName))
                {
                    descRow[srcColumn.ColumnName] = srcRow[srcColumn.ColumnName];
                }
            }
        }

        #endregion // 公有方法

        #region 保护方法
        #endregion // 保护方法

        #region 私有方法
        #endregion // 私有方法

        #region 属性及其私有变量
        #endregion // 属性及其私有变量

    }
}