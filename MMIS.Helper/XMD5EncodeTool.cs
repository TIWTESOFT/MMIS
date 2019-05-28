using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace MMIS.Helper
{
    public partial class XMD5EncodeTool
    {
        /// <summary>
        /// MD5加密结果
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Encode(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Default.GetBytes(str);
            byte[] result = md5.ComputeHash(data);
            String ret = "";
            for (int i = 0; i < result.Length; i++)
                ret += result[i].ToString("x").PadLeft(2, '0');
            return ret;
        }
    }
}
