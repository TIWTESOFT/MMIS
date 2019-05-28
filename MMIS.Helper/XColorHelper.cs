using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;

namespace MMIS.Helper
{
    /// <summary>
    /// XColorHelper 类
    /// 名称: 
    /// 功能: 
    /// 时间: 10/9/2011 2:37:32 PM
    /// 作者: wss
    /// </summary>
    public class XColorHelper
    {
        #region 构造和析构

        /// <summary>
        /// 构造
        /// </summary>
        public XColorHelper()
        {
          
        }

        #endregion // 构造和析构

        #region 公有方法

        public static Color GetColorFormStringRgb(string rgb, char seperator = ',')
        {
            string[] rgbArray = rgb.Split(seperator);
            if (rgbArray.Length == 3)
            {
                int r=XHelper.GetInt(rgbArray[0]);
                int g=XHelper.GetInt(rgbArray[1]);
                int b=XHelper.GetInt(rgbArray[2]);
                return Color.FromArgb(r, g, b);
            }
            return Color.Black;
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