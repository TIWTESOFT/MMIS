using System;
using System.Collections.Generic;
using System.Configuration;

using System.Text;

namespace MMIS.Helper
{
    public partial class XAppSettingHelper
    {
        public static void Save(string key, string value)
        {
            // 写入参数设置  
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();
        }

        public static void Save(IList<XAppSettingInfo> settingInfos)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            foreach (XAppSettingInfo settingInfo in settingInfos)
            {
                configuration.AppSettings.Settings[settingInfo.Key].Value = settingInfo.Value;
            }
            configuration.Save();
        }
    }
}
