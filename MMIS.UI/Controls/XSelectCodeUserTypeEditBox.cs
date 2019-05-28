using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XSelectCodeUserTypeEditBox : XSelectEditBox
    {
        protected override Common.frmListBase GetSelectForm()
        {
            return new frmSelectCodeUserType();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XCodeUserTypeInfo info = selectedModel as XCodeUserTypeInfo;
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
            XCodeUserTypeInfo info = selectedModel as XCodeUserTypeInfo;
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
