using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.Helper
{
    public abstract class XEncodeAndDecodeBase
    {
        public abstract string Encode(string srcString);

        public abstract string Decode(string srcString);
    }
}
