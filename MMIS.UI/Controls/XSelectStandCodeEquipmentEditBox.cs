using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using MMIS.Model;

namespace MMIS.UI
{
    public partial class XSelectStandCodeEquipmentEditBox : XSelectEditBox
    {
        protected override Common.frmListBase GetSelectForm()
        {
            return new frmSelectStandCodeEquipment();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XStandCodeEquipmentInfo info = selectedModel as XStandCodeEquipmentInfo;
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
            XStandCodeEquipmentInfo info = selectedModel as XStandCodeEquipmentInfo;
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
