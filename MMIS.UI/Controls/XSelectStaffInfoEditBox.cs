using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XSelectStaffInfoEditBox : XSelectEditBox
    {
        protected override Common.frmListBase GetSelectForm()
        {
            return new frmSelectStaffInfo();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XStaffInfoInfo staffInfo = selectedModel as XStaffInfoInfo;
            if (staffInfo != null)
            {
                return staffInfo.UserName;
            }
            else
            {
                return string.Empty;
            }
        }

        protected override string GetValueMember(XModelBase selectedModel)
        {
            XStaffInfoInfo staffInfo = selectedModel as XStaffInfoInfo;
            if (staffInfo != null)
            {
                return staffInfo.RID;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
