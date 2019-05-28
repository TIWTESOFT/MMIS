using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing.Printing;

namespace MMIS.Helper
{
    /// <summary>
    /// XPriterHelper 类
    /// 名称: 
    /// 功能: 
    /// 时间: 9/26/2011 3:03:07 PM
    /// 作者: wss
    /// </summary>
    public class XPrinterHelper
    {
        #region 构造和析构

        /// <summary>
        /// 构造
        /// </summary>
        public XPrinterHelper()
        {
        }

        #endregion // 构造和析构

        #region 公有方法

        /// <summary>
        /// 获得计算机所连接的打印机名称
        /// </summary>
        /// <returns></returns>
        public static IList<string> GetInstalledPrinterNames()
        {
            IList<string> printerNames = new List<string>();
            foreach (string sPrint in PrinterSettings.InstalledPrinters)//获取所有打印机名称
            {
                printerNames.Add(sPrint);
            }
            return printerNames;
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