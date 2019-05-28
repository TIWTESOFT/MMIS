using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace MMIS.Helper
{
    public class XNetHelper
    {
        /// <summary>
        /// 获取本机IP4地址
        /// </summary>
        /// <returns></returns>
        public static string GetLocalIP4Address()
        {
            IPHostEntry IpEntry = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ipAdd in IpEntry.AddressList)
            {
                if (ipAdd.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ipAdd.ToString();
                }
            }
            return string.Empty;
        }
    }
}
