using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.UI.Common;
using MMIS.Model;
using Janus.Windows.GridEX;
using MMIS.Helper;

namespace MMIS.UI
{
    public partial class frmEquipmentCheckList : frmListBase
    {
        private XCodeEquipmentStateBusiness m_EquipmentStateBusiness = new XCodeEquipmentStateBusiness();

        public frmEquipmentCheckList()
        {
            InitializeComponent();
        }

        protected override XBusinessBase InitBusiness()
        {
            return new XEquipmentCheckBusiness();
           // return new xv
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmEquipmentCheckEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmEquipmentCheckEdit(this.m_CurrentModel);
        }

        protected override bool IsQueryDataFromView
        {
            get
            {
                return true;
            }
        }

        protected override void FillGridBefore()
        {
            IList<XModelBase> stateList = this.m_EquipmentStateBusiness.GetAll();

            IList<string> colors = new List<string>();

            foreach (XModelBase model in stateList)
            {
                XCodeEquipmentStateInfo stateInfo = model as XCodeEquipmentStateInfo;

                GridEXFormatCondition condition = new GridEXFormatCondition();
                if (!colors.Contains(stateInfo.ColorRGB) && stateInfo.ColorRGB != "0,0,0")
                {
                    Color color = XColorHelper.GetColorFormStringRgb(stateInfo.ColorRGB);
                    condition.FormatStyle.BackColor = color;
                    condition.Column = this.grdData.RootTable.Columns["ColorRGB"];
                    condition.Value1 = stateInfo.ColorRGB;
                    if (condition.Column != null)
                    {
                        this.grdData.RootTable.FormatConditions.Add(condition);
                    }

                    colors.Add(stateInfo.ColorRGB);
                }
            }
        }
    }
}