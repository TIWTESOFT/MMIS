using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;

namespace MMIS.Helper
{
    /// <summary>
    /// XColorHelper ��
    /// ����: 
    /// ����: 
    /// ʱ��: 10/9/2011 2:37:32 PM
    /// ����: wss
    /// </summary>
    public class XColorHelper
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public XColorHelper()
        {
          
        }

        #endregion // ���������

        #region ���з���

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

        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        #endregion // ���Լ���˽�б���

    }
}