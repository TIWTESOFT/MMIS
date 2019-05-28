using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XSelectCodeFolderTypeEditBox : XTreeSelectEditBox
    {
        protected override Common.frmTreeBase GetSelectForm()
        {
            return new frmSelectCodeFolderType();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XCodeFolderTypeInfo info = selectedModel as XCodeFolderTypeInfo;
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
            XCodeFolderTypeInfo info = selectedModel as XCodeFolderTypeInfo;
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
