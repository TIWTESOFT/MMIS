using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XSelectStandEquipmentEditBox : XSelectEditBox
    {
        protected override Common.frmListBase GetSelectForm()
        {
            return new frmSelectStandEquipment();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XStandEquipmentInfo info = selectedModel as XStandEquipmentInfo;
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
            XStandEquipmentInfo info = selectedModel as XStandEquipmentInfo;
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
