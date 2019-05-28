using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XSelectFileTypeEditBox : XSelectEditBox
    {
        protected override Common.frmListBase GetSelectForm()
        {
            return new frmSelectFileType();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XCodeFileTypeInfo info = selectedModel as XCodeFileTypeInfo;
            if (info != null)
            {
                return info.NameCN;
            }
            else
            {
                return string.Empty;
            }
        }

        protected override string GetValueMember(XModelBase selectedModel)
        {
            XCodeFileTypeInfo info = selectedModel as XCodeFileTypeInfo;
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
