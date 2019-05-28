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
    public partial class frmImagePreview : frmBase
    {
        private string m_FileName = string.Empty;

        public frmImagePreview(string fileName)
        {
            InitializeComponent();
            this.m_FileName = fileName;
            this.Preview();
        }

        private void Preview()
        {
            try
            {
                Image image = Image.FromFile(this.m_FileName);
                this.picFile.BackgroundImage = image;
            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.Message);
                XErrorLogTool.WriteLog(ex.ToString());
            }
        }

        private void frmImagePreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.picFile.BackgroundImage = null;
            this.picFile.Dispose();
            GC.Collect();
        }
    }
}
