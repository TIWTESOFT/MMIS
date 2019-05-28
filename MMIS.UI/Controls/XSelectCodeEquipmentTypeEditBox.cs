using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XSelectCodeEquipmentTypeEditBox : XSelectEditBox
    {
        protected override Common.frmListBase GetSelectForm()
        {
            return new frmSelectCodeEquipmentType();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XCodeEquipmentTypeInfo info = selectedModel as XCodeEquipmentTypeInfo;
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
            XCodeEquipmentTypeInfo info = selectedModel as XCodeEquipmentTypeInfo;
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
