using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using MMIS.Model;

namespace MMIS.UI
{
    public partial class XSelectUseDeptEditBox : XSelectEditBox
    {
        protected override Common.frmListBase GetSelectForm()
        {
            return new frmSelectUseDept();
        }

        protected override string GetDisplayMember(Model.XModelBase selectedModel)
        {
            XUseDeptInfo deptInfo = selectedModel as XUseDeptInfo;
            if (deptInfo != null)
            {
                return deptInfo.DeptName;
            }
            else
            {
                return string.Empty;
            }
        }

        protected override string GetValueMember(XModelBase selectedModel)
        {
            XUseDeptInfo useDeptInfo = selectedModel as XUseDeptInfo;
            if (useDeptInfo != null)
            {
                return useDeptInfo.RID;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
