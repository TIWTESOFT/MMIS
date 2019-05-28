using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XSelectStandEditBox : XSelectEditBox
    {
        protected override Common.frmListBase GetSelectForm()
        {
            return new frmSelectStand();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XStandardInfo info = selectedModel as XStandardInfo;
            if (info != null)
            {
                return info.StandName;
            }
            else
            {
                return string.Empty;
            }
        }

        protected override string GetValueMember(XModelBase selectedModel)
        {
            XStandardInfo info = selectedModel as XStandardInfo;
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
