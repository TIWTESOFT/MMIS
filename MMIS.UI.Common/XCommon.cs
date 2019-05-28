using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Model;
using System.Windows.Forms;

namespace MMIS.UI.Common
{
    public class XCommon
    {
        public static float gFontSize = 10.00F;//系统字体大小

        public static XUsersInfo LoginUsersInfo;

        public static string LoginId = string.Empty;

        //public static string TempPath = "C:\\WssTemp";
        public static string TempPath = Application.StartupPath + "\\WssTemp";
    }
}
