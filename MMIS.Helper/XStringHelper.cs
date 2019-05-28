using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.Helper
{
    public static class XStringHelper
    {
        public static string LeftPad(string srcString, int length, char c)
        {
            if (srcString.Length > length)
            {
                return srcString;
            }
            int padLength = length - srcString.Length;
            for (int i = 1; i <= padLength; i++)
            {
                srcString = c + srcString;
            }
            return srcString;
        }
    }
}
