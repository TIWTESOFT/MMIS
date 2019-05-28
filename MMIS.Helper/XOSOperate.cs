using System;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Management;

namespace MMIS.Helper
{
    /// <summary>
    /// XOSOperate 类
    /// 名称: 系统操作类
    /// 功能: 
    /// 时间: 4/27/2011 4:00:44 PM
    /// 作者: Wss
    /// </summary>
    public class XOSOperate
    {
        #region 构造和析构

        /// <summary>
        /// 构造
        /// </summary>
        public XOSOperate()
        {

        }

        #endregion // 构造和析构

        #region 公有方法

        /// <summary>
        /// 设置应用程序开机自动运行
        /// </summary>
        /// <param name="fileName">应用程序的文件名</param>
        /// <param name="isAutoRun">是否自动运行，为false时，取消自动运行</param>
        /// <exception cref="System.Exception">设置不成功时抛出异常</exception>
        public static void SetAutoRun(string fileName, bool isAutoRun)
        {
            RegistryKey reg = null;
            try
            {
                if (!System.IO.File.Exists(fileName))
                    throw new Exception("开机启动文件不存在!");
                String name = fileName.Substring(fileName.LastIndexOf("\\") + 1);
                reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (reg == null)
                    reg = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                if (isAutoRun)
                {
                    if (reg.GetValue(name) == null || reg.GetValue(name).ToString().ToUpper() != fileName.ToUpper())
                    {
                        //如果没有设置开机启动，或者开机启动位置不是当前文件，则修改开机启动
                        reg.SetValue(name, fileName);
                    }
                }
                else
                {
                    reg.SetValue(name, false);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (reg != null)
                    reg.Close();
            }
        }

        public bool IsFileAutoRun(string fileName)
        {
            if (!System.IO.File.Exists(fileName))
                return false;
            String name = fileName.Substring(fileName.LastIndexOf("\\") + 1);
            RegistryKey reg = null;
            reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (reg == null || reg.GetValue(name) == null)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 获取物理地址
        /// </summary>
        /// <returns></returns>
        public static string GetMac()
        {

            System.Management.ManagementClass mc = new System.Management.ManagementClass("Win32_NetworkAdapterConfiguration");
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"] == true)
                    sb.Append(mo["MacAddress"].ToString());
                mo.Dispose();
            }
            return (sb.ToString());

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