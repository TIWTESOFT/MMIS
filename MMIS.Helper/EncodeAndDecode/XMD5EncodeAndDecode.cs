using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MMIS.Helper
{
    public class XMD5EncodeAndDecode : XEncodeAndDecodeBase
    {
        public override string Encode(string srcString)
        {
            MD5 md5Hasher = MD5.Create();

            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(srcString));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public override string Decode(string srcString)
        {
            throw new NotImplementedException();
        }
    }
}
