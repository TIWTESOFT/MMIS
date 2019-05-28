using MMIS.Helper;
using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMIS.UI.Common
{
    public partial class frmOfficeFilePreview : frmBase
    {
        private string m_FileName = null;

        public frmOfficeFilePreview(string fileName)
        {
            InitializeComponent();
            this.m_FileName = fileName;
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            base.FormLoadFunction(sender, e);

            this.Preview();
        }

        private void Preview()
        {
            try
            {
                this.fcWord.Open(m_FileName);
            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.Message);
                XErrorLogTool.WriteLog(ex.ToString());
            }
        }
    }
}
