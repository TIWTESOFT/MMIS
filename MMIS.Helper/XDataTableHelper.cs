using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data;

namespace MMIS.Helper
{
    /// <summary>
    /// XDataTableHelper ��
    /// ����: 
    /// ����: 
    /// ʱ��: 9/6/2011 9:33:28 AM
    /// ����: wss
    /// </summary>
    public class XDataTableHelper
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public XDataTableHelper()
        {
           
        }

        #endregion // ���������

        #region ���з���

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="columnName"></param>
        /// <param name="sort"></param>
        /// <returns></returns>
        public static DataTable DataTableSort(DataTable dt, string columnName, string sort) //���ַ�����ascii��ֵ��DataTable����
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int m = i;     //�������ÿһ�ֱȽ�����Сֵ����Сֵ������
                for (int j = i + 1; j < dt.Rows.Count; j++)
                {
                    if (sort.ToUpper() == "ASC")  //��������
                    {
                        if (dt.Rows[m][columnName].ToString().CompareTo(dt.Rows[j][columnName].ToString()) > 0)
                        {
                            m = j;
                        }
                    }
                    else if (sort.ToUpper() == "DESC")  //��������
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

        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        #endregion // ���Լ���˽�б���

    }
}