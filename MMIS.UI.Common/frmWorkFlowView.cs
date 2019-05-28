using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;

namespace MMIS.UI.Common
{
    public partial class frmWorkFlowView : frmBase
    {
        protected XBusinessBase m_Business = null;
        protected string m_MainId = string.Empty;

        public frmWorkFlowView(XBusinessBase business, string mainId)
        {
            InitializeComponent();
            this.m_Business = business;
            this.m_MainId = mainId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmWorkFlowView_Load(object sender, EventArgs e)
        {
            this.InitWorkFlow();
        }

        protected virtual void InitWorkFlow()
        {
            if (this.m_Business != null)
            {
                this.grdData.DataSource = this.m_Business.ViewWorkFlow(this.m_MainId);
                this.grdData.AutoSizeColumns();
            }
        }
    }
}
