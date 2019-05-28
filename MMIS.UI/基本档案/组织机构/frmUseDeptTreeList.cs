using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.UI
{
    public partial class frmUseDeptTreeList : frmTreeListEditBase
    {
        public frmUseDeptTreeList()
        {
            InitializeComponent();
        }

        protected override XBusinessBase InitBusiness()
        {
            return new XUseDeptBusiness();
        }

        protected override string GetModelText(XModelBase model)
        {
            XUseDeptInfo deptInfo = model as XUseDeptInfo;
            return deptInfo.DeptName;
        }

        protected override XModelBase InitNewModel()
        {
            return new XUseDeptInfo();
        }

        protected override void FillModelInfo()
        {
            XUseDeptInfo deptInfo = this.m_CurrentModel as XUseDeptInfo;
            if (string.IsNullOrEmpty(deptInfo.RID))
            {
                deptInfo.RID = Guid.NewGuid().ToString();
                deptInfo.ID = deptInfo.RID;
            }
            deptInfo.DeptName = this.txtDeptName.Text.Trim();
            deptInfo.Spell = this.txtSpell.Text.Trim();
            deptInfo.SpellHeader = this.txtSpellHeader.Text.Trim();
            deptInfo.Remark = this.txtRemark.Text.Trim();
            if (string.IsNullOrEmpty(deptInfo.ParentID))
            {
                deptInfo.ParentID = this.GetParentID();
            }
            deptInfo.IsUsed = this.chkIsUsed.Checked;
            deptInfo.NameNum = XHelper.GetInt(this.nebNameNum.Value);
        }

        protected override void FillEditControl(XModelBase modelBase)
        {
            XUseDeptInfo deptInfo = modelBase as XUseDeptInfo;

            this.txtDeptName.Text = deptInfo.DeptName;
            this.txtSpell.Text = deptInfo.Spell;
            this.txtSpellHeader.Text = deptInfo.SpellHeader;
            this.txtRemark.Text = deptInfo.Remark;
            this.chkIsUsed.Checked = deptInfo.IsUsed;
            this.nebNameNum.Value = deptInfo.NameNum;

        }

        private void txtDeptName_Leave(object sender, EventArgs e)
        {
            if (this.txtSpell.Text.Trim() == string.Empty)
            {
                this.txtSpell.Text = XSpellHelper.GetFullSpell(this.txtDeptName.Text.Trim());
            }
            if (this.txtSpellHeader.Text.Trim() == string.Empty)
            {
                this.txtSpellHeader.Text = XSpellHelper.GetSpellHeader(this.txtDeptName.Text.Trim());
            }
        }
    }
}
