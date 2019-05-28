using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XSelectCodeTaskTypeEditBox : XSelectEditBox
    {
        protected override Common.frmListBase GetSelectForm()
        {
            return new frmSelectCodeTaskTypeList();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XCodeTaskTypeInfo info = selectedModel as XCodeTaskTypeInfo;
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
            XCodeTaskTypeInfo info = selectedModel as XCodeTaskTypeInfo;
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
