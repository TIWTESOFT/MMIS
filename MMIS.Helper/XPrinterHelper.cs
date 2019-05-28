using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing.Printing;

namespace MMIS.Helper
{
    /// <summary>
    /// XPriterHelper ��
    /// ����: 
    /// ����: 
    /// ʱ��: 9/26/2011 3:03:07 PM
    /// ����: wss
    /// </summary>
    public class XPrinterHelper
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public XPrinterHelper()
        {
        }

        #endregion // ���������

        #region ���з���

        /// <summary>
        /// ��ü���������ӵĴ�ӡ������
        /// </summary>
        /// <returns></returns>
        public static IList<string> GetInstalledPrinterNames()
        {
            IList<string> printerNames = new List<string>();
            foreach (string sPrint in PrinterSettings.InstalledPrinters)//��ȡ���д�ӡ������
            {
                printerNames.Add(sPrint);
            }
            return printerNames;
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