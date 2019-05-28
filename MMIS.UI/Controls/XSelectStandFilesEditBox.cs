using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XSelectStandFilesEditBox : XSelectEditBox
    {
        protected override Common.frmListBase GetSelectForm()
        {
            return new frmSelectStandFiles();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XStandFilesInfo info = selectedModel as XStandFilesInfo;
            if (info != null)
            {
                return info.FileName;
            }
            else
            {
                return string.Empty;
            }
        }

        protected override string GetValueMember(XModelBase selectedModel)
        {
            XStandFilesInfo info = selectedModel as XStandFilesInfo;
            if (info != null)
            {
                return info.RID;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
