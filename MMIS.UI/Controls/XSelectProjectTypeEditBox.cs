using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XSelectProjectTypeEditBox : XSelectEditBox
    {
        protected override Common.frmListBase GetSelectForm()
        {
            return new frmSelectCodeProjectType();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XCodeProjectTypeInfo projectTypeInfo = selectedModel as XCodeProjectTypeInfo;
            if (projectTypeInfo != null)
            {
                return projectTypeInfo.NameCN;
            }
            else
            {
                return string.Empty;
            }
        }

        protected override string GetValueMember(XModelBase selectedModel)
        {
            XCodeProjectTypeInfo projectTypeInfo = selectedModel as XCodeProjectTypeInfo;
            if (projectTypeInfo != null)
            {
                return projectTypeInfo.RID;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
