using MMIS.Helper;
using MMIS.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;

namespace MMIS.DAL
{
    public partial class XTaskAttachmentProvider
    {
        protected override XModelBase InitViewModel()
        {
            return new XVTaskAttachmentInfo();
        }
    }
}
