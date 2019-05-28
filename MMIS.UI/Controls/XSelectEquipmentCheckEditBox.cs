using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XSelectEquipmentCheckEditBox : XSelectEditBox
    {
        protected override Common.frmListBase GetSelectForm()
        {
            return new frmSelectEquipmentCheck();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XEquipmentCheckInfo info = selectedModel as XEquipmentCheckInfo;
            if (info != null)
            {
                return info.EquipmentName;
            }
            else
            {
                return string.Empty;
            }
        }

        protected override string GetValueMember(XModelBase selectedModel)
        {
            XEquipmentCheckInfo info = selectedModel as XEquipmentCheckInfo;
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
