using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Xml;
using MMIS.Helper;

namespace MMIS.Helper
{
    /// <summary>
    /// XmlTool 类
    /// 名称: 
    /// 功能: 
    /// 时间: 9/9/2011 11:20:17 AM
    /// 作者: wss
    /// </summary>
    public class XmlTool
    {
        #region 构造和析构

        /// <summary>
        /// 构造
        /// </summary>
        public XmlTool()
        {
        }

        #endregion // 构造和析构

        #region 公有方法

        /// <summary>
        /// 获取节点值
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
        /// 获取子节点值
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

        #endregion // 公有方法

        #region 保护方法
        #endregion // 保护方法

        #region 私有方法
        #endregion // 私有方法

        #region 属性及其私有变量
        #endregion // 属性及其私有变量

    }
}