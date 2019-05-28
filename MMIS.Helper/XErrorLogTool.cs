using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace MMIS.Helper
{
    /// <summary>
    /// XErrorLogTool ��
    /// ����: 
    /// ����: 
    /// ʱ��: 9/7/2011 10:40:16 AM
    /// ����: wss
    /// </summary>
    public class XErrorLogTool
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public XErrorLogTool()
        {
        }

        #endregion // ���������

        #region ���з���

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

        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���

        private static string m_Exception = "";

        private static string m_logFileDirectory = "";

        private static string m_logFileName = "";

        #endregion // ���Լ���˽�б���

    }
}