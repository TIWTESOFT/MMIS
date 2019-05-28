using MMIS.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace MMIS.UI
{
    public partial class XSystemConfigTool
    {
        private XmlTool m_XmlTool = new XmlTool();
        private string m_ConfigFileName = "SystemConfig.config";

        public XSystemConfigInfo GetConfigInfo()
        {
            XmlDocument dct = new XmlDocument();
            dct.Load(m_ConfigFileName);

            XSystemConfigInfo configInfo = new XSystemConfigInfo();

            XmlNode signNode = dct.SelectSingleNode("SystemConfigs/SignConfig");

            if (signNode != null)
            {
                configInfo.SignWidht = XHelper.GetInt(m_XmlTool.GetNodeAttributValue(signNode, "SignWidth"));
                configInfo.SignHeight = XHelper.GetInt(m_XmlTool.GetNodeAttributValue(signNode, "SignHeight"));
                configInfo.RefreshMinutes = XHelper.GetInt(m_XmlTool.GetNodeAttributValue(signNode, "RefreshMinutes"));
            }

            return configInfo;
        }

        public bool SaveConfigInfo(XSystemConfigInfo configInfo)
        {
            XmlDocument dct = new XmlDocument();
            dct.Load(m_ConfigFileName);

            XmlNode signNode = dct.SelectSingleNode("SystemConfigs/SignConfig");

            signNode.Attributes["SignWidth"].Value = configInfo.SignWidht.ToString();
            signNode.Attributes["SignHeight"].Value = configInfo.SignHeight.ToString();
            signNode.Attributes["RefreshMinutes"].Value = configInfo.RefreshMinutes.ToString();
            try
            {
                dct.Save(m_ConfigFileName);
                return true;
            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.Message);
                XErrorLogTool.WriteLog(ex.ToString());
                return false;
            }
        }
    }
}
