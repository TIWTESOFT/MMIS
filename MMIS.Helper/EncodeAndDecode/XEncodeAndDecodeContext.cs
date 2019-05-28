using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.Helper
{
    public class XEncodeAndDecodeContext
    {
        public static XEncodeAndDecodeBase GetEncodeAndDecodeTool(EncodeType type)
        {
            switch (type)
            {
                case EncodeType.DesEncode:
                    return new XDesEncodeDecode();
                case EncodeType.Md5:
                    return new XMD5EncodeAndDecode();
                default:
                    return null;
            }
        }
    }
}
