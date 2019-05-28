using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XSelectUsersEditBox : XSelectEditBox
    {
        protected override Common.frmListBase GetSelectForm()
        {
            return new frmSelectUser();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XUsersInfo usersInfo = selectedModel as XUsersInfo;
            if (usersInfo != null)
            {
                return usersInfo.RealName;
            }
            else
            {
                return string.Empty;
            }
        }

        protected override string GetValueMember(XModelBase selectedModel)
        {
            XUsersInfo usersInfo = selectedModel as XUsersInfo;
            if (usersInfo != null)
            {
                return usersInfo.RID;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
