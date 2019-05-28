using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XSelectCodeEquipmentCustTypeEditBox : XSelectEditBox
    {
        protected override Common.frmListBase GetSelectForm()
        {
            return new frmSelectCodeEquipmentCustType();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XCodeEquipmentCustTypeInfo info = selectedModel as XCodeEquipmentCustTypeInfo;
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
            XCodeEquipmentCustTypeInfo info = selectedModel as XCodeEquipmentCustTypeInfo;
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
