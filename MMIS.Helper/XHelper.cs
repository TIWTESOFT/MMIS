using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace MMIS.Helper
{
    /// <summary>
    /// XHelper 类
    /// 名称: 
    /// 功能: 
    /// 时间: 2011/4/30 7:44:23
    /// 作者: Lizard
    /// </summary>
    public class XHelper
    {
        #region 构造和析构

        /// <summary>
        /// 构造
        /// </summary>
        public XHelper()
        {
        }

        #endregion // 构造和析构

        #region 公有方法

        /// <summary>
        /// 获得字符串
        /// </summary>
        /// <param name="value">要转换为字符串的值</param>
        /// <returns></returns>
        public static string GetString(object value)
        {
            if (value == null)
            {
                return "";
            }
            else
            {
                return value.ToString();
            }
        }

        public static double GetDouble(object value)
        {
            if (value == null)
            {
                return 0;
            }
            else
            {
                if (IsNumberic(value.ToString()))
                {
                    return Convert.ToDouble(value);
                }
                else
                {
                    return 0;
                }
            }
        }

        public static DateTime GetDateTime(object value)
        {
            if (value == null)
            {
                return new DateTime(2000, 1, 1);
            }
            else
            {
                try
                {
                    return DateTime.Parse(value.ToString());
                }
                catch
                {
                    return new DateTime(2000, 1, 1);
                }
            }
        }
        /// <summary>
        /// 对字符进行unicode编码
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetHtmlEncode(string value)
        {
            string str = value;
            string outStr = "";
            if (!string.IsNullOrEmpty(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    //outStr += "&#x" + ((int)str[i]).ToString("x") + ";";
                    outStr += "~#x" + ((int)str[i]).ToString("x") + ";";
                }
            }
            return outStr;
        }

        /// <summary>
        /// 获得下拉列表的选择值
        /// </summary>
        /// <param name="combobox">要获得的Combobox</param>
        /// <returns></returns>
        public static string GetComboboxSelectedValue(ComboBox combobox)
        {
            if (combobox == null)
            {
                return "";
            }
            if (combobox.SelectedValue == null)
            {
                return "";
            }
            else if (combobox.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                return "";
            }
            else
            {
                return combobox.SelectedValue.ToString();
            }
        }

        /// <summary>
        /// 判断一个字符串是否数字
        /// </summary>
        /// <param name="oText"></param>
        /// <returns></returns>
        public static bool IsNumberic(string oText)
        {
            try
            {
                double var1 = Convert.ToDouble(oText);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsInteger(string value)
        {
            try
            {
                Int32 intValue = int.Parse(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static int GetInt(object value)
        {
            try
            {
                return int.Parse(value.ToString());
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// 获得数字前的字母
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string GetLettersBeforeNumber(string code)
        {
            int startLetterLength = 0;
            for (int i = 0; i < code.Length; i++)
            {
                if (Char.IsNumber(code[i]))
                {
                    startLetterLength = i;
                    break;
                }
            }
            if (startLetterLength >= 0)
            {
                return code.Substring(0, startLetterLength);
            }
            else
            {
                return string.Empty;
            }
        }

        public static string GetFormatedDate(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd");
        }

        public static string GetFormatedTime(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string GetPKByTime()
        {
            return string.Format(DateTime.Now.ToString("yyyyMMddHHmmssffffff"));
        }

        #endregion // 公有方法

        #region 保护方法
        #endregion // 保护方法

        #region 私有方法
        #endregion // 私有方法

        #region 属性及其私有变量
        #endregion // 属性及其私有变量

        public static void SendTab()
        {
            System.Windows.Forms.SendKeys.Send("{TAB}");
        }

        public static byte[] GetFileBytes(string fileName)
        {
            FileInfo fi = new FileInfo(fileName);
            if (fi.Exists == false)
            {
                return null;
                //直接返回失败
            }

            string fileDesc = string.Empty;

            byte[] bData = null;
            using (FileStream fs = fi.OpenRead())
            {
                bData = new byte[fi.Length];
                fs.Read(bData, 0, Convert.ToInt32(fi.Length));
            }

            return bData;
        }
    }
}