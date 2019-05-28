using System;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Win32;
using System.Management;

namespace MMIS.Helper
{
    /// <summary>
    /// XOSOperate ��
    /// ����: ϵͳ������
    /// ����: 
    /// ʱ��: 4/27/2011 4:00:44 PM
    /// ����: Wss
    /// </summary>
    public class XOSOperate
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public XOSOperate()
        {

        }

        #endregion // ���������

        #region ���з���

        /// <summary>
        /// ����Ӧ�ó��򿪻��Զ�����
        /// </summary>
        /// <param name="fileName">Ӧ�ó�����ļ���</param>
        /// <param name="isAutoRun">�Ƿ��Զ����У�Ϊfalseʱ��ȡ���Զ�����</param>
        /// <exception cref="System.Exception">���ò��ɹ�ʱ�׳��쳣</exception>
        public static void SetAutoRun(string fileName, bool isAutoRun)
        {
            RegistryKey reg = null;
            try
            {
                if (!System.IO.File.Exists(fileName))
                    throw new Exception("���������ļ�������!");
                String name = fileName.Substring(fileName.LastIndexOf("\\") + 1);
                reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (reg == null)
                    reg = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                if (isAutoRun)
                {
                    if (reg.GetValue(name) == null || reg.GetValue(name).ToString().ToUpper() != fileName.ToUpper())
                    {
                        //���û�����ÿ������������߿�������λ�ò��ǵ�ǰ�ļ������޸Ŀ�������
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
        /// ��ȡ�����ַ
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

        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���
        #endregion // ���Լ���˽�б���

    }
}