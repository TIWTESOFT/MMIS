using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Xml;
using MMIS.Helper;

namespace MMIS.Helper
{
    /// <summary>
    /// XmlTool ��
    /// ����: 
    /// ����: 
    /// ʱ��: 9/9/2011 11:20:17 AM
    /// ����: wss
    /// </summary>
    public class XmlTool
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public XmlTool()
        {
        }

        #endregion // ���������

        #region ���з���

        /// <summary>
        /// ��ȡ�ڵ�ֵ
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public string GetNodeValue(XmlNode node)
        {
            if (node != null)
            {
                return node.InnerText.Trim();
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// ��ȡ�ӽڵ�ֵ
        /// </summary>
        /// <param name="parentNode"></param>
        /// <param name="nodeName"></param>
        /// <returns></returns>
        public string GetChildNodeValue(XmlNode parentNode, string nodeName)
        {
            if (parentNode == null)
            {
                return string.Empty;
            }
            XmlNode childNode = parentNode.SelectSingleNode(nodeName);
            if (childNode == null)
            {
                return string.Empty;
            }
            else
            {
                return this.GetNodeValue(childNode);
            }
        }

        public bool SetChildNodeValue(XmlNode parentNode, string nodeName, string value)
        {
            if (parentNode == null)
            {
                return false;
            }
            XmlNode childNode = parentNode.SelectSingleNode(nodeName);
            if (childNode == null)
            {
                return false;
            }
            else
            {
                childNode.InnerText = value;
                return true;
            }
        }

        public string GetNodeAttributValue(XmlNode node, string attributName)
        {
            if (node == null)
            {
                return string.Empty;
            }
            try
            {
                return node.Attributes[attributName].InnerText.Trim();
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
                return string.Empty;
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