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
using MMIS.Helper;
using Janus.Windows.GridEX;

namespace MMIS.UI
{
    public partial class frmCodeEquipmentStateList : frmListBase
    {
        public frmCodeEquipmentStateList()
        {
            InitializeComponent();
        }

        protected override XBusinessBase InitBusiness()
        {
            return new XCodeEquipmentStateBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmCodeEquipmentStateEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmCodeEquipmentStateEdit(this.m_CurrentModel);
        }

        protected override void FillGridBefore()
        {
            IList<string> colors = new List<string>();

            foreach (XModelBase model in this.m_CurrentList)
            {
                XCodeEquipmentStateInfo stateInfo = model as XCodeEquipmentStateInfo;

                GridEXFormatCondition condition = new GridEXFormatCondition();
                if (!colors.Contains(stateInfo.ColorRGB) && stateInfo.ColorRGB != "0,0,0")
                {
                    try
                    {
                        Color color = XColorHelper.GetColorFormStringRgb(stateInfo.ColorRGB);
                        condition.FormatStyle.BackColor = color;
                        condition.Column = this.grdData.RootTable.Columns["ColorRGB"];
                        condition.Value1 = stateInfo.ColorRGB;
                        this.grdData.RootTable.FormatConditions.Add(condition);

                        colors.Add(stateInfo.ColorRGB);
                    }
                    catch (Exception ex)
                    {
                        XErrorLogTool.WriteLog(ex.ToString());
                    }
                }
            }
        }

    }
}