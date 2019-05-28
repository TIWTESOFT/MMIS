using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MMIS.UI.Common
{
    public partial class frmQueryBase : frmBase
    {
        public frmQueryBase()
        {
            InitializeComponent();
        }

        private string m_WhereCondition = string.Empty;

        public string WhereCondition
        {
            get { return this.m_WhereCondition; }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            m_WhereCondition = XQueryTool.GetQueryCondition(this);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
