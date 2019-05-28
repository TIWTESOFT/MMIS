using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XSelectEquipmentCustEditBox : XSelectEditBox
    {
        protected override Common.frmListBase GetSelectForm()
        {
            return new frmSelectEquipmentCust();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XEquipmentCustInfo info = selectedModel as XEquipmentCustInfo;
            if (info != null)
            {
                return info.CustName;
            }
            else
            {
                return string.Empty;
            }
        }

        protected override string GetValueMember(XModelBase selectedModel)
        {
            XEquipmentCustInfo info = selectedModel as XEquipmentCustInfo;
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
