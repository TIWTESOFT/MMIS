using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace MMIS.Helper
{
    /// <summary>
    /// XErrorLogTool 类
    /// 名称: 
    /// 功能: 
    /// 时间: 9/7/2011 10:40:16 AM
    /// 作者: wss
    /// </summary>
    public class XErrorLogTool
    {
        #region 构造和析构

        /// <summary>
        /// 构造
        /// </summary>
        public XErrorLogTool()
        {
        }

        #endregion // 构造和析构

        #region 公有方法

        public static void WriteLog(string exception, string logFileDirectory = "", string logFileName = "")
        {
            m_Exception = exception;
            m_logFileDirectory = logFileDirectory;
            m_logFileName = logFileName;
            Thread thread = new Thread(new ThreadStart(WriteLogByThread));
            thread.Start();
        }

        private static void WriteLogByThread()
        {
            try
            {
                if (m_logFileDirectory == string.Empty)
                {
                    m_logFileDirectory = AppDomain.CurrentDomain.BaseDirectory + "\\ErrorLog";
                    if (!Directory.Exists(m_logFileDirectory))
                    {
                        Directory.CreateDirectory(m_logFileDirectory);
                    }
                }

                if (m_logFileName.Trim() == string.Empty)
                {
                    m_logFileName = DateTime.Now.Date.ToString("yyyy-MM-dd") + "_ErrorLog.txt";
                }
                FileMode fileMode = FileMode.CreateNew;
                string logFileFullName = m_logFileDirectory + "\\" + m_logFileName;
                if (File.Exists(logFileFullName))
                {
                    fileMode = FileMode.Append;
                }
                using (FileStream fs = new System.IO.FileStream(logFileFullName,
                        fileMode, FileAccess.Write))
                {

                    using (System.IO.StreamWriter w = new System.IO.StreamWriter(fs,

                         System.Text.Encoding.UTF8))
                    {
                        string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n";
                        string seperator = "*********************************************\r\n";
                        w.WriteLine(seperator + currentTime + m_Exception + "\r\n" + seperator);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion // 公有方法

        #region 保护方法
        #endregion // 保护方法

        #region 私有方法
        #endregion // 私有方法

        #region 属性及其私有变量

        private static string m_Exception = "";

        private static string m_logFileDirectory = "";

        private static string m_logFileName = "";

        #endregion // 属性及其私有变量

    }
}